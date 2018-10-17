Public Class frmEmployeeInput
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim eEmployeeName As String
        Dim ePhone As String
        Dim WeekDays() As String = {"Monday", "Tuesday", "Wednesday", "Thursday"}

        Dim MonInTimes() As String = {txtTimeInMon1.Text, txtTimeInMon2.Text, txtTimeInMon3.Text}
        Dim MonOutTimes() As String = {txtTimeOutMon1.Text, txtTimeOutMon2.Text, txtTimeOutMon3.Text}

        Dim TueInTimes() As String = {txtTimeInTue1.Text, txtTimeInTue2.Text, txtTimeinTue3.Text}
        Dim TueOutTimes() As String = {txtTimeOutTue1.Text, txtTimeOutTue2.Text, txtTimeOutTue3.Text}

        Dim WedInTimes() As String = {txtTimeInWed1.Text, txtTimeInWed2.Text, txtTimeInWed3.Text}
        Dim WedOutTimes() As String = {txtTimeOutWed1.Text, txtTimeOutWed2.Text, txtTimeOutWed3.Text}

        Dim ThurInTimes() As String = {txtTimeInThur1.Text, txtTimeInThur2.Text, txtTimeInThur3.Text}
        Dim ThurOutTimes() As String = {txtTimeOutThur1.Text, txtTimeOutThur2.Text, txtTimeOutThur3.Text}


        eEmployeeName = txtEmpName.Text
        ePhone = txtEmpPhone.Text

        'MessageBox.Show("Employee Name: " & eEmployeeName & vbNewLine & "Phone:" & ePhone )
        For i = 0 To UBound(TueInTimes)
            MsgBox(TueInTimes(i))
        Next
        For i = 0 To UBound(TueOutTimes)
            MsgBox(TueOutTimes(i))
        Next

        For i = 0 To UBound(WedInTimes)
            MsgBox(WedInTimes(i))
        Next
        For i = 0 To UBound(WedOutTimes)
            MsgBox(WedOutTimes(i))
        Next

        For i = 0 To UBound(ThurInTimes)
            MsgBox(ThurInTimes(i))
        Next
        For i = 0 To UBound(ThurOutTimes)
            MsgBox(ThurOutTimes(i))
        Next


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class