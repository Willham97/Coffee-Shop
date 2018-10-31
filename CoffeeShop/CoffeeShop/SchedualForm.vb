Public Class SchedualForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.EmployeeScheduleTable' table. You can move, or remove it, as needed.
        Me.EmployeeScheduleTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.EmployeeScheduleTable)
        'For i As Decimal = 7 To 19.5 Step 0.5
        For i As Decimal = 420 To 1170 Step 30

            ScheduleGrid.Rows.Add(New DateTime().AddMinutes(i), "m", "t", "w", "th")
        Next
    End Sub

    Private Sub ScheduleGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ScheduleGrid.CellContentClick

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim menu = New frmMenu()
        Me.Hide()
        menu.Show()

    End Sub
End Class