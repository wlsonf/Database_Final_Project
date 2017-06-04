Imports MySql.Data.MySqlClient

Public Class Main
    Public UserYa As ClientYa = New ClientYa()
    Public UserType As String


    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub LogoutButt_Click(sender As Object, e As EventArgs) Handles LogoutButt.Click
        Me.Visible = False
        Login_Form.Visible = True
    End Sub

    Private Sub DeleteButt_Click(sender As Object, e As EventArgs) Handles DeleteButt.Click

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(UserYa.Address)
    End Sub
End Class