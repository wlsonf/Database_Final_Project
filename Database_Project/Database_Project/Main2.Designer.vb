<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DepartureBox = New System.Windows.Forms.ComboBox()
        Me.DestinationBox = New System.Windows.Forms.ComboBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome,"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(85, 25)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(25, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "abc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Where to go"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Destination"
        '
        'DepartureBox
        '
        Me.DepartureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartureBox.FormattingEnabled = True
        Me.DepartureBox.Location = New System.Drawing.Point(124, 59)
        Me.DepartureBox.Name = "DepartureBox"
        Me.DepartureBox.Size = New System.Drawing.Size(121, 21)
        Me.DepartureBox.TabIndex = 4
        '
        'DestinationBox
        '
        Me.DestinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinationBox.FormattingEnabled = True
        Me.DestinationBox.Location = New System.Drawing.Point(124, 91)
        Me.DestinationBox.Name = "DestinationBox"
        Me.DestinationBox.Size = New System.Drawing.Size(121, 21)
        Me.DestinationBox.TabIndex = 5
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(103, 138)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(75, 23)
        Me.GoBtn.TabIndex = 6
        Me.GoBtn.Text = "Go"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'LogOutBtn
        '
        Me.LogOutBtn.Location = New System.Drawing.Point(19, 171)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Size = New System.Drawing.Size(117, 23)
        Me.LogOutBtn.TabIndex = 7
        Me.LogOutBtn.Text = "Log Out"
        Me.LogOutBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(142, 171)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(122, 23)
        Me.DeleteBtn.TabIndex = 8
        Me.DeleteBtn.Text = "Delete Account"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 215)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.LogOutBtn)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.DestinationBox)
        Me.Controls.Add(Me.DepartureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main2"
        Me.Text = "Main2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DepartureBox As ComboBox
    Friend WithEvents DestinationBox As ComboBox
    Friend WithEvents GoBtn As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents DeleteBtn As Button
End Class
