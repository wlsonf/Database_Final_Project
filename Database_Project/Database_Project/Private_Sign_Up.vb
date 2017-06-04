Imports MySql.Data.MySqlClient

Public Class Private_Sign_Up
    Public UserYa As ClientYa = New ClientYa()

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand



    Private Sub Private_Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLbl.Text = UserYa.ClientID
    End Sub

    Private Function get_staffID() As String
        Dim staffID As String
        Dim reader As MySqlDataReader
        Dim queryFindStaffID As String = "SELECT m.staffID FROM office o, manager m WHERE m.officeID = o.officeID AND o.city = '" & CityBox.SelectedItem.ToString & "'"
        Try
            conn.Open()
            comm = New MySqlCommand(queryFindStaffID, conn)
            reader = comm.ExecuteReader()
            reader.Read()
            staffID = reader("staffID").ToString()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return staffID

    End Function


    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim staffID As String = get_staffID()
        Dim queryADD As String = "INSERT INTO private VALUES ('" & UserYa.ClientID & "', '" & GenderBox.SelectedItem.ToString & "', " & AgeNum.Value & ", '" & staffID & "')"

        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()

            MessageBox.Show("Account Created")
            Dim ABC As Login_Form = New Login_Form()
            ABC.Show()
            conn.Close()
            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

End Class