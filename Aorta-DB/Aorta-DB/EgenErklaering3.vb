﻿Imports System.ComponentModel
'tredje side i egenerklaringen
Public Class EgenErklaering3
    'tilbake knapp
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering2.Show()
        Me.Hide()
    End Sub
    'hånterer lukking av siden
    Private Sub EgenErklaering3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering.clear()
        EgenErklaering4.clear()
        EgenErklaering5.clear()
        EgenErklaering6.clear()
        EgenErklaering7.clear()
        EgenErklaering8.clear()
    End Sub
    'resetter radioknappene
    Public Sub clear()
        radbtnja19.Checked = False
        radbtnja20.Checked = False
        radbtnja21.Checked = False
        radbtnja22.Checked = False
        radbtnja23.Checked = False
        radbtnja24.Checked = False
        radbtnja25.Checked = False
        radbtnja26.Checked = False
        radbtnja27.Checked = False
        radbtnja28.Checked = False
        radbtnnei19.Checked = True
        radbtnnei20.Checked = True
        radbtnnei21.Checked = True
        radbtnnei22.Checked = True
        radbtnnei23.Checked = True
        radbtnnei24.Checked = True
        radbtnnei25.Checked = True
        radbtnnei26.Checked = True
        radbtnnei27.Checked = True
        radbtnnei28.Checked = True
    End Sub
    'knapp til neste side
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(19, radbtnja19.Checked)
        erklaring.setAns(20, radbtnja20.Checked)
        erklaring.setAns(21, radbtnja21.Checked)
        erklaring.setAns(22, radbtnja22.Checked)
        erklaring.setAns(23, radbtnja23.Checked)
        erklaring.setAns(24, radbtnja24.Checked)
        erklaring.setAns(25, radbtnja25.Checked)
        erklaring.setAns(26, radbtnja26.Checked)
        erklaring.setAns(27, radbtnja27.Checked)
        erklaring.setAns(28, radbtnja28.Checked)
        EgenErklaering4.Show()
        Me.Hide()
    End Sub
    'navigarings knapper
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        MsgBox("Du kan ikke ha mer enn en time")
    End Sub

    Private Sub btnKontakt_Click(sender As Object, e As EventArgs) Handles btnTimeinfo.Click
        InfoBruker.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        BrukerHovedside.Show()
        Me.Close()
    End Sub

    Private Sub EgenErklaering3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class