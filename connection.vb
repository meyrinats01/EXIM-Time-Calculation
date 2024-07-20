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
    Public digitsOnly As New System.Text.RegularExpressions.Regex("[^\d]")
    Public Sub dbconnection()
        Dim teks As String = "driver=MySQL ODBC 8.4 ANSI Driver;dsn=eximtimecalculation.dsn;server=ritalinserver.ddns.net;uid=ariebrainware;password=huvtex-diqjuK-2bakmi;database=pinguinferryjasa;port=13306"
        conn = New OdbcConnection(teks)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Function ConvertDateTimeToUnix(param As DateTime)
        Dim unixTime = New DateTimeOffset(param).ToUnixTimeSeconds
        Return unixTime
    End Function

    Public Sub TextBoxValidateNumberOnly(e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                e.Handled = True
            End If
        End If
        Return
    End Sub
    Public Function ConvertUnixToDateTime(param As Long)
        Dim dateTimeValue = DateTimeOffset.FromUnixTimeSeconds(param).DateTime
        Return dateTimeValue
    End Function
End Module
