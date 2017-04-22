Imports System.ComponentModel
'syuvende side i egenerklaring
Public Class EgenErklaering7
    'tilbake knapp
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering6.Show()
        Me.Hide()
    End Sub
    'hånterer lukking av siden
    Private Sub EgenErklaering7_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering3.clear()
        EgenErklaering4.clear()
        EgenErklaering5.clear()
        EgenErklaering6.clear()
        EgenErklaering.clear()
        EgenErklaering8.clear()
    End Sub
    'resetter radiokanppene
    Public Sub clear()
        radbtnja49.Checked = False
        radbtnnei49.Checked = True
    End Sub
    'knapp til neste side
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(49, radbtnja49.Checked)
        EgenErklaering8.Show()
        Me.Hide()
    End Sub
    'navigasjonskanpper
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
End Class