Public Class InfoBruker
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        BrukerHovedside.Show()
        Me.Hide()
    End Sub

    Private Sub InfoBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim helsesjekk As New ArrayList
        helsesjekk = find_helsesjekk(bruker.getPersonnr)
        listboxInfo.Items.Add("Din blodtype er: " & helsesjekk(0))
        listboxInfo.Items.Add("Din blodprosent er: " & helsesjekk(1) & "%")
        If helsesjekk(2) = False Then
            listboxInfo.Items.Add("Du har ikke syfilis")
        Else
            listboxInfo.Items.Add("Du har syfilis")
        End If
        If helsesjekk(3) = False Then
            listboxInfo.Items.Add("Du har ikke HIV")
        Else
            listboxInfo.Items.Add("Du har HIV")
        End If
        If helsesjekk(4) = False Then
            listboxInfo.Items.Add("Du har ikke hepatitt B")
        Else
            listboxInfo.Items.Add("Du har hepatitt B")
        End If
        If helsesjekk(5) = False Then
            listboxInfo.Items.Add("Du har ikke hepatitt C")
        Else
            listboxInfo.Items.Add("Du har hepatitt C")
        End If
    End Sub
End Class