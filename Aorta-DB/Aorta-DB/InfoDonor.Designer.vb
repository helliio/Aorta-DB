<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoDonor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoDonor))
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.checkSyflis = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numHemoglobin = New System.Windows.Forms.NumericUpDown()
        Me.checkHiv = New System.Windows.Forms.CheckBox()
        Me.checkHepatittB = New System.Windows.Forms.CheckBox()
        Me.checkHepatittC = New System.Windows.Forms.CheckBox()
        Me.btnLagreInfo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.numHemoglobin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(12, 12)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 0
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Blodtype:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(253, 128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'checkSyflis
        '
        Me.checkSyflis.AutoSize = True
        Me.checkSyflis.Location = New System.Drawing.Point(254, 183)
        Me.checkSyflis.Name = "checkSyflis"
        Me.checkSyflis.Size = New System.Drawing.Size(113, 17)
        Me.checkSyflis.TabIndex = 7
        Me.checkSyflis.Text = "Har brukeren syflis"
        Me.checkSyflis.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hemoglobin:"
        '
        'numHemoglobin
        '
        Me.numHemoglobin.Location = New System.Drawing.Point(254, 157)
        Me.numHemoglobin.Name = "numHemoglobin"
        Me.numHemoglobin.Size = New System.Drawing.Size(120, 20)
        Me.numHemoglobin.TabIndex = 9
        '
        'checkHiv
        '
        Me.checkHiv.AutoSize = True
        Me.checkHiv.Location = New System.Drawing.Point(254, 206)
        Me.checkHiv.Name = "checkHiv"
        Me.checkHiv.Size = New System.Drawing.Size(109, 17)
        Me.checkHiv.TabIndex = 7
        Me.checkHiv.Text = "Har brukeren HIV"
        Me.checkHiv.UseVisualStyleBackColor = True
        '
        'checkHepatittB
        '
        Me.checkHepatittB.AutoSize = True
        Me.checkHepatittB.Location = New System.Drawing.Point(254, 229)
        Me.checkHepatittB.Name = "checkHepatittB"
        Me.checkHepatittB.Size = New System.Drawing.Size(136, 17)
        Me.checkHepatittB.TabIndex = 7
        Me.checkHepatittB.Text = "Har brukeren hepatitt B"
        Me.checkHepatittB.UseVisualStyleBackColor = True
        '
        'checkHepatittC
        '
        Me.checkHepatittC.AutoSize = True
        Me.checkHepatittC.Location = New System.Drawing.Point(254, 252)
        Me.checkHepatittC.Name = "checkHepatittC"
        Me.checkHepatittC.Size = New System.Drawing.Size(136, 17)
        Me.checkHepatittC.TabIndex = 7
        Me.checkHepatittC.Text = "Har brukeren hepatitt C"
        Me.checkHepatittC.UseVisualStyleBackColor = True
        '
        'btnLagreInfo
        '
        Me.btnLagreInfo.Location = New System.Drawing.Point(268, 337)
        Me.btnLagreInfo.Name = "btnLagreInfo"
        Me.btnLagreInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnLagreInfo.TabIndex = 10
        Me.btnLagreInfo.Text = "Lagre info"
        Me.btnLagreInfo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
        '
        'InfoDonor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLagreInfo)
        Me.Controls.Add(Me.numHemoglobin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.checkHepatittC)
        Me.Controls.Add(Me.checkHepatittB)
        Me.Controls.Add(Me.checkHiv)
        Me.Controls.Add(Me.checkSyflis)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTilbake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InfoDonor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoDonor"
        CType(Me.numHemoglobin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTilbake As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents checkSyflis As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numHemoglobin As NumericUpDown
    Friend WithEvents checkHiv As CheckBox
    Friend WithEvents checkHepatittB As CheckBox
    Friend WithEvents checkHepatittC As CheckBox
    Friend WithEvents btnLagreInfo As Button
    Friend WithEvents Label2 As Label
End Class
