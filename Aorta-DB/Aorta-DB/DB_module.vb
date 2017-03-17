﻿Imports MySql.Data.MySqlClient
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
        Dim sqlSporring = "INSERT INTO users (username, password, first_name, last_name, type, tlf, mail, adress, post_code, city) VALUES (@username, @password, @first_name, @last_name, @type, @tlf, @mail, @adress, @post_code, @city)"
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
        close_db()
    End Sub

    Public Sub create_appointment(user As Decimal, time As String, dates As String)
        connect_db()
        Dim sqlSporring = "INSERT INTO appointments (username, time, date) VALUES (@username, @time, @date)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@username", user)
        sql.Parameters.AddWithValue("@time", time)
        sql.Parameters.AddWithValue("@date", dates)
        sql.ExecuteNonQuery()
        close_db()
    End Sub

    Public Sub cancel_appointment(user As Decimal, time As String, dates As String)
        Try
            connect_db()
            Dim sqlSporring = "DELETE FROM appointments WHERE username = @username AND time = @time AND date = @date"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@username", user)
            sql.Parameters.AddWithValue("@time", time)
            sql.Parameters.AddWithValue("@date", dates)
            sql.ExecuteNonQuery()
            close_db()
        Catch
        End Try
    End Sub

    Public Function get_appointment_user(time As String, dates As String)
        Try
            connect_db()
            Dim sqlSporring = "SELECT username FROM appointments WHERE time = @time AND date = @date"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@time", time)
            sql.Parameters.AddWithValue("@date", dates)
            Dim reader As MySqlDataReader = sql.ExecuteReader
            reader.Read()
            Return reader.Item(0)
            close_db()
        Catch
            Return 0
        End Try
    End Function

    Public Function get_appointment_date(user As Decimal)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT time, date FROM appointments WHERE username = @persnr ORDER BY date DESC"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", user)
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim tid, dato As String
        For Each rad In interntabell.Rows
            tid = rad("time")
            dato = rad("date")
            ret.Add(tid & " " & dato)
        Next
        Return ret
    End Function


    Public Function return_user(persnr As Decimal)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT * FROM users WHERE username = @persnr"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", persnr)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 9
            ret.Add(reader.Item(i).ToString())
        Next
        close_db()
        Return ret
    End Function
End Module
