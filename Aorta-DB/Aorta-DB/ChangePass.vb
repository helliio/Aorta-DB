Public Class ChangePass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not txtPassord.Text.Length >= 8 Then
            MsgBox("Passord må være lengre enn 8 tegn")
            Exit Sub
        End If
        If txtPassord.Text <> txtBekreftpass.Text Then
            'some error
            Exit Sub
        End If
        update_pass(bruker.getPersonnr, txtPassord.Text)
        Me.Close()
    End Sub
End Class