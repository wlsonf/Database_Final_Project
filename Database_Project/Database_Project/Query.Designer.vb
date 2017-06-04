<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Query
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxQuery = New System.Windows.Forms.ComboBox()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose question:"
        '
        'BoxQuery
        '
        Me.BoxQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxQuery.FormattingEnabled = True
        Me.BoxQuery.Items.AddRange(New Object() {"Choose item", "(a)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names and phone numbers of the Managers at each office", "(b)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names of all female drivers based in the Glasgow office. ", "(c)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of staff at each office.", "(d)" & Global.Microsoft.VisualBasic.ChrW(9) & "The details of all taxis at the Glasgow office.", "(e)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of W registered taxis.", "(f)" & Global.Microsoft.VisualBasic.ChrW(9) & "The number of drivers allocated to each taxi.", "(g)" & Global.Microsoft.VisualBasic.ChrW(9) & "The name and number of owners with more than one taxi.", "(h)" & Global.Microsoft.VisualBasic.ChrW(9) & "The full address of all business clients in Glasgow.", "(i)" & Global.Microsoft.VisualBasic.ChrW(9) & "The details of the current contracts with business clients in Glasgow.", "(j)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of private clients in each city.", "(k)" & Global.Microsoft.VisualBasic.ChrW(9) & "The details of jobs undertaken by a driver on a given day.", "(l)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names of drivers who are over 55 years old.", "(m)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names and numbers of private clients who hired a taxi in November 2016.", "(n)" & Global.Microsoft.VisualBasic.ChrW(9) & "The names and addresses of private clients who have hired a taxi more than th" &
                "ree times.", "(o)" & Global.Microsoft.VisualBasic.ChrW(9) & "The average number of miles driven during a job.", "(p)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of jobs allocated to each car.", "(q)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of jobs allocated to each driver.", "(r)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total amount charged for each car in November 2016.", "(s)" & Global.Microsoft.VisualBasic.ChrW(9) & "The total number of jobs and miles driven for a given contract."})
        Me.BoxQuery.Location = New System.Drawing.Point(109, 13)
        Me.BoxQuery.Name = "BoxQuery"
        Me.BoxQuery.Size = New System.Drawing.Size(493, 21)
        Me.BoxQuery.TabIndex = 1
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(16, 55)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(586, 253)
        Me.dgvTable.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(526, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 352)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.BoxQuery)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Query"
        Me.Text = "Form1"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BoxQuery As ComboBox
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
