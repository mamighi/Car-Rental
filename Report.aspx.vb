
Partial Class Report
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim row As TableRow = New TableRow()
        row.Height = 25
        Dim cCustId As TableCell = New TableCell()
        cCustId.Text = "Customer ID"
        Dim cCarId As TableCell = New TableCell()
        cCarId.Text = "Car ID"
        Dim cODate As TableCell = New TableCell()
        cODate.Text = "Check-Out Date"
        Dim cIDate As TableCell = New TableCell()
        cIDate.Text = "Check-In Date"
        Dim cCost As TableCell = New TableCell()
        cCost.Text = "Cost"
        Dim cDeposit As TableCell = New TableCell()
        cDeposit.Text = "Deposit"
        row.Cells.Add(cCustId)
        row.Cells.Add(cCarId)
        row.Cells.Add(cODate)
        row.Cells.Add(cIDate)
        row.Cells.Add(cCost)
        row.Cells.Add(cDeposit)
        Table1.Rows.Add(row)
        Dim dbm As DataBaseManager = New DataBaseManager
        Dim det As List(Of List(Of String)) = dbm.loadTransaction()
        Dim count As Int32 = 0
        For Each temp As List(Of String) In det
            row = New TableRow()
            If (count Mod 2 = 0) Then
                row.BackColor = System.Drawing.Color.LightBlue
            Else
                row.BackColor = System.Drawing.Color.White
            End If
            count += 1

            cCustId = New TableCell()
            cCustId.Text = temp(0)
            cCarId = New TableCell()
            cCarId.Text = temp(1)
            cODate = New TableCell()
            cODate.Text = temp(2)
            cIDate = New TableCell()
            cIDate.Text = temp(3)
            cCost = New TableCell()
            cCost.Text = temp(4)
            cDeposit = New TableCell()
            cDeposit.Text = temp(5)
            row.Cells.Add(cCustId)
            row.Cells.Add(cCarId)
            row.Cells.Add(cODate)
            row.Cells.Add(cIDate)
            row.Cells.Add(cCost)
            row.Cells.Add(cDeposit)
            Table1.Rows.Add(row)
        Next
    End Sub
End Class
