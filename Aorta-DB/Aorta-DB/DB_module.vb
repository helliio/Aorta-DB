Imports MySql.Data.MySqlClient
Module DB_module
    Private tilkobling As MySqlConnection
    Private Sub connect_db()
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" & "Database=liangzh;" & "Uid=liangzh;" & "Pwd=vdAZFdty;")
        tilkobling.Open()
    End Sub
    Private Sub close_db()
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub
    Public Function login(user As Decimal, pass As String)
        connect_db()
        Dim username As String = user.ToString
        Dim password As String = pass
        Dim sqlSporring = "select * from users where username=@username " &
                          "and password=@password"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)
        sql.Parameters.AddWithValue("@password", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            close_db()
            Return True
        Else
            close_db()
            Return False
        End If
    End Function
End Module
