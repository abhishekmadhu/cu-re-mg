Public Class VendorFirstForm
    Private Sub VendorFirstForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustomerRegistrationForm.Show()
        VendorLoginForm.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OldCustomerForm.Show()
        VendorLoginForm.Close()
    End Sub
End Class