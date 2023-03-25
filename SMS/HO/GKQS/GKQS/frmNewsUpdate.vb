Public Class frmNewsUpdate
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
    Private Sub frmNewsUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            access.ExecQuery("SELECT * FROM News")
            '   REPORT & ABORT ON ERRORS
            If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
            'FAIL IF NO RECORDS FOUND

            If access.DBDT.Rows.Count < 1 OrElse CurrentRecord > access.DBDT.Rows.Count - 1 Then MessageBox.Show("RECORD NOT FOUND", "NO RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim r As DataRow = access.DBDT.Rows(CurrentRecord)
            TextBox1.Text = r("News").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            With access
                .AddParam("@News", TextBox1.Text)
                .AddParam("@ID", "1")
                'QUERY
                .ExecQuery("UPDATE News SET News = @News where ID = @ID")
                '   REPORT & ABORT ON ERRORS
                If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

                'SUCCESS
                MessageBox.Show("News Updated!", "News", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.lblNews.Text = TextBox1.Text
                Me.Close()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class