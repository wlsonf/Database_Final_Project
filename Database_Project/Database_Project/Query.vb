Imports MySql.Data.MySqlClient


Public Class Query
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Login_Form = New Login_Form
        Login_Form.Show()
        Me.Visible = False
    End Sub

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
        BoxQuery.SelectedIndex = 0
        'dgvTable.DataSource = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxQuery.SelectedIndexChanged
        Dim query As String = ""


        Select Case BoxQuery.SelectedIndex()
            Case 0
                Return
            Case 1
                query = "SELECT o.name AS Office_Name, s.name AS Name, s.phone AS Phone FROM manager m  
                        JOIN staff s ON s.staffID = m.staffID
                        JOIN office o ON o.officeID = m.officeID;"
            Case 2
                query = "SELECT ex.name AS Name FROM external ex
                        JOIN driver d ON d.extID = ex.extID
                        JOIN manager m ON m.staffID = d.staffID
                        JOIN office o ON o.officeID = m.officeID
                        WHERE o.name = 'Glasgow' AND ex.gender = 'female';"
            Case 3
                query = "SELECT o.name AS Name, (COUNT(a.staffID) + COUNT(m.staffID)) AS Total_Staff 
                        FROM office o, admin a, manager m
                        WHERE a.officeID = o.officeID AND m.officeID = o.officeID
                        GROUP BY o.name;"
            Case 4
                query = "SELECT plateNumber AS Plate_Number, type AS Type, color AS Color, extID AS OwnerID FROM taxi 
                        WHERE extID IN(SELECT extID FROM owner 
                                       WHERE staffID IN(SELECT staffID FROM manager 
                                                        WHERE officeID IN(SELECT officeID FROM office 
                                                                           WHERE name = 'Glasgow')))"
            Case 5
                query = "SELECT COUNT(platenumber) AS Total_Taxi FROM taxi;"
            Case 6
                query = "SELECT d.plateNumber AS Plate_Number, COUNT(extID) AS Drivers_Allocated 
                        FROM driver d GROUP BY plateNumber;"
            Case 7
                query = "SELECT ex.name AS Owner_Name, COUNT(t.plateNumber) AS Number_of_Taxi 
                        FROM external ex, taxi t WHERE ex.extID = t.extID 
                        GROUP BY ex.name HAVING COUNT(t.plateNumber)>1"
            Case 8
                query = "SELECT c.name AS Client_Name, c.address AS Client_Address FROM client c
                        JOIN business b ON b.clientID = c.clientID
                        JOIN contract con ON con.contractID = b.contractID
                        JOIN manager m ON m.staffID = con.staffID
                        JOIN office of ON of.officeID = m.officeID
                        WHERE of.name = 'Glasgow';"
            Case 9
                query = "SELECT con.contractID AS ContractID, con.staffID AS ManagerID, con.numberOfJob AS Number_of_Jobs, con.totalMilage AS Total_Mileage
                        FROM contract con
                        JOIN manager m ON m.staffID = con.staffID
                        JOIN office o ON o.officeID = m.officeID
                        WHERE o.name = 'Glasgow'"
            Case 10
                query = "SELECT o.city AS City, COUNT(p.clientID) AS Total_Private_Clients 
                        FROM office o, private p, manager m 
                        WHERE p.staffID = m.staffID AND m.officeID = o.officeID
                        GROUP BY o.name;"
            Case 11
                query = "SELECT ex.name AS Driver_Name, j.jobID AS JobID, j.extID AS DriverID, j.clientID AS ClientID, j.date AS Date, j.pTime AS Pick_up_Time, j.dTime AS Drop_off_Time, j.pAddress AS Pick_up_Address, j.dAddress AS Drop_off_Address 
                        FROM external ex, job j 
                        WHERE date = '2017-06-03' AND ex.extID = j.extID AND ex.extID = 'ex33';"
            Case 12
                query = "SELECT ex.name AS Driver_Name
                        FROM external ex, driver d 
                        WHERE ex.extID = d.extID AND ex.age > 55;"
            Case 13
                query = "SELECT c.name AS Client_Name, COUNT(j.jobID) AS Number_of_Jobs 
                        FROM client c, job j 
                        JOIN private p ON p.clientId = j.clientID 
                        WHERE p.clientID = c.clientID 
                        AND (j.date BETWEEN '2016-10-31' AND '2016-12-01') GROUP BY c.name;"
            Case 14
                query = "SELECT c.name AS Client_Name, c.address  AS Client_Address
                        FROM client c
                        JOIN private p ON p.clientID = c.clientID
                        JOIN job j ON j.clientID = p.clientID
                        HAVING COUNT(j.jobID) > 3;"
            Case 15
                query = "SELECT AVG(mileage) AS Average_Milage FROM receipt;"
            Case 16
                query = "SELECT d.plateNumber AS Plate_Number, COUNT(j.jobID) AS Total_Jobs
                        FROM driver d, job j
                        WHERE d.extID = j.extID
                        GROUP BY d.plateNumber;"
            Case 17
                query = "SELECT ext.name AS Driver_Name, COUNT(j.jobID) AS totalJob
                        FROM external ext, job j, driver d
                        WHERE d.extID = ext.extID AND d.extID = j.extID
                        GROUP BY ext.name;"
            Case 18
                query = "SELECT t.plateNumber, SUM(r.charge) AS TotalCharge 
                        FROM taxi t, receipt r 
                        JOIN job j ON j.jobID = r.jobID 
                        JOIN driver d ON d.extID = j.extID 
                        WHERE D.plateNumber = T.plateNumber GROUP BY t.plateNumber;"
            Case 19
                query = "SELECT numberOfJob, totalMilage FROM contract;"
        End Select
        display(query)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
