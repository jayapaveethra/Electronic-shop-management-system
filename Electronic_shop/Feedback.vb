Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Feedback
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim user As String
        user = TextBox2.Text

        Dim role As String
        role = ComboBox1.SelectedItem.ToString()
        myconnection.Open()
        mycommand = New SqlCommand("insert into feed([uname],[feedback]) values ('" & user & "','" & role & "')", myconnection)
        mycommand.ExecuteNonQuery()
        'MessageBox.Show("New Row Inserted" & ra)
        myconnection.Close()
        MessageBox.Show("Details added  Successfully")


        TextBox2.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class