Public Class frmStudentProfile
    Private Access As New DBControl
  

    Private Sub frmStudentProfile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.Text = "Staff Profile" Then
            '   RUN QUERY 
            Access.ExecQuery("SELECT * FROM Staff_Profile")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            '   FILL DATAGRID
            dgvStudents.DataSource = Access.DBDT

            '   FILL COMBOBOX
            For Each R As DataRow In Access.DBDT.Rows
                cbxFilter.Items.Add(R("Full_Name"))
            Next

            ' DISPLAY FIRST NAME FOUND
            If Access.RecordCount > 0 Then cbxFilter.SelectedIndex = 0
        Else
            '   RUN QUERY 
            Access.ExecQuery("SELECT * FROM Students")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            '   FILL DATAGRID
            dgvStudents.DataSource = Access.DBDT

            '   FILL COMBOBOX
            For Each R As DataRow In Access.DBDT.Rows
                cbxFilter.Items.Add(R("Full_Name"))
            Next

            ' DISPLAY FIRST NAME FOUND
            If Access.RecordCount > 0 Then cbxFilter.SelectedIndex = 0
        End If
    End Sub
    '   RUNNING THE SEARCH AND ALSO PREVENT SQL INJECTION

    Private Sub SearchStudents(Name As String)
        If Me.Text = "Staff Profile" Then
            '   ADD PARAMETER & RUN QUERY - WILDCARD IS WHY THE PERCENTAGE IS USED(MEANING IF IT FIND ANY MATCH....)
            Access.AddParam("@FullName", "%" & Name & "%")
            Access.ExecQuery("SELECT * FROM Staff_Profile WHERE [Full_Name] LIKE @FullName")

            '   REPORT AND ABORT ON ERRORS
            '  If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            '   FILL COMBOBOX
            dgvStudents.DataSource = Access.DBDT
        Else
            '   ADD PARAMETER & RUN QUERY - WILDCARD IS WHY THE PERCENTAGE IS USED(MEANING IF IT FIND ANY MATCH....)
            Access.AddParam("@FullName", "%" & Name & "%")
            Access.ExecQuery("SELECT * FROM Students WHERE [Full_Name] LIKE @FullName")

            '   REPORT AND ABORT ON ERRORS
            '  If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            '   FILL COMBOBOX
            dgvStudents.DataSource = Access.DBDT
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchStudents(txtSearch.Text)
    End Sub

    
    Private Sub frmStudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class