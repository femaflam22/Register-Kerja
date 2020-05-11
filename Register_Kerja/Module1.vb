Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public conec As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public simpendata As String
    Public Sub konek()
        simpendata = "provider=microsoft.jet.oledb.4.0;data source=kerja.mdb"
        conec = New OleDbConnection(simpendata)
        If conec.State = ConnectionState.Closed Then
            conec.Open()
        End If
    End Sub
End Module
