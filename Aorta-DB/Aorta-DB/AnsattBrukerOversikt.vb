Imports System.ComponentModel

Public Class AnsattBrukerOversikt
    Dim timer As Integer = 0

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

    Private Sub btnBestillTime_Click(sender As Object, e As EventArgs) Handles btnBestillTime.Click
        If timer = 1 Then
            MsgBox("Du kan ikke ha mer enn en time")
        Else
            TimebestillingAnsatt.Show()
            Me.Close()
        End If
    End Sub

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

    Private Sub AnsattBrukerOversikt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub btnNyGivning_Click(sender As Object, e As EventArgs) Handles btnNyGivning.Click
        If timer = 1 Then
            If check_helsesjekk(bruker.getPersonnr) = True Then
                If check_egenerklaering(bruker.getPersonnr) = True Then
                    Global_val.giver_id = CDec(bruker.getPersonnr)
                    BlodGivning.Show()
                Else
                    MsgBox("Denne brukeren må gjøre egenerklæringen før han/hun kan gi blod")
                End If
            Else
                MsgBox("Denne bruker må gjøre en helsesjekk før han/hun kan gi blod")
            End If
        Else
            MsgBox("Brukeren må ha en time for å gi blod")
        End If
    End Sub

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