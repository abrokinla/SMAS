Imports System.IO
Public Class frmResultEdit
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

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UploadDelete()
        MessageBox.Show("SUCCESSFUL!")
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

    Private Sub CheckRecord()
        Try
            With access
                If rdMid.Checked = True Then
                    'DECLARE PARAMETERS
                    .AddParam("@Term", cbxTerm.Text)
                    .AddParam("@Ses", txtSes.Text)
                    .AddParam("@Name", cbxStudent.Text)
                    .AddParam("@Class", cbxClass.Text)

                    'QUERY
                    .ExecQuery("SELECT * FROM MidTermResult WHERE [TERM]= @Term AND [SES] = @Ses AND FNAME= @Name")
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
                    If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
                    'FAIL IF NO RECORDS FOUND

                    If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
                    lblFilename.Text = r("RESULT")
                    lblID.Text = r("STUID")

                ElseIf rdExam.Checked = True Then

                    'DECLARE PARAMETERS
                    .AddParam("@Term", cbxTerm.Text)
                    .AddParam("@Ses", txtSes.Text)
                    .AddParam("@Name", cbxStudent.Text)
                    .AddParam("@Class", cbxClass.Text)

                    'QUERY
                    .ExecQuery("SELECT * FROM TerminalExamResult WHERE [TERM]= @Term AND [SES] = @Ses AND FNAME= @Name")
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmResults.Show()
        Close()
    End Sub

    Private Sub cbxStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStudent.SelectedIndexChanged
        CheckRecord()
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

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblFilename1.Text = openfiledialog.FileName.ToString
                lblFilename1.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub UploadDelete()
        Try
            If rdMid.Checked = True Then
                If IO.File.Exists(lblFilename.Text) Then
                    IO.File.Delete("C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblFilename.Text))
                    IO.File.Copy(lblFilename1.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblFilename1.Text))
                    lblFilename1.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblFilename1.Text)
                End If
            ElseIf rdExam.Checked = True Then
                If IO.File.Exists(lblFilename.Text) Then
                    IO.File.Delete("C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblFilename.Text))
                    IO.File.Copy(lblFilename1.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblFilename1.Text))
                    lblFilename1.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblFilename1.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        Try
            With access
                If rdMid.Checked = True Then
                    'DECLARE PARAMETERS
                    .AddParam("@Result", lblFilename1.Text)
                    .AddParam("@ID", lblID.Text)
                    .AddParam("@Name", cbxStudent.Text)
                    .AddParam("@Class", cbxClass.Text)
                    .AddParam("@Term", cbxTerm.Text)
                    .AddParam("@Ses", txtSes.Text)

                    'QUERY
                    .ExecQuery("UPDATE MidTermResult SET RESULT = @Result WHERE STUID = @ID AND FNAME= @Name AND [CLASS] = @Class AND [TERM] = @Term AND SES = @Ses")
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
                    MessageBox.Show("Successful!")
                ElseIf rdExam.Checked = True Then
                    'DECLARE PARAMETERS
                    .AddParam("@Result", lblFilename1.Text)
                    .AddParam("@ID", lblID.Text)
                    .AddParam("@Name", cbxStudent.Text)
                    .AddParam("@Class", cbxClass.Text)
                    .AddParam("@Term", cbxTerm.Text)
                    .AddParam("@Ses", txtSes.Text)

                    'QUERY
                    .ExecQuery("UPDATE TerminalExamResult SET RESULT = @Result WHERE STUID = @ID AND FNAME= @Name AND [CLASS] = @Class AND [TERM] = @Term AND SES = @Ses")
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
                    MessageBox.Show("Successful!")
                End If

            End With

        Catch EX As Exception
            MessageBox.Show(EX.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            If rdMid.Checked = True Then
                If IO.File.Exists(lblFilename.Text) Then
                    Process.Start(lblFilename.Text)

                End If
            ElseIf rdExam.Checked = True Then
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