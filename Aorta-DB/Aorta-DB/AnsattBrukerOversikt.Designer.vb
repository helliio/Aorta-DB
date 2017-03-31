<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnNyGivning = New System.Windows.Forms.Button()
        Me.btnFørstegangsInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBruker
        '
        Me.lblBruker.AutoSize = True
        Me.lblBruker.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBruker.Location = New System.Drawing.Point(12, 21)
        Me.lblBruker.Name = "lblBruker"
        Me.lblBruker.Size = New System.Drawing.Size(179, 32)
        Me.lblBruker.TabIndex = 0
        Me.lblBruker.Text = "Donør: Bruker"
        '
        'lblNesteTime
        '
        Me.lblNesteTime.AutoSize = True
        Me.lblNesteTime.Location = New System.Drawing.Point(90, 93)
        Me.lblNesteTime.Name = "lblNesteTime"
        Me.lblNesteTime.Size = New System.Drawing.Size(0, 13)
        Me.lblNesteTime.TabIndex = 11
        '
        'lblNesteGivning
        '
        Me.lblNesteGivning.AutoSize = True
        Me.lblNesteGivning.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNesteGivning.Location = New System.Drawing.Point(15, 93)
        Me.lblNesteGivning.Name = "lblNesteGivning"
        Me.lblNesteGivning.Size = New System.Drawing.Size(66, 15)
        Me.lblNesteGivning.TabIndex = 10
        Me.lblNesteGivning.Text = "Neste time:"
        '
        'listboxGivinger
        '
        Me.listboxGivinger.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxGivinger.FormattingEnabled = True
        Me.listboxGivinger.ItemHeight = 14
        Me.listboxGivinger.Location = New System.Drawing.Point(18, 242)
        Me.listboxGivinger.Name = "listboxGivinger"
        Me.listboxGivinger.Size = New System.Drawing.Size(120, 88)
        Me.listboxGivinger.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Siste blodtappinger"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Info om blodgiver"
        '
        'listboxInfo
        '
        Me.listboxInfo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxInfo.FormattingEnabled = True
        Me.listboxInfo.ItemHeight = 14
        Me.listboxInfo.Location = New System.Drawing.Point(15, 363)
        Me.listboxInfo.Name = "listboxInfo"
        Me.listboxInfo.Size = New System.Drawing.Size(120, 88)
        Me.listboxInfo.TabIndex = 13
        '
        'btnAvbestill
        '
        Me.btnAvbestill.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvbestill.Location = New System.Drawing.Point(167, 134)
        Me.btnAvbestill.Name = "btnAvbestill"
        Me.btnAvbestill.Size = New System.Drawing.Size(131, 62)
        Me.btnAvbestill.TabIndex = 15
        Me.btnAvbestill.Text = "Avbestill time"
        Me.btnAvbestill.UseVisualStyleBackColor = True
        '
        'btnBestill
        '
        Me.btnBestill.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestill.Location = New System.Drawing.Point(18, 134)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(131, 62)
        Me.btnBestill.TabIndex = 14
        Me.btnBestill.Text = "Bestill time"
        Me.btnBestill.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(534, 21)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTilbake.Size = New System.Drawing.Size(61, 27)
        Me.btnTilbake.TabIndex = 16
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(167, 242)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(131, 88)
        Me.btnInfo.TabIndex = 17
        Me.btnInfo.Text = "Time info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnNyGivning
        '
        Me.btnNyGivning.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNyGivning.Location = New System.Drawing.Point(317, 242)
        Me.btnNyGivning.Name = "btnNyGivning"
        Me.btnNyGivning.Size = New System.Drawing.Size(131, 88)
        Me.btnNyGivning.TabIndex = 18
        Me.btnNyGivning.Text = "Registrer ny blodtapping"
        Me.btnNyGivning.UseVisualStyleBackColor = True
        '
        'btnFørstegangsInfo
        '
        Me.btnFørstegangsInfo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFørstegangsInfo.Location = New System.Drawing.Point(167, 363)
        Me.btnFørstegangsInfo.Name = "btnFørstegangsInfo"
        Me.btnFørstegangsInfo.Size = New System.Drawing.Size(131, 88)
        Me.btnFørstegangsInfo.TabIndex = 19
        Me.btnFørstegangsInfo.Text = "Helsesjekk"
        Me.btnFørstegangsInfo.UseVisualStyleBackColor = True
        '
        'AnsattBrukerOversikt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.btnFørstegangsInfo)
        Me.Controls.Add(Me.btnNyGivning)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnAvbestill)
        Me.Controls.Add(Me.btnBestill)
        Me.Controls.Add(Me.listboxInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNesteTime)
        Me.Controls.Add(Me.lblNesteGivning)
        Me.Controls.Add(Me.listboxGivinger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBruker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AnsattBrukerOversikt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnsattBrukerOversikt"
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
    Friend WithEvents btnBestill As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnNyGivning As Button
    Friend WithEvents btnFørstegangsInfo As Button
End Class
