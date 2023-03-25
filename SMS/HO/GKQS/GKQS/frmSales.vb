Public Class frmSales
    Private access As New DBControl
    Private CurrentRecord As Integer = 0

    'ERROR CHECKING AND REPORTING
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(access.Exception) Then
            If Report = True Then MsgBox(access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub PrintReciept()
        Dim p As New PrinterClass(Application.StartupPath)
        With p
            'LOGO
            .RTL = False
            .PrintLogo()

            'PRINT TITLE
            .FeedPaper(2)
            .AlignCentre()
            .BigFont()
            .Bold = True
            .WriteLine("SALES RECIEPT")

            'PRINT DATE
            .GoToSixth(1)
            '.WriteLine("DATE:")
            .SmallFont()
            .WriteChars("DATE: " & Date.Now.ToString("dd-MM-yyyy"))
            .FeedPaper(2)

            'PRINT CASHIER
            .AlignRight()
            .GoToSixth(1)
            .SmallFont()
            .WriteChars("CASHIER: " & lblCashier.Text)
            '.WriteLine(lblCashier.Text)
            .FeedPaper(2)

            'PRINT HEADER
            .GoToSixth(1)
            .WriteChars("#")
            .GoToSixth(2)
            .WriteChars("ITEM")
            .GoToSixth(4)
            .WriteChars("QTY")
            .GoToSixth(5)
            .WriteChars("AMT")
            .WriteLine("")
            .DrawLine()
            .FeedPaper(1)

            'PRINTING ITEMS
            .NormalFont()
            .GoToSixth(1)
            .WriteChars(1)
            .GoToSixth(2)
            .WriteChars(cbxStockItem.Text)
            .GoToSixth(4)
            .WriteChars(cbxQnty.Text)
            .GoToSixth(5)
            .WriteChars(cbxQnty.Text * lblPriceSales.Text)
            .WriteLine("")
            If grp2.Visible = True Then
                'PRINTING ITEMS
                .NormalFont()
                .GoToSixth(1)
                .WriteChars(2)
                .GoToSixth(2)
                .WriteChars(cbxStockItem2.Text)
                .GoToSixth(4)
                .WriteChars(cbxQnty2.Text)
                .GoToSixth(5)
                .WriteChars(cbxQnty2.Text * lblPriceSales2.Text)
                .WriteLine("")
            End If
            If grp3.Visible = True Then
                'PRINTING ITEMS
                .NormalFont()
                .GoToSixth(1)
                .WriteChars(3)
                .GoToSixth(2)
                .WriteChars(cbxStockItem3.Text)
                .GoToSixth(4)
                .WriteChars(cbxQnty3.Text)
                .GoToSixth(5)
                .WriteChars(cbxQnty3.Text * lblPriceSales3.Text)
                .WriteLine("")
            End If

            '   PRINTING TOTALS
            .NormalFont()
            .DrawLine()
            .GoToSixth(1)
            .UnderlineOff()
            .GoToSixth(5)
            .WriteChars(lblSalesTotal.Text & "NGN")
            .CutPaper()
            .EndDoc()
        End With

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Static intCurrentChar As Int32

        Dim font As New Font("Verdana", 8)

        Dim PrintAreaHeight, PrintAreaWidth, marginLeft, marginTop As Int32

        With PrintDocument1.DefaultPageSettings

            PrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom

            PrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right

            marginLeft = .Margins.Left

            marginTop = .Margins.Top

        End With

        Dim intLineCount As Int32 = CInt(PrintAreaHeight / font.Height)

        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, PrintAreaWidth, PrintAreaHeight)

        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)

        Dim intLinesFilled, intCharsFitted As Int32

        e.Graphics.MeasureString(Mid(lstItem.Text, intCurrentChar + 1), font, New SizeF(PrintAreaWidth, PrintAreaHeight), fmt, intCharsFitted, intLinesFilled)

        e.Graphics.DrawString(Mid(lstItem.Text, intCurrentChar + 1), font, Brushes.Black, rectPrintingArea, fmt)

        intCurrentChar += intCharsFitted

    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCashier.Text = frmMain.lblCashier.Text
        Dim Today As String
        Today = Date.Now.ToString("dd-MMM-yy")
        lblDate.Text = Today
        '   QUERY
        access.ExecQuery("SELECT * FROM STOCK")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        For Each R As DataRow In access.DBDT.Rows
            cbxStockItem.Items.Add(R("Stock_Item"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStockItem.SelectedIndex = 0


    End Sub

    Private Sub btnAddSales_Click(sender As Object, e As EventArgs) Handles btnAddSales.Click
        Dim qnty, items As Integer
        If cbxQnty.Text = "" Then
            MessageBox.Show("SELECT QUANTITY TO BE SOLD", "SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbxQnty.Focus()
        Else
            qnty = cbxQnty.Text : items = lblItemsInStock.Text
            If qnty > items Then
                MsgBox("LOW STOCK")
                Exit Sub
            Else
                '   SOLVE FOR THE COST OF ITEMS BOUGHT
                Dim x, a, b As Integer
                b = CInt(lblPriceSales.Text)
                a = cbxQnty.Text
                x = a * b

                '   ADD ITEMS TO LIST BOX
                '   UPDATE QUANTITY IN STOCK
                lstItem.Items.Add(cbxStockItem.Text & "                          " & cbxQnty.Text & "               " & x)
                lblItemsInStock.Text = lblItemsInStock.Text - cbxQnty.Text
                lblSalesTotal.Text = lblSalesTotal.Text + x
                lblAmtSold.Text = lblAmtSold.Text + x
                Dim SELL1, SELL2 As Integer
                SELL1 = lblsold.Text : SELL2 = cbxQnty.Text
                lblsold.Text = SELL1 + SELL2
                cbxStockItem.Enabled = False

                '   cbxQnty.Text = ""
                btnSales.Enabled = False
                btnAddSales.Enabled = False
                btnSavePrint.Enabled = True
            End If

        End If


    End Sub
    Private Sub GetRecord()
        'FAIL IF NO RECORDS FOUND
        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'RETURN STOCK RECORDS
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblPriceSales.Text = r("Price")
        lblItemsInStock.Text = r("Quantity")
        lblID.Text = r("StockID")
        lblsold.Text = r("NO SOLD")

        lblAmtSold.Text = r("AMOUNT SOLD")

    End Sub
    Private Sub GetStock()
        ' QUERY STAFF TABLE TO FILL DATA TABLE
        If cbxStockItem.Text = "" Then
            MessageBox.Show("NO ITEM FOUND", "STOCK SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            access.AddParam("@SearchID", cbxStockItem.Text)
            access.ExecQuery("select * FROM STOCK WHERE Stock_Item= @SearchID")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
            GetRecord()
        End If

    End Sub

    Private Sub lblItemsInStock_TextChanged(sender As Object, e As EventArgs) Handles lblItemsInStock.TextChanged, lblItemsInStock2.TextChanged
        cbxQnty.Items.Clear()
        Dim a, x As Integer
        x = lblItemsInStock.Text
        For a = 1 To x
            cbxQnty.Items.Add(a)
        Next a
    End Sub


    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        MessageBox.Show("Are you sure you want to Print?", "SALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then
            PrintReciept()
            'PrintDocument1.Print()
            access.AddParam("@ITEM", cbxStockItem.Text)
            access.AddParam("@QNTY", cbxQnty.Text)
            access.AddParam("@PRICE", lblPriceSales.Text)
            access.AddParam("@COST", cbxQnty.Text * lblPriceSales.Text)
            access.AddParam("@CASHIER", lblCashier.Text)
            access.AddParam("@TODAY", Date.Now.ToString("dd-MMM-yy"))

            'QUERY
            access.ExecQuery("INSERT INTO [DAILY SALES] (Stock_ITEM, QUANTITY, PRICE, COST, CASHIER, [SALES_DATE])" & _
                            "VALUES (@ITEM, @QNTY, @PRICE, @COST, @CASHIER, @TODAY)")
            '   REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

            If grp2.Visible = True Then
                access.AddParam("@ITEM", cbxStockItem2.Text)
                access.AddParam("@QNTY", cbxQnty2.Text)
                access.AddParam("@PRICE", lblPriceSales2.Text)
                access.AddParam("@COST", cbxQnty2.Text * lblPriceSales2.Text)
                access.AddParam("@CASHIER", lblCashier.Text)
                access.AddParam("@TODAY", Date.Now.ToString("dd-MMM-yy"))

                'QUERY
                access.ExecQuery("INSERT INTO [DAILY SALES] (Stock_ITEM, QUANTITY, PRICE, COST, CASHIER, [SALES DATE])" & _
                                "VALUES (@ITEM, @QNTY, @PRICE, @COST, @CASHIER, @TODAY)")
                '   REPORT & ABORT ON ERRORS
                If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            End If
            If grp3.Visible = True Then
                access.AddParam("@ITEM", cbxStockItem3.Text)
                access.AddParam("@QNTY", cbxQnty3.Text)
                access.AddParam("@PRICE", lblPriceSales3.Text)
                access.AddParam("@COST", cbxQnty3.Text * lblPriceSales3.Text)
                access.AddParam("@CASHIER", lblCashier.Text)
                access.AddParam("@TODAY", Date.Now.ToString("dd-MMM-yy"))

                'QUERY
                access.ExecQuery("INSERT INTO [DAILY SALES] (Stock_ITEM, QUANTITY, PRICE, COST, CASHIER, [SALES DATE])" & _
                                "VALUES (@ITEM, @QNTY, @PRICE, @COST, @CASHIER, @TODAY)")
                '   REPORT & ABORT ON ERRORS
                If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            End If

            access.AddParam("@Qnty", lblItemsInStock.Text)
            access.AddParam("@Sold", lblsold.Text)
            access.AddParam("@AmntSold", lblAmtSold.Text)
            access.AddParam("@ID", lblID.Text)
            access.ExecQuery("UPDATE STOCK SET Quantity = @Qnty, [NO_SOLD] = @Sold, [AMOUNT_SOLD] = @AmntSold WHERE StockID = @ID")

            access.AddParam("@SECQnty", lblItemsInStock2.Text)
            access.AddParam("@SECSold", lblSold2.Text)
            access.AddParam("@SECAmntSold", lblAmntSold2.Text)
            access.AddParam("@SECID", lblID2.Text)
            If grp2.Visible = True Then
                access.ExecQuery("UPDATE STOCK SET Quantity = @SECQnty, [NO_SOLD] = @SECSold, [AMOUNT_SOLD] = @SECAmntSold WHERE StockID = @SECID")
            End If
            access.AddParam("@THIRDQnty", lblItemsInStock3.Text)
            access.AddParam("@THIRDSold", lblSold2.Text)
            access.AddParam("@THIRDAmntSold", lblAmntSold2.Text)
            access.AddParam("@THIRDID", lblID3.Text)
            If grp3.Visible = True Then
                access.ExecQuery("UPDATE STOCK SET Quantity = @THIRDQnty, [NO_SOLD] = @THIRDSold, [AMOUNT_SOLD] = @THIRDAmntSold WHERE StockID = @THIRDID")
            End If
            '   REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            'SUCCESS
            MessageBox.Show("SAVED!", "INVENTORY", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub
    Private Sub cbxStockItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStockItem.SelectedIndexChanged
        GetStock()
    End Sub

    Private Sub picAdd_Click(sender As Object, e As EventArgs) Handles picAdd.Click
        grp2.Visible = True
        picAdd2.Visible = True

        '   QUERY
        access.ExecQuery("SELECT * FROM STOCK")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        For Each R As DataRow In access.DBDT.Rows
            cbxStockItem2.Items.Add(R("Stock_Item"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStockItem2.SelectedIndex = 0

    End Sub

    Private Sub picAdd2_Click(sender As Object, e As EventArgs) Handles picAdd2.Click
        grp3.Visible = True
        grp2.Visible = True
        picAdd2.Visible = True
        btnSales.Enabled = False
        '   QUERY
        access.ExecQuery("SELECT * FROM STOCK")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        For Each R As DataRow In access.DBDT.Rows
            cbxStockItem3.Items.Add(R("Stock_Item"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStockItem3.SelectedIndex = 0
    End Sub

    Private Sub picAdd_DoubleClick(sender As Object, e As EventArgs) Handles picAdd.DoubleClick
        grp3.Visible = False
        picAdd2.Visible = False
        grp2.Visible = False
        picAdd.Visible = True

    End Sub

    Private Sub picAdd2_DoubleClick(sender As Object, e As EventArgs) Handles picAdd2.DoubleClick
        grp3.Visible = False
    End Sub

    Private Sub cbxStockItem2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStockItem2.SelectedIndexChanged
        ' QUERY STAFF TABLE TO FILL DATA TABLE
        If cbxStockItem2.Text = "" Then
            MessageBox.Show("NO ITEM FOUND", "STOCK SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            access.AddParam("@SearchID", cbxStockItem2.Text)
            access.ExecQuery("select * FROM STOCK WHERE Srock_Item= @SearchID")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub

            'FAIL IF NO RECORDS FOUND
            If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'RETURN STOCK RECORDS
            Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
            lblPriceSales2.Text = r("Price")
            lblItemsInStock2.Text = r("Quantity")
            lblID2.Text = r("StockID")
            lblSold2.Text = r("NO_SOLD")
            lblAmntSold2.Text = r("AMOUNT_SOLD")
        End If
    End Sub

    Private Sub btnAddSales2_Click(sender As Object, e As EventArgs) Handles btnAddSales2.Click
        Dim qnty, items As Integer
        If cbxQnty2.Text = "" Then
            MessageBox.Show("SELECT QUANTITY TO BE SOLD", "SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbxQnty2.Focus()
        Else
            qnty = cbxQnty2.Text : items = lblItemsInStock2.Text
            If qnty > items Then
                MsgBox("LOW STOCK")
                Exit Sub
            Else
                '   SOLVE FOR THE COST OF ITEMS BOUGHT
                Dim x, a, b As Integer
                b = CInt(lblPriceSales2.Text)
                a = cbxQnty2.Text
                x = a * b

                '   ADD ITEMS TO LIST BOX
                '   UPDATE QUANTITY IN STOCK
                lstItem.Items.Add(cbxStockItem2.Text & "                          " & cbxQnty2.Text & "               " & x)
                lblItemsInStock2.Text = lblItemsInStock2.Text - cbxQnty2.Text
                lblSalesTotal.Text = lblSalesTotal.Text + x
                lblAmntSold2.Text = lblAmntSold2.Text + x
                Dim SELL1, SELL2 As Integer
                SELL1 = lblSold2.Text : SELL2 = cbxQnty2.Text
                lblSold2.Text = SELL1 + SELL2
                cbxStockItem2.Enabled = False
                btnAddSales2.Enabled = False
                'cbxQnty2.Text = ""
            End If
        End If
    End Sub

    Private Sub lblItemsInStock2_TextChanged(sender As Object, e As EventArgs) Handles lblItemsInStock2.TextChanged
        cbxQnty2.Items.Clear()
        Dim a, x As Integer
        x = lblItemsInStock2.Text
        For a = 1 To x
            cbxQnty2.Items.Add(a)
        Next a
    End Sub

    Private Sub cbxStockItem3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStockItem3.SelectedIndexChanged
        ' QUERY STAFF TABLE TO FILL DATA TABLE
        If cbxStockItem3.Text = "" Then
            MessageBox.Show("NO ITEM FOUND", "STOCK SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            access.AddParam("@SearchID", cbxStockItem3.Text)
            access.ExecQuery("select * FROM STOCK WHERE Stock_Item= @SearchID")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub

            'FAIL IF NO RECORDS FOUND
            If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'RETURN STOCK RECORDS
            Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
            lblPriceSales3.Text = r("Price")
            lblItemsInStock3.Text = r("Quantity")
            lblID3.Text = r("StockID")
            lblSold3.Text = r("NO_SOLD")
            lblAmntSold3.Text = r("AMOUNT_SOLD")
            '   REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        End If
    End Sub

    Private Sub btnAddSales3_Click(sender As Object, e As EventArgs) Handles btnAddSales3.Click
        Dim qnty, items As Integer
        If cbxQnty3.Text = "" Then
            MessageBox.Show("SELECT QUANTITY TO BE SOLD", "SALES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbxQnty3.Focus()
        Else
            qnty = cbxQnty3.Text : items = lblItemsInStock3.Text
            If qnty > items Then
                MsgBox("LOW STOCK")
                Exit Sub
            Else
                '   SOLVE FOR THE COST OF ITEMS BOUGHT
                Dim x, a, b As Integer
                b = CInt(lblPriceSales3.Text)
                a = cbxQnty3.Text
                x = a * b

                '   ADD ITEMS TO LIST BOX
                '   UPDATE QUANTITY IN STOCK
                lstItem.Items.Add(cbxStockItem3.Text & "                          " & cbxQnty3.Text & "               " & x)
                lblItemsInStock3.Text = lblItemsInStock3.Text - cbxQnty3.Text
                lblSalesTotal.Text = lblSalesTotal.Text + x
                lblAmntSold3.Text = lblAmntSold3.Text + x
                Dim SELL1, SELL2 As Integer
                SELL1 = lblSold3.Text : SELL2 = cbxQnty3.Text
                lblSold3.Text = SELL1 + SELL2
                cbxStockItem3.Enabled = False
                btnSales.Enabled = False
                btnAddSales3.Enabled = False
                '  cbxQnty3.Text = ""
            End If
        End If
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        Dim MSG As Integer
        MSG = MsgBox("ADD MORE ITEMS?", vbYesNo, vbQuestion)
        If MSG = vbYes Then
            access.AddParam("@Qnty", lblItemsInStock.Text)
            access.AddParam("@Sold", lblsold.Text)
            access.AddParam("@AmntSold", lblAmtSold.Text)
            access.AddParam("@ID", lblID.Text)
            access.ExecQuery("UPDATE STOCK SET Quantity = @Qnty, [NO_SOLD] = @Sold, [AMOUNT_SOLD] = @AmntSold WHERE StockID = @ID")

            access.AddParam("@SECQnty", lblItemsInStock2.Text)
            access.AddParam("@SECSold", lblSold2.Text)
            access.AddParam("@SECAmntSold", lblAmntSold2.Text)
            access.AddParam("@SECID", lblID2.Text)
            If grp2.Visible = True Then
                access.ExecQuery("UPDATE STOCK SET Quantity = @SECQnty, [NO_SOLD] = @SECSold, [AMOUNT_SOLD] = @SECAmntSold WHERE StockID = @SECID")
            End If
            access.AddParam("@THIRDQnty", lblItemsInStock3.Text)
            access.AddParam("@THIRDSold", lblSold2.Text)
            access.AddParam("@THIRDAmntSold", lblAmntSold2.Text)
            access.AddParam("@THIRDID", lblID3.Text)
            If grp3.Visible = True Then
                access.ExecQuery("UPDATE STOCK SET Quantity = @THIRDQnty, [NO_SOLD] = @THIRDSold, [AMOUNT_SOLD] = @THIRDAmntSold WHERE StockID = @THIRDID")
            End If
            '   REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

            cbxStockItem.Enabled = True : cbxStockItem2.Enabled = True : cbxStockItem.Enabled = True
            grp3.Visible = False
            picAdd2.Visible = False
            grp2.Visible = False
            btnSales.Enabled = False

        End If
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
    End Sub
    Private Sub lblItemsInStock3_TextChanged(sender As Object, e As EventArgs) Handles lblItemsInStock3.TextChanged
        cbxQnty3.Items.Clear()
        Dim a, x As Integer
        x = lblItemsInStock3.Text
        For a = 1 To x
            cbxQnty3.Items.Add(a)
        Next a
    End Sub


    Private Sub cbxQnty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxQnty.SelectedIndexChanged
        If cbxQnty.Text <> "" Then
            btnAddSales.Enabled = True
        End If
    End Sub

    Private Sub cbxQnty2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxQnty2.SelectedIndexChanged
        If cbxQnty2.Text <> "" Then
            btnAddSales2.Enabled = True
        End If
    End Sub

    Private Sub cbxQnty3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxQnty3.SelectedIndexChanged
        If cbxQnty3.Text <> "" Then
            btnAddSales3.Enabled = True
        End If
    End Sub

    Private Sub lblSalesTotal_Click(sender As Object, e As EventArgs) Handles lblSalesTotal.Click

    End Sub
End Class