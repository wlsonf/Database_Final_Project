<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Contract
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClientLbl = New System.Windows.Forms.Label()
        Me.CityBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ClientID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "City"
        '
        'ClientLbl
        '
        Me.ClientLbl.AutoSize = True
        Me.ClientLbl.Location = New System.Drawing.Point(80, 13)
        Me.ClientLbl.Name = "ClientLbl"
        Me.ClientLbl.Size = New System.Drawing.Size(27, 13)
        Me.ClientLbl.TabIndex = 2
        Me.ClientLbl.Text = "cl00"
        '
        'CityBox
        '
        Me.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CityBox.FormattingEnabled = True
        Me.CityBox.Items.AddRange(New Object() {"Glasgow", "Aberdeen", "Edinburgh", "Stirling", "Dundee"})
        Me.CityBox.Location = New System.Drawing.Point(83, 40)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(121, 21)
        Me.CityBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Create_Contract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 115)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.ClientLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Create_Contract"
        Me.Text = "Create_Contract"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ClientLbl As Label
    Friend WithEvents CityBox As ComboBox
    Friend WithEvents Button1 As Button
End Class
