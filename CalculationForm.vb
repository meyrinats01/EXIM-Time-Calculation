Imports System.Data.Odbc
Public Class CalculationForm
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT id, DATE_FORMAT(FROM_UNIXTIME(date), '%c/%e/%Y '), voyage_number, DATE_FORMAT(FROM_UNIXTIME(start_loading_time), '%c/%e/%Y %r'), DATE_FORMAT(FROM_UNIXTIME(finish_loading_time), '%c/%e/%Y %r'), quantity, team_supervisor, DATE_FORMAT(FROM_UNIXTIME(created_at), '%c/%e/%Y %r') FROM loading_data WHERE deleted_at='0' OR deleted_at=''", conn)
        ds = New DataSet
        da.Fill(ds, "loading_data")
        dgv_timecalculationreport.DataSource = ds.Tables("loading_data")
        conn.Close()
    End Sub
    Private Sub btn_viewreport_Click(sender As Object, e As EventArgs) Handles btn_viewreport.Click

    End Sub
End Class