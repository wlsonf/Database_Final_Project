Public Class Login_Form
    Private Sub StaffLoginButt_Click(sender As Object, e As EventArgs) Handles StaffLoginButt.Click
        Dim Staff_LoginForm = New Staff_LoginForm
        Me.Visible = False
        Staff_LoginForm.Show()
    End Sub

    Private Sub ReqButt_Click(sender As Object, e As EventArgs) Handles ReqButt.Click
        Dim Query = New Query
        Me.Visible = False
        Query.Show()
    End Sub

    Private Sub LoginButt_Click(sender As Object, e As EventArgs) Handles LoginButt.Click
        If PhoneNumberTxt.Text = "admin" And PasswordTxt.Text = "admin" Then
            MsgBox("Logged In", MsgBoxStyle.Information, "Login")
        Else
            If PhoneNumberTxt.Text = "" And PasswordTxt.Text = "" Then
                MsgBox("Incorrect Phone / Password", MsgBoxStyle.Critical, "ERROR")
            End If
        End If
        Dim Main = New Main
        Me.Visible = False
        Main.Show()
    End Sub

    Private Sub ExitButt_Click(sender As Object, e As EventArgs) Handles ExitButt.Click
        Me.Close()
    End Sub

    Private Sub SignUpButt_Click(sender As Object, e As EventArgs) Handles SignUpButt.Click
        Dim Sign_Up = New Sign_Up
        Me.Visible = False
        Sign_Up.Visible = True
    End Sub
End Class