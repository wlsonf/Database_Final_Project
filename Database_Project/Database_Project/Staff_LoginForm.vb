﻿Imports MySql.Data.MySqlClient


Public Class Staff_LoginForm
    Public StaffYa As ClientYa = New ClientYa()

    Private Sub LoginButt_Click(sender As Object, e As EventArgs) Handles LoginButt.Click
        Dim Main = New Main

        Dim conn As MySqlConnection
        Dim comm As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM staff WHERE staffID = '" & ID_txt.Text & "' and password = '" & Password_txt.Text & "'"

        Try
            conn = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            While reader.Read
                If reader("staffID").ToString = ID_txt.Text And reader("password").ToString = Password_txt.Text Then
                    StaffYa.ClientID = reader("staffID").ToString
                    StaffYa.Name = reader("name").ToString
                    StaffYa.Phone = reader("phone").ToString
                    Main.UserYa = StaffYa
                    MessageBox.Show("Success")
                    conn.Close()
                    Main.Show()
                    Me.Dispose()
                    Return
                Else
                    MessageBox.Show("Wrong Password!")
                    Exit Sub
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackButt_Click(sender As Object, e As EventArgs) Handles BackButt.Click
        Dim Login_Form = New Login_Form
        Login_Form.Visible = True
        Me.Close()
    End Sub
End Class