Public Class frmStockSum
    Private access As New DBControl
    Private Sub frmStockSum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   QUERY
        access.ExecQuery("SELECT * FROM STOCK")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvStock.DataSource = access.DBDT
    End Sub
End Class