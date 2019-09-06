Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Add_stock_details

    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i_id As String
        Dim iname As String
        Dim quan As String
        Dim cost As String
        Dim intCount As Integer = 0
        i_id = TextBox1.Text
        iname = TextBox2.Text
        quan = TextBox3.Text
        cost = TextBox4.Text
        If i_id = "" Or iname = "" Or quan = "" Or cost = "" Then
            MsgBox("Please fill all information")

        Else
            Dim validity As Boolean
            validity = True
            If Not IsNumeric(i_id) Then
                MsgBox("pls enter id as number")
                validity = False
                TextBox1.Clear()
                TextBox1.Focus()
            End If
            If Not IsNumeric(quan) Then
                MsgBox("pls enter quantity as number")
                validity = False
                TextBox3.Clear()
                TextBox3.Focus()
            End If
            If Not IsNumeric(cost) Then
                MsgBox("pls enter cost as number")
                validity = False
                TextBox4.Clear()
                TextBox4.Focus()
            End If

            If (validity) Then

                myconnection.Open()
                mycommand = New SqlCommand("insert into add_stock([i_id],[i_name],[quantity],[cost]) values ('" & i_id & "','" & iname & "','" & quan & "','" & cost & "')", myconnection)
                mycommand.ExecuteNonQuery()
                'MessageBox.Show("New Row Inserted" & ra)
                myconnection.Close()
                MessageBox.Show("stock added Successfully")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()

            End If





        End If


    End Sub
    Public Shared Function randomid() As String

        Dim intNumber As Integer
        Dim arrNumber(0 To 5) As Integer
        Dim i, x, y As Integer
        'Make sure the Label is clear

        Dim res As String = ""
        'We want a total of 6 Numbers (UK Lottery)

        For x = 0 To 5
Start:
            Randomize()
            intNumber = Int((49 * Rnd()) + 1) ' Random number 1 to 49
            For y = 0 To 5
                ' Check arrNumber (y)
                'If intnumber has already been selected, 
                'Then go and select another one.
                If intNumber = arrNumber(y) Then
                    GoTo Start
                End If
            Next y

            'Place the next non-repeated number in the arrNumber(x).
            arrNumber(x) = intNumber

        Next x
        '----------------------------------------------------
        For i = 0 To 5
            res = res & (arrNumber(i)) & ""
        Next

        Return res
    End Function


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = randomid()
    End Sub
End Class