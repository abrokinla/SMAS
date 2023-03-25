Public Class frmStudentSummary
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

    Private Sub rdNur_CheckedChanged(sender As Object, e As EventArgs) Handles rdNur.CheckedChanged
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

    End Sub
    Private Sub Biodata()
        access.AddParam("@Name", cbxStudents.Text)
        access.AddParam("@Class", cbxClass.Text)
        access.AddParam("@ID", lblID.Text)

        access.ExecQuery("SELECT * FROM Students Where Full_Name= @Name AND [Class]= @Class AND Student_ID=@ID")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblName.Text = r("Full_Name").ToString
        lblClass.Text = r("Class").ToString
        lblGender.Text = r("Gender").ToString
        lblDob.Text = r("Date_of_Birth").ToString
        lblNat.Text = r("Nationality").ToString
        lblState.Text = r("State").ToString
        lblLga.Text = r("LGA").ToString


    End Sub
    Private Sub GetPaymentRecord()
        'Search parameters declared
        With access
            .AddParam("@StuId", lblID.Text)
            .AddParam("@Name", lblName.Text)

            'QUERY
            .ExecQuery("SELECT * FROM Accounting WHERE StuId = @StuId AND Full_Name= @Name")
            'FAIL IF NO RECORDS FOUND
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then
                dgvSummary.DataSource = ""
            Else
                dgvSummary.DataSource = access.DBDT
            End If


        End With
    End Sub
    Private Sub GetPassport()
        With access
            .AddParam("@StuId", lblID.Text)
            .AddParam("@Name", lblName.Text)
            .AddParam("@Class", cbxClass.Text)

            'QUERY
            .ExecQuery("SELECT * FROM Students WHERE StuId = @StuId AND Full_Name= @Name AND [Class]= @Class")
            'FAIL IF NO RECORDS FOUND
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then
                lblIDtag.Text = ""
            Else
                Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
                lblIDtag.Text = r("Passport")
            End If

        End With
    End Sub
    Private Sub cbxStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStudents.SelectedIndexChanged

        access.AddParam("@StuName", cbxStudents.Text)
        access.AddParam("@Class", cbxClass.Text)
        access.ExecQuery("SELECT Student_ID FROM Students WHERE Full_Name = @StuName AND [Class] = @Class")
        'FAIL IF NO RECORDS FOUND
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID.Text = r("Student_ID")
    End Sub

    Private Sub lblID_TextChanged(sender As Object, e As EventArgs) Handles lblID.TextChanged
        Biodata()
        GetPaymentRecord()
        GetPassport()
    End Sub

    Private Sub lblIDtag_TextChanged(sender As Object, e As EventArgs) Handles lblIDtag.TextChanged
        If lblIDtag.Text <> "" Then
            picPassport.Image = Image.FromFile(lblIDtag.Text)
        Else
            picPassport.Image = picPassport.InitialImage
        End If
    End Sub


    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click
        If grpResult.Visible = False Then
            lblResult.ForeColor = Color.Blue
            grpResult.Visible = True
        Else
            grpResult.Visible = False
        End If

    End Sub

    Private Sub lblResult_MouseHover(sender As Object, e As EventArgs) Handles lblResult.MouseHover
        lblResult.ForeColor = Color.DarkMagenta
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lblFilename.Text = ""
        rdMid.Checked = False
        rdTerm.Checked = False
        cbxTerm.Text = "...TERM..."
        cbxSession.Text = "...SESSION..."
        grpResult.Visible = False
    End Sub
    Private Sub FetchResult()
        Try
            With access
                If rdMid.Checked = True Then
                    'DECLARE PARAMETERS
                    .AddParam("@Term", cbxTerm.Text)
                    .AddParam("@Ses", cbxSession.Text)
                    .AddParam("@Name", lblName.Text)
                    .AddParam("@ID", lblID.Text)

                    'QUERY
                    .ExecQuery("SELECT * FROM MidTermResult WHERE [TERM]= @Term AND [SES] = @Ses AND FNAME= @Name AND STUID= @ID")
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
                    If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
                    'FAIL IF NO RECORDS FOUND

                    If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
                    lblFilename.Text = r("RESULT")
                    lblID.Text = r("STUID")

                ElseIf rdTerm.Checked = True Then

                    'DECLARE PARAMETERS
                    .AddParam("@Term", cbxTerm.Text)
                    .AddParam("@Ses", cbxSession.Text)
                    .AddParam("@Name", lblName.Text)
                    .AddParam("@ID", lblID.Text)

                    'QUERY
                    .ExecQuery("SELECT * FROM TerminalExamResult WHERE [TERM]= @Term AND [SES] = @Ses AND FNAME= @Name AND STUID= @ID")
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
                    If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
                    'FAIL IF NO RECORDS FOUND

                    If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
                    lblFilename.Text = r("RESULT")
                    lblID.Text = r("STUID")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSession.SelectedIndexChanged
        FetchResult()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            If rdMid.Checked = True Then
                If IO.File.Exists(lblFilename.Text) Then
                    Process.Start(lblFilename.Text)

                End If
            ElseIf rdTerm.Checked = True Then
                If IO.File.Exists(lblFilename.Text) Then
                    Process.Start(lblFilename.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class