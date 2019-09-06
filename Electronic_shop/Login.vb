Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Login

    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Customer_registration.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        user = TextBox1.Text
        Dim pass As String
        pass = TextBox2.Text
        Dim role As String
        role = ComboBox1.SelectedItem.ToString()
        If role = "ADMIN" Then
            If user = "admin" And pass = "admin" And role = "ADMIN" Then
                MsgBox("Login successful")
                Stock_details.Show()



            Else : MsgBox("Login Unsuccessful. Please try again.")
            End If
        Else
            myconnection.Open()

            Dim sqlOrder As New SqlCommand()
            sqlOrder.Connection = myconnection
            sqlOrder.CommandText = "SELECT * FROM c_registration WHERE Username ='" & user & "' AND Password ='" & pass & "' "
            Dim sqlReading As SqlDataReader = sqlOrder.ExecuteReader()
            If (sqlReading.Read() = True) Then
                User_order.Show()

            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
