Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As ArrayList = get_appointment_date(12345678913)
        Dim siste_time As String = list(0)
        Dim dt = DateTime.ParseExact(siste_time, "HH:mm dd/MM/yyyy", Nothing)
        Debug.Print(dt)
        Dim newdate As Date = dt.AddDays(3)
        Debug.Print(newdate)
        If dt < newdate Then
            Debug.Print("hello")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TimeBestilling.Show()
    End Sub


End Class
