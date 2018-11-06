Public Class EmployeeForm
    Private Sub EmployeeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDatabaseDataSet)

    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.EmployeeTable' table. You can move, or remove it, as needed.
        Me.EmployeeTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.EmployeeTable)

    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click
        Dim addTime = New AddTimeForm()
        addTime.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Me.Close()
    End Sub

    Private Sub EmployeeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim menu = New frmMenu()
        menu.Show()
    End Sub
End Class