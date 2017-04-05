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
    Public Function login2(user As Decimal)
        connect_db()
        Dim username As String = user.ToString
        Dim sqlSporring = "select * from users where username=@username "
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)

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

    Public Sub create_erklaring(personnr As Decimal, date_id As Integer, inn As Array, land As String)
        Try
            Dim sqlSporring = "INSERT INTO erklaring (pers, date_id"
            For i As Integer = 1 To inn.Length
                sqlSporring = sqlSporring & ", check" & i.ToString
            Next
            sqlSporring = sqlSporring & ", land) VALUES (@pers, @date_id"
            For i As Integer = 1 To inn.Length
                sqlSporring = sqlSporring & ", " & inn(i - 1).ToString
            Next
            sqlSporring = sqlSporring & ", @land)"
            'Debug.Print(sqlSporring)
            connect_db()
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@pers", personnr)
            sql.Parameters.AddWithValue("@date_id", date_id)
            sql.Parameters.AddWithValue("@land", land)
            sql.ExecuteNonQuery()
            close_db()
        Catch ex As Exception
            MsgBox("Du har alledrede gjort egenerklæringen for denne timen")
        End Try
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

    Public Sub create_blodpack(user As Decimal, dato As Integer, type As String, hemoglobin As Decimal, hiv As Boolean, hepatittB As Boolean, hepatittC As Boolean, kommentar As String)
        connect_db()
        Dim sqlSporring = "INSERT INTO blodpakke (pernr, dato, type, hemoglobin, hiv, hepatittB, hepatittC, kommentar) VALUES (@pernr, @dato, @type, @hemoglobin, @hiv, @hepatittB, @hepatittC, @kommentar)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@pernr", user)
        sql.Parameters.AddWithValue("@dato", dato)
        sql.Parameters.AddWithValue("@type", type)
        sql.Parameters.AddWithValue("@hemoglobin", hemoglobin)
        sql.Parameters.AddWithValue("@hiv", hiv)
        sql.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql.Parameters.AddWithValue("@kommentar", kommentar)
        sql.ExecuteNonQuery()
        close_db()
    End Sub

    Public Function get_blodpack(persnr As Decimal, dato As Integer)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT * FROM blodpakke WHERE pernr = @pernr AND dato = @dato"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@pernr", persnr)
        sql.Parameters.AddWithValue("@dato", dato)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 6
            ret.Add(reader.Item(i).ToString())
        Next
        reader.Close()
        close_db()
        Return ret
    End Function

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
            'Debug.Print(user.ToString + time + dates)
        Catch
            'Debug.Print("oh no")
            'Debug.Print(user.ToString + time + dates)
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

    Public Function get_appointment_id(time As String, dates As String)
        Try
            connect_db()
            Dim sqlSporring = "SELECT id FROM appointments WHERE time = @time AND date = @date"
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
    Public Function get_appointment_date_only(user As Decimal)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT date FROM appointments WHERE username = @persnr ORDER BY date DESC"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", user)
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim dato As String
        For Each rad In interntabell.Rows
            dato = rad("date")
            ret.Add(dato)
        Next
        Return ret
    End Function

    Public Function get_appointment_info(user As Decimal, dato As String)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT type, hemoglobin, hiv, hepatittB, hepatittC, kommentar from blodpakke b, appointments a where b.dato = a.id AND b.pernr = @personnr AND a.date = @date"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@personnr", user)
        sql.Parameters.AddWithValue("@date", dato)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 5
            ret.Add(reader.Item(i))
        Next
        close_db()
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

    Public Function return_erklaring(persnr As Decimal, dato As Integer)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT * FROM erklaring WHERE pers = @pers AND date_id = @date_id"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@pers", persnr)
        sql.Parameters.AddWithValue("@date_id", dato)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 3 To 62
            ret.Add(reader.Item(i).ToString())
        Next
        reader.Close()
        close_db()
        Return ret
    End Function

    Public Sub update_erklaring_godkjenning(persnr As Decimal, dato As Integer, godkjen As Boolean)
        connect_db()
        Dim sqlSporring = "UPDATE erklaring SET godkjent = @godkjen WHERE pers = @persnr AND date_id = @date_id;"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", persnr)
        sql.Parameters.AddWithValue("@date_id", dato)
        sql.Parameters.AddWithValue("@godkjen", godkjen)
        sql.ExecuteNonQuery()
        close_db()
    End Sub

    Public Sub update_bank_db(type As String, rode As Integer, plasma As Integer, plater As Integer)
        connect_db()
        Dim sqlSporring = "UPDATE blodprod SET rode_blodlegemer = @rode, plasma = @plasma, blodplater  = @plater WHERE  type  = @type;"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@rode", rode)
        sql.Parameters.AddWithValue("@plasma", plasma)
        sql.Parameters.AddWithValue("@plater", plater)
        sql.Parameters.AddWithValue("@type", type)
        sql.ExecuteNonQuery()
        close_db()
    End Sub

    Public Function get_bank_db(type As String)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT rode_blodlegemer, plasma, blodplater FROM blodprod WHERE type = @type"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@type", type)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 2
            ret.Add(reader.Item(i))
        Next
        close_db()
        Return ret
    End Function
    Public Function get_appointments_ansatt(dates As String)
        Dim timer As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT time, first_name, last_name FROM appointments a, users u WHERE a.username = u.username AND date = @date ORDER BY time"
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@date", dates)
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim time, first_name, last_name As String
        For Each rad In interntabell.Rows
            Dim timer_rad As New ArrayList
            time = rad("time")
            first_name = rad("first_name")
            last_name = rad("last_name")
            timer_rad.Add(time)
            timer_rad.Add(first_name)
            timer_rad.Add(last_name)
            timer.Add(timer_rad)
        Next
        Return timer
    End Function
    Public Sub set_helsesjekk(user As Decimal, type As String, hemoglobin As Decimal, syfilis As Boolean, hiv As Boolean, hepatittB As Boolean, hepatittC As Boolean)
        connect_db()
        Dim sqlSporring = "INSERT INTO helsesjekk (user, type, hemoglobin, syfilis, hiv, hepatittB, hepatittC) VALUES (@user, @type, @hemoglobin, @syfilis, @hiv, @hepatittB, @hepatittC)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        sql.Parameters.AddWithValue("@type", type)
        sql.Parameters.AddWithValue("@hemoglobin", hemoglobin)
        sql.Parameters.AddWithValue("@syfilis", syfilis)
        sql.Parameters.AddWithValue("@hiv", hiv)
        sql.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    Public Sub update_helsesjekk(user As Decimal, type As String, hemoglobin As Decimal, syfilis As Boolean, hiv As Boolean, hepatittB As Boolean, hepatittC As Boolean)
        connect_db()
        Dim sqlSporring = "UPDATE helsesjekk SET type= @type, hemoglobin = @hemoglobin, syfilis = @syfilis, hiv = @hiv, hepatittB = @hepatittB, hepatittC = @hepatittC WHERE user = @user"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        sql.Parameters.AddWithValue("@type", type)
        sql.Parameters.AddWithValue("@hemoglobin", hemoglobin)
        sql.Parameters.AddWithValue("@syfilis", syfilis)
        sql.Parameters.AddWithValue("@hiv", hiv)
        sql.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    Public Function check_helsesjekk(user As Decimal)
        connect_db()
        Dim username As String = user.ToString
        Dim sqlSporring = "select * from helsesjekk where user = @username "
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            close_db()
            Return True
        Else
            close_db()
            Return False
        End If
    End Function
    Public Function find_helsesjekk(user As Decimal)
        Try
            connect_db()
            Dim ret As New ArrayList
            Dim username As String = user.ToString
            Dim sqlSporring = "select type, hemoglobin, syfilis, hiv, hepatittB, hepatittC  from helsesjekk where user = @username"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            sql.Parameters.AddWithValue("@username", username)
            Dim reader As MySqlDataReader = sql.ExecuteReader
            reader.Read()
            For i As Integer = 0 To 5
                ret.Add(reader.Item(i))
            Next
            close_db()
            Return ret
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function check_egenerklaering(user As Decimal)
        connect_db()
        Dim username As String = user.ToString
        Dim sqlSporring = "select * from erklaring where pers = @username "
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            close_db()
            Return True
        Else
            close_db()
            Return False
        End If
    End Function
    Public Function find_blodtype(user As String)
        Dim ret As String
        connect_db()
        Dim sqlSporring = "SELECT type FROM helsesjekk WHERE user = @user"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()

        ret = reader.Item(0)
        close_db()
        Return ret
    End Function
    Public Function get_appointments_user(dates As String)
        Dim timer As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT time FROM appointments WHERE date = @date ORDER BY time"
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@date", dates)
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim time As String
        For Each rad In interntabell.Rows
            Dim timer_rad As New ArrayList
            time = rad("time")
            timer_rad.Add(time)
            timer.Add(timer_rad)
        Next
        Return timer
    End Function
End Module
