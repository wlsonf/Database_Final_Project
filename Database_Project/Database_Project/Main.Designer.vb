<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.LogoutButt = New System.Windows.Forms.Button()
        Me.DeleteButt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DestinationBox = New System.Windows.Forms.ComboBox()
        Me.DepartureBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(71, 13)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(89, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "<name  / phone>"
        '
        'LogoutButt
        '
        Me.LogoutButt.Location = New System.Drawing.Point(30, 217)
        Me.LogoutButt.Name = "LogoutButt"
        Me.LogoutButt.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButt.TabIndex = 2
        Me.LogoutButt.Text = "Log Out"
        Me.LogoutButt.UseVisualStyleBackColor = True
        '
        'DeleteButt
        '
        Me.DeleteButt.Location = New System.Drawing.Point(125, 217)
        Me.DeleteButt.Name = "DeleteButt"
        Me.DeleteButt.Size = New System.Drawing.Size(147, 23)
        Me.DeleteButt.TabIndex = 3
        Me.DeleteButt.Text = "Delete Account"
        Me.DeleteButt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Where to go"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pick up Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DestinationBox
        '
        Me.DestinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinationBox.FormattingEnabled = True
        Me.DestinationBox.Location = New System.Drawing.Point(104, 73)
        Me.DestinationBox.Name = "DestinationBox"
        Me.DestinationBox.Size = New System.Drawing.Size(121, 21)
        Me.DestinationBox.TabIndex = 9
        '
        'DepartureBox
        '
        Me.DepartureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartureBox.FormattingEnabled = True
        Me.DepartureBox.Location = New System.Drawing.Point(104, 114)
        Me.DepartureBox.Name = "DepartureBox"
        Me.DepartureBox.Size = New System.Drawing.Size(121, 21)
        Me.DepartureBox.TabIndex = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.DepartureBox)
        Me.Controls.Add(Me.DestinationBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteButt)
        Me.Controls.Add(Me.LogoutButt)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "MainApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents LogoutButt As Button
    Friend WithEvents DeleteButt As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DestinationBox As ComboBox
    Friend WithEvents DepartureBox As ComboBox
End Class
