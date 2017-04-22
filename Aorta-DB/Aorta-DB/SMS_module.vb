'her simulerers en sms api, med message boks
Module SMS_module
    'funsjon som sender på minnelse
    Public Sub send_reminder(id As Decimal)
        Dim tlf As Integer = get_user_tlf(id)
        MsgBox("msg sent to " & tlf)
    End Sub
    'lager et nytt passord og sender det på sms
    Public Sub send_new_password(user As Decimal)
        Try
            Dim tlf As Integer = get_user_tlf(user)
            Dim charset As String = "abcdefghijklmnopqrstuvwxyz0123456789"
            Dim r As New Random
            Dim sb As New System.Text.StringBuilder
            For i As Integer = 0 To 7
                Dim index As Integer = r.Next(0, charset.Length - 1)
                sb.Append(charset.Substring(index, 1))
            Next
            Dim new_pass As String = sb.ToString
            Debug.Print(new_pass)
            update_pass(user, new_pass)
            MsgBox("new password: " & new_pass & " sent to: " & tlf)
        Catch
            MsgBox("bruker finnes ikke")
        End Try
    End Sub
End Module
