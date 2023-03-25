Public Class frmSearchStudent
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
    Private Sub rdCol_CheckedChanged(sender As Object, e As EventArgs) Handles rdCol.CheckedChanged
        If rdCol.Checked = True Then
            cbxClass.Items.Clear()
            cbxClass.Items.Add("JSS 1")
            cbxClass.Items.Add("JSS 2")
            cbxClass.Items.Add("JSS 3")
            cbxClass.Items.Add("SSS 1")
            cbxClass.Items.Add("SSS 2")
            cbxClass.Items.Add("SSS 3")
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
        End If
    End Sub

    Private Sub cbxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxStudent.Items.Add(R("Full_Name"))

        Next
        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStudent.SelectedIndex = 0

    End Sub
    Private Sub GetStudent()
        ' QUERY STAFF TABLE TO FILL DATA TABLE
        If cbxStudent.Text = "" Then
            MessageBox.Show("Select Student to Edit", "SEARCH STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbxStudent.Focus()
        Else

            access.AddParam("@SearchID", cbxStudent.Text)
            access.ExecQuery("select * FROM Students WHERE [Full_Name]= @SearchID")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
            GetRecord()
        End If
    End Sub
    Private Sub GetRecord()
        'FAIL IF NO RECORDS FOUND
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'RETURN STAFF RECORDS
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)
        frmNewStudent.txtName.Text = r("Full_Name").ToString
        frmNewStudent.cbxGender.Text = r("Gender").ToString
        frmNewStudent.txtDob.Text = r("Date_of_Birth").ToString
        frmNewStudent.txtAddress.Text = r("Address").ToString
        frmNewStudent.cbxGenotype.Text = r("Genotype").ToString
        frmNewStudent.cbxBloodGroup.Text = r("Blood_Group").ToString
        frmNewStudent.txtNationality.Text = r("Nationality").ToString
        frmNewStudent.txtState.Text = r("State").ToString
        frmNewStudent.txtLGA.Text = r("LGA").ToString
        frmNewStudent.txtReligion.Text = r("Religion").ToString
        frmNewStudent.txtLastSchool.Text = r("Last_School_Attended").ToString
        frmNewStudent.txtMedicalReport.Text = r("Medical_Report").ToString
        frmNewStudent.cbxHobbies.Text = r("Hobbies").ToString
        frmNewStudent.txtParent.Text = r("Parent").ToString
        frmNewStudent.cbxFathersProfession.Text = r("Fathers_Profession").ToString
        frmNewStudent.cbxMothersProfession.Text = r("Mothers_Profession").ToString
        frmNewStudent.txtTel1.Text = r("Telephone_1").ToString
        frmNewStudent.txtTel2.Text = r("Telephone_2").ToString
        frmNewStudent.cbxClass.Text = r("Class").ToString
        frmNewStudent.lblFileName.Text = r("Passport").ToString
        If r("Status") = "Active" Then
            frmNewStudent.rdActive.Checked = True
        Else
            frmNewStudent.rdInactive.Checked = True
        End If
        frmNewStudent.lblStuID.Text = r("Student_ID").ToString
        frmNewStudent.SaveToolStripMenuItem.Enabled = False
        frmNewStudent.updateToolStripMenuItem2.Enabled = True
        frmNewStudent.cbxDay.Visible = False
        frmNewStudent.cbxMonth.Visible = False
        frmNewStudent.cbxYear.Visible = False
        frmNewStudent.btnStuID.Enabled = False
        frmNewStudent.Show()
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        GetStudent()
    End Sub
End Class