Public Class frmInventory
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
   
    Private Sub NewStock()
        'ADD PARAMETERS
        access.AddParam("@StockID", lblStockID.Text)
        access.AddParam("@Item", txtItem.Text)
        access.AddParam("@Desc", txtDesc.Text)
        access.AddParam("@Qnty", txtQnty.Text)
        access.AddParam("@Price", txtSalesPrice.Text)
        access.AddParam("@ExpSales", lblTotal.Text)
        access.AddParam("@Cost", txtCost.Text)
        access.AddParam("@TotalCost", lblTotalCost.Text)


        access.ExecQuery("INSERT INTO STOCK (StockID, Stock_Item, Description, Quantity, Price, Total, [UNIT_COST], [TOTAL_COST])" & _
                         "VALUES (@stockID, @Item, @Desc, @Qnty, @Price, @ExpSales, @Cost, @TotalCost);")
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS!!!
        MsgBox("Stock added successfully")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '   CHECK IF TEXTBOXES ARE NOT EMPTY
        If txtItem.Text = "" Then
            MsgBox("Please Enter Item name", MsgBoxResult.Ok)
            txtItem.Focus()
            Exit Sub
        ElseIf txtDesc.Text = "" Then
            MsgBox("Please Enter item description", MsgBoxResult.Ok)
            txtDesc.Focus()
            Exit Sub
        ElseIf txtQnty.Text = "" Then
            MsgBox("Please Enter Quantity of item to be stocked", MsgBoxResult.Ok)
            txtQnty.Focus()
            Exit Sub
        ElseIf txtSalesPrice.Text = "" Then
            MsgBox("Please Enter Unit Price", MsgBoxResult.Ok)
            txtSalesPrice.Focus()
            Exit Sub
        Else
            NewStock()

            '   INSTATIATING A NEW FORM
            Dim frm As New frmInventory
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtSalesPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesPrice.KeyPress, txtCost.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtSalesPrice_LostFocus(sender As Object, e As EventArgs) Handles txtSalesPrice.LostFocus
        If txtQnty.Text = "" Then
            MsgBox("Please Enter Quantity of items to be stocked", MsgBoxStyle.OkOnly, MessageBoxIcon.Error)
            txtQnty.Focus()
        ElseIf txtSalesPrice.Text = "" Then
            Exit Sub
        Else
            lblTotal.Text = txtQnty.Text * txtSalesPrice.Text
            If lblTotalCost.Text = "" Then
                MsgBox("Enter Cost price")
                txtCost.Focus()
                btnAdd.Enabled = False
            Else
                btnAdd.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtQnty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQnty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCost_LostFocus(sender As Object, e As EventArgs) Handles txtCost.LostFocus
        If txtQnty.Text = "" Then
            MsgBox("Please Enter Quantity of items to be stocked", MsgBoxStyle.OkOnly, MessageBoxIcon.Error)
            txtQnty.Focus()
        ElseIf txtCost.Text = "" Then
            Exit Sub
        Else
            lblTotalCost.Text = txtQnty.Text * txtCost.Text
            If lblTotal.Text = "" Then
                MsgBox("Enter sales price")
                txtSalesPrice.Focus()
                btnAdd.Enabled = False
            Else
                btnAdd.Enabled = True
            End If

        End If
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM STOCK WHERE StockID = (SELECT MAX(NumID) FROM Staff_Profile)")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub


        '   DISPLAY LAST ROW NUMBER
        Dim Rr As DataRow = access.DBDT.Rows(CurrentRecord)
        lblStockID.Text = Rr("StockID") + 1

    End Sub
End Class