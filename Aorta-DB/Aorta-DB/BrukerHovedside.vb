Public Class BrukerHovedside
    Private Sub BrukerHovedside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        InfoBruker.Show()
        Me.Hide()
    End Sub
End Class