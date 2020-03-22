<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CboxWybierzUzytkownika = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CboxWybierzUzytkownika
        '
        Me.CboxWybierzUzytkownika.FormattingEnabled = True
        Me.CboxWybierzUzytkownika.Location = New System.Drawing.Point(106, 110)
        Me.CboxWybierzUzytkownika.Name = "CboxWybierzUzytkownika"
        Me.CboxWybierzUzytkownika.Size = New System.Drawing.Size(194, 24)
        Me.CboxWybierzUzytkownika.TabIndex = 0
        Me.CboxWybierzUzytkownika.Text = "Wybierz uzytkownika"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nazwa uzytkownika"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(106, 141)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(194, 54)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Log in"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 286)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboxWybierzUzytkownika)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboxWybierzUzytkownika As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLogin As Button
End Class
