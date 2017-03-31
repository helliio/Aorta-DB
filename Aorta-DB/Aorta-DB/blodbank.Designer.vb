<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blodbank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(blodbank))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadioButtonPlus = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMinus = New System.Windows.Forms.RadioButton()
        Me.NumericRode = New System.Windows.Forms.NumericUpDown()
        Me.NumericPlasma = New System.Windows.Forms.NumericUpDown()
        Me.NumericPlater = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.NumericRode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericPlasma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericPlater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(535, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(149, 134)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(276, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "bestille"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "blodprodukter"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(123, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Text = "Velg blodtype"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(117, 177)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "røde blodlegemer"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(232, 177)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "plasma"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(328, 177)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "blodplater"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "blodprodukt i ML"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(620, 282)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "min side"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RadioButtonPlus
        '
        Me.RadioButtonPlus.AutoSize = True
        Me.RadioButtonPlus.Location = New System.Drawing.Point(137, 60)
        Me.RadioButtonPlus.Name = "RadioButtonPlus"
        Me.RadioButtonPlus.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonPlus.TabIndex = 17
        Me.RadioButtonPlus.TabStop = True
        Me.RadioButtonPlus.Text = "RH+"
        Me.RadioButtonPlus.UseVisualStyleBackColor = True
        '
        'RadioButtonMinus
        '
        Me.RadioButtonMinus.AutoSize = True
        Me.RadioButtonMinus.Checked = True
        Me.RadioButtonMinus.Location = New System.Drawing.Point(137, 83)
        Me.RadioButtonMinus.Name = "RadioButtonMinus"
        Me.RadioButtonMinus.Size = New System.Drawing.Size(44, 17)
        Me.RadioButtonMinus.TabIndex = 18
        Me.RadioButtonMinus.TabStop = True
        Me.RadioButtonMinus.Text = "RH-"
        Me.RadioButtonMinus.UseVisualStyleBackColor = True
        '
        'NumericRode
        '
        Me.NumericRode.Enabled = False
        Me.NumericRode.Location = New System.Drawing.Point(117, 200)
        Me.NumericRode.Name = "NumericRode"
        Me.NumericRode.Size = New System.Drawing.Size(107, 20)
        Me.NumericRode.TabIndex = 19
        '
        'NumericPlasma
        '
        Me.NumericPlasma.Enabled = False
        Me.NumericPlasma.Location = New System.Drawing.Point(232, 200)
        Me.NumericPlasma.Name = "NumericPlasma"
        Me.NumericPlasma.Size = New System.Drawing.Size(90, 20)
        Me.NumericPlasma.TabIndex = 20
        '
        'NumericPlater
        '
        Me.NumericPlater.Enabled = False
        Me.NumericPlater.Location = New System.Drawing.Point(328, 200)
        Me.NumericPlater.Name = "NumericPlater"
        Me.NumericPlater.Size = New System.Drawing.Size(92, 20)
        Me.NumericPlater.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(535, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'blodbank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 327)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NumericPlater)
        Me.Controls.Add(Me.NumericPlasma)
        Me.Controls.Add(Me.NumericRode)
        Me.Controls.Add(Me.RadioButtonMinus)
        Me.Controls.Add(Me.RadioButtonPlus)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "blodbank"
        Me.Text = "blodbank"
        CType(Me.NumericRode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericPlasma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericPlater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButtonPlus As RadioButton
    Friend WithEvents RadioButtonMinus As RadioButton
    Friend WithEvents NumericRode As NumericUpDown
    Friend WithEvents NumericPlasma As NumericUpDown
    Friend WithEvents NumericPlater As NumericUpDown
    Friend WithEvents Button4 As Button
End Class
