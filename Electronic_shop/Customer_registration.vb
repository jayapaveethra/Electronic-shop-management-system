Imports System.Data

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Customer_registration
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer


    Dim myconnection As New SqlConnection("Server=(LocalDb)\LocalDBDemo;Database=electronicshop;Integrated Security = true")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        Dim ph As String
        Dim email As String
        username = TextBox1.Text
        password = TextBox2.Text
        ph = TextBox4.Text
        email = TextBox3.Text

        'If IsNothing(userid) != "" And fn != "" And ln!="" And ph!="" And email!="" And proof!="" Then
        If username = "" Or password = "" Or ph = "" Or email = "" Then
            MsgBox("Please Type Valid Details")


        Else

            Dim validity As Boolean
            Dim validity1 As Boolean
            validity = True

            validity1 = False
            If Not CheckPhoneNumber(ph) Then
                MessageBox.Show("Please Enter Phone Number!")
                validity = False
                TextBox4.Clear()
                TextBox4.Focus()
            End If

            If Not IsValidEmailFormat(email) Then
                MessageBox.Show("Please Enter Valid Email ID!")
                validity = False
                TextBox3.Clear()
                TextBox3.Focus()
            End If


            If (validity) Then


                myconnection.Open()
                mycommand = New SqlCommand("insert into c_registration([username],[password],[email],[ph]) values ('" & username & "','" & password & "','" & email & "','" & ph & "')", myconnection)
                mycommand.ExecuteNonQuery()
                'MessageBox.Show("New Row Inserted" & ra)
                myconnection.Close()
                MessageBox.Show("Customer Details Are Registered Successfully")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()

            End If


        End If



    End Sub

    Public Shared Function CheckPhoneNumber(ByVal strPhoneNumber As String) As Boolean
        Dim MatchPhoneNumberPattern As String = "^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"
        If strPhoneNumber IsNot Nothing Then
            Return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern)
        Else
            Return False
        End If
    End Function



    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
End Class