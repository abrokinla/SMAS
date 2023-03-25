Public Class frmEditPayment
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
    Private Sub rdCol_CheckedChanged(sender As Object, e As EventArgs) Handles rdCol.CheckedChanged
        If rdCol.Checked = True Then
            cbxClass.Items.Clear()
            cbxClass.Items.Add("JSS 1")
            cbxClass.Items.Add("JSS 2")
            cbxClass.Items.Add("JSS 3")
            cbxClass.Items.Add("SSS 1")
            cbxClass.Items.Add("SSS 2")
            cbxClass.Items.Add("SSS 3")
        Else
            Exit Sub
        End If

    End Sub

    Private Sub rdNur_CheckedChanged(sender As Object, e As EventArgs) Handles rdNur.CheckedChanged

        If rdNur.Checked = True Then
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
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cbxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxStudent.Items.Clear()
        cbxStudent.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxStudent.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStudent.SelectedIndex = 0
       
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbxTerm.Text = "SELECT" Or txtSes.Text = "" Then
            MessageBox.Show("SELECT A VALID TERM AND ENTER ACADEMIC SESSION", "EDIT PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbxTerm.Focus()
        Else
            With access
                .AddParam("@NAME", cbxStudent.Text)
                .AddParam("@CLASS", cbxClass.Text)
                .AddParam("@SES", txtSes.Text)
                .AddParam("@TERM", cbxTerm.Text)

                .ExecQuery("SELECT * FROM Accounting WHERE [Full_Name] = @NAME AND [Class] = @CLASS AND [Session] = @SES AND Term = @TERM")
            End With
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

            '   FILL DATAGRIDVIEW
            For Each R As DataRow In access.DBDT.Rows
                dgvAccounting.DataSource = access.DBDT
            Next
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MessageBox.Show("You are about to delete a payment entry", "EDIT PAYMENT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Windows.Forms.DialogResult.OK Then
            If Me.dgvAccounting.SelectedRows.Count > 0 Then
                access.AddParam("@StrSno", Me.dgvAccounting.SelectedRows(0).Cells("NumID").Value)

                ' QUERY
                access.ExecQuery("DELETE FROM Accounting WHERE NumID = @StrSno")
                ' SUCCESS
                MessageBox.Show("DELETED", "EDIT PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '   UPDATE OUTSTANDING
                frmUpdateOutstanding.cbxStudents.Text = cbxStudent.Text
                frmUpdateOutstanding.cbxClass.Text = cbxClass.Text
                frmUpdateOutstanding.lblID.Text = lblStuID.Text
                frmUpdateOutstanding.Show()
                Me.Close()
            Else
                Exit Sub
            End If
        Else : Exit Sub
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub cbxStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStudent.SelectedIndexChanged
        With access
            .AddParam("@Class", cbxClass.Text)
            .AddParam("@Name", cbxStudent.Text)
            .ExecQuery("SELECT * FROM Students WHERE Class = @Class AND [Full_Name] = @Name")
            Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
            lblStuID.Text = r("Student_ID")
        End With
    End Sub

End Class