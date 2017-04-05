Imports System.ComponentModel

Public Class TimebestillingAnsatt

    Private Sub TimebestillingAnsatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd.MM.yyyy"

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

        DateTimePicker1.MinDate = DateTime.Now.AddDays(1)
    End Sub
    Public Function check_date(date_pick As String)
        Dim siste_time As Date = CDate(date_pick)
        Dim valgt_time As Date = CDate(DateTimePicker1.Text)
        Dim ny_time_lovlig As Date = siste_time.AddDays(90)
        If ny_time_lovlig >= valgt_time Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        Dim list As ArrayList = get_appointment_date(bruker.getPersonnr)
        Dim time As String = ComboBox1.Text & "." & ComboBox2.Text
        If list.Count > 0 Then
            If check_date(list(0)) = 1 Then
                If get_appointment_user(time, DateTimePicker1.Text) = 0 Then
                    Dim result As Integer = MessageBox.Show("Er du sikker på at du vil ha time " & DateTimePicker1.Text & " klokka " & ComboBox1.Text & ":" & ComboBox2.Text, "Timebestilling", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        create_appointment(bruker.getPersonnr, time, DateTimePicker1.Text)
                        Me.Close()
                    End If
                ElseIf get_appointment_user(time, DateTimePicker1.Text) = bruker.getPersonnr Then
                    MsgBox("Du har allerede bestillt denne timen")
                Else
                    MsgBox("Denne timen er allerede tatt")
                End If
            Else
                MsgBox("Denne timer er ikke 90 dager etter din siste time")
            End If
        Else
            If get_appointment_user(time, DateTimePicker1.Text) = 0 Then
                Dim result As Integer = MessageBox.Show("Er du sikker på at du vil ha time " & DateTimePicker1.Text & " klokka " & ComboBox1.Text & ":" & ComboBox2.Text, "Timebestilling", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    create_appointment(bruker.getPersonnr, time, DateTimePicker1.Text)
                    Me.Close()
                End If
            ElseIf get_appointment_user(time, DateTimePicker1.Text) = bruker.getPersonnr Then
                MsgBox("Du har allerede bestillt denne timen")
            Else
                MsgBox("Denne timen er allerede tatt")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TimeBestilling_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AnsattBrukerOversikt.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim Timer As ArrayList
        Timer = get_appointments_user(DateTimePicker1.Text)
        For Each item In Timer
            ListBox1.Items.Add(item(0))
        Next
    End Sub
End Class