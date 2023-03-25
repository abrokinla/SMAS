Public Class frmLogin
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
    Public Sub ClearTextbox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        access.AddParam("@username", txtUsername.Text)
        access.AddParam("@password", txtPassword.Text)
        access.AddParam("@Role", cbxRole.Text)
        '   QUERY
        access.ExecQuery("SELECT * FROM AdminLogin WHERE Username = @username AND Pword = @Pword AND Role = @Role")

        If NoErrors(True) = False OrElse access.RecordCount < 1 Then
            MessageBox.Show("WRONG LOGIN DETAILS", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim R As DataRow = access.DBDT.Rows(CurrentRecord)

            If R("Username") <> txtUsername.Text Or R("Pword") <> txtPassword.Text Or R("Role") <> cbxRole.Text Then
                MessageBox.Show("Incorrect login details", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearTextbox(Me)
                txtUsername.Focus()
                txtPassword.PasswordChar = ""
                txtPassword.Text = "Password"

            Else
                MessageBox.Show("Login Successsful!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.lblCashier.Text = R("Surname")
                Me.Hide()
                frmMain.Show()
            End If

        End If
        ReportErrors()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
        Else
            Exit Sub
        End If




    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.PasswordChar = "*"
            txtPassword.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.PasswordChar = ""
            txtPassword.Text = "Password"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        access.ExecQuery("SELECT * FROM Lock")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        Dim R As DataRow = access.DBDT.Rows(CurrentRecord)
        If R("Lock") = True Then
            frmLock.Show()
            frmLock.btnLock.Text = "UNLOCK"
            Me.Close()
        ElseIf R("Lock") = False Then
            Me.Show()
        End If
        
    End Sub
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
End Class