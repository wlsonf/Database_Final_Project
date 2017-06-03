Imports MySql.Data.MySqlClient

Public Class Sign_Up
    Private Sub SignUpButt_Click(sender As Object, e As EventArgs) Handles SignUpButt.Click
        'Me.Close()
        Dim conn As MySqlConnection
        Dim comm As MySqlCommand
        Dim reader As MySqlDataReader
        Dim queryADD As String = "INSERT INTO client VALUES ('','" & NameTxt.Text & "', '" & PhoneTxt.Text & "', '" & ComboBox1.SelectedItem.ToString & "' , '', '" & PasswordTxt.Text & "')"
        '                                                     clientID, name, phone, class, address, password
        Try
            conn = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            reader = comm.ExecuteReader

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButt_Click(sender As Object, e As EventArgs) Handles BackButt.Click
        Me.Close()
    End Sub
End Class