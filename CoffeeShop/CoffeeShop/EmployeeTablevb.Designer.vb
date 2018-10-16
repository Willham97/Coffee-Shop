<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeTablevb
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.empId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mondayHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tuesHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wedHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thurHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empId, Me.empName, Me.empPhone, Me.mondayHours, Me.tuesHours, Me.wedHours, Me.thurHours})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'empId
        '
        Me.empId.HeaderText = "Employee Id"
        Me.empId.Name = "empId"
        '
        'empName
        '
        Me.empName.HeaderText = "Employee Name"
        Me.empName.Name = "empName"
        '
        'empPhone
        '
        Me.empPhone.HeaderText = "Phone Number"
        Me.empPhone.Name = "empPhone"
        '
        'mondayHours
        '
        Me.mondayHours.HeaderText = "Monday"
        Me.mondayHours.Name = "mondayHours"
        '
        'tuesHours
        '
        Me.tuesHours.HeaderText = "Tuesday"
        Me.tuesHours.Name = "tuesHours"
        '
        'wedHours
        '
        Me.wedHours.HeaderText = "Wednesday"
        Me.wedHours.Name = "wedHours"
        '
        'thurHours
        '
        Me.thurHours.HeaderText = "Thursday"
        Me.thurHours.Name = "thurHours"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(608, 392)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 46)
        Me.Button3.TabIndex = 76
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(413, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 46)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(218, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Add/Remove"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Gold
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(23, 392)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 46)
        Me.btnSave.TabIndex = 73
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'EmployeeTablevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EmployeeTablevb"
        Me.Text = "EmployeeTablevb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents empId As DataGridViewTextBoxColumn
    Friend WithEvents empName As DataGridViewTextBoxColumn
    Friend WithEvents empPhone As DataGridViewTextBoxColumn
    Friend WithEvents mondayHours As DataGridViewTextBoxColumn
    Friend WithEvents tuesHours As DataGridViewTextBoxColumn
    Friend WithEvents wedHours As DataGridViewTextBoxColumn
    Friend WithEvents thurHours As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
End Class
