Public Class frmDailySales
    Private access As New DBControl
    Private Sub frmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        access.AddParam("@Today", Date.Now.ToString("dd-MM-yyyy"))

        'QUERY
        access.ExecQuery("SELECT * FROM [Daily Sales] WHERE [SALES_DATE] = @Today")

        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        dgvDailySales.DataSource = access.DBDT
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SalesDate As String
        SalesDate = Date.Parse(txtFrom.Text).ToString("dd-MM-yyyy")

        access.AddParam("@Date", SalesDate)
        access.ExecQuery("select * from [Daily Sales] Where [SALES_DATE] = @Date")

        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        dgvDailySales.DataSource = access.DBDT

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click
        If dgvDailySales.RowCount > 1 Then
            Dim amount As Integer = 0
            For totalsum As Integer = 0 To dgvDailySales.RowCount - 1
                amount += Convert.ToInt32(dgvDailySales.Rows(totalsum).Cells(4).Value)
            Next
            lblSum.Text = amount
        End If


    End Sub

End Class