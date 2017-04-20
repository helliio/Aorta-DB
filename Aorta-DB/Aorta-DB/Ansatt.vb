Imports System.ComponentModel

Public Class Ansatt
    Private Sub Ansatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub Ansatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dag = Format(Date.Now(), "dd.MM.yyyy")
        lblAnsatt.Text = bruker.getFornavn() & " " & bruker.getEtternavn()
        Dim dagensTimer As ArrayList
        dagensTimer = get_appointments_ansatt(dag)
        For Each item In dagensTimer
            Dim out As String
            out = item(0) & " " & item(1) & " " & item(2)
            listGivninger.Items.Add(out)
        Next
    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim id As Decimal = login2(txtSok.Text)
        If id <> 0 Then
            Global_val.bruker = New User(id)
            If bruker.getUserType = 0 Then
                AnsattBrukerOversikt.Show()
                Me.Hide()
                txtSok.Text = ""
            End If
        End If

    End Sub
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Me.Close()
        Main.Show()
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
End Class