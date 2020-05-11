<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsatu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsatu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_data = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_daftar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 44)
        Me.Panel1.TabIndex = 0
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
        Me.btn_data.Location = New System.Drawing.Point(467, 385)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_data.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_data.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_data.selected = False
        Me.btn_data.Size = New System.Drawing.Size(250, 48)
        Me.btn_data.TabIndex = 6
        Me.btn_data.Text = "    Data Register"
        Me.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_data.Textcolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_data.TextFont = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_daftar.ButtonText = "Daftar"
        Me.btn_daftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_daftar.Font = New System.Drawing.Font("Britannic Bold", 15.75!)
        Me.btn_daftar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_daftar.IdleBorderThickness = 1
        Me.btn_daftar.IdleCornerRadius = 20
        Me.btn_daftar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_daftar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btn_daftar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_daftar.Location = New System.Drawing.Point(131, 385)
        Me.btn_daftar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(263, 65)
        Me.btn_daftar.TabIndex = 5
        Me.btn_daftar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Register_Kerja.My.Resources.Resources.TIGA
        Me.PictureBox2.Location = New System.Drawing.Point(467, 159)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 229)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Register_Kerja.My.Resources.Resources.sh
        Me.PictureBox1.Location = New System.Drawing.Point(131, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Register_Kerja.My.Resources.Resources.x
        Me.PictureBox3.Location = New System.Drawing.Point(817, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'frmsatu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(863, 555)
        Me.Controls.Add(Me.btn_data)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsatu"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_daftar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_data As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox3 As PictureBox
End Class
