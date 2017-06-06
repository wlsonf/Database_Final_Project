Imports MySql.Data.MySqlClient

Public Class Journey
    Public UserYa As ClientYa = New ClientYa()
    Public Jour As Trip = New Trip()

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand

    Private Sub DoneBtn_Click(sender As Object, e As EventArgs) Handles DoneBtn.Click
        Dim charge As Int32 = Jour.Mileage * 4000
        Dim sCharge As String = charge.ToString()
        MessageBox.Show(UserYa.ClassYa)
        If charge = 0 Or UserYa.ClassYa = "b" Then
            sCharge = "null"
        End If
        Dim queryADD As String = "INSERT INTO receipt VALUES ('" & Jour.JobID & "', " & Jour.Mileage & ", 'succeed', 'ok', " & sCharge & ");
                                  UPDATE job SET dTime = CURTIME() WHERE jobID = '" & Jour.JobID & "'; "
        If UserYa.ClassYa = "b" Then
            queryADD = queryADD & "UPDATE contract SET totalMilage = totalMilage + " & Jour.Mileage & " WHERE contractID = '" & UserYa.ContractYa.ContractID & "';
                                   UPDATE contract SET numberOfJob = numberOfJob + 1 WHERE contractID = '" & UserYa.ContractYa.ContractID & "';"
        End If

        MessageBox.Show("Congratulations you have arrived at your destination.")

        Try
            conn.Open()
            comm = New MySqlCommand(queryADD, conn)
            comm.ExecuteNonQuery()

            conn.Close()
            Me.Visible = False
            Dim Main As Main2 = New Main2()
            Main.UserYa = UserYa
            Main.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

        'MESSAGE BOX ARE YOU SURE
        'IF SURE EXECUTE
        'ELSE BACK (RETURN)


        Dim charge As Int32 = Jour.Mileage * 4000
        Dim sCharge As String = charge.ToString()
        If charge = 0 Or UserYa.ClassYa = "b" Then
            sCharge = "null"
        End If
        Dim queryADD As String = "INSERT INTO receipt VALUES ('" & Jour.JobID & "', '0', 'failed', 'user cancel', 'NULL');
                                  UPDATE job SET dTime = CURTIME() WHERE jobID = '" & Jour.JobID & "'; "
        If UserYa.ClassYa = "b" Then
            queryADD = queryADD & "UPDATE contract SET totalMilage = totalMilage + 0 WHERE contractID = '" & UserYa.ContractYa.ContractID & "';
                                   UPDATE contract SET numberOfJob = numberOfJob + 0 WHERE contractID = '" & UserYa.ContractYa.ContractID & "';"
        End If

        If MsgBox("Really?", MsgBoxStyle.YesNo, "Cancel the trip?") = MsgBoxResult.Yes Then
            MsgBox("Trip canceled!", MsgBoxStyle.OkOnly, "FastCab")
            comm.ExecuteNonQuery()
            Me.Close()
            Try
                conn.Open()
                comm = New MySqlCommand(queryADD, conn)
                comm.ExecuteNonQuery()

                conn.Close()
                Me.Visible = False
                Dim Main As Main2 = New Main2()
                Main.UserYa = UserYa

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Drive resumed")
        End If

    End Sub
End Class