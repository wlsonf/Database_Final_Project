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
        Me.DepartureBox = New System.Windows.Forms.ComboBox()
        Me.DestinationBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteButt = New System.Windows.Forms.Button()
        Me.LogoutButt = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DepartureBox
        '
        Me.DepartureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartureBox.FormattingEnabled = True
        Me.DepartureBox.Location = New System.Drawing.Point(104, 119)
        Me.DepartureBox.Name = "DepartureBox"
        Me.DepartureBox.Size = New System.Drawing.Size(121, 21)
        Me.DepartureBox.TabIndex = 19
        '
        'DestinationBox
        '
        Me.DestinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinationBox.FormattingEnabled = True
        Me.DestinationBox.Location = New System.Drawing.Point(104, 78)
        Me.DestinationBox.Name = "DestinationBox"
        Me.DestinationBox.Size = New System.Drawing.Size(121, 21)
        Me.DestinationBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Pick up Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Where to go"
        '
        'DeleteButt
        '
        Me.DeleteButt.Location = New System.Drawing.Point(125, 222)
        Me.DeleteButt.Name = "DeleteButt"
        Me.DeleteButt.Size = New System.Drawing.Size(147, 23)
        Me.DeleteButt.TabIndex = 14
        Me.DeleteButt.Text = "Delete Account"
        Me.DeleteButt.UseVisualStyleBackColor = True
        '
        'LogoutButt
        '
        Me.LogoutButt.Location = New System.Drawing.Point(30, 222)
        Me.LogoutButt.Name = "LogoutButt"
        Me.LogoutButt.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButt.TabIndex = 13
        Me.LogoutButt.Text = "Log Out"
        Me.LogoutButt.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(71, 18)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(89, 13)
        Me.NameLabel.TabIndex = 12
        Me.NameLabel.Text = "<name  / phone>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Welcome"
        '
        'Main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 265)
        Me.Controls.Add(Me.DepartureBox)
        Me.Controls.Add(Me.DestinationBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteButt)
        Me.Controls.Add(Me.LogoutButt)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main2"
        Me.Text = "Main2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DepartureBox As ComboBox
    Friend WithEvents DestinationBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DeleteButt As Button
    Friend WithEvents LogoutButt As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label1 As Label
End Class
