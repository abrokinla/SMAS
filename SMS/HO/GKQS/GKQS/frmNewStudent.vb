Imports System.IO
Public Class frmNewStudent
    Private access As New DBControl
    Private CurrentRecord As Integer = 0
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(access.Exception) Then
            If Report = True Then MsgBox(access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub frmNewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 1 To 31
            cbxDay.Items.Add(x)
        Next
        For x = 2010 To 2060
            cbxYear.Items.Add(x)
        Next
        access.ExecQuery("select * FROM SETTINGS")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'declare parameters
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblTerm.Text = r("TERM").ToString
        lblSession.Text = r("SESSION").ToString


        'LOAD PASSPORT IF FOUND
        If lblFileName.Text = "" Then
            Exit Sub
        Else
            picPassport.Image = Image.FromFile(lblFileName.Text)
        End If
    End Sub

    Private Sub TextBox_Validate(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If Not String.IsNullOrWhiteSpace(txtName.Text) Then SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub NewStudent()
        ' COPY PASSPORT TO DIRECTORY
        Dim path As String = "C:\GKQSFolder\StudentPassport"
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
        Try
            If IO.File.Exists(lblFileName.Text) Then
                IO.File.Copy(lblFileName.Text, "C:\GKQSFolder\StudentPassport\" & IO.Path.GetFileName(lblFileName.Text))
                lblFileName.Text = "C:\GKQSFolder\StudentPassport\" & IO.Path.GetFileName(lblFileName.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' ADD PARAMETERS
        access.AddParam("@StuID", lblStuID.Text)
        access.AddParam("@FullName", txtName.Text)
        access.AddParam("@Address", txtAddress.Text)
        access.AddParam("@LastSchool", txtLastSchool.Text)
        access.AddParam("@DOB", cbxDay.Text & " " & cbxMonth.Text & " " & cbxYear.Text)
        access.AddParam("@State", txtState.Text)
        access.AddParam("@Gender", cbxGender.Text)
        access.AddParam("@BloodGroup", cbxBloodGroup.Text)
        access.AddParam("@Genotype", cbxGenotype.Text)
        access.AddParam("@Nationality", txtNationality.Text) ' Start here 
        access.AddParam("@MedicalReport", txtMedicalReport.Text)
        access.AddParam("@Religion", txtReligion.Text)
        access.AddParam("@LGA", txtLGA.Text)
        access.AddParam("@Hobbies", cbxHobbies.Text)
        access.AddParam("@Parent", txtParent.Text)
        access.AddParam("@FathersProfession", cbxFathersProfession.Text)
        access.AddParam("@MothersProfession", cbxMothersProfession.Text)
        access.AddParam("@Tel1", txtTel1.Text)
        access.AddParam("@Tel2", txtTel2.Text)
        access.AddParam("@Class", cbxClass.Text)
        ' access.AddParam("@Passport", picPassport.Image)
        access.AddParam("@Date", Date.Today())
        If rdActive.Checked = True Then
            access.AddParam("@Status", rdActive.Text)
        Else
            access.AddParam("@Status", rdInactive.Text)
        End If
        access.AddParam("@Passport", lblFileName.Text)
        '   EXECUTE INSERT COMMAND
        access.ExecQuery("INSERT INTO Students ([Student_ID], [Full_Name], Address, [Last_School_Attended], [Date_of_Birth], State, Gender, [Blood_Group], Genotype,  Nationality, [Medical_Report], Religion, LGA, Hobbies, Parent, [Fathers_Profession], [Mothers_Profession], [Telephone_1], [Telephone_2], [Class], [Date_of_Admission], Status, Passport)" & _
                         "VALUES (@STUID, @FullName, @Address, @LastSchool, @DOB, @State, @Gender, @BloodGroup, @Genotype, @Nationality, @MedicalReport, @Religion, @LGA, @Hobbies, @Parent, @FathersProfession, @MothersProfession, @Tel1, @Tel2, @Class, @Date, @Status, @Passport);")
        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        MsgBox("Student was added successfully")
        frmOutstanding.Show()
        Me.Close()

        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub


        '  frmStudentProfile.RefreshGrid()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        '   Instantiating a new form

        Dim frm = New frmNewStudent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        

        frmOutstanding.lblName.Text = txtName.Text
        frmOutstanding.lblClass.Text = cbxClass.Text
        frmOutstanding.lblID.Text = lblStuID.Text
        If rdCol.Checked = False And rdNP.Checked = False Then
            MsgBox("SELECT EITHER NUR/PRY OR COLLEGE", MsgBoxStyle.Exclamation, vbOKOnly)
            Exit Sub
        ElseIf lblStuID.Text = "" Then
            MsgBox("GENERATE STUDENT ID NUMBER", MsgBoxStyle.Exclamation, vbOKOnly)
            btnStuID.Focus()
        Else
            '   Adding a new student
            NewStudent()

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If OFGSelectImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            picPassport.Image = Image.FromFile(OFGSelectImage.FileName)
            'set output fields
            lblFileName.Text = OFGSelectImage.FileName.ToString
        End If
    End Sub


    Private Sub btnStuID_Click(sender As Object, e As EventArgs) Handles btnStuID.Click
       
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE NumID = (SELECT MAX(NumID) FROM Students)")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub


        '   DISPLAY LAST ROW NUMBER
        Dim Rr As DataRow = access.DBDT.Rows(CurrentRecord)

        If rdNP.Checked = True Then
            lblStuID.Text = "GKQPS" & Rr("NumID") + 1
        ElseIf rdCol.Checked = True Then
            lblStuID.Text = "GKQC" & Rr("NumID") + 1
        End If
    End Sub

    Private Sub txtTel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel1.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel2.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub rdNP_CheckedChanged(sender As Object, e As EventArgs) Handles rdNP.CheckedChanged
        If rdNP.Checked = True Then
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
        End If
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
        End If
    End Sub

    Private Sub cbxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass.SelectedIndexChanged
        lblFee.Text = vbNullChar
    End Sub

    Private Sub updateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles updateToolStripMenuItem2.Click
        Try

        
        ' ADD PARAMETERS

        access.AddParam("@FullName", txtName.Text)
        access.AddParam("@Address", txtAddress.Text)
        access.AddParam("@LastSchool", txtLastSchool.Text)
        access.AddParam("@DOB", txtDob.Text)
        access.AddParam("@State", txtState.Text)
        access.AddParam("@Gender", cbxGender.Text)
        access.AddParam("@BloodGroup", cbxBloodGroup.Text)
        access.AddParam("@Genotype", cbxGenotype.Text)
        access.AddParam("@Nationality", txtNationality.Text) ' Start here 
        access.AddParam("@MedicalReport", txtMedicalReport.Text)
        access.AddParam("@Religion", txtReligion.Text)
        access.AddParam("@LGA", txtLGA.Text)
        access.AddParam("@Hobbies", cbxHobbies.Text)
        access.AddParam("@Parent", txtParent.Text)
        access.AddParam("@FathersProfession", cbxFathersProfession.Text)
        access.AddParam("@MothersProfession", cbxMothersProfession.Text)
        access.AddParam("@Tel1", txtTel1.Text)
        access.AddParam("@Tel2", txtTel2.Text)
        access.AddParam("@Class", cbxClass.Text)
        access.AddParam("@Passport", lblFileName.Text)
        ' access.AddParam("@Date", Date.Today())
        If rdActive.Checked = True Then
            access.AddParam("@Status", rdActive.Text)
        Else
            access.AddParam("@Status", rdInactive.Text)
        End If
        access.AddParam("@StuID", lblStuID.Text)

        '   EXECUTE UPDATE COMMAND
            access.ExecQuery("UPDATE Students SET Full_Name = @FullName, Address = @Address, Last_School_Attended = @LastSchool, [Date_of_Birth] =  @DOB, State =  @State, Gender =  @Gender, Blood_Group = @BloodGroup, Genotype =  @Genotype, Nationality =  @Nationality, Medical_Report =  @MedicalReport, Religion =  @Religion, LGA =  @LGA, Hobbies = @Hobbies, Parent = @Parent, [Fathers_Profession] = @FathersProfession, [Mothers_Profession] =  @MothersProfession, [Telephone_1] = @Tel1, Telephone_2 = @Tel2, [Class] =  @Class, Passport = @Passport, Status = @Status WHERE [Student_ID] = @STUID")


        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS
            MessageBox.Show("Update successful!", "UPDATE STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmUpdateOutstanding.lblID.Text = lblStuID.Text
        frmUpdateOutstanding.cbxClass.Text = cbxClass.Text
            frmUpdateOutstanding.cbxStudents.Text = txtName.Text
            frmUpdateOutstanding.btnLoad.Visible = True
            frmUpdateOutstanding.txtOutstanding.Visible = False
            frmUpdateOutstanding.Text = "Student"
            frmUpdateOutstanding.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class