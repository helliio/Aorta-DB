Public Class Logginn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
        Dim id As Decimal = login(TxtPersonnummer.Text, txtPassord.Text)
        If id <> 0 Then
            Global_val.bruker = New User(id)
            If bruker.getUserType = 0 Then
                BrukerHovedside.Show()
                Me.Hide()
            ElseIf bruker.getUserType = 1 Then
                Ansatt.Show()
                Me.Hide()
            ElseIf bruker.getUserType = 2 Then
                IktHovedside.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Ugyldig brukernavn eller passord")
        End If
    End Sub

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ansatt.Show()
        Me.Hide()
    End Sub
End Class