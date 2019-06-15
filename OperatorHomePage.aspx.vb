
Partial Class OperatorHomePage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim us As String = Session("UN").ToString()
        Label2.Text = "Welcome " + us
    End Sub
End Class
