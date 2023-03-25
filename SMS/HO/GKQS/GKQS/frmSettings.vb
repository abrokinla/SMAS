Public Class frmSettings
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
    Private Sub ReportErrors()
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
    End Sub
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        access.AddParam("@id", "ADMIN")
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM AdminLogin Where Role = @id")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   FILL LISTBOX
        For Each R As DataRow In access.DBDT.Rows
            lstAdmin.Items.Add(R("Username"))

        Next
        access.AddParam("@id", "USER")
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM AdminLogin Where Role = @id")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   FILL LISTBOX
        For Each R As DataRow In access.DBDT.Rows
            lstUser.Items.Add(R("Username"))

        Next
        access.AddParam("@id", "EXECUTIVE")
        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM AdminLogin Where Role = @id")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL LISTBOX
        For Each R As DataRow In access.DBDT.Rows
            lstExec.Items.Add(R("Username"))

        Next

        '   LOAD CURRENT TERM AND SESSION
        access.ExecQuery("SELECT * FROM SETTINGS")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        Dim ROW As DataRow = access.DBDT(CurrentRecord)
        cbxTerm.Text = ROW("TERM")
        cbxSes.Text = ROW("SESSION")
        ReportErrors()
    End Sub

    Private Sub txtFname_GotFocus(sender As Object, e As EventArgs) Handles txtFname.GotFocus
        If txtFname.Text = "First name" Then
            txtFname.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtSname_GotFocus(sender As Object, e As EventArgs) Handles txtSname.GotFocus
        If txtSname.Text = "Surname" Then
            txtSname.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtSname_LostFocus(sender As Object, e As EventArgs) Handles txtSname.LostFocus
        If txtSname.Text = "" Then
            txtSname.Text = "Surname"
        End If
    End Sub

    Private Sub txtFname_LostFocus(sender As Object, e As EventArgs) Handles txtFname.LostFocus
        If txtFname.Text = "" Then
            txtFname.Text = "First name"
        End If
    End Sub

    Private Sub txtMnum_GotFocus(sender As Object, e As EventArgs) Handles txtMnum.GotFocus
        If txtMnum.Text = "Mobile number" Then
            txtMnum.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtMnum_LostFocus(sender As Object, e As EventArgs) Handles txtMnum.LostFocus
        If txtMnum.Text = "" Then
            txtMnum.Text = "Mobile number"
        End If
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        If txtEmail.Text = "E-mail Address" Then
            txtEmail.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "E-mail Address"
        End If
    End Sub

    Private Sub txtPword_GotFocus(sender As Object, e As EventArgs) Handles txtPword.GotFocus
        If txtPword.Text = "Password" Then
            txtPword.Text = ""
            txtPword.PasswordChar = "*"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtPword_LostFocus(sender As Object, e As EventArgs) Handles txtPword.LostFocus
        If txtPword.Text = "" Then
            txtPword.Text = "Password"
            txtPword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtRPword_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles txtRPword.GiveFeedback

    End Sub

    Private Sub txtRPword_GotFocus(sender As Object, e As EventArgs) Handles txtRPword.GotFocus
        If txtRPword.Text = "Retype Password" Then
            txtRPword.Text = ""
            txtRPword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtRPword_LostFocus(sender As Object, e As EventArgs) Handles txtRPword.LostFocus
        If txtPword.Text = "" Then
            txtRPword.Text = "Retype Password"
            txtRPword.PasswordChar = ""
        ElseIf txtRPword.Text <> txtPword.Text Then
            MsgBox("Password mismatch")
            txtPword.Text = ""
            txtRPword.Text = "Retype Password"
            txtRPword.PasswordChar = ""
            txtPword.Focus()
        Else
            btnSignup.Enabled = True
        End If
    End Sub

    Private Sub btnNewTerm_Click(sender As Object, e As EventArgs) Handles btnNewTerm.Click
        '   declare parameters
        access.AddParam("@session", cbxSes.Text)
        access.AddParam("@Term", cbxTerm.Text)


        '   Query
        Dim A As Integer
        A = MsgBox("YOU ARE ABOUT TO START A NEW TERM, ARE YOU SURE?", vbYesNo, vbQuestion)
        If A = vbYes Then
            access.ExecQuery("UPDATE SETTINGS SET [SESSION] = @session, [TERM]= @term")
            ReportErrors()
            MsgBox("WELCOME TO A NEW TERM")
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
    Public Sub ClearTextbox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '   declare parameters
        With access
            .AddParam("@Tuition", txtTuition.Text)
            .AddParam("@AM", txtBusAM.Text)
            .AddParam("@PM", txtBusPM.Text)
            .AddParam("@Excur", txtExcur.Text)
            .AddParam("@Party", txtParty.Text)
            .AddParam("@Vs", txtVs.Text)
            .AddParam("@RegForm", txtReg.Text)
            .AddParam("@Hostel", txtHostel.Text)
            .AddParam("@Others", txtOthers.Text)
            .AddParam("@Uniform", txtUniform.Text)
            .AddParam("@Cardigan", txtCardigan.Text)
            .AddParam("@Polo", txtPolo.Text)
            .AddParam("@Sports1", txtSports1.Text)
            .AddParam("@Sports2", txtSports2.Text)
            .AddParam("@IDCard", txtID.Text)
            .AddParam("@Lib", txtLibFee.Text)
            .AddParam("@Sci", txtScienceFee.Text) : .AddParam("@Class", cbxClass.Text)

        End With
        
        '   query
        access.ExecQuery("UPDATE FEE SET TUITION = @Tuition, AM = @AM, PM = @PM, EXCURSION = @Excur, PARTY = @Party, VS = @Vs, [REG_FORM] = @RegForm, Hostel = @Hostel, OTHERS = @Others, UNIFORM = @Uniform, CARDIGAN = @Cardigan, POLO = @Polo, [SPORTS_1] = @Sports1, [SPORTS_2] = @Sports2, [ID_CARD] = @IDCard, LIBRARY = @Lib, SCIENCE = @Sci  WHERE [CLASS] = @Class")

        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS
        MessageBox.Show("UPDATE SUCCESSFUL!", "UPDATE FEES", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearTextbox(Me)
        cbxClass.Text = ""
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If cbxMonth.Text = "Month" Or cbxDay.Text = "Day" Then
            MessageBox.Show("Make sure all textboxes are filled appropriately", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbxMonth.Focus()
        ElseIf txtRPword.Text <> txtPword.Text Then
            MessageBox.Show("Password Mismatch!", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPword.Focus()
            txtRPword.Text = "Retype Password"
        Else
            MessageBox.Show("YOU ABOUT TO CREATE A NEW USER.", "NEW USER", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Windows.Forms.DialogResult.OK Then
                'parameters
                access.AddParam("@Fname", txtFname.Text)
                access.AddParam("@Sname", txtSname.Text)
                access.AddParam("@MobileNum", txtMnum.Text)
                access.AddParam("@Email", txtEmail.Text)
                access.AddParam("@Role", cbxRole.Text)
                access.AddParam("@Username", txtUsername.Text)
                access.AddParam("@Password", txtPword.Text)
                access.AddParam("@Bday", cbxDay.Text & "/" & cbxMonth.Text)
                If rdFemale.Checked = True Then
                    access.AddParam("@Gender", rdFemale.Text)
                Else
                    access.AddParam("@Gender", rdMale.Text)
                End If

                'Query
                access.ExecQuery("INSERT INTO AdminLogin ([FirstName], [Surname], [MobileNum], [EmailAddress], [Role], Username, Pword, Birthday, Gender)" & _
                                 "VALUES (@Fname, @Sname, @MobileNum, @Email, @Role, @Username, @Password, @Bday, @Gender);")
                ReportErrors()
                '   SUCCESS
                MsgBox("SIGNUP SUCCESSFUL!")
                '   INSTANTIATE NEW FORM
                Dim FRM As New frmSettings
                Me.Close()
                FRM.Show()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
        ElseIf txtUsername.Text <> "" Then
            access.AddParam("@SearchID", txtUsername.Text)
            access.ExecQuery("select * FROM AdminLogin WHERE Username= @SearchID")
            If NoErrors(True) = False OrElse access.RecordCount < 1 Then
                MessageBox.Show("USERNAME IS AVAILABLE", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("USERNAME IS NOT AVAILABLE", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Text = "" : txtUsername.Focus()
            End If
        End If

    End Sub


    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub cbxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMonth.SelectedIndexChanged
        Dim x As Integer
        If cbxMonth.Text = "SEP" Or cbxMonth.Text = "APR" Or cbxMonth.Text = "JUN" Or cbxMonth.Text = "NOV" Then
            cbxDay.Items.Clear()
            For x = 1 To 30
                cbxDay.Items.Add(x)
            Next x
        ElseIf cbxMonth.Text = "FEB" Then
            cbxDay.Items.Clear()
            For x = 1 To 29
                cbxDay.Items.Add(x)
            Next x
        Else
            cbxDay.Items.Clear()
            For x = 1 To 31
                cbxDay.Items.Add(x)
            Next x
        End If
    End Sub


    Private Sub btnUserRem_Click(sender As Object, e As EventArgs) Handles btnUserRem.Click
        access.AddParam("@User", lstUser.SelectedItem)
        'query
        access.ExecQuery("DELETE * FROM AdminLogin Where Username = @Usern")
        Dim ab As Integer = MessageBox.Show("You are about to delete a user!", "GKQS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ab = MsgBoxResult.Yes Then
            MessageBox.Show("User Removed!", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '   INSTANTIATE NEW FORM
            Dim FRM As New frmSettings
            Me.Close()
            FRM.Show()
            ReportErrors()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAdminRem_Click(sender As Object, e As EventArgs) Handles btnAdminRem.Click
        access.AddParam("@Admin", lstAdmin.SelectedItem)
        'query
        access.ExecQuery("DELETE * FROM AdminLogin Where Username = @Admin")
        Dim ab As Integer = MessageBox.Show("You are about to delete a user!", "GKQS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ab = MsgBoxResult.Yes Then
            MessageBox.Show("Admin Removed!", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '   INSTANTIATE NEW FORM
            Dim FRM As New frmSettings
            Me.Close()
            FRM.Show()
            ReportErrors()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnNewSession_Click(sender As Object, e As EventArgs) Handles btnNewSession.Click
        MessageBox.Show("ARE YOU SURE YOU WANT TO START A NEW SESSION?", "NEW SESSION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then
            If cbxTerm.Text <> "FIRST" Then
                MessageBox.Show("YOU MUST START A NEW SESSION FROM THE FIRST TERM", "NEW SESSION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbxTerm.Focus()
            Else


                access.AddParam("@Class", "SSS 3")
                access.AddParam("@Status", "Inactive")
                access.AddParam("@OldClass", "GRADUATED")
                access.ExecQuery("UPDATE Students SET Class = @Class, Status= @Status Where Class= @OldClass")
                access.AddParam("@Class", "SSS 3")
                access.AddParam("@OldClass", "GRADUATED")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")

                access.AddParam("@Class", "GRADUATED")
                access.AddParam("@Status", "Inactive")
                access.AddParam("@OldClass", "PRY FIVE")
                access.ExecQuery("UPDATE Students SET Class = @Class, Status = @Status Where Class= @OldClass")
                access.AddParam("@Class", "GRADUATED")
                access.AddParam("@OldClass", "PRY FIVE")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "SSS 3")
                access.AddParam("@OldClass", "SSS 2")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "SSS 3")
                access.AddParam("@OldClass", "SSS 2")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "SSS 2")
                access.AddParam("@OldClass", "SSS 1")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "SSS 2")
                access.AddParam("@OldClass", "SSS 1")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "SSS 1")
                access.AddParam("@OldClass", "JSS 3")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "SSS 1")
                access.AddParam("@OldClass", "JSS 3")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "JSS 3")
                access.AddParam("@OldClass", "JSS 2")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "JSS 3")
                access.AddParam("@OldClass", "JSS 2")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "JSS 2")
                access.AddParam("@OldClass", "JSS 1")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "JSS 2")
                access.AddParam("@OldClass", "JSS 1")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "PRY FIVE")
                access.AddParam("@OldClass", "PRY FOUR")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "PRY FIVE")
                access.AddParam("@OldClass", "PRY FOUR")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "PRY FOUR")
                access.AddParam("@OldClass", "PRY THREE")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "PRY FOUR")
                access.AddParam("@OldClass", "PRY THREE")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "PRY THREE")
                access.AddParam("@OldClass", "PRY TWO")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "PRY TWO")
                access.AddParam("@OldClass", "PRY ONE")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "PRY TWO")
                access.AddParam("@OldClass", "PRY ONE")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "PRY TWO")
                access.AddParam("@OldClass", "PRY ONE")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "PRY ONE")
                access.AddParam("@OldClass", "KG3/NUR")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "PRY ONE")
                access.AddParam("@OldClass", "KG3/NUR")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "KG3/NUR")
                access.AddParam("@OldClass", "KG2")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "KG3/NUR")
                access.AddParam("@OldClass", "KG2")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "KG2")
                access.AddParam("@OldClass", "KG1")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "KG2")
                access.AddParam("@OldClass", "KG1")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "KG1")
                access.AddParam("@OldClass", "PLAYGROUP")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "KG1")
                access.AddParam("@OldClass", "PLAYGROUP")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                access.AddParam("@Class", "PLAYGROUP")
                access.AddParam("@OldClass", "Créche")
                access.ExecQuery("UPDATE Students SET Class = @Class Where Class= @OldClass")
                access.AddParam("@Class", "PLAYGROUP")
                access.AddParam("@OldClass", "Créche")
                access.ExecQuery("UPDATE OUTSTANDING SET Class = @Class Where Class = @OldClass")


                '   declare parameters
                access.AddParam("@session", cbxSes.Text)
                access.AddParam("@Term", cbxTerm.Text)


                '   Query

                access.ExecQuery("UPDATE SETTINGS SET [SESSION] = @session, [TERM]= @term")
                ReportErrors()
                MsgBox("WELCOME TO A NEW TERM")

                '   SUCCESS
                MessageBox.Show("WELCOME TO " & cbxTerm.Text & " TERM IN" & cbxSes.Text & "CONGRATULATIONS!!", "NEW SESSION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtBus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusPM.KeyPress, txtExcur.KeyPress, txtVs.KeyPress, txtOthers.KeyPress, txtParty.KeyPress, txtBusAM.KeyPress, txtUniform.KeyPress, txtSports1.KeyPress, txtPolo.KeyPress, txtID.KeyPress, txtHostel.KeyPress, txtCardigan.KeyPress, txtScienceFee.KeyPress, txtLibFee.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnExecRemove_Click(sender As Object, e As EventArgs) Handles btnExecRemove.Click
        access.AddParam("@Exec", lstExec.SelectedItem)
        'query
        access.ExecQuery("DELETE * FROM AdminLogin Where Username = @Exec")
        Dim ab As Integer = MessageBox.Show("You are about to delete a user!", "GKQS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ab = MsgBoxResult.Yes Then
            MessageBox.Show("User Removed!", "ADMIN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '   INSTANTIATE NEW FORM
            Dim FRM As New frmSettings
            Me.Close()
            FRM.Show()
            ReportErrors()
        Else
            Exit Sub : End If
    End Sub

    Private Sub cbxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClass.SelectedIndexChanged
        '   DECLARE PARAMETERS
        access.AddParam("@Class", cbxClass.Text)

        '   QUERY
        access.ExecQuery("SELECT * FROM FEE WHERE CLASS = @Class")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then Exit Sub
        Dim R As DataRow = access.DBDT(CurrentRecord)
        txtTuition.Text = R("TUITION")
        txtBusAM.Text = R("AM")
        txtBusPM.Text = R("PM")
        txtExcur.Text = R("EXCURSION")
        txtParty.Text = R("PARTY")
        txtVs.Text = R("VS")
        txtReg.Text = R("REG_FORM")
        txtHostel.Text = R("HOSTEL")
        txtOthers.Text = R("OTHERS")
        txtUniform.Text = R("UNIFORM")
        txtCardigan.Text = R("CARDIGAN")
        txtPolo.Text = R("POLO")
        txtSports1.Text = R("SPORTS_1")
        txtSports2.Text = R("SPORTS_2")
        txtID.Text = R("ID_CARD")
        txtLibFee.Text = R("LIBRARY")
        txtScienceFee.Text=R("SCIENCE")
        ReportErrors()
    End Sub


End Class