
Partial Class EditCar
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = False

        Dim carType As String = DropDownList1.SelectedItem.ToString()
        Dim carModel As String = TextBox3.Text
        Dim remark As String = TextBox4.Text

        If carModel.Length < 1 Then
            Label2.Text = "Please Enter Car Model"
            Label2.Visible = True
            Return
        End If
        Dim carId As Int32 = Int32.Parse(DropDownList2.SelectedItem.ToString())
        Dim dbm As DataBaseManager = New DataBaseManager
        dbm.updateCar(carId, carType, carModel, remark)
        Response.Redirect("AdminHomePage.aspx")

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        DropDownList2.Items.Clear()
        DropDownList2.Items.Add("CAR ID")
        Dim dbm As DataBaseManager = New DataBaseManager
        Dim carList As List(Of Int32) = dbm.getCarList()
        For Each temp As Int32 In carList
            DropDownList2.Items.Add(temp.ToString())
        Next


    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        Try
            TextBox3.Text = ""
            TextBox4.Text = ""


            Dim carId As Int32 = Int32.Parse(DropDownList2.SelectedItem.ToString())
            Dim dbm As DataBaseManager = New DataBaseManager
            Dim cardet As List(Of String) = dbm.getCarDetails(carId)
            TextBox3.Text = cardet(1)
            TextBox4.Text = cardet(2)
            Dim index As Integer = 0
            Dim sIndex As Integer = 0
            For Each temp As ListItem In DropDownList1.Items
                If temp.Text.Equals(cardet(0)) Then
                    sIndex = index
                End If
                index += 1
            Next
            DropDownList1.SelectedIndex = sIndex
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim carId As Int32 = Int32.Parse(DropDownList2.SelectedItem.ToString())
        Dim dbm As DataBaseManager = New DataBaseManager()
        dbm.removeCar(carId)
        Response.Redirect("AdminHomePage.aspx")
    End Sub
End Class