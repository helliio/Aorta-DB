Public Class blodbank
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub blodbank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("AB")
        ComboBox1.Items.Add("O")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then

        Else MsgBox("må velge rh- eller rh+")
        End If
        If RadioButton2.Checked Then

        Else MsgBox("må velge rh- eller rh+")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub



    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        NumericUpDown1.Enabled = CheckBox3.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        NumericUpDown2.Enabled = CheckBox2.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        NumericUpDown3.Enabled = CheckBox1.Checked
    End Sub
End Class