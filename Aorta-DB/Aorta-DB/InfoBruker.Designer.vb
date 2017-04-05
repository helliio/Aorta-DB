<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoBruker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoBruker))
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listboxHelsesjekk = New System.Windows.Forms.ListBox()
        Me.listboxTimer = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listboxGivningsInfo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(12, 12)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 0
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(37, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Info om brukeren"
        '
        'listboxHelsesjekk
        '
        Me.listboxHelsesjekk.FormattingEnabled = True
        Me.listboxHelsesjekk.Location = New System.Drawing.Point(12, 199)
        Me.listboxHelsesjekk.Name = "listboxHelsesjekk"
        Me.listboxHelsesjekk.Size = New System.Drawing.Size(178, 160)
        Me.listboxHelsesjekk.TabIndex = 2
        '
        'listboxTimer
        '
        Me.listboxTimer.FormattingEnabled = True
        Me.listboxTimer.Location = New System.Drawing.Point(478, 30)
        Me.listboxTimer.Name = "listboxTimer"
        Me.listboxTimer.Size = New System.Drawing.Size(120, 95)
        Me.listboxTimer.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(373, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'listboxGivningsInfo
        '
        Me.listboxGivningsInfo.FormattingEnabled = True
        Me.listboxGivningsInfo.Location = New System.Drawing.Point(373, 199)
        Me.listboxGivningsInfo.Name = "listboxGivningsInfo"
        Me.listboxGivningsInfo.Size = New System.Drawing.Size(231, 160)
        Me.listboxGivningsInfo.TabIndex = 5
        '
        'InfoBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.listboxGivningsInfo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listboxTimer)
        Me.Controls.Add(Me.listboxHelsesjekk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTilbake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InfoBruker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoBruker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTilbake As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents listboxHelsesjekk As ListBox
    Friend WithEvents listboxTimer As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents listboxGivningsInfo As ListBox
End Class
