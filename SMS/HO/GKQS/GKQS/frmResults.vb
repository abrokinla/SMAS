Imports System.IO
Public Class frmResults
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

    Private Sub frmResultExamJnr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'QUERY DISPLAY CURRENT TERM AND SESSION
        access.ExecQuery("select * FROM SETTINGS")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'declare parameters
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblTerm.Text = r("TERM").ToString
        lblSession.Text = r("SESSION").ToString

    End Sub

    Private Sub rdNp_CheckedChanged(sender As Object, e As EventArgs) Handles rdNp.CheckedChanged
        If rdNp.Checked = True Then
            cbxClass1.Items.Clear()
            cbxClass1.Items.Add("Créche")
            cbxClass1.Items.Add("PLAYGROUP")
            cbxClass1.Items.Add("KG1")
            cbxClass1.Items.Add("KG2")
            cbxClass1.Items.Add("KG3/NUR")
            cbxClass1.Items.Add("PRY ONE")
            cbxClass1.Items.Add("PRY TWO")
            cbxClass1.Items.Add("PRY THREE")
            cbxClass1.Items.Add("PRY FOUR")
            cbxClass1.Items.Add("PRY FIVE")

            cbxClass2.Items.Clear()
            cbxClass2.Items.Add("Créche")
            cbxClass2.Items.Add("PLAYGROUP")
            cbxClass2.Items.Add("KG1")
            cbxClass2.Items.Add("KG2")
            cbxClass2.Items.Add("KG3/NUR")
            cbxClass2.Items.Add("PRY ONE")
            cbxClass2.Items.Add("PRY TWO")
            cbxClass2.Items.Add("PRY THREE")
            cbxClass2.Items.Add("PRY FOUR")
            cbxClass2.Items.Add("PRY FIVE")

            cbxClass3.Items.Clear()
            cbxClass3.Items.Add("Créche")
            cbxClass3.Items.Add("PLAYGROUP")
            cbxClass3.Items.Add("KG1")
            cbxClass3.Items.Add("KG2")
            cbxClass3.Items.Add("KG3/NUR")
            cbxClass3.Items.Add("PRY ONE")
            cbxClass3.Items.Add("PRY TWO")
            cbxClass3.Items.Add("PRY THREE")
            cbxClass3.Items.Add("PRY FOUR")
            cbxClass3.Items.Add("PRY FIVE")

            cbxClass4.Items.Clear()
            cbxClass4.Items.Add("Créche")
            cbxClass4.Items.Add("PLAYGROUP")
            cbxClass4.Items.Add("KG1")
            cbxClass4.Items.Add("KG2")
            cbxClass4.Items.Add("KG3/NUR")
            cbxClass4.Items.Add("PRY ONE")
            cbxClass4.Items.Add("PRY TWO")
            cbxClass4.Items.Add("PRY THREE")
            cbxClass4.Items.Add("PRY FOUR")
            cbxClass4.Items.Add("PRY FIVE")

            cbxClass5.Items.Clear()
            cbxClass5.Items.Add("Créche")
            cbxClass5.Items.Add("PLAYGROUP")
            cbxClass5.Items.Add("KG1")
            cbxClass5.Items.Add("KG2")
            cbxClass5.Items.Add("KG3/NUR")
            cbxClass5.Items.Add("PRY ONE")
            cbxClass5.Items.Add("PRY TWO")
            cbxClass5.Items.Add("PRY THREE")
            cbxClass5.Items.Add("PRY FOUR")
            cbxClass5.Items.Add("PRY FIVE")

            cbxClass6.Items.Clear()
            cbxClass6.Items.Add("Créche")
            cbxClass6.Items.Add("PLAYGROUP")
            cbxClass6.Items.Add("KG1")
            cbxClass6.Items.Add("KG2")
            cbxClass6.Items.Add("KG3/NUR")
            cbxClass6.Items.Add("PRY ONE")
            cbxClass6.Items.Add("PRY TWO")
            cbxClass6.Items.Add("PRY THREE")
            cbxClass6.Items.Add("PRY FOUR")
            cbxClass6.Items.Add("PRY FIVE")
        End If

    End Sub

    Private Sub rdCol_CheckedChanged(sender As Object, e As EventArgs) Handles rdCol.CheckedChanged
        If rdCol.Checked = True Then
            cbxClass1.Items.Clear()
            cbxClass1.Items.Add("JSS 1")
            cbxClass1.Items.Add("JSS 2")
            cbxClass1.Items.Add("JSS 3")
            cbxClass1.Items.Add("SSS 1")
            cbxClass1.Items.Add("SSS 2")
            cbxClass1.Items.Add("SSS 3")


            cbxClass2.Items.Clear()
            cbxClass2.Items.Add("JSS 1")
            cbxClass2.Items.Add("JSS 2")
            cbxClass2.Items.Add("JSS 3")
            cbxClass2.Items.Add("SSS 1")
            cbxClass2.Items.Add("SSS 2")
            cbxClass2.Items.Add("SSS 3")

            cbxClass3.Items.Clear()
            cbxClass3.Items.Add("JSS 1")
            cbxClass3.Items.Add("JSS 2")
            cbxClass3.Items.Add("JSS 3")
            cbxClass3.Items.Add("SSS 1")
            cbxClass3.Items.Add("SSS 2")
            cbxClass3.Items.Add("SSS 3")

            cbxClass4.Items.Clear()
            cbxClass4.Items.Add("JSS 1")
            cbxClass4.Items.Add("JSS 2")
            cbxClass4.Items.Add("JSS 3")
            cbxClass4.Items.Add("SSS 1")
            cbxClass4.Items.Add("SSS 2")
            cbxClass4.Items.Add("SSS 3")

            cbxClass5.Items.Clear()
            cbxClass5.Items.Add("JSS 1")
            cbxClass5.Items.Add("JSS 2")
            cbxClass5.Items.Add("JSS 3")
            cbxClass5.Items.Add("SSS 1")
            cbxClass5.Items.Add("SSS 2")
            cbxClass5.Items.Add("SSS 3")

            cbxClass6.Items.Clear()
            cbxClass6.Items.Add("JSS 1")
            cbxClass6.Items.Add("JSS 2")
            cbxClass6.Items.Add("JSS 3")
            cbxClass6.Items.Add("SSS 1")
            cbxClass6.Items.Add("SSS 2")
            cbxClass6.Items.Add("SSS 3")
        End If
    End Sub

    Private Sub btnUpload1_Click(sender As Object, e As EventArgs) Handles btnUpload1.Click
        Try
            With access


                ' CHECK FOR DUPLICATE RESULT
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName1.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName1.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                ' COPY RESULT TO DIRECTORY

10:             If cbxExam.Text = "MID TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes1.Text) Then
                            IO.File.Copy(lblRes1.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes1.Text))
                            lblRes1.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes1.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes1.Text) Then
                            IO.File.Copy(lblRes1.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes1.Text))
                            lblRes1.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes1.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                    Exit Sub
                End If
                'SAVE RESULT DETAILS IN DBS
                'DECLARE PARAMETERS
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName1.Text)
                    .AddParam("@Class", cbxClass1.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes1.Text)
                    .AddParam("@ID", lblID1.Text)

                    'QUERY
                    .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")

                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName1.Text)
                    .AddParam("@Class", cbxClass1.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes1.Text)
                    .AddParam("@ID", lblID1.Text)
                    .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")
                Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cbxClass1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass1.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass1.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName1.Items.Clear()
        cbxName1.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName1.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName1.SelectedIndex = 0
    End Sub

    Private Sub cbxClass2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass2.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass2.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName2.Items.Clear()
        cbxName2.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName2.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName2.SelectedIndex = 0
    End Sub

    Private Sub cbxClass3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass3.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass3.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName3.Items.Clear()
        cbxName3.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName3.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName3.SelectedIndex = 0
    End Sub

    Private Sub cbxClass4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass4.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass4.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName4.Items.Clear()
        cbxName4.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName4.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName4.SelectedIndex = 0
    End Sub

    Private Sub cbxClass5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass5.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass5.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName5.Items.Clear()
        cbxName5.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName5.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName5.SelectedIndex = 0
    End Sub

    Private Sub cbxClass6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass6.SelectedIndexChanged
        '   LOAD NAMES OF STUDENTS FROM SELECTED CLASS
        access.AddParam("@CLASS", cbxClass6.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE Class= @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        cbxName6.Items.Clear()
        cbxName6.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxName6.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxName6.SelectedIndex = 0
    End Sub

    Private Sub btnBrowse1_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblRes1.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub cbxName1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName1.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxName1.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID1.Text = r("Student_ID")
    End Sub

    Private Sub lblRes1_TextChanged(sender As Object, e As EventArgs) Handles lblRes1.TextChanged
        If lblRes1.Text <> "" Then
            btnUpload1.Enabled = True
        Else
            btnUpload1.Enabled = False
        End If
    End Sub

    Private Sub cbxName2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName2.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxName2.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID2.Text = r("Student_ID")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblRes2.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub lblRes2_TextChanged(sender As Object, e As EventArgs) Handles lblRes2.TextChanged
        If lblRes2.Text <> "" Then
            btnUpload2.Enabled = True
        Else
            btnUpload2.Enabled = False
        End If
    End Sub

    Private Sub btnUpload2_Click(sender As Object, e As EventArgs) Handles btnUpload2.Click
        Try
            With access


                ' CHECK FOR DUPLICATE RESULT
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName2.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName2.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                ' COPY RESULT TO DIRECTORY

10:             If cbxExam.Text = "MID TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes2.Text) Then
                            IO.File.Copy(lblRes2.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes2.Text))
                            lblRes2.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes2.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes2.Text) Then
                            IO.File.Copy(lblRes2.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes2.Text))
                            lblRes2.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes2.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                    Exit Sub
                End If
                'SAVE RESULT DETAILS IN DBS
                'DECLARE PARAMETERS
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName2.Text)
                    .AddParam("@Class", cbxClass2.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes2.Text)
                    .AddParam("@ID", lblID2.Text)

                    'QUERY
                    .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")

                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName2.Text)
                    .AddParam("@Class", cbxClass2.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes2.Text)
                    .AddParam("@ID", lblID2.Text)
                    .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")
                Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub lblRes3_TextChanged(sender As Object, e As EventArgs) Handles lblRes3.TextChanged
        If lblRes3.Text <> "" Then
            btnUpload3.Enabled = True
        Else
            btnUpload3.Enabled = False
        End If
    End Sub

    Private Sub cbxName3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName3.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxName3.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID3.Text = r("Student_ID")
    End Sub

    Private Sub btnBrowse3_Click(sender As Object, e As EventArgs) Handles btnBrowse3.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblRes3.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpload3_Click(sender As Object, e As EventArgs) Handles btnUpload3.Click
        Try
            With access


                ' CHECK FOR DUPLICATE RESULT
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName3.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName3.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                ' COPY RESULT TO DIRECTORY

10:             If cbxExam.Text = "MID TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes3.Text) Then
                            IO.File.Copy(lblRes3.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes3.Text))
                            lblRes3.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes3.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes3.Text) Then
                            IO.File.Copy(lblRes3.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes3.Text))
                            lblRes3.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes3.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                    Exit Sub
                End If
                'SAVE RESULT DETAILS IN DBS
                'DECLARE PARAMETERS
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName3.Text)
                    .AddParam("@Class", cbxClass3.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes3.Text)
                    .AddParam("@ID", lblID3.Text)

                    'QUERY
                    .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")

                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName3.Text)
                    .AddParam("@Class", cbxClass3.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes3.Text)
                    .AddParam("@ID", lblID3.Text)
                    .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")
                Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblRes4_TextChanged(sender As Object, e As EventArgs) Handles lblRes4.TextChanged
        If lblRes4.Text <> "" Then
            btnUpload4.Enabled = True
        Else
            btnUpload4.Enabled = False
        End If
    End Sub

    Private Sub btnBrowse4_Click(sender As Object, e As EventArgs) Handles btnBrowse4.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblRes4.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpload4_Click(sender As Object, e As EventArgs) Handles btnUpload4.Click
        Try
            With access


                ' CHECK FOR DUPLICATE RESULT
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName4.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName4.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                ' COPY RESULT TO DIRECTORY

10:             If cbxExam.Text = "MID TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes4.Text) Then
                            IO.File.Copy(lblRes4.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes4.Text))
                            lblRes4.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes4.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes4.Text) Then
                            IO.File.Copy(lblRes4.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes4.Text))
                            lblRes4.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes4.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                    Exit Sub
                End If
                'SAVE RESULT DETAILS IN DBS
                'DECLARE PARAMETERS
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName4.Text)
                    .AddParam("@Class", cbxClass4.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes4.Text)
                    .AddParam("@ID", lblID4.Text)

                    'QUERY
                    .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")

                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName4.Text)
                    .AddParam("@Class", cbxClass4.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes4.Text)
                    .AddParam("@ID", lblID4.Text)
                    'QUERY
                    .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")
                Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblRes5_TextChanged(sender As Object, e As EventArgs) Handles lblRes5.TextChanged
        If lblRes5.Text <> "" Then
            btnUpload5.Enabled = True
        Else
            btnUpload5.Enabled = False
        End If
    End Sub

    Private Sub cbxName4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName4.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxName4.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID4.Text = r("Student_ID")
    End Sub

    Private Sub cbxName5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName5.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxName5.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID5.Text = r("Student_ID")
    End Sub

    Private Sub btnBrowse5_Click(sender As Object, e As EventArgs) Handles btnBrowse5.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblRes5.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpload5_Click(sender As Object, e As EventArgs) Handles btnUpload5.Click
        Try
            With access


                ' CHECK FOR DUPLICATE RESULT
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName5.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName5.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                ' COPY RESULT TO DIRECTORY

10:             If cbxExam.Text = "MID TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes5.Text) Then
                            IO.File.Copy(lblRes5.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes5.Text))
                            lblRes5.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes5.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes5.Text) Then
                            IO.File.Copy(lblRes5.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes5.Text))
                            lblRes5.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes5.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                    Exit Sub
                End If
                'SAVE RESULT DETAILS IN DBS
                'DECLARE PARAMETERS
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName5.Text)
                    .AddParam("@Class", cbxClass5.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes5.Text)
                    .AddParam("@ID", lblID5.Text)

                    'QUERY
                    .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")

                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName5.Text)
                    .AddParam("@Class", cbxClass5.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes5.Text)
                    .AddParam("@ID", lblID5.Text)
                    'QUERY
                    .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")
                Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblRes6_TextChanged(sender As Object, e As EventArgs) Handles lblRes6.TextChanged
        If lblRes6.Text <> "" Then
            btnUpload6.Enabled = True
        Else
            btnUpload6.Enabled = False
        End If
    End Sub

    Private Sub cbxName6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName6.SelectedIndexChanged
        '   LOAD DETAILS OF SELECTED STUDENTS
        access.AddParam("@Name", cbxName6.Text)
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] = @Name")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        'FAIL IF NO RECORDS FOUND

        If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
        lblID6.Text = r("Student_ID")
    End Sub

    Private Sub btnBrowse6_Click(sender As Object, e As EventArgs) Handles btnBrowse6.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblRes6.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpload6_Click(sender As Object, e As EventArgs) Handles btnUpload6.Click
        Try
            With access


                ' CHECK FOR DUPLICATE RESULT
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName6.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName6.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                    .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                    If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                    MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                ' COPY RESULT TO DIRECTORY

10:             If cbxExam.Text = "MID TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes6.Text) Then
                            IO.File.Copy(lblRes6.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes6.Text))
                            lblRes6.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes6.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If
                    Try
                        If IO.File.Exists(lblRes6.Text) Then
                            IO.File.Copy(lblRes6.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes6.Text))
                            lblRes6.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes6.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                Else
                    MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                    Exit Sub
                End If
                'SAVE RESULT DETAILS IN DBS
                'DECLARE PARAMETERS
                If cbxExam.Text = "MID TERM EXAM" Then
                    .AddParam("@Name", cbxName6.Text)
                    .AddParam("@Class", cbxClass6.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes6.Text)
                    .AddParam("@ID", lblID6.Text)

                    'QUERY
                    .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")

                ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                    .AddParam("@Name", cbxName6.Text)
                    .AddParam("@Class", cbxClass6.Text)
                    .AddParam("@Term", lblTerm.Text)
                    .AddParam("@Ses", lblSession.Text)
                    .AddParam("@Result", lblRes6.Text)
                    .AddParam("@ID", lblID6.Text)
                    'QUERY
                    .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                               "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                    '   REPORT & ABORT ON ERRORS
                    If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                    'SUCCESS
                    MessageBox.Show("SUCCESSFUL!")
                Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbxExam.Focus()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UploadAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadAllToolStripMenuItem.Click
        If lblRes3.Text <> "" Then
            Try
                With access


                    ' CHECK FOR DUPLICATE RESULT
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName3.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 90
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName3.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 10
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 90

                    End If
                    ' COPY RESULT TO DIRECTORY

10:                 If cbxExam.Text = "MID TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes3.Text) Then
                                IO.File.Copy(lblRes3.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes3.Text))
                                lblRes3.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes3.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 90
                        End Try
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes3.Text) Then
                                IO.File.Copy(lblRes3.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes3.Text))
                                lblRes3.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes3.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 90
                        End Try
                    Else
                        MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                        Exit Sub
                    End If
                    'SAVE RESULT DETAILS IN DBS
                    'DECLARE PARAMETERS
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName3.Text)
                        .AddParam("@Class", cbxClass3.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes3.Text)
                        .AddParam("@ID", lblID3.Text)

                        'QUERY
                        .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")

                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName3.Text)
                        .AddParam("@Class", cbxClass3.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes3.Text)
                        .AddParam("@ID", lblID3.Text)
                        .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")
                    Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
90:     If lblRes2.Text <> "" Then
            Try
                With access


                    ' CHECK FOR DUPLICATE RESULT
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName2.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 20
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 100
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName2.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 20
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 100

                    End If
                    ' COPY RESULT TO DIRECTORY

20:                 If cbxExam.Text = "MID TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes2.Text) Then
                                IO.File.Copy(lblRes2.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes2.Text))
                                lblRes2.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes2.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 100
                        End Try
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes2.Text) Then
                                IO.File.Copy(lblRes2.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes2.Text))
                                lblRes2.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes2.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 100
                        End Try
                    Else
                        MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                        Exit Sub
                    End If
                    'SAVE RESULT DETAILS IN DBS
                    'DECLARE PARAMETERS
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName2.Text)
                        .AddParam("@Class", cbxClass2.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes2.Text)
                        .AddParam("@ID", lblID2.Text)

                        'QUERY
                        .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")

                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName2.Text)
                        .AddParam("@Class", cbxClass2.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes2.Text)
                        .AddParam("@ID", lblID2.Text)
                        .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")
                    Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

100:    If lblRes1.Text <> "" Then
            Try
                With access


                    ' CHECK FOR DUPLICATE RESULT
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName1.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 30
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 110
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName1.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 30
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 110

                    End If
                    ' COPY RESULT TO DIRECTORY

30:                 If cbxExam.Text = "MID TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes1.Text) Then
                                IO.File.Copy(lblRes1.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes1.Text))
                                lblRes1.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes1.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 110
                        End Try
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes1.Text) Then
                                IO.File.Copy(lblRes1.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes1.Text))
                                lblRes1.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes1.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 110
                        End Try
                    Else
                        MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                        Exit Sub
                    End If
                    'SAVE RESULT DETAILS IN DBS
                    'DECLARE PARAMETERS
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName1.Text)
                        .AddParam("@Class", cbxClass1.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes1.Text)
                        .AddParam("@ID", lblID1.Text)

                        'QUERY
                        .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")

                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName1.Text)
                        .AddParam("@Class", cbxClass1.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes1.Text)
                        .AddParam("@ID", lblID1.Text)
                        .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")
                    Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

110:    If lblRes4.Text <> "" Then
            Try
                With access


                    ' CHECK FOR DUPLICATE RESULT
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName4.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 40
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 120
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName4.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 40
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 120

                    End If
                    ' COPY RESULT TO DIRECTORY

40:                 If cbxExam.Text = "MID TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes4.Text) Then
                                IO.File.Copy(lblRes4.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes4.Text))
                                lblRes4.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes4.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 120
                        End Try
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes4.Text) Then
                                IO.File.Copy(lblRes4.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes4.Text))
                                lblRes4.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes4.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 120
                        End Try
                    Else
                        MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                        Exit Sub
                    End If
                    'SAVE RESULT DETAILS IN DBS
                    'DECLARE PARAMETERS
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName4.Text)
                        .AddParam("@Class", cbxClass4.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes4.Text)
                        .AddParam("@ID", lblID4.Text)

                        'QUERY
                        .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")

                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName4.Text)
                        .AddParam("@Class", cbxClass4.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes4.Text)
                        .AddParam("@ID", lblID4.Text)
                        'QUERY
                        .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")
                    Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
120:    If lblRes5.Text <> "" Then
            Try
                With access


                    ' CHECK FOR DUPLICATE RESULT
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName5.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 50
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 130
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName5.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 50
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo 130

                    End If
                    ' COPY RESULT TO DIRECTORY

50:                 If cbxExam.Text = "MID TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes5.Text) Then
                                IO.File.Copy(lblRes5.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes5.Text))
                                lblRes5.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes5.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 130
                        End Try
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes5.Text) Then
                                IO.File.Copy(lblRes5.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes5.Text))
                                lblRes5.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes5.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            GoTo 130
                        End Try
                    Else
                        MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                        Exit Sub
                    End If
                    'SAVE RESULT DETAILS IN DBS
                    'DECLARE PARAMETERS
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName5.Text)
                        .AddParam("@Class", cbxClass5.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes5.Text)
                        .AddParam("@ID", lblID5.Text)

                        'QUERY
                        .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")

                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName5.Text)
                        .AddParam("@Class", cbxClass5.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes5.Text)
                        .AddParam("@ID", lblID5.Text)
                        'QUERY
                        .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")
                    Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
130:    If lblRes6.Text <> "" Then
            Try
                With access


                    ' CHECK FOR DUPLICATE RESULT
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName6.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM MidTermResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 60
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName6.Text) : .AddParam("@Ses", lblSession.Text) : .AddParam("@Term", lblTerm.Text)
                        .ExecQuery("select * FROM TerminalExamResult WHERE [FNAME]= @Name AND [SES] = @Ses AND [TERM]= @Term")
                        If NoErrors(True) = False OrElse .RecordCount < 1 Then GoTo 60
                        MessageBox.Show("RECORD ALREADY EXISTS!", "Results!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    End If
                    ' COPY RESULT TO DIRECTORY

60:                 If cbxExam.Text = "MID TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\MidTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes6.Text) Then
                                IO.File.Copy(lblRes6.Text, "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes6.Text))
                                lblRes6.Text = "C:\GKQSFolder\Result\MidTermResults\" & IO.Path.GetFileName(lblRes6.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            Exit Sub
                        End Try
                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        Dim path As String = "C:\GKQSFolder\Result\EndTermResults\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                        End If
                        Try
                            If IO.File.Exists(lblRes6.Text) Then
                                IO.File.Copy(lblRes6.Text, "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes6.Text))
                                lblRes6.Text = "C:\GKQSFolder\Result\EndTermResults\" & IO.Path.GetFileName(lblRes6.Text)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            Exit Sub
                        End Try
                    Else
                        MessageBox.Show("Select type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                        Exit Sub
                    End If
                    'SAVE RESULT DETAILS IN DBS
                    'DECLARE PARAMETERS
                    If cbxExam.Text = "MID TERM EXAM" Then
                        .AddParam("@Name", cbxName6.Text)
                        .AddParam("@Class", cbxClass6.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes6.Text)
                        .AddParam("@ID", lblID6.Text)

                        'QUERY
                        .ExecQuery("INSERT INTO MidTermResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")

                    ElseIf cbxExam.Text = "END OF TERM EXAM" Then
                        .AddParam("@Name", cbxName6.Text)
                        .AddParam("@Class", cbxClass6.Text)
                        .AddParam("@Term", lblTerm.Text)
                        .AddParam("@Ses", lblSession.Text)
                        .AddParam("@Result", lblRes6.Text)
                        .AddParam("@ID", lblID6.Text)
                        'QUERY
                        .ExecQuery("INSERT INTO TerminalExamResult (FNAME, [CLASS], [TERM], [SES], RESULT, STUID)" & _
                                   "VALUES (@Name, @Class, @Term, @Ses, @Result, @ID)")

                        '   REPORT & ABORT ON ERRORS
                        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                        'SUCCESS
                        MessageBox.Show("SUCCESSFUL!")
                    Else : MessageBox.Show("Choose type of exam", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cbxExam.Focus()
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
        frmResultEdit.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

End Class