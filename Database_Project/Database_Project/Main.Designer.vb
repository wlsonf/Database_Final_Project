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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogoutButt = New System.Windows.Forms.Button()
        Me.DeleteButt = New System.Windows.Forms.Button()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "<name  / phone>"
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.DeleteButt)
        Me.Controls.Add(Me.LogoutButt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "MainApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogoutButt As Button
    Friend WithEvents DeleteButt As Button
End Class
