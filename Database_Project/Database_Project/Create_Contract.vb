Imports MySql.Data.MySqlClient

Public Class Create_Contract
    Public UserYa As ClientYa

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand

    Private Function get_bottomest_id() As Int32
        Dim reader As MySqlDataReader
        Dim contractID As String = ""
        Dim nums As String = ""
        Dim num As Int32
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT contractID FROM contract ORDER BY contractID DESC", conn)
            reader = comm.ExecuteReader()
            reader.Read()
            contractID = reader("clientID").ToString()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each c As Char In contractID
            If IsNumeric(c) Then
                nums = nums & c
            End If
        Next

        num = Int32.Parse(nums)
        Return num
    End Function

    Private Function get_staffID() As String
        Dim staffID As String = ""
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim staffID As String = get_staffID()
        Dim nextID As String = "ct" & (get_bottomest_id() + 1).ToString()
        Dim queryADD As String = "INSERT INTO contract VALUES ('" & nextID & "', '" & staffID & "', 0, 0)"

        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()

            MessageBox.Show("Account Created")
            Dim ABC As Business_Sign_Up = New Business_Sign_Up()
            ABC.UserYa = UserYa
            ABC.ContractID = nextID
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