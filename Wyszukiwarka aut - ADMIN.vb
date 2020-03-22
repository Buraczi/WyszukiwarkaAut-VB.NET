Imports System.Data.OleDb

Public Class WyszukiwarkaAutAdmin

    Dim con As New OleDbConnection 'połączenie z bazą'
    Dim constringAuta1 As String 'baza Komis 1'
    Dim constringAuta2 As String 'baza Komis 2
    Dim path As String = My.Application.Info.DirectoryPath 'ścieżka do apki - patrz "WypelnijZdjecie()" '
    Dim cmd As New OleDbCommand 'komenda SELECT z bazy'
    Dim cmdAdd As New OleDbCommand 'komenda INSERT do bazy'
    Dim dr As OleDbDataReader 'odczyt SELECTa'
    Dim drAdd As OleDbDataReader 'odczyt INSERTa'

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("Jestes zalogowany na koncie o uprawnieniach administratora")

        constringAuta1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|/DB_Auta_01.mdb"
        constringAuta2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|/DB_Auta_02.mdb"

        With cboxWybierzDB.Items
            .Add("Komis 1")
            .Add("Komis 2")
        End With

    End Sub

    Private Sub WypelnijMarka()

        cboxMarka.Items.Clear()

        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.Marka FROM tblAuta"
        End With

        dr = cmd.ExecuteReader

        While dr.Read
            cboxMarka.Items.Add(dr("Marka"))
        End While

    End Sub

    Private Sub WypelnijModel()

        Me.cboxModel.Items.Clear()

        Dim cmd1 As New OleDbCommand
        Dim dr1 As OleDbDataReader

        With cmd1
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.Model FROM tblAuta WHERE [Marka] = '" & Me.cboxMarka.Text & "'"
        End With

        dr1 = cmd1.ExecuteReader

        While dr1.Read
            cboxModel.Items.Add(dr1("Model"))
        End While

    End Sub

    Private Sub WypelnijSilnik()

        Me.cboxSilnik.Items.Clear()

        Dim cmd2 As New OleDbCommand
        Dim dr2 As OleDbDataReader

        With cmd2
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.Silnik FROM tblAuta WHERE [Marka] = '" & Me.cboxMarka.Text & "' AND [Model] = '" & Me.cboxModel.Text & "'"
        End With

        dr2 = cmd2.ExecuteReader

        While dr2.Read
            cboxSilnik.Items.Add(dr2("Silnik"))
        End While

    End Sub

    Private Sub WypelnijKolor()

        Me.cboxKolor.Items.Clear()

        Dim cmd3 As New OleDbCommand
        Dim dr3 As OleDbDataReader

        With cmd3
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.Kolor FROM tblAuta WHERE [Marka] = '" & Me.cboxMarka.Text & "' AND [Model] = '" & Me.cboxModel.Text & "' AND [Silnik] = '" & Me.cboxSilnik.Text & "'"
        End With

        dr3 = cmd3.ExecuteReader

        While dr3.Read
            cboxKolor.Items.Add(dr3("Kolor"))
        End While

    End Sub

    Private Sub WypelnijZdjecie()

        Dim cmd4 As New OleDbCommand
        Dim dr4 As OleDbDataReader

        With cmd4
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.Zdjecie FROM tblAuta WHERE [Marka] = '" & Me.cboxMarka.Text & "' AND [Model] = '" & Me.cboxModel.Text & "' AND [Silnik] = '" & Me.cboxSilnik.Text & "' AND [Kolor] = '" & Me.cboxKolor.Text & "'"
        End With

        dr4 = cmd4.ExecuteReader

        While dr4.Read
            picboxAuto.ImageLocation = path & dr4("Zdjecie")
        End While

    End Sub

    Private Sub CboxMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMarka.SelectedIndexChanged

        Me.cboxModel.Items.Clear()
        WypelnijModel()

    End Sub

    Private Sub CboxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxModel.SelectedIndexChanged

        Me.cboxSilnik.Items.Clear()
        WypelnijSilnik()

    End Sub

    Private Sub CboxSilnik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSilnik.SelectedIndexChanged

        Me.cboxKolor.Items.Clear()
        WypelnijKolor()

    End Sub

    Private Sub CboxKolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxKolor.SelectedIndexChanged

        WypelnijZdjecie()

    End Sub

    Private Sub CboxWybierzDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxWybierzDB.SelectedIndexChanged

        If cboxWybierzDB.SelectedItem = "Komis 1" Then

            con.Close()

            cboxMarka.Items.Clear()
            cboxModel.Items.Clear()
            cboxSilnik.Items.Clear()
            cboxKolor.Items.Clear()

            With con
                .ConnectionString = constringAuta1
                .Open()
            End With

            WypelnijMarka()

        ElseIf cboxWybierzDB.SelectedItem = "Komis 2" Then

            con.Close()

            cboxMarka.Items.Clear()
            cboxModel.Items.Clear()
            cboxSilnik.Items.Clear()
            cboxKolor.Items.Clear()

            With con
                .ConnectionString = constringAuta2
                .Open()
            End With

            WypelnijMarka()

        End If

    End Sub

    Private Sub ButtonDodajPozycje1_Click(sender As Object, e As EventArgs) Handles ButtonDodajPozycje1.Click
        'dodawanie pozycji do bazy'

        con.Close()

        con.Open()

        With cmdAdd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO tblAuta (Marka, Model, Silnik, Kolor) VALUES ('" & Me.TboxAddMarka.Text & "','" & Me.TboxAddModel.Text & "','" & Me.TboxAddSilnik.Text & "','" & Me.TboxAddKolor.Text & "')"
        End With

        drAdd = cmdAdd.ExecuteReader

        TboxAddMarka.Clear()
        TboxAddModel.Clear()
        TboxAddSilnik.Clear()
        TboxAddKolor.Clear()

        WypelnijMarka()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
