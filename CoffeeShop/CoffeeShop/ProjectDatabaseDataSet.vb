Partial Class ProjectDatabaseDataSet
    Partial Public Class EmployeeScheduleTableDataTable
        Private Sub EmployeeScheduleTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DayColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
