<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountingSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountingSystem))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiptToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebtorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvFees = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvPayroll = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvAssets = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvIncome = New System.Windows.Forms.DataGridView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpExpenditure = New System.Windows.Forms.GroupBox()
        Me.lblExpenditure = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvExpenditure = New System.Windows.Forms.DataGridView()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cbxSumTerm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSumSession = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxName = New System.Windows.Forms.ComboBox()
        Me.rdNur = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdCol = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxClass = New System.Windows.Forms.ComboBox()
        Me.txtSes = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.lblSes = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSumIncome = New System.Windows.Forms.Label()
        Me.dgvIncomeSummary = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgvDebtors = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.grpExpenditure.SuspendLayout()
        CType(Me.dgvExpenditure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvIncomeSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvDebtors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowItemReorder = True
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1145, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentToolStripMenuItem, Me.ReceiptToolStripMenuItem1, Me.RefreshToolStripMenuItem, Me.SaveToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(50, 25)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeesToolStripMenuItem, Me.SalaryToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.PaymentToolStripMenuItem.Text = "P&ayment"
        '
        'FeesToolStripMenuItem
        '
        Me.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        Me.FeesToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.FeesToolStripMenuItem.Text = "&Fees"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SalaryToolStripMenuItem.Text = "&Salary"
        '
        'ReceiptToolStripMenuItem1
        '
        Me.ReceiptToolStripMenuItem1.Name = "ReceiptToolStripMenuItem1"
        Me.ReceiptToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.ReceiptToolStripMenuItem1.Text = "Receip&t"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebtorsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(67, 25)
        Me.ToolStripMenuItem1.Text = "FIL&TER"
        '
        'DebtorsToolStripMenuItem
        '
        Me.DebtorsToolStripMenuItem.Name = "DebtorsToolStripMenuItem"
        Me.DebtorsToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.DebtorsToolStripMenuItem.Text = "&Debtors"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1145, 536)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.dgvFees)
        Me.TabPage1.Location = New System.Drawing.Point(4, 37)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FEES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvFees
        '
        Me.dgvFees.AllowUserToAddRows = False
        Me.dgvFees.AllowUserToDeleteRows = False
        Me.dgvFees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFees.Location = New System.Drawing.Point(1, 3)
        Me.dgvFees.Name = "dgvFees"
        Me.dgvFees.ReadOnly = True
        Me.dgvFees.Size = New System.Drawing.Size(1126, 485)
        Me.dgvFees.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.dgvPayroll)
        Me.TabPage2.Location = New System.Drawing.Point(4, 37)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PAYROLL"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvPayroll
        '
        Me.dgvPayroll.AllowUserToAddRows = False
        Me.dgvPayroll.AllowUserToDeleteRows = False
        Me.dgvPayroll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayroll.Location = New System.Drawing.Point(1, 3)
        Me.dgvPayroll.Name = "dgvPayroll"
        Me.dgvPayroll.ReadOnly = True
        Me.dgvPayroll.Size = New System.Drawing.Size(1126, 477)
        Me.dgvPayroll.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.dgvInventory)
        Me.TabPage3.Location = New System.Drawing.Point(4, 37)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "INVENTORY"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(1, 3)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.Size = New System.Drawing.Size(1129, 477)
        Me.dgvInventory.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.dgvAssets)
        Me.TabPage4.Location = New System.Drawing.Point(4, 37)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ASSETS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvAssets
        '
        Me.dgvAssets.AllowUserToAddRows = False
        Me.dgvAssets.AllowUserToDeleteRows = False
        Me.dgvAssets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssets.Location = New System.Drawing.Point(1, 3)
        Me.dgvAssets.Name = "dgvAssets"
        Me.dgvAssets.ReadOnly = True
        Me.dgvAssets.Size = New System.Drawing.Size(1134, 477)
        Me.dgvAssets.TabIndex = 2
        '
        'TabPage5
        '
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage5.Controls.Add(Me.lblIncome)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.dgvIncome)
        Me.TabPage5.Location = New System.Drawing.Point(4, 37)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "EXPECTED INCOME"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.ForeColor = System.Drawing.Color.Red
        Me.lblIncome.Location = New System.Drawing.Point(365, 15)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(73, 25)
        Me.lblIncome.TabIndex = 4
        Me.lblIncome.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(336, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "EXPECTED INCOME FOR THE TERM"
        '
        'dgvIncome
        '
        Me.dgvIncome.AllowUserToAddRows = False
        Me.dgvIncome.AllowUserToDeleteRows = False
        Me.dgvIncome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncome.Location = New System.Drawing.Point(1, 71)
        Me.dgvIncome.Name = "dgvIncome"
        Me.dgvIncome.ReadOnly = True
        Me.dgvIncome.Size = New System.Drawing.Size(1131, 422)
        Me.dgvIncome.TabIndex = 2
        '
        'TabPage7
        '
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage7.Controls.Add(Me.Label4)
        Me.TabPage7.Controls.Add(Me.Label1)
        Me.TabPage7.Controls.Add(Me.grpExpenditure)
        Me.TabPage7.Controls.Add(Me.dgvExpenditure)
        Me.TabPage7.Controls.Add(Me.grpFilter)
        Me.TabPage7.Controls.Add(Me.PictureBox2)
        Me.TabPage7.Controls.Add(Me.PictureBox1)
        Me.TabPage7.Location = New System.Drawing.Point(4, 37)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "EXPENDITURE"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TOTAL EXPENDITURE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filter"
        '
        'grpExpenditure
        '
        Me.grpExpenditure.Controls.Add(Me.lblExpenditure)
        Me.grpExpenditure.Controls.Add(Me.btnCalc)
        Me.grpExpenditure.Controls.Add(Me.Label7)
        Me.grpExpenditure.Location = New System.Drawing.Point(489, 57)
        Me.grpExpenditure.Name = "grpExpenditure"
        Me.grpExpenditure.Size = New System.Drawing.Size(368, 54)
        Me.grpExpenditure.TabIndex = 4
        Me.grpExpenditure.TabStop = False
        '
        'lblExpenditure
        '
        Me.lblExpenditure.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblExpenditure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExpenditure.Location = New System.Drawing.Point(6, 17)
        Me.lblExpenditure.Name = "lblExpenditure"
        Me.lblExpenditure.Size = New System.Drawing.Size(242, 25)
        Me.lblExpenditure.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(303, 16)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(58, 29)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "CALC"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "NGN"
        '
        'dgvExpenditure
        '
        Me.dgvExpenditure.AllowUserToAddRows = False
        Me.dgvExpenditure.AllowUserToDeleteRows = False
        Me.dgvExpenditure.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExpenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpenditure.Location = New System.Drawing.Point(1, 130)
        Me.dgvExpenditure.Name = "dgvExpenditure"
        Me.dgvExpenditure.ReadOnly = True
        Me.dgvExpenditure.Size = New System.Drawing.Size(1094, 367)
        Me.dgvExpenditure.TabIndex = 2
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.btnOK)
        Me.grpFilter.Controls.Add(Me.cbxSumTerm)
        Me.grpFilter.Controls.Add(Me.Label3)
        Me.grpFilter.Controls.Add(Me.cbxSumSession)
        Me.grpFilter.Controls.Add(Me.Label2)
        Me.grpFilter.Location = New System.Drawing.Point(30, 32)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(386, 87)
        Me.grpFilter.TabIndex = 4
        Me.grpFilter.TabStop = False
        Me.grpFilter.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(329, 34)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(47, 44)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cbxSumTerm
        '
        Me.cbxSumTerm.FormattingEnabled = True
        Me.cbxSumTerm.Items.AddRange(New Object() {"", "FIRST", "SECOND", "THIRD"})
        Me.cbxSumTerm.Location = New System.Drawing.Point(184, 39)
        Me.cbxSumTerm.Name = "cbxSumTerm"
        Me.cbxSumTerm.Size = New System.Drawing.Size(139, 33)
        Me.cbxSumTerm.TabIndex = 3
        Me.cbxSumTerm.Text = "SELECT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Term"
        '
        'cbxSumSession
        '
        Me.cbxSumSession.FormattingEnabled = True
        Me.cbxSumSession.Items.AddRange(New Object() {"2019/2020", "2020/2021", "2021/2022", "2022/2023", "2023/2024", "2024/2025"})
        Me.cbxSumSession.Location = New System.Drawing.Point(6, 39)
        Me.cbxSumSession.Name = "cbxSumSession"
        Me.cbxSumSession.Size = New System.Drawing.Size(159, 33)
        Me.cbxSumSession.TabIndex = 1
        Me.cbxSumSession.Text = "SELECT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Session"
        '
        'TabPage8
        '
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage8.Controls.Add(Me.Label11)
        Me.TabPage8.Controls.Add(Me.GroupBox1)
        Me.TabPage8.Controls.Add(Me.lblTerm)
        Me.TabPage8.Controls.Add(Me.lblSes)
        Me.TabPage8.Controls.Add(Me.Label9)
        Me.TabPage8.Controls.Add(Me.lblSumIncome)
        Me.TabPage8.Controls.Add(Me.dgvIncomeSummary)
        Me.TabPage8.Location = New System.Drawing.Point(4, 37)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "INCOME SUMMARY"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(812, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 12)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Click to add"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxName)
        Me.GroupBox1.Controls.Add(Me.rdNur)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.rdCol)
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxClass)
        Me.GroupBox1.Controls.Add(Me.txtSes)
        Me.GroupBox1.Controls.Add(Me.txtTerm)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 80)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cbxName
        '
        Me.cbxName.FormattingEnabled = True
        Me.cbxName.Location = New System.Drawing.Point(458, 43)
        Me.cbxName.Name = "cbxName"
        Me.cbxName.Size = New System.Drawing.Size(246, 33)
        Me.cbxName.TabIndex = 15
        '
        'rdNur
        '
        Me.rdNur.AutoSize = True
        Me.rdNur.Location = New System.Drawing.Point(120, 48)
        Me.rdNur.Name = "rdNur"
        Me.rdNur.Size = New System.Drawing.Size(107, 29)
        Me.rdNur.TabIndex = 9
        Me.rdNur.TabStop = True
        Me.rdNur.Text = "Nur/Pry"
        Me.rdNur.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "STUDENT'S NAME"
        '
        'rdCol
        '
        Me.rdCol.AutoSize = True
        Me.rdCol.Location = New System.Drawing.Point(120, 16)
        Me.rdCol.Name = "rdCol"
        Me.rdCol.Size = New System.Drawing.Size(95, 29)
        Me.rdCol.TabIndex = 8
        Me.rdCol.TabStop = True
        Me.rdCol.Text = "College"
        Me.rdCol.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(724, 39)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(37, 32)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Class"
        '
        'cbxClass
        '
        Me.cbxClass.FormattingEnabled = True
        Me.cbxClass.Location = New System.Drawing.Point(248, 44)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(193, 33)
        Me.cbxClass.TabIndex = 6
        '
        'txtSes
        '
        Me.txtSes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSes.Location = New System.Drawing.Point(6, 51)
        Me.txtSes.Name = "txtSes"
        Me.txtSes.Size = New System.Drawing.Size(100, 26)
        Me.txtSes.TabIndex = 5
        Me.txtSes.Text = "SESSION"
        '
        'txtTerm
        '
        Me.txtTerm.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(6, 20)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(100, 26)
        Me.txtTerm.TabIndex = 4
        Me.txtTerm.Text = "TERM"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Location = New System.Drawing.Point(1014, 49)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(71, 25)
        Me.lblTerm.TabIndex = 11
        Me.lblTerm.Text = " TERM"
        '
        'lblSes
        '
        Me.lblSes.AutoSize = True
        Me.lblSes.Location = New System.Drawing.Point(1014, 21)
        Me.lblSes.Name = "lblSes"
        Me.lblSes.Size = New System.Drawing.Size(85, 25)
        Me.lblSes.TabIndex = 10
        Me.lblSes.Text = "Label11"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Location = New System.Drawing.Point(799, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "INCOME"
        '
        'lblSumIncome
        '
        Me.lblSumIncome.AutoSize = True
        Me.lblSumIncome.ForeColor = System.Drawing.Color.Red
        Me.lblSumIncome.Location = New System.Drawing.Point(888, 21)
        Me.lblSumIncome.Name = "lblSumIncome"
        Me.lblSumIncome.Size = New System.Drawing.Size(24, 25)
        Me.lblSumIncome.TabIndex = 8
        Me.lblSumIncome.Text = "0"
        '
        'dgvIncomeSummary
        '
        Me.dgvIncomeSummary.AllowUserToAddRows = False
        Me.dgvIncomeSummary.AllowUserToDeleteRows = False
        Me.dgvIncomeSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIncomeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncomeSummary.Location = New System.Drawing.Point(8, 89)
        Me.dgvIncomeSummary.Name = "dgvIncomeSummary"
        Me.dgvIncomeSummary.ReadOnly = True
        Me.dgvIncomeSummary.Size = New System.Drawing.Size(1131, 401)
        Me.dgvIncomeSummary.TabIndex = 2
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgvDebtors)
        Me.TabPage6.Location = New System.Drawing.Point(4, 37)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1137, 495)
        Me.TabPage6.TabIndex = 8
        Me.TabPage6.Text = "DEBTORS"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgvDebtors
        '
        Me.dgvDebtors.AllowUserToAddRows = False
        Me.dgvDebtors.AllowUserToDeleteRows = False
        Me.dgvDebtors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebtors.Location = New System.Drawing.Point(6, 3)
        Me.dgvDebtors.Name = "dgvDebtors"
        Me.dgvDebtors.ReadOnly = True
        Me.dgvDebtors.Size = New System.Drawing.Size(1128, 492)
        Me.dgvDebtors.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GKQS.My.Resources.Resources.icons8_add_32
        Me.PictureBox2.Location = New System.Drawing.Point(489, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GKQS.My.Resources.Resources.icons8_add_32
        Me.PictureBox1.Location = New System.Drawing.Point(23, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmAccountingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1145, 567)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAccountingSystem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.grpExpenditure.ResumeLayout(False)
        Me.grpExpenditure.PerformLayout()
        CType(Me.dgvExpenditure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvIncomeSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgvDebtors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReceiptToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebtorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvFees As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPayroll As System.Windows.Forms.DataGridView
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAssets As System.Windows.Forms.DataGridView
    Friend WithEvents dgvIncome As System.Windows.Forms.DataGridView
    Friend WithEvents dgvExpenditure As System.Windows.Forms.DataGridView
    Friend WithEvents dgvIncomeSummary As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpExpenditure As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents cbxSumTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxSumSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents lblSes As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSumIncome As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtSes As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDebtors As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblExpenditure As System.Windows.Forms.Label
    Friend WithEvents cbxClass As System.Windows.Forms.ComboBox
    Friend WithEvents rdNur As System.Windows.Forms.RadioButton
    Friend WithEvents rdCol As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxName As System.Windows.Forms.ComboBox
End Class
