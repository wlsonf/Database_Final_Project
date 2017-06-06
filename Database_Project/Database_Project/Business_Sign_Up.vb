Imports MySql.Data.MySqlClient

Public Class Business_Sign_Up
    Public UserYa As ClientYa
    Public ContractID As String

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = UserYa.ClientID
        TextBox1.Text = ContractID
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim queryADD As String = "INSERT INTO business VALUES ('" & UserYa.ClientID & "', '" & ContractID & "');"


        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()

            MessageBox.Show("Account Created")
            Dim DONE As Login_Form = New Login_Form()
            DONE.Show()
            conn.Close()
            Me.Dispose()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CreateLbl_Click(sender As Object, e As EventArgs) Handles CreateLbl.Click
        Dim ABC As Create_Contract = New Create_Contract()

        ABC.UserYa = UserYa
        ABC.Show()
        Me.Dispose()

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

End Class