Public Class frmExpenditure
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

    Private Sub txtDate_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDate.MouseDown
        txtDate.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '   DEFINE PARAMETERS
        access.AddParam("@Date", txtDate.Text)
        access.AddParam("@Desc", txtDesc.Text)
        access.AddParam("@Amount", txtAmount.Text)
        access.AddParam("@Session", lblSes.Text)
        access.AddParam("@Term", lblTerm.Text)
        access.AddParam("@Collect", txtCollect.Text)
        access.AddParam("@Approv", txtAprov.Text)
        If rdCash.Checked = True Then
            access.AddParam("@Mode", rdCash.Text)
        ElseIf rdCheque.Checked = True Then
            access.AddParam("@Mode", rdCheque.Text)
        Else : MsgBox("Choose mode of payment", vbOKOnly, vbInformation)
        End If

        '   QUERY
        access.ExecQuery("INSERT INTO Expenditure ([Date_of_Exp], Description, Amount, [Session], Term, COLLECTED_BY, APPROVED_BY, MODE_OF_PAYMENT)" & _
                         "Values (@Date, @Desc, @Amount, @Session, @Term, @Collect, @Approv, @Mode);")

        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS
        MsgBox("RECORD ADDED SUCCESSFULLY")

        Dim frm As New frmExpenditure
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmExpenditure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   display current session and term
        access.ExecQuery("SELECT * FROM SETTINGS")
        Dim ROW As DataRow = access.DBDT(CurrentRecord)
        lblTerm.Text = ROW("TERM").ToString
        lblSes.Text = ROW("SESSION").ToString

        'DISPLAY CURRENT DATE
        txtDate.Text = Date.Now.ToString("MM-dd-yyyy")
        access.ExecQuery("SELECT * FROM Expenditure")
        dgvExpenditure.DataSource = access.DBDT
    End Sub

    Private Sub btnViewExp_Click(sender As Object, e As EventArgs) Handles btnViewExp.Click
        If btnViewExp.Text = "VIEW>>>" Then
            Me.Size = New System.Drawing.Size(962, 455)
            btnViewExp.Text = "BACK<<<"
            access.ExecQuery("SELECT * FROM Expenditure")
            dgvExpenditure.DataSource = access.DBDT
        Else : Me.Size = New System.Drawing.Size(468, 455)
            btnViewExp.Text = "VIEW>>>"
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

End Class



























