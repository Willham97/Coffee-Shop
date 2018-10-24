<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddOrders))
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim CaseCostLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProjectDatabaseDataSet = New CoffeeShop.ProjectDatabaseDataSet()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableTableAdapter = New CoffeeShop.ProjectDatabaseDataSetTableAdapters.ProductTableTableAdapter()
        Me.TableAdapterManager = New CoffeeShop.ProjectDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ProductTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.CaseCostTextBox = New System.Windows.Forms.TextBox()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        CaseCostLabel = New System.Windows.Forms.Label()
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(170, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProjectDatabaseDataSet
        '
        Me.ProjectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet"
        Me.ProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableBindingSource
        '
        Me.ProductTableBindingSource.DataMember = "ProductTable"
        Me.ProductTableBindingSource.DataSource = Me.ProjectDatabaseDataSet
        '
        'ProductTableTableAdapter
        '
        Me.ProductTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeScheduleTableTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableTableAdapter = Me.ProductTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = CoffeeShop.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductTableBindingNavigator
        '
        Me.ProductTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductTableBindingNavigator.BindingSource = Me.ProductTableBindingSource
        Me.ProductTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductTableBindingNavigatorSaveItem})
        Me.ProductTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductTableBindingNavigator.Name = "ProductTableBindingNavigator"
        Me.ProductTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductTableBindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.ProductTableBindingNavigator.TabIndex = 71
        Me.ProductTableBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ProductTableBindingNavigatorSaveItem
        '
        Me.ProductTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductTableBindingNavigatorSaveItem.Name = "ProductTableBindingNavigatorSaveItem"
        Me.ProductTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductIDLabel.ForeColor = System.Drawing.Color.White
        ProductIDLabel.Location = New System.Drawing.Point(63, 51)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(89, 20)
        ProductIDLabel.TabIndex = 71
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTableBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(174, 48)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ProductIDTextBox.TabIndex = 72
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.ForeColor = System.Drawing.Color.White
        ProductNameLabel.Location = New System.Drawing.Point(38, 99)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(114, 20)
        ProductNameLabel.TabIndex = 73
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTableBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(174, 96)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ProductNameTextBox.TabIndex = 74
        '
        'CaseCostLabel
        '
        CaseCostLabel.AutoSize = True
        CaseCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CaseCostLabel.ForeColor = System.Drawing.Color.White
        CaseCostLabel.Location = New System.Drawing.Point(63, 147)
        CaseCostLabel.Name = "CaseCostLabel"
        CaseCostLabel.Size = New System.Drawing.Size(87, 20)
        CaseCostLabel.TabIndex = 75
        CaseCostLabel.Text = "Case Cost:"
        '
        'CaseCostTextBox
        '
        Me.CaseCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTableBindingSource, "CaseCost", True))
        Me.CaseCostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaseCostTextBox.Location = New System.Drawing.Point(174, 144)
        Me.CaseCostTextBox.Name = "CaseCostTextBox"
        Me.CaseCostTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CaseCostTextBox.TabIndex = 76
        '
        'frmAddOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(484, 285)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(CaseCostLabel)
        Me.Controls.Add(Me.CaseCostTextBox)
        Me.Controls.Add(Me.ProductTableBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmAddOrders"
        Me.Text = "Add/Edit Product"
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductTableBindingNavigator.ResumeLayout(False)
        Me.ProductTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ProjectDatabaseDataSet As ProjectDatabaseDataSet
    Friend WithEvents ProductTableBindingSource As BindingSource
    Friend WithEvents ProductTableTableAdapter As ProjectDatabaseDataSetTableAdapters.ProductTableTableAdapter
    Friend WithEvents TableAdapterManager As ProjectDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductTableBindingNavigator As BindingNavigator
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
    Friend WithEvents ProductTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents CaseCostTextBox As TextBox
End Class
