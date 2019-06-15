
Partial Class AddCar
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

        Dim dbm As DataBaseManager = New DataBaseManager
        dbm.addCar(carType, carModel, remark)
        Response.Redirect("AdminHomePage.aspx")
       
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class