﻿Public Class BrukerHovedside
    Private Sub BrukerHovedside_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub BrukerHovedside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBruker.Text = "Velkommen " & bruker.getFornavn() & " " & bruker.getEtternavn()
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
End Class