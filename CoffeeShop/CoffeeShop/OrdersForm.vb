Public Class frmOrders
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menu = New frmMenu()
        menu.show()
        Me.Hide()
    End Sub
End Class