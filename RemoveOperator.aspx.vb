
Partial Class RemoveOperator
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

        
        Dim userName As String = DropDownList1.SelectedItem.ToString()
        Dim dbm As DataBaseManager = New DataBaseManager
        dbm.removeOpr(userName)
            Response.Redirect("AdminHomePage.aspx")
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        DropDownList1.Items.Clear()
        DropDownList1.Items.Add("USERNAME")
        Dim dbm As DataBaseManager = New DataBaseManager
        Dim oper As List(Of String) = dbm.getOpList()
        For Each temp As String In oper
            DropDownList1.Items.Add(temp)
        Next

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Try
            TextBox3.Text = ""
            TextBox4.Text = ""


            Dim userName As String = DropDownList1.SelectedItem.ToString()
            Dim dbm As DataBaseManager = New DataBaseManager
            Dim det As List(Of String) = dbm.getOprDet(userName)
            TextBox3.Text = det(0)
            TextBox4.Text = det(1)
        Catch ex As Exception

        End Try
    End Sub
End Class