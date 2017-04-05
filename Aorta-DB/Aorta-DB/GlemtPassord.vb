Imports System.ComponentModel

Public Class GlemtPassord

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim persnr As Decimal
        If IsNumeric(txtPersonnummer.Text) And txtPersonnummer.Text.Length = 11 Then
            persnr = Convert.ToDecimal(txtPersonnummer.Text)
        Else
            'some error
            MsgBox("invalid personnummer")
            Exit Sub
        End If
        send_new_password(persnr)
    End Sub

    Private Sub GlemtPassord_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.Show()
        Me.Hide()
    End Sub
End Class