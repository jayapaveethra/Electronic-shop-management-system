Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class User_order
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i_name As String
        i_name = TextBox1.Text
        Dim validity As Boolean
        validity = True

        If i_name = "" Then
            MsgBox("Please Type Valid UserID")

        End If
        myconnection.Open()
        Dim sqlOrder As New SqlCommand()
        sqlOrder.Connection = myconnection
        sqlOrder.CommandText = "SELECT * FROM add_stock WHERE i_name ='" & i_name & "' "
        Dim sqlReading As SqlDataReader = sqlOrder.ExecuteReader()

        If (Not sqlReading.Read() = True) Then

            MsgBox("item not exist")
            validity = False
        End If
        myconnection.Close()
        If (validity) Then
            myconnection.Open()
            mycommand = New SqlCommand("select * from add_stock where i_name = @i_name", myconnection)
            mycommand.Parameters.Add("@i_name", SqlDbType.VarChar).Value = i_name

            Dim adapter As New SqlDataAdapter(mycommand)
            Dim table As New DataTable()
            adapter.Fill(table)

            TextBox3.Text = table.Rows(0)(0).ToString()
            TextBox4.Text = table.Rows(0)(2).ToString()
            TextBox5.Text = table.Rows(0)(3).ToString()


            myconnection.Close()


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i_id As String
        Dim i_name As String
        Dim quan As String
        Dim cost As String
        Dim uname As String
        i_name = TextBox1.Text
        i_id = TextBox3.Text
        uname = TextBox2.Text
        quan = TextBox4.Text
        cost = TextBox5.Text
        myconnection.Open()
        mycommand = New SqlCommand("insert into booking([i_name],[i_id],[uname],[quantity],[cost]) values ('" & i_name & "','" & i_id & "','" & uname & "','" & quan & "','" & cost & "')", myconnection)
        mycommand.ExecuteNonQuery()
        'MessageBox.Show("New Row Inserted" & ra)
        myconnection.Close()
        MessageBox.Show("Details added  Successfully")
        User_payment.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User_payment.Show()

    End Sub
End Class