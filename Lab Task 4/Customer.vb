Imports System.Data.SqlClient

Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=ザシャン; Initial Catalog=LT4;Trusted_Connection=yes;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim adapter As New SqlDataAdapter
        Dim sqlcommand As New SqlCommand("SELECT * FROM Reservation", connection)
        adapter.SelectCommand = sqlcommand
        Dim custable As New DataTable
        custable.Clear()
        adapter.Fill(custable)
        dgvCus.DataSource = custable
    End Sub
End Class