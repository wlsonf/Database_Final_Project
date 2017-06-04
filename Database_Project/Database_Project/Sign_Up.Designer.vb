<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.PhoneTxt = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BackButt = New System.Windows.Forms.Button()
        Me.SignUpButt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type"
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(100, 25)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(100, 20)
        Me.NameTxt.TabIndex = 3
        '
        'PhoneTxt
        '
        Me.PhoneTxt.Location = New System.Drawing.Point(100, 54)
        Me.PhoneTxt.Name = "PhoneTxt"
        Me.PhoneTxt.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTxt.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Private", "Business"})
        Me.ComboBox1.Location = New System.Drawing.Point(100, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'BackButt
        '
        Me.BackButt.Location = New System.Drawing.Point(16, 188)
        Me.BackButt.Name = "BackButt"
        Me.BackButt.Size = New System.Drawing.Size(89, 23)
        Me.BackButt.TabIndex = 9
        Me.BackButt.Text = "Back"
        Me.BackButt.UseVisualStyleBackColor = True
        '
        'SignUpButt
        '
        Me.SignUpButt.Location = New System.Drawing.Point(174, 188)
        Me.SignUpButt.Name = "SignUpButt"
        Me.SignUpButt.Size = New System.Drawing.Size(89, 23)
        Me.SignUpButt.TabIndex = 10
        Me.SignUpButt.Text = "Sign Up"
        Me.SignUpButt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(100, 110)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(99, 20)
        Me.PasswordTxt.TabIndex = 12
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(14, 86)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address"
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(99, 82)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(100, 20)
        Me.AddressTxt.TabIndex = 14
        '
        'Sign_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 229)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SignUpButt)
        Me.Controls.Add(Me.BackButt)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PhoneTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sign_Up"
        Me.Text = "Sign_Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents PhoneTxt As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BackButt As Button
    Friend WithEvents SignUpButt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents AddressTxt As TextBox
End Class
