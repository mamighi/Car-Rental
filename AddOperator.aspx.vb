
Partial Class AddOperator
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = False
        Dim userName As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim fullName As String = TextBox3.Text
        Dim remark As String = TextBox4.Text

        If userName.Length < 1 Or password.Length < 1 Or fullName.Length < 1 Then
            Label2.Text = "Please Fill Up All Details"
            Label2.Visible = True
            Return
        End If

        Dim dbm As DataBaseManager = New DataBaseManager
        If dbm.checkUserName(userName) Then
            Label2.Text = "The User Already Exist"
            Label2.Visible = True
            Return
        End If
        If dbm.addUser(userName, password, fullName, remark) Then
            Response.Redirect("AdminHomePage.aspx")
        Else
            Label2.Text = "Something Went Wrong, Try Again"
            Label2.Visible = True
        End If
    End Sub
End Class