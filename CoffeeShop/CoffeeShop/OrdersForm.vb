Public Class frmOrders
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menu = New frmMenu()
        menu.show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addOrders = New frmAddOrders()
        addOrders.Show()
    End Sub

    Private Sub ProductTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDatabaseDataSet)

    End Sub

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.ProductTable)

    End Sub
End Class