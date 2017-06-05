Imports MySql.Data.MySqlClient

Public Class Journey
    Public UserYa As ClientYa = New ClientYa()
    Public Jour As Trip = New Trip()

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand



    Private Sub DoneBtn_Click(sender As Object, e As EventArgs) Handles DoneBtn.Click
        Dim charge As Int32 = Jour.Mileage * 4000
        Dim sCharge As String = charge.ToString()
        If charge = 0 Then
            sCharge = "null"
        End If
        Dim queryADD As String = "INSERT INTO receipt VALUES ('" & Jour.JobID & "', " & Jour.Mileage & ", 'succeed', 'ok', " & sCharge & ");
                                 UPDATE job SET dTime = CURTIME() WHERE jobID = '" & Jour.JobID & "'; "


        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()

            conn.Close()
            Me.Visible = False
            Login_Form.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub




End Class