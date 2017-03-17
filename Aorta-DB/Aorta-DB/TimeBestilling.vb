Imports System.ComponentModel

Public Class TimeBestilling

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
        ComboBox1.Items.Add("16")

        ComboBox2.Text = "00"
        ComboBox2.Items.Add("00")
        ComboBox2.Items.Add("10")
        ComboBox2.Items.Add("20")
        ComboBox2.Items.Add("30")
        ComboBox2.Items.Add("40")
        ComboBox2.Items.Add("50")
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        Debug.Print(DateTimePicker1.Text)
        Debug.Print(ComboBox1.Text & ":" & ComboBox2.Text)
        Dim time As String = ComboBox1.Text & ":" & ComboBox2.Text
        Dim result As Integer = MessageBox.Show("Er du sikker på at du vil ha time " & DateTimePicker1.Text & " klokka " & ComboBox1.Text & ":" & ComboBox2.Text, "Timebestilling", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            create_appointment(bruker.getPersonnr, time, DateTimePicker1.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TimeBestilling_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        BrukerHovedside.Show()
        Me.Hide()
    End Sub
End Class