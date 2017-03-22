<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VelgTime
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
        Me.listboxTimer = New System.Windows.Forms.ListBox()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.btnVelgTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listboxTimer
        '
        Me.listboxTimer.FormattingEnabled = True
        Me.listboxTimer.Location = New System.Drawing.Point(75, 43)
        Me.listboxTimer.Name = "listboxTimer"
        Me.listboxTimer.Size = New System.Drawing.Size(120, 173)
        Me.listboxTimer.TabIndex = 0
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(12, 12)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(58, 19)
        Me.btnTilbake.TabIndex = 1
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'btnVelgTime
        '
        Me.btnVelgTime.Location = New System.Drawing.Point(96, 222)
        Me.btnVelgTime.Name = "btnVelgTime"
        Me.btnVelgTime.Size = New System.Drawing.Size(75, 23)
        Me.btnVelgTime.TabIndex = 2
        Me.btnVelgTime.Text = "Velg time"
        Me.btnVelgTime.UseVisualStyleBackColor = True
        '
        'VelgTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnVelgTime)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.listboxTimer)
        Me.Name = "VelgTime"
        Me.Text = "VelgTime"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listboxTimer As ListBox
    Friend WithEvents btnTilbake As Button
    Friend WithEvents btnVelgTime As Button
End Class
