Public Class frmEmployeeInput
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim eEmployeeName As String
        Dim ePhone As String
        Dim WeekDays() As String = {"Monday", "Tuesday", "Wednesday", "Thursday"}


        eEmployeeName = txtEmpName.Text
        ePhone = txtEmpPhone.Text

        MessageBox.Show("Employee Name: " & eEmployeeName & vbNewLine & "Phone:" & ePhone)


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class