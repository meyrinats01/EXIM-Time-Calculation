<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        MenuStrip2 = New MenuStrip()
        SailingToolStripMenuItem = New ToolStripMenuItem()
        ImportToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        CalculationToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        lbl_welcome = New Label()
        lbl_loading = New Label()
        lbl_copyright = New Label()
        gbox_login = New GroupBox()
        btn_login = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtbox_password = New TextBox()
        txtbox_username = New TextBox()
        MenuStrip2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        gbox_login.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Enabled = False
        MenuStrip2.Font = New Font("Segoe UI", 19F)
        MenuStrip2.Items.AddRange(New ToolStripItem() {SailingToolStripMenuItem, ImportToolStripMenuItem, ExportToolStripMenuItem, CalculationToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1556, 39)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' SailingToolStripMenuItem
        ' 
        SailingToolStripMenuItem.Font = New Font("Segoe UI", 17F)
        SailingToolStripMenuItem.Name = "SailingToolStripMenuItem"
        SailingToolStripMenuItem.Size = New Size(95, 35)
        SailingToolStripMenuItem.Text = "Sailing"
        ' 
        ' ImportToolStripMenuItem
        ' 
        ImportToolStripMenuItem.Font = New Font("Segoe UI", 17F)
        ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        ImportToolStripMenuItem.Size = New Size(95, 35)
        ImportToolStripMenuItem.Text = "Import"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Font = New Font("Segoe UI", 17F)
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(92, 35)
        ExportToolStripMenuItem.Text = "Export"
        ' 
        ' CalculationToolStripMenuItem
        ' 
        CalculationToolStripMenuItem.Font = New Font("Segoe UI", 17F)
        CalculationToolStripMenuItem.Name = "CalculationToolStripMenuItem"
        CalculationToolStripMenuItem.Size = New Size(140, 35)
        CalculationToolStripMenuItem.Text = "Calculation"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Font = New Font("Segoe UI", 17F)
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(108, 35)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(798, 764)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lbl_welcome
        ' 
        lbl_welcome.AutoSize = True
        lbl_welcome.Font = New Font("Segoe UI", 40F)
        lbl_welcome.Location = New Point(804, 92)
        lbl_welcome.Name = "lbl_welcome"
        lbl_welcome.Size = New Size(359, 72)
        lbl_welcome.TabIndex = 3
        lbl_welcome.Text = "WELCOME TO"
        ' 
        ' lbl_loading
        ' 
        lbl_loading.AutoSize = True
        lbl_loading.Font = New Font("Segoe UI", 38F)
        lbl_loading.Location = New Point(804, 178)
        lbl_loading.Name = "lbl_loading"
        lbl_loading.Size = New Size(750, 136)
        lbl_loading.TabIndex = 4
        lbl_loading.Text = "Loading-Unloading Duration " & vbCrLf & "System of PT Penguin Ferry Jasa"
        ' 
        ' lbl_copyright
        ' 
        lbl_copyright.AutoSize = True
        lbl_copyright.Location = New Point(1745, 1017)
        lbl_copyright.Name = "lbl_copyright"
        lbl_copyright.Size = New Size(147, 15)
        lbl_copyright.TabIndex = 5
        lbl_copyright.Text = "PT Penguin Ferry Jasa 2024"
        ' 
        ' gbox_login
        ' 
        gbox_login.Controls.Add(btn_login)
        gbox_login.Controls.Add(Label2)
        gbox_login.Controls.Add(Label1)
        gbox_login.Controls.Add(txtbox_password)
        gbox_login.Controls.Add(txtbox_username)
        gbox_login.Location = New Point(804, 345)
        gbox_login.Name = "gbox_login"
        gbox_login.Size = New Size(740, 443)
        gbox_login.TabIndex = 10
        gbox_login.TabStop = False
        gbox_login.Text = "Login"
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Segoe UI", 30F)
        btn_login.Location = New Point(336, 361)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(178, 64)
        btn_login.TabIndex = 2
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30F)
        Label2.Location = New Point(6, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 54)
        Label2.TabIndex = 13
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F)
        Label1.Location = New Point(6, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 54)
        Label1.TabIndex = 12
        Label1.Text = "Username"
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Font = New Font("Segoe UI", 30F)
        txtbox_password.Location = New Point(286, 179)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "*"c
        txtbox_password.Size = New Size(438, 61)
        txtbox_password.TabIndex = 1
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Font = New Font("Segoe UI", 30F)
        txtbox_username.Location = New Point(286, 48)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(438, 61)
        txtbox_username.TabIndex = 0
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1556, 800)
        Controls.Add(gbox_login)
        Controls.Add(lbl_copyright)
        Controls.Add(lbl_loading)
        Controls.Add(lbl_welcome)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Menu"
        Text = "MENU"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        gbox_login.ResumeLayout(False)
        gbox_login.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SailingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents lbl_loading As Label
    Friend WithEvents lbl_copyright As Label
    Friend WithEvents gbox_login As GroupBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents txtbox_username As TextBox

End Class
