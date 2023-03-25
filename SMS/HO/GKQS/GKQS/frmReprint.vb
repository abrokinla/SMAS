Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing
Public Class frmReprint
    Private ACCESS As New DBControl
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
    Private Sub frmReprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.Refresh()
        Dim PF As New PrintForm
        Dim xPaperSize As New PaperSize("A6", 700, 425)
        PF.Form = Me
        PF.PrinterSettings.Copies = 1
        PF.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(1, 1, 1, 1)

        PF.PrinterSettings.DefaultPageSettings.Landscape = False
        'SET PAGE SIZE
        PF.PrinterSettings.DefaultPageSettings.PaperSize = xPaperSize
        PF.PrintAction = PrintAction.PrintToPreview

        btnPrint.Visible = False
        btnClose.Visible = False
        PF.Print()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class