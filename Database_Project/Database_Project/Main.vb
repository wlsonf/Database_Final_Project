Imports MySql.Data.MySqlClient

Public Class Main
    Private Sub LogoutButt_Click(sender As Object, e As EventArgs) Handles LogoutButt.Click
        Me.Visible = False
        Login_Form.Visible = True
    End Sub

    Private Sub DeleteButt_Click(sender As Object, e As EventArgs) Handles DeleteButt.Click

    End Sub
End Class