<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleForm
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ProjectDatabaseDataSet = New CoffeeShop.ProjectDatabaseDataSet()
        Me.EmployeeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableTableAdapter = New CoffeeShop.ProjectDatabaseDataSetTableAdapters.EmployeeTableTableAdapter()
        Me.TableAdapterManager = New CoffeeShop.ProjectDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Gold
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(107, 352)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(200, 55)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ProjectDatabaseDataSet
        '
        Me.ProjectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet"
        Me.ProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableBindingSource
        '
        Me.EmployeeTableBindingSource.DataMember = "EmployeeTable"
        Me.EmployeeTableBindingSource.DataSource = Me.ProjectDatabaseDataSet
        '
        'EmployeeTableTableAdapter
        '
        Me.EmployeeTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeScheduleTableTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableTableAdapter = Me.EmployeeTableTableAdapter
        Me.TableAdapterManager.ProductTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CoffeeShop.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mon, Me.tue, Me.wed, Me.thur})
        Me.DataGridView1.Location = New System.Drawing.Point(129, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(448, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'mon
        '
        Me.mon.HeaderText = "Monday"
        Me.mon.Name = "mon"
        '
        'tue
        '
        Me.tue.HeaderText = "Tuesday"
        Me.tue.Name = "tue"
        '
        'wed
        '
        Me.wed.HeaderText = "Wednesday"
        Me.wed.Name = "wed"
        '
        'thur
        '
        Me.thur.HeaderText = "Thursday"
        Me.thur.Name = "thur"
        '
        'ScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "ScheduleForm"
        Me.Text = "ScheduleForm"
        CType(Me.ProjectDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents ProjectDatabaseDataSet As ProjectDatabaseDataSet
    Friend WithEvents EmployeeTableBindingSource As BindingSource
    Friend WithEvents EmployeeTableTableAdapter As ProjectDatabaseDataSetTableAdapters.EmployeeTableTableAdapter
    Friend WithEvents TableAdapterManager As ProjectDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mon As DataGridViewTextBoxColumn
    Friend WithEvents tue As DataGridViewTextBoxColumn
    Friend WithEvents wed As DataGridViewTextBoxColumn
    Friend WithEvents thur As DataGridViewTextBoxColumn
End Class
