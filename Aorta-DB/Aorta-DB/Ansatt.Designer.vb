<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ansatt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ansatt))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblSok = New System.Windows.Forms.Label()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.listGivninger = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.headerpanel = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.lblAnsatt = New System.Windows.Forms.Label()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAvbestill2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sidetoppanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnKontakt = New System.Windows.Forms.Button()
        Me.btnMinSide = New System.Windows.Forms.Button()
        Me.btnEgenerklaring = New System.Windows.Forms.Button()
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGivninger = New System.Windows.Forms.Button()
        Me.headerpanel.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidetoppanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(178, 92)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(45, 22)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Info"
        '
        'lblSok
        '
        Me.lblSok.AutoSize = True
        Me.lblSok.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblSok.Location = New System.Drawing.Point(439, 92)
        Me.lblSok.Name = "lblSok"
        Me.lblSok.Size = New System.Drawing.Size(164, 21)
        Me.lblSok.TabIndex = 3
        Me.lblSok.Text = "Søk på en blodgiver"
        '
        'txtSok
        '
        Me.txtSok.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSok.Location = New System.Drawing.Point(452, 117)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(211, 21)
        Me.txtSok.TabIndex = 4
        Me.txtSok.Text = "Skriv inn personnummer"
        '
        'btnSok
        '
        Me.btnSok.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSok.FlatAppearance.BorderSize = 0
        Me.btnSok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSok.ForeColor = System.Drawing.Color.White
        Me.btnSok.Location = New System.Drawing.Point(669, 117)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(99, 21)
        Me.btnSok.TabIndex = 5
        Me.btnSok.Text = "Søk"
        Me.btnSok.UseVisualStyleBackColor = False
        '
        'listGivninger
        '
        Me.listGivninger.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listGivninger.FormattingEnabled = True
        Me.listGivninger.ItemHeight = 17
        Me.listGivninger.Location = New System.Drawing.Point(452, 297)
        Me.listGivninger.Name = "listGivninger"
        Me.listGivninger.Size = New System.Drawing.Size(298, 174)
        Me.listGivninger.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 82)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Årlig slutter mellom 15.000 og 17.000 å gi blod pga. høy alder, flytting eller an" &
    "net. Disse må erstattes og det er her du kommer inn."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(447, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Blodtappingstimer i dag"
        '
        'headerpanel
        '
        Me.headerpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.headerpanel.Controls.Add(Me.PictureBox6)
        Me.headerpanel.Controls.Add(Me.btnLoggUt)
        Me.headerpanel.Controls.Add(Me.lblAnsatt)
        Me.headerpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerpanel.Location = New System.Drawing.Point(172, 0)
        Me.headerpanel.Name = "headerpanel"
        Me.headerpanel.Size = New System.Drawing.Size(612, 75)
        Me.headerpanel.TabIndex = 119
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(6, 24)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 119
        Me.PictureBox6.TabStop = False
        '
        'btnLoggUt
        '
        Me.btnLoggUt.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoggUt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.FlatAppearance.BorderSize = 0
        Me.btnLoggUt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoggUt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoggUt.ForeColor = System.Drawing.Color.White
        Me.btnLoggUt.Location = New System.Drawing.Point(501, 19)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(99, 31)
        Me.btnLoggUt.TabIndex = 6
        Me.btnLoggUt.TabStop = False
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = False
        '
        'lblAnsatt
        '
        Me.lblAnsatt.AutoSize = True
        Me.lblAnsatt.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsatt.ForeColor = System.Drawing.Color.White
        Me.lblAnsatt.Location = New System.Drawing.Point(52, 31)
        Me.lblAnsatt.Name = "lblAnsatt"
        Me.lblAnsatt.Size = New System.Drawing.Size(98, 33)
        Me.lblAnsatt.TabIndex = 0
        Me.lblAnsatt.Text = "Ansatt"
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.PictureBox5)
        Me.sidepanel.Controls.Add(Me.GroupBox5)
        Me.sidepanel.Controls.Add(Me.Panel9)
        Me.sidepanel.Controls.Add(Me.PictureBox4)
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Controls.Add(Me.Panel2)
        Me.sidepanel.Controls.Add(Me.PictureBox3)
        Me.sidepanel.Controls.Add(Me.PictureBox1)
        Me.sidepanel.Controls.Add(Me.btnAvbestill2)
        Me.sidepanel.Controls.Add(Me.PictureBox2)
        Me.sidepanel.Controls.Add(Me.sidetoppanel)
        Me.sidepanel.Controls.Add(Me.btnKontakt)
        Me.sidepanel.Controls.Add(Me.btnMinSide)
        Me.sidepanel.Controls.Add(Me.btnEgenerklaring)
        Me.sidepanel.Controls.Add(Me.btnBestill)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(172, 561)
        Me.sidepanel.TabIndex = 118
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(146, 446)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 121
        Me.PictureBox5.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(172, 200)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(646, 46)
        Me.GroupBox5.TabIndex = 117
        Me.GroupBox5.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(172, 437)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(612, 27)
        Me.Panel9.TabIndex = 110
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(146, 365)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 120
        Me.PictureBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(172, 439)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 28)
        Me.Panel1.TabIndex = 109
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(172, 365)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 39)
        Me.Panel2.TabIndex = 105
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(146, 200)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 119
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 278)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnAvbestill2
        '
        Me.btnAvbestill2.BackColor = System.Drawing.Color.Transparent
        Me.btnAvbestill2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvbestill2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAvbestill2.FlatAppearance.BorderSize = 0
        Me.btnAvbestill2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAvbestill2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAvbestill2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvbestill2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvbestill2.ForeColor = System.Drawing.Color.White
        Me.btnAvbestill2.Location = New System.Drawing.Point(0, 347)
        Me.btnAvbestill2.Name = "btnAvbestill2"
        Me.btnAvbestill2.Size = New System.Drawing.Size(172, 54)
        Me.btnAvbestill2.TabIndex = 18
        Me.btnAvbestill2.TabStop = False
        Me.btnAvbestill2.Text = "Avbestill time"
        Me.btnAvbestill2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbestill2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(149, 115)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 118
        Me.PictureBox2.TabStop = False
        '
        'sidetoppanel
        '
        Me.sidetoppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.sidetoppanel.Controls.Add(Me.logo)
        Me.sidetoppanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.sidetoppanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.sidetoppanel.Location = New System.Drawing.Point(0, 0)
        Me.sidetoppanel.Name = "sidetoppanel"
        Me.sidetoppanel.Size = New System.Drawing.Size(172, 75)
        Me.sidetoppanel.TabIndex = 17
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
        Me.btnKontakt.Location = New System.Drawing.Point(0, 426)
        Me.btnKontakt.Name = "btnKontakt"
        Me.btnKontakt.Size = New System.Drawing.Size(172, 54)
        Me.btnKontakt.TabIndex = 8
        Me.btnKontakt.TabStop = False
        Me.btnKontakt.Text = "Kontakt oss"
        Me.btnKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKontakt.UseVisualStyleBackColor = False
        '
        'btnMinSide
        '
        Me.btnMinSide.BackColor = System.Drawing.Color.Transparent
        Me.btnMinSide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinSide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMinSide.FlatAppearance.BorderSize = 0
        Me.btnMinSide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMinSide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMinSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinSide.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinSide.ForeColor = System.Drawing.Color.White
        Me.btnMinSide.Location = New System.Drawing.Point(0, 99)
        Me.btnMinSide.Name = "btnMinSide"
        Me.btnMinSide.Size = New System.Drawing.Size(172, 54)
        Me.btnMinSide.TabIndex = 0
        Me.btnMinSide.TabStop = False
        Me.btnMinSide.Text = "Min side"
        Me.btnMinSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMinSide.UseVisualStyleBackColor = False
        '
        'btnEgenerklaring
        '
        Me.btnEgenerklaring.BackColor = System.Drawing.Color.Transparent
        Me.btnEgenerklaring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEgenerklaring.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklaring.FlatAppearance.BorderSize = 0
        Me.btnEgenerklaring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklaring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklaring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEgenerklaring.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgenerklaring.ForeColor = System.Drawing.Color.White
        Me.btnEgenerklaring.Location = New System.Drawing.Point(0, 184)
        Me.btnEgenerklaring.Name = "btnEgenerklaring"
        Me.btnEgenerklaring.Size = New System.Drawing.Size(172, 54)
        Me.btnEgenerklaring.TabIndex = 7
        Me.btnEgenerklaring.TabStop = False
        Me.btnEgenerklaring.Text = "Egenerklæring"
        Me.btnEgenerklaring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEgenerklaring.UseVisualStyleBackColor = False
        '
        'btnBestill
        '
        Me.btnBestill.BackColor = System.Drawing.Color.Transparent
        Me.btnBestill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBestill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnBestill.FlatAppearance.BorderSize = 0
        Me.btnBestill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnBestill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnBestill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestill.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestill.ForeColor = System.Drawing.Color.White
        Me.btnBestill.Location = New System.Drawing.Point(0, 261)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(172, 54)
        Me.btnBestill.TabIndex = 0
        Me.btnBestill.TabStop = False
        Me.btnBestill.Text = "Bestill time"
        Me.btnBestill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestill.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(192, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 65)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Bestill Blod"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnGivninger
        '
        Me.btnGivninger.BackColor = System.Drawing.Color.White
        Me.btnGivninger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGivninger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGivninger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnGivninger.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGivninger.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGivninger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGivninger.Location = New System.Drawing.Point(586, 484)
        Me.btnGivninger.Name = "btnGivninger"
        Me.btnGivninger.Size = New System.Drawing.Size(165, 65)
        Me.btnGivninger.TabIndex = 120
        Me.btnGivninger.Text = "Kalender"
        Me.btnGivninger.UseVisualStyleBackColor = False
        '
        'Ansatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnGivninger)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.headerpanel)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.txtSok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listGivninger)
        Me.Controls.Add(Me.lblSok)
        Me.Controls.Add(Me.lblInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ansatt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ansatt"
        Me.headerpanel.ResumeLayout(False)
        Me.headerpanel.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidetoppanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblSok As Label
    Friend WithEvents txtSok As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents listGivninger As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents headerpanel As Panel
    Friend WithEvents lblAnsatt As Label
    Friend WithEvents sidepanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAvbestill2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents sidetoppanel As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents btnKontakt As Button
    Friend WithEvents btnMinSide As Button
    Friend WithEvents btnEgenerklaring As Button
    Friend WithEvents btnBestill As Button
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGivninger As Button
    Friend WithEvents PictureBox6 As PictureBox
End Class
