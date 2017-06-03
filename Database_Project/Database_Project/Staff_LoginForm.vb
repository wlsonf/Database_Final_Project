Public Class Staff_LoginForm
    Private Sub LoginButt_Click(sender As Object, e As EventArgs) Handles LoginButt.Click
        Dim Main = New Main

        If ID_txt.Text = "admin" And Password_txt.Text = "admin" Then
            MsgBox("Logged In", MsgBoxStyle.Information, "Login")
            Main.Show()
            Me.Visible = False
        Else
            If ID_txt.Text = "" Then
                MsgBox("Phone Number cannot be empty", MsgBoxStyle.Critical, "ERROR")
            Else
                If Password_txt.Text = "" Then
                    MsgBox("Password cannot be empty", MsgBoxStyle.Critical, "ERROR")
                Else
                    MsgBox("Wrong Phone Number / Password", MsgBoxStyle.Critical, "ERROR")
                End If
            End If
        End If
    End Sub

    Private Sub BackButt_Click(sender As Object, e As EventArgs) Handles BackButt.Click
        Dim Login_Form = New Login_Form
        Login_Form.Visible = True
        Me.Close()
    End Sub
End Class