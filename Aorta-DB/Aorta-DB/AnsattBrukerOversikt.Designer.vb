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
        Me.lblBruker.Location = New System.Drawing.Point(32, 22)
        Me.lblBruker.Name = "lblBruker"
        Me.lblBruker.Size = New System.Drawing.Size(73, 13)
        Me.lblBruker.TabIndex = 0
        Me.lblBruker.Text = "Donør: Bruker"
        '
        'lblNesteTime
        '
        Me.lblNesteTime.AutoSize = True
        Me.lblNesteTime.Location = New System.Drawing.Point(9, 69)
        Me.lblNesteTime.Name = "lblNesteTime"
        Me.lblNesteTime.Size = New System.Drawing.Size(0, 13)
        Me.lblNesteTime.TabIndex = 11
        '
        'lblNesteGivning
        '
        Me.lblNesteGivning.AutoSize = True
        Me.lblNesteGivning.Location = New System.Drawing.Point(9, 53)
        Me.lblNesteGivning.Name = "lblNesteGivning"
        Me.lblNesteGivning.Size = New System.Drawing.Size(60, 13)
        Me.lblNesteGivning.TabIndex = 10
        Me.lblNesteGivning.Text = "Neste time:"
        '
        'listboxGivinger
        '
        Me.listboxGivinger.FormattingEnabled = True
        Me.listboxGivinger.Location = New System.Drawing.Point(12, 123)
        Me.listboxGivinger.Name = "listboxGivinger"
        Me.listboxGivinger.Size = New System.Drawing.Size(120, 95)
        Me.listboxGivinger.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Siste givninger:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Generell info"
        '
        'listboxInfo
        '
        Me.listboxInfo.FormattingEnabled = True
        Me.listboxInfo.Location = New System.Drawing.Point(12, 241)
        Me.listboxInfo.Name = "listboxInfo"
        Me.listboxInfo.Size = New System.Drawing.Size(120, 95)
        Me.listboxInfo.TabIndex = 13
        '
        'btnAvbestill
        '
        Me.btnAvbestill.Location = New System.Drawing.Point(257, 274)
        Me.btnAvbestill.Name = "btnAvbestill"
        Me.btnAvbestill.Size = New System.Drawing.Size(131, 62)
        Me.btnAvbestill.TabIndex = 15
        Me.btnAvbestill.Text = "Avbestill givningstime"
        Me.btnAvbestill.UseVisualStyleBackColor = True
        '
        'btnBestill
        '
        Me.btnBestill.Location = New System.Drawing.Point(257, 206)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(131, 62)
        Me.btnBestill.TabIndex = 14
        Me.btnBestill.Text = "Bestill givningstime"
        Me.btnBestill.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(327, 8)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnTilbake.Size = New System.Drawing.Size(61, 27)
        Me.btnTilbake.TabIndex = 16
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(303, 102)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(85, 44)
        Me.btnInfo.TabIndex = 17
        Me.btnInfo.Text = "Time info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnNyGivning
        '
        Me.btnNyGivning.Location = New System.Drawing.Point(303, 156)
        Me.btnNyGivning.Name = "btnNyGivning"
        Me.btnNyGivning.Size = New System.Drawing.Size(85, 44)
        Me.btnNyGivning.TabIndex = 18
        Me.btnNyGivning.Text = "Ny givning"
        Me.btnNyGivning.UseVisualStyleBackColor = True
        '
        'btnFørstegangsInfo
        '
        Me.btnFørstegangsInfo.Location = New System.Drawing.Point(303, 53)
        Me.btnFørstegangsInfo.Name = "btnFørstegangsInfo"
        Me.btnFørstegangsInfo.Size = New System.Drawing.Size(85, 43)
        Me.btnFørstegangsInfo.TabIndex = 19
        Me.btnFørstegangsInfo.Text = "Ny info"
        Me.btnFørstegangsInfo.UseVisualStyleBackColor = True
        '
        'AnsattBrukerOversikt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 348)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnsattBrukerOversikt"
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
