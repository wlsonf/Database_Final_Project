Imports MySql.Data.MySqlClient

Public Class Login_Form
    Public UserYa As ClientYa = New ClientYa()

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
        Dim Main As Main2 = New Main2()
        Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
        Dim comm As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM client WHERE phone = '" & PhoneNumberTxt.Text & "'"

        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            reader.Read()

            If reader("password").ToString = PasswordTxt.Text Then
                UserYa.ClientID = reader("clientID").ToString
                UserYa.Name = reader("name").ToString
                UserYa.Phone = reader("phone").ToString
                UserYa.ClassYa = reader("class").ToString
                UserYa.Address = reader("address").ToString
                Main.UserYa = UserYa
                MsgBox("Welcome " + UserYa.Name + "!", MsgBoxStyle.OkOnly, "Success")
                conn.Close()
                Main.Show()
                Me.Dispose()
                Return
            Else
                MsgBox("Wrong Password!", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If


        Catch ex As Exception
            MsgBox("Wrong Phone Number", MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub ExitButt_Click(sender As Object, e As EventArgs) Handles ExitButt.Click
        If MsgBox("Really?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            MsgBox("Bye", MsgBoxStyle.OkOnly, "FastCab")
            Me.Close()
        Else

        End If
    End Sub

    Private Sub SignUpButt_Click(sender As Object, e As EventArgs) Handles SignUpButt.Click
        Dim Sign_Up = New Sign_Up
        Sign_Up.ShowDialog()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

End Class