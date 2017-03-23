<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IktHovedside
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IktHovedside))
        Me.btnNyAnsatt = New System.Windows.Forms.Button()
        Me.btnStatestikk = New System.Windows.Forms.Button()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNyAnsatt
        '
        Me.btnNyAnsatt.Location = New System.Drawing.Point(98, 103)
        Me.btnNyAnsatt.Name = "btnNyAnsatt"
        Me.btnNyAnsatt.Size = New System.Drawing.Size(97, 33)
        Me.btnNyAnsatt.TabIndex = 0
        Me.btnNyAnsatt.Text = "Ny ansatt"
        Me.btnNyAnsatt.UseVisualStyleBackColor = True
        '
        'btnStatestikk
        '
        Me.btnStatestikk.Location = New System.Drawing.Point(98, 142)
        Me.btnStatestikk.Name = "btnStatestikk"
        Me.btnStatestikk.Size = New System.Drawing.Size(97, 33)
        Me.btnStatestikk.TabIndex = 0
        Me.btnStatestikk.Text = "Statestikk"
        Me.btnStatestikk.UseVisualStyleBackColor = True
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Location = New System.Drawing.Point(13, 13)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(75, 23)
        Me.btnLoggUt.TabIndex = 1
        Me.btnLoggUt.Text = "logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'IktHovedside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnLoggUt)
        Me.Controls.Add(Me.btnStatestikk)
        Me.Controls.Add(Me.btnNyAnsatt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IktHovedside"
        Me.Text = "IktHovedside"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNyAnsatt As Button
    Friend WithEvents btnStatestikk As Button
    Friend WithEvents btnLoggUt As Button
End Class
