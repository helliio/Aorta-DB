Imports System.ComponentModel
'Siden som lar ansatte sjekke den siste helsesjekken og tilbakemelding på givningstimer
Public Class TimeInfoAnsatt
    Dim timer As Integer = 0

    'Navigerins knapper
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs)
        Me.Close()
        AnsattBrukerOversikt.Show()
    End Sub

    Private Sub TimeInfoAnsatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
        Me.Close()
    End Sub
    Private Sub btnStatestikk_Click(sender As Object, e As EventArgs) Handles btnStatestikk.Click
        statestikk.Show()
        Me.Close()
    End Sub

    Private Sub btnSjekkBlod_Click(sender As Object, e As EventArgs) Handles btnSjekkBlod.Click
        InnkallingBaserPaaBehov.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        Ansatt.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click_1(sender As Object, e As EventArgs) Handles btnBestill.Click
        blodbank.Show()
        Me.Close()
    End Sub

    Private Sub btnTilbake_Click_1(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattBrukerOversikt.Show()
        Me.Close()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Ansatt.Close()
        Me.Hide()
    End Sub

    'Laster inn helsesjekken
    Private Sub TimeInfoAnsatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list1 As ArrayList = get_appointment_date(bruker.getPersonnr)
        Dim dt_list1 As New ArrayList
        Dim d1 = DateTime.Now
        For Each item In list1
            dt_list1.Add(CDate(item))
        Next
        For Each item As Date In dt_list1
            If item >= d1 Then
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                Timer += 1
            End If
        Next
        Dim helsesjekk As New ArrayList
        Try
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
        Catch
            listboxHelsesjekk.Items.Add("Du har ikke hatt helsesjekk enda")
        End Try
        Dim list As ArrayList = get_appointment_date_only(bruker.getPersonnr)
        Dim dt_list As New ArrayList
        Dim d = DateTime.Now
        For Each item In list
            dt_list.Add(CDate(item))
        Next
        For Each item As Date In dt_list
            If item < d Then
                Dim i As String = item.ToString("dd.MM.yyyy")
                listboxTimer.Items.Add(i)
            End If
        Next

    End Sub

    'Laster inn info om valgt givningstime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listboxGivningsInfo.Items.Clear()
        Try
            Dim timeinfo As New ArrayList
            timeinfo = get_appointment_info(bruker.getPersonnr, listboxTimer.SelectedItem)
            listboxGivningsInfo.Items.Add("Din blodtype er: " & timeinfo(0))
            listboxGivningsInfo.Items.Add("Din blodprosent er: " & timeinfo(1))
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
        Catch ex As Exception
            listboxGivningsInfo.Items.Add("denne timen har ikke")
            listboxGivningsInfo.Items.Add("fått noe svar fra labben")
        End Try
    End Sub
End Class