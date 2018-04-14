Public Class VendorLoginForm
    Private Sub VendorLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        'If UsernameTextBox.Text = "user1" Then
        'If PasswordTextBox.Text = "password1" Then
        VendorFirstForm.Show()
        'End If
        'End If
    End Sub
End Class