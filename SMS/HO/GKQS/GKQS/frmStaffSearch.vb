Public Class frmStaffSearch
    Private Access As New DBControl
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
   
    Private Sub btnCLear_Click(sender As Object, e As EventArgs) Handles btnCLear.Click
        txtSearch.Text = ""
    End Sub
    Private Sub GetStaff()
        ' QUERY STAFF TABLE TO FILL DATA TABLE
        If txtSearch.Text = "" Then
            MessageBox.Show("ENTER STAFF ID", "SEARCH STAFF", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearch.Focus()
        Else

            Access.AddParam("@SearchID", txtSearch.Text)
            Access.ExecQuery("select * FROM [Staff_Profile] WHERE [Staff_ID]= @SearchID")
            If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
            GetRecord()
        End If

    End Sub
    Private Sub GetRecord()
        'FAIL IF NO RECORDS FOUND
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'RETURN STAFF RECORDS
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)
        frmNewStaff.txtFname.Text = r("Full_Name").ToString
        frmNewStaff.txtState.Text = r("State_of_Origin").ToString
        frmNewStaff.txtAddress.Text = r("Address").ToString
        frmNewStaff.txtEmail.Text = r("Email_Address").ToString
        frmNewStaff.txtNationality.Text = r("Nationality").ToString
        frmNewStaff.txtLGA.Text = r("LGA").ToString
        frmNewStaff.txtSchlGrad.Text = r("School_Graduated").ToString
        frmNewStaff.txtTel1.Text = r("Telephone_1").ToString
        frmNewStaff.txtTel2.Text = r("Telephone_2").ToString
        frmNewStaff.txtNok.Text = r("Kin").ToString
        frmNewStaff.txtTelNok.Text = r("Kin_Telephone").ToString
        frmNewStaff.txtDOB.Text = r("Date_of_Birth").ToString
        frmNewStaff.lblStaffID.Text = r("Staff_ID").ToString
        frmNewStaff.cbxGender.Text = r("Gender").ToString
        frmNewStaff.cbxReligion.Text = r("Religion").ToString
        frmNewStaff.txtQual.Text = r("Qualification").ToString
        frmNewStaff.txtBank.Text = r("Bank").ToString
        frmNewStaff.txtAcctName.Text = r("Account_Name").ToString
        frmNewStaff.txtAcctNo.Text = r("Account_Number").ToString
        frmNewStaff.txtDateEmp.Text = r("Date_employed").ToString
        frmNewStaff.txtDOB.Visible = True
        frmNewStaff.txtDateEmp.Visible = True
        frmNewStaff.cbxDay.Visible = False
        frmNewStaff.cbxDay2.Visible = False
        frmNewStaff.cbxMonth.Visible = False
        frmNewStaff.cbxMonth2.Visible = False
        frmNewStaff.cbxYear.Visible = False
        frmNewStaff.cbxYear2.Visible = False
        frmNewStaff.btnID.Enabled = False
        frmNewStaff.UPDATEToolStripMenuItem.Enabled = True
        frmNewStaff.Save2ToolStripMenuItem.Enabled = False
        frmNewStaff.DELETEToolStripMenuItem.Enabled = True
        frmNewStaff.Show()
        Me.Close()

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetStaff()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmStaffSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Access.ExecQuery("select * FROM [Staff_Profile]")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        cbxStaff.Text = ""
        cbxStaff.Items.Clear()
        '   FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxStaff.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If Access.RecordCount > 0 Then cbxStaff.SelectedIndex = 0
    End Sub

    Private Sub cbxStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStaff.SelectedIndexChanged
        Access.AddParam("@SearchID", cbxStaff.Text)
        Access.ExecQuery("select * FROM [Staff_Profile] WHERE Full_Name = @SearchID")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'FAIL IF NO RECORDS FOUND
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'RETURN STAFF RECORDS
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)
        txtSearch.Text = r("Staff_ID").ToString
    End Sub
End Class