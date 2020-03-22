Imports System.Data.OleDb

Public Class WyszukiwarkaAutUser

    Dim con As New OleDbConnection
    Dim constringAuta1 As String 'baza Komis 1'
    Dim constringAuta2 As String 'baza Komis 2
    ReadOnly path As String = My.Application.Info.DirectoryPath 'ścieżka do apki - patrz "WypelnijZdjecie()" '
    Dim cmd As New OleDbCommand
    Dim cmdAddOcena As New OleDbCommand ' komenda dodania/zmiany oceny auta
    Dim cmdTopList As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim drAddOcena As OleDbDataReader 'czytanie komendy dodania/zmiany oceny auta
    Dim drTopList As OleDbDataReader
    Dim AutoID As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("Jestes zalogowany na koncie uzytkownika")

        constringAuta1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|/DB_Auta_01.mdb"
        constringAuta2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|/DB_Auta_02.mdb"

        With cboxWybierzDB.Items
            .Add("Komis 1")
            .Add("Komis 2")
        End With

        For i = 1 To 10
            CboxOcenAuto.Items.Add(i)
        Next

        'wyszażanie przycisku odśwież TOP 3 - wybierz Komis żeby odblokować
        BtnTop3Odswiez.Enabled = False

    End Sub

    Private Sub WypelnijMarka()

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

    Private Sub WypelnijOceneAut()
        Dim cmd5 As New OleDbCommand
        Dim dr5 As OleDbDataReader

        With cmd5
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.OcenaAuta FROM tblAuta WHERE [Marka] = '" & Me.cboxMarka.Text & "' AND [Model] = '" & Me.cboxModel.Text & "' AND [Silnik] = '" & Me.cboxSilnik.Text & "' AND [Kolor] = '" & Me.cboxKolor.Text & "'"
        End With

        dr5 = cmd5.ExecuteReader

        While dr5.Read
            TboxOcenaAuta.Text = dr5("OcenaAuta")
        End While
    End Sub

    Private Sub PodajID()
        Dim cmd6 As New OleDbCommand
        Dim dr6 As OleDbDataReader

        With cmd6
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT tblAuta.ID FROM tblAuta WHERE [Marka] = '" & Me.cboxMarka.Text & "' AND [Model] = '" & Me.cboxModel.Text & "' AND [Silnik] = '" & Me.cboxSilnik.Text & "' AND [Kolor] = '" & Me.cboxKolor.Text & "'"
        End With

        dr6 = cmd6.ExecuteReader

        While dr6.Read
            AutoID = dr6("ID")
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
        WypelnijOceneAut()
        PodajID()

    End Sub

    Private Sub CboxWybierzDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxWybierzDB.SelectedIndexChanged
        'wybór bazy danych

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

        If cboxWybierzDB.SelectedItem = "Komis 1" Then
            BtnTop3Odswiez.Enabled = True
        ElseIf cboxWybierzDB.SelectedItem = "Komis 2" Then
            BtnTop3Odswiez.Enabled = True
        Else
            BtnTop3Odswiez.Enabled = False
        End If
    End Sub

    Private Sub PokazTOP3()
        con.Close()

        con.Open()

        With cmdTopList
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "SELECT TOP 3 Marka, Model FROM tblAuta ORDER BY OcenaAuta DESC"


        End With

        drTopList = cmdTopList.ExecuteReader
        While drTopList.Read
            LboxTopModel.Items.Add(drTopList("Marka"))
        End While
    End Sub

    Private Sub BtnOcenAuto_Click(sender As Object, e As EventArgs) Handles BtnOcenAuto.Click
        'update oceny auta

        con.Close()

        con.Open()

        With cmdAddOcena
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE 
                                tblAuta 
                            SET 
                                OcenaAuta = " & CboxOcenAuto.Text & " 
                            WHERE 
                                ID = " & AutoID & " "


        End With

        drAddOcena = cmdAddOcena.ExecuteReader

        cboxMarka.Items.Clear()
        cboxModel.Items.Clear()
        cboxSilnik.Items.Clear()
        cboxKolor.Items.Clear()

        WypelnijMarka()
    End Sub


    Private Sub BtnTop3Odswiez_Click(sender As Object, e As EventArgs) Handles BtnTop3Odswiez.Click

        LboxTopModel.Items.Clear()
        PokazTOP3()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class