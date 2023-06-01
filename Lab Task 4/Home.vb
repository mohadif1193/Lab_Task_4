Imports System.Data.SqlClient

Public Class Home

    Private Sub btAbout_Click(sender As Object, e As EventArgs) Handles btAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub btRes_Click(sender As Object, e As EventArgs) Handles btRes.Click
        Restaurant.Show()
        Me.Hide()
    End Sub

    Private Sub btCus_Click(sender As Object, e As EventArgs) Handles btCus.Click
        Customer.ShowDialog()
    End Sub

    Private Sub btATC_Click(sender As Object, e As EventArgs) Handles btATC.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)

        Dim sqlQuery As String = "INSERT INTO Item(name, id, price, quantity,) VALUES (@name, @id, @price, @quantity)"
        Dim sqlcommand As New SqlCommand(sqlQuery, connection)

        sqlcommand.Parameters.AddWithValue("@name", tbName)
        sqlcommand.Parameters.AddWithValue("@id", tbID)
        sqlcommand.Parameters.AddWithValue("@price", tbPrice)
        sqlcommand.Parameters.AddWithValue("@quantity", tbQTT)

        sqlcommand.ExecuteNonQuery()

    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)
        Dim total As Double

        connection.Open()

        Dim sqlQuery As String = "SELECT * FROM Item WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", tbSearch.Text)

        Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()

        While sqlDataReader.Read()
            tbName.Text = sqlDataReader("name").ToString()
            tbID.Text = sqlDataReader("id").ToString()
            tbPrice.Text = sqlDataReader("price").ToString()
            tbQTT.Text = sqlDataReader("quantity").ToString()
        End While

        total = tbPrice.Text + tbQTT.Text

        tbTotal.Text = total

    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "DELETE FROM Item WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", tbSearch.Text)

        Dim rowsAffected As Integer = sqlCommand.ExecuteNonQuery
        If rowsAffected > 0 Then
            MsgBox("The Item Has Been Removed ")
        Else
            MsgBox("Can't Be Removed.")
        End If
    End Sub
End Class