Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Login
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        End
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes"
        Dim connection As New SqlConnection(connectionString)

        Dim sqlQuery As String = "SELECT * FROM Login WHERE name=@name AND phone=@phone AND password=@password"

        Dim sqlcommand As New SqlCommand(sqlQuery, connection)

        sqlcommand.Parameters.AddWithValue("@name", tbName.Text)
        sqlcommand.Parameters.AddWithValue("@phone", tbPhone.Text)
        sqlcommand.Parameters.AddWithValue("@password", tbPwd.Text)

        connection.Open()

        Dim reader As SqlDataReader = sqlcommand.ExecuteReader

        If reader.HasRows Then
            While reader.Read()
                Dim username As String = reader("name").ToString()
                Dim phone As String = reader("phone").ToString()
                Dim password As String = reader("password").ToString()
            End While
            Me.Hide()
            MsgBox("Welcome User!")
            Home.Show()
        Else
            MsgBox("Invalid User. Please register first")
        End If
        connection.Close()
    End Sub

    Private Sub btRegister_Click(sender As Object, e As EventArgs) Handles btRegister.Click
        Register.Show()
        Me.Hide
    End Sub
End Class
