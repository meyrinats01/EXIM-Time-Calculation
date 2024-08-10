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
        Dim teks As String = "Driver={MySQL ODBC 8.4 ANSI Driver};big_packets=1;database=pinguinferryjasa;db=pinguinferryjasa_backup;multi_host=1;multi_statements=1;no_schema=1;port=13306;server=ritalinserver.ddns.net;uid=ariebrainware;user=ariebrainware;password=huvtex-diqjuK-2bakmi"
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
        Dim dateTimeValue = DateTimeOffset.FromUnixTimeSeconds(param).DateTime.ToLocalTime
        Return dateTimeValue
    End Function
    Public Function DataGridItemDateTimeStringToDateTimeValue(param As String)
        Dim dateTimeValue = DateTimeOffset.Parse(param).DateTime.ToLocalTime
        Return dateTimeValue
    End Function
End Module
