Imports System.Data.Odbc
Public Class SailingForm
    Dim dateUnix, etaUnix, ataUnix, etdUnix, atdUnix As Long
    Dim createdAt As Long

    Sub clearField()
        dtp_daydate.Value = Date.Now
        txtbox_vesselname.Text = ""
        txtbox_captain.Text = ""
        dtp_eta.Value = Date.Now
        dtp_ata.Value = Date.Now
        dtp_etd.Value = Date.Now
        dtp_atd.Value = Date.Now
    End Sub
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM ship_data WHERE deleted_at=''", conn)
        ds = New DataSet
        da.Fill(ds, "ship_data")
        dgv_sailingform.DataSource = ds.Tables("ship_data")
        conn.Close()
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            dbconnection()
            command = "UPDATE sailing SET deleted_at=NOW() WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            showData()
            conn.Close()
        End If
    End Sub

    Sub UpdateRecord(param As String)
        dbconnection()
        command = "SELECT * FROM sailing WHERE id = '" & param & "'"
        query = New OdbcCommand(command, conn)
        If reader.HasRows Then
            command = "UPDATE sailing SET vessel_name='" & txtbox_vesselname.Text & "', captain='" & txtbox_captain.Text & "', eta='" & dtp_eta.Value & "', ata='" & dtp_ata.Value & "', etd='" & dtp_etd.Value & "', atd='" & dtp_atd.Value & "' WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            MsgBox("Data updated successfully")
            showData()
            clearField()
        End If
        conn.Close()
    End Sub
    Private Sub SailingForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Menu.Show()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text = "Update" Then
            dbconnection()
            command = "SELECT * FROM sailing WHERE id = '" & selectedID & "'"
            query = New OdbcCommand(command, conn)
            If reader.HasRows Then
                command = "UPDATE sailing SET vessel_name='" & txtbox_vesselname.Text & "', captain='" & txtbox_captain.Text & "', eta='" & dtp_eta.Value & "', ata='" & dtp_ata.Value & "', etd='" & dtp_etd.Value & "', atd='" & dtp_atd.Value & "' WHERE id='" & selectedID & "'"
                query = New OdbcCommand(command, conn)
                query.ExecuteNonQuery()
                MsgBox("Data updated successfully")
                showData()
                clearField()
            End If
            conn.Close()
            Return
        End If

        dbconnection()
        ' Convert datetimepicker value to unix time seconds
        dateUnix = New DateTimeOffset(dtp_daydate.Value).ToUnixTimeSeconds
        etaUnix = New DateTimeOffset(dtp_eta.Value).ToUnixTimeSeconds
        ataUnix = New DateTimeOffset(dtp_ata.Value).ToUnixTimeSeconds
        etdUnix = New DateTimeOffset(dtp_etd.Value).ToUnixTimeSeconds
        atdUnix = New DateTimeOffset(dtp_atd.Value).ToUnixTimeSeconds
        createdAt = New DateTimeOffset(Date.Now).ToUnixTimeSeconds
        command = "INSERT INTO ship_data (date, vessel, captain, estimate_time_arrival, actual_time_arrival, estimate_time_departure, actual_time_departure,created_at) VALUES ('" & dateUnix & "','" & txtbox_vesselname.Text & "','" & txtbox_captain.Text & "','" & etaUnix & "','" & ataUnix & "','" & etdUnix & "','" & atdUnix & "','" & createdAt & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        If MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            showData()
            clearField()
        End If
    End Sub

    Private Sub dgv_sailingform_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sailingform.CellContentClick
        If dgv_sailingform.RowCount > 0 Then
            Dim i As Integer
            i = dgv_sailingform.CurrentRow.Index
            selectedID = dgv_sailingform.Item(0, i).Value
            txtbox_vesselname.Text = dgv_sailingform.Item(1, i).Value
            txtbox_captain.Text = dgv_sailingform.Item(2, i).Value
            dtp_eta.Value = dgv_sailingform.Item(3, i).Value
            dtp_ata.Value = dgv_sailingform.Item(4, i).Value
            dtp_etd.Value = dgv_sailingform.Item(5, i).Value
            dtp_atd.Value = dgv_sailingform.Item(6, i).Value
            btn_save.Text = "Update"
        End If
    End Sub
End Class