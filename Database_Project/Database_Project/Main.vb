Imports MySql.Data.MySqlClient

Public Class Main
    Public UserYa As ClientYa = New ClientYa()
    Public UserType As String


    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub LogoutButt_Click(sender As Object, e As EventArgs) Handles LogoutButt.Click
        If MsgBox("Really?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            Me.Visible = False
            Login_Form.Visible = True
        Else

        End If
    End Sub

    Private Sub DeleteButt_Click(sender As Object, e As EventArgs) Handles DeleteButt.Click
        Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
        Dim comm As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "DELETE FROM client WHERE phone = '" & UserYa.Phone & "'"

        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader


            If MsgBox("Really?", MsgBoxStyle.YesNo, "Delete Account") = MsgBoxResult.Yes Then
                MsgBox("Account Deleted!", MsgBoxStyle.OkOnly, "FastCab")
                reader.Read()
                Me.Close()
            Else

            End If


        Catch ex As Exception
            MsgBox("Wrong Phone Number", MsgBoxStyle.Critical, "ERROR")
        End Try


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(UserYa.ClientID)
        Dim monyet As String
        NameLabel.Text = UserYa.Name
    End Sub
End Class