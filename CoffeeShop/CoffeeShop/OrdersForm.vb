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
End Class