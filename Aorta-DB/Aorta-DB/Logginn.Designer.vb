﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logginn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logginn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPersonnummer = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNyBruker = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logg Inn"
        '
        'TxtPersonnummer
        '
        Me.TxtPersonnummer.Location = New System.Drawing.Point(94, 70)
        Me.TxtPersonnummer.Name = "TxtPersonnummer"
        Me.TxtPersonnummer.Size = New System.Drawing.Size(100, 20)
        Me.TxtPersonnummer.TabIndex = 1
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(94, 113)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(100, 20)
        Me.txtPassord.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 21)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Glemt passord?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 52)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Logg inn"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Passord:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Personnummer:"
        '
        'btnNyBruker
        '
        Me.btnNyBruker.Location = New System.Drawing.Point(94, 143)
        Me.btnNyBruker.Name = "btnNyBruker"
        Me.btnNyBruker.Size = New System.Drawing.Size(98, 21)
        Me.btnNyBruker.TabIndex = 3
        Me.btnNyBruker.Text = "Ny bruker"
        Me.btnNyBruker.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(13, 13)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(65, 22)
        Me.btnTilbake.TabIndex = 5
        Me.btnTilbake.Text = "TIlbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Logginn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNyBruker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.TxtPersonnummer)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Logginn"
        Me.Text = "Logg inn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPersonnummer As TextBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNyBruker As Button
    Friend WithEvents btnTilbake As Button
End Class
