<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        gbox_exportform = New GroupBox()
        txtbox_packageexport = New TextBox()
        txtbox_spvteam = New TextBox()
        dtp_daydate = New DateTimePicker()
        Label8 = New Label()
        txtbox_voyagenumber = New TextBox()
        dtp_finishload = New DateTimePicker()
        dtp_startload = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        btn_delete = New Button()
        Label4 = New Label()
        Label5 = New Label()
        btn_save = New Button()
        Label6 = New Label()
        dgv_exportform = New DataGridView()
        gbox_exportform.SuspendLayout()
        CType(dgv_exportform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbox_exportform
        ' 
        gbox_exportform.Controls.Add(txtbox_packageexport)
        gbox_exportform.Controls.Add(txtbox_spvteam)
        gbox_exportform.Controls.Add(dtp_daydate)
        gbox_exportform.Controls.Add(Label8)
        gbox_exportform.Controls.Add(txtbox_voyagenumber)
        gbox_exportform.Controls.Add(dtp_finishload)
        gbox_exportform.Controls.Add(dtp_startload)
        gbox_exportform.Controls.Add(Label1)
        gbox_exportform.Controls.Add(Label2)
        gbox_exportform.Controls.Add(DateTimePicker1)
        gbox_exportform.Controls.Add(Label3)
        gbox_exportform.Controls.Add(btn_delete)
        gbox_exportform.Controls.Add(Label4)
        gbox_exportform.Controls.Add(Label5)
        gbox_exportform.Controls.Add(btn_save)
        gbox_exportform.Controls.Add(Label6)
        gbox_exportform.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        gbox_exportform.Location = New Point(13, 17)
        gbox_exportform.Margin = New Padding(4)
        gbox_exportform.Name = "gbox_exportform"
        gbox_exportform.Padding = New Padding(4)
        gbox_exportform.Size = New Size(1003, 393)
        gbox_exportform.TabIndex = 33
        gbox_exportform.TabStop = False
        gbox_exportform.Text = "Export Form"
        ' 
        ' txtbox_packageexport
        ' 
        txtbox_packageexport.Font = New Font("Segoe UI", 12F)
        txtbox_packageexport.Location = New Point(404, 289)
        txtbox_packageexport.Margin = New Padding(4)
        txtbox_packageexport.Name = "txtbox_packageexport"
        txtbox_packageexport.Size = New Size(345, 29)
        txtbox_packageexport.TabIndex = 4
        ' 
        ' txtbox_spvteam
        ' 
        txtbox_spvteam.Font = New Font("Segoe UI", 12F)
        txtbox_spvteam.Location = New Point(404, 344)
        txtbox_spvteam.Margin = New Padding(4)
        txtbox_spvteam.Name = "txtbox_spvteam"
        txtbox_spvteam.Size = New Size(345, 29)
        txtbox_spvteam.TabIndex = 5
        ' 
        ' dtp_daydate
        ' 
        dtp_daydate.Font = New Font("Segoe UI", 12F)
        dtp_daydate.Location = New Point(404, 53)
        dtp_daydate.Margin = New Padding(4)
        dtp_daydate.Name = "dtp_daydate"
        dtp_daydate.Size = New Size(345, 29)
        dtp_daydate.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(25, 66)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 21)
        Label8.TabIndex = 30
        Label8.Text = "Day/Date"
        ' 
        ' txtbox_voyagenumber
        ' 
        txtbox_voyagenumber.Font = New Font("Segoe UI", 12F)
        txtbox_voyagenumber.Location = New Point(404, 106)
        txtbox_voyagenumber.Margin = New Padding(4)
        txtbox_voyagenumber.Name = "txtbox_voyagenumber"
        txtbox_voyagenumber.Size = New Size(345, 29)
        txtbox_voyagenumber.TabIndex = 1
        ' 
        ' dtp_finishload
        ' 
        dtp_finishload.Font = New Font("Segoe UI", 12F)
        dtp_finishload.Format = DateTimePickerFormat.Time
        dtp_finishload.Location = New Point(404, 231)
        dtp_finishload.Margin = New Padding(4)
        dtp_finishload.Name = "dtp_finishload"
        dtp_finishload.Size = New Size(345, 29)
        dtp_finishload.TabIndex = 3
        ' 
        ' dtp_startload
        ' 
        dtp_startload.Font = New Font("Segoe UI", 12F)
        dtp_startload.Format = DateTimePickerFormat.Time
        dtp_startload.Location = New Point(404, 167)
        dtp_startload.Margin = New Padding(4)
        dtp_startload.Name = "dtp_startload"
        dtp_startload.Size = New Size(345, 29)
        dtp_startload.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(33, -27)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 21)
        Label1.TabIndex = 8
        Label1.Text = "Day/Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(25, 120)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 21)
        Label2.TabIndex = 9
        Label2.Text = "Voyage Number"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(411, -41)
        DateTimePicker1.Margin = New Padding(4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(345, 29)
        DateTimePicker1.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(25, 176)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 21)
        Label3.TabIndex = 10
        Label3.Text = "Start Load"
        ' 
        ' btn_delete
        ' 
        btn_delete.Font = New Font("Segoe UI", 12F)
        btn_delete.Location = New Point(839, 304)
        btn_delete.Margin = New Padding(4)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(129, 67)
        btn_delete.TabIndex = 7
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(25, 233)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 11
        Label4.Text = "Finish Load"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(25, 297)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 21)
        Label5.TabIndex = 12
        Label5.Text = "Package Export"
        ' 
        ' btn_save
        ' 
        btn_save.Font = New Font("Segoe UI", 12F)
        btn_save.Location = New Point(839, 176)
        btn_save.Margin = New Padding(4)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(129, 67)
        btn_save.TabIndex = 6
        btn_save.Text = "SAVE"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(25, 353)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 21)
        Label6.TabIndex = 13
        Label6.Text = "SPV Team"
        ' 
        ' dgv_exportform
        ' 
        dgv_exportform.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_exportform.Location = New Point(13, 418)
        dgv_exportform.Margin = New Padding(4)
        dgv_exportform.Name = "dgv_exportform"
        dgv_exportform.ReadOnly = True
        dgv_exportform.Size = New Size(1003, 510)
        dgv_exportform.TabIndex = 0
        ' 
        ' ExportForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 945)
        Controls.Add(gbox_exportform)
        Controls.Add(dgv_exportform)
        Font = New Font("Segoe UI", 12F)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "ExportForm"
        Text = "Export Form"
        gbox_exportform.ResumeLayout(False)
        gbox_exportform.PerformLayout()
        CType(dgv_exportform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbox_exportform As GroupBox
    Friend WithEvents txtbox_spvteam As TextBox
    Friend WithEvents dtp_daydate As DateTimePicker
    Friend WithEvents Label8 As Label
    Private WithEvents txtbox_voyagenumber As TextBox
    Friend WithEvents dtp_finishload As DateTimePicker
    Friend WithEvents dtp_startload As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_exportform As DataGridView
    Friend WithEvents txtbox_packageexport As TextBox
End Class
