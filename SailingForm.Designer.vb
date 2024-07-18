<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SailingForm
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
        dgv_sailingform = New DataGridView()
        txtbox_vesselname = New TextBox()
        txtbox_captain = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btn_save = New Button()
        btn_edit = New Button()
        btn_delete = New Button()
        DateTimePicker1 = New DateTimePicker()
        dtp_etd = New DateTimePicker()
        dtp_eta = New DateTimePicker()
        dtp_ata = New DateTimePicker()
        dtp_atd = New DateTimePicker()
        gbox_sailingform = New GroupBox()
        dtp_daydate = New DateTimePicker()
        Label8 = New Label()
        CType(dgv_sailingform, ComponentModel.ISupportInitialize).BeginInit()
        gbox_sailingform.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_sailingform
        ' 
        dgv_sailingform.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_sailingform.Location = New Point(15, 487)
        dgv_sailingform.Margin = New Padding(4)
        dgv_sailingform.Name = "dgv_sailingform"
        dgv_sailingform.ReadOnly = True
        dgv_sailingform.Size = New Size(998, 441)
        dgv_sailingform.TabIndex = 0
        ' 
        ' txtbox_vesselname
        ' 
        txtbox_vesselname.Font = New Font("Segoe UI", 12F)
        txtbox_vesselname.Location = New Point(404, 106)
        txtbox_vesselname.Margin = New Padding(4)
        txtbox_vesselname.Name = "txtbox_vesselname"
        txtbox_vesselname.Size = New Size(345, 29)
        txtbox_vesselname.TabIndex = 2
        ' 
        ' txtbox_captain
        ' 
        txtbox_captain.Font = New Font("Segoe UI", 12F)
        txtbox_captain.Location = New Point(404, 162)
        txtbox_captain.Margin = New Padding(4)
        txtbox_captain.Name = "txtbox_captain"
        txtbox_captain.Size = New Size(345, 29)
        txtbox_captain.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(31, -29)
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
        Label2.Location = New Point(23, 118)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 21)
        Label2.TabIndex = 9
        Label2.Text = "Vessel Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(23, 174)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 10
        Label3.Text = "Captain"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(23, 231)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 11
        Label4.Text = "ET. Arrival"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(23, 295)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 21)
        Label5.TabIndex = 12
        Label5.Text = "AT. Arrival"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(23, 351)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 21)
        Label6.TabIndex = 13
        Label6.Text = "ET. Departure"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(23, 407)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 21)
        Label7.TabIndex = 14
        Label7.Text = "AT. Departure"
        ' 
        ' btn_save
        ' 
        btn_save.Font = New Font("Segoe UI", 12F)
        btn_save.Location = New Point(846, 240)
        btn_save.Margin = New Padding(4)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(129, 67)
        btn_save.TabIndex = 15
        btn_save.Text = "SAVE"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Font = New Font("Segoe UI", 12F)
        btn_edit.Location = New Point(861, 15)
        btn_edit.Margin = New Padding(4)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(129, 67)
        btn_edit.TabIndex = 16
        btn_edit.Text = "EDIT"
        btn_edit.UseVisualStyleBackColor = True
        btn_edit.Visible = False
        ' 
        ' btn_delete
        ' 
        btn_delete.Font = New Font("Segoe UI", 12F)
        btn_delete.Location = New Point(846, 372)
        btn_delete.Margin = New Padding(4)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(129, 67)
        btn_delete.TabIndex = 17
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = True
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
        ' dtp_etd
        ' 
        dtp_etd.Font = New Font("Segoe UI", 12F)
        dtp_etd.Format = DateTimePickerFormat.Time
        dtp_etd.Location = New Point(404, 343)
        dtp_etd.Margin = New Padding(4)
        dtp_etd.Name = "dtp_etd"
        dtp_etd.Size = New Size(345, 29)
        dtp_etd.TabIndex = 26
        ' 
        ' dtp_eta
        ' 
        dtp_eta.Font = New Font("Segoe UI", 12F)
        dtp_eta.Format = DateTimePickerFormat.Time
        dtp_eta.Location = New Point(404, 223)
        dtp_eta.Margin = New Padding(4)
        dtp_eta.Name = "dtp_eta"
        dtp_eta.Size = New Size(345, 29)
        dtp_eta.TabIndex = 27
        ' 
        ' dtp_ata
        ' 
        dtp_ata.Font = New Font("Segoe UI", 12F)
        dtp_ata.Format = DateTimePickerFormat.Time
        dtp_ata.Location = New Point(404, 287)
        dtp_ata.Margin = New Padding(4)
        dtp_ata.Name = "dtp_ata"
        dtp_ata.Size = New Size(345, 29)
        dtp_ata.TabIndex = 28
        ' 
        ' dtp_atd
        ' 
        dtp_atd.Font = New Font("Segoe UI", 12F)
        dtp_atd.Format = DateTimePickerFormat.Time
        dtp_atd.Location = New Point(404, 399)
        dtp_atd.Margin = New Padding(4)
        dtp_atd.Name = "dtp_atd"
        dtp_atd.Size = New Size(345, 29)
        dtp_atd.TabIndex = 29
        ' 
        ' gbox_sailingform
        ' 
        gbox_sailingform.Controls.Add(dtp_daydate)
        gbox_sailingform.Controls.Add(Label8)
        gbox_sailingform.Controls.Add(Label7)
        gbox_sailingform.Controls.Add(dtp_atd)
        gbox_sailingform.Controls.Add(txtbox_vesselname)
        gbox_sailingform.Controls.Add(dtp_ata)
        gbox_sailingform.Controls.Add(txtbox_captain)
        gbox_sailingform.Controls.Add(dtp_eta)
        gbox_sailingform.Controls.Add(Label1)
        gbox_sailingform.Controls.Add(dtp_etd)
        gbox_sailingform.Controls.Add(Label2)
        gbox_sailingform.Controls.Add(DateTimePicker1)
        gbox_sailingform.Controls.Add(Label3)
        gbox_sailingform.Controls.Add(btn_delete)
        gbox_sailingform.Controls.Add(Label4)
        gbox_sailingform.Controls.Add(btn_edit)
        gbox_sailingform.Controls.Add(Label5)
        gbox_sailingform.Controls.Add(btn_save)
        gbox_sailingform.Controls.Add(Label6)
        gbox_sailingform.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        gbox_sailingform.Location = New Point(15, 17)
        gbox_sailingform.Margin = New Padding(4)
        gbox_sailingform.Name = "gbox_sailingform"
        gbox_sailingform.Padding = New Padding(4)
        gbox_sailingform.Size = New Size(998, 462)
        gbox_sailingform.TabIndex = 30
        gbox_sailingform.TabStop = False
        gbox_sailingform.Text = "Sailing Form"
        ' 
        ' dtp_daydate
        ' 
        dtp_daydate.Font = New Font("Segoe UI", 12F)
        dtp_daydate.Location = New Point(404, 53)
        dtp_daydate.Margin = New Padding(4)
        dtp_daydate.Name = "dtp_daydate"
        dtp_daydate.Size = New Size(345, 29)
        dtp_daydate.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(23, 64)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 21)
        Label8.TabIndex = 30
        Label8.Text = "Day/Date"
        ' 
        ' SailingForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 945)
        Controls.Add(gbox_sailingform)
        Controls.Add(dgv_sailingform)
        Font = New Font("Segoe UI", 12F)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "SailingForm"
        Text = "SailingForm"
        CType(dgv_sailingform, ComponentModel.ISupportInitialize).EndInit()
        gbox_sailingform.ResumeLayout(False)
        gbox_sailingform.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_sailingform As DataGridView
    Friend WithEvents txtbox_vesselname As TextBox
    Friend WithEvents txtbox_captain As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dtp_etd As DateTimePicker
    Friend WithEvents dtp_eta As DateTimePicker
    Friend WithEvents dtp_ata As DateTimePicker
    Friend WithEvents dtp_atd As DateTimePicker
    Friend WithEvents gbox_sailingform As GroupBox
    Friend WithEvents dtp_daydate As DateTimePicker
    Friend WithEvents Label8 As Label
End Class
