<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculationForm
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
        lbl_loading = New Label()
        Label1 = New Label()
        Label2 = New Label()
        dtp_datefrom = New DateTimePicker()
        dtp_dateto = New DateTimePicker()
        dgv_timecalculationreport = New DataGridView()
        btn_viewreport = New Button()
        CType(dgv_timecalculationreport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_loading
        ' 
        lbl_loading.AutoSize = True
        lbl_loading.Font = New Font("Segoe UI", 38F)
        lbl_loading.Location = New Point(22, 25)
        lbl_loading.Name = "lbl_loading"
        lbl_loading.Size = New Size(675, 68)
        lbl_loading.TabIndex = 5
        lbl_loading.Text = "TIME CALCULATION REPORT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(44, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 21)
        Label1.TabIndex = 1
        Label1.Text = "From"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(371, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 21)
        Label2.TabIndex = 6
        Label2.Text = "To"
        ' 
        ' dtp_datefrom
        ' 
        dtp_datefrom.Font = New Font("Segoe UI", 12F)
        dtp_datefrom.Location = New Point(44, 173)
        dtp_datefrom.Name = "dtp_datefrom"
        dtp_datefrom.Size = New Size(249, 29)
        dtp_datefrom.TabIndex = 0
        ' 
        ' dtp_dateto
        ' 
        dtp_dateto.Font = New Font("Segoe UI", 12F)
        dtp_dateto.Location = New Point(371, 173)
        dtp_dateto.Name = "dtp_dateto"
        dtp_dateto.Size = New Size(249, 29)
        dtp_dateto.TabIndex = 1
        ' 
        ' dgv_timecalculationreport
        ' 
        dgv_timecalculationreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_timecalculationreport.Location = New Point(22, 223)
        dgv_timecalculationreport.Name = "dgv_timecalculationreport"
        dgv_timecalculationreport.Size = New Size(1703, 506)
        dgv_timecalculationreport.TabIndex = 3
        ' 
        ' btn_viewreport
        ' 
        btn_viewreport.Font = New Font("Segoe UI", 12F)
        btn_viewreport.Location = New Point(646, 164)
        btn_viewreport.Margin = New Padding(4)
        btn_viewreport.Name = "btn_viewreport"
        btn_viewreport.Size = New Size(128, 38)
        btn_viewreport.TabIndex = 2
        btn_viewreport.Text = "View Report"
        btn_viewreport.UseVisualStyleBackColor = True
        ' 
        ' CalculationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 741)
        Controls.Add(btn_viewreport)
        Controls.Add(dgv_timecalculationreport)
        Controls.Add(dtp_dateto)
        Controls.Add(dtp_datefrom)
        Controls.Add(Label2)
        Controls.Add(lbl_loading)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CalculationForm"
        Text = "Calculation"
        CType(dgv_timecalculationreport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_loading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_datefrom As DateTimePicker
    Friend WithEvents dtp_dateto As DateTimePicker
    Friend WithEvents dgv_timecalculationreport As DataGridView
    Friend WithEvents btn_viewreport As Button
End Class
