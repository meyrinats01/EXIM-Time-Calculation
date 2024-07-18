﻿Imports System.Data.Odbc
Public Class SailingForm
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
        da = New OdbcDataAdapter("SELECT * FROM ship_data WHERE deleted_at='0'", conn)
        ds = New DataSet
        da.Fill(ds, "ship_data")
        dgv_sailingform.DataSource = ds.Tables("ship_data")
        conn.Close()
    End Sub
    Sub DeleteRecord(param As String)
        If MessageBox.Show("Are you sure want to delete item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim now = ConvertDateTimeToUnix(Date.Now)
            dbconnection()
            command = "UPDATE ship_data SET deleted_at='" & now & "' WHERE id='" & param & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            showData()
            conn.Close()
        End If
    End Sub

    Sub UpdateRecord(param As String)
        dbconnection()
        'command = "SELECT * FROM ship_data WHERE id = '" & param & "'"
        ' Convert datetimepicker value to unix time seconds
        dateUnix = New DateTimeOffset(dtp_daydate.Value).ToUnixTimeSeconds
        etaUnix = New DateTimeOffset(dtp_eta.Value).ToUnixTimeSeconds
        ataUnix = New DateTimeOffset(dtp_ata.Value).ToUnixTimeSeconds
        etdUnix = New DateTimeOffset(dtp_etd.Value).ToUnixTimeSeconds
        atdUnix = New DateTimeOffset(dtp_atd.Value).ToUnixTimeSeconds
        query = New OdbcCommand(command, conn)

        command = "UPDATE ship_data SET date=" & dateUnix & ", vessel='" & txtbox_vesselname.Text & "', captain='" & txtbox_captain.Text & "', estimate_time_arrival=" & etaUnix & ", actual_time_arrival=" & ataUnix & ", estimate_time_departure=" & etdUnix & ", actual_time_departure=" & atdUnix & " WHERE id='" & param & "'"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        MsgBox("Data updated successfully")
        showData()
        clearField()

        conn.Close()
    End Sub
    Sub SetDGVHeader()
        dgv_sailingform.Columns(0).HeaderText = "ID"
        dgv_sailingform.Columns(1).HeaderText = "Date"
        dgv_sailingform.Columns(2).HeaderText = "Vessel Name"
        dgv_sailingform.Columns(3).HeaderText = "Captain"
        dgv_sailingform.Columns(4).HeaderText = "Estimate Time Arrival"
        dgv_sailingform.Columns(5).HeaderText = "Actual Time Arrival"
        dgv_sailingform.Columns(6).HeaderText = "Package Import Quantity"
        dgv_sailingform.Columns(7).HeaderText = "Voyage Number"
        dgv_sailingform.Columns(8).HeaderText = "Estimate Time Departure"
        dgv_sailingform.Columns(9).HeaderText = "Actual Time Departure"
        dgv_sailingform.Columns(10).HeaderText = "Package Export Quantity"
        dgv_sailingform.Columns(11).HeaderText = "Created At"
    End Sub

    Function ConvertDateTimeToUnix(param As DateTime)
        Dim unixTime = New DateTimeOffset(param).ToUnixTimeSeconds
        Return unixTime
    End Function
    Function ConvertUnixToDateTime(param As Long)
        Dim dateTimeValue = DateTimeOffset.FromUnixTimeSeconds(param).DateTime
        Return dateTimeValue
    End Function
    Private Sub SailingForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Menu.Show()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text = "Update" Then

            UpdateRecord(selectedID)
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
            dtp_daydate.Value = ConvertUnixToDateTime(dgv_sailingform.Item(1, i).Value)
            txtbox_vesselname.Text = dgv_sailingform.Item(2, i).Value
            txtbox_captain.Text = dgv_sailingform.Item(3, i).Value
            dtp_eta.Value = ConvertUnixToDateTime(dgv_sailingform.Item(4, i).Value)
            dtp_ata.Value = ConvertUnixToDateTime(dgv_sailingform.Item(5, i).Value)
            dtp_etd.Value = ConvertUnixToDateTime(dgv_sailingform.Item(8, i).Value)
            dtp_atd.Value = ConvertUnixToDateTime(dgv_sailingform.Item(9, i).Value)
            btn_save.Text = "Update"
        End If
    End Sub

    Private Sub SailingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_sailingform.Columns.Clear()
        showData()
        SetDGVHeader()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If selectedID = "" Then
            MsgBox("Please select a record to delete")
            Return
        Else
            DeleteRecord(selectedID)
        End If
    End Sub
End Class