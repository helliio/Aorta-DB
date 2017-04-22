Imports System.ComponentModel
'sjette side av egenerklaringen
Public Class EgenErklaering6
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering5.Show()
        Me.Hide()
    End Sub
    'resetter radioknappene
    Public Sub clear()
        radbtnja45.Checked = False
        radbtnja46.Checked = False
        radbtnja47.Checked = False
        radbtnja48.Checked = False
        radbtnnei45.Checked = True
        radbtnnei46.Checked = True
        radbtnnei47.Checked = True
        radbtnnei48.Checked = True
    End Sub
    'knapp til netse side
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(45, radbtnja45.Checked)
        erklaring.setAns(46, radbtnja46.Checked)
        erklaring.setAns(47, radbtnja47.Checked)
        erklaring.setAns(48, radbtnja48.Checked)
        EgenErklaering7.Show()
        Me.Hide()
    End Sub
    'hånterer lukking av side
    Private Sub EgenErklaering6_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering3.clear()
        EgenErklaering4.clear()
        EgenErklaering5.clear()
        EgenErklaering.clear()
        EgenErklaering7.clear()
        EgenErklaering8.clear()
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

    Private Sub EgenErklaering6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class