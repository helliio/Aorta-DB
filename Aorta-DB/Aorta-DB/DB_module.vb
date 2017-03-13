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
        Dim password As String = Hash512(pass)
        Dim sqlSporring = "select * from users where username=@username " &
                          "and password=@password"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)
        sql.Parameters.AddWithValue("@password", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            close_db()
            Return user
        Else
            close_db()
            Return 0
        End If
    End Function
    Public Sub create_user(user As Decimal, pass As String, first_name As String, last_name As String, bruker_type As Integer, tlf As Decimal, mail As String, adress As String, post_code As Integer, city As String)
        connect_db()
        Dim password = Hash512(pass)
        Dim sqlSporring = "insert into users (username, password, first_name, last_name, type, tlf, mail, adress, post_code, city) values (@username, @password, @first_name, @last_name, @type, @tlf, @mail, @adress, @post_code, @city)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", user)
        sql.Parameters.AddWithValue("@password", password)
        sql.Parameters.AddWithValue("@first_name", first_name)
        sql.Parameters.AddWithValue("@last_name", last_name)
        sql.Parameters.AddWithValue("@type", bruker_type)
        sql.Parameters.AddWithValue("@tlf", tlf)
        sql.Parameters.AddWithValue("@mail", mail)
        sql.Parameters.AddWithValue("@adress", adress)
        sql.Parameters.AddWithValue("@post_code", post_code)
        sql.Parameters.AddWithValue("@city", city)

        sql.ExecuteNonQuery()
    End Sub
End Module
