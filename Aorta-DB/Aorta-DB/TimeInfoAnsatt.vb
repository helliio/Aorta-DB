Imports System.ComponentModel

Public Class TimeInfoAnsatt
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs)
        Me.Close()
        AnsattBrukerOversikt.Show()
    End Sub

    Private Sub TimeInfoAnsatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub TimeInfoAnsatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
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

    Private Sub btnBestill_Click_1(sender As Object, e As EventArgs) Handles btnBestill.Click
        blodbank.Show()
        Me.Close()
    End Sub

    Private Sub btnTilbake_Click_1(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattBrukerOversikt.Show()
        Me.Close()
    End Sub

    Private Sub btnLoggUt_Click_1(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Ansatt.Close()
        Me.Hide()
    End Sub
End Class