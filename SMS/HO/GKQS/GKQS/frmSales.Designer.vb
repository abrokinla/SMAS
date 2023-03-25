<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.lblAmtSold = New System.Windows.Forms.Label()
        Me.lblsold = New System.Windows.Forms.Label()
        Me.btnClearSales = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnAddSales = New System.Windows.Forms.Button()
        Me.cbxQnty = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPriceSales = New System.Windows.Forms.Label()
        Me.lblItemsInStock = New System.Windows.Forms.Label()
        Me.cbxStockItem = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lblSalesTotal = New System.Windows.Forms.Label()
        Me.grp3 = New System.Windows.Forms.GroupBox()
        Me.lblAmntSold3 = New System.Windows.Forms.Label()
        Me.lblSold3 = New System.Windows.Forms.Label()
        Me.btnClearSales3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnAddSales3 = New System.Windows.Forms.Button()
        Me.cbxQnty3 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblPriceSales3 = New System.Windows.Forms.Label()
        Me.lblID3 = New System.Windows.Forms.Label()
        Me.lblItemsInStock3 = New System.Windows.Forms.Label()
        Me.cbxStockItem3 = New System.Windows.Forms.ComboBox()
        Me.grp2 = New System.Windows.Forms.GroupBox()
        Me.lblAmntSold2 = New System.Windows.Forms.Label()
        Me.lblSold2 = New System.Windows.Forms.Label()
        Me.btnClearSales2 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddSales2 = New System.Windows.Forms.Button()
        Me.cbxQnty2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPriceSales2 = New System.Windows.Forms.Label()
        Me.lblItemsInStock2 = New System.Windows.Forms.Label()
        Me.lblID2 = New System.Windows.Forms.Label()
        Me.cbxStockItem2 = New System.Windows.Forms.ComboBox()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.picAdd2 = New System.Windows.Forms.PictureBox()
        Me.picAdd = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.grp1.SuspendLayout()
        Me.grp3.SuspendLayout()
        Me.grp2.SuspendLayout()
        CType(Me.picAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(64, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 28)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "SALES"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(527, 401)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 19)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "TOTAL"
        '
        'btnSavePrint
        '
        Me.btnSavePrint.Enabled = False
        Me.btnSavePrint.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrint.Location = New System.Drawing.Point(557, 442)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(167, 23)
        Me.btnSavePrint.TabIndex = 36
        Me.btnSavePrint.Text = "SAVE AND PRINT RECIEPT"
        Me.btnSavePrint.UseVisualStyleBackColor = True
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.lblAmtSold)
        Me.grp1.Controls.Add(Me.lblsold)
        Me.grp1.Controls.Add(Me.btnClearSales)
        Me.grp1.Controls.Add(Me.Label20)
        Me.grp1.Controls.Add(Me.Label26)
        Me.grp1.Controls.Add(Me.btnAddSales)
        Me.grp1.Controls.Add(Me.cbxQnty)
        Me.grp1.Controls.Add(Me.Label13)
        Me.grp1.Controls.Add(Me.Label10)
        Me.grp1.Controls.Add(Me.Label8)
        Me.grp1.Controls.Add(Me.lblID)
        Me.grp1.Controls.Add(Me.lblPriceSales)
        Me.grp1.Controls.Add(Me.lblItemsInStock)
        Me.grp1.Controls.Add(Me.cbxStockItem)
        Me.grp1.Location = New System.Drawing.Point(53, 47)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(440, 144)
        Me.grp1.TabIndex = 33
        Me.grp1.TabStop = False
        '
        'lblAmtSold
        '
        Me.lblAmtSold.Location = New System.Drawing.Point(355, 121)
        Me.lblAmtSold.Name = "lblAmtSold"
        Me.lblAmtSold.Size = New System.Drawing.Size(39, 20)
        Me.lblAmtSold.TabIndex = 30
        Me.lblAmtSold.Text = "0"
        Me.lblAmtSold.Visible = False
        '
        'lblsold
        '
        Me.lblsold.Location = New System.Drawing.Point(355, 85)
        Me.lblsold.Name = "lblsold"
        Me.lblsold.Size = New System.Drawing.Size(39, 20)
        Me.lblsold.TabIndex = 30
        Me.lblsold.Text = "0"
        Me.lblsold.Visible = False
        '
        'btnClearSales
        '
        Me.btnClearSales.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSales.Location = New System.Drawing.Point(127, 111)
        Me.btnClearSales.Name = "btnClearSales"
        Me.btnClearSales.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSales.TabIndex = 28
        Me.btnClearSales.Text = "CLEAR"
        Me.btnClearSales.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(204, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "STOCK ID"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(204, 85)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "STOCK"
        '
        'btnAddSales
        '
        Me.btnAddSales.Enabled = False
        Me.btnAddSales.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSales.Location = New System.Drawing.Point(46, 111)
        Me.btnAddSales.Name = "btnAddSales"
        Me.btnAddSales.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSales.TabIndex = 21
        Me.btnAddSales.Text = "ADD"
        Me.btnAddSales.UseVisualStyleBackColor = True
        '
        'cbxQnty
        '
        Me.cbxQnty.FormattingEnabled = True
        Me.cbxQnty.Location = New System.Drawing.Point(117, 82)
        Me.cbxQnty.Name = "cbxQnty"
        Me.cbxQnty.Size = New System.Drawing.Size(47, 21)
        Me.cbxQnty.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 19)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "QUANTITY"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "UNIT PRICE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ITEM"
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Silver
        Me.lblID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(268, 55)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(128, 23)
        Me.lblID.TabIndex = 19
        '
        'lblPriceSales
        '
        Me.lblPriceSales.BackColor = System.Drawing.Color.Silver
        Me.lblPriceSales.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceSales.Location = New System.Drawing.Point(116, 54)
        Me.lblPriceSales.Name = "lblPriceSales"
        Me.lblPriceSales.Size = New System.Drawing.Size(67, 23)
        Me.lblPriceSales.TabIndex = 4
        '
        'lblItemsInStock
        '
        Me.lblItemsInStock.BackColor = System.Drawing.Color.Silver
        Me.lblItemsInStock.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsInStock.Location = New System.Drawing.Point(267, 82)
        Me.lblItemsInStock.Name = "lblItemsInStock"
        Me.lblItemsInStock.Size = New System.Drawing.Size(61, 23)
        Me.lblItemsInStock.TabIndex = 19
        '
        'cbxStockItem
        '
        Me.cbxStockItem.FormattingEnabled = True
        Me.cbxStockItem.Location = New System.Drawing.Point(96, 21)
        Me.cbxStockItem.Name = "cbxStockItem"
        Me.cbxStockItem.Size = New System.Drawing.Size(277, 21)
        Me.cbxStockItem.TabIndex = 17
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(334, 376)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(0, 19)
        Me.Label29.TabIndex = 32
        '
        'lstItem
        '
        Me.lstItem.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.ItemHeight = 15
        Me.lstItem.Items.AddRange(New Object() {"ITEM" & Global.Microsoft.VisualBasic.ChrW(9) & "                   QNTY" & Global.Microsoft.VisualBasic.ChrW(9) & "    COST"})
        Me.lstItem.Location = New System.Drawing.Point(531, 47)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(319, 349)
        Me.lstItem.TabIndex = 31
        '
        'lblSalesTotal
        '
        Me.lblSalesTotal.BackColor = System.Drawing.Color.Silver
        Me.lblSalesTotal.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTotal.Location = New System.Drawing.Point(588, 400)
        Me.lblSalesTotal.Name = "lblSalesTotal"
        Me.lblSalesTotal.Size = New System.Drawing.Size(136, 23)
        Me.lblSalesTotal.TabIndex = 30
        Me.lblSalesTotal.Text = "0.00"
        '
        'grp3
        '
        Me.grp3.Controls.Add(Me.lblAmntSold3)
        Me.grp3.Controls.Add(Me.lblSold3)
        Me.grp3.Controls.Add(Me.btnClearSales3)
        Me.grp3.Controls.Add(Me.Label17)
        Me.grp3.Controls.Add(Me.Label18)
        Me.grp3.Controls.Add(Me.btnAddSales3)
        Me.grp3.Controls.Add(Me.cbxQnty3)
        Me.grp3.Controls.Add(Me.Label19)
        Me.grp3.Controls.Add(Me.Label22)
        Me.grp3.Controls.Add(Me.Label23)
        Me.grp3.Controls.Add(Me.lblPriceSales3)
        Me.grp3.Controls.Add(Me.lblID3)
        Me.grp3.Controls.Add(Me.lblItemsInStock3)
        Me.grp3.Controls.Add(Me.cbxStockItem3)
        Me.grp3.Location = New System.Drawing.Point(53, 324)
        Me.grp3.Name = "grp3"
        Me.grp3.Size = New System.Drawing.Size(440, 144)
        Me.grp3.TabIndex = 34
        Me.grp3.TabStop = False
        Me.grp3.Visible = False
        '
        'lblAmntSold3
        '
        Me.lblAmntSold3.Location = New System.Drawing.Point(345, 111)
        Me.lblAmntSold3.Name = "lblAmntSold3"
        Me.lblAmntSold3.Size = New System.Drawing.Size(39, 20)
        Me.lblAmntSold3.TabIndex = 30
        Me.lblAmntSold3.Text = "0"
        Me.lblAmntSold3.Visible = False
        '
        'lblSold3
        '
        Me.lblSold3.Location = New System.Drawing.Point(345, 75)
        Me.lblSold3.Name = "lblSold3"
        Me.lblSold3.Size = New System.Drawing.Size(39, 20)
        Me.lblSold3.TabIndex = 30
        Me.lblSold3.Text = "0"
        Me.lblSold3.Visible = False
        '
        'btnClearSales3
        '
        Me.btnClearSales3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSales3.Location = New System.Drawing.Point(127, 111)
        Me.btnClearSales3.Name = "btnClearSales3"
        Me.btnClearSales3.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSales3.TabIndex = 28
        Me.btnClearSales3.Text = "CLEAR"
        Me.btnClearSales3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(203, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "STOCK ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(204, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "STOCK"
        '
        'btnAddSales3
        '
        Me.btnAddSales3.Enabled = False
        Me.btnAddSales3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSales3.Location = New System.Drawing.Point(46, 111)
        Me.btnAddSales3.Name = "btnAddSales3"
        Me.btnAddSales3.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSales3.TabIndex = 21
        Me.btnAddSales3.Text = "ADD"
        Me.btnAddSales3.UseVisualStyleBackColor = True
        '
        'cbxQnty3
        '
        Me.cbxQnty3.FormattingEnabled = True
        Me.cbxQnty3.Location = New System.Drawing.Point(117, 82)
        Me.cbxQnty3.Name = "cbxQnty3"
        Me.cbxQnty3.Size = New System.Drawing.Size(47, 21)
        Me.cbxQnty3.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 82)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 19)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "QUANTITY"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 19)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "UNIT PRICE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 19)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "ITEM"
        '
        'lblPriceSales3
        '
        Me.lblPriceSales3.BackColor = System.Drawing.Color.Silver
        Me.lblPriceSales3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceSales3.Location = New System.Drawing.Point(116, 54)
        Me.lblPriceSales3.Name = "lblPriceSales3"
        Me.lblPriceSales3.Size = New System.Drawing.Size(67, 23)
        Me.lblPriceSales3.TabIndex = 4
        '
        'lblID3
        '
        Me.lblID3.BackColor = System.Drawing.Color.Silver
        Me.lblID3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID3.Location = New System.Drawing.Point(267, 48)
        Me.lblID3.Name = "lblID3"
        Me.lblID3.Size = New System.Drawing.Size(128, 23)
        Me.lblID3.TabIndex = 19
        '
        'lblItemsInStock3
        '
        Me.lblItemsInStock3.BackColor = System.Drawing.Color.Silver
        Me.lblItemsInStock3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsInStock3.Location = New System.Drawing.Point(267, 82)
        Me.lblItemsInStock3.Name = "lblItemsInStock3"
        Me.lblItemsInStock3.Size = New System.Drawing.Size(61, 23)
        Me.lblItemsInStock3.TabIndex = 19
        '
        'cbxStockItem3
        '
        Me.cbxStockItem3.FormattingEnabled = True
        Me.cbxStockItem3.Location = New System.Drawing.Point(117, 21)
        Me.cbxStockItem3.Name = "cbxStockItem3"
        Me.cbxStockItem3.Size = New System.Drawing.Size(277, 21)
        Me.cbxStockItem3.TabIndex = 17
        '
        'grp2
        '
        Me.grp2.Controls.Add(Me.lblAmntSold2)
        Me.grp2.Controls.Add(Me.lblSold2)
        Me.grp2.Controls.Add(Me.btnClearSales2)
        Me.grp2.Controls.Add(Me.Label21)
        Me.grp2.Controls.Add(Me.Label4)
        Me.grp2.Controls.Add(Me.btnAddSales2)
        Me.grp2.Controls.Add(Me.cbxQnty2)
        Me.grp2.Controls.Add(Me.Label12)
        Me.grp2.Controls.Add(Me.Label14)
        Me.grp2.Controls.Add(Me.Label15)
        Me.grp2.Controls.Add(Me.lblPriceSales2)
        Me.grp2.Controls.Add(Me.lblItemsInStock2)
        Me.grp2.Controls.Add(Me.lblID2)
        Me.grp2.Controls.Add(Me.cbxStockItem2)
        Me.grp2.Location = New System.Drawing.Point(53, 183)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(440, 144)
        Me.grp2.TabIndex = 35
        Me.grp2.TabStop = False
        Me.grp2.Visible = False
        '
        'lblAmntSold2
        '
        Me.lblAmntSold2.Location = New System.Drawing.Point(345, 111)
        Me.lblAmntSold2.Name = "lblAmntSold2"
        Me.lblAmntSold2.Size = New System.Drawing.Size(39, 20)
        Me.lblAmntSold2.TabIndex = 30
        Me.lblAmntSold2.Text = "0"
        Me.lblAmntSold2.Visible = False
        '
        'lblSold2
        '
        Me.lblSold2.Location = New System.Drawing.Point(345, 75)
        Me.lblSold2.Name = "lblSold2"
        Me.lblSold2.Size = New System.Drawing.Size(39, 20)
        Me.lblSold2.TabIndex = 30
        Me.lblSold2.Text = "0"
        Me.lblSold2.Visible = False
        '
        'btnClearSales2
        '
        Me.btnClearSales2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSales2.Location = New System.Drawing.Point(127, 111)
        Me.btnClearSales2.Name = "btnClearSales2"
        Me.btnClearSales2.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSales2.TabIndex = 28
        Me.btnClearSales2.Text = "CLEAR"
        Me.btnClearSales2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(203, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "STOCK ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "STOCK"
        '
        'btnAddSales2
        '
        Me.btnAddSales2.Enabled = False
        Me.btnAddSales2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSales2.Location = New System.Drawing.Point(46, 111)
        Me.btnAddSales2.Name = "btnAddSales2"
        Me.btnAddSales2.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSales2.TabIndex = 21
        Me.btnAddSales2.Text = "ADD"
        Me.btnAddSales2.UseVisualStyleBackColor = True
        '
        'cbxQnty2
        '
        Me.cbxQnty2.FormattingEnabled = True
        Me.cbxQnty2.Location = New System.Drawing.Point(117, 82)
        Me.cbxQnty2.Name = "cbxQnty2"
        Me.cbxQnty2.Size = New System.Drawing.Size(47, 21)
        Me.cbxQnty2.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "QUANTITY"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 19)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "UNIT PRICE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "ITEM"
        '
        'lblPriceSales2
        '
        Me.lblPriceSales2.BackColor = System.Drawing.Color.Silver
        Me.lblPriceSales2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceSales2.Location = New System.Drawing.Point(116, 54)
        Me.lblPriceSales2.Name = "lblPriceSales2"
        Me.lblPriceSales2.Size = New System.Drawing.Size(67, 23)
        Me.lblPriceSales2.TabIndex = 4
        '
        'lblItemsInStock2
        '
        Me.lblItemsInStock2.BackColor = System.Drawing.Color.Silver
        Me.lblItemsInStock2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsInStock2.Location = New System.Drawing.Point(267, 82)
        Me.lblItemsInStock2.Name = "lblItemsInStock2"
        Me.lblItemsInStock2.Size = New System.Drawing.Size(61, 23)
        Me.lblItemsInStock2.TabIndex = 19
        '
        'lblID2
        '
        Me.lblID2.BackColor = System.Drawing.Color.Silver
        Me.lblID2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID2.Location = New System.Drawing.Point(267, 48)
        Me.lblID2.Name = "lblID2"
        Me.lblID2.Size = New System.Drawing.Size(128, 23)
        Me.lblID2.TabIndex = 19
        '
        'cbxStockItem2
        '
        Me.cbxStockItem2.FormattingEnabled = True
        Me.cbxStockItem2.Location = New System.Drawing.Point(117, 21)
        Me.cbxStockItem2.Name = "cbxStockItem2"
        Me.cbxStockItem2.Size = New System.Drawing.Size(277, 21)
        Me.cbxStockItem2.TabIndex = 17
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Red
        Me.btnSales.Enabled = False
        Me.btnSales.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(358, 474)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(135, 42)
        Me.btnSales.TabIndex = 41
        Me.btnSales.Text = "MORE SALES"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'picAdd2
        '
        Me.picAdd2.Image = Global.GKQS.My.Resources.Resources.icons8_add_32
        Me.picAdd2.Location = New System.Drawing.Point(43, 319)
        Me.picAdd2.Name = "picAdd2"
        Me.picAdd2.Size = New System.Drawing.Size(19, 20)
        Me.picAdd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdd2.TabIndex = 38
        Me.picAdd2.TabStop = False
        Me.picAdd2.Visible = False
        '
        'picAdd
        '
        Me.picAdd.Image = Global.GKQS.My.Resources.Resources.icons8_add_32
        Me.picAdd.Location = New System.Drawing.Point(43, 181)
        Me.picAdd.Name = "picAdd"
        Me.picAdd.Size = New System.Drawing.Size(19, 20)
        Me.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdd.TabIndex = 39
        Me.picAdd.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(391, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 19)
        Me.lblDate.TabIndex = 42
        Me.lblDate.Text = "Label1"
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.ForeColor = System.Drawing.Color.Red
        Me.lblCashier.Location = New System.Drawing.Point(710, 18)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(80, 19)
        Me.lblCashier.TabIndex = 43
        Me.lblCashier.Text = "user 1010"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GKQS.My.Resources.Resources.user_48px
        Me.PictureBox1.Location = New System.Drawing.Point(665, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 522)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.picAdd2)
        Me.Controls.Add(Me.picAdd)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnSavePrint)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.lblSalesTotal)
        Me.Controls.Add(Me.grp3)
        Me.Controls.Add(Me.grp2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSales"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grp3.ResumeLayout(False)
        Me.grp3.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        CType(Me.picAdd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents picAdd2 As System.Windows.Forms.PictureBox
    Friend WithEvents picAdd As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSavePrint As System.Windows.Forms.Button
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearSales As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnAddSales As System.Windows.Forms.Button
    Friend WithEvents cbxQnty As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblPriceSales As System.Windows.Forms.Label
    Friend WithEvents lblItemsInStock As System.Windows.Forms.Label
    Friend WithEvents cbxStockItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
    Friend WithEvents lblSalesTotal As System.Windows.Forms.Label
    Friend WithEvents grp3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearSales3 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnAddSales3 As System.Windows.Forms.Button
    Friend WithEvents cbxQnty3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblPriceSales3 As System.Windows.Forms.Label
    Friend WithEvents lblID3 As System.Windows.Forms.Label
    Friend WithEvents lblItemsInStock3 As System.Windows.Forms.Label
    Friend WithEvents cbxStockItem3 As System.Windows.Forms.ComboBox
    Friend WithEvents grp2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearSales2 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAddSales2 As System.Windows.Forms.Button
    Friend WithEvents cbxQnty2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPriceSales2 As System.Windows.Forms.Label
    Friend WithEvents lblID2 As System.Windows.Forms.Label
    Friend WithEvents cbxStockItem2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents lblItemsInStock2 As System.Windows.Forms.Label
    Friend WithEvents lblsold As System.Windows.Forms.Label
    Friend WithEvents lblAmtSold As System.Windows.Forms.Label
    Friend WithEvents lblAmntSold3 As System.Windows.Forms.Label
    Friend WithEvents lblSold3 As System.Windows.Forms.Label
    Friend WithEvents lblAmntSold2 As System.Windows.Forms.Label
    Friend WithEvents lblSold2 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
