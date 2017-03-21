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
        Me.CheckBox49 = New System.Windows.Forms.CheckBox()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Besvares av menn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Har eller har du hatt seksuell kontakt med andre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "menn?" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 45)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Neste vindu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox49
        '
        Me.CheckBox49.AutoSize = True
        Me.CheckBox49.Location = New System.Drawing.Point(266, 78)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.Size = New System.Drawing.Size(37, 17)
        Me.CheckBox49.TabIndex = 65
        Me.CheckBox49.Text = "Ja"
        Me.CheckBox49.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(291, 12)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(58, 25)
        Me.btnTilbake.TabIndex = 66
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'EgenErklaering7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 324)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.CheckBox49)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EgenErklaering7"
        Me.Text = "EgenErklaering7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox49 As CheckBox
    Friend WithEvents btnTilbake As Button
End Class
