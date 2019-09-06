Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Check_availability
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i_id As String
        i_id = TextBox1.Text

        If i_id = "" Then
            MsgBox("Please Type Valid UserID")

        Else
            Dim validity As Boolean
            validity = True
            If Not IsNumeric(i_id) Then
                MsgBox("pls enter id as number")
                validity = False
                TextBox1.Clear()
                TextBox1.Focus()
            End If

            If (validity) Then
                myconnection.Open()
                mycommand = New SqlCommand("select * from add_stock where i_id = @i_id", myconnection)
                mycommand.Parameters.Add("@i_id", SqlDbType.VarChar).Value = i_id

                Dim adapter As New SqlDataAdapter(mycommand)
                Dim table As New DataTable()
                adapter.Fill(table)

                TextBox2.Text = table.Rows(0)(1).ToString()
                TextBox3.Text = table.Rows(0)(2).ToString()
                TextBox4.Text = table.Rows(0)(3).ToString()


                myconnection.Close()


            End If
        End If
    End Sub
End Class