Public Class frmMenu
    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim orders = New frmOrders()
        orders.Show()
        Me.Hide()

    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Dim employee = New EmployeeForm()
        employee.Show()
        Me.Hide()
    End Sub

    Private Sub btnSchedual_Click(sender As Object, e As EventArgs) Handles btnSchedual.Click
        Dim schedual = New SchedualForm()
        schedual.Show()
        Me.Hide()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
