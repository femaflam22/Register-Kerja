<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmliat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmliat))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.pw = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_data = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_daftar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 44)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(776, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Register_Kerja.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(50, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(122, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Register Kerja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(143, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hanya untuk admin"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.HintForeColor = System.Drawing.Color.Gray
        Me.username.HintText = "Masukkan Username"
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.username.LineIdleColor = System.Drawing.Color.Gray
        Me.username.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.username.LineThickness = 2
        Me.username.Location = New System.Drawing.Point(457, 226)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(335, 37)
        Me.username.TabIndex = 7
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pw
        '
        Me.pw.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pw.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pw.HintForeColor = System.Drawing.Color.Gray
        Me.pw.HintText = "Masukkan Password"
        Me.pw.isPassword = True
        Me.pw.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.pw.LineIdleColor = System.Drawing.Color.Gray
        Me.pw.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.pw.LineThickness = 2
        Me.pw.Location = New System.Drawing.Point(457, 299)
        Me.pw.Margin = New System.Windows.Forms.Padding(4)
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(335, 37)
        Me.pw.TabIndex = 8
        Me.pw.Text = "Masukkan Username"
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(455, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lupa Password?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(710, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kirim Bantuan"
        '
        'btn_data
        '
        Me.btn_data.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_data.BorderRadius = 0
        Me.btn_data.ButtonText = "    Data Register"
        Me.btn_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_data.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_data.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_data.Iconimage = CType(resources.GetObject("btn_data.Iconimage"), System.Drawing.Image)
        Me.btn_data.Iconimage_right = Nothing
        Me.btn_data.Iconimage_right_Selected = Nothing
        Me.btn_data.Iconimage_Selected = Nothing
        Me.btn_data.IconMarginLeft = 0
        Me.btn_data.IconMarginRight = 0
        Me.btn_data.IconRightVisible = True
        Me.btn_data.IconRightZoom = 0R
        Me.btn_data.IconVisible = True
        Me.btn_data.IconZoom = 90.0R
        Me.btn_data.IsTab = False
        Me.btn_data.Location = New System.Drawing.Point(744, 570)
        Me.btn_data.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_data.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_data.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_data.selected = False
        Me.btn_data.Size = New System.Drawing.Size(375, 70)
        Me.btn_data.TabIndex = 11
        Me.btn_data.Text = "    Data Register"
        Me.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_data.Textcolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_data.TextFont = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Login"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(994, 763)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(482, 92)
        Me.BunifuFlatButton1.TabIndex = 12
        Me.BunifuFlatButton1.Text = "Login"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_daftar
        '
        Me.btn_daftar.ActiveBorderThickness = 1
        Me.btn_daftar.ActiveCornerRadius = 20
        Me.btn_daftar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_daftar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_daftar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_daftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_daftar.BackgroundImage = CType(resources.GetObject("btn_daftar.BackgroundImage"), System.Drawing.Image)
        Me.btn_daftar.ButtonText = "Login"
        Me.btn_daftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_daftar.Font = New System.Drawing.Font("Britannic Bold", 15.75!)
        Me.btn_daftar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn_daftar.IdleBorderThickness = 1
        Me.btn_daftar.IdleCornerRadius = 20
        Me.btn_daftar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_daftar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn_daftar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_daftar.Location = New System.Drawing.Point(492, 390)
        Me.btn_daftar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(263, 46)
        Me.btn_daftar.TabIndex = 13
        Me.btn_daftar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmliat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(863, 555)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.btn_data)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmliat"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents pw As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_data As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_daftar As Bunifu.Framework.UI.BunifuThinButton2
End Class
