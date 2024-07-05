Imports System.Data.Odbc
Public Class menu
    Dim check As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_welcome.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_loading.Click

    End Sub

    Private Sub SailingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SailingToolStripMenuItem.Click

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        dbconnection()
        check = "SELECT * FROM users WHERE username='" & txtbox_username.Text & "' AND password=SHA2('" & txtbox_password.Text & "',512) AND is_active='true' AND role='admin';"
        query = New OdbcCommand(check, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                ' Enable the MenuStrip2
                ' MenuStrip2.Enabled = True
                ' GroupBox1.Visible = False
                MsgBox("Welcome, " & reader("full_name"))
            Else
                MsgBox("Username or password is incorrect")
            End If
        End While
    End Sub
End Class
