Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class addBook
    Private Sub addBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connectDB()

            Dim query As String = "SELECT category_name FROM `categories`"

            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, sqlcon)
            Dim ds As New DataSet

            da.Fill(ds, "categories")

            For Each row As DataRow In ds.Tables("categories").Rows
                txtbCategory.Items.Add(row("category_name").ToString())
            Next

            ds.Dispose()
            da.Dispose()

            disconnectDB()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = txtbID.Text.Trim()
        Dim title As String = txtbTitle.Text.Trim()
        Dim category As String = If(txtbCategory.SelectedItem IsNot Nothing, txtbCategory.SelectedItem.ToString(), "")
        Dim isbn As String = txtISBN.Text.Trim()
        Dim author As String = txtAuthor.Text.Trim()

        If String.IsNullOrEmpty(id) OrElse String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(isbn) OrElse String.IsNullOrEmpty(author) Then
            MsgBox("Please fill in all fields.", vbOKOnly + vbExclamation, "Warning")
            Return
        Else

            Try
                connectDB()

                'getting category id by name
                Dim queryCategory As String = "SELECT category_id FROM categories WHERE category_name = @category_name"

                Dim categoryId As Integer

                Using cmdCategory As New MySqlCommand(queryCategory, sqlcon)
                    cmdCategory.Parameters.AddWithValue("@category_name", category)
                    Dim result = cmdCategory.ExecuteScalar()

                    If Result IsNot Nothing AndAlso Not IsDBNull(Result) Then
                        categoryId = Convert.ToInt32(Result)
                    Else
                        MsgBox("Selected category does not exist in the database.", vbOKOnly + vbCritical, "Error")
                        Return
                    End If

                End Using




                Dim query1 As String = "INSERT INTO books (b_id, b_isbn, b_title, b_category, author_name) VALUES (@book_id, @book_isbn, @book_title, @book_category, @book_author)"
                Dim query2 As String = "INSERT INTO bookcopies (b_id,bc_status) VALUES (@book_id, 1)"

                Using cmd1 As New MySqlCommand(query1, sqlcon)

                    cmd1.Parameters.AddWithValue("@book_id", id)
                    cmd1.Parameters.AddWithValue("@book_title", title)
                    cmd1.Parameters.AddWithValue("@book_category", categoryId)
                    cmd1.Parameters.AddWithValue("@book_isbn", isbn)
                    cmd1.Parameters.AddWithValue("@book_author", author)
                    cmd1.ExecuteNonQuery()

                End Using

                Using cmd2 As New MySqlCommand(query2, sqlcon)
                    cmd2.Parameters.AddWithValue("@book_id", id)
                    cmd2.ExecuteNonQuery()
                End Using

                MsgBox("Book and copy saved successfully!", vbInformation + vbOK, "Success")

                disconnectDB()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try


        End If

    End Sub
End Class