
Partial Class CarRent
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack Then
            Return
        End If
        DropDownList1.Items.Clear()
        Dim dbm As DataBaseManager = New DataBaseManager
        Dim avCar As List(Of Int32) = dbm.getAvailableCarList()
        DropDownList1.Items.Add("Car ID")
        For Each temp As Int32 In avCar
            DropDownList1.Items.Add(temp.ToString())
        Next

        DropDownList2.Items.Clear()
        DropDownList2.Items.Add("Customer ID")
        Dim custList As List(Of Int32) = dbm.getCostList()
        For Each temp As Int32 In custList
            DropDownList2.Items.Add(temp.ToString())
        Next
        TextBox1.Text = DateTime.Now.ToString()
        Dim dur As Int32 = Int32.Parse(DropDownList3.SelectedItem.ToString())
        Dim d As DateTime = DateTime.Now
        d = d.AddDays(dur)
        TextBox2.Text = d.ToString()
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Try
            Dim dbm As DataBaseManager = New DataBaseManager
            Dim carDet As List(Of String) = dbm.getCarDetails(Int32.Parse(DropDownList1.SelectedItem.ToString()))
            Label2.Text = carDet(1) + " " + carDet(2)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        Try
            Dim dbm As DataBaseManager = New DataBaseManager
            Dim custDet As List(Of String) = dbm.getCustdet(Int32.Parse(DropDownList2.SelectedItem.ToString()))
            Label3.Text = custDet(0) + " " + custDet(1)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        Dim dur As Int32 = Int32.Parse(DropDownList3.SelectedItem.ToString())
        Dim d As DateTime = DateTime.Now
        d = d.AddDays(dur)
        TextBox2.Text = d.ToString()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Visible = False
        If DropDownList1.SelectedItem.ToString.Equals("Car ID") Then
            Label5.Visible = True
            Label5.Text = "Choose Car ID"
            Return
        End If
        If DropDownList2.SelectedItem.ToString.Equals("Customer ID") Then
            Label5.Visible = True
            Label5.Text = "Choose Customer ID"
            Return
        End If

        Dim carID As Int32 = Int32.Parse(DropDownList1.SelectedItem.ToString)
        Dim custID As Int32 = Int32.Parse(DropDownList2.SelectedItem.ToString)
        Dim oDate As DateTime = DateTime.Now
        Dim dur As Int32 = Int32.Parse(DropDownList3.SelectedItem.ToString())
        Dim iDate As DateTime = DateTime.Now
        Try
            iDate = iDate.AddDays(dur)
            Dim cost As Double = Double.Parse(TextBox3.Text)
            Dim deposit As Double = Double.Parse(TextBox4.Text)
            Dim remark As String = TextBox5.Text
            Dim dbm As DataBaseManager = New DataBaseManager
            dbm.addTransaction(custID, carID, iDate, oDate, cost, deposit, remark)
            Response.Redirect("OperatorHomePage.aspx")
        Catch ex As Exception
            Label5.Visible = True
            Label5.Text = "Insert All Requierd Data"
        End Try

    End Sub
End Class
