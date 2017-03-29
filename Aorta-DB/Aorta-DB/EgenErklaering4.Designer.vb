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
        Me.Label1.Location = New System.Drawing.Point(45, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Har du i løpet av de siste to år"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "- hatt sjeldne eller alvorlige infeksjonssykdommer?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 451)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 36)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Neste vindu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(11, 463)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(68, 38)
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
        Me.GroupBox4.Location = New System.Drawing.Point(410, 58)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Size = New System.Drawing.Size(104, 21)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        '
        'radbtnnei29
        '
        Me.radbtnnei29.AutoSize = True
        Me.radbtnnei29.Checked = True
        Me.radbtnnei29.Location = New System.Drawing.Point(64, 4)
        Me.radbtnnei29.Margin = New System.Windows.Forms.Padding(2)
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
        Me.radbtnja29.Location = New System.Drawing.Point(3, 4)
        Me.radbtnja29.Margin = New System.Windows.Forms.Padding(2)
        Me.radbtnja29.Name = "radbtnja29"
        Me.radbtnja29.Size = New System.Drawing.Size(41, 20)
        Me.radbtnja29.TabIndex = 65
        Me.radbtnja29.Text = "Ja"
        Me.radbtnja29.UseVisualStyleBackColor = True
        '
        'EgenErklaering4
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "EgenErklaering4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
