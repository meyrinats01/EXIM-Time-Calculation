<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportForm
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
        dgv_importform = New DataGridView()
        gbox_importform = New GroupBox()
        txtbox_spvteam = New TextBox()
        dtp_daydate = New DateTimePicker()
        Label8 = New Label()
        txtbox_voyagenumber = New TextBox()
        dtp_finishunload = New DateTimePicker()
        dtp_startunload = New DateTimePicker()
        Label1 = New Label()
        dtp_packageimport = New DateTimePicker()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        btn_delete = New Button()
        Label4 = New Label()
        btn_edit = New Button()
        Label5 = New Label()
        btn_save = New Button()
        Label6 = New Label()
        CType(dgv_importform, ComponentModel.ISupportInitialize).BeginInit()
        gbox_importform.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_importform
        ' 
        dgv_importform.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_importform.Location = New Point(13, 422)
        dgv_importform.Margin = New Padding(4)
        dgv_importform.Name = "dgv_importform"
        dgv_importform.Size = New Size(1003, 510)
        dgv_importform.TabIndex = 1
        ' 
        ' gbox_importform
        ' 
        gbox_importform.Controls.Add(txtbox_spvteam)
        gbox_importform.Controls.Add(dtp_daydate)
        gbox_importform.Controls.Add(Label8)
        gbox_importform.Controls.Add(txtbox_voyagenumber)
        gbox_importform.Controls.Add(dtp_finishunload)
        gbox_importform.Controls.Add(dtp_startunload)
        gbox_importform.Controls.Add(Label1)
        gbox_importform.Controls.Add(dtp_packageimport)
        gbox_importform.Controls.Add(Label2)
        gbox_importform.Controls.Add(DateTimePicker1)
        gbox_importform.Controls.Add(Label3)
        gbox_importform.Controls.Add(btn_delete)
        gbox_importform.Controls.Add(Label4)
        gbox_importform.Controls.Add(btn_edit)
        gbox_importform.Controls.Add(Label5)
        gbox_importform.Controls.Add(btn_save)
        gbox_importform.Controls.Add(Label6)
        gbox_importform.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        gbox_importform.Location = New Point(13, 21)
        gbox_importform.Margin = New Padding(4)
        gbox_importform.Name = "gbox_importform"
        gbox_importform.Padding = New Padding(4)
        gbox_importform.Size = New Size(1003, 393)
        gbox_importform.TabIndex = 31
        gbox_importform.TabStop = False
        gbox_importform.Text = "Import Form"
        ' 
        ' txtbox_spvteam
        ' 
        txtbox_spvteam.Font = New Font("Segoe UI", 12.0F)
        txtbox_spvteam.Location = New Point(404, 344)
        txtbox_spvteam.Margin = New Padding(4)
        txtbox_spvteam.Name = "txtbox_spvteam"
        txtbox_spvteam.Size = New Size(345, 29)
        txtbox_spvteam.TabIndex = 32
        ' 
        ' dtp_daydate
        ' 
        dtp_daydate.Font = New Font("Segoe UI", 12.0F)
        dtp_daydate.Location = New Point(404, 53)
        dtp_daydate.Margin = New Padding(4)
        dtp_daydate.Name = "dtp_daydate"
        dtp_daydate.Size = New Size(345, 29)
        dtp_daydate.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F)
        Label8.Location = New Point(24, 65)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 21)
        Label8.TabIndex = 30
        Label8.Text = "Day/Date"
        ' 
        ' txtbox_voyagenumber
        ' 
        txtbox_voyagenumber.Font = New Font("Segoe UI", 12.0F)
        txtbox_voyagenumber.Location = New Point(404, 106)
        txtbox_voyagenumber.Margin = New Padding(4)
        txtbox_voyagenumber.Name = "txtbox_voyagenumber"
        txtbox_voyagenumber.Size = New Size(345, 29)
        txtbox_voyagenumber.TabIndex = 2
        ' 
        ' dtp_finishunload
        ' 
        dtp_finishunload.Font = New Font("Segoe UI", 12.0F)
        dtp_finishunload.Format = DateTimePickerFormat.Time
        dtp_finishunload.Location = New Point(404, 231)
        dtp_finishunload.Margin = New Padding(4)
        dtp_finishunload.Name = "dtp_finishunload"
        dtp_finishunload.Size = New Size(345, 29)
        dtp_finishunload.TabIndex = 28
        ' 
        ' dtp_startunload
        ' 
        dtp_startunload.Font = New Font("Segoe UI", 12.0F)
        dtp_startunload.Format = DateTimePickerFormat.Time
        dtp_startunload.Location = New Point(404, 167)
        dtp_startunload.Margin = New Padding(4)
        dtp_startunload.Name = "dtp_startunload"
        dtp_startunload.Size = New Size(345, 29)
        dtp_startunload.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.Location = New Point(32, -28)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 21)
        Label1.TabIndex = 8
        Label1.Text = "Day/Date"
        ' 
        ' dtp_packageimport
        ' 
        dtp_packageimport.Font = New Font("Segoe UI", 12.0F)
        dtp_packageimport.Format = DateTimePickerFormat.Time
        dtp_packageimport.Location = New Point(404, 287)
        dtp_packageimport.Margin = New Padding(4)
        dtp_packageimport.Name = "dtp_packageimport"
        dtp_packageimport.Size = New Size(345, 29)
        dtp_packageimport.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.Location = New Point(24, 119)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 21)
        Label2.TabIndex = 9
        Label2.Text = "Voyage Number"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12.0F)
        DateTimePicker1.Location = New Point(411, -41)
        DateTimePicker1.Margin = New Padding(4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(345, 29)
        DateTimePicker1.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F)
        Label3.Location = New Point(24, 175)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 21)
        Label3.TabIndex = 10
        Label3.Text = "Start Unload"
        ' 
        ' btn_delete
        ' 
        btn_delete.Font = New Font("Segoe UI", 12.0F)
        btn_delete.Location = New Point(839, 304)
        btn_delete.Margin = New Padding(4)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(129, 67)
        btn_delete.TabIndex = 17
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F)
        Label4.Location = New Point(24, 232)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 21)
        Label4.TabIndex = 11
        Label4.Text = "Finish Unload"
        ' 
        ' btn_edit
        ' 
        btn_edit.Font = New Font("Segoe UI", 12.0F)
        btn_edit.Location = New Point(839, 190)
        btn_edit.Margin = New Padding(4)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(129, 67)
        btn_edit.TabIndex = 16
        btn_edit.Text = "EDIT"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F)
        Label5.Location = New Point(24, 296)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 21)
        Label5.TabIndex = 12
        Label5.Text = "Package Import"
        ' 
        ' btn_save
        ' 
        btn_save.Font = New Font("Segoe UI", 12.0F)
        btn_save.Location = New Point(839, 68)
        btn_save.Margin = New Padding(4)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(129, 67)
        btn_save.TabIndex = 15
        btn_save.Text = "SAVE"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F)
        Label6.Location = New Point(24, 352)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 21)
        Label6.TabIndex = 13
        Label6.Text = "SPV Team"
        ' 
        ' ImportForm
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 945)
        Controls.Add(gbox_importform)
        Controls.Add(dgv_importform)
        Font = New Font("Segoe UI", 12.0F)
        Margin = New Padding(4)
        Name = "ImportForm"
        Text = "ImportForm"
        CType(dgv_importform, ComponentModel.ISupportInitialize).EndInit()
        gbox_importform.ResumeLayout(False)
        gbox_importform.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_importform As DataGridView
    Friend WithEvents gbox_importform As GroupBox
    Friend WithEvents dtp_daydate As DateTimePicker
    Friend WithEvents Label8 As Label
    Private txtbox_voyagenumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_atd As DateTimePicker
    Friend WithEvents txtbox_vesselname As TextBox
    Friend WithEvents dtp_finishunload As DateTimePicker
    Friend WithEvents txtbox_captain As TextBox
    Friend WithEvents dtp_startunload As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_packageimport As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbox_spvteam As TextBox
End Class
