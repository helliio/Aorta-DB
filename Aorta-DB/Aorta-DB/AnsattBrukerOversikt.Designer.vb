﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsattBrukerOversikt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattBrukerOversikt))
        Me.lblBruker = New System.Windows.Forms.Label()
        Me.lblNesteTime = New System.Windows.Forms.Label()
        Me.lblNesteGivning = New System.Windows.Forms.Label()
        Me.listboxGivinger = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listboxInfo = New System.Windows.Forms.ListBox()
        Me.btnAvbestill = New System.Windows.Forms.Button()
        Me.btnBestillTime = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnNyGivning = New System.Windows.Forms.Button()
        Me.btnFørstegangsInfo = New System.Windows.Forms.Button()
        Me.headerpanel = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.lblAnsatt = New System.Windows.Forms.Label()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStatestikk = New System.Windows.Forms.Button()
        Me.btnSjekkBlod = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sidetoppanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnMinSide = New System.Windows.Forms.Button()
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.btnKalender = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.headerpanel.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidetoppanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBruker
        '
        Me.lblBruker.AutoSize = True
        Me.lblBruker.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBruker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblBruker.Location = New System.Drawing.Point(178, 82)
        Me.lblBruker.Name = "lblBruker"
        Me.lblBruker.Size = New System.Drawing.Size(146, 24)
        Me.lblBruker.TabIndex = 0
        Me.lblBruker.Text = "Donør: Bruker"
        '
        'lblNesteTime
        '
        Me.lblNesteTime.AutoSize = True
        Me.lblNesteTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNesteTime.Location = New System.Drawing.Point(262, 145)
        Me.lblNesteTime.Name = "lblNesteTime"
        Me.lblNesteTime.Size = New System.Drawing.Size(0, 21)
        Me.lblNesteTime.TabIndex = 11
        '
        'lblNesteGivning
        '
        Me.lblNesteGivning.AutoSize = True
        Me.lblNesteGivning.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNesteGivning.Location = New System.Drawing.Point(184, 114)
        Me.lblNesteGivning.Name = "lblNesteGivning"
        Me.lblNesteGivning.Size = New System.Drawing.Size(98, 21)
        Me.lblNesteGivning.TabIndex = 10
        Me.lblNesteGivning.Text = "Neste time:"
        '
        'listboxGivinger
        '
        Me.listboxGivinger.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxGivinger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.listboxGivinger.FormattingEnabled = True
        Me.listboxGivinger.ItemHeight = 21
        Me.listboxGivinger.Location = New System.Drawing.Point(200, 243)
        Me.listboxGivinger.Name = "listboxGivinger"
        Me.listboxGivinger.Size = New System.Drawing.Size(251, 130)
        Me.listboxGivinger.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(184, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Siste blodtappinger"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(184, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Info om blodgiver"
        '
        'listboxInfo
        '
        Me.listboxInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.listboxInfo.FormattingEnabled = True
        Me.listboxInfo.ItemHeight = 21
        Me.listboxInfo.Location = New System.Drawing.Point(200, 421)
        Me.listboxInfo.Name = "listboxInfo"
        Me.listboxInfo.Size = New System.Drawing.Size(251, 130)
        Me.listboxInfo.TabIndex = 13
        '
        'btnAvbestill
        '
        Me.btnAvbestill.BackColor = System.Drawing.Color.White
        Me.btnAvbestill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvbestill.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvbestill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAvbestill.Location = New System.Drawing.Point(636, 463)
        Me.btnAvbestill.Name = "btnAvbestill"
        Me.btnAvbestill.Size = New System.Drawing.Size(131, 88)
        Me.btnAvbestill.TabIndex = 15
        Me.btnAvbestill.Text = "Avbestill time"
        Me.btnAvbestill.UseVisualStyleBackColor = False
        '
        'btnBestillTime
        '
        Me.btnBestillTime.BackColor = System.Drawing.Color.White
        Me.btnBestillTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestillTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestillTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnBestillTime.Location = New System.Drawing.Point(477, 347)
        Me.btnBestillTime.Name = "btnBestillTime"
        Me.btnBestillTime.Size = New System.Drawing.Size(131, 88)
        Me.btnBestillTime.TabIndex = 14
        Me.btnBestillTime.Text = "Bestill time"
        Me.btnBestillTime.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.White
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnInfo.Location = New System.Drawing.Point(477, 463)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(131, 88)
        Me.btnInfo.TabIndex = 17
        Me.btnInfo.Text = "Time info"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnNyGivning
        '
        Me.btnNyGivning.BackColor = System.Drawing.Color.White
        Me.btnNyGivning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNyGivning.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNyGivning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnNyGivning.Location = New System.Drawing.Point(477, 243)
        Me.btnNyGivning.Name = "btnNyGivning"
        Me.btnNyGivning.Size = New System.Drawing.Size(290, 88)
        Me.btnNyGivning.TabIndex = 18
        Me.btnNyGivning.Text = "Registrer ny blodtapping"
        Me.btnNyGivning.UseVisualStyleBackColor = False
        '
        'btnFørstegangsInfo
        '
        Me.btnFørstegangsInfo.BackColor = System.Drawing.Color.White
        Me.btnFørstegangsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFørstegangsInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFørstegangsInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnFørstegangsInfo.Location = New System.Drawing.Point(636, 347)
        Me.btnFørstegangsInfo.Name = "btnFørstegangsInfo"
        Me.btnFørstegangsInfo.Size = New System.Drawing.Size(131, 88)
        Me.btnFørstegangsInfo.TabIndex = 19
        Me.btnFørstegangsInfo.Text = "Helsesjekk"
        Me.btnFørstegangsInfo.UseVisualStyleBackColor = False
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
        Me.headerpanel.Size = New System.Drawing.Size(628, 75)
        Me.headerpanel.TabIndex = 121
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
        Me.lblAnsatt.Size = New System.Drawing.Size(203, 33)
        Me.lblAnsatt.TabIndex = 0
        Me.lblAnsatt.Text = "Bruker oversikt"
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.PictureBox3)
        Me.sidepanel.Controls.Add(Me.PictureBox7)
        Me.sidepanel.Controls.Add(Me.PictureBox1)
        Me.sidepanel.Controls.Add(Me.PictureBox5)
        Me.sidepanel.Controls.Add(Me.GroupBox5)
        Me.sidepanel.Controls.Add(Me.Panel9)
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Controls.Add(Me.Panel2)
        Me.sidepanel.Controls.Add(Me.btnStatestikk)
        Me.sidepanel.Controls.Add(Me.btnSjekkBlod)
        Me.sidepanel.Controls.Add(Me.PictureBox2)
        Me.sidepanel.Controls.Add(Me.sidetoppanel)
        Me.sidepanel.Controls.Add(Me.btnMinSide)
        Me.sidepanel.Controls.Add(Me.btnBestill)
        Me.sidepanel.Controls.Add(Me.btnKalender)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(172, 600)
        Me.sidepanel.TabIndex = 120
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
        'btnStatestikk
        '
        Me.btnStatestikk.BackColor = System.Drawing.Color.Transparent
        Me.btnStatestikk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatestikk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnStatestikk.FlatAppearance.BorderSize = 0
        Me.btnStatestikk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnStatestikk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnStatestikk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatestikk.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatestikk.ForeColor = System.Drawing.Color.White
        Me.btnStatestikk.Location = New System.Drawing.Point(0, 428)
        Me.btnStatestikk.Name = "btnStatestikk"
        Me.btnStatestikk.Size = New System.Drawing.Size(172, 54)
        Me.btnStatestikk.TabIndex = 18
        Me.btnStatestikk.TabStop = False
        Me.btnStatestikk.Text = "Statistikk"
        Me.btnStatestikk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatestikk.UseVisualStyleBackColor = False
        '
        'btnSjekkBlod
        '
        Me.btnSjekkBlod.BackColor = System.Drawing.Color.Transparent
        Me.btnSjekkBlod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSjekkBlod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSjekkBlod.FlatAppearance.BorderSize = 0
        Me.btnSjekkBlod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSjekkBlod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSjekkBlod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSjekkBlod.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSjekkBlod.ForeColor = System.Drawing.Color.White
        Me.btnSjekkBlod.Location = New System.Drawing.Point(0, 347)
        Me.btnSjekkBlod.Name = "btnSjekkBlod"
        Me.btnSjekkBlod.Size = New System.Drawing.Size(172, 54)
        Me.btnSjekkBlod.TabIndex = 18
        Me.btnSjekkBlod.TabStop = False
        Me.btnSjekkBlod.Text = "Sjekk blod"
        Me.btnSjekkBlod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSjekkBlod.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(146, 115)
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
        Me.btnBestill.Location = New System.Drawing.Point(0, 184)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(172, 54)
        Me.btnBestill.TabIndex = 7
        Me.btnBestill.TabStop = False
        Me.btnBestill.Text = "Bestill blod"
        Me.btnBestill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestill.UseVisualStyleBackColor = False
        '
        'btnKalender
        '
        Me.btnKalender.BackColor = System.Drawing.Color.Transparent
        Me.btnKalender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKalender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKalender.FlatAppearance.BorderSize = 0
        Me.btnKalender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKalender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKalender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKalender.ForeColor = System.Drawing.Color.White
        Me.btnKalender.Location = New System.Drawing.Point(0, 261)
        Me.btnKalender.Name = "btnKalender"
        Me.btnKalender.Size = New System.Drawing.Size(172, 54)
        Me.btnKalender.TabIndex = 0
        Me.btnKalender.TabStop = False
        Me.btnKalender.Text = "Kalender"
        Me.btnKalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKalender.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(146, 447)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 122
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 131
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(146, 200)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 132
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(146, 365)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 133
        Me.PictureBox3.TabStop = False
        '
        'AnsattBrukerOversikt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.headerpanel)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.btnFørstegangsInfo)
        Me.Controls.Add(Me.btnNyGivning)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnAvbestill)
        Me.Controls.Add(Me.btnBestillTime)
        Me.Controls.Add(Me.listboxInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNesteTime)
        Me.Controls.Add(Me.lblNesteGivning)
        Me.Controls.Add(Me.listboxGivinger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBruker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AnsattBrukerOversikt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnsattBrukerOversikt"
        Me.headerpanel.ResumeLayout(False)
        Me.headerpanel.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidetoppanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBruker As Label
    Friend WithEvents lblNesteTime As Label
    Friend WithEvents lblNesteGivning As Label
    Friend WithEvents listboxGivinger As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listboxInfo As ListBox
    Friend WithEvents btnAvbestill As Button
    Friend WithEvents btnBestillTime As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnNyGivning As Button
    Friend WithEvents btnFørstegangsInfo As Button
    Friend WithEvents headerpanel As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents lblAnsatt As Label
    Friend WithEvents sidepanel As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStatestikk As Button
    Friend WithEvents btnSjekkBlod As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents sidetoppanel As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents btnMinSide As Button
    Friend WithEvents btnBestill As Button
    Friend WithEvents btnKalender As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
