<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoggInn = New System.Windows.Forms.Button()
        Me.btnEgenerklæring = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoggInn
        '
        Me.btnLoggInn.Location = New System.Drawing.Point(109, 204)
        Me.btnLoggInn.Name = "btnLoggInn"
        Me.btnLoggInn.Size = New System.Drawing.Size(101, 39)
        Me.btnLoggInn.TabIndex = 0
        Me.btnLoggInn.Text = "Logg inn"
        Me.btnLoggInn.UseVisualStyleBackColor = True
        '
        'btnEgenerklæring
        '
        Me.btnEgenerklæring.Location = New System.Drawing.Point(364, 204)
        Me.btnEgenerklæring.Name = "btnEgenerklæring"
        Me.btnEgenerklæring.Size = New System.Drawing.Size(104, 39)
        Me.btnEgenerklæring.TabIndex = 0
        Me.btnEgenerklæring.Text = "Egenerklæring"
        Me.btnEgenerklæring.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.btnEgenerklæring)
        Me.Controls.Add(Me.btnLoggInn)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoggInn As Button
    Friend WithEvents btnEgenerklæring As Button
End Class
