Public Class InnkallingBaserPaaBehov
    Private Sub InnkallingBaserPaaBehov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("O+")
        ComboBox1.Items.Add("O-")
        ComboBox1.Items.Add("A+")
        ComboBox1.Items.Add("A-")
        ComboBox1.Items.Add("B+")
        ComboBox1.Items.Add("B-")
        ComboBox1.Items.Add("AB+")
        ComboBox1.Items.Add("AB-")
        ComboBox1.Text = "Velg blodtype"
    End Sub
End Class