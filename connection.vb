Imports System.Data.Odbc
Module connection
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public query As OdbcCommand
    Public ds As DataSet
    Public reader As OdbcDataReader
    Public command, selectedID As String
    Public dateUnix, etaUnix, ataUnix, etdUnix, atdUnix As Long
    Public createdAt As Long
    Public Sub dbconnection()
        Dim teks As String = "driver=MySQL ODBC 8.4 ANSI Driver;dsn=eximtimecalculation.dsn;server=ritalinserver.ddns.net;uid=ariebrainware;password=huvtex-diqjuK-2bakmi;database=pinguinferryjasa;port=13306"
        conn = New OdbcConnection(teks)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
