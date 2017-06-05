Imports MySql.Data.MySqlClient

Public Class Main2
    Public UserYa As ClientYa = New ClientYa()

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; uid=root; pwd=; database=fastcab;")
    Dim comm As MySqlCommand


    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub LogoutButt_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        If MsgBox("Really?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            Me.Visible = False
            Login_Form.Visible = True
        Else

        End If
    End Sub

    Private Sub DeleteButt_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        'Dim reader As MySqlDataReader
        Dim query As String = "DELETE FROM client WHERE phone = '" & UserYa.Phone & "'"

        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            'reader = comm.ExecuteReader


            If MsgBox("Really?", MsgBoxStyle.YesNo, "Delete Account") = MsgBoxResult.Yes Then
                MsgBox("Account Deleted!", MsgBoxStyle.OkOnly, "FastCab")
                comm.ExecuteNonQuery()
                Me.Close()
            Else

            End If

            conn.Close()

        Catch ex As Exception
            MsgBox("Wrong Phone Number", MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(UserYa.ClientID)
        'Dim monyet As String
        NameLabel.Text = UserYa.Name

        If UserYa.ClassYa = "b" Then
            find_contract()
        End If

        LoadComboBox()

        'Dim departure As List(Of String)
        'Dim destination As List(Of String)


        'DepartureBox.DataSource = departure
        'DestinationBox.DataSource = destination



    End Sub

    Private Function find_distance() As Int32
        Dim distance As Int32
        Dim reader As MySqlDataReader
        'Dim query As String = "SELECT distance FROM mapping WHERE (departure = '" & DepartureBox.SelectedItem.ToString() & "' 
        '                        OR destination = '" & DepartureBox.SelectedItem.ToString() & "') 
        '                        AND (departure = '" & DestinationBox.SelectedItem.ToString() & "'
        '                        OR destination = '" & DestinationBox.SelectedItem.ToString() & "');"
        Dim query As String = "SELECT distance FROM distance 
                                WHERE pAddress = '" & DepartureBox.SelectedItem.ToString() & "' 
                                AND dAddress = '" & DestinationBox.SelectedItem.ToString() & "';"
        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            reader.Read()
            distance = Int32.Parse(reader("distance").ToString())

            conn.Close()

        Catch ex As Exception
            MsgBox("Error: ", MsgBoxStyle.Critical, "ERROR")
        End Try

        Return distance

    End Function

    Private Function find_driver() As String
        Dim drivers As List(Of String) = New List(Of String)
        Dim driver As String = ""

        Dim reader As MySqlDataReader
        Dim query As String

        If (UserYa.ClassYa = "p") Then
            query = "SELECT d.extID FROM driver d, private p WHERE d.staffID = p.staffID;" 'KALO PRIVATE CARI DI PRIVATE, KALO BUSINESS CARI DI BUSINESS
        Else
            query = "SELECT d.extID FROM driver d, business WHERE d.staffID = b.staffID;"
        End If
        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader()

            While reader.Read()
                drivers.Add(reader("extID").ToString())
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox("Error: ", MsgBoxStyle.Critical, "ERROR")
        End Try

        Dim range As Int32 = drivers.Count()
        driver = drivers(Math.Ceiling(Rnd() * range))
        Return driver

    End Function

    Private Function get_bottomest_id() As Int32
        Dim reader As MySqlDataReader
        Dim jobID As String = ""
        Dim nums As String = ""
        Dim num As Int32
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT jobID FROM job ORDER BY jobID DESC", conn)
            reader = comm.ExecuteReader()
            reader.Read()
            jobID = reader("clientID").ToString()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        For Each c As Char In jobID
            If IsNumeric(c) Then
                nums = nums & c
            End If
        Next

        num = Int32.Parse(nums)
        Return num
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GoBtn.Click

        Dim nextID As String = "jb" & (get_bottomest_id() + 1).ToString()
        Dim a As String = "INSERT INTO job VALUES ('" & nextID & "', '" & find_driver() & "', '" & UserYa.ClientID & "', CURDATE(), CURTIME(), null, '
                          " & DepartureBox.SelectedItem.ToString() & "', '" & DestinationBox.SelectedItem.ToString() & "');"

        Try
            conn.Open()

            comm = New MySqlCommand(a, conn)
            comm.ExecuteNonQuery()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim Jour As Trip = New Trip()
        Dim AAA As Journey = New Journey()

        Jour.Mileage = find_distance()
        Jour.JobID = nextID
        AAA.Jour = Jour
        AAA.Show()
        Me.Dispose()

    End Sub

    Private Sub find_contract()
        Dim reader As MySqlDataReader
        Dim queryy As String = "SELECT contractID FROM business WHERE clientID = '" & UserYa.ClientID & "';"

        Try
            conn.Open()
            comm = New MySqlCommand(queryy, conn)
            reader = comm.ExecuteReader()
            reader.Read()
            UserYa.ContractYa.ContractID = reader("contractID").ToString()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadComboBox()
        Dim reader As MySqlDataReader
        Dim pAdd As List(Of String) = New List(Of String)
        Dim dAdd As List(Of String) = New List(Of String)
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT pAddress FROM distance GROUP BY pAddress", conn)
            reader = comm.ExecuteReader()
            While reader.Read()
                pAdd.Add(reader("pAddress").ToString())
            End While

            comm = New MySqlCommand("SELECT dAddress FROM distance GROUP BY dAddress", conn)
            reader = comm.ExecuteReader()
            While reader.Read()
                dAdd.Add(reader("dAddress").ToString())
            End While

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class