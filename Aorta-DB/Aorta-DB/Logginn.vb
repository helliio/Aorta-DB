Public Class Logginn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click
        'Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
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
            TxtPersonnummer.Clear()
            txtPassord.Clear()
        Else
            MsgBox("Ugyldig brukernavn eller passord")
        End If
    End Sub

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) 
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGlemtpassord.Click
        Ansatt.Show()
        Me.Hide()
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnNyBruker_Click_1(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        Me.Close()
        NyBruker.Show()
    End Sub

    Private Sub btnEgenerklæring_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Hide()
    End Sub
End Class