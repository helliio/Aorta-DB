Imports System.ComponentModel

Public Class InnkallingBaserPaaBehov
    Private Sub InnkallingBaserPaaBehov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("O+")
        ComboBox1.Items.Add("O-")
        ComboBox1.Items.Add("A+")
        ComboBox1.Items.Add("A-")
        ComboBox1.Items.Add("B+")
        ComboBox1.Items.Add("B-")
        ComboBox1.Items.Add("AB+")
        ComboBox1.Items.Add("AB-")
        ComboBox1.Text = "Velg blodtype"

        Dim typeApluss As ArrayList = get_Antallblod("A+")
        If typeApluss(1) < 1000 Or typeApluss(2) < 1000 Or typeApluss(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen A+")
        End If
        Dim typeAminus As ArrayList = get_Antallblod("A-")
        If typeAminus(1) < 1000 Or typeAminus(2) < 1000 Or typeAminus(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen A-")
        End If
        Dim typeBpluss As ArrayList = get_Antallblod("B+")
        If typeBpluss(1) < 1000 Or typeBpluss(2) < 1000 Or typeBpluss(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen B+")
        End If
        Dim typeBminus As ArrayList = get_Antallblod("B-")
        If typeBminus(1) < 1000 Or typeBminus(2) < 1000 Or typeBminus(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen B-")
        End If
        Dim typeABpluss As ArrayList = get_Antallblod("AB+")
        If typeABpluss(1) < 1000 Or typeABpluss(2) < 1000 Or typeABpluss(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen AB+")
        End If
        Dim typeABminus As ArrayList = get_Antallblod("AB-")
        If typeABminus(1) < 1000 Or typeABminus(2) < 1000 Or typeABminus(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen AB-")
        End If
        Dim type0pluss As ArrayList = get_Antallblod("O+")
        If type0pluss(1) < 1000 Or type0pluss(2) < 1000 Or type0pluss(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen O+")
        End If
        Dim type0minus As ArrayList = get_Antallblod("O-")
        If type0minus(1) < 1000 Or type0minus(2) < 1000 Or type0minus(3) < 1000 Then
            ListBox2.Items.Add("Det er behov for mer blod av typen O-")
        End If
    End Sub


    Private Sub btnBlodgivere_Click(sender As Object, e As EventArgs) Handles btnBlodgivere.Click
        If ComboBox1.Text <> "Velg blodtype" Then
            listboxBlodgivere.Items.Clear()
            Dim blodgivere As ArrayList = get_blodgiver(ComboBox1.Text)
            For Each item In blodgivere
                Dim out As String
                out = item(0) & " " & item(1) & " " & item(2)
                listboxBlodgivere.Items.Add(out)
            Next
        Else
            MsgBox("Du må velge en blodtype")
        End If
    End Sub

    Private Sub btnMengdeBlod_Click(sender As Object, e As EventArgs) Handles btnMengdeBlod.Click
        If ComboBox1.Text <> "Velg blodtype" Then
            listboxBlodMengde.Items.Clear()
            Dim blodMengde As ArrayList = get_Antallblod(ComboBox1.Text)
            listboxBlodMengde.Items.Add("Valgt blodtype er: " & blodMengde(0))
            listboxBlodMengde.Items.Add("Antall Milliliter røde blodlegemer er: " & blodMengde(1))
            listboxBlodMengde.Items.Add("Antall milliliter plasma er: " & blodMengde(2))
            listboxBlodMengde.Items.Add("Antall milliliter blodplater er: " & blodMengde(3))
        Else
            MsgBox("Du må velge en blodtype")
        End If
    End Sub
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Me.Close()
        Main.Show()
    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        blodbank.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        Ansatt.Show()
        Me.Close()
    End Sub

    Private Sub btnStatestikk_Click(sender As Object, e As EventArgs) Handles btnStatestikk.Click
        Statestikk.Show()
        Me.Close()
    End Sub

    Private Sub InnkallingBaserPaaBehov_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
End Class