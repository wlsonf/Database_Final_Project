<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Private_Sign_Up
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
        Me.CityBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.IDLbl = New System.Windows.Forms.Label()
        Me.AgeNum = New System.Windows.Forms.NumericUpDown()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        CType(Me.AgeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ClientID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Age"
        '
        'CityBox
        '
        Me.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CityBox.FormattingEnabled = True
        Me.CityBox.Items.AddRange(New Object() {"Glasgow", "Aberdeen", "Edinburgh", "Stirling", "Dundee"})
        Me.CityBox.Location = New System.Drawing.Point(108, 106)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 21)
        Me.CityBox.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "City"
        '
        'GenderBox
        '
        Me.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"male", "female"})
        Me.GenderBox.Location = New System.Drawing.Point(108, 44)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(100, 21)
        Me.GenderBox.TabIndex = 19
        '
        'IDLbl
        '
        Me.IDLbl.AutoSize = True
        Me.IDLbl.Location = New System.Drawing.Point(108, 20)
        Me.IDLbl.Name = "IDLbl"
        Me.IDLbl.Size = New System.Drawing.Size(27, 13)
        Me.IDLbl.TabIndex = 20
        Me.IDLbl.Text = "cl00"
        '
        'AgeNum
        '
        Me.AgeNum.Location = New System.Drawing.Point(108, 76)
        Me.AgeNum.Name = "AgeNum"
        Me.AgeNum.Size = New System.Drawing.Size(46, 20)
        Me.AgeNum.TabIndex = 21
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(108, 137)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 22
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'Private_Sign_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 180)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.AgeNum)
        Me.Controls.Add(Me.IDLbl)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Private_Sign_Up"
        Me.Text = "Private_Sign_Up"
        CType(Me.AgeNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CityBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents IDLbl As Label
    Friend WithEvents AgeNum As NumericUpDown
    Friend WithEvents SubmitBtn As Button
End Class
