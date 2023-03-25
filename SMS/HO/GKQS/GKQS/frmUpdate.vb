Public Class frmUpdate
    Private access As New DBControl
    Private CurrentRecord As Integer = 0

    'ERROR CHECKING AND REPORTING
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub GetStock()
        ' QUERY STAFF TABLE TO FILL DATA TABLE
        If cbxStockItem.Text = "" Then
            MessageBox.Show("SELECT ITEM TO BE SOLD", "STOCK SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbxStockItem.Focus()
        Else
            access.AddParam("@SearchID", cbxStockItem.Text)
            access.ExecQuery("select * FROM STOCK WHERE Item= @SearchID")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
            GetRecord()
        End If

    End Sub
    Private Sub GetRecord()
        'FAIL IF NO RECORDS FOUND
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'RETURN STOCK RECORDS
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblStockID.Text = r("StockID").ToString
        txtItem.Text = r("Stock_Item").ToString
        txtDesc.Text = r("Description").ToString
        'txtPrice.Text = r("Price").ToString
        'txtQnty.Text = r("Quantity").ToString
        lblQnty.Text = r("Quantity").ToString
        lblPrevTotal.Text = r("Total").ToString
        lblPrevCost.Text = r("TOTAL COST")

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '   SEARCH
        GroupBox1.Visible = True
        GetStock()
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   QUERY
        access.ExecQuery("SELECT * FROM STOCK")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        For Each R As DataRow In access.DBDT.Rows
            cbxStockItem.Items.Add(R("Stock_Item"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStockItem.SelectedIndex = 0
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtPrice_LostFocus(sender As Object, e As EventArgs) Handles txtPrice.LostFocus
        If txtPrice.Text = "" Then
            Exit Sub
        Else
            Dim a, b As Integer
            a = txtQnty.Text : b = txtPrice.Text
            lblTotal.Text = a * b
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lblCost.Text = "" Or lblTotal.Text = "" Then
            btnUpdate.Enabled = False
        Else
            btnUpdate.Enabled = True
            '   DECLARE VARIABLES
            Dim OLDQNTY, PREVQNTY, NEWQNTY, OLDSALES, PREVSALES, NEWSALES, OLDCOST, PREVCOST, NEWCOST As Integer
            PREVSALES = lblTotal.Text
            OLDSALES = lblPrevTotal.Text
            PREVCOST = lblCost.Text
            OLDCOST = lblPrevCost.Text
            PREVQNTY = lblQnty.Text
            OLDQNTY = txtQnty.Text
            NEWSALES = PREVSALES + OLDSALES
            NEWCOST = PREVCOST + OLDCOST
            NEWQNTY = PREVQNTY + OLDQNTY
            '   DECLARE PARAMETERS AGAINST SQL INJECTION

            access.AddParam("@Item", txtItem.Text)
            access.AddParam("@Desc", txtDesc.Text)
            access.AddParam("@Qnty", NEWQNTY)
            access.AddParam("@Price", txtPrice.Text)
            access.AddParam("@Total", NEWSALES)
            access.AddParam("@Cost", txtCost.Text)
            access.AddParam("@TotalCost", NEWCOST)
            access.AddParam("@StockID", lblStockID.Text)

            '   QUERY
            access.ExecQuery("UPDATE STOCK SET [Stock_Item] = @Item, [Description]= @Desc, [Quantity]= @Qnty, Price= @Price, [Total]= @Total, [UNIT_COST] = @Cost, [TOTAL_COST] = @TotalCost WHERE StockID= @StockID")


            '   REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub


            '   SUUCESS
            MsgBox("UPDATE SUCESSFUL")
            '   INSTANTIATE A NEW FORM
            ' Dim FRM As New frmUpdate
            ' Me.Close()
            'FRM.Show()
            Me.Refresh()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

    End Sub

    Private Sub txtQnty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQnty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCost_LostFocus(sender As Object, e As EventArgs) Handles txtCost.LostFocus
        If txtCost.Text = "" Then
            Exit Sub
        Else
            lblCost.Text = txtQnty.Text * txtCost.Text
        End If

    End Sub

End Class