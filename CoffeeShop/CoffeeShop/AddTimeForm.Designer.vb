<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTimeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTimeForm))
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim DayLabel As System.Windows.Forms.Label
        Dim TimeInLabel As System.Windows.Forms.Label
        Dim TimeOutLabel As System.Windows.Forms.Label
        Me.ProjectDatabaseDataSet = New CoffeeShop.ProjectDatabaseDataSet()
        Me.EmployeeScheduleTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeScheduleTableTableAdapter = New CoffeeShop.ProjectDatabaseDataSetTableAdapters.EmployeeScheduleTableTableAdapter()
        Me.TableAdapterManager = New CoffeeShop.ProjectDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeScheduleTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmployeeScheduleTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.DayTextBox = New System.Windows.Forms.TextBox()
        Me.TimeInTextBox = New System.Windows.Forms.TextBox()
        Me.TimeOutTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeScheduleTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        DayLabel = New System.Windows.Forms.Label()
        TimeInLabel = New System.Windows.Forms.Label()
        TimeOutLabel = New System.Windows.Forms.Label()
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeScheduleTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeScheduleTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeScheduleTableBindingNavigator.SuspendLayout()
        CType(Me.EmployeeScheduleTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDatabaseDataSet
        '
        Me.ProjectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet"
        Me.ProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeScheduleTableBindingSource
        '
        Me.EmployeeScheduleTableBindingSource.DataMember = "EmployeeScheduleTable"
        Me.EmployeeScheduleTableBindingSource.DataSource = Me.ProjectDatabaseDataSet
        '
        'EmployeeScheduleTableTableAdapter
        '
        Me.EmployeeScheduleTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeScheduleTableTableAdapter = Me.EmployeeScheduleTableTableAdapter
        Me.TableAdapterManager.EmployeeTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CoffeeShop.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeScheduleTableBindingNavigator
        '
        Me.EmployeeScheduleTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeScheduleTableBindingNavigator.BindingSource = Me.EmployeeScheduleTableBindingSource
        Me.EmployeeScheduleTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeScheduleTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeScheduleTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeScheduleTableBindingNavigatorSaveItem})
        Me.EmployeeScheduleTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeScheduleTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeScheduleTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeScheduleTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeScheduleTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeScheduleTableBindingNavigator.Name = "EmployeeScheduleTableBindingNavigator"
        Me.EmployeeScheduleTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeScheduleTableBindingNavigator.Size = New System.Drawing.Size(740, 25)
        Me.EmployeeScheduleTableBindingNavigator.TabIndex = 0
        Me.EmployeeScheduleTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmployeeScheduleTableBindingNavigatorSaveItem
        '
        Me.EmployeeScheduleTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeScheduleTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeScheduleTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeScheduleTableBindingNavigatorSaveItem.Name = "EmployeeScheduleTableBindingNavigatorSaveItem"
        Me.EmployeeScheduleTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeScheduleTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Gold
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(47, 211)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(200, 55)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIDLabel.ForeColor = System.Drawing.Color.White
        EmployeeIDLabel.Location = New System.Drawing.Point(37, 49)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(104, 20)
        EmployeeIDLabel.TabIndex = 10
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeScheduleTableBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(147, 46)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.EmployeeIDTextBox.TabIndex = 11
        '
        'DayLabel
        '
        DayLabel.AutoSize = True
        DayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DayLabel.ForeColor = System.Drawing.Color.White
        DayLabel.Location = New System.Drawing.Point(37, 81)
        DayLabel.Name = "DayLabel"
        DayLabel.Size = New System.Drawing.Size(41, 20)
        DayLabel.TabIndex = 12
        DayLabel.Text = "Day:"
        '
        'DayTextBox
        '
        Me.DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeScheduleTableBindingSource, "Day", True))
        Me.DayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayTextBox.Location = New System.Drawing.Point(147, 78)
        Me.DayTextBox.Name = "DayTextBox"
        Me.DayTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DayTextBox.TabIndex = 13
        '
        'TimeInLabel
        '
        TimeInLabel.AutoSize = True
        TimeInLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TimeInLabel.ForeColor = System.Drawing.Color.White
        TimeInLabel.Location = New System.Drawing.Point(37, 113)
        TimeInLabel.Name = "TimeInLabel"
        TimeInLabel.Size = New System.Drawing.Size(65, 20)
        TimeInLabel.TabIndex = 14
        TimeInLabel.Text = "Time In:"
        '
        'TimeInTextBox
        '
        Me.TimeInTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeScheduleTableBindingSource, "TimeIn", True))
        Me.TimeInTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeInTextBox.Location = New System.Drawing.Point(147, 110)
        Me.TimeInTextBox.Name = "TimeInTextBox"
        Me.TimeInTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TimeInTextBox.TabIndex = 15
        '
        'TimeOutLabel
        '
        TimeOutLabel.AutoSize = True
        TimeOutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TimeOutLabel.ForeColor = System.Drawing.Color.White
        TimeOutLabel.Location = New System.Drawing.Point(37, 145)
        TimeOutLabel.Name = "TimeOutLabel"
        TimeOutLabel.Size = New System.Drawing.Size(77, 20)
        TimeOutLabel.TabIndex = 16
        TimeOutLabel.Text = "Time Out:"
        '
        'TimeOutTextBox
        '
        Me.TimeOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeScheduleTableBindingSource, "TimeOut", True))
        Me.TimeOutTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOutTextBox.Location = New System.Drawing.Point(147, 142)
        Me.TimeOutTextBox.Name = "TimeOutTextBox"
        Me.TimeOutTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TimeOutTextBox.TabIndex = 17
        '
        'EmployeeScheduleTableDataGridView
        '
        Me.EmployeeScheduleTableDataGridView.AutoGenerateColumns = False
        Me.EmployeeScheduleTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeScheduleTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EmployeeScheduleTableDataGridView.DataSource = Me.EmployeeScheduleTableBindingSource
        Me.EmployeeScheduleTableDataGridView.Location = New System.Drawing.Point(270, 43)
        Me.EmployeeScheduleTableDataGridView.Name = "EmployeeScheduleTableDataGridView"
        Me.EmployeeScheduleTableDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.EmployeeScheduleTableDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TimeIn"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TimeIn"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TimeOut"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TimeOut"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'AddTimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(740, 291)
        Me.Controls.Add(Me.EmployeeScheduleTableDataGridView)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(DayLabel)
        Me.Controls.Add(Me.DayTextBox)
        Me.Controls.Add(TimeInLabel)
        Me.Controls.Add(Me.TimeInTextBox)
        Me.Controls.Add(TimeOutLabel)
        Me.Controls.Add(Me.TimeOutTextBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.EmployeeScheduleTableBindingNavigator)
        Me.Name = "AddTimeForm"
        Me.Text = "AddTimeForm"
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeScheduleTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeScheduleTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeScheduleTableBindingNavigator.ResumeLayout(False)
        Me.EmployeeScheduleTableBindingNavigator.PerformLayout()
        CType(Me.EmployeeScheduleTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectDatabaseDataSet As ProjectDatabaseDataSet
    Friend WithEvents EmployeeScheduleTableBindingSource As BindingSource
    Friend WithEvents EmployeeScheduleTableTableAdapter As ProjectDatabaseDataSetTableAdapters.EmployeeScheduleTableTableAdapter
    Friend WithEvents TableAdapterManager As ProjectDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeScheduleTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmployeeScheduleTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnBack As Button
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents DayTextBox As TextBox
    Friend WithEvents TimeInTextBox As TextBox
    Friend WithEvents TimeOutTextBox As TextBox
    Friend WithEvents EmployeeScheduleTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
