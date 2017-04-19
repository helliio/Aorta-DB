<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatistikkIKT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatistikkIKT))
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sidetoppanel = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnStatistikk = New System.Windows.Forms.Button()
        Me.btnNyAnsatt = New System.Windows.Forms.Button()
        Me.btnMinSide = New System.Windows.Forms.Button()
        Me.sidepanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidetoppanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.GroupBox9)
        Me.sidepanel.Controls.Add(Me.Panel9)
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Controls.Add(Me.Panel2)
        Me.sidepanel.Controls.Add(Me.PictureBox2)
        Me.sidepanel.Controls.Add(Me.sidetoppanel)
        Me.sidepanel.Controls.Add(Me.btnStatistikk)
        Me.sidepanel.Controls.Add(Me.btnNyAnsatt)
        Me.sidepanel.Controls.Add(Me.btnMinSide)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(172, 600)
        Me.sidepanel.TabIndex = 125
        '
        'GroupBox9
        '
        Me.GroupBox9.Location = New System.Drawing.Point(172, 200)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(646, 46)
        Me.GroupBox9.TabIndex = 117
        Me.GroupBox9.TabStop = False
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
        'btnStatistikk
        '
        Me.btnStatistikk.BackColor = System.Drawing.Color.Transparent
        Me.btnStatistikk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatistikk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnStatistikk.FlatAppearance.BorderSize = 0
        Me.btnStatistikk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnStatistikk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnStatistikk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistikk.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistikk.ForeColor = System.Drawing.Color.White
        Me.btnStatistikk.Location = New System.Drawing.Point(0, 256)
        Me.btnStatistikk.Name = "btnStatistikk"
        Me.btnStatistikk.Size = New System.Drawing.Size(172, 54)
        Me.btnStatistikk.TabIndex = 0
        Me.btnStatistikk.TabStop = False
        Me.btnStatistikk.Text = "Statistikk"
        Me.btnStatistikk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistikk.UseVisualStyleBackColor = False
        '
        'btnNyAnsatt
        '
        Me.btnNyAnsatt.BackColor = System.Drawing.Color.Transparent
        Me.btnNyAnsatt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNyAnsatt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyAnsatt.FlatAppearance.BorderSize = 0
        Me.btnNyAnsatt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyAnsatt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNyAnsatt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNyAnsatt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNyAnsatt.ForeColor = System.Drawing.Color.White
        Me.btnNyAnsatt.Location = New System.Drawing.Point(0, 173)
        Me.btnNyAnsatt.Name = "btnNyAnsatt"
        Me.btnNyAnsatt.Size = New System.Drawing.Size(172, 54)
        Me.btnNyAnsatt.TabIndex = 0
        Me.btnNyAnsatt.TabStop = False
        Me.btnNyAnsatt.Text = "Ny ansatt"
        Me.btnNyAnsatt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNyAnsatt.UseVisualStyleBackColor = False
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
        'StatistikkIKT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.sidepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StatistikkIKT"
        Me.Text = "StatistikkIKT"
        Me.sidepanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidetoppanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidepanel As Panel
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents sidetoppanel As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents btnStatistikk As Button
    Friend WithEvents btnNyAnsatt As Button
    Friend WithEvents btnMinSide As Button
End Class
