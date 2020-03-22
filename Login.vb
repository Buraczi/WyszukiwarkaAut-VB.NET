Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With CboxWybierzUzytkownika.Items
            .Add(My.Settings.AdminUser)
            .Add(My.Settings.RegularUser)
        End With

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        If CboxWybierzUzytkownika.Text = My.Settings.AdminUser Then
            Call AdminUser()
        ElseIf CboxWybierzUzytkownika.Text = My.Settings.RegularUser Then
            Call RegularUser()
        End If

    End Sub

    Private Sub AdminUser()

        WyszukiwarkaAutAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub RegularUser()

        WyszukiwarkaAutUser.Show()
        Me.Hide()

    End Sub

End Class