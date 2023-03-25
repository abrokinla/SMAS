Public Class frmPayroll
    Private access As New DBControl
    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        access.AddParam("@Status", "Active")
        '   QUERY
        access.ExecQuery("SELECT [Full_Name], [Account_Name], [Account_Number], Bank FROM [Staff_Profile] WHERE Status = @Status")
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub
        '   FILL DATAGRID
        dgvPayroll.DataSource = access.DBDT
    End Sub

    Private Sub EXPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPORTToolStripMenuItem.Click
        frmReport.rdPayroll.Checked = True
        frmReport.GroupBox1.Enabled = False
        frmReport.Show()
    End Sub
End Class