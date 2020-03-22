<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WyszukiwarkaAutUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboxWybierzDB = New System.Windows.Forms.ComboBox()
        Me.picboxAuto = New System.Windows.Forms.PictureBox()
        Me.cboxKolor = New System.Windows.Forms.ComboBox()
        Me.cboxSilnik = New System.Windows.Forms.ComboBox()
        Me.cboxModel = New System.Windows.Forms.ComboBox()
        Me.cboxMarka = New System.Windows.Forms.ComboBox()
        Me.CboxOcenAuto = New System.Windows.Forms.ComboBox()
        Me.BtnOcenAuto = New System.Windows.Forms.Button()
        Me.TboxOcenaAuta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LboxTopModel = New System.Windows.Forms.ListBox()
        Me.BtnTop3Odswiez = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picboxAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxWybierzDB
        '
        Me.cboxWybierzDB.FormattingEnabled = True
        Me.cboxWybierzDB.Location = New System.Drawing.Point(715, 12)
        Me.cboxWybierzDB.Name = "cboxWybierzDB"
        Me.cboxWybierzDB.Size = New System.Drawing.Size(203, 24)
        Me.cboxWybierzDB.TabIndex = 11
        Me.cboxWybierzDB.Text = "Wybierz komis"
        '
        'picboxAuto
        '
        Me.picboxAuto.Location = New System.Drawing.Point(12, 12)
        Me.picboxAuto.Name = "picboxAuto"
        Me.picboxAuto.Size = New System.Drawing.Size(680, 336)
        Me.picboxAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxAuto.TabIndex = 10
        Me.picboxAuto.TabStop = False
        '
        'cboxKolor
        '
        Me.cboxKolor.FormattingEnabled = True
        Me.cboxKolor.Location = New System.Drawing.Point(395, 389)
        Me.cboxKolor.Name = "cboxKolor"
        Me.cboxKolor.Size = New System.Drawing.Size(121, 24)
        Me.cboxKolor.TabIndex = 9
        Me.cboxKolor.Text = "Wybierz kolor"
        '
        'cboxSilnik
        '
        Me.cboxSilnik.FormattingEnabled = True
        Me.cboxSilnik.Location = New System.Drawing.Point(268, 389)
        Me.cboxSilnik.Name = "cboxSilnik"
        Me.cboxSilnik.Size = New System.Drawing.Size(121, 24)
        Me.cboxSilnik.TabIndex = 8
        Me.cboxSilnik.Text = "Wybierz silnik"
        '
        'cboxModel
        '
        Me.cboxModel.FormattingEnabled = True
        Me.cboxModel.Location = New System.Drawing.Point(140, 389)
        Me.cboxModel.Name = "cboxModel"
        Me.cboxModel.Size = New System.Drawing.Size(121, 24)
        Me.cboxModel.TabIndex = 7
        Me.cboxModel.Text = "Wybierz model"
        '
        'cboxMarka
        '
        Me.cboxMarka.FormattingEnabled = True
        Me.cboxMarka.Location = New System.Drawing.Point(12, 389)
        Me.cboxMarka.Name = "cboxMarka"
        Me.cboxMarka.Size = New System.Drawing.Size(121, 24)
        Me.cboxMarka.TabIndex = 6
        Me.cboxMarka.Text = "Wybierz marke"
        '
        'CboxOcenAuto
        '
        Me.CboxOcenAuto.FormattingEnabled = True
        Me.CboxOcenAuto.Location = New System.Drawing.Point(715, 389)
        Me.CboxOcenAuto.Name = "CboxOcenAuto"
        Me.CboxOcenAuto.Size = New System.Drawing.Size(121, 24)
        Me.CboxOcenAuto.TabIndex = 12
        '
        'BtnOcenAuto
        '
        Me.BtnOcenAuto.Location = New System.Drawing.Point(843, 389)
        Me.BtnOcenAuto.Name = "BtnOcenAuto"
        Me.BtnOcenAuto.Size = New System.Drawing.Size(75, 23)
        Me.BtnOcenAuto.TabIndex = 13
        Me.BtnOcenAuto.Text = "Oceń"
        Me.BtnOcenAuto.UseVisualStyleBackColor = True
        '
        'TboxOcenaAuta
        '
        Me.TboxOcenaAuta.Location = New System.Drawing.Point(523, 389)
        Me.TboxOcenaAuta.Name = "TboxOcenaAuta"
        Me.TboxOcenaAuta.ReadOnly = True
        Me.TboxOcenaAuta.Size = New System.Drawing.Size(100, 22)
        Me.TboxOcenaAuta.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ocena auta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(712, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Oceń auto:"
        '
        'LboxTopModel
        '
        Me.LboxTopModel.FormattingEnabled = True
        Me.LboxTopModel.ItemHeight = 16
        Me.LboxTopModel.Location = New System.Drawing.Point(715, 123)
        Me.LboxTopModel.Name = "LboxTopModel"
        Me.LboxTopModel.Size = New System.Drawing.Size(203, 132)
        Me.LboxTopModel.TabIndex = 17
        '
        'BtnTop3Odswiez
        '
        Me.BtnTop3Odswiez.Location = New System.Drawing.Point(779, 261)
        Me.BtnTop3Odswiez.Name = "BtnTop3Odswiez"
        Me.BtnTop3Odswiez.Size = New System.Drawing.Size(75, 23)
        Me.BtnTop3Odswiez.TabIndex = 18
        Me.BtnTop3Odswiez.Text = "Odśwież"
        Me.BtnTop3Odswiez.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(715, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TOP 3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Zmień użytkownika"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WyszukiwarkaAutUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 491)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTop3Odswiez)
        Me.Controls.Add(Me.LboxTopModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TboxOcenaAuta)
        Me.Controls.Add(Me.BtnOcenAuto)
        Me.Controls.Add(Me.CboxOcenAuto)
        Me.Controls.Add(Me.cboxWybierzDB)
        Me.Controls.Add(Me.picboxAuto)
        Me.Controls.Add(Me.cboxKolor)
        Me.Controls.Add(Me.cboxSilnik)
        Me.Controls.Add(Me.cboxModel)
        Me.Controls.Add(Me.cboxMarka)
        Me.Name = "WyszukiwarkaAutUser"
        Me.Text = "Wyszukiwarka aut - USER"
        CType(Me.picboxAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxWybierzDB As ComboBox
    Friend WithEvents picboxAuto As PictureBox
    Friend WithEvents cboxKolor As ComboBox
    Friend WithEvents cboxSilnik As ComboBox
    Friend WithEvents cboxModel As ComboBox
    Friend WithEvents cboxMarka As ComboBox
    Friend WithEvents CboxOcenAuto As ComboBox
    Friend WithEvents BtnOcenAuto As Button
    Friend WithEvents TboxOcenaAuta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LboxTopModel As ListBox
    Friend WithEvents BtnTop3Odswiez As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
