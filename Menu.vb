Imports System.Data.Odbc
Public Class Menu
    Dim check As String

    Private Sub SailingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SailingToolStripMenuItem.Click
        Me.Hide()
        SailingForm.Show()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        dbconnection()
        check = "SELECT * FROM users WHERE username='" & txtbox_username.Text & "' AND password=SHA2('" & txtbox_password.Text & "',512) AND is_active=1 AND role='admin';"
        query = New OdbcCommand(check, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                ' Enable the MenuStrip2
                ' MenuStrip2.Enabled = True
                ' GroupBox1.Visible = False
                MsgBox("Welcome, " & reader("full_name"))
                MenuStrip2.Enabled = True
                gbox_login.Visible = False
            Else
                MsgBox("Username or password is incorrect")
            End If
        End While
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        Me.Hide()
        ImportForm.Show()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Me.Hide()
        ExportForm.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        gbox_login.Show()
        txtbox_username.Text = ""
        txtbox_password.Text = ""
        MenuStrip2.Enabled = False
    End Sub

    Private Sub CalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculationToolStripMenuItem.Click
        Me.Hide()
        CalculationForm.Show()
    End Sub
End Class
