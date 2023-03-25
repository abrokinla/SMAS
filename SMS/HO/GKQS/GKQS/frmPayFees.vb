Public Class frmPayFees
    Private access As New DBControl
    Private CurrentRecord As Integer = 0
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub ReportErrors()
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
    End Sub
    Private Sub frmPayFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Accounting WHERE NumID = (SELECT MAX(NumID) FROM Accounting)")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

      
        '   FILL COMBOBOX WITH LAST ROW NUMBER
        Dim Rr As DataRow = access.DBDT.Rows(CurrentRecord)
        lblReceipt.Text = Rr("NumID")

        'QUERY DISPLAY CURRENT TERM AND SESSION
        access.ExecQuery("select * FROM SETTINGS")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'declare parameters
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblTerm.Text = r("TERM").ToString
        lblSession.Text = r("SESSION").ToString

        lblCashier.Text = frmMain.lblCashier.Text
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If rdNur.Checked = True Then
            cbxClass.Items.Clear()
            cbxClass.Items.Add("Créche")
            cbxClass.Items.Add("PLAYGROUP")
            cbxClass.Items.Add("KG1")
            cbxClass.Items.Add("KG2")
            cbxClass.Items.Add("KG3/NUR")
            cbxClass.Items.Add("PRY ONE")
            cbxClass.Items.Add("PRY TWO")
            cbxClass.Items.Add("PRY THREE")
            cbxClass.Items.Add("PRY FOUR")
            cbxClass.Items.Add("PRY FIVE")
            cbxClass.Items.Add("GRADUATED")
            grpClass.Visible = False
        Else
            cbxClass.Items.Clear()
            cbxClass.Items.Add("JSS 1")
            cbxClass.Items.Add("JSS 2")
            cbxClass.Items.Add("JSS 3")
            cbxClass.Items.Add("SSS 1")
            cbxClass.Items.Add("SSS 2")
            cbxClass.Items.Add("SSS 3")
            cbxClass.Items.Add("GRADUATED")
            grpClass.Visible = False
        End If
    End Sub

    Private Sub cbxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxStudents.Items.Clear()
        cbxStudents.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxStudents.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStudents.SelectedIndex = 0
        If cbxStudents.Text = "" Then
            grpPay.Enabled = False
        Else
            grpPay.Enabled = True
        End If
    End Sub
    Private Sub GetOutstanding()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
            .AddParam("@Name", cbxStudents.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM OUTSTANDING WHERE Class= @Class AND [FullName] = @Name")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblOutstanding.Text = r("Outstanding")
    End Sub
    Private Sub GetTuition()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblTuition.Text = r("TUITION")
    End Sub
    Private Sub cbxStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStudents.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxStudents.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblName.Text = cbxStudents.Text
        lblID.Text = r("Student_ID")
        GetOutstanding()
        GetTuition()
        grpPay.Enabled = True
    End Sub

    Private Sub lblOutstanding_TextChanged(sender As Object, e As EventArgs) Handles lblOutstanding.TextChanged
        txtTotal.Text = lblOutstanding.Text
    End Sub

    Private Sub txtDiscount_LostFocus(sender As Object, e As EventArgs) Handles txtDiscount.LostFocus
        Dim a, b As Integer
        a = txtDiscount.Text
        b = txtTotal.Text
        If txtDiscount.Text > 0 Then
            MessageBox.Show("Deduct discount from outstanding?", "DISCOUNT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Windows.Forms.DialogResult.Yes Then
                txtTotal.Text = b - a
            ElseIf a > b Then
                MessageBox.Show("Discount is greater than outstanding", "DISCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDiscount.Text = ""
            Else
                txtDiscount.Text = "0"
                txtAmount.Focus()
            End If
        End If
        ReportErrors()
    End Sub
    Private Sub GetBusFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblBus.Text = r("Am")
    End Sub
    Private Sub GetExcursionFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblExcur.Text = r("EXCURSION")
        chkExcur.Enabled = False
    End Sub
    Private Sub GetPartyFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblParty.Text = r("PARTY")
        chkParty.Enabled = False
    End Sub
    Private Sub GetVSFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblVS.Text = r("VS")
        chkVs.Enabled = False
    End Sub
    Private Sub GetRegFormFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblReg.Text = r("REG_FORM")
        chkRegForm.Enabled = False
    End Sub
    Private Sub FetchLibFee()

        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblLib.Text = r("LIBRARY")
        chkLib.Enabled = False
    End Sub
    Private Sub FetchScienceFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblSci.Text = r("SCIENCE")
        chkSci.Enabled = False
    End Sub
    Private Sub GetHostelFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblHostel.Text = r("HOSTEL")
        chkHostel.Enabled = False
    End Sub

    Private Sub GetOthersFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblOthers.Text = r("OTHERS")
        chkOthers.Enabled = False
    End Sub
    Private Sub GetUniformFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblUniform.Text = r("UNIFORM")
        chkUniform.Enabled = False
    End Sub
    Private Sub GetCardiganFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblCardigan.Text = r("CARDIGAN")
        chkCardigan.Enabled = False
    End Sub
    Private Sub GetPoloFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblPolo.Text = r("POLO")
        chkPolo.Enabled = False
    End Sub
    Private Sub GetSports1Fee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblSports1.Text = r("SPORTS_1")
        chkSports1.Enabled = False
    End Sub
    Private Sub GetSports2Fee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblSports2.Text = r("SPORTS_2")
        chkSports2.Enabled = False
    End Sub
    Private Sub GetIDCARDFee()
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID2.Text = r("ID_CARD")
        chkID.Enabled = False
    End Sub

    Private Sub lblBus_TextChanged(sender As Object, e As EventArgs) Handles lblBus.TextChanged
        Dim a, b As Integer
        access.AddParam("@Class", cbxClass.Text)
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        a = txtTotal.Text : b = r("PM")
        txtTotal.Text = a + b
    End Sub

    Private Sub chkBus_CheckedChanged(sender As Object, e As EventArgs) Handles chkBus.CheckedChanged
        If chkBus.Checked = True Then
            grpBus.Visible = True
        Else
            grpBus.Visible = False
        End If
        ' GetBusFee()
        chkBus.Enabled = False
    End Sub


    Private Sub lblExcur_TextChanged(sender As Object, e As EventArgs) Handles lblExcur.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblExcur.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkExcur_CheckedChanged(sender As Object, e As EventArgs) Handles chkExcur.CheckedChanged
        GetExcursionFee()
    End Sub

    Private Sub lblParty_TextChanged(sender As Object, e As EventArgs) Handles lblParty.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblParty.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkParty_CheckedChanged(sender As Object, e As EventArgs) Handles chkParty.CheckedChanged
        GetPartyFee()
    End Sub

    Private Sub lblVS_TextChanged(sender As Object, e As EventArgs) Handles lblVS.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblVS.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkVs_CheckedChanged(sender As Object, e As EventArgs) Handles chkVs.CheckedChanged
        GetVSFee()
    End Sub

    Private Sub lblReg_TextChanged(sender As Object, e As EventArgs) Handles lblReg.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblReg.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkRegForm_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegForm.CheckedChanged
        GetRegFormFee()
    End Sub

    Private Sub lblOthers_Click(sender As Object, e As EventArgs) Handles lblOthers.Click

    End Sub

    Private Sub chkOthers_CheckedChanged(sender As Object, e As EventArgs) Handles chkOthers.CheckedChanged
        GetOthersFee()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmount_LostFocus(sender As Object, e As EventArgs) Handles txtAmount.LostFocus
        Dim a, b As Integer
        If txtAmount.Text = "" Or txtTotal.Text = "" Then
            Exit Sub
        End If
        a = txtAmount.Text
        b = txtTotal.Text
        '   CALCULATE NEW OUTSTANDING
        If a > b Then
            MessageBox.Show("Invalid amount, Amount paid is greater than outstanding", "PAY FEES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmount.Focus()
        ElseIf txtAmount.Text = "" Or txtTotal.Text = "" Then
            Exit Sub
        Else
            lblOldAmount.Text = txtTotal.Text
            lblAmountPaid.Text = txtAmount.Text
            lblNewOust.Text = b - a
        End If
    End Sub

    Private Sub rdTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rdTransfer.CheckedChanged
        If rdTransfer.Checked = True Then
            txtBankName.Visible = True
        ElseIf rdCash.Checked = True Then
            txtBankName.Text = ""
            txtBankName.Visible = False
        End If
    End Sub

    Private Sub rdBank_CheckedChanged(sender As Object, e As EventArgs) Handles rdBank.CheckedChanged
        If rdBank.Checked = True Then
            txtBankName.Visible = True
        ElseIf rdCash.Checked = True Then
            txtBankName.Text = ""
            txtBankName.Visible = False
        End If
    End Sub

    Private Sub NewPayment()
        Dim A, receipt As String
        A = Date.Now.ToString("yyyy")
        receipt = "GKQS/" & A & "/" & lblReceipt.Text + 1
        '   DECLARE PARAMETERS

        access.AddParam("@StuID", lblID.Text)
        access.AddParam("@FName", lblName.Text)
        access.AddParam("@Class", cbxClass.Text)
        access.AddParam("@Session", lblSession.Text)
        access.AddParam("@Term", lblTerm.Text)
        access.AddParam("@Fees", lblTuition.Text)
        access.AddParam("@Discount", txtDiscount.Text)
        access.AddParam("@AmountPaid", txtAmount.Text)
        access.AddParam("@OldOuts", txtTotal.Text)
        access.AddParam("@NewOuts", lblNewOust.Text)
        If rdCash.Checked = True Then
            access.AddParam("@Mode", rdCash.Text)
        ElseIf rdTransfer.Checked = True Then
            access.AddParam("@Mode", rdTransfer.Text)
        ElseIf rdBank.Checked = True Then
            access.AddParam("@Mode", rdBank.Text)
        End If
        If rdSingle.Checked = True Then
            access.AddParam("@Type", rdSingle.Text)
        Else
            access.AddParam("@Type", rdInstallment.Text)
        End If
        access.AddParam("@BankName", txtBankName.Text)
        If chkFirst.Checked = True Then
            access.AddParam("@FirstTime", True)
        Else
            access.AddParam("@FirstTime", False)
        End If
        access.AddParam("@PaymentDate", Date.Now.ToString("MM-dd-yyyy"))
        access.AddParam("@PaidBy", txtPaidby.Text)
        access.AddParam("@Cashier", lblCashier.Text)
        access.AddParam("@receipt", receipt)

        '   QUERY
        access.ExecQuery("INSERT INTO Accounting ([StuId], [Full_Name], [Class], [Session], Term, Fees, Discount, [Amount_Paid],[Old_Outstanding], [New_Outstanding], [Mode_of_Payment], [PaymentType], [Bank_Name], [First_Time], [Payment_Date], [Paid_By], Cashier, Receipt_Number)" & _
                             "VALUES (@StuID, @FName, @Class, @Session, @Term, @Fees, @Discount, @AmountPaid, @OldOuts, @NewOuts, @Mode, @Type, @BankName, @FirstTime, @PaymentDate, @PaidBy, @Cashier, @receipt);")
        ReportErrors()
        With access
            .AddParam("@NewOuts", lblNewOust.Text)
            .AddParam("@StuID", lblID.Text)
        End With
        access.ExecQuery("UPDATE OUTSTANDING SET Outstanding = @NewOuts WHERE STUID = @StuID")
        ReportErrors()
        '   SUCCESS
        MessageBox.Show("Payment Successful!", "FEE PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'PRINT RECEIPT
        PrintReciept()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim i As Integer
        i = MsgBox("MAKE PAYMENT?", vbYesNo)
        If i = vbYes Then
            NewPayment()
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtBankName_GotFocus(sender As Object, e As EventArgs) Handles txtBankName.GotFocus
        If txtBankName.Text = "Bank Name" Then
            txtBankName.Text = ""
        ElseIf txtAmount.TextLength < 4 Then
            MessageBox.Show("Invalid amount!", "PAY FEES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAmount.Focus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtBankName_LostFocus(sender As Object, e As EventArgs) Handles txtBankName.LostFocus
        If txtBankName.Text = "" Then
            txtBankName.Text = "Bank Name"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub chkFirst_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirst.CheckedChanged
        Dim a, b, c As Integer
        a = lblTuition.Text : b = lblOutstanding.Text
        If chkFirst.Checked = True Then
            a = txtDiscount.Text : b = lblOutstanding.Text : c = lblTuition.Text
            txtTotal.Text = (c + b) - a
            grpOther.Enabled = True
        ElseIf txtDiscount.Text <> 0 And chkFirst.Checked = False Then
            a = txtDiscount.Text : b = lblOutstanding.Text
            txtTotal.Text = b - a
            grpOther.Enabled = True
        ElseIf chkFirst.Checked = False Then
            grpOther.Enabled = True
            txtTotal.Text = lblOutstanding.Text
            txtDiscount.Text = "0"
        End If
    End Sub
    Private Sub PrintReciept()
        frmPrintReciept.lblName.Text = lblName.Text
        frmPrintReciept.lblName2.Text = cbxStudents.Text
        frmPrintReciept.lblPaidBy.Text = txtPaidby.Text
        frmPrintReciept.lblPaidBy2.Text = txtPaidby.Text
        frmPrintReciept.lblClass.Text = cbxClass.Text
        frmPrintReciept.lblClass2.Text = cbxClass.Text
        frmPrintReciept.Label7.Text = frmPrintReciept.Label7.Text & " FOR " & lblTerm.Text & " " & "TERM" & " " & lblSession.Text
        frmPrintReciept.Label26.Text = frmPrintReciept.Label26.Text & " FOR " & lblTerm.Text & " " & "TERM" & " " & lblSession.Text
        frmPrintReciept.lblAmount.Text = txtAmount.Text & ".00"
        frmPrintReciept.lblAmount2.Text = txtAmount.Text & ".00"
        frmPrintReciept.lblBalance.Text = lblNewOust.Text & ".00 NGN"
        frmPrintReciept.lblBalance2.Text = lblNewOust.Text & ".00 NGN"
        frmPrintReciept.lblTerm.Text = lblTerm.Text
        frmPrintReciept.lblSes.Text = lblSession.Text
        Dim mode As String
        If rdBank.Checked = True Then
            mode = rdBank.Text
            frmPrintReciept.lblMode.Text = mode
            frmPrintReciept.lblMode2.Text = mode
            frmPrintReciept.lblBank.Text = txtBankName.Text
            frmPrintReciept.lblBank2.Text = txtBankName.Text
        ElseIf rdCash.Checked = True Then
            mode = rdCash.Text
            frmPrintReciept.lblMode.Text = mode
            frmPrintReciept.lblMode2.Text = mode
            frmPrintReciept.Label21.Visible = False
            frmPrintReciept.Label25.Visible = False
        Else
            mode = rdTransfer.Text
            frmPrintReciept.lblMode.Text = mode
            frmPrintReciept.lblMode2.Text = mode
            frmPrintReciept.lblBank.Text = txtBankName.Text
            frmPrintReciept.lblBank2.Text = txtBankName.Text
        End If
        frmPrintReciept.Show()
    End Sub

    Private Sub chkAm_CheckedChanged(sender As Object, e As EventArgs) Handles chkAm.CheckedChanged

        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        Dim a, b As Integer

        a = r("Am")
        b = lblBus.Text
        lblBus.Text = a + b
        chkAm.Enabled = False
    End Sub

    Private Sub chkPm_CheckedChanged(sender As Object, e As EventArgs) Handles chkPm.CheckedChanged
        ' DECLARE PARAMETERS
        With access
            .AddParam("@Class", cbxClass.Text)
        End With
        ' QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE Class= @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        Dim a, b As Integer

        a = r("Pm")
        b = lblBus.Text
        lblBus.Text = a + b
        chkPm.Enabled = False
    End Sub

    Private Sub lblOthers_TextChanged(sender As Object, e As EventArgs) Handles lblOthers.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblOthers.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub lblHostel_TextChanged(sender As Object, e As EventArgs) Handles lblHostel.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblHostel.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkHostel_CheckedChanged(sender As Object, e As EventArgs) Handles chkHostel.CheckedChanged
        GetHostelFee()
    End Sub


    Private Sub lblCardigan_TextChanged(sender As Object, e As EventArgs) Handles lblCardigan.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblCardigan.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub lblPolo_TextChanged(sender As Object, e As EventArgs) Handles lblPolo.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblPolo.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub lblSports1_TextChanged(sender As Object, e As EventArgs) Handles lblSports1.TextChanged
        Dim a, b As Integer
        a = CInt(txtTotal.Text) : b = lblSports1.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub lblSports2_TextChanged(sender As Object, e As EventArgs) Handles lblSports2.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblSports2.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub lblID2_TextChanged(sender As Object, e As EventArgs) Handles lblID2.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text : b = lblID2.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkUniform_CheckedChanged(sender As Object, e As EventArgs) Handles chkUniform.CheckedChanged
        GetUniformFee()
    End Sub

    Private Sub chkCardigan_CheckedChanged(sender As Object, e As EventArgs) Handles chkCardigan.CheckedChanged
        GetCardiganFee()
    End Sub

    Private Sub chkPolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPolo.CheckedChanged
        GetPoloFee()
    End Sub

    Private Sub chkSports1_CheckedChanged(sender As Object, e As EventArgs) Handles chkSports1.CheckedChanged
        GetSports1Fee()
    End Sub

    Private Sub chkSports2_CheckedChanged(sender As Object, e As EventArgs) Handles chkSports2.CheckedChanged
        GetSports2Fee()
    End Sub

    Private Sub chkID_CheckedChanged(sender As Object, e As EventArgs) Handles chkID.CheckedChanged
        GetIDCARDFee()
    End Sub

    Private Sub lblUniform_TextChanged(sender As Object, e As EventArgs) Handles lblUniform.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text
        b = lblUniform.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub lblLib_TextChanged(sender As Object, e As EventArgs) Handles lblLib.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text
        b = lblLib.Text
        txtTotal.Text = a + b
    End Sub
    Private Sub LBLSCI_TEXTCHANGED(SENDER As Object, E As EventArgs) Handles lblSci.TextChanged
        Dim a, b As Integer
        a = txtTotal.Text
        b = lblSci.Text
        txtTotal.Text = a + b
    End Sub

    Private Sub chkLib_CheckedChanged(sender As Object, e As EventArgs) Handles chkLib.CheckedChanged
        FetchLibFee()
    End Sub

    Private Sub chkSci_CheckedChanged(sender As Object, e As EventArgs) Handles chkSci.CheckedChanged
        FetchScienceFee()
    End Sub
End Class