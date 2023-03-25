Imports System.IO
Public Class frmNewStaff
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
    Private Sub frmNewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DAYS AND YEARS FOR BIRTH AND EMPLOYMENT
        Dim x As Integer
        For x = 1 To 31
            cbxDay.Items.Add(x)
            cbxDay2.Items.Add(x)
        Next
        For x = 1975 To 2000
            cbxYear.Items.Add(x)
        Next
        For x = 2017 To 2030
            cbxYear2.Items.Add(x)
        Next
        txtDateEmp.Visible = False
        txtDOB.Visible = False


        If UPDATEToolStripMenuItem.Enabled = True Then
            Save2ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub CLOSEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem1.Click
        'CLOSE FORM
        Me.Close()
    End Sub

    Private Sub NewStaff()
        ' DATE OF BIRTH
        Dim DOB, DateEmp As String
        DOB = cbxDay.Text & "/" & cbxMonth.Text & "/" & cbxYear.Text
        DateEmp = cbxDay2.Text & "/" & cbxMonth2.Text & "/" & cbxYear2.Text
        ' ADD PARAMETERS
        access.AddParam("@FullName", txtFname.Text)
        access.AddParam("@Address", txtAddress.Text)
        access.AddParam("@SchoolGrad", txtSchlGrad.Text)
        access.AddParam("@State", txtState.Text)
        access.AddParam("@Gender", cbxGender.Text)
        access.AddParam("@NextOfKin", txtNok.Text)
        access.AddParam("@Qualification", txtQual.Text)
        access.AddParam("@Nationality", txtNationality.Text) ' Start here 
        access.AddParam("@NokTel", txtTelNok.Text)
        access.AddParam("@Religion", cbxReligion.Text)
        access.AddParam("@LGA", txtLGA.Text)
        access.AddParam("@Email", txtEmail.Text)
        access.AddParam("@DOB", DOB)
        access.AddParam("@Tel1", txtTel1.Text)
        access.AddParam("@Tel2", txtTel2.Text)
        access.AddParam("@DateEmp", DateEmp)
        access.AddParam("@StaffID", lblStaffID.Text)
        access.AddParam("@Bank", txtBank.Text)
        access.AddParam("@AccountNum", txtAcctNo.Text)
        access.AddParam("@AcctName", txtAcctName.Text)
        access.AddParam("@cv", lblCv.Text)
        access.AddParam("@cert", lblCert.Text)
        access.AddParam("@others", lblOthers.Text)
        If rdActive.Checked = True Then
            access.AddParam("@Status", rdActive.Text)
        ElseIf rdInactive.Checked = True Then
            access.AddParam("@Status", rdInactive.Text)
        End If

        '   EXECUTE INSERT COMMAND
        access.ExecQuery("INSERT INTO [Staff_Profile] ([Full_Name], Address, [School_Graduated], [State_of_Origin], Gender, [Kin], Qualification, Nationality, [Kin_Telephone], Religion, LGA, [Email_Address], [Date_of_Birth], [Telephone_1], [Telephone_2], [Date employed], [Staff_ID], Bank, [Account_Number], [Account_Name], Curriclum_Vitae_Upload, Certificate_Upload, Others, Status)" & _
                         "VALUES (@FullName, @Address, @SchoolGrad, @State, @Gender, @NextOfKin, @Qualification, @Nationality, @NokTel, @Religion, @LGA, @Email, @DOB, @Tel1, @Tel2, @DateEmp, @StaffID, @Bank, @AccountNum, @AcctName, @cv, @cert, @others, @Status);")

        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS!!!
        MsgBox("Staff was added successfully")
    End Sub

    Private Sub REFRESHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REFRESHToolStripMenuItem.Click

        '   Instantiating a new form

        Dim frm = New frmNewStaff
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Save2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Save2ToolStripMenuItem.Click
        '   Adding a new STAFF
        MessageBox.Show("Are you sure you want to save?", "NEW STAFF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then
            NewStaff()
            access.AddParam("@ID", lblStaffID.Text)
            access.AddParam("@NAME", txtFname.Text)
            access.ExecQuery("INSERT INTO SALARY ([STAFF_ID], [FULL_NAME])" & _
                             "VALUES (@ID, @NAME);")
            '   Instantiating a new form
            Dim frm = New frmNewStaff
            frm.Show()
            Me.Close()
        Else
            Exit Sub
        End If


    End Sub


    Private Sub TextBox_Validate(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If UPDATEToolStripMenuItem.Enabled = True Then
            Save2ToolStripMenuItem.Enabled = False
        Else
            If Not String.IsNullOrWhiteSpace(txtFname.Text) Then Save2ToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub frmGenID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        'Dim ID As String
        'ID = System.Guid.NewGuid.ToString
        'lblStaffID.Text = ID

        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Staff_Profile WHERE NumID = (SELECT MAX(NumID) FROM Staff_Profile)")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub


        '   FILL COMBOBOX WITH LAST ROW NUMBER
        Dim Rr As DataRow = access.DBDT.Rows(CurrentRecord)
        lblStaffID.Text = "GKQS" & Rr("NumID") + 1
    End Sub


    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        ' ADD PARAMETERS
        access.AddParam("@FullName", txtFname.Text)
        access.AddParam("@Address", txtAddress.Text)
        access.AddParam("@SchoolGrad", txtSchlGrad.Text)
        access.AddParam("@State", txtState.Text)
        access.AddParam("@Gender", cbxGender.Text)
        access.AddParam("@NextOfKin", txtNok.Text)
        access.AddParam("@Qualification", txtQual.Text)
        access.AddParam("@Nationality", txtNationality.Text) ' Start here 
        access.AddParam("@NokTel", txtTelNok.Text)
        access.AddParam("@Religion", cbxReligion.Text)
        access.AddParam("@LGA", txtLGA.Text)
        access.AddParam("@Email", txtEmail.Text)
        access.AddParam("@DOB", txtDOB.Text)
        access.AddParam("@Tel1", txtTel1.Text)
        access.AddParam("@Tel2", txtTel2.Text)
        access.AddParam("@DateEmp", txtDateEmp.Text)
        access.AddParam("@StaffID", lblStaffID.Text)
        access.AddParam("@Bank", txtBank.Text)
        access.AddParam("@AccountNum", txtAcctNo.Text)
        access.AddParam("@AcctName", txtAcctName.Text)
        access.AddParam("@cv", lblCv.Text)
        access.AddParam("@cert", lblCert.Text)
        access.AddParam("@others", lblOthers.Text)
        If rdActive.Checked = True Then
            access.AddParam("@Status", rdActive.Text)
        ElseIf rdInactive.Checked = True Then
            access.AddParam("@Status", rdInactive.Text)
        End If
        '   EXECUTE UPDATE COMMAND
        access.ExecQuery("UPDATE [Staff_Profile] SET [Full_Name]= @FullName, Address= @Address, [School_Graduated]= @SchoolGrad, [State_of_Origin]= @State, Gender= @Gender, [Next_of_Kin]= @NextOfKin, [Qualification]= @Qual, Nationality= @Nationality, [Next_of_Kin_Telephone]= @NokTel, Religion= @Religion, LGA= @LGA, [Email_Address]= @Email, [Date_of_Birth]= @DOB, [Telephone_1]= @Tel1, [Telephone_2]= @Tel2, [Date employed]= @DateEmp, Bank= @Bank, [Account_Number]= @AccountNum,[Account_Name]= @AcctName, Curriclum_Vitae_Upload = @cv, Certificate_Upload = @cert, Others = @others, Status = @Status WHERE [Staff_ID] ='" & lblStaffID.Text & "'")

        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS!!!
        MsgBox("Staff update successful")
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        access.AddParam("@StaffID", lblStaffID.Text)
        Dim x As Integer
        x = MessageBox.Show("DO YOU WANT TO DELETE THIS FILE?", "DELETE RECORD", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If x = vbOK Then
            access.ExecQuery("DELETE * FROM [Staff_Profile] WHERE [Staff_ID]= @StaffID")

        End If

    End Sub

    Private Sub txtAcctNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcctNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
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

    Private Sub txtTelNok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelNok.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCV.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblCv.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim path As String = "C:\GKQSFolder\Staff"
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
        Try
            If IO.File.Exists(lblCv.Text) Then
                IO.File.Copy(lblCv.Text, "C:\GKQSFolder\Staff\" & IO.Path.GetFileName(lblCv.Text))
                lblCv.Text = "C:\GKQSFolder\Staff\" & IO.Path.GetFileName(lblCv.Text)
                If lblCert.Text <> "" And IO.File.Exists(lblCert.Text) Then
                    IO.File.Copy(lblCert.Text, "C:\GKQSFolder\Staff\" & IO.Path.GetFileName(lblCert.Text))
                    lblCert.Text = "C:\GKSFolder\Staff\" & IO.Path.GetFileName(lblCert.Text)
                    If lblOthers.Text <> "" And IO.File.Exists(lblOthers.Text) Then
                        IO.File.Copy(lblOthers.Text, "C:\GKQSFolder\Staff\" & IO.Path.GetFileName(lblOthers.Text))
                        lblOthers.Text = "C:\GKSFolder\Staff\" & IO.Path.GetFileName(lblOthers.Text)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCert_Click(sender As Object, e As EventArgs) Handles btnCert.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblCert.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnOthers_Click(sender As Object, e As EventArgs) Handles btnOthers.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.InitialDirectory = "C:\"
        openfiledialog.Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openfiledialog.RestoreDirectory = True
        Try
            If openfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'set output fields
                lblOthers.Text = openfiledialog.FileName.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
        End Try
    End Sub

   
    Private Sub lblCv_TextChanged(sender As Object, e As EventArgs) Handles lblCv.TextChanged
        If lblCv.Text <> "" And lblCert.Text <> "" And lblOthers.Text <> "" Then
            btnUpload.Enabled = True
        End If
    End Sub

    Private Sub btnOthers_TextChanged(sender As Object, e As EventArgs) Handles btnOthers.TextChanged
        If lblCv.Text <> "" And lblCert.Text <> "" And lblOthers.Text <> "" Then
            btnUpload.Enabled = True
        End If
    End Sub
    Private Sub lblOthers_TextChanged(sender As Object, e As EventArgs) Handles lblOthers.TextChanged
        If lblCv.Text <> "" And lblCert.Text <> "" And lblOthers.Text <> "" Then
            btnUpload.Enabled = True
        End If
    End Sub

    
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCert.Text = "" : lblCv.Text = "" : lblOthers.Text = "" : btnUpload.Enabled = False
    End Sub
End Class