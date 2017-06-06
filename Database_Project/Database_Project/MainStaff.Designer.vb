<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainStaff
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChooseBox = New System.Windows.Forms.ComboBox()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.ReturnBtn = New System.Windows.Forms.Button()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Show Table:"
        '
        'ChooseBox
        '
        Me.ChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseBox.FormattingEnabled = True
        Me.ChooseBox.Items.AddRange(New Object() {"", "admin", "business", "client", "contract", "driver", "external", "job", "manager", "office", "owner", "private", "receipt", "staff", "taxi"})
        Me.ChooseBox.Location = New System.Drawing.Point(74, 38)
        Me.ChooseBox.Name = "ChooseBox"
        Me.ChooseBox.Size = New System.Drawing.Size(195, 21)
        Me.ChooseBox.TabIndex = 2
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(74, 75)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(586, 253)
        Me.dgvTable.TabIndex = 3
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Location = New System.Drawing.Point(584, 35)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReturnBtn.TabIndex = 4
        Me.ReturnBtn.Text = "Return"
        Me.ReturnBtn.UseVisualStyleBackColor = True
        '
        'MainStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 340)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.ChooseBox)
        Me.Controls.Add(Me.Label2)
        Me.Name = "MainStaff"
        Me.Text = "MainStaff"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ChooseBox As ComboBox
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents ReturnBtn As Button
End Class
