Public Class Opening
    Private Sub Opening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MembersLbl.Text = "Bernardus Jeffrey Darmawan - 2001585474 " & Environment.NewLine & "Mikha Putri Yupikha - 2001585575 " & Environment.NewLine & "Wilson Fransicius Willyam - 2001585303"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AAA As Login_Form = New Login_Form()
        AAA.Show()
        Me.Dispose()
    End Sub
End Class