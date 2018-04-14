Imports System.Data.OleDb
Public Class OldCustomerForm
    Private Sub OldCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub

    Private Sub productID_Click(sender As Object, e As EventArgs) Handles productID.Click
        Dim productID, SQLstring As String
        Dim dtProperties As New DataTable()
        Dim dbDataAdapter As OleDbDataAdapter
        productID = TextBox1.Text
        Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = customers.mdb"
        SQLstring = "SELECT * FROM customerList  WHERE Product_ID = " & "'" & productID & "'" & ""
        dbDataAdapter = New OleDbDataAdapter(SQLstring, ConnectString)
        dbDataAdapter.Fill(dtProperties)
        grdProperties.DataSource = dtProperties
    End Sub
End Class