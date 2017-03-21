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
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.btnTilbake = New System.Windows.Forms.Button()
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
        'CheckBox29
        '
        Me.CheckBox29.AutoSize = True
        Me.CheckBox29.Location = New System.Drawing.Point(312, 58)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(48, 28)
        Me.CheckBox29.TabIndex = 50
        Me.CheckBox29.Text = "Ja"
        Me.CheckBox29.UseVisualStyleBackColor = True
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
        'EgenErklaering4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 359)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.CheckBox29)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "EgenErklaering4"
        Me.Text = "EgenErklaering4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox29 As CheckBox
    Friend WithEvents btnTilbake As Button
End Class
