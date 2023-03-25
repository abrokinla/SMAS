Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing
Public Class frmPrintReciept
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

    Private Sub frmPrintReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Now.ToString("MM-dd-yyyy")
        lblDate2.Text = Date.Now.ToString("MM-dd-yyyy")

        ACCESS.AddParam("@PaymentDate", lblDate.Text)
        ACCESS.AddParam("@Name", lblName.Text)
        ACCESS.AddParam("@Class", lblClass.Text)

        ACCESS.ExecQuery("SELECT NumID FROM Accounting where [Payment_Date] = @PaymentDate AND [Full_Name] = @Name AND Class = @Class")
        If NoErrors(True) = False OrElse ACCESS.RecordCount < 1 Then Exit Sub
        Dim R As DataRow = ACCESS.DBDT(CurrentRecord)
        Dim A As String
        A = Date.Now.ToString("yyyy")
        lblReceipt.Text = "GKQS/" & A & "/" & R("NumID")
        lblReceipt2.Text = "GKQS/" & A & "/" & R("NumID")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        With ACCESS
            .AddParam("@ReceiptNum", lblReceipt.Text)
            .AddParam("@Student", lblName.Text)
            .AddParam("@PaymentDate", lblDate.Text)
            .AddParam("@AmountWords", txtAmountWords.Text)
            .AddParam("@Term", lblTerm.Text)
            .AddParam("@Ses", lblSes.Text)
            .AddParam("@Class", lblClass.Text)
            .AddParam("@AmountPaid", lblAmount.Text)
            .AddParam("@PaidBy", lblPaidBy.Text)
            .AddParam("@Mode", lblMode.Text)
            .AddParam("@Bank", lblBank.Text)
            .AddParam("@Outstanding", lblBalance.Text)
            .AddParam("@PaidFor", Label7.Text)

            'QUERY
            .ExecQuery("INSERT INTO Receipt ([Receipt_Num], [Student_Name], [Payment_Date], [Amount_Words], Term, Ses, [Clas], [Amount_Paid], [Paid_By], Payment_Mode, Bank, Outstanding, Payment_For)" & _
                       "VALUES (@ReceiptNum, @Student, @PaymentDate, @AmountWords, @Term, @Ses, @Class, @AmountPaid, @PaidBy, @Mode, @Bank, @Outstanding, @PaidFor)")
        End With
        ReportErrors()


        MessageBox.Show("Done")


        Me.Refresh()
        Dim PF As New PrintForm
        Dim xPaperSize As New PaperSize("A6", 700, 425)
        PF.Form = Me
        PF.PrinterSettings.Copies = 1
        PF.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(1, 1, 1, 1)
        '  PF.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = Printing.PaperKind.A6

        PF.PrinterSettings.DefaultPageSettings.Landscape = False
        'SET PAGE
        PF.PrinterSettings.DefaultPageSettings.PaperSize = xPaperSize
        PF.PrintAction = PrintAction.PrintToPrinter
        btnPrint.Visible = False
        btnClose.Visible = False
        PF.Print()
        Me.Close()
        frmPayFees.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        With ACCESS
            .AddParam("@ReceiptNum", lblReceipt.Text)
            .AddParam("@Student", lblName.Text)
            .AddParam("@PaymentDate", lblDate.Text)
            .AddParam("@AmountWords", txtAmountWords.Text)
            .AddParam("@Term", lblTerm.Text)
            .AddParam("@Ses", lblSes.Text)
            .AddParam("@Class", lblClass.Text)
            .AddParam("@AmountPaid", lblAmount.Text)
            .AddParam("@PaidBy", lblPaidBy.Text)
            .AddParam("@Mode", lblMode.Text)
            .AddParam("@Bank", lblBank.Text)
            .AddParam("@Outstanding", lblBalance.Text)
            .AddParam("@PaidFor", Label7.Text)

            'QUERY
            .ExecQuery("INSERT INTO Receipt ([Receipt_Num], [Student_Name], [Payment_Date], [Amount_Words], Term, Ses, [Clas], [Amount_Paid], [Paid_By], Payment_Mode, Bank, Outstanding, Payment_For)" & _
                       "VALUES (@ReceiptNum, @Student, @PaymentDate, @AmountWords, @Term, @Ses, @Class, @AmountPaid, @PaidBy, @Mode, @Bank, @Outstanding, @PaidFor)")
        End With
        ReportErrors()

        ' CLOSE FORM
        Me.Close()
        frmPayFees.Show()
    End Sub
    Function NumberToText(ByVal n As Integer) As String
        ' functio to convert from numbers to words
        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", _
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", _
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Million " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberTotext(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

    Private Sub lblAmount_TextChanged(sender As Object, e As EventArgs) Handles lblAmount.TextChanged
        'Write amount in words
        Dim ThisNumber As String
        ThisNumber = NumberToText(lblAmount.Text) & " Naira Only"
        txtAmountWords.Text = ThisNumber
        txtAmountwords2.Text = txtAmountWords.Text
    End Sub

End Class