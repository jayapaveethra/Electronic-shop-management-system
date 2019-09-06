Public Class Stock_details
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add_stock_details.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Check_availability.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        View_details.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Feedback.Show()

    End Sub
End Class