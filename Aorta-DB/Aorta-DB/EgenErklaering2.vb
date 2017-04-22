Imports System.ComponentModel
'andre side i egenerklaringen
Public Class EgenErklaering2
    Private Sub EgenErklaering2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'tilbake knapp
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering.Show()
        Me.Hide()
    End Sub
    'hånterer lukking av side
    Private Sub EgenErklaering2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        EgenErklaering.clear()
        Me.clear()
        EgenErklaering3.clear()
        EgenErklaering4.clear()
        EgenErklaering5.clear()
        EgenErklaering6.clear()
        EgenErklaering7.clear()
        EgenErklaering8.clear()
    End Sub
    'resetter radioknappene
    Public Sub clear()
        radbtnja12.Checked = False
        radbtnja13.Checked = False
        radbtnja14.Checked = False
        radbtnja15.Checked = False
        radbtnja16.Checked = False
        radbtnja17.Checked = False
        radbtnja18.Checked = False
        radbtnnei12.Checked = True
        radbtnnei13.Checked = True
        radbtnnei14.Checked = True
        radbtnnei15.Checked = True
        radbtnnei16.Checked = True
        radbtnnei17.Checked = True
        radbtnnei18.Checked = True
    End Sub
    'nesteknapp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(12, radbtnja12.Checked)
        erklaring.setAns(13, radbtnja13.Checked)
        erklaring.setAns(14, radbtnja14.Checked)
        erklaring.setAns(15, radbtnja15.Checked)
        erklaring.setAns(16, radbtnja16.Checked)
        erklaring.setAns(17, radbtnja17.Checked)
        erklaring.setAns(18, radbtnja18.Checked)
        EgenErklaering3.Show()
        Me.Hide()
    End Sub
    'navigasjons knapper
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        MsgBox("Du kan ikke ha mer enn en time")
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