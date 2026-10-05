Imports MySql.Data.MySqlClient
Module ModuleDatabase
    Public sqlcon As New MySqlConnection
    Private db_server As String = "localhost"
    Private db_username As String = "root"
    Private db_password As String = ""
    Private db_port As String = "3306"
    Private db_name As String = "library"


    Public Sub connectDB()
        sqlcon = New MySqlConnection("server=" & db_server & "; port=" & db_port & "; user id=" & db_username & "; password=" & db_password & "; database=" & db_name & ";")
        sqlcon.Open()
    End Sub

    Public Sub disconnectDB()
        sqlcon.Close()
    End Sub

    Public Sub viewData(dgv As DataGridView)

    End Sub


End Module
