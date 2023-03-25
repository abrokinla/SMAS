Public Class frmMain
    Private ACCESS As New DBControl
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
    Private Sub lnkAccounting_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAccounting.LinkClicked
        'frmTrial.Show()
        frmAccountingSystem.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ACCESS.AddParam("@ID", "1")
            ACCESS.ExecQuery("Select News FROM News WHERE ID= @ID")
            'FAIL IF NO RECORDS FOUND

            If ACCESS.DBDT.Rows.Count < 1 OrElse CurrentRecord > ACCESS.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim r As DataRow = ACCESS.DBDT.Rows(CurrentRecord)

            lblNews.Text = r("News").ToString
            lblNews.Parent = pnlNews
            lblNews.Location = New Point(pnlNews.ClientSize.Width, pnlNews.ClientSize.Height / 2 - (lblNews.Height / 2))
            Timer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblNews.Right < 0 Then
            lblNews.Left = pnlNews.ClientSize.Width
        Else
            lblNews.Left -= 10
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim x As Integer
        x = MsgBox("Are you sure you want to exit", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Alert")
        If x = vbYes Then End
    End Sub

    
    Private Sub lnkCalender_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCalender.LinkClicked
        frmTrial.Show()
    End Sub
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

   

    Private Sub lnkAdmission_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAdmission.LinkClicked
        frmNewStudent.Show()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        frmNewStudent.Show()
    End Sub

    Private Sub UpdateNewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateNewsToolStripMenuItem.Click
        frmNewsUpdate.Show()
    End Sub

    Private Sub lnkProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkProfile.LinkClicked
        frmStudentProfile.Show()
    End Sub

    Private Sub lnkPayments_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPayments.LinkClicked
        frmPayFees.Show()
    End Sub

    Private Sub lnkAssignments_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAssignments.LinkClicked
        frmStudentSummary.Show()
    End Sub

    Private Sub lnkResults_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkResults.LinkClicked
        frmResults.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub lnkNewStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNewStaff.LinkClicked
        'frmTrial.Show()
        frmNewStaff.Show()
    End Sub

    Private Sub lnkStaffProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStaffProfile.LinkClicked
        'frmTrial.Show()
        frmStudentProfile.Text = "Staff Profile"
        frmStudentProfile.Show()
    End Sub

    Private Sub lnkSalaries_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSalaries.LinkClicked
        frmTrial.Show()
    End Sub

    Private Sub NewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStaffToolStripMenuItem.Click
        frmTrial.Show()
    End Sub
    Private Sub lnkedit_linkClicked(sender As Object, e As EventArgs) Handles lnkEdit.LinkClicked
        frmStaffSearch.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        frmInventory.Show()
    End Sub

    Private Sub lnkInventory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAddNew.LinkClicked
        frmInventory.Show()
    End Sub

    Private Sub lnkUpdateStock_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUpdateStock.LinkClicked
        frmUpdate.Show()
    End Sub

    Private Sub lnkStockSum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStockSum.LinkClicked
        frmStockSum.Show()
    End Sub


    Private Sub lnkAssets_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAssets.LinkClicked
        'frmTrial.Show()
        frmAssets.Show()
    End Sub

    Private Sub lnkExpenditure_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkExpenditure.LinkClicked
        'frmTrial.Show()
        frmExpenditure.Show()
    End Sub

    Private Sub lnkLibrary_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLibrary.LinkClicked
        frmTrial.Show()
    End Sub

    Private Sub lnkBudget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBudget.LinkClicked
        frmTrial.Show()
    End Sub

   
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.Show()
    End Sub

    Private Sub lnkSales_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSales.LinkClicked
        frmSales.Show()
    End Sub

    Private Sub lnkedit_linkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEdit.LinkClicked
        'frmTrial.Show()
        frmStaffSearch.Show()
    End Sub

    Private Sub lnkPayroll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPayroll.LinkClicked
        'frmTrial.Show()
        frmPayroll.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        frmLock.Show()
    End Sub

    Private Sub lnkEditStudent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEditStudent.LinkClicked
        frmSearchStudent.Show()
    End Sub

    Private Sub lnkDailySales_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDailySales.LinkClicked
        frmdailysales.show()
    End Sub

    Private Sub EditPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPaymentToolStripMenuItem.Click
        frmExecLogin.Text = "EDIT PAYMENT"
        frmExecLogin.Show()
    End Sub

    Private Sub UpdateOutstandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateOutstandingToolStripMenuItem.Click
        frmExecLogin.Text = "UPDATE OUTSTANDING"
        frmExecLogin.Show()
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        frmReport.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click

    End Sub


End Class
