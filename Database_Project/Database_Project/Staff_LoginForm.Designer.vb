<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_LoginForm
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
        Me.ID_txt = New System.Windows.Forms.TextBox()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.LoginButt = New System.Windows.Forms.Button()
        Me.BackButt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'ID_txt
        '
        Me.ID_txt.Location = New System.Drawing.Point(123, 30)
        Me.ID_txt.Name = "ID_txt"
        Me.ID_txt.Size = New System.Drawing.Size(100, 20)
        Me.ID_txt.TabIndex = 2
        '
        'Password_txt
        '
        Me.Password_txt.Location = New System.Drawing.Point(123, 70)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_txt.Size = New System.Drawing.Size(100, 20)
        Me.Password_txt.TabIndex = 3
        '
        'LoginButt
        '
        Me.LoginButt.Location = New System.Drawing.Point(256, 30)
        Me.LoginButt.Name = "LoginButt"
        Me.LoginButt.Size = New System.Drawing.Size(75, 23)
        Me.LoginButt.TabIndex = 4
        Me.LoginButt.Text = "Login"
        Me.LoginButt.UseVisualStyleBackColor = True
        '
        'BackButt
        '
        Me.BackButt.Location = New System.Drawing.Point(256, 65)
        Me.BackButt.Name = "BackButt"
        Me.BackButt.Size = New System.Drawing.Size(75, 23)
        Me.BackButt.TabIndex = 5
        Me.BackButt.Text = "Back"
        Me.BackButt.UseVisualStyleBackColor = True
        '
        'Staff_LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 115)
        Me.Controls.Add(Me.BackButt)
        Me.Controls.Add(Me.LoginButt)
        Me.Controls.Add(Me.Password_txt)
        Me.Controls.Add(Me.ID_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Staff_LoginForm"
        Me.Text = "Staff_LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_txt As TextBox
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents LoginButt As Button
    Friend WithEvents BackButt As Button
End Class
