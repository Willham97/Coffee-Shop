<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnSchedual = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOrders
        '
        Me.btnOrders.BackColor = System.Drawing.Color.Gold
        Me.btnOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOrders.Location = New System.Drawing.Point(142, 63)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(200, 55)
        Me.btnOrders.TabIndex = 0
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.Color.Gold
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEmployees.Location = New System.Drawing.Point(142, 149)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(200, 55)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnSchedual
        '
        Me.btnSchedual.BackColor = System.Drawing.Color.Gold
        Me.btnSchedual.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSchedual.Location = New System.Drawing.Point(142, 235)
        Me.btnSchedual.Name = "btnSchedual"
        Me.btnSchedual.Size = New System.Drawing.Size(200, 55)
        Me.btnSchedual.TabIndex = 2
        Me.btnSchedual.Text = "Schedule"
        Me.btnSchedual.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gold
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(142, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 55)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSchedual)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnOrders)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOrders As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnSchedual As Button
    Friend WithEvents btnExit As Button
End Class
