Imports System.ComponentModel

Public Class EgenErklaering4
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering3.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering3.clear()
        EgenErklaering.clear()
        EgenErklaering5.clear()
        EgenErklaering6.clear()
        EgenErklaering7.clear()
        EgenErklaering8.clear()
    End Sub

    Public Sub clear()
        radbtnja29.Checked = False
        radbtnnei29.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(29, radbtnja29.Checked)
        EgenErklaering5.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        MsgBox("Du kan ikke ha mer enn en time")
    End Sub

    Private Sub btnAvbestill2_Click(sender As Object, e As EventArgs)
        MsgBox("Du kan ikke avbestille timen på dette tidspunktet. Gå ut av egenerklæringen og prøv igjen")
    End Sub

    Private Sub btnTimeinfo_Click(sender As Object, e As EventArgs) Handles btnTimeinfo.Click
        InfoBruker.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        BrukerHovedside.Show()
        Me.Close()
    End Sub

    Private Sub EgenErklaering4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class