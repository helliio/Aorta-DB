Imports System.ComponentModel

Public Class Statestikk

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Hide()
    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
        Me.Hide()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        blodbank.Show()
        Me.Hide()
    End Sub

    Private Sub btnSjekkBlod_Click(sender As Object, e As EventArgs) Handles btnSjekkBlod.Click
        InnkallingBaserPaaBehov.Show()
        Me.Hide()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        Ansatt.Show()
        Me.Hide()
    End Sub

    Private Sub Statestikk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Statestikk_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Ansatt.Show()
        Me.Hide()
    End Sub
End Class