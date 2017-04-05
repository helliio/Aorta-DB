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
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.sidetoppanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnKontakt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNyBruker = New System.Windows.Forms.Button()
        Me.btnEgenerklæring = New System.Windows.Forms.Button()
        Me.headerpanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sidepanel.SuspendLayout()
        Me.sidetoppanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerpanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'txtPassord
        '
        Me.txtPassord.BackColor = System.Drawing.Color.White
        Me.txtPassord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassord.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(443, 258)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(122, 21)
        Me.txtPassord.TabIndex = 10
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
        Me.btnGlemtpassord.Location = New System.Drawing.Point(444, 376)
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
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.sidetoppanel)
        Me.sidepanel.Controls.Add(Me.btnKontakt)
        Me.sidepanel.Controls.Add(Me.Button1)
        Me.sidepanel.Controls.Add(Me.btnNyBruker)
        Me.sidepanel.Controls.Add(Me.btnEgenerklæring)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(172, 561)
        Me.sidepanel.TabIndex = 14
        '
        'sidetoppanel
        '
        Me.sidetoppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.sidetoppanel.Controls.Add(Me.logo)
        Me.sidetoppanel.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.btnKontakt.Location = New System.Drawing.Point(-13, 375)
        Me.btnKontakt.Name = "btnKontakt"
        Me.btnKontakt.Size = New System.Drawing.Size(195, 54)
        Me.btnKontakt.TabIndex = 8
        Me.btnKontakt.TabStop = False
        Me.btnKontakt.Text = "Kontakt oss"
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
        Me.Button1.Location = New System.Drawing.Point(-13, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Hjem"
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
        Me.btnNyBruker.Location = New System.Drawing.Point(-13, 207)
        Me.btnNyBruker.Name = "btnNyBruker"
        Me.btnNyBruker.Size = New System.Drawing.Size(195, 54)
        Me.btnNyBruker.TabIndex = 7
        Me.btnNyBruker.TabStop = False
        Me.btnNyBruker.Text = "Registrer deg"
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
        Me.btnEgenerklæring.Location = New System.Drawing.Point(-13, 289)
        Me.btnEgenerklæring.Name = "btnEgenerklæring"
        Me.btnEgenerklæring.Size = New System.Drawing.Size(195, 54)
        Me.btnEgenerklæring.TabIndex = 0
        Me.btnEgenerklæring.TabStop = False
        Me.btnEgenerklæring.Text = "Egenerklæring"
        Me.btnEgenerklæring.UseVisualStyleBackColor = False
        '
        'headerpanel
        '
        Me.headerpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.headerpanel.Controls.Add(Me.PictureBox1)
        Me.headerpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerpanel.Location = New System.Drawing.Point(172, 0)
        Me.headerpanel.Name = "headerpanel"
        Me.headerpanel.Size = New System.Drawing.Size(612, 75)
        Me.headerpanel.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aorta_DB.My.Resources.Resources.Logomakr_82u4uc
        Me.PictureBox1.Location = New System.Drawing.Point(29, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        'Logginn
        '
        Me.AcceptButton = Me.btnLogginn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.headerpanel)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogginn)
        Me.Controls.Add(Me.btnGlemtpassord)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.TxtPersonnummer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Logginn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logg inn"
        Me.sidepanel.ResumeLayout(False)
        Me.sidetoppanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerpanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPersonnummer As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents btnGlemtpassord As Button
    Friend WithEvents btnLogginn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sidepanel As Panel
    Friend WithEvents btnKontakt As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnNyBruker As Button
    Friend WithEvents btnEgenerklæring As Button
    Friend WithEvents headerpanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sidetoppanel As Panel
    Friend WithEvents logo As PictureBox
End Class
