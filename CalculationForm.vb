Imports System.Data.Odbc
Public Class CalculationForm
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT id, DATE_FORMAT(FROM_UNIXTIME(date), '%c/%e/%Y '), voyage_number, DATE_FORMAT(FROM_UNIXTIME(start_loading_time), '%c/%e/%Y %r'), DATE_FORMAT(FROM_UNIXTIME(finish_loading_time), '%c/%e/%Y %r'), quantity, team_supervisor, DATE_FORMAT(FROM_UNIXTIME(created_at), '%c/%e/%Y %r') FROM loading_data WHERE deleted_at='0' OR deleted_at='' ORDER BY date DESC", conn)
        ds = New DataSet
        da.Fill(ds, "loading_data")
        dgv_timecalculationreport.DataSource = ds.Tables("loading_data")
        conn.Close()
    End Sub
    Sub filteredCalculationForm(dateForm As String, dateTo As String)
        dbconnection()
        Dim query As String = "SELECT * FROM calculation_form WHERE day_date BETWEEN ? AND ?"
        Dim cmd As New OdbcCommand(query, conn)
        cmd.Parameters.AddWithValue("?", dateForm)
        cmd.Parameters.AddWithValue("?", dateTo)
        da = New OdbcDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "calculation_form")
        dgv_timecalculationreport.DataSource = ds.Tables("calculation_form")
        conn.Close()
    End Sub
    Private Sub btn_viewreport_Click(sender As Object, e As EventArgs) Handles btn_viewreport.Click
        filteredCalculationForm(dtp_datefrom.Value, dtp_dateto.Value)
    End Sub

    Private Sub CalculationForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Menu.Show()
    End Sub
End Class