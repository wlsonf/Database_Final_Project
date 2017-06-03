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
        Dim Main = New Main

        If PhoneNumberTxt.Text = "admin" And PasswordTxt.Text = "admin" Then
            MsgBox("Logged In", MsgBoxStyle.Information, "Login")
            Main.Show()
            Me.Visible = False
        Else
            If PhoneNumberTxt.Text = "" Then
                MsgBox("Phone Number cannot be empty", MsgBoxStyle.Critical, "ERROR")
            Else
                If PasswordTxt.Text = "" Then
                    MsgBox("Password cannot be empty", MsgBoxStyle.Critical, "ERROR")
                Else
                    MsgBox("Wrong Phone Number / Password", MsgBoxStyle.Critical, "ERROR")
                End If
            End If
        End If
    End Sub

    Private Sub ExitButt_Click(sender As Object, e As EventArgs) Handles ExitButt.Click
        MsgBox("Bye", MsgBoxStyle.OkOnly, "FastCab")
        Me.Close()
    End Sub

    Private Sub SignUpButt_Click(sender As Object, e As EventArgs) Handles SignUpButt.Click
        Dim Sign_Up = New Sign_Up
        Sign_Up.ShowDialog()
    End Sub
End Class