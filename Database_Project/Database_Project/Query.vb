Public Class Query
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Login_Form = New Login_Form
        Login_Form.Show()
        Me.Visible = False
    End Sub
End Class
