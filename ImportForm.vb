Imports System.Data.Odbc
Public Class ImportForm
    Dim startUnloadUnix, finishUnloadUnix, packageImportUnix As Long
    Sub clearField()
        dtp_daydate.Value = Date.Now
        txtbox_voyagenumber.Text = ""
        dtp_startunload.Value = Date.Now
        dtp_finishunload.Value = Date.Now
        txtbox_packageimport.Text = ""
        txtbox_spvteam.Text = ""
        btn_save.Text = "Save"
    End Sub
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT id, 
            DATE_FORMAT(FROM_UNIXTIME(date), '%c/%e/%Y ') AS date, 
            voyage_number, 
            DATE_FORMAT(FROM_UNIXTIME(start_unloading_time), '%c/%e/%Y %r') AS start_unloading_time, 
            DATE_FORMAT(FROM_UNIXTIME(finish_unloading_time), '%c/%e/%Y %r') AS finish_unloading_time, 
            quantity, 
            team_supervisor, 
            DATE_FORMAT(FROM_UNIXTIME(created_at), '%c/%e/%Y %r') AS created_at 
            FROM unloading_data WHERE deleted_at='0' OR deleted_at=''", conn)
        ds = New DataSet
        da.Fill(ds, "unloading_data")
        dgv_importform.DataSource = ds.Tables("unloading_data")
        conn.Close()
    End Sub
    Sub setDGVColumHeader()
        dgv_importform.Columns(0).HeaderText = "ID"
        dgv_importform.Columns(1).HeaderText = "Date"
        dgv_importform.Columns(2).HeaderText = "Voyage Number"
        dgv_importform.Columns(3).HeaderText = "Start Unload"
        dgv_importform.Columns(4).HeaderText = "Finish Unload"
        dgv_importform.Columns(5).HeaderText = "Package Import"
        dgv_importform.Columns(6).HeaderText = "SPV Team"
        dgv_importform.Columns(7).HeaderText = "Created At"
    End Sub
    Sub UpdateRecord(param As String)
        dbconnection()
        'command = "SELECT * FROM unloading_data WHERE id = '" & param & "'"
        ' Convert datetimepicker value to unix time seconds
        dateUnix = New DateTimeOffset(dtp_daydate.Value).ToUnixTimeSeconds
        startUnloadUnix = New DateTimeOffset(dtp_startunload.Value).ToUnixTimeSeconds
        finishUnloadUnix = New DateTimeOffset(dtp_finishunload.Value).ToUnixTimeSeconds
        query = New OdbcCommand(command, conn)

        command = "UPDATE unloading_data SET date=" & dateUnix & ", voyage_number='" & txtbox_voyagenumber.Text & "', start_unloading_time=" & startUnloadUnix & ", finish_unloading_time=" & finishUnloadUnix & ", quantity=" & txtbox_packageimport.Text & ", team_supervisor='" & txtbox_spvteam.Text & "' WHERE id='" & param & "'"
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
            command = "UPDATE unloading_data SET deleted_at='" & now & "' WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            showData()
            conn.Close()
        End If
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text = "SAVE" Then
            dbconnection()
            dateUnix = New DateTimeOffset(dtp_daydate.Value).ToUnixTimeSeconds
            startUnloadUnix = New DateTimeOffset(dtp_startunload.Value).ToUnixTimeSeconds
            finishUnloadUnix = New DateTimeOffset(dtp_finishunload.Value).ToUnixTimeSeconds
            packageImportUnix = Convert.ToInt64(txtbox_packageimport.Text)
            createdAt = ConvertDateTimeToUnix(Date.Now)
            command = "INSERT INTO unloading_data (date, voyage_number, start_unloading_time, finish_unloading_time, quantity, team_supervisor, created_at) VALUES ('" & dateUnix & "', '" & txtbox_voyagenumber.Text & "', '" & startUnloadUnix & "', '" & finishUnloadUnix & "', '" & packageImportUnix & "', '" & txtbox_spvteam.Text & "', '" & createdAt & "')"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            MsgBox("Data saved successfully")
            showData()
            clearField()
            conn.Close()
        Else
            UpdateRecord(selectedID)
        End If
    End Sub
    Private Sub ImportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_importform.Columns.Clear()
        showData()
        'setDGVColumHeader()
    End Sub

    Private Sub ImportForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Menu.Show()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If selectedID = "" Then
            MsgBox("Please select item to delete")
        Else
            DeleteRecord(selectedID)
        End If
    End Sub
    Private Sub txtbox_packageimport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_packageimport.KeyPress
        TextBoxValidateNumberOnly(e)
    End Sub
    Private Sub txtbox_packageimport_TextChanged(sender As Object, e As EventArgs) Handles txtbox_packageimport.TextChanged
        txtbox_packageimport.Text = digitsOnly.Replace(txtbox_packageimport.Text, "")
        txtbox_packageimport.SelectionStart = txtbox_packageimport.Text.Length
    End Sub

    Private Sub dgv_importform_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_importform.CellClick
        Dim i As Integer
        i = dgv_importform.CurrentRow.Index
        selectedID = dgv_importform.Item(0, i).Value
        dtp_daydate.Value = ConvertUnixToDateTime(dgv_importform.Item(1, i).Value)
        txtbox_voyagenumber.Text = dgv_importform.Item(2, i).Value
        dtp_startunload.Value = ConvertUnixToDateTime(dgv_importform.Item(3, i).Value)
        dtp_finishunload.Value = ConvertUnixToDateTime(dgv_importform.Item(4, i).Value)
        txtbox_packageimport.Text = dgv_importform.Item(5, i).Value
        txtbox_spvteam.Text = dgv_importform.Item(6, i).Value
        btn_save.Text = "Update"
    End Sub
End Class