<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EgenErklaering4
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
        Me.radbtnnei29 = New System.Windows.Forms.RadioButton()
        Me.radbtnja29 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Har du i løpet av de siste to år"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "- hatt sjeldne eller alvorlige infeksjonssykdommer?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 45)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Neste vindu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTilbake.Location = New System.Drawing.Point(429, 12)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(58, 25)
        Me.btnTilbake.TabIndex = 62
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.radbtnnei29)
        Me.GroupBox4.Controls.Add(Me.radbtnja29)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(311, 58)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Size = New System.Drawing.Size(143, 26)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        '
        'radbtnnei29
        '
        Me.radbtnnei29.AutoSize = True
        Me.radbtnnei29.Checked = True
        Me.radbtnnei29.Location = New System.Drawing.Point(88, 5)
        Me.radbtnnei29.Name = "radbtnnei29"
        Me.radbtnnei29.Size = New System.Drawing.Size(47, 20)
        Me.radbtnnei29.TabIndex = 66
        Me.radbtnnei29.TabStop = True
        Me.radbtnnei29.Text = "Nei"
        Me.radbtnnei29.UseVisualStyleBackColor = True
        '
        'radbtnja29
        '
        Me.radbtnja29.AutoSize = True
        Me.radbtnja29.Location = New System.Drawing.Point(4, 5)
        Me.radbtnja29.Name = "radbtnja29"
        Me.radbtnja29.Size = New System.Drawing.Size(41, 20)
        Me.radbtnja29.TabIndex = 65
        Me.radbtnja29.Text = "Ja"
        Me.radbtnja29.UseVisualStyleBackColor = True
        '
        'EgenErklaering4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 359)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "EgenErklaering4"
        Me.Text = "EgenErklaering4"
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
    Friend WithEvents radbtnnei29 As RadioButton
    Friend WithEvents radbtnja29 As RadioButton
End Class
