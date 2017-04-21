Imports System.ComponentModel
'denne siden er for instilliger og registreringer til en spesifikk bruker for ansatte
Public Class AnsattBrukerOversikt
    Dim timer As Integer = 0
    'når siden laster inn henter denne funsjonen infor om brukern og setter dem i riktige listboksene
    Private Sub AnsattBrukerOversikt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = 0
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
                lblNesteTime.Text = i
                timer += 1
            End If
        Next


        lblBruker.Text = "Donør: " & bruker.getFornavn() & " " & bruker.getEtternavn()
    End Sub
    'knappen sender brukern til timebestllings side for å bestill time for brukern
    Private Sub btnBestillTime_Click(sender As Object, e As EventArgs) Handles btnBestillTime.Click
        If timer = 1 Then
            MsgBox("Du kan ikke ha mer enn en time")
        Else
            TimebestillingAnsatt.Show()
            Me.Close()
        End If
    End Sub
    'denne knappen avbestiller neste timen for brukern.
    Private Sub btnAvbestill_Click(sender As Object, e As EventArgs) Handles btnAvbestill.Click
        Dim dato As String = lblNesteTime.Text
        If timer <> 1 Then
            MsgBox("Du har ingen timer å avbestille")
        Else
            Dim result As Integer = MessageBox.Show("Er du sikker på at du vil avbestille timen ", "Avbestilling", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim list = Split(dato, " ")
                lblNesteTime.Text = ""
                cancel_appointment(bruker.getPersonnr, list(0), list(1))
                timer = 0
            End If
        End If
    End Sub
    'lukker programmet
    Private Sub AnsattBrukerOversikt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
    'setter opp nytt blodgivning(hvis bruken har allerede fullført egenerklaring og helseskjekk)
    Private Sub btnNyGivning_Click(sender As Object, e As EventArgs) Handles btnNyGivning.Click
        If check_helsesjekk(bruker.getPersonnr) = True Then
            If check_egenerklaering(bruker.getPersonnr) = True Then
                Global_val.giver_id = CDec(bruker.getPersonnr)
                BlodGivning.Show()
                Me.Hide()
            Else
                MsgBox("Denne brukeren må gjøre egenerklæringen før han/hun kan gi blod")
            End If
        Else
            MsgBox("Denne bruker må gjøre en helsesjekk før han/hun kan gi blod")
        End If
    End Sub
    'knapper for å bytte faner
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Me.Close()
        TimeInfoAnsatt.Show()
    End Sub

    Private Sub btnFørstegangsInfo_Click(sender As Object, e As EventArgs) Handles btnFørstegangsInfo.Click
        Me.Close()
        InfoDonor.Show()
    End Sub
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
        Ansatt.Close()
    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        blodbank.Show()
        Me.Close()
    End Sub

    Private Sub btnStatestikk_Click(sender As Object, e As EventArgs) Handles btnStatestikk.Click
        Statestikk.Show()
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
End Class