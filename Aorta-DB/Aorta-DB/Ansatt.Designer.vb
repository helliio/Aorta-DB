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
        Me.listGivninger = New System.Windows.Forms.ListBox()
        Me.btnGivninger = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAnsatt
        '
        Me.lblAnsatt.AutoSize = True
        Me.lblAnsatt.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsatt.Location = New System.Drawing.Point(21, 27)
        Me.lblAnsatt.Name = "lblAnsatt"
        Me.lblAnsatt.Size = New System.Drawing.Size(89, 32)
        Me.lblAnsatt.TabIndex = 0
        Me.lblAnsatt.Text = "Ansatt"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(29, 100)
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
        Me.lblSok.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSok.Location = New System.Drawing.Point(442, 61)
        Me.lblSok.Name = "lblSok"
        Me.lblSok.Size = New System.Drawing.Size(114, 15)
        Me.lblSok.TabIndex = 3
        Me.lblSok.Text = "Søk på en blodgiver"
        '
        'txtSok
        '
        Me.txtSok.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSok.Location = New System.Drawing.Point(444, 80)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(119, 21)
        Me.txtSok.TabIndex = 4
        Me.txtSok.Text = "Skriv inn personnummer"
        '
        'btnSok
        '
        Me.btnSok.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSok.Location = New System.Drawing.Point(566, 79)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(42, 22)
        Me.btnSok.TabIndex = 5
        Me.btnSok.Text = "Søk"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'listGivninger
        '
        Me.listGivninger.FormattingEnabled = True
        Me.listGivninger.Location = New System.Drawing.Point(444, 238)
        Me.listGivninger.Name = "listGivninger"
        Me.listGivninger.Size = New System.Drawing.Size(164, 95)
        Me.listGivninger.TabIndex = 7
        '
        'btnGivninger
        '
        Me.btnGivninger.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGivninger.Location = New System.Drawing.Point(444, 339)
        Me.btnGivninger.Name = "btnGivninger"
        Me.btnGivninger.Size = New System.Drawing.Size(164, 65)
        Me.btnGivninger.TabIndex = 9
        Me.btnGivninger.Text = "Kalender"
        Me.btnGivninger.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Registrer ny blodtapping"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoggUt.Location = New System.Drawing.Point(535, 459)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(73, 30)
        Me.btnLoggUt.TabIndex = 11
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(235, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 65)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Bestill blod"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 141)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Årlig slutter mellom 15.000 og 17.000 å gi blod pga. høy alder, flytting eller an" &
    "net. Disse må erstattes og det er her du kommer inn."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Blotappingstimer i dag.."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 296)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "fjern denne"
        '
        'Ansatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnLoggUt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGivninger)
        Me.Controls.Add(Me.listGivninger)
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
    Friend WithEvents listGivninger As ListBox
    Friend WithEvents btnGivninger As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
