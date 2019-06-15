
Partial Class AddOperator
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = False
        Dim firstName As String = TextBox1.Text
        Dim lastName As String = TextBox2.Text
        Dim contactNum As String = TextBox3.Text
        Dim remark As String = TextBox4.Text
        Dim email As String = TextBox5.Text


        If firstName.Length < 1 Or lastName.Length < 1 Or contactNum.Length < 1 Then
            Label2.Text = "Please Fill Up All Details"
            Label2.Visible = True
            Return
        End If

        Dim dbm As DataBaseManager = New DataBaseManager

        dbm.addCostumer(firstName, lastName, contactNum, email, remark)
        Response.Redirect("OperatorHomePage.aspx")
        Label2.Text = "Something Went Wrong, Try Again"
        Label2.Visible = True
    End Sub
End Class