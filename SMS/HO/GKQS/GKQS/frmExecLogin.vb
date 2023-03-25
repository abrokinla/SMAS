Public Class frmExecLogin
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtUname_GotFocus(sender As Object, e As EventArgs) Handles txtUname.GotFocus
        If txtUname.Text = "Username" Then
            txtUname.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtUname_LostFocus(sender As Object, e As EventArgs) Handles txtUname.LostFocus
        If txtUname.Text = "" Then
            txtUname.Text = "Username"
        Else
            Exit Sub
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

    Private Sub txtPword_LostFocus(sender As Object, e As EventArgs) Handles txtPword.LostFocus
        If txtPword.Text = "" Then
            txtPword.PasswordChar = ""
            txtPword.Text = "Password"
        Else
            Exit Sub
        End If
    End Sub
    
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        access.AddParam("@username", txtUname.Text)
        access.AddParam("@password", txtPword.Text)
        access.AddParam("@Role", "EXECUTIVE")
        '   QUERY
        access.ExecQuery("SELECT * FROM AdminLogin WHERE Username = @username AND Pword = @Pword AND Role = @Role")

        If NoErrors(True) = False OrElse access.RecordCount < 1 Then
            MessageBox.Show("WRONG LOGIN DETAILS", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim R As DataRow = access.DBDT.Rows(CurrentRecord)
            If R("Username") <> txtUname.Text Or R("Pword") <> txtPword.Text Or R("Role") <> "EXECUTIVE" Then
                MessageBox.Show("Incorrect login details", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearTextbox(Me)
                txtUname.Focus()
                txtPword.PasswordChar = ""
                txtPword.Text = "Password"
            Else
                MessageBox.Show("Login Successsful! Welcome! " & R("Surname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Me.Text = "EDIT PAYMENT" Then
                    frmEditPayment.Show()
                    Me.Close()
                ElseIf Me.Text = "UPDATE OUTSTANDING" Then
                    frmUpdateOutstanding.Show()
                    Me.Close()
                End If
            End If

        End If
        ReportErrors()
    End Sub
End Class