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
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(44, 173)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(249, 29)
        DateTimePicker1.TabIndex = 7
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 12F)
        DateTimePicker2.Location = New Point(371, 173)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(249, 29)
        DateTimePicker2.TabIndex = 8
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 223)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1703, 506)
        DataGridView1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(646, 164)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 38)
        Button1.TabIndex = 34
        Button1.Text = "View Report"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CalculationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1737, 741)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(lbl_loading)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CalculationForm"
        Text = "Calculation"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_loading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
