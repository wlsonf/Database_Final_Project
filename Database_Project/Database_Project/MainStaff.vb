Imports MySql.Data.MySqlClient

Public Class MainStaff
    Public UserYa As ClientYa

    Dim conn As MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataTable
    Dim bsource As New BindingSource
    Dim comm As New MySqlCommand

    Private Sub display(query As String)
        'dgvTable.DataSource = Nothing
        ds = New DataTable()
        dgvTable.DataSource = ds
        conn = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
        'query = "SELECT s.name, s.phone FROM manager m, staff s WHERE m.staffID = s.staffID"

        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)

            da.SelectCommand = comm
            da.Fill(ds)
            bsource.DataSource = ds
            dgvTable.DataSource = bsource
            da.Update(ds)

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChooseBox.SelectedIndex = 0
        'dgvTable.DataSource = Nothing
    End Sub


    Private Sub BoxQuery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChooseBox.SelectedIndexChanged
        Dim query As String = ""


        Select Case ChooseBox.SelectedIndex()
            Case 0
                Return
            Case 1
                query = "SELECT * FROM admin"
            Case 2
                query = "SELECT * FROM business"
            Case 3
                query = "SELECT * FROM client"
            Case 4
                query = "SELECT * FROM contract"
            Case 5
                query = "SELECT * FROM driver"
            Case 6
                query = "SELECT * FROM external"
            Case 7
                query = "SELECT * FROM job"
            Case 8
                query = "SELECT * FROM manager"
            Case 9
                query = "SELECT * FROM office"
            Case 10
                query = "SELECT * FROM owner"
            Case 11
                query = "SELECT * FROM private"
            Case 12
                query = "SELECT * FROM  receipt"
            Case 13
                query = "SELECT * FROM staff"
            Case 14
                query = "SELECT * FROM taxi"
        End Select

        display(query)

    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click

        Me.Close()

    End Sub
End Class