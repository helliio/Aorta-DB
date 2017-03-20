Imports System.ComponentModel

Public Class Ansatt
    Private Sub Ansatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub Ansatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAnsatt.Text = "Velkommen " & bruker.getFornavn() & " " & bruker.getEtternavn()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Me.Close()
    End Sub
End Class