Imports System.ComponentModel
'fjerde side i egenerklaringen
Public Class EgenErklaering4
    'tilbake knapp
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering3.Show()
        Me.Hide()
    End Sub
    'hånterer lukking av side
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
    'resetter radioknappene
    Public Sub clear()
        radbtnja29.Checked = False
        radbtnnei29.Checked = True
    End Sub
    'tar deg til neste side
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(29, radbtnja29.Checked)
        EgenErklaering5.Show()
        Me.Hide()
    End Sub
    'navigerings knapper
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