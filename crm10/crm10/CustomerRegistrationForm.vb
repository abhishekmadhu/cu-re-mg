Public Class CustomerRegistrationForm

    Private Sub CustomerRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet31)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingContext(DataSet31, "customerList").Position =
            BindingContext(DataSet31, "customerList").Position + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingContext(DataSet31, "customerList").Position =
            BindingContext(DataSet31, "customerList").Position - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNewCustomer.Show()
    End Sub
End Class