Public Class InfoBruker
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        BrukerHovedside.Show()
        Me.Hide()
    End Sub

    Private Sub InfoBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim helsesjekk As New ArrayList
        helsesjekk = find_helsesjekk(bruker.getPersonnr)
        listboxHelsesjekk.Items.Add("Din blodtype er: " & helsesjekk(0))
        listboxHelsesjekk.Items.Add("Din blodprosent er: " & helsesjekk(1) & "%")
        If helsesjekk(2) = False Then
            listboxHelsesjekk.Items.Add("Du har ikke syfilis")
        Else
            listboxHelsesjekk.Items.Add("Du har syfilis")
        End If
        If helsesjekk(3) = False Then
            listboxHelsesjekk.Items.Add("Du har ikke HIV")
        Else
            listboxHelsesjekk.Items.Add("Du har HIV")
        End If
        If helsesjekk(4) = False Then
            listboxHelsesjekk.Items.Add("Du har ikke hepatitt B")
        Else
            listboxHelsesjekk.Items.Add("Du har hepatitt B")
        End If
        If helsesjekk(5) = False Then
            listboxHelsesjekk.Items.Add("Du har ikke hepatitt C")
        Else
            listboxHelsesjekk.Items.Add("Du har hepatitt C")
        End If

        Dim timer As New ArrayList
        timer = get_appointment_date_only(bruker.getPersonnr)
        For Each item In timer
            listboxTimer.Items.Add(item)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim timeinfo As New ArrayList
        timeinfo = get_appointment_info(bruker.getPersonnr, listboxTimer.SelectedItem)
        listboxGivningsInfo.Items.Clear()
        listboxGivningsInfo.Items.Add("Din blodtype er :" & timeinfo(0))
        listboxGivningsInfo.Items.Add("Din blodprosent er :" & timeinfo(1))
        If timeinfo(2) = False Then
            listboxGivningsInfo.Items.Add("Du har ikke HIV")
        Else
            listboxGivningsInfo.Items.Add("Du har HIV")
        End If
        If timeinfo(3) = False Then
            listboxGivningsInfo.Items.Add("Du har ikke hepatitt B")
        Else
            listboxGivningsInfo.Items.Add("Du har hepatitt B")
        End If
        If timeinfo(4) = False Then
            listboxGivningsInfo.Items.Add("Du har ikke hepatitt C")
        Else
            listboxGivningsInfo.Items.Add("Du har hepatitt C")
        End If
        listboxGivningsInfo.Items.Add("Kommentar: " & timeinfo(5))
    End Sub
End Class