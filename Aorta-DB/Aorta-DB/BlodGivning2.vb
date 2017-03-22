Public Class BlodGivning2
    Private Sub BlodGivning2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("O+")
        ComboBox1.Items.Add("O-")
        ComboBox1.Items.Add("A+")
        ComboBox1.Items.Add("A-")
        ComboBox1.Items.Add("B+")
        ComboBox1.Items.Add("B-")
        ComboBox1.Items.Add("AB+")
        ComboBox1.Items.Add("AB-")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Blodtype" Then
            MsgBox("velg type")
        Else

        End If
    End Sub
End Class