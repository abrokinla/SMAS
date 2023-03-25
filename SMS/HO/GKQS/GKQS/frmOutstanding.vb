Public Class frmOutstanding
    Private access As New DBControl
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOutstanding.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' DECLARE PARAMETERS

        access.AddParam("@stuID", lblID.Text)
        access.AddParam("@FName", lblName.Text)
        access.AddParam("@Outstanding", txtOutstanding.Text)
        access.AddParam("@Class", lblClass.Text)

        access.ExecQuery("INSERT INTO OUTSTANDING (STUID, [FullName], Outstanding, Class)" & _
                         "VALUES(@stuID, @FName, @Outstanding, @Class);")
       
        '   REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        '   SUCCESS
        MessageBox.Show("UPDATE SUCCESSFUL!", "OUTSTANDING", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

End Class