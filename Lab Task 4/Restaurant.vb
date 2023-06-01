Imports System.Data.SqlClient

Public Class Restaurant
    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btAbout_Click(sender As Object, e As EventArgs) Handles btAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub btReserve_Click(sender As Object, e As EventArgs) Handles btReserve.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim sqlQuery2 As String = "INSERT INTO Restaurant(name, id, location, rating) VALUES (@name, @id, @location, @rating)"
        Dim sqlCommand2 As New SqlCommand(sqlQuery2, connection)

        sqlCommand2.Parameters.AddWithValue("@name", tbName.Text)
        sqlCommand2.Parameters.AddWithValue("@id", tbID.Text)
        sqlCommand2.Parameters.AddWithValue("@location", tbLocation.Text)
        sqlCommand2.Parameters.AddWithValue("@rating", tbRating.Text)

        Dim sqlQuery As String = "INSERT INTO Customer(fname,lname,phone,date,time) VALUES (@fname,@lname,@phone,@date,@time)"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)

        sqlCommand.Parameters.AddWithValue("@fname", firstName.Text)
        sqlCommand.Parameters.AddWithValue("@lname", lastName.Text)
        sqlCommand.Parameters.AddWithValue("@phone", phoneNo.Text)
        sqlCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@date", .SqlDbType = SqlDbType.Date, .Value = resDate.Text})
        sqlCommand.Parameters.AddWithValue("@time", resTime.Text)

        sqlCommand.ExecuteNonQuery()
        MsgBox("The Reservation Has Been Confirmed.")
        connection.Close()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "DELETE FROM Reservation WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", tbSearch.Text)

        Dim rowsAffected As Integer = sqlCommand.ExecuteNonQuery
        If rowsAffected > 0 Then
            MsgBox("The Resevation Has Been Removed")
        Else
            MsgBox("Can't Be Removed.")
        End If
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)

        connection.Open()

        Dim sqlQuery As String = "SELECT * FROM Reservation WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", tbSearch.Text)

        Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()

        While sqlDataReader.Read()
            tbName.Text = sqlDataReader("name").ToString()
            tbID.Text = sqlDataReader("id").ToString()
            tbLocation.Text = sqlDataReader("location").ToString()
            tbRating.Text = sqlDataReader("rating").ToString()
            firstName.Text = sqlDataReader("cusfname").ToString()
            lastName.Text = sqlDataReader("cuslname").ToString()
            phoneNo.Text = sqlDataReader("phone").ToString()
            resDate.Text = sqlDataReader("date").ToString()
            resTime.Text = sqlDataReader("time").ToString()
        End While
    End Sub

    Private Sub btCus_Click(sender As Object, e As EventArgs) Handles btCus.Click
        Customer.ShowDialog()
    End Sub
End Class