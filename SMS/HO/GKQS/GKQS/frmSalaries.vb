Public Class frmSalaries
    Private ACCESS As New DBControl
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
    Private Sub frmSalaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   GET NAMES OF STAFF
       
        ACCESS.ExecQuery("SELECT * FROM [Staff_Profile]")
        If Not String.IsNullOrEmpty(ACCESS.Exception) Then MsgBox(ACCESS.Exception) : Exit Sub

        '   FILL COMBOBOX
        For Each R As DataRow In ACCESS.DBDT.Rows
            cbxStaff.Items.Add(R("Full_Name"))
        Next
        ' DISPLAY FIRST NAME FOUND
        If ACCESS.RecordCount > 0 Then cbxStaff.SelectedIndex = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' DECLARE PARAMETERS
        MessageBox.Show("SAVE?", "SALARY", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then
            ACCESS.AddParam("@SALARY", txtSalary.Text)
            ACCESS.AddParam("@NAME", cbxStaff.Text)
            ACCESS.AddParam("@ID", lblID.Text)
            'QUERY
            ACCESS.ExecQuery("UPDATE [SALARY] SET [SALARY] = @SALARY WHERE [FULL_NAME] = @NAME AND Staff_ID = @ID)")
            'SUCCESSFUL
            MessageBox.Show("ADDED SUCCESSFULLY", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSalary.Text = ""
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cbxStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStaff.SelectedIndexChanged
        Try
            With ACCESS
                .AddParam("@Name", cbxStaff.Text)
                '   QUERY
                .ExecQuery("SELECT * From Staff_Profile WHERE Full_Name = @Name")
                If Not String.IsNullOrEmpty(ACCESS.Exception) Then MsgBox(ACCESS.Exception) : Exit Sub
                If NoErrors(True) = False OrElse ACCESS.RecordCount < 1 Then Exit Sub
                'FAIL IF NO RECORDS FOUND

                If ACCESS.DBDT.Rows.Count < 1 OrElse CurrentRecord > ACCESS.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim r As DataRow = ACCESS.DBDT.Rows(CurrentRecord)
                lblID.Text = r("Staff_ID").ToString
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class