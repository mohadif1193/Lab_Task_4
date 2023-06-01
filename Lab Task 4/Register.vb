Imports System.Data.SqlClient

Public Class Register
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Login.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btregister_Click(sender As Object, e As EventArgs) Handles btregister.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)

        Dim sqlQuery As String = "INSERT INTO Login(name, phone, password) VALUES (@name, @phone, passworrd)"
        Dim sqlcommand As New SqlCommand(sqlQuery, connection)

        sqlcommand.Parameters.AddWithValue("@name", tbName)
        sqlcommand.Parameters.AddWithValue("@phone", tbPhone)
        sqlcommand.Parameters.AddWithValue("@password", tbPwd)

        sqlcommand.ExecuteNonQuery()
        MsgBox("Registered Successfully")

        Login.Show()
        Me.Hide()
    End Sub
End Class