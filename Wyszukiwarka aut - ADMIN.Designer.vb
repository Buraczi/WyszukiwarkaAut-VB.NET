<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WyszukiwarkaAutAdmin
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
        Me.cboxMarka = New System.Windows.Forms.ComboBox()
        Me.cboxModel = New System.Windows.Forms.ComboBox()
        Me.cboxSilnik = New System.Windows.Forms.ComboBox()
        Me.cboxKolor = New System.Windows.Forms.ComboBox()
        Me.picboxAuto = New System.Windows.Forms.PictureBox()
        Me.cboxWybierzDB = New System.Windows.Forms.ComboBox()
        Me.ButtonDodajPozycje1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TboxAddModel = New System.Windows.Forms.TextBox()
        Me.TboxAddMarka = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TboxAddSilnik = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TboxAddKolor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picboxAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxMarka
        '
        Me.cboxMarka.FormattingEnabled = True
        Me.cboxMarka.Location = New System.Drawing.Point(6, 204)
        Me.cboxMarka.Name = "cboxMarka"
        Me.cboxMarka.Size = New System.Drawing.Size(121, 24)
        Me.cboxMarka.TabIndex = 0
        Me.cboxMarka.Text = "Wybierz marke"
        '
        'cboxModel
        '
        Me.cboxModel.FormattingEnabled = True
        Me.cboxModel.Location = New System.Drawing.Point(134, 204)
        Me.cboxModel.Name = "cboxModel"
        Me.cboxModel.Size = New System.Drawing.Size(121, 24)
        Me.cboxModel.TabIndex = 1
        Me.cboxModel.Text = "Wybierz model"
        '
        'cboxSilnik
        '
        Me.cboxSilnik.FormattingEnabled = True
        Me.cboxSilnik.Location = New System.Drawing.Point(262, 204)
        Me.cboxSilnik.Name = "cboxSilnik"
        Me.cboxSilnik.Size = New System.Drawing.Size(121, 24)
        Me.cboxSilnik.TabIndex = 2
        Me.cboxSilnik.Text = "Wybierz silnik"
        '
        'cboxKolor
        '
        Me.cboxKolor.FormattingEnabled = True
        Me.cboxKolor.Location = New System.Drawing.Point(389, 204)
        Me.cboxKolor.Name = "cboxKolor"
        Me.cboxKolor.Size = New System.Drawing.Size(121, 24)
        Me.cboxKolor.TabIndex = 3
        Me.cboxKolor.Text = "Wybierz kolor"
        '
        'picboxAuto
        '
        Me.picboxAuto.Location = New System.Drawing.Point(20, 13)
        Me.picboxAuto.Name = "picboxAuto"
        Me.picboxAuto.Size = New System.Drawing.Size(445, 185)
        Me.picboxAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxAuto.TabIndex = 4
        Me.picboxAuto.TabStop = False
        '
        'cboxWybierzDB
        '
        Me.cboxWybierzDB.FormattingEnabled = True
        Me.cboxWybierzDB.Location = New System.Drawing.Point(511, 13)
        Me.cboxWybierzDB.Name = "cboxWybierzDB"
        Me.cboxWybierzDB.Size = New System.Drawing.Size(203, 24)
        Me.cboxWybierzDB.TabIndex = 5
        Me.cboxWybierzDB.Text = "Wybierz komis"
        '
        'ButtonDodajPozycje1
        '
        Me.ButtonDodajPozycje1.Location = New System.Drawing.Point(476, 305)
        Me.ButtonDodajPozycje1.Name = "ButtonDodajPozycje1"
        Me.ButtonDodajPozycje1.Size = New System.Drawing.Size(126, 42)
        Me.ButtonDodajPozycje1.TabIndex = 6
        Me.ButtonDodajPozycje1.Text = "Dodaj do DB"
        Me.ButtonDodajPozycje1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DODAJ POZYCJE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Model"
        '
        'TboxAddModel
        '
        Me.TboxAddModel.Location = New System.Drawing.Point(129, 325)
        Me.TboxAddModel.Name = "TboxAddModel"
        Me.TboxAddModel.Size = New System.Drawing.Size(100, 22)
        Me.TboxAddModel.TabIndex = 9
        '
        'TboxAddMarka
        '
        Me.TboxAddMarka.Location = New System.Drawing.Point(20, 325)
        Me.TboxAddMarka.Name = "TboxAddMarka"
        Me.TboxAddMarka.Size = New System.Drawing.Size(100, 22)
        Me.TboxAddMarka.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Marka"
        '
        'TboxAddSilnik
        '
        Me.TboxAddSilnik.Location = New System.Drawing.Point(238, 325)
        Me.TboxAddSilnik.Name = "TboxAddSilnik"
        Me.TboxAddSilnik.Size = New System.Drawing.Size(100, 22)
        Me.TboxAddSilnik.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Silnik"
        '
        'TboxAddKolor
        '
        Me.TboxAddKolor.Location = New System.Drawing.Point(347, 325)
        Me.TboxAddKolor.Name = "TboxAddKolor"
        Me.TboxAddKolor.Size = New System.Drawing.Size(100, 22)
        Me.TboxAddKolor.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Kolor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Zmień użytkownika"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WyszukiwarkaAutAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 426)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TboxAddKolor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TboxAddSilnik)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TboxAddMarka)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TboxAddModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonDodajPozycje1)
        Me.Controls.Add(Me.cboxWybierzDB)
        Me.Controls.Add(Me.picboxAuto)
        Me.Controls.Add(Me.cboxKolor)
        Me.Controls.Add(Me.cboxSilnik)
        Me.Controls.Add(Me.cboxModel)
        Me.Controls.Add(Me.cboxMarka)
        Me.Name = "WyszukiwarkaAutAdmin"
        Me.Text = "Wyszukiwarka aut - ADMIN"
        CType(Me.picboxAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxMarka As ComboBox
    Friend WithEvents cboxModel As ComboBox
    Friend WithEvents cboxSilnik As ComboBox
    Friend WithEvents cboxKolor As ComboBox
    Friend WithEvents picboxAuto As PictureBox
    Friend WithEvents cboxWybierzDB As ComboBox
    Friend WithEvents ButtonDodajPozycje1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TboxAddModel As TextBox
    Friend WithEvents TboxAddMarka As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TboxAddSilnik As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TboxAddKolor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
