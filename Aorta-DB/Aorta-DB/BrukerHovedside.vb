Public Class BrukerHovedside
    Private Sub BrukerHovedside_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub BrukerHovedside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As ArrayList = get_appointment_date(bruker.getPersonnr)
        Dim dt_list As New ArrayList
        Dim d = DateTime.Now
        For Each item In list
            dt_list.Add(CDate(item))
        Next
        For Each item As Date In dt_list
            If item < d Then
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                listboxGivinger.Items.Add(i)
            Else
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                Debug.Print(i)
                listboxInfo.Items.Add(i)
            End If
        Next

        lblBruker.Text = "Velkommen " & bruker.getFornavn() & " " & bruker.getEtternavn()
        'listboxInfo.Items.Add("Blodtype: ")
        'listboxInfo.Items.Add("Antall givninger: " & list.Count)
        'listboxInfo.Items.Add("Neste givning: "

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        InfoBruker.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        TimeBestilling.Show()
        Me.Hide()
    End Sub

    Private Sub btnAvbestill_Click(sender As Object, e As EventArgs) Handles btnAvbestill.Click
        Dim dato As String = listboxInfo.SelectedItem
        Dim result As Integer = MessageBox.Show("Er du sikker på at du vil avbestille timen ", "Avbestilling", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim list = Split(dato, " ")

            cancel_appointment(bruker.getPersonnr, list(0), list(1))
        End If
    End Sub
End Class