<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlodGivning
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
        Me.listboxEgenerklæring = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNeste = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listboxEgenerklæring
        '
        Me.listboxEgenerklæring.FormattingEnabled = True
        Me.listboxEgenerklæring.Location = New System.Drawing.Point(12, 32)
        Me.listboxEgenerklæring.Name = "listboxEgenerklæring"
        Me.listboxEgenerklæring.Size = New System.Drawing.Size(790, 212)
        Me.listboxEgenerklæring.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(844, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Ja/Nei"
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(832, 221)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(79, 23)
        Me.btnOppdater.TabIndex = 2
        Me.btnOppdater.Text = "Oppdater info"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(851, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Godkjent"
        '
        'btnNeste
        '
        Me.btnNeste.Location = New System.Drawing.Point(832, 141)
        Me.btnNeste.Name = "btnNeste"
        Me.btnNeste.Size = New System.Drawing.Size(75, 23)
        Me.btnNeste.TabIndex = 4
        Me.btnNeste.Text = "Neste"
        Me.btnNeste.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(12, 3)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 5
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'BlodGivning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnNeste)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOppdater)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.listboxEgenerklæring)
        Me.Name = "BlodGivning"
        Me.Text = "BlodGivning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listboxEgenerklæring As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnOppdater As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNeste As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents Label2 As Label
End Class
