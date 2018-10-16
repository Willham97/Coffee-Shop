Public Class frmAddOrders
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim iProductID As String
        Dim iProductName As String
        Dim iCaseCost As String

        iProductID = txtProductId.Text
        iProductName = txtProductId.Text
        iCaseCost = TextBox1.Text

        MessageBox.Show("Product ID: " & iProductID & vbNewLine & "Product Name:" & iProductName & vbNewLine & "Case Cost: " & iCaseCost)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class