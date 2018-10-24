Public Class frmMenu
    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim orders = New frmOrders()
        Me.Hide()
        orders.Show()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click

    End Sub

    Private Sub btnSchedual_Click(sender As Object, e As EventArgs) Handles btnSchedual.Click
        Dim schedual = New SchedualForm()
        Me.Hide()
        schedual.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
