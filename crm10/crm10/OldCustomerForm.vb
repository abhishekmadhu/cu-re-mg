Public Class OldCustomerForm
    Private Sub OldCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub
End Class