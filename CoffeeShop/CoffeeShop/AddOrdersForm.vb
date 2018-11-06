Public Class frmAddOrders
    Private Sub btnSave_Click(sender As Object, e As EventArgs)

        Dim iProductID As String
        Dim iProductName As String
        Dim iCaseCost As String


        MessageBox.Show("Product ID: " & iProductID & vbNewLine & "Product Name:" & iProductName & vbNewLine & "Case Cost: " & iCaseCost)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ProductTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDatabaseDataSet)

    End Sub

    Private Sub frmAddOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.ProductTable)

    End Sub


End Class