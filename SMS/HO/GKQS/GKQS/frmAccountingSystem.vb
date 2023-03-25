Public Class frmAccountingSystem
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
    Private Sub frmAccountingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   display current session and term

        access.ExecQuery("SELECT * FROM SETTINGS")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        Dim ROW As DataRow = access.DBDT(CurrentRecord)
        cbxSumTerm.Text = ROW("TERM").ToString
        cbxSumSession.Text = ROW("SESSION").ToString
        lblTerm.Text = ROW("TERM").ToString
        lblSes.Text = ROW("SESSION").ToString

        '   QUERY DISPLAY STAFF PAYROLL
        access.ExecQuery("SELECT Full_Name, Account_Name, Account_Number, Bank, SALARY  FROM [Staff_Profile]" & _
                         "INNER JOIN SALARY ON [Staff_Profile].[Staff_ID] = SALARY.[STAFF_ID]")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvPayroll.DataSource = access.DBDT

        '   QUERY DISPLAY DIFFERENT FEE
        access.ExecQuery("SELECT * FROM FEE")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvFees.DataSource = access.DBDT

        '   QUERY DISPLAY STOCK IN INVENTORY
        access.ExecQuery("SELECT * FROM STOCK")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvInventory.DataSource = access.DBDT

        '   QUERY DISPLAY SCHOOL RECORDED ASSETS
        access.ExecQuery("SELECT * FROM Asset")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvAssets.DataSource = access.DBDT

        '   declare parameter 
        access.AddParam("@Status", "Active")
        '   QUERY DISPLAY EXPECTED INCOME
        access.ExecQuery("SELECT [Student_ID], [Full_Name], Gender, Students.Class, TUITION FROM [Students] INNER JOIN FEE ON Students.Class = FEE.CLASS WHERE Status = @Status")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvIncome.DataSource = access.DBDT


        '   SUM INCOME EXPECTED FOR THE TERM
        If dgvIncome.RowCount > 1 Then
            Dim amount As Integer = 0
            For totalsum As Integer = 0 To dgvIncome.RowCount - 1
                amount += Convert.ToInt32(dgvIncome.Rows(totalsum).Cells(4).Value)
            Next
            lblIncome.Text = amount
        End If

        '   FILL INCOME FOR THE TERM
        access.AddParam("@Term", lblTerm.Text)
        access.AddParam("@Session", lblSes.Text)
        access.ExecQuery("SELECT NumID, [Full_Name], Class, [Amount_Paid], [Mode_of_Payment], [Bank_Name], [Payment_Date], Cashier  from Accounting where Term = @Term and [Session] = @Session")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvIncomeSummary.DataSource = access.DBDT

        '   FILL DEBTORS
        access.ExecQuery("SELECT * FROM OUTSTANDING WHERE Outstanding > 0")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvDebtors.DataSource = access.DBDT

        'display expenditure
        access.ExecQuery("SELECT * FROM Expenditure")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'fill datagridview
        dgvExpenditure.Visible = True
        dgvExpenditure.DataSource = access.DBDT
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If dgvExpenditure.RowCount > 0 Then
            Dim amount As Integer = 0
            For totalsum As Integer = 0 To dgvExpenditure.RowCount - 1
                amount += Convert.ToInt32(dgvExpenditure.Rows(totalsum).Cells(3).Value)
            Next
            lblExpenditure.Text = amount
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If grpFilter.Visible = False Then
            grpFilter.Visible = True
        Else : grpFilter.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cbxSumSession.Text = "SELECT" Or cbxSumTerm.Text = "SELECT" Then
            MessageBox.Show("SELECT VALID TERM AND SESSION", "EXPENDITURE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbxSumSession.Focus()
        Else
            access.AddParam("@Session", cbxSumSession.Text)
            access.AddParam("@Term", cbxSumTerm.Text)
            '   QUERY
            access.ExecQuery("SELECT * FROM Expenditure WHERE [Session] = @Session AND Term = @Term")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
            'fill datagridview
            dgvExpenditure.Visible = True
            dgvExpenditure.DataSource = access.DBDT
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If txtTerm.Text = "TERM" Or txtSes.Text = "SESSION" Then
            MessageBox.Show("Enter valid Term and Session", "INCOME SUMMARY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTerm.Focus()
        Else
            access.AddParam("@Stu_Name", cbxName.text)
            access.AddParam("@Term", UCase(txtTerm.Text))
            access.AddParam("@Session", txtSes.Text)
            access.ExecQuery("select NumID, [Full_Name], Class, [Amount_Paid], [Mode_of_Payment], [Bank_Name], [Payment_Date], Cashier  from Accounting Where [Full_Name] = @Stu_Name AND Term= @Term AND [Session] = @Session")

            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            dgvIncomeSummary.Visible = True
            dgvIncomeSummary.DataSource = access.DBDT
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        If dgvIncomeSummary.RowCount > 1 Then
            Dim amount As Integer = 0
            For totalsum As Integer = 0 To dgvIncomeSummary.RowCount - 1
                amount += Convert.ToInt32(dgvIncomeSummary.Rows(totalsum).Cells(3).Value)
            Next
            lblSumIncome.Text = amount
        End If
    End Sub

    Private Sub txtTerm_GotFocus(sender As Object, e As EventArgs) Handles txtTerm.GotFocus
        If txtTerm.Text = "TERM" Then
            txtTerm.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtTerm_LostFocus(sender As Object, e As EventArgs) Handles txtTerm.LostFocus
        If txtTerm.Text = "" Then
            txtTerm.Text = "TERM"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtSes_GotFocus(sender As Object, e As EventArgs) Handles txtSes.GotFocus
        If txtSes.Text = "SESSION" Then
            txtSes.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtSes_LostFocus(sender As Object, e As EventArgs) Handles txtSes.LostFocus
        If txtSes.Text = "" Then
            txtSes.Text = "SESSION"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DebtorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebtorsToolStripMenuItem.Click
        TabPage6.Focus()
    End Sub

    Private Sub rdCol_CheckedChanged(sender As Object, e As EventArgs) Handles rdCol.CheckedChanged

        cbxClass.Items.Clear()
        cbxClass.Items.Add("JSS 1")
        cbxClass.Items.Add("JSS 2")
        cbxClass.Items.Add("JSS 3")
        cbxClass.Items.Add("SSS 1")
        cbxClass.Items.Add("SSS 2")
        cbxClass.Items.Add("SSS 3")
    End Sub

    Private Sub rdNur_CheckedChanged(sender As Object, e As EventArgs) Handles rdNur.CheckedChanged
        cbxClass.Items.Clear()
        cbxClass.Items.Add("Créche")
        cbxClass.Items.Add("PLAYGROUP")
        cbxClass.Items.Add("KG1")
        cbxClass.Items.Add("KG2")
        cbxClass.Items.Add("KG2")
        cbxClass.Items.Add("KG3/NUR")
        cbxClass.Items.Add("PRY ONE")
        cbxClass.Items.Add("PRY TWO")
        cbxClass.Items.Add("PRY THREE")
        cbxClass.Items.Add("PRY FOUR")
        cbxClass.Items.Add("PRY FIVE")
    End Sub

    Private Sub cbxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName.Items.Clear()
        cbxName.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName.SelectedIndex = 0
        
    End Sub

    Private Sub ReceiptToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReceiptToolStripMenuItem1.Click
        frmReceipt.Show()
        Me.Hide()
    End Sub
End Class