<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logginn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logginn))
        Me.TxtPersonnummer = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.btnGlemtpassord = New System.Windows.Forms.Button()
        Me.btnLogginn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnKontakt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNyBruker = New System.Windows.Forms.Button()
        Me.btnEgenerklæring = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPersonnummer
        '
        Me.TxtPersonnummer.BackColor = System.Drawing.Color.White
        Me.TxtPersonnummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPersonnummer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPersonnummer.Location = New System.Drawing.Point(451, 206)
        Me.TxtPersonnummer.Name = "TxtPersonnummer"
        Me.TxtPersonnummer.Size = New System.Drawing.Size(122, 21)
        Me.TxtPersonnummer.TabIndex = 1
        '
        'txtPassord
        '
        Me.txtPassord.BackColor = System.Drawing.Color.White
        Me.txtPassord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassord.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(451, 259)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(122, 21)
        Me.txtPassord.TabIndex = 2
        '
        'btnGlemtpassord
        '
        Me.btnGlemtpassord.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGlemtpassord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGlemtpassord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGlemtpassord.FlatAppearance.BorderSize = 2
        Me.btnGlemtpassord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGlemtpassord.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlemtpassord.ForeColor = System.Drawing.Color.White
        Me.btnGlemtpassord.Location = New System.Drawing.Point(443, 406)
        Me.btnGlemtpassord.Name = "btnGlemtpassord"
        Me.btnGlemtpassord.Size = New System.Drawing.Size(131, 33)
        Me.btnGlemtpassord.TabIndex = 3
        Me.btnGlemtpassord.Text = "Glemt passord?"
        Me.btnGlemtpassord.UseVisualStyleBackColor = False
        '
        'btnLogginn
        '
        Me.btnLogginn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnLogginn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogginn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLogginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogginn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogginn.ForeColor = System.Drawing.Color.White
        Me.btnLogginn.Location = New System.Drawing.Point(433, 347)
        Me.btnLogginn.Name = "btnLogginn"
        Me.btnLogginn.Size = New System.Drawing.Size(149, 42)
        Me.btnLogginn.TabIndex = 3
        Me.btnLogginn.Text = "Logg inn"
        Me.btnLogginn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Passord:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Personnummer/id:"
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(172, 528)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(80, 33)
        Me.btnTilbake.TabIndex = 5
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.btnKontakt)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnNyBruker)
        Me.Panel3.Controls.Add(Me.btnEgenerklæring)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(172, 561)
        Me.Panel3.TabIndex = 14
        '
        'btnKontakt
        '
        Me.btnKontakt.BackColor = System.Drawing.Color.Transparent
        Me.btnKontakt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKontakt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKontakt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKontakt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKontakt.ForeColor = System.Drawing.Color.White
        Me.btnKontakt.Location = New System.Drawing.Point(-13, 375)
        Me.btnKontakt.Name = "btnKontakt"
        Me.btnKontakt.Size = New System.Drawing.Size(195, 54)
        Me.btnKontakt.TabIndex = 8
        Me.btnKontakt.Text = "Kontakt oss"
        Me.btnKontakt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-13, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logg inn"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnNyBruker
        '
        Me.btnNyBruker.BackColor = System.Drawing.Color.Transparent
        Me.btnNyBruker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNyBruker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyBruker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyBruker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNyBruker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNyBruker.ForeColor = System.Drawing.Color.White
        Me.btnNyBruker.Location = New System.Drawing.Point(-13, 207)
        Me.btnNyBruker.Name = "btnNyBruker"
        Me.btnNyBruker.Size = New System.Drawing.Size(195, 54)
        Me.btnNyBruker.TabIndex = 7
        Me.btnNyBruker.Text = "Registrer deg"
        Me.btnNyBruker.UseVisualStyleBackColor = False
        '
        'btnEgenerklæring
        '
        Me.btnEgenerklæring.BackColor = System.Drawing.Color.Transparent
        Me.btnEgenerklæring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEgenerklæring.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklæring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEgenerklæring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEgenerklæring.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgenerklæring.ForeColor = System.Drawing.Color.White
        Me.btnEgenerklæring.Location = New System.Drawing.Point(-13, 289)
        Me.btnEgenerklæring.Name = "btnEgenerklæring"
        Me.btnEgenerklæring.Size = New System.Drawing.Size(195, 54)
        Me.btnEgenerklæring.TabIndex = 0
        Me.btnEgenerklæring.Text = "Egenerklæring"
        Me.btnEgenerklæring.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 75)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Aorta_DB.My.Resources.Resources.Logomakr_2plwp5
        Me.PictureBox4.Location = New System.Drawing.Point(43, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(79, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(172, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 75)
        Me.Panel2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(266, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Logg inn"
        '
        'Logginn
        '
        Me.AcceptButton = Me.Button2
        Me.AcceptButton = Me.btnLogginn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnTilbake)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPersonnummer As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents btnGlemtpassord As Button
    Friend WithEvents btnLogginn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTilbake As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnKontakt As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnNyBruker As Button
    Friend WithEvents btnEgenerklæring As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
