Imports System.ComponentModel

Public Class InfoDonor
    Private Sub InfoDonor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

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

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattBrukerOversikt.Show()
        Me.Close()
    End Sub

    Private Sub btnLagreInfo_Click(sender As Object, e As EventArgs) Handles btnLagreInfo.Click
        If check_helsesjekk(bruker.getPersonnr) = True Then
            update_helsesjekk(bruker.getPersonnr, ComboBox1.Text, numHemoglobin.Value, checkSyflis.Checked, checkHiv.Checked, checkHepatittB.Checked, checkHepatittC.Checked)
        Else
            set_helsesjekk(bruker.getPersonnr, ComboBox1.Text, numHemoglobin.Value, checkSyflis.Checked, checkHiv.Checked, checkHepatittB.Checked, checkHepatittC.Checked)
        End If
        AnsattBrukerOversikt.Show()
        Me.Hide()
    End Sub
End Class