<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blodprodukter
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listboxBlodGitt = New System.Windows.Forms.ListBox()
        Me.listboxBlodSendt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blodprodukter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Blod gitt i dag"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Blod har blitt sendt til:"
        '
        'listboxBlodGitt
        '
        Me.listboxBlodGitt.FormattingEnabled = True
        Me.listboxBlodGitt.Location = New System.Drawing.Point(12, 101)
        Me.listboxBlodGitt.Name = "listboxBlodGitt"
        Me.listboxBlodGitt.Size = New System.Drawing.Size(120, 95)
        Me.listboxBlodGitt.TabIndex = 1
        '
        'listboxBlodSendt
        '
        Me.listboxBlodSendt.FormattingEnabled = True
        Me.listboxBlodSendt.Location = New System.Drawing.Point(170, 101)
        Me.listboxBlodSendt.Name = "listboxBlodSendt"
        Me.listboxBlodSendt.Size = New System.Drawing.Size(129, 95)
        Me.listboxBlodSendt.TabIndex = 2
        '
        'Blodprodukter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 261)
        Me.Controls.Add(Me.listboxBlodSendt)
        Me.Controls.Add(Me.listboxBlodGitt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Blodprodukter"
        Me.Text = "Blodprodukter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listboxBlodGitt As ListBox
    Friend WithEvents listboxBlodSendt As ListBox
End Class
