Public Class NyBruker
    Private Sub NyBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNybruker_Click(sender As Object, e As EventArgs) Handles lblNybruker.Click

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub btnNybruker_Click(sender As Object, e As EventArgs) Handles btnNybruker.Click
        Dim persnr As Decimal
        Dim tlf As Decimal
        Dim postnr As Integer
        If IsNumeric(txtPersonnummer.Text) And IsNumeric(txtTelefon.Text) And IsNumeric(txtPostnummer.Text) Then
            persnr = Convert.ToDecimal(txtPersonnummer.Text)
            tlf = Convert.ToDecimal(txtTelefon.Text)
            postnr = CInt(txtPostnummer.Text)
        Else
            'some error
            Exit Sub
        End If

        If txtPassord.Text <> txtBekreftpass.Text Then
            'some error
            Exit Sub
        End If
        Try
            create_user(persnr, txtPassord.Text, txtFornavn.Text, txtEtternavn.Text, 0, tlf, txtMail.Text, txtAdresse.Text, postnr, txtPoststed.Text)
        Catch ex As Exception
            MsgBox("DB error")
            Exit Sub
        End Try
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub txtPoststed_TextChanged(sender As Object, e As EventArgs) Handles txtPoststed.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class