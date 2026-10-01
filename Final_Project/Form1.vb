Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If Not String.IsNullOrEmpty(email) AndAlso Not String.IsNullOrEmpty(password) Then
            Try
                connectDB()
                Dim ds As New DataSet
                Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM users WHERE usr_email = @usr_email and usr_password = @usr_password and isActive = 1", sqlcon)

                da.SelectCommand.Parameters.AddWithValue("@usr_email", email)
                da.SelectCommand.Parameters.AddWithValue("@usr_password", password)

                da.Fill(ds, "users")

                If ds.Tables("users").Rows.Count > 0 Then
                    Dashboard.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid Credentials", vbOKOnly + vbCritical, "OOPS!")

                End If

                da.Dispose()
                ds.Dispose()

                disconnectDB()
            Catch ex As Exception

            End Try
        Else

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Text = "test@gmail.com"
        txtPassword.Text = "test123"
    End Sub
End Class
