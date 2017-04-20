<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logginn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logginn))
        Me.TxtPersonnummer = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.btnGlemtpassord = New System.Windows.Forms.Button()
        Me.btnLogginn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Panel()
        Me.textheader = New System.Windows.Forms.PictureBox()
        Me.sidetoppanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnKontakt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNyBruker = New System.Windows.Forms.Button()
        Me.btnEgenerklæring = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        CType(Me.textheader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidetoppanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPersonnummer
        '
        Me.TxtPersonnummer.BackColor = System.Drawing.Color.White
        Me.TxtPersonnummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPersonnummer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPersonnummer.Location = New System.Drawing.Point(443, 207)
        Me.TxtPersonnummer.Name = "TxtPersonnummer"
        Me.TxtPersonnummer.Size = New System.Drawing.Size(122, 21)
        Me.TxtPersonnummer.TabIndex = 1
        Me.TxtPersonnummer.Text = "12345678910"
        '
        'txtPassord
        '
        Me.txtPassord.BackColor = System.Drawing.Color.White
        Me.txtPassord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassord.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(443, 259)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(122, 21)
        Me.txtPassord.TabIndex = 10
        Me.txtPassord.Text = "123456"
        '
        'btnGlemtpassord
        '
        Me.btnGlemtpassord.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGlemtpassord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGlemtpassord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGlemtpassord.FlatAppearance.BorderSize = 0
        Me.btnGlemtpassord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGlemtpassord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGlemtpassord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGlemtpassord.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlemtpassord.ForeColor = System.Drawing.Color.White
        Me.btnGlemtpassord.Location = New System.Drawing.Point(443, 370)
        Me.btnGlemtpassord.Name = "btnGlemtpassord"
        Me.btnGlemtpassord.Size = New System.Drawing.Size(122, 33)
        Me.btnGlemtpassord.TabIndex = 20
        Me.btnGlemtpassord.TabStop = False
        Me.btnGlemtpassord.Text = "Glemt passord?"
        Me.btnGlemtpassord.UseVisualStyleBackColor = False
        '
        'btnLogginn
        '
        Me.btnLogginn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnLogginn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogginn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLogginn.FlatAppearance.BorderSize = 0
        Me.btnLogginn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLogginn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLogginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogginn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogginn.ForeColor = System.Drawing.Color.White
        Me.btnLogginn.Location = New System.Drawing.Point(435, 330)
        Me.btnLogginn.Name = "btnLogginn"
        Me.btnLogginn.Size = New System.Drawing.Size(139, 33)
        Me.btnLogginn.TabIndex = 15
        Me.btnLogginn.TabStop = False
        Me.btnLogginn.Text = "Logg inn"
        Me.btnLogginn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Passord:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Personnummer/id:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(437, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Logg inn"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.header.Controls.Add(Me.textheader)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(172, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(628, 75)
        Me.header.TabIndex = 23
        '
        'textheader
        '
        Me.textheader.Image = Global.Aorta_DB.My.Resources.Resources.Logomakr_82u4uc
        Me.textheader.Location = New System.Drawing.Point(26, 24)
        Me.textheader.Name = "textheader"
        Me.textheader.Size = New System.Drawing.Size(554, 26)
        Me.textheader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.textheader.TabIndex = 0
        Me.textheader.TabStop = False
        '
        'sidetoppanel
        '
        Me.sidetoppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.sidetoppanel.Controls.Add(Me.logo)
        Me.sidetoppanel.Location = New System.Drawing.Point(0, 0)
        Me.sidetoppanel.Name = "sidetoppanel"
        Me.sidetoppanel.Size = New System.Drawing.Size(172, 75)
        Me.sidetoppanel.TabIndex = 22
        '
        'logo
        '
        Me.logo.Image = Global.Aorta_DB.My.Resources.Resources.Logomakr_2plwp5
        Me.logo.Location = New System.Drawing.Point(39, 24)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(89, 26)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.PictureBox7)
        Me.sidepanel.Controls.Add(Me.PictureBox6)
        Me.sidepanel.Controls.Add(Me.PictureBox5)
        Me.sidepanel.Controls.Add(Me.PictureBox4)
        Me.sidepanel.Controls.Add(Me.btnKontakt)
        Me.sidepanel.Controls.Add(Me.Button1)
        Me.sidepanel.Controls.Add(Me.btnNyBruker)
        Me.sidepanel.Controls.Add(Me.btnEgenerklæring)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(172, 600)
        Me.sidepanel.TabIndex = 21
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(147, 370)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 122
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(147, 285)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 121
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(147, 199)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 120
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(147, 114)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 119
        Me.PictureBox4.TabStop = False
        '
        'btnKontakt
        '
        Me.btnKontakt.BackColor = System.Drawing.Color.Transparent
        Me.btnKontakt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKontakt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKontakt.FlatAppearance.BorderSize = 0
        Me.btnKontakt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKontakt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKontakt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKontakt.ForeColor = System.Drawing.Color.White
        Me.btnKontakt.Location = New System.Drawing.Point(-3, 349)
        Me.btnKontakt.Name = "btnKontakt"
        Me.btnKontakt.Size = New System.Drawing.Size(195, 54)
        Me.btnKontakt.TabIndex = 8
        Me.btnKontakt.TabStop = False
        Me.btnKontakt.Text = "Kontakt oss"
        Me.btnKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKontakt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-3, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Logg inn"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnNyBruker
        '
        Me.btnNyBruker.BackColor = System.Drawing.Color.Transparent
        Me.btnNyBruker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNyBruker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyBruker.FlatAppearance.BorderSize = 0
        Me.btnNyBruker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyBruker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyBruker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNyBruker.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNyBruker.ForeColor = System.Drawing.Color.White
        Me.btnNyBruker.Location = New System.Drawing.Point(-3, 181)
        Me.btnNyBruker.Name = "btnNyBruker"
        Me.btnNyBruker.Size = New System.Drawing.Size(195, 54)
        Me.btnNyBruker.TabIndex = 7
        Me.btnNyBruker.TabStop = False
        Me.btnNyBruker.Text = "Registrer deg"
        Me.btnNyBruker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNyBruker.UseVisualStyleBackColor = False
        '
        'btnEgenerklæring
        '
        Me.btnEgenerklæring.BackColor = System.Drawing.Color.Transparent
        Me.btnEgenerklæring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEgenerklæring.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklæring.FlatAppearance.BorderSize = 0
        Me.btnEgenerklæring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklæring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklæring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEgenerklæring.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgenerklæring.ForeColor = System.Drawing.Color.White
        Me.btnEgenerklæring.Location = New System.Drawing.Point(-3, 263)
        Me.btnEgenerklæring.Name = "btnEgenerklæring"
        Me.btnEgenerklæring.Size = New System.Drawing.Size(195, 54)
        Me.btnEgenerklæring.TabIndex = 0
        Me.btnEgenerklæring.TabStop = False
        Me.btnEgenerklæring.Text = "Egenerklæring"
        Me.btnEgenerklæring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEgenerklæring.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(441, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 33)
        Me.Button2.TabIndex = 24
        Me.Button2.TabStop = False
        Me.Button2.Text = "Send nytt passord"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(441, 466)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 21)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Personnummer:"
        Me.Label4.Visible = False
        '
        'Logginn
        '
        Me.AcceptButton = Me.btnLogginn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidetoppanel)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogginn)
        Me.Controls.Add(Me.btnGlemtpassord)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.TxtPersonnummer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Logginn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logg inn"
        Me.header.ResumeLayout(False)
        CType(Me.textheader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidetoppanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPersonnummer As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents btnGlemtpassord As Button
    Friend WithEvents btnLogginn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents header As Panel
    Friend WithEvents textheader As PictureBox
    Friend WithEvents sidetoppanel As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents sidepanel As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnKontakt As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnNyBruker As Button
    Friend WithEvents btnEgenerklæring As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
