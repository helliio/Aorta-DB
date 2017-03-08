<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NyBruker
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
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtPersonnummer = New System.Windows.Forms.TextBox()
        Me.btnNybruker = New System.Windows.Forms.Button()
        Me.lblBekreftpass = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblPersonnummer = New System.Windows.Forms.Label()
        Me.lblNybruker = New System.Windows.Forms.Label()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBekreftpass
        '
        Me.txtBekreftpass.Location = New System.Drawing.Point(42, 254)
        Me.txtBekreftpass.Name = "txtBekreftpass"
        Me.txtBekreftpass.Size = New System.Drawing.Size(100, 20)
        Me.txtBekreftpass.TabIndex = 19
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(42, 215)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(100, 20)
        Me.txtPassord.TabIndex = 18
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(42, 176)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 17
        '
        'txtPersonnummer
        '
        Me.txtPersonnummer.Location = New System.Drawing.Point(42, 137)
        Me.txtPersonnummer.Name = "txtPersonnummer"
        Me.txtPersonnummer.Size = New System.Drawing.Size(100, 20)
        Me.txtPersonnummer.TabIndex = 16
        '
        'btnNybruker
        '
        Me.btnNybruker.Location = New System.Drawing.Point(42, 280)
        Me.btnNybruker.Name = "btnNybruker"
        Me.btnNybruker.Size = New System.Drawing.Size(132, 49)
        Me.btnNybruker.TabIndex = 15
        Me.btnNybruker.Text = "Lag ny bruker"
        Me.btnNybruker.UseVisualStyleBackColor = True
        '
        'lblBekreftpass
        '
        Me.lblBekreftpass.AutoSize = True
        Me.lblBekreftpass.Location = New System.Drawing.Point(40, 238)
        Me.lblBekreftpass.Name = "lblBekreftpass"
        Me.lblBekreftpass.Size = New System.Drawing.Size(81, 13)
        Me.lblBekreftpass.TabIndex = 14
        Me.lblBekreftpass.Text = "Bekreft passord"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(40, 199)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 13
        Me.lblPassord.Text = "Passord"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(39, 160)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(26, 13)
        Me.lblMail.TabIndex = 12
        Me.lblMail.Text = "Mail"
        '
        'lblPersonnummer
        '
        Me.lblPersonnummer.AutoSize = True
        Me.lblPersonnummer.Location = New System.Drawing.Point(39, 121)
        Me.lblPersonnummer.Name = "lblPersonnummer"
        Me.lblPersonnummer.Size = New System.Drawing.Size(77, 13)
        Me.lblPersonnummer.TabIndex = 11
        Me.lblPersonnummer.Text = "Personnummer"
        '
        'lblNybruker
        '
        Me.lblNybruker.AutoSize = True
        Me.lblNybruker.Font = New System.Drawing.Font("Calibri", 15.25!, System.Drawing.FontStyle.Bold)
        Me.lblNybruker.Location = New System.Drawing.Point(38, 9)
        Me.lblNybruker.Name = "lblNybruker"
        Me.lblNybruker.Size = New System.Drawing.Size(98, 26)
        Me.lblNybruker.TabIndex = 10
        Me.lblNybruker.Text = "Ny Bruker"
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(42, 98)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(100, 20)
        Me.txtEtternavn.TabIndex = 23
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(42, 59)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(100, 20)
        Me.txtFornavn.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Etternavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fornavn"
        '
        'NyBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 341)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
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
        Me.Name = "NyBruker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBekreftpass As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtPersonnummer As TextBox
    Private WithEvents btnNybruker As Button
    Friend WithEvents lblBekreftpass As Label
    Friend WithEvents lblPassord As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblPersonnummer As Label
    Friend WithEvents lblNybruker As Label
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
