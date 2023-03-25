Public Class frmReceipt
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
    Private Sub ReportErrors()
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
    End Sub
    Public Sub ClearTextbox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Private Sub cbxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMonth.SelectedIndexChanged
        If cbxMonth.Text = "4" Or cbxMonth.Text = "6" Or cbxMonth.Text = "9" Or cbxMonth.Text = "11" Then
            cbxDay.Items.Clear()
            For x = 1 To 30
                cbxDay.Items.Add(x)
            Next x
        ElseIf cbxMonth.Text = "2" Then
            cbxDay.Items.Clear()
            For x = 1 To 29
                cbxDay.Items.Add(x)
            Next x
        Else
            cbxDay.Items.Clear()
            For x = 1 To 31
                cbxDay.Items.Add(x)
            Next x
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' trim date
        Dim m, d, y, today As String
        m = cbxMonth.Text : d = cbxDay.Text : y = txtYear.Text
        today = m & "/" & d & "/" & y
        access.AddParam("@Today", today)
        ' MessageBox.Show("hey" & today)
        access.ExecQuery("SELECT * FROM Receipt WHERE Payment_Date = @Today")

        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxReceipt.Items.Clear()
        cbxReceipt.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxReceipt.Items.Add(R("Receipt_Num"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxReceipt.SelectedIndex = 0


        dgvReceipt.DataSource = access.DBDT
        ' trim date
        Dim mm, dd, yy, todayy As String
        mm = cbxMonth.Text : dd = cbxDay.Text : yy = txtYear.Text
        todayy = m & "/" & d & "/" & y
        access.AddParam("@Today", todayy)

        access.ExecQuery("SELECT Receipt_Num, Student_Name, Payment_Date, Amount_Paid FROM Receipt WHERE Payment_Date = @Today")

        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
    End Sub

    Private Sub btnGo2_Click(sender As Object, e As EventArgs) Handles btnGo2.Click
        access.AddParam("@term", cbxTerm.Text)
        access.AddParam("@Ses", txtSes.Text)

        access.ExecQuery("SELECT Receipt_Num, Student_Name, Payment_Date, Amount_Paid FROM Receipt WHERE Term= @term AND Ses = @Ses")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        ReportErrors()

        dgvReceipt.DataSource = access.DBDT

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmAccountingSystem.Show()
    End Sub
    Private Sub reprint()
        If Me.dgvReceipt.SelectedRows.Count > 0 Then
            access.AddParam("@StrSno", Me.dgvReceipt.SelectedRows(0).Cells("Receipt_Num").Value)

            ' QUERY
            access.ExecQuery("SELECT * FROM Receipt WHERE Receipt_Num = @StrSno")

            If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
            With frmReprint
                .lblName.Text = r("Student_Name") : .lblName2.Text = r("Student_Name")
                .lblReceipt.Text = r("Receipt_Num")
                .lblDate.Text = r("Payment_Date") : .lblDate2.Text = r("Payment_Date")
                .txtAmountWords.Text = r("Amount_Words") : .txtAmountwords2.Text = r("Amount_Words")
                .lblTerm.Text = r("Term")
                .lblSes.Text = r("Ses")
                .lblClass.Text = r("Clas") : .lblClass2.Text = r("Clas")
                .lblAmount.Text = r("Amount_Paid") : .lblAmount2.Text = r("Amount_Paid")
                .Label7.Text = r("Payment_For") : .Label26.Text = r("Payment_For")
                .lblPaidBy.Text = r("Paid_By") : .lblPaidBy2.Text = r("Paid_By")
                .lblMode.Text = r("Payment_Mode") : .lblMode2.Text = r("Payment_Mode")
                .lblBank.Text = r("Bank") : .lblBank2.Text = r("Bank")
                .lblBalance.Text = r("Outstanding"):.lblBalance2.Text = r("Outstanding")
                .Show()
            End With


        End If
    End Sub
    

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        reprint()
    End Sub
End Class