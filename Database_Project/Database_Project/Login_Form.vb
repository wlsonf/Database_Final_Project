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
        Dim Main As Main = New Main()

        'If PhoneNumberTxt.Text = "admin" And PasswordTxt.Text = "admin" Then
        '    MsgBox("Logged In", MsgBoxStyle.Information, "Login")
        '    Main.Show()
        '    Me.Visible = False
        'Else
        '    If PhoneNumberTxt.Text = "" Then
        '        MsgBox("Phone Number cannot be empty", MsgBoxStyle.Critical, "ERROR")
        '    Else
        '        If PasswordTxt.Text = "" Then
        '            MsgBox("Password cannot be empty", MsgBoxStyle.Critical, "ERROR")
        '        Else
        '            MsgBox("Wrong Phone Number / Password", MsgBoxStyle.Critical, "ERROR")
        '        End If
        '    End If
        'End If
        Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
        Dim comm As MySqlCommand
        Dim reader As MySqlDataReader
        'Dim str As String = "server=localhost; uid=root; pwd=; database=fastcab;"
        Dim query As String = "SELECT * FROM client WHERE phone = '" & PhoneNumberTxt.Text & "'"

        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader

            If reader("password").ToString = PasswordTxt.Text Then
                UserYa.ClientID = reader("clientID").ToString
                UserYa.Name = reader("name").ToString
                UserYa.Phone = reader("phone").ToString
                UserYa.ClassYa = reader("class").ToString
                UserYa.Address = reader("address").ToString
                Main.UserYa = UserYa
                MessageBox.Show("Success")
                conn.Close()
                Main.Show()
                Me.Dispose()
                Return
                'ElseIf 

            Else
                MessageBox.Show("Wrong Password!")
                Exit Sub
            End If


        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Wrong PhoneNumber")
        End Try

    End Sub

    Private Sub ExitButt_Click(sender As Object, e As EventArgs) Handles ExitButt.Click
        MsgBox("Bye", MsgBoxStyle.OkOnly, "FastCab")
        Me.Close()
    End Sub

    Private Sub SignUpButt_Click(sender As Object, e As EventArgs) Handles SignUpButt.Click
        Dim Sign_Up = New Sign_Up
        Sign_Up.Show()
        Me.Dispose()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

End Class