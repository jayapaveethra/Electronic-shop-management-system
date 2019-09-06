Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class User_payment
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim i_id As String
        Dim i_name As String
        Dim quan As String
        Dim cost As String
        Dim uname As String
        i_name = TextBox1.Text
        i_id = TextBox2.Text
        uname = TextBox3.Text
        quan = TextBox4.Text
        cost = TextBox5.Text
        myconnection.Open()
        mycommand = New SqlCommand("insert into c_booking([i_name],[i_id],[uname],[quantity],[cost]) values ('" & i_name & "','" & i_id & "','" & uname & "','" & quan & "','" & cost & "')", myconnection)
        mycommand.ExecuteNonQuery()
        'MessageBox.Show("New Row Inserted" & ra)
        myconnection.Close()
        MessageBox.Show("Details added  Successfully")

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String
        Dim m As String
        Dim m1 As String
        Dim validity As Boolean
        validity = True

        uname = TextBox1.Text

        myconnection.Open()
        Dim sqlOrder As New SqlCommand()
        sqlOrder.Connection = myconnection
        sqlOrder.CommandText = "SELECT * FROM booking WHERE uname ='" & uname & "' "
        Dim sqlReading As SqlDataReader = sqlOrder.ExecuteReader()

        If (Not sqlReading.Read() = True) Then

            MsgBox("u are not booking any thing")
            validity = False
        End If
        myconnection.Close()
        If (validity) Then
            myconnection.Open()
            mycommand = New SqlCommand("select * from booking where uname = @uname", myconnection)
            mycommand.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname

            Dim adapter As New SqlDataAdapter(mycommand)
            Dim table As New DataTable()
            adapter.Fill(table)
            TextBox2.Text = table.Rows(0)(0).ToString()
            TextBox3.Text = table.Rows(0)(1).ToString()
            TextBox4.Text = table.Rows(0)(3).ToString()
            m = table.Rows(0)(4).ToString()
            m1 = table.Rows(0)(3).ToString()
            TextBox5.Text = m * m1


            myconnection.Close()


        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Feedback.Show()

    End Sub
End Class