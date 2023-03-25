Public Class frmUpdateOutstanding
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

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

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

        cbxStudents.Items.Clear()
        cbxStudents.Text = ""
        '   FILL COMBOBOX
        For Each R As DataRow In access.DBDT.Rows
            cbxStudents.Items.Add(R("Full_Name"))
        Next

        ' DISPLAY FIRST NAME FOUND
        If access.RecordCount > 0 Then cbxStudents.SelectedIndex = 0
    End Sub

    Private Sub cbxStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStudents.SelectedIndexChanged
        With access
            .AddParam("@NAME", cbxStudents.Text)
            .AddParam("@CLASS", cbxClass.Text)


            .ExecQuery("SELECT * FROM OUTSTANDING WHERE FullName = @NAME AND [Class] = @CLASS")
            ReportErrors()
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        End With

            '   DISPLAY OUTSTANDING
            If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
            txtOutstanding.Text = r("Outstanding")
            lblID.Text = r("STUID").ToString

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        With access
            .AddParam("@outstanding", txtOutstanding.Text)
            .AddParam("@ID", lblID.Text)
            .AddParam("@NAME", cbxStudents.Text)
            .AddParam("@CLASS", cbxClass.Text)


        End With
        access.ExecQuery("UPDATE OUTSTANDING SET [Outstanding] = @outstanding WHERE STUID = @ID AND FullName= @NAME AND [Class] = @CLASS")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        ReportErrors()
        If Me.Text = "Student" Then
            With access
                .AddParam("@outstanding", txtOutstanding.Text)
                .AddParam("@NAME", cbxStudents.Text)
                .AddParam("@CLASS", cbxClass.Text)
                .AddParam("@ID", lblID.Text)

                'QUERY
                .ExecQuery("UPDATE OUTSTANDING SET [Outstanding] = @outstanding, FullName= @NAME, [Class] = @CLASS WHERE STUID = @ID")
                If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
                ReportErrors()
            End With
        End If
        'SUCCESS
        MessageBox.Show("UPDATE SUCCESSFUL", "UPDATE OUTSTANDING", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

   
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If Me.Text = "Student" Then
            With access
                .AddParam("@id", lblID.Text)

                'QUERY
                .ExecQuery("SELECT * FROM OUTSTANDING WHERE STUID = @id")
                ReportErrors()
                If Not String.IsNullOrEmpty(.Exception) Then MsgBox(.Exception) : Exit Sub

                If .DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim rOW As DataRow = .DBDT.Rows(CurrentRecord)
                txtOutstanding.Text = rOW("Outstanding")
                txtOutstanding.Visible = True
            End With
        End If
    End Sub
End Class