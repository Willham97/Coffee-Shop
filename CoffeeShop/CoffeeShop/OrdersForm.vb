Imports System.Drawing.Printing

Public Class frmOrders
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menu = New frmMenu()
        menu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addOrders = New frmAddOrders()
        addOrders.Show()
    End Sub

    Private Sub ProductTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDatabaseDataSet)

    End Sub

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.ProjectDatabaseDataSet.ProductTable)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'opens a print dialog that can handle a simple print of the datagrid view
        Dim printDialog As New PrintDialog()
        Dim printDoc As New PrintDocument()
        printDoc.DocumentName = "IHCC Orders"
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
            ProductTableDataGridView.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

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