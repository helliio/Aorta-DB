Imports System.ComponentModel
'side for helseskjekk
Public Class InfoDonor
    Private Sub InfoDonor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
    'legger til verdier inn i comboboksen
    Private Sub InfoDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A-")
        ComboBox1.Items.Add("A+")
        ComboBox1.Items.Add("B-")
        ComboBox1.Items.Add("B+")
        ComboBox1.Items.Add("AB-")
        ComboBox1.Items.Add("AB+")
        ComboBox1.Items.Add("O-")
        ComboBox1.Items.Add("O+")
        ComboBox1.Text = "A-"

        Label2.Text = "Helsesjekk for donør: " & bruker.getFornavn() & " " & bruker.getEtternavn()
    End Sub
    'knapp tilbake
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattBrukerOversikt.Show()
        Me.Close()
    End Sub
    'sender info til databasen
    Private Sub btnLagreInfo_Click(sender As Object, e As EventArgs) Handles btnLagreInfo.Click
        If check_helsesjekk(bruker.getPersonnr) = True Then
            update_helsesjekk(bruker.getPersonnr, ComboBox1.Text, numHemoglobin.Value, checkSyflis.Checked, checkHiv.Checked, checkHepatittB.Checked, checkHepatittC.Checked)
        Else
            set_helsesjekk(bruker.getPersonnr, ComboBox1.Text, numHemoglobin.Value, checkSyflis.Checked, checkHiv.Checked, checkHepatittB.Checked, checkHepatittC.Checked)
        End If
        AnsattBrukerOversikt.Show()
        Me.Hide()
    End Sub
    'navigasjons knappper
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
        Ansatt.Close()
    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        blodbank.Show()
        Me.Close()
    End Sub

    Private Sub btnStatestikk_Click(sender As Object, e As EventArgs) Handles btnStatestikk.Click
        Statestikk.Show()
        Me.Close()
    End Sub

    Private Sub btnSjekkBlod_Click(sender As Object, e As EventArgs) Handles btnSjekkBlod.Click
        InnkallingBaserPaaBehov.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        Ansatt.Show()
        Me.Close()
    End Sub

    Private Sub btnLoggUt_Click_1(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Ansatt.Close()
        Me.Close()
    End Sub
End Class