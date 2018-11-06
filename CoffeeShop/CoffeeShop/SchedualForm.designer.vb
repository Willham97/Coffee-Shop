<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedualForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MonColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TueColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TueColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TueColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WedColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WedColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThurColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThurColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThurColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonColumn, Me.MonColumn2, Me.MonColumn3, Me.TueColumn, Me.TueColumn2, Me.TueColumn3, Me.WedColumn, Me.WedColumn2, Me.WedColumn3, Me.ThurColumn, Me.ThurColumn2, Me.ThurColumn3})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 90
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1293, 595)
        Me.DataGridView1.TabIndex = 0
        '
        'MonColumn
        '
        Me.MonColumn.HeaderText = ""
        Me.MonColumn.Name = "MonColumn"
        '
        'MonColumn2
        '
        Me.MonColumn2.HeaderText = "Monday"
        Me.MonColumn2.Name = "MonColumn2"
        '
        'MonColumn3
        '
        Me.MonColumn3.DividerWidth = 2
        Me.MonColumn3.HeaderText = ""
        Me.MonColumn3.Name = "MonColumn3"
        '
        'TueColumn
        '
        Me.TueColumn.HeaderText = ""
        Me.TueColumn.Name = "TueColumn"
        '
        'TueColumn2
        '
        Me.TueColumn2.HeaderText = "Tuesday"
        Me.TueColumn2.Name = "TueColumn2"
        '
        'TueColumn3
        '
        Me.TueColumn3.DividerWidth = 2
        Me.TueColumn3.HeaderText = ""
        Me.TueColumn3.Name = "TueColumn3"
        '
        'WedColumn
        '
        Me.WedColumn.HeaderText = ""
        Me.WedColumn.Name = "WedColumn"
        '
        'WedColumn2
        '
        Me.WedColumn2.HeaderText = "Wednesday"
        Me.WedColumn2.Name = "WedColumn2"
        '
        'WedColumn3
        '
        Me.WedColumn3.DividerWidth = 2
        Me.WedColumn3.HeaderText = ""
        Me.WedColumn3.Name = "WedColumn3"
        '
        'ThurColumn
        '
        Me.ThurColumn.HeaderText = ""
        Me.ThurColumn.Name = "ThurColumn"
        '
        'ThurColumn2
        '
        Me.ThurColumn2.HeaderText = "Thursday"
        Me.ThurColumn2.Name = "ThurColumn2"
        '
        'ThurColumn3
        '
        Me.ThurColumn3.HeaderText = ""
        Me.ThurColumn3.Name = "ThurColumn3"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Gold
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(296, 613)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(211, 55)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Home"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.Gold
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(807, 613)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(211, 55)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Gold
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(555, 613)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(211, 55)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'SchedualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1317, 680)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SchedualForm"
        Me.Text = "Schedule Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents MonColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MonColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TueColumn As DataGridViewTextBoxColumn
    Friend WithEvents TueColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TueColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents WedColumn As DataGridViewTextBoxColumn
    Friend WithEvents WedColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents WedColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ThurColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThurColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ThurColumn3 As DataGridViewTextBoxColumn
End Class
