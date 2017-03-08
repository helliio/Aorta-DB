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
        Me.lblBruker = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listboxInfo = New System.Windows.Forms.ListBox()
        Me.listboxGivinger = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.btnEgenerklæring = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBruker
        '
        Me.lblBruker.AutoSize = True
        Me.lblBruker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblBruker.Location = New System.Drawing.Point(12, 9)
        Me.lblBruker.Name = "lblBruker"
        Me.lblBruker.Size = New System.Drawing.Size(227, 29)
        Me.lblBruker.TabIndex = 0
        Me.lblBruker.Text = "Velkommen bruker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Siste givninger:"
        '
        'listboxInfo
        '
        Me.listboxInfo.FormattingEnabled = True
        Me.listboxInfo.Location = New System.Drawing.Point(15, 60)
        Me.listboxInfo.Name = "listboxInfo"
        Me.listboxInfo.Size = New System.Drawing.Size(120, 95)
        Me.listboxInfo.TabIndex = 2
        '
        'listboxGivinger
        '
        Me.listboxGivinger.FormattingEnabled = True
        Me.listboxGivinger.Location = New System.Drawing.Point(15, 197)
        Me.listboxGivinger.Name = "listboxGivinger"
        Me.listboxGivinger.Size = New System.Drawing.Size(120, 95)
        Me.listboxGivinger.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Info:"
        '
        'btnBestill
        '
        Me.btnBestill.Location = New System.Drawing.Point(254, 230)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(131, 62)
        Me.btnBestill.TabIndex = 4
        Me.btnBestill.Text = "Bestill givningstime"
        Me.btnBestill.UseVisualStyleBackColor = True
        '
        'btnEgenerklæring
        '
        Me.btnEgenerklæring.Location = New System.Drawing.Point(300, 176)
        Me.btnEgenerklæring.Name = "btnEgenerklæring"
        Me.btnEgenerklæring.Size = New System.Drawing.Size(85, 44)
        Me.btnEgenerklæring.TabIndex = 5
        Me.btnEgenerklæring.Text = "Egenerklæring"
        Me.btnEgenerklæring.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(300, 126)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(85, 44)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "btnInfo"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'BrukerHovedside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 304)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnEgenerklæring)
        Me.Controls.Add(Me.btnBestill)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listboxGivinger)
        Me.Controls.Add(Me.listboxInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBruker)
        Me.Name = "BrukerHovedside"
        Me.Text = "BrukerHovedside"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBruker As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listboxInfo As ListBox
    Friend WithEvents listboxGivinger As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBestill As Button
    Friend WithEvents btnEgenerklæring As Button
    Friend WithEvents btnInfo As Button
End Class
