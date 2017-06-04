Imports MySql.Data.MySqlClient


Public Class Query
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Login_Form = New Login_Form
        Login_Form.Show()
        Me.Visible = False
    End Sub

    Dim conn As MySqlConnection
    Dim SDA As New MySqlDataAdapter
    Dim DBdataset As New DataTable
    Dim bsource As New BindingSource
    Dim comm As New MySqlCommand

    Private Sub display(query As String)

        conn = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
        query = "SELECT s.name, s.phone FROM manager m, staff s WHERE m.staffID = s.staffID"

        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)

            SDA.SelectCommand = comm
            SDA.Fill(DBdataset)
            bsource.DataSource = DBdataset
            dgvTable.DataSource = bsource
            SDA.Update(DBdataset)

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BoxQuery.SelectedIndex = 0
        'dgvTable.DataSource = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxQuery.SelectedIndexChanged
        Dim query As String

        Select Case BoxQuery.SelectedIndex()
            Case 0
                Return
            Case 1
                query = ""
            Case 2
                query = ""
            Case 3
                query = ""
            Case 4
                query = ""
            Case 5
                query = ""
            Case 6
                query = ""
            Case 7
                query = ""
            Case 8
                query = ""
            Case 9
                query = ""
            Case 10
                query = ""
            Case 11
                query = ""
            Case 12
                query = ""
            Case 13
                query = ""
            Case 14
                query = ""
            Case 15
                query = ""
            Case 16
                query = ""
            Case 17
                query = ""
            Case 18
                query = ""
            Case 19
                query = ""
        End Select
        display(query)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

End Class
