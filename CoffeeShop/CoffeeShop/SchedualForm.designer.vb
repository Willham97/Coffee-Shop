<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSchedual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ScheduleGrid = New System.Windows.Forms.DataGridView()
        Me.TimeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MondayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TuesdayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WednesdayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThursdayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        CType(Me.ScheduleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScheduleGrid
        '
        Me.ScheduleGrid.AllowUserToAddRows = False
        Me.ScheduleGrid.AllowUserToDeleteRows = False
        Me.ScheduleGrid.AllowUserToResizeColumns = False
        Me.ScheduleGrid.AllowUserToResizeRows = False
        Me.ScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduleGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeColumn, Me.MondayColumn, Me.TuesdayColumn, Me.WednesdayColumn, Me.ThursdayColumn})
        Me.ScheduleGrid.Location = New System.Drawing.Point(12, 12)
        Me.ScheduleGrid.MultiSelect = False
        Me.ScheduleGrid.Name = "ScheduleGrid"
        Me.ScheduleGrid.ReadOnly = True
        Me.ScheduleGrid.RowTemplate.ReadOnly = True
        Me.ScheduleGrid.Size = New System.Drawing.Size(543, 595)
        Me.ScheduleGrid.TabIndex = 0
        '
        'TimeColumn
        '
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TimeColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TimeColumn.HeaderText = "Times"
        Me.TimeColumn.Name = "TimeColumn"
        Me.TimeColumn.ReadOnly = True
        '
        'MondayColumn
        '
        Me.MondayColumn.HeaderText = "Monday"
        Me.MondayColumn.Name = "MondayColumn"
        Me.MondayColumn.ReadOnly = True
        '
        'TuesdayColumn
        '
        Me.TuesdayColumn.HeaderText = "Tuesday"
        Me.TuesdayColumn.Name = "TuesdayColumn"
        Me.TuesdayColumn.ReadOnly = True
        '
        'WednesdayColumn
        '
        Me.WednesdayColumn.HeaderText = "Wednesday"
        Me.WednesdayColumn.Name = "WednesdayColumn"
        Me.WednesdayColumn.ReadOnly = True
        '
        'ThursdayColumn
        '
        Me.ThursdayColumn.HeaderText = "Thursday"
        Me.ThursdayColumn.Name = "ThursdayColumn"
        Me.ThursdayColumn.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Gold
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(12, 623)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(157, 46)
        Me.btnPrint.TabIndex = 75
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.Color.Gold
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEmployees.Location = New System.Drawing.Point(204, 623)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(157, 46)
        Me.btnEmployees.TabIndex = 74
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Gold
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenu.Location = New System.Drawing.Point(398, 623)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(157, 46)
        Me.btnMenu.TabIndex = 73
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'frmSchedual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(567, 690)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.ScheduleGrid)
        Me.Name = "frmSchedual"
        Me.Text = "Schedule"
        CType(Me.ScheduleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScheduleGrid As DataGridView
    Friend WithEvents TimeColumn As DataGridViewTextBoxColumn
    Friend WithEvents MondayColumn As DataGridViewTextBoxColumn
    Friend WithEvents TuesdayColumn As DataGridViewTextBoxColumn
    Friend WithEvents WednesdayColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThursdayColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnMenu As Button
End Class
