Imports MySql.Data.MySqlClient


Public Class Staff_LoginForm
    Public StaffYa As ClientYa = New ClientYa()

    Private Sub LoginButt_Click(sender As Object, e As EventArgs) Handles LoginButt.Click
        If ID_txt.Text = "" Then
            MsgBox("ID cannot be empty", MsgBoxStyle.Critical, "ERROR")
        ElseIf Password_txt.Text = "" Then
            MsgBox("Password cannot be empty", MsgBoxStyle.Critical, "ERROR")
        End If

        Dim Main = New Main

        Dim conn As MySqlConnection
        Dim comm As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM staff WHERE staffID = '" & ID_txt.Text & "'"

        Try
            conn = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            reader.Read()
            If reader("password").ToString = Password_txt.Text Then
                StaffYa.ClientID = reader("staffID").ToString
                StaffYa.Name = reader("name").ToString
                StaffYa.Phone = reader("phone").ToString
                Main.UserYa = StaffYa
                MessageBox.Show("Success")
                conn.Close()
                Main.Show()
                Me.Dispose()
                Return
            Else
                MessageBox.Show("Wrong Password!")
                Exit Sub
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButt_Click(sender As Object, e As EventArgs) Handles BackButt.Click
        Dim Login_Form = New Login_Form
        Login_Form.Visible = True
        Me.Close()
    End Sub
End Class