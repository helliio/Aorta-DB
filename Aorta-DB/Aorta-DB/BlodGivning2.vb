Public Class BlodGivning2
    Private Sub BlodGivning2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Ansatt.Show()
    End Sub

    Private Sub BlodGivning2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blodtype As String = find_blodtype(bruker.getPersonnr)
        ComboBox1.Items.Add("O+")
        ComboBox1.Items.Add("O-")
        ComboBox1.Items.Add("A+")
        ComboBox1.Items.Add("A-")
        ComboBox1.Items.Add("B+")
        ComboBox1.Items.Add("B-")
        ComboBox1.Items.Add("AB+")
        ComboBox1.Items.Add("AB-")
        ComboBox1.Text = blodtype
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        blod = New Blod_pakke(giver_id, ComboBox1.Text, NumericUpDown1.Value, CheckHiv.Checked, CheckHepatittB.Checked, CheckHepatittC.Checked, TextBox1.Text)
        blod.send()
        Close()
    End Sub
End Class