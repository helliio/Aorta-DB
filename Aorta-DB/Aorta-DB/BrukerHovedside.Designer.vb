<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrukerHovedside
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrukerHovedside))
        Me.lblBruker = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listboxGivinger = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.lblNesteTime = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.btnAvbestill2 = New System.Windows.Forms.Button()
        Me.sidetoppanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnKontakt = New System.Windows.Forms.Button()
        Me.btnMinSide = New System.Windows.Forms.Button()
        Me.btnEgenerklaring = New System.Windows.Forms.Button()
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.headerpanel = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.sidepanel.SuspendLayout()
        Me.sidetoppanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBruker
        '
        Me.lblBruker.AutoSize = True
        Me.lblBruker.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBruker.ForeColor = System.Drawing.Color.White
        Me.lblBruker.Location = New System.Drawing.Point(26, 20)
        Me.lblBruker.Name = "lblBruker"
        Me.lblBruker.Size = New System.Drawing.Size(236, 28)
        Me.lblBruker.TabIndex = 0
        Me.lblBruker.Text = "Velkommen bruker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(638, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Siste givninger:"
        '
        'listboxGivinger
        '
        Me.listboxGivinger.FormattingEnabled = True
        Me.listboxGivinger.Location = New System.Drawing.Point(12, 39)
        Me.listboxGivinger.Name = "listboxGivinger"
        Me.listboxGivinger.Size = New System.Drawing.Size(146, 95)
        Me.listboxGivinger.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Neste time:"
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoggUt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.FlatAppearance.BorderSize = 0
        Me.btnLoggUt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLoggUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoggUt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoggUt.ForeColor = System.Drawing.Color.White
        Me.btnLoggUt.Location = New System.Drawing.Point(513, 0)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(99, 31)
        Me.btnLoggUt.TabIndex = 5
        Me.btnLoggUt.TabStop = False
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'lblNesteTime
        '
        Me.lblNesteTime.AutoSize = True
        Me.lblNesteTime.Location = New System.Drawing.Point(12, 143)
        Me.lblNesteTime.Name = "lblNesteTime"
        Me.lblNesteTime.Size = New System.Drawing.Size(0, 13)
        Me.lblNesteTime.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(202, 126)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(179, 145)
        Me.Panel6.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(200, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nyttig info.."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.listboxGivinger)
        Me.Panel4.Location = New System.Drawing.Point(411, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(179, 145)
        Me.Panel4.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dine givinger:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(200, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nyheter..."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(203, 321)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(179, 145)
        Me.Panel5.TabIndex = 17
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(411, 321)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(179, 145)
        Me.Panel7.TabIndex = 18
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.btnAvbestill2)
        Me.sidepanel.Controls.Add(Me.sidetoppanel)
        Me.sidepanel.Controls.Add(Me.btnKontakt)
        Me.sidepanel.Controls.Add(Me.btnMinSide)
        Me.sidepanel.Controls.Add(Me.btnEgenerklaring)
        Me.sidepanel.Controls.Add(Me.btnBestill)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(172, 561)
        Me.sidepanel.TabIndex = 19
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
        Me.btnAvbestill2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvbestill2.ForeColor = System.Drawing.Color.White
        Me.btnAvbestill2.Location = New System.Drawing.Point(-13, 370)
        Me.btnAvbestill2.Name = "btnAvbestill2"
        Me.btnAvbestill2.Size = New System.Drawing.Size(195, 54)
        Me.btnAvbestill2.TabIndex = 18
        Me.btnAvbestill2.TabStop = False
        Me.btnAvbestill2.Text = "Avbestill time"
        Me.btnAvbestill2.UseVisualStyleBackColor = False
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
        Me.btnKontakt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKontakt.ForeColor = System.Drawing.Color.White
        Me.btnKontakt.Location = New System.Drawing.Point(-13, 449)
        Me.btnKontakt.Name = "btnKontakt"
        Me.btnKontakt.Size = New System.Drawing.Size(195, 54)
        Me.btnKontakt.TabIndex = 8
        Me.btnKontakt.TabStop = False
        Me.btnKontakt.Text = "Kontakt oss"
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
        Me.btnMinSide.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinSide.ForeColor = System.Drawing.Color.White
        Me.btnMinSide.Location = New System.Drawing.Point(-13, 122)
        Me.btnMinSide.Name = "btnMinSide"
        Me.btnMinSide.Size = New System.Drawing.Size(195, 54)
        Me.btnMinSide.TabIndex = 0
        Me.btnMinSide.TabStop = False
        Me.btnMinSide.Text = "Min side"
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
        Me.btnEgenerklaring.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgenerklaring.ForeColor = System.Drawing.Color.White
        Me.btnEgenerklaring.Location = New System.Drawing.Point(-13, 207)
        Me.btnEgenerklaring.Name = "btnEgenerklaring"
        Me.btnEgenerklaring.Size = New System.Drawing.Size(195, 54)
        Me.btnEgenerklaring.TabIndex = 7
        Me.btnEgenerklaring.TabStop = False
        Me.btnEgenerklaring.Text = "Egenerklæring"
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
        Me.btnBestill.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestill.ForeColor = System.Drawing.Color.White
        Me.btnBestill.Location = New System.Drawing.Point(-13, 289)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(195, 54)
        Me.btnBestill.TabIndex = 0
        Me.btnBestill.TabStop = False
        Me.btnBestill.Text = "Bestill time"
        Me.btnBestill.UseVisualStyleBackColor = False
        '
        'headerpanel
        '
        Me.headerpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.headerpanel.Controls.Add(Me.lblBruker)
        Me.headerpanel.Controls.Add(Me.btnLoggUt)
        Me.headerpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerpanel.Location = New System.Drawing.Point(172, 0)
        Me.headerpanel.Name = "headerpanel"
        Me.headerpanel.Size = New System.Drawing.Size(612, 75)
        Me.headerpanel.TabIndex = 20
        '
        'BrukerHovedside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.headerpanel)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.lblNesteTime)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "BrukerHovedside"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BrukerHovedside"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.sidepanel.ResumeLayout(False)
        Me.sidetoppanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerpanel.ResumeLayout(False)
        Me.headerpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBruker As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listboxGivinger As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents lblNesteTime As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents sidepanel As Panel
    Friend WithEvents sidetoppanel As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents btnKontakt As Button
    Friend WithEvents btnMinSide As Button
    Friend WithEvents btnEgenerklaring As Button
    Friend WithEvents btnBestill As Button
    Friend WithEvents headerpanel As Panel
    Friend WithEvents btnAvbestill2 As Button
End Class
