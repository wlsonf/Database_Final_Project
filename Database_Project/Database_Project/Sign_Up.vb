Imports MySql.Data.MySqlClient

Public Class Sign_Up

    Public UserYa As ClientYa = New ClientYa()
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand

    Private Function get_bottomest_id() As Int32
        Dim reader As MySqlDataReader
        Dim clientID As String
        Dim nums As String = ""
        Dim num As Int32
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT clientID FROM client ORDER BY clientID DESC", conn)
            reader = comm.ExecuteReader()
            reader.Read()
            clientID = reader("clientID").ToString()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each c As Char In clientID
            If IsNumeric(c) Then
                nums = nums & c
            End If
        Next

        num = Int32.Parse(nums)
        Return num
    End Function


    Private Sub SignUpButt_Click(sender As Object, e As EventArgs) Handles SignUpButt.Click
        'Me.Close()
        Dim reader As MySqlDataReader
        Dim a As String
        If ComboBox1.SelectedIndex = 0 Then
            a = "p"
        Else
            a = "b"
        End If
        Dim queryADD As String = "INSERT INTO client VALUES ('cl" & (get_bottomest_id() + 1).ToString() & "','" & NameTxt.Text & "', '" & PhoneTxt.Text & "', '" & a & "' , '" & AddressTxt.Text & "', '" & PasswordTxt.Text & "')"
        '                                                     clientID, name, phone, class, address, password
        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()
            conn.Close()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButt_Click(sender As Object, e As EventArgs) Handles BackButt.Click
        Me.Close()
    End Sub
End Class