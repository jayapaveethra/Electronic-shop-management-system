Public Class View_details


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicshopDataSet2.add_stock' table. You can move, or remove it, as needed.
        Me.Add_stockTableAdapter.Fill(Me.ElectronicshopDataSet2.add_stock)

    End Sub
End Class