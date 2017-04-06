<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.txtBekreftpass = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.lblBekreftpass = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBekreftpass
        '
        Me.txtBekreftpass.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBekreftpass.Location = New System.Drawing.Point(94, 150)
        Me.txtBekreftpass.Name = "txtBekreftpass"
        Me.txtBekreftpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBekreftpass.Size = New System.Drawing.Size(100, 23)
        Me.txtBekreftpass.TabIndex = 109
        '
        'txtPassord
        '
        Me.txtPassord.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassord.Location = New System.Drawing.Point(94, 104)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(100, 23)
        Me.txtPassord.TabIndex = 108
        '
        'lblBekreftpass
        '
        Me.lblBekreftpass.AutoSize = True
        Me.lblBekreftpass.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBekreftpass.Location = New System.Drawing.Point(91, 132)
        Me.lblBekreftpass.Name = "lblBekreftpass"
        Me.lblBekreftpass.Size = New System.Drawing.Size(93, 15)
        Me.lblBekreftpass.TabIndex = 107
        Me.lblBekreftpass.Text = "Bekreft passord"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassord.Location = New System.Drawing.Point(91, 88)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(52, 15)
        Me.lblPassord.TabIndex = 106
        Me.lblPassord.Text = "Passord"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBekreftpass)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.lblBekreftpass)
        Me.Controls.Add(Me.lblPassord)
        Me.Name = "ChangePass"
        Me.Text = "ChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBekreftpass As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents lblBekreftpass As Label
    Friend WithEvents lblPassord As Label
    Friend WithEvents Button1 As Button
End Class
