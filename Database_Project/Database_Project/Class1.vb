Public Class ClientYa
    Public ClientID As String
    Public Name As String
    Public Phone As String
    Public ClassYa As String
    Public Address As String
    Public ContractYa As Contract = New Contract()
    Public Type As String
End Class

Public Class Contract
    Public ContractID As String
    Public StaffID As String
    Public NumOfJob As Int32
    Public TotalMilage As Int32
End Class

Public Class Trip
    Public JobID As String
    Public Mileage As Int32
    Public Dept As String
    Public Dest As String
End Class