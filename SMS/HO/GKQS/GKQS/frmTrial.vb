Public Class frmTrial
    Dim x As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
rat:
        x = x + 1
        If x = 6 Then
            lblTrial.ForeColor = Color.Red
        ElseIf x = 12 Then
            lblTrial.ForeColor = Color.Green
            x = 0
            else
            GoTo rat
        End If
    End Sub

    Private Sub frmTrial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub lblTrial_Click(sender As Object, e As EventArgs) Handles lblTrial.Click

    End Sub
End Class