﻿Imports System.ComponentModel
'femte side i egenerklaring
Public Class EgenErklaering5
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        EgenErklaering4.Show()
    End Sub
    'hånterer lukking av siden
    Private Sub EgenErklaering5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering3.clear()
        EgenErklaering4.clear()
        EgenErklaering.clear()
        EgenErklaering6.clear()
        EgenErklaering7.clear()
        EgenErklaering8.clear()
    End Sub
    'resetter radiokanppene
    Public Sub clear()
        radbtnja30.Checked = False
        radbtnja31.Checked = False
        radbtnja32.Checked = False
        radbtnja33.Checked = False
        radbtnja34.Checked = False
        radbtnja35.Checked = False
        radbtnja36.Checked = False
        radbtnja37.Checked = False
        radbtnja38.Checked = False
        radbtnja39.Checked = False
        radbtnja40.Checked = False
        radbtnja41.Checked = False
        radbtnja42.Checked = False
        radbtnja43.Checked = False
        radbtnja44.Checked = False
        radbtnja30.Checked = True
        radbtnja31.Checked = True
        radbtnja32.Checked = True
        radbtnja33.Checked = True
        radbtnja34.Checked = True
        radbtnja35.Checked = True
        radbtnja36.Checked = True
        radbtnja37.Checked = True
        radbtnja38.Checked = True
        radbtnja39.Checked = True
        radbtnja40.Checked = True
        radbtnja41.Checked = True
        radbtnja42.Checked = True
        radbtnja43.Checked = True
        radbtnja44.Checked = True
    End Sub
    'knapp til neste side
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(30, radbtnja30.Checked)
        erklaring.setAns(31, radbtnja31.Checked)
        erklaring.setAns(32, radbtnja32.Checked)
        erklaring.setAns(33, radbtnja33.Checked)
        erklaring.setAns(34, radbtnja34.Checked)
        erklaring.setAns(35, radbtnja35.Checked)
        erklaring.setAns(36, radbtnja36.Checked)
        erklaring.setAns(37, radbtnja37.Checked)
        erklaring.setAns(38, radbtnja38.Checked)
        erklaring.setAns(39, radbtnja39.Checked)
        erklaring.setAns(41, radbtnja41.Checked)
        erklaring.setAns(42, radbtnja42.Checked)
        erklaring.setAns(43, radbtnja43.Checked)
        erklaring.setAns(44, radbtnja44.Checked)
        EgenErklaering6.Show()
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

    Private Sub btnTimeinfo_Click(sender As Object, e As EventArgs) Handles btnTimeinfo.Click
        InfoBruker.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        BrukerHovedside.Show()
        Me.Close()
    End Sub
End Class