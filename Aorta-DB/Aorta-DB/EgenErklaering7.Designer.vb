<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EgenErklaering7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radbtnnei49 = New System.Windows.Forms.RadioButton()
        Me.radbtnja49 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Besvares av menn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Har eller har du hatt seksuell kontakt med andre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "menn?" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 433)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 66)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Neste vindu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(35, 462)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(77, 37)
        Me.btnTilbake.TabIndex = 66
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.radbtnnei49)
        Me.GroupBox4.Controls.Add(Me.radbtnja49)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(367, 96)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Size = New System.Drawing.Size(191, 38)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'radbtnnei49
        '
        Me.radbtnnei49.AutoSize = True
        Me.radbtnnei49.Checked = True
        Me.radbtnnei49.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.radbtnnei49.Location = New System.Drawing.Point(117, 7)
        Me.radbtnnei49.Margin = New System.Windows.Forms.Padding(4)
        Me.radbtnnei49.Name = "radbtnnei49"
        Me.radbtnnei49.Size = New System.Drawing.Size(40, 17)
        Me.radbtnnei49.TabIndex = 66
        Me.radbtnnei49.TabStop = True
        Me.radbtnnei49.Text = "Nei"
        Me.radbtnnei49.UseVisualStyleBackColor = True
        '
        'radbtnja49
        '
        Me.radbtnja49.AutoSize = True
        Me.radbtnja49.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.radbtnja49.Location = New System.Drawing.Point(5, 7)
        Me.radbtnja49.Margin = New System.Windows.Forms.Padding(4)
        Me.radbtnja49.Name = "radbtnja49"
        Me.radbtnja49.Size = New System.Drawing.Size(36, 17)
        Me.radbtnja49.TabIndex = 65
        Me.radbtnja49.Text = "Ja"
        Me.radbtnja49.UseVisualStyleBackColor = True
        '
        'EgenErklaering7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 512)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "EgenErklaering7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EgenErklaering7"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radbtnnei49 As RadioButton
    Friend WithEvents radbtnja49 As RadioButton
End Class
