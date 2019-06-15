
Partial Class _Default
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = False
        Dim userName As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim dbm As DataBaseManager = New DataBaseManager
        Dim result As Int16 = 0
        result = dbm.login(userName, password)

        If result = 0 Then
            Label2.Visible = True
        ElseIf result = 1 Then
            Session("UN") = userName
            Session("TY") = "AD"
            Response.Redirect("AdminHomePage.aspx")
        ElseIf result = 2 Then
            Session("UN") = userName
            Session("TY") = "OP"
            Response.Redirect("OperatorHomePage.aspx")
        End If

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim ut As String = Session("TY").ToString()
            If ut.Equals("AD") Then
                Response.Redirect("AdminHomePage.aspx")
            ElseIf ut.Equals("OP") Then
                Response.Redirect("OperatorHomePage.aspx")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class