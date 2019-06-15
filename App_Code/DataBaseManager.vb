Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class DataBaseManager
    Dim SQLConn As SqlConnection = New SqlConnection("Data Source=MOHAMMAD\MOHAMMAD;Initial Catalog=CarRental;Integrated Security=True;")

    Public Function login(ByVal us As String, ByVal pass As String) As Int32
        Dim cmd = New SqlCommand("SELECT [UserType] FROM [USER] WHERE [UserID]='" + us + "' AND [UserPassword]='" + pass + "'")
        Dim retVal As Int32 = 0
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            If result = "admin" Then
                retVal = 1
            Else
                retVal = 2
            End If
        End If
        SQLConn.Close()
        Return retVal
    End Function
    Public Function checkUserName(ByVal us As String) As Boolean
        Dim cmd = New SqlCommand("SELECT [UserType] FROM [USER] WHERE [UserID]='" + us + "'")
        Dim retVal As Boolean = False
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            retVal = True
        End If
        SQLConn.Close()
        Return retVal
    End Function
    Public Function addUser(ByVal us As String, ByVal pas As String, ByVal fn As String, ByVal re As String) As Boolean
        Dim uty As String = "oper"
        Dim cmd = New SqlCommand("INSERT INTO [USER] (UserID,UserPassword,UserType,UserFullName,Remark) VALUES('" + us + "','" + pas + "','" + uty + "','" + fn + "','" + re + "')")
        cmd.Connection = SQLConn
        Try
            SQLConn.Open()
            cmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function getOpList() As List(Of String)
        Dim retVal As List(Of String) = New List(Of String)
        Dim cmd = New SqlCommand("SELECT UserID FROM [USER] WHERE UserType='oper'")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            retVal.Add(reader.GetString(0))
        End While
        SQLConn.Close()
        Return retVal
    End Function
    Public Function getOprDet(ByVal usr As String) As List(Of String)
        Dim retVal As List(Of String) = New List(Of String)
        Dim cmd = New SqlCommand("SELECT * FROM [USER] WHERE UserID='" + usr + "'")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            retVal.Add(reader.GetString(3))
            retVal.Add(reader.GetString(4))
        End If
        SQLConn.Close()
        Return retVal
    End Function
    Public Sub removeOpr(ByVal usr As String)
        Dim cmd = New SqlCommand("DELETE FROM [USER] WHERE UserID='" + usr + "'")
        cmd.Connection = SQLConn
        SQLConn.Open()
        cmd.ExecuteNonQuery()
        SQLConn.Close()
    End Sub
    Public Sub addCar(ByVal carType As String, ByVal carModel As String, remark As String)
        Dim stat As String = "Available"
        Dim cmd = New SqlCommand("INSERT INTO [Car] (CarStatus,CarType,CarModel,Remark) VALUES('" + stat + "','" + carType + "','" + carModel + "','" + remark + "')")
        cmd.Connection = SQLConn
        Try
            SQLConn.Open()
            cmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Function getCarList() As List(Of Int32)
        Dim retVal As List(Of Int32) = New List(Of Integer)
        Dim cmd = New SqlCommand("SELECT CarID FROM [Car]")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            retVal.Add(reader.GetInt32(0))
        End While
        SQLConn.Close()
        Return retVal
    End Function
    Public Function getCarDetails(ByVal carId As Int32) As List(Of String)
        Dim retVal As List(Of String) = New List(Of String)
        Dim cmd = New SqlCommand("SELECT * FROM [Car] WHERE CarID='" + carId.ToString() + "'")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            retVal.Add(reader.GetString(2))
            retVal.Add(reader.GetString(3))
            retVal.Add(reader.GetString(4))
        End if
            SQLConn.Close()
            Return retVal
    End Function
    Public Sub removeCar(ByVal carId As Int32)
        Dim cmd = New SqlCommand("DELETE FROM [Car] WHERE CarID='" + carId.ToString() + "'")
        cmd.Connection = SQLConn
        SQLConn.Open()
        cmd.ExecuteNonQuery()
        SQLConn.Close()
    End Sub
    Public Sub updateCar(ByVal carId As Int32, ByVal carType As String, ByVal carModel As String, ByVal remark As String)
        Dim cmd = New SqlCommand("UPDATE [Car] SET CarType='" + carType + "',CarModel='" + carModel + "',Remark='" + remark + "' WHERE CarID='" + carId + "' ")
        cmd.Connection = SQLConn
        SQLConn.Open()
        cmd.ExecuteNonQuery()
        SQLConn.Close()
    End Sub
    Public Sub addCostumer(ByVal fn As String, ByVal ln As String, ByVal con As String, ByVal email As String, ByVal remark As String)
        Dim cmd = New SqlCommand("INSERT INTO [Customer] (CustFirstName,CustLastName,CustContNumber,CustEmailAdd,CustRemark) VALUES('" + fn + "','" + ln + "','" + con + "','" + email + "','" + remark + "')")
        cmd.Connection = SQLConn
        Try
            SQLConn.Open()
            cmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Function getCostList() As List(Of Int32)
        Dim retVal As List(Of Int32) = New List(Of Integer)
        Dim cmd = New SqlCommand("SELECT CustomerID FROM [Customer]")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            retVal.Add(reader.GetInt32(0))
        End While
        SQLConn.Close()
        Return retVal
    End Function
    Public Sub editCostumer(ByVal id As Int32, ByVal fn As String, ByVal ln As String, ByVal con As String, ByVal email As String, ByVal remark As String)
        Dim cmd = New SqlCommand("UPDATE [Customer] SET CustFirstName='" + fn + "',CustLastName='" + ln + "',CustContNumber='" + con + "',CustEmailAdd ='" + email + "',CustRemark='" + remark + "' WHERE CustomerID='" + id.ToString + "' ")
        cmd.Connection = SQLConn
        SQLConn.Open()
        cmd.ExecuteNonQuery()
        SQLConn.Close()
    End Sub
    Public Function getCustdet(ByVal id As Int32) As List(Of String)
        Dim retVal As List(Of String) = New List(Of String)
        Dim cmd = New SqlCommand("SELECT * FROM [Customer] WHERE CustomerID='" + id.ToString() + "'")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            retVal.Add(reader.GetString(1))
            retVal.Add(reader.GetString(2))
            retVal.Add(reader.GetString(3))
            retVal.Add(reader.GetString(4))
            retVal.Add(reader.GetString(5))
        End If
        SQLConn.Close()
        Return retVal

    End Function
    Public Function getAvailableCarList() As List(Of Int32)
        Dim retVal As List(Of Int32) = New List(Of Int32)
        Dim unAv As List(Of Int32) = New List(Of Int32)
        Dim carList As List(Of Int32) = getCarList()
        For Each temp As Int32 In carList
            Dim cmd = New SqlCommand("SELECT * FROM [Transaction] WHERE CarID='" + temp.ToString() + "'")
            cmd.Connection = SQLConn
            SQLConn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                Dim checkIn As DateTime = reader.GetDateTime(3)
                Dim checkOut As DateTime = reader.GetDateTime(2)
                Dim today As DateTime = DateTime.Now
                If checkOut <= today And checkIn >= today Then
                    unAv.Add(temp)
                End If
            End While
            SQLConn.Close()
        Next
        For Each temp As Int32 In carList
            If unAv.Contains(temp) = False Then
                retVal.Add(temp)
            End If
        Next
        Return retVal
    End Function
    Public Sub addTransaction(ByVal custID As Int32, ByVal carID As Int32, ByVal iDate As DateTime, ByVal oDate As DateTime, ByVal cost As Double, ByVal deposit As Double, ByVal remark As String)
        Dim cmd = New SqlCommand("INSERT INTO [Transaction] (CustID,CarID,CheckOutDate,CheckInDate,Cost,Deposit,Remark) VALUES('" + custID.ToString + "','" + carID.ToString + "','" + oDate.ToString + "','" + iDate.ToString + "','" + cost.ToString + "','" + deposit.ToString + "','" + remark + "')")
        cmd.Connection = SQLConn
        Try
            SQLConn.Open()
            cmd.ExecuteNonQuery()
            SQLConn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Function loadTransaction() As List(Of List(Of String))
        Dim retVal As List(Of List(Of String)) = New List(Of List(Of String))
        Dim cmd = New SqlCommand("SELECT * FROM [Transaction] ")
        cmd.Connection = SQLConn
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            Dim temp As List(Of String) = New List(Of String)
            temp.Add(reader.GetInt32(0).ToString)
            temp.Add(reader.GetInt32(1).ToString)
            temp.Add(reader.GetDateTime(2).ToString)
            temp.Add(reader.GetDateTime(3).ToString)
            temp.Add(reader.GetSqlDouble(4).ToString)
            temp.Add(reader.GetSqlDouble(5).ToString)
            temp.Add(reader.GetString(7).ToString)
            retVal.Add(temp)
        End While
        SQLConn.Close()
        Return retVal
    End Function
End Class
