Public Class frmLock
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
    Private Sub t1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub t2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t2.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub t3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t3.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub t4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t5.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub t5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t5.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub t6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t6.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        t1.Focus()
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged
        t2.Focus()
    End Sub

    Private Sub t2_TextChanged(sender As Object, e As EventArgs) Handles t2.TextChanged
        t3.Focus()
    End Sub

    Private Sub t3_TextChanged(sender As Object, e As EventArgs) Handles t3.TextChanged
        t4.Focus()
    End Sub

    Private Sub t4_TextChanged(sender As Object, e As EventArgs) Handles t4.TextChanged
        t5.Focus()
    End Sub

    Private Sub t5_TextChanged(sender As Object, e As EventArgs) Handles t5.TextChanged
        t6.Focus()
    End Sub

    Private Sub t6_TextChanged(sender As Object, e As EventArgs) Handles t6.TextChanged
        btnLock.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If frmMain.Enabled = False Then
            Me.Close()
            frmMain.Close()
        Else
            Me.Close()
            ClearTextbox(Me)
            Me.Width = 322
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Width = 593
        lques.Visible = True : lAns.Visible = True
        txtQuestion.Visible = True : txtAnswer.Visible = True
        btnEnter.Visible = True


        '   RUN QUERY 
        access.ExecQuery("SELECT * FROM Lock")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   FILL TEXTBOX
        Dim R As DataRow = access.DBDT.Rows(CurrentRecord)
        txtQuestion.Text = R("Secret Question")

    End Sub

    Private Sub txtOldCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldCode.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNewCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewCode.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRecode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecode.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        access.AddParam("@Newcode", txtNewCode.Text)

        If txtNewCode.Text <> txtRecode.Text Then
            MessageBox.Show("Password Mismatch!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewCode.Text = "" : txtRecode.Text = "" : txtNewCode.Focus()
        ElseIf txtNewCode.TextLength > 6 Then
            MessageBox.Show("Enter only 6 characters", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            access.ExecQuery("UPDATE Lock SET LockID = @Newcode")
            ReportErrors()
            '   SUCCESS
            MessageBox.Show("Lock Code changed successfully", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Width = 322
            ClearTextbox(Me)
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Width = 593
        lOld.Visible = True : lNew.Visible = True : lRec.Visible = True
        txtNewCode.Visible = True : txtOldCode.Visible = True : txtRecode.Visible = True
        btnUpdate.Visible = True
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        access.AddParam("@Answer", txtAnswer.Text)
        '   QUERY
        access.ExecQuery("SELECT * FROM Lock WHERE Answer = @Answer")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then
            MessageBox.Show("Wrong Answer!, Please enter correct answer!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnswer.Text = "" : txtAnswer.Focus()
        Else
            '       SUCCESS
            lOld.Visible = False : lNew.Visible = True : lRec.Visible = True
            txtNewCode.Visible = True : txtOldCode.Visible = False : txtRecode.Visible = True
            btnUpdate.Visible = True

        End If
    End Sub

    Private Sub txtOldCode_LostFocus(sender As Object, e As EventArgs) Handles txtOldCode.LostFocus
        access.AddParam("@Oldcode", txtOldCode.Text)
        access.ExecQuery("SELECT * FROM Lock WHERE LockID = @Oldcode")
        If NoErrors(True) = False OrElse access.RecordCount < 1 Then
            MessageBox.Show("Enter the Old Lock Code!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOldCode.Focus()
        Else
            txtNewCode.Focus()
        End If
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        If btnLock.Text = "UNLOCK" Then
            access.ExecQuery("SELECT * FROM Lock")

            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            Dim a As String
            a = t1.Text & t2.Text & t3.Text & t4.Text & t5.Text & t6.Text
            Dim R As DataRow = access.DBDT.Rows(CurrentRecord)
            If R("LockID") = a Then
                access.AddParam("@Lock", False)
                access.ExecQuery("UPDATE Lock SET Lock = @Lock")
                MessageBox.Show("UNLOCKED!!!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLogin.Show()
                Me.Close()
            Else
                MessageBox.Show("Enter the correct Lock Code!!!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearTextbox(Me)
                t1.Focus()
            End If
        ElseIf btnLock.Text = "LOCK" Then

            access.ExecQuery("SELECT * FROM Lock")

            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            Dim a As String
            a = t1.Text & t2.Text & t3.Text & t4.Text & t5.Text & t6.Text
            Dim R As DataRow = access.DBDT.Rows(CurrentRecord)
            If R("LockID") = a Then
                access.AddParam("@Lock", True)
                access.ExecQuery("UPDATE Lock SET Lock = @Lock")
                MessageBox.Show("LOCKED!!!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Else
                MessageBox.Show("Enter the correct Lock Code!!!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearTextbox(Me)
                t1.Focus()
            End If
        End If


    End Sub

    Private Sub txtNewCode_LostFocus(sender As Object, e As EventArgs) Handles txtNewCode.LostFocus
        If txtNewCode.TextLength <> 6 Then
            MessageBox.Show("LOCK CODE MUST BE 6 CHARACTERS", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewCode.Text = "" : txtNewCode.Focus()
            If txtNewCode.Text = "" Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtRecode_LostFocus(sender As Object, e As EventArgs) Handles txtRecode.LostFocus
        If txtNewCode.Text = "" Then
            MessageBox.Show("Enter NEW CODE!!!", "Lock!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRecode.Text = ""
            txtNewCode.Focus()
        End If
    End Sub

End Class