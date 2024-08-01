Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class ExportForm
    Dim startLoadUnix, finishLoadUnix, packageExportUnix As Long
    Sub clearField()
        dtp_daydate.Value = Date.Now
        txtbox_voyagenumber.Text = ""
        dtp_startload.Value = Date.Now
        dtp_finishload.Value = Date.Now
        txtbox_packageexport.Text = ""
        txtbox_spvteam.Text = ""
        btn_save.Text = "Save"
    End Sub
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT id, 
            DATE_FORMAT(FROM_UNIXTIME(date), '%c/%e/%Y ') AS date, 
            voyage_number, 
            DATE_FORMAT(FROM_UNIXTIME(start_loading_time), '%c/%e/%Y %r') AS start_loading_time,
            DATE_FORMAT(FROM_UNIXTIME(finish_loading_time), '%c/%e/%Y %r') AS finish_loading_time, 
            quantity, 
            team_supervisor, 
            DATE_FORMAT(FROM_UNIXTIME(created_at), '%c/%e/%Y %r') created_at 
            FROM loading_data WHERE deleted_at='0' OR deleted_at='' ORDER BY loading_data.date DESC", conn)
        ds = New DataSet
        da.Fill(ds, "loading_data")
        dgv_exportform.DataSource = ds.Tables("loading_data")
        conn.Close()
    End Sub
    Sub setDGVColumHeader()
        dgv_exportform.Columns(0).HeaderText = "ID"
        dgv_exportform.Columns(1).HeaderText = "Date"
        dgv_exportform.Columns(2).HeaderText = "Voyage Number"
        dgv_exportform.Columns(3).HeaderText = "Start Load"
        dgv_exportform.Columns(4).HeaderText = "Finish Load"
        dgv_exportform.Columns(5).HeaderText = "Package Export"
        dgv_exportform.Columns(6).HeaderText = "SPV Team"
        dgv_exportform.Columns(7).HeaderText = "Created At"
    End Sub
    Sub UpdateRecord(param As String)
        dbconnection()
        'command = "SELECT * FROM loading_data WHERE id = '" & param & "'"
        ' Convert datetimepicker value to unix time seconds
        dateUnix = New DateTimeOffset(dtp_daydate.Value).ToUnixTimeSeconds
        startLoadUnix = New DateTimeOffset(dtp_startload.Value).ToUnixTimeSeconds
        finishLoadUnix = New DateTimeOffset(dtp_finishload.Value).ToUnixTimeSeconds
        query = New OdbcCommand(command, conn)

        command = "UPDATE loading_data SET date=" & dateUnix & ", 
            voyage_number='" & txtbox_voyagenumber.Text & "', 
            start_loading_time=" & startLoadUnix & ", 
            finish_loading_time=" & finishLoadUnix & ", 
            quantity=" & txtbox_packageexport.Text & ", 
            team_supervisor='" & txtbox_spvteam.Text & "' 
            WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        MsgBox("Data updated successfully")
        showData()
        clearField()

        conn.Close()
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim now = ConvertDateTimeToUnix(Date.Now)
            dbconnection()
            command = "UPDATE loading_data SET deleted_at='" & now & "' WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            showData()
            conn.Close()
        End If
    End Sub
    Private Sub ExportForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Menu.Show()
    End Sub

    Private Sub ExportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_exportform.Columns.Clear()
        showData()
        'setDGVColumHeader()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text = "Update" Then
            UpdateRecord(selectedID)
        Else
            dbconnection()
            dateUnix = New DateTimeOffset(dtp_daydate.Value).ToUnixTimeSeconds
            startLoadUnix = New DateTimeOffset(dtp_startload.Value).ToUnixTimeSeconds
            finishLoadUnix = New DateTimeOffset(dtp_finishload.Value).ToUnixTimeSeconds
            createdAt = New DateTimeOffset(Date.Now).ToUnixTimeSeconds
            command = "INSERT INTO loading_data (date, voyage_number, start_loading_time, finish_loading_time, quantity, team_supervisor, created_at) VALUES ('" & dateUnix & "','" & txtbox_voyagenumber.Text & "','" & startLoadUnix & "','" & finishLoadUnix & "','" & txtbox_packageexport.Text & "','" & txtbox_spvteam.Text & "','" & createdAt & "')"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            MsgBox("Data saved successfully")
            showData()
            clearField()
            conn.Close()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If selectedID = "" Then
            MsgBox("Please select the data you want to delete")
        Else
            DeleteRecord(selectedID)
            clearField()
        End If
    End Sub

    Private Sub txtbox_packageexport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_packageexport.KeyPress
        TextBoxValidateNumberOnly(e)
    End Sub

    Private Sub txtbox_packageexport_TextChanged(sender As Object, e As EventArgs) Handles txtbox_packageexport.TextChanged
        txtbox_packageexport.Text = digitsOnly.Replace(txtbox_packageexport.Text, "")
        txtbox_packageexport.SelectionStart = txtbox_packageexport.Text.Length
    End Sub

    Private Sub dgv_exportform_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_exportform.CellClick
        If dgv_exportform.RowCount > 0 Then
            Dim i As Integer
            i = dgv_exportform.CurrentRow.Index

            selectedID = dgv_exportform.Item(0, i).Value
            dtp_daydate.Value = dgv_exportform.Item(1, i).Value
            txtbox_voyagenumber.Text = dgv_exportform.Item(2, i).Value
            dtp_startload.Value = dgv_exportform.Item(3, i).Value
            dtp_finishload.Value = dgv_exportform.Item(4, i).Value
            txtbox_packageexport.Text = dgv_exportform.Item(5, i).Value
            txtbox_spvteam.Text = dgv_exportform.Item(6, i).Value
            btn_save.Text = "Update"
        End If
    End Sub
End Class
