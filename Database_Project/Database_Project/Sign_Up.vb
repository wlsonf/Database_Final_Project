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


        Dim a As String
        Dim nextID As String = "cl" & (get_bottomest_id() + 1).ToString()
        If ComboBox1.SelectedIndex = 0 Then
            a = "p"
        Else
            a = "b"
        End If
        Dim queryADD As String = "INSERT INTO client VALUES ('" & nextID & "','" & NameTxt.Text & "', '" & PhoneTxt.Text & "', '" & a & "' , '" & AddressTxt.Text & "', '" & PasswordTxt.Text & "')"
        '                                                     clientID, name, phone, class, address, password
        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()
            If ComboBox1.SelectedIndex = 0 Then
                Dim Private_SU As Private_Sign_Up = New Private_Sign_Up()
                UserYa.ClientID = nextID
                UserYa.Name = NameTxt.Text
                UserYa.Phone = PhoneTxt.Text
                UserYa.ClassYa = a
                UserYa.Address = AddressTxt.Text
                Private_SU.UserYa = UserYa

                Private_SU.Show()

            Else
                a = "b"
            End If

            conn.Close()
            Me.Visible = False
            Login_Form.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

End Class