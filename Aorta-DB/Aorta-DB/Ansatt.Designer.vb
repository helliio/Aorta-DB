<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ansatt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ansatt))
        Me.lblAnsatt = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblting = New System.Windows.Forms.Label()
        Me.lblSok = New System.Windows.Forms.Label()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.listBrukere = New System.Windows.Forms.ListBox()
        Me.listGivninger = New System.Windows.Forms.ListBox()
        Me.btnBrukere = New System.Windows.Forms.Button()
        Me.btnGivninger = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAnsatt
        '
        Me.lblAnsatt.AutoSize = True
        Me.lblAnsatt.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsatt.Location = New System.Drawing.Point(28, 27)
        Me.lblAnsatt.Name = "lblAnsatt"
        Me.lblAnsatt.Size = New System.Drawing.Size(87, 33)
        Me.lblAnsatt.TabIndex = 0
        Me.lblAnsatt.Text = "Ansatt"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(30, 100)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(36, 19)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Info"
        '
        'lblting
        '
        Me.lblting.AutoSize = True
        Me.lblting.Location = New System.Drawing.Point(12, 119)
        Me.lblting.Name = "lblting"
        Me.lblting.Size = New System.Drawing.Size(115, 13)
        Me.lblting.TabIndex = 2
        Me.lblting.Text = "------------------------------------"
        '
        'lblSok
        '
        Me.lblSok.AutoSize = True
        Me.lblSok.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSok.Location = New System.Drawing.Point(405, 9)
        Me.lblSok.Name = "lblSok"
        Me.lblSok.Size = New System.Drawing.Size(97, 14)
        Me.lblSok.TabIndex = 3
        Me.lblSok.Text = "Søk på en bruker"
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(408, 26)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(119, 20)
        Me.txtSok.TabIndex = 4
        Me.txtSok.Text = "Skriv inn personnummer"
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(535, 27)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(42, 20)
        Me.btnSok.TabIndex = 5
        Me.btnSok.Text = "Søk"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'listBrukere
        '
        Me.listBrukere.FormattingEnabled = True
        Me.listBrukere.Location = New System.Drawing.Point(292, 109)
        Me.listBrukere.Name = "listBrukere"
        Me.listBrukere.Size = New System.Drawing.Size(120, 95)
        Me.listBrukere.TabIndex = 6
        '
        'listGivninger
        '
        Me.listGivninger.FormattingEnabled = True
        Me.listGivninger.Location = New System.Drawing.Point(436, 109)
        Me.listGivninger.Name = "listGivninger"
        Me.listGivninger.Size = New System.Drawing.Size(120, 95)
        Me.listGivninger.TabIndex = 7
        '
        'btnBrukere
        '
        Me.btnBrukere.Location = New System.Drawing.Point(292, 210)
        Me.btnBrukere.Name = "btnBrukere"
        Me.btnBrukere.Size = New System.Drawing.Size(120, 32)
        Me.btnBrukere.TabIndex = 8
        Me.btnBrukere.Text = "Godkjenn bruker"
        Me.btnBrukere.UseVisualStyleBackColor = True
        '
        'btnGivninger
        '
        Me.btnGivninger.Location = New System.Drawing.Point(436, 210)
        Me.btnGivninger.Name = "btnGivninger"
        Me.btnGivninger.Size = New System.Drawing.Size(120, 32)
        Me.btnGivninger.TabIndex = 9
        Me.btnGivninger.Text = "Kalender"
        Me.btnGivninger.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 80)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ny blodgivning"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Location = New System.Drawing.Point(502, 426)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(75, 23)
        Me.btnLoggUt.TabIndex = 11
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "11223344556"
        '
        'Ansatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnLoggUt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGivninger)
        Me.Controls.Add(Me.btnBrukere)
        Me.Controls.Add(Me.listGivninger)
        Me.Controls.Add(Me.listBrukere)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.txtSok)
        Me.Controls.Add(Me.lblSok)
        Me.Controls.Add(Me.lblting)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblAnsatt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ansatt"
        Me.Text = "Ansatt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnsatt As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblting As Label
    Friend WithEvents lblSok As Label
    Friend WithEvents txtSok As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents listBrukere As ListBox
    Friend WithEvents listGivninger As ListBox
    Friend WithEvents btnBrukere As Button
    Friend WithEvents btnGivninger As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents TextBox1 As TextBox
End Class
