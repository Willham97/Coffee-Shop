Imports System.Drawing.Printing
Imports System.IO

Public Class SchedualForm
    Const MANUALSCHEDULE_PATH = "ManualSchedule.dat"

    'OPEN MAIN MENU FORM AND CLOSE THIS ONE?
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'TODO; Open main menu form.
        Me.Close()
    End Sub

    'OPEN EMPLOYEE FORM AND CLOSE THIS ONE?
    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        'TODO; Open employees form.
    End Sub

    'SAVE ON FORM CLOSE
    Private Sub SchedualForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnSave.PerformClick()
    End Sub

    'LOAD FUNCTIONALITY; not from database but instead from file
    Private Sub SchedualForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.EmployeeScheduleTable' table. You can move, or remove it, as needed.
        'Me.EmployeeScheduleTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.EmployeeScheduleTable)
        If File.Exists(MANUALSCHEDULE_PATH) Then
            Dim fReader As StreamReader = File.OpenText(MANUALSCHEDULE_PATH)
            For i As Decimal = 420 To 1170 Step 30
                Dim line As String() = fReader.ReadLine().Split(vbTab)
                DataGridView1.Rows.Add(line(0), line(1), line(2), line(3), line(4), line(5), line(6), line(7), line(8))
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).HeaderCell.Value = New DateTime().AddMinutes(i).ToShortTimeString()
            Next
            fReader.Close()
        Else
            For i As Decimal = 420 To 1170 Step 30
                DataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "")
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).HeaderCell.Value = New DateTime().AddMinutes(i).ToShortTimeString()
            Next
        End If
    End Sub

    'SAVE FUNCTIONALITY; not to database but instead to file
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'get the file as a write object
        Dim fWriter As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(MANUALSCHEDULE_PATH, False)
        'get each row in the datagridview and write the strings to file
        For Each row As DataGridViewRow In DataGridView1.Rows
            fWriter.WriteLine(String.Join(vbTab, Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray(),
                Function(c) If(c.Value IsNot Nothing, c.Value.ToString(), ""))))
        Next
        fWriter.Close()
    End Sub

    'PRINTING FUNCTIONALITY
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'opens a print dialog that can handle a simple print of the datagrid view
        Dim printDialog As New PrintDialog()
        Dim printDoc As New PrintDocument()
        printDoc.DocumentName = "IHCC Schedule"
        printDoc.DefaultPageSettings.Landscape = True
        printDoc.DefaultPageSettings.Color = False
        AddHandler printDoc.PrintPage, AddressOf OnPrintPage
        printDialog.Document = printDoc

        If (printDialog.ShowDialog() = DialogResult.OK) Then
            printDoc.Print()
        End If
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'create a memory bitmap and size to the form
        Using bmp As Bitmap = New Bitmap(Me.Width, Me.Height)

            'Draws the form/component as a bitmap image
            DataGridView1.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

            'draw the form image on the printer graphics sized and centered to margins
            Dim ratio As Single = CSng(bmp.Width / bmp.Height)
            If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
                e.Graphics.DrawImage(bmp,
                e.MarginBounds.Left,
                CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - ((e.MarginBounds.Width / ratio) / 2)),
                e.MarginBounds.Width,
                CInt(e.MarginBounds.Width / ratio))
            Else
                e.Graphics.DrawImage(bmp,
                CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.MarginBounds.Height * ratio / 2)),
                e.MarginBounds.Top,
                CInt(e.MarginBounds.Height * ratio),
                e.MarginBounds.Height)
            End If
        End Using
    End Sub
End Class