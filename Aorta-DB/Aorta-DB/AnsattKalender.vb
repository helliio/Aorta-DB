Public Class AnsattKalender
    Private Sub AnsattKalender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd.MM.yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim Timer As ArrayList
        Timer = get_appointments_ansatt(DateTimePicker1.Text)
        For Each item In Timer
            Dim out As String
            out = item(0) & " " & item(1) & " " & item(2)
            ListBox1.Items.Add(out)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ansatt.Show()
        Me.Hide()
    End Sub
End Class