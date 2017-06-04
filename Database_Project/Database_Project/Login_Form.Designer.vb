<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Me.LoginButt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PhoneNumberTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.StaffLoginButt = New System.Windows.Forms.Button()
        Me.ReqButt = New System.Windows.Forms.Button()
        Me.ExitButt = New System.Windows.Forms.Button()
        Me.SignUpButt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FastCab"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'LoginButt
        '
        Me.LoginButt.Location = New System.Drawing.Point(16, 139)
        Me.LoginButt.Name = "LoginButt"
        Me.LoginButt.Size = New System.Drawing.Size(89, 23)
        Me.LoginButt.TabIndex = 1
        Me.LoginButt.Text = "Login"
        Me.LoginButt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'PhoneNumberTxt
        '
        Me.PhoneNumberTxt.Location = New System.Drawing.Point(97, 51)
        Me.PhoneNumberTxt.Name = "PhoneNumberTxt"
        Me.PhoneNumberTxt.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberTxt.TabIndex = 4
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(97, 94)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxt.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTxt.TabIndex = 5
        '
        'StaffLoginButt
        '
        Me.StaffLoginButt.Location = New System.Drawing.Point(252, 12)
        Me.StaffLoginButt.Name = "StaffLoginButt"
        Me.StaffLoginButt.Size = New System.Drawing.Size(89, 23)
        Me.StaffLoginButt.TabIndex = 6
        Me.StaffLoginButt.Text = "Login as Staff"
        Me.StaffLoginButt.UseVisualStyleBackColor = True
        '
        'ReqButt
        '
        Me.ReqButt.Location = New System.Drawing.Point(252, 41)
        Me.ReqButt.Name = "ReqButt"
        Me.ReqButt.Size = New System.Drawing.Size(89, 23)
        Me.ReqButt.TabIndex = 7
        Me.ReqButt.Text = "Requirement"
        Me.ReqButt.UseVisualStyleBackColor = True
        '
        'ExitButt
        '
        Me.ExitButt.Location = New System.Drawing.Point(252, 70)
        Me.ExitButt.Name = "ExitButt"
        Me.ExitButt.Size = New System.Drawing.Size(89, 23)
        Me.ExitButt.TabIndex = 8
        Me.ExitButt.Text = "Exit"
        Me.ExitButt.UseVisualStyleBackColor = True
        '
        'SignUpButt
        '
        Me.SignUpButt.Location = New System.Drawing.Point(120, 139)
        Me.SignUpButt.Name = "SignUpButt"
        Me.SignUpButt.Size = New System.Drawing.Size(89, 23)
        Me.SignUpButt.TabIndex = 9
        Me.SignUpButt.Text = "New User?"
        Me.SignUpButt.UseVisualStyleBackColor = True
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 173)
        Me.Controls.Add(Me.SignUpButt)
        Me.Controls.Add(Me.ExitButt)
        Me.Controls.Add(Me.ReqButt)
        Me.Controls.Add(Me.StaffLoginButt)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.PhoneNumberTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginButt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login_Form"
        Me.Text = "Login_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButt As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PhoneNumberTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents StaffLoginButt As Button
    Friend WithEvents ReqButt As Button
    Friend WithEvents ExitButt As Button
    Friend WithEvents SignUpButt As Button
End Class
