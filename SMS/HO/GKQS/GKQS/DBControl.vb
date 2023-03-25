Imports System.Data.OleDb

Public Class DBControl
    '   CREATE THE DATABASE CONNECTION 
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                         "Data Source=GKQS.accdb;")

    '   PREPARE DB COMMAND
    Private DBCmd As OleDbCommand

    '   DATABASE DATA - DBDA MEANS DATABASE DATA ADAPTER
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable '  DATABASE DATA TABLE

    '   QUERY PARAMETERS 
    Public Params As New List(Of OleDbParameter)

    '   QUERY STATISTICS
    Public RecordCount As Integer ' This could be Student ID or Staff ID
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        '   RESET QUERY STATS 
        RecordCount = 0
        Exception = ""

        '   HANDLE ERRORS
        Try
            '   OPEN A CONNECTION 
            DBCon.Open()

            '   CREATE DATABASE COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            '   LOAD PARAMS INTO DATABASE COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            '   CLEAR PARAMS LIST
            Params.Clear()

            '   EXECUTE COMMAND & FILL DATATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        '   CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    '   INCLUDE QUERY & COMMAND PARAMETERS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Sub AddParam(p1 As String)
        Throw New NotImplementedException
    End Sub

End Class
