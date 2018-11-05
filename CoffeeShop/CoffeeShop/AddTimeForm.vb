Public Class AddTimeForm
    Private Sub EmployeeScheduleTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeScheduleTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeScheduleTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDatabaseDataSet)

    End Sub

    Private Sub AddTimeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.EmployeeScheduleTable' table. You can move, or remove it, as needed.
        Me.EmployeeScheduleTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.EmployeeScheduleTable)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class