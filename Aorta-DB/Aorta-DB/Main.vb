Imports System.Security.Cryptography
Imports System.Text
Public Class Main
    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As Decimal = 12345678910
        Dim pass As String = "test"
        Debug.Print(CreateRandomSalt())
    End Sub
End Class
