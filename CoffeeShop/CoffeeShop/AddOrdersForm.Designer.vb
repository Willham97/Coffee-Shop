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
        Me.lblProdId = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.lblCaseCost = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblProdId
        '
        Me.lblProdId.AutoSize = True
        Me.lblProdId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdId.ForeColor = System.Drawing.Color.White
        Me.lblProdId.Location = New System.Drawing.Point(119, 40)
        Me.lblProdId.Name = "lblProdId"
        Me.lblProdId.Size = New System.Drawing.Size(89, 20)
        Me.lblProdId.TabIndex = 3
        Me.lblProdId.Text = "Product ID:"
        '
        'txtProductId
        '
        Me.txtProductId.AccessibleName = "txtProductId"
        Me.txtProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductId.Location = New System.Drawing.Point(239, 37)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(129, 26)
        Me.txtProductId.TabIndex = 4
        '
        'txtProductName
        '
        Me.txtProductName.AccessibleDescription = "txtProductName"
        Me.txtProductName.AccessibleName = "txtProductName"
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(239, 90)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(129, 26)
        Me.txtProductName.TabIndex = 6
        '
        'lblProdName
        '
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdName.ForeColor = System.Drawing.Color.White
        Me.lblProdName.Location = New System.Drawing.Point(119, 93)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(114, 20)
        Me.lblProdName.TabIndex = 5
        Me.lblProdName.Text = "Product Name:"
        '
        'lblCaseCost
        '
        Me.lblCaseCost.AutoSize = True
        Me.lblCaseCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseCost.ForeColor = System.Drawing.Color.White
        Me.lblCaseCost.Location = New System.Drawing.Point(119, 147)
        Me.lblCaseCost.Name = "lblCaseCost"
        Me.lblCaseCost.Size = New System.Drawing.Size(87, 20)
        Me.lblCaseCost.TabIndex = 7
        Me.lblCaseCost.Text = "Case Cost:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Gold
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(76, 211)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 46)
        Me.btnSave.TabIndex = 69
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(253, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 46)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = "txtCaseCost"
        Me.TextBox1.AccessibleName = "txtCaseCost"
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(239, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 26)
        Me.TextBox1.TabIndex = 71
        '
        'frmAddOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(484, 285)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCaseCost)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblProdName)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.lblProdId)
        Me.Name = "frmAddOrders"
        Me.Text = "Add/Edit Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProdId As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblProdName As Label
    Friend WithEvents lblCaseCost As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
