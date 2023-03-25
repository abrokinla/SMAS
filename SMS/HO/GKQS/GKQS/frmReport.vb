Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GKQSDataSet.Staff_Profile' table. You can move, or remove it, as needed.
        Me.Staff_ProfileTableAdapter.Fill(Me.GKQSDataSet.Staff_Profile)
        'TODO: This line of code loads data into the 'GKQSDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.GKQSDataSet.Students)
        'TODO: This line of code loads data into the 'GKQSDataSet.OUTSTANDING' table. You can move, or remove it, as needed.
        Me.OUTSTANDINGTableAdapter.Fill(Me.GKQSDataSet.OUTSTANDING)
        'TODO: This line of code loads data into the 'GKQSDataSet.Accounting' table. You can move, or remove it, as needed.
        Me.AccountingTableAdapter.Fill(Me.GKQSDataSet.Accounting)

        Me.rptIncome.RefreshReport()
        Me.rptDebtors.RefreshReport()
        Me.rptStudents.RefreshReport()
        Me.rptstaff.RefreshReport()
        Me.rptPayroll.RefreshReport()
    End Sub

    Private Sub rdIncome_CheckedChanged(sender As Object, e As EventArgs) Handles rdIncome.CheckedChanged
        If rdIncome.Checked = True Then
            rptIncome.Visible = True
        Else : rptIncome.Visible = False
        End If
    End Sub

    Private Sub rdDebtors_CheckedChanged(sender As Object, e As EventArgs) Handles rdDebtors.CheckedChanged
        If rdDebtors.Checked = True Then
            rptDebtors.Visible = True
        Else : rptDebtors.Visible = False
        End If
    End Sub

    Private Sub rdStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rdStudent.CheckedChanged
        If rdStudent.Checked = True Then
            rptStudents.Visible = True
        Else : rptStudents.Visible = False
        End If
    End Sub

    Private Sub rdStaff_CheckedChanged(sender As Object, e As EventArgs) Handles rdStaff.CheckedChanged
        If rdStaff.Checked = True Then
            rptstaff.Visible = True
        Else : rptstaff.Visible = False
        End If
    End Sub

    Private Sub rdPayroll_CheckedChanged(sender As Object, e As EventArgs) Handles rdPayroll.CheckedChanged
        If rdPayroll.Checked = True Then
            rptPayroll.Visible = True
        Else : rptPayroll.Visible = False
        End If
    End Sub

    
End Class