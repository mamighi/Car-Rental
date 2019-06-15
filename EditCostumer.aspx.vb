
Partial Class EditCostumer
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = False
        Dim firstName As String = TextBox1.Text
        Dim lastName As String = TextBox2.Text
        Dim contactNum As String = TextBox3.Text
        Dim remark As String = TextBox4.Text
        Dim email As String = TextBox5.Text
        Dim id As Int32 = Int32.Parse(DropDownList1.SelectedItem.ToString())

        If firstName.Length < 1 Or lastName.Length < 1 Or contactNum.Length < 1 Then
            Label2.Text = "Please Fill Up All Details"
            Label2.Visible = True
            Return
        End If

        Dim dbm As DataBaseManager = New DataBaseManager

        dbm.editCostumer(id, firstName, lastName, contactNum, email, remark)
        Response.Redirect("OperatorHomePage.aspx")


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack Then
            Return
        End If
        DropDownList1.Items.Clear()
        DropDownList1.Items.Add("Customer ID")
        Dim dbm As DataBaseManager = New DataBaseManager
        Dim carList As List(Of Int32) = dbm.getCostList()
        For Each temp As Int32 In carList
            DropDownList1.Items.Add(temp.ToString())
        Next
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Try

       
        Dim id As Int32 = Int32.Parse(DropDownList1.SelectedItem.ToString())
        Dim dbm As DataBaseManager = New DataBaseManager()
        Dim det As List(Of String) = dbm.getCustdet(id)
        TextBox1.Text = det(0)
        TextBox2.Text = det(1)
        TextBox3.Text = det(2)
        TextBox5.Text = det(3)
            TextBox4.Text = det(4)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class