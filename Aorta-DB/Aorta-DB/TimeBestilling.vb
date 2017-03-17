Public Class TimeBestilling
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub TimeBestilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        ComboBox1.Text = "08"
        ComboBox1.Items.Add("08")
        ComboBox1.Items.Add("09")
        ComboBox1.Items.Add("10")
        ComboBox1.Items.Add("11")
        ComboBox1.Items.Add("12")
        ComboBox1.Items.Add("13")
        ComboBox1.Items.Add("14")
        ComboBox1.Items.Add("15")

        ComboBox2.Text = "00"
        ComboBox2.Items.Add("00")
        ComboBox2.Items.Add("15")
        ComboBox2.Items.Add("30")
        ComboBox2.Items.Add("45")
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        Debug.Print(DateTimePicker1.Text)
        Debug.Print(ComboBox1.Text & ":" & ComboBox2.Text)
    End Sub
End Class