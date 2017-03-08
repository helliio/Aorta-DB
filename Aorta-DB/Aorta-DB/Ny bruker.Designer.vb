<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNybruker = New System.Windows.Forms.Label()
        Me.lblPersonnummer = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.lblBekreftpass = New System.Windows.Forms.Label()
        Me.btnNybruker = New System.Windows.Forms.Button()
        Me.txtPersonnummer = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.txtBekreftpass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNybruker
        '
        Me.lblNybruker.AutoSize = True
        Me.lblNybruker.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold)
        Me.lblNybruker.Location = New System.Drawing.Point(53, 55)
        Me.lblNybruker.Name = "lblNybruker"
        Me.lblNybruker.Size = New System.Drawing.Size(98, 26)
        Me.lblNybruker.TabIndex = 0
        Me.lblNybruker.Text = "Ny Bruker"
        '
        'lblPersonnummer
        '
        Me.lblPersonnummer.AutoSize = True
        Me.lblPersonnummer.Location = New System.Drawing.Point(55, 96)
        Me.lblPersonnummer.Name = "lblPersonnummer"
        Me.lblPersonnummer.Size = New System.Drawing.Size(77, 13)
        Me.lblPersonnummer.TabIndex = 1
        Me.lblPersonnummer.Text = "Personnummer"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(55, 143)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(26, 13)
        Me.lblMail.TabIndex = 2
        Me.lblMail.Text = "Mail"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(55, 188)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 3
        Me.lblPassord.Text = "Passord"
        '
        'lblBekreftpass
        '
        Me.lblBekreftpass.AutoSize = True
        Me.lblBekreftpass.Location = New System.Drawing.Point(55, 234)
        Me.lblBekreftpass.Name = "lblBekreftpass"
        Me.lblBekreftpass.Size = New System.Drawing.Size(81, 13)
        Me.lblBekreftpass.TabIndex = 4
        Me.lblBekreftpass.Text = "Bekreft passord"
        '
        'btnNybruker
        '
        Me.btnNybruker.Location = New System.Drawing.Point(57, 287)
        Me.btnNybruker.Name = "btnNybruker"
        Me.btnNybruker.Size = New System.Drawing.Size(132, 49)
        Me.btnNybruker.TabIndex = 5
        Me.btnNybruker.Text = "Lag ny bruker"
        Me.btnNybruker.UseVisualStyleBackColor = True
        '
        'txtPersonnummer
        '
        Me.txtPersonnummer.Location = New System.Drawing.Point(57, 112)
        Me.txtPersonnummer.Name = "txtPersonnummer"
        Me.txtPersonnummer.Size = New System.Drawing.Size(100, 20)
        Me.txtPersonnummer.TabIndex = 6
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(58, 158)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 7
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(58, 204)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(100, 20)
        Me.txtPassord.TabIndex = 8
        '
        'txtBekreftpass
        '
        Me.txtBekreftpass.Location = New System.Drawing.Point(58, 250)
        Me.txtBekreftpass.Name = "txtBekreftpass"
        Me.txtBekreftpass.Size = New System.Drawing.Size(100, 20)
        Me.txtBekreftpass.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 364)
        Me.Controls.Add(Me.txtBekreftpass)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtPersonnummer)
        Me.Controls.Add(Me.btnNybruker)
        Me.Controls.Add(Me.lblBekreftpass)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblPersonnummer)
        Me.Controls.Add(Me.lblNybruker)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNybruker As Label
    Friend WithEvents lblPersonnummer As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblPassord As Label
    Friend WithEvents lblBekreftpass As Label
    Private WithEvents btnNybruker As Button
    Friend WithEvents txtPersonnummer As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents txtBekreftpass As TextBox
End Class
