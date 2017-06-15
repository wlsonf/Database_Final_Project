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
        Dim query As String = ""
        ' XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX    INI KALO JADI MAU SEMUANYA DIBERSIHIN XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        query = query & "DELETE FROM receipt WHERE jobID IN (SELECT jobID FROM job WHERE clientID = '" & UserYa.ClientID & "');
                                DELETE FROM job WHERE clientID = '" & UserYa.ClientID & "';"
        If UserYa.ClassYa = "b" Then
            query = query & "DELETE FROM business WHERE clientID = '" & UserYa.ClientID & "';
                            DELETE FROM contract WHERE contractID = '" & UserYa.ContractYa.ContractID & "';"
        Else
            query = query & "DELETE FROM private WHERE clientID = '" & UserYa.ClientID & "';"
        End If

        query = query & "DELETE FROM client WHERE clientID = '" & UserYa.ClientID & "';"
        'MessageBox.Show(UserYa.ClientID)
        Try
            conn.Open()
            comm = New MySqlCommand(query, conn)
            'reader = comm.ExecuteReader

            If MsgBox("Really?", MsgBoxStyle.YesNo, "Delete Account") = MsgBoxResult.Yes Then
                MsgBox("Account Deleted!", MsgBoxStyle.OkOnly, "FastCab")

            Else
                Return
            End If
            comm.ExecuteNonQuery()

            conn.Close()

            Dim AAA As Login_Form = New Login_Form()
            AAA.Show()
            Me.Dispose()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            conn.Close()
        End Try

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(UserYa.ClientID)
        'Dim monyet As String
        NameLabel.Text = UserYa.Name
        'MessageBox.Show("abcdowudasd")

        If UserYa.ClassYa = "b" Then
            find_contract()
        End If
        'MessageBox.Show(UserYa.Type)

        LoadComboBox("", "")
        DepartureBox.SelectedIndex = 0
        redisplay()

        If UserYa.Type = "staff" Then
            admin.Visible = True
            GoBtn.Visible = False
            DeleteBtn.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            DepartureBox.Visible = False
            DestinationBox.Visible = False
        ElseIf UserYa.Type = "client" Then
            admin.Visible = False
        Else
            admin.Visible = False
        End If

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

        Return distance

    End Function

    Private Function find_driver() As String
        Dim drivers As List(Of String) = New List(Of String)
        Dim driver As String = ""

        Dim reader As MySqlDataReader
        Dim query As String

        If (UserYa.ClassYa = "p") Then
            query = "SELECT d.extID FROM driver d, private p WHERE d.staffID = p.staffID AND p.clientID = '" & UserYa.ClientID & "';" 'KALO PRIVATE CARI DI PRIVATE, KALO BUSINESS CARI DI BUSINESS
        Else
            query = "SELECT d.extID FROM driver d, business b, contract ct WHERE d.staffID = ct.staffID AND ct.contractID = b.contractID AND b.clientID = '" & UserYa.ClientID & "';"
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
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
            jobID = reader("jobID").ToString()

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
        Dim a As String = "INSERT INTO job VALUES ('" & nextID & "', '" & find_driver() & "', '" & UserYa.ClientID & "', CURDATE(), CURTIME(), CURTIME(), '
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
        Jour.Dept = DepartureBox.SelectedItem.ToString()
        Jour.Dest = DestinationBox.SelectedItem.ToString()
        AAA.UserYa = UserYa
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
            'MessageBox.Show("yeyeeyyeye")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadComboBox(dept As String, dest As String)
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
            conn.Close()
            conn.Open()

            comm = New MySqlCommand("SELECT dAddress FROM distance GROUP BY dAddress", conn)
            reader = comm.ExecuteReader()
            While reader.Read()
                dAdd.Add(reader("dAddress").ToString())
            End While
            dAdd.Remove(dept)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DepartureBox.DataSource = pAdd
        DestinationBox.DataSource = dAdd

        'DepartureBox.SelectedItem = dept
        DestinationBox.SelectedIndex = 0

    End Sub

    Private Sub redisplay()
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
            conn.Close()
            conn.Open()

            comm = New MySqlCommand("SELECT dAddress FROM distance GROUP BY dAddress", conn)
            reader = comm.ExecuteReader()
            While reader.Read()
                dAdd.Add(reader("dAddress").ToString())
            End While
            dAdd.Remove(DepartureBox.SelectedItem)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'DepartureBox.DataSource = pAdd
        DestinationBox.DataSource = dAdd
    End Sub

    Private Sub DepartureBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartureBox.SelectedIndexChanged
        redisplay()
        'LoadComboBox(DepartureBox.SelectedItem.ToString(), "")
    End Sub

    Private Sub DestinationBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestinationBox.SelectedIndexChanged
        'LoadComboBox("", DestinationBox.SelectedItem.ToString())
    End Sub


    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click

        Dim MainS As MainStaff = New MainStaff()

        MainS.UserYa = UserYa
        MainS.Show()

    End Sub
End Class