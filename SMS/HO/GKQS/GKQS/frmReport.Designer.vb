<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdPayroll = New System.Windows.Forms.RadioButton()
        Me.rdStaff = New System.Windows.Forms.RadioButton()
        Me.rdStudent = New System.Windows.Forms.RadioButton()
        Me.rdDebtors = New System.Windows.Forms.RadioButton()
        Me.rdIncome = New System.Windows.Forms.RadioButton()
        Me.rptIncome = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptDebtors = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptStudents = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptstaff = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptPayroll = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Staff_ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GKQSDataSet = New GKQS.GKQSDataSet()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OUTSTANDINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountingTableAdapter = New GKQS.GKQSDataSetTableAdapters.AccountingTableAdapter()
        Me.OUTSTANDINGTableAdapter = New GKQS.GKQSDataSetTableAdapters.OUTSTANDINGTableAdapter()
        Me.StudentsTableAdapter = New GKQS.GKQSDataSetTableAdapters.StudentsTableAdapter()
        Me.Staff_ProfileTableAdapter = New GKQS.GKQSDataSetTableAdapters.Staff_ProfileTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Staff_ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GKQSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OUTSTANDINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.rdPayroll)
        Me.GroupBox1.Controls.Add(Me.rdStaff)
        Me.GroupBox1.Controls.Add(Me.rdStudent)
        Me.GroupBox1.Controls.Add(Me.rdDebtors)
        Me.GroupBox1.Controls.Add(Me.rdIncome)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rdPayroll
        '
        Me.rdPayroll.AutoSize = True
        Me.rdPayroll.Location = New System.Drawing.Point(627, 29)
        Me.rdPayroll.Name = "rdPayroll"
        Me.rdPayroll.Size = New System.Drawing.Size(74, 17)
        Me.rdPayroll.TabIndex = 4
        Me.rdPayroll.TabStop = True
        Me.rdPayroll.Text = "PAYROLL"
        Me.rdPayroll.UseVisualStyleBackColor = True
        '
        'rdStaff
        '
        Me.rdStaff.AutoSize = True
        Me.rdStaff.Location = New System.Drawing.Point(112, 66)
        Me.rdStaff.Name = "rdStaff"
        Me.rdStaff.Size = New System.Drawing.Size(58, 17)
        Me.rdStaff.TabIndex = 3
        Me.rdStaff.TabStop = True
        Me.rdStaff.Text = "STAFF"
        Me.rdStaff.UseVisualStyleBackColor = True
        '
        'rdStudent
        '
        Me.rdStudent.AutoSize = True
        Me.rdStudent.Location = New System.Drawing.Point(112, 29)
        Me.rdStudent.Name = "rdStudent"
        Me.rdStudent.Size = New System.Drawing.Size(103, 17)
        Me.rdStudent.TabIndex = 2
        Me.rdStudent.TabStop = True
        Me.rdStudent.Text = "STUDENT LIST"
        Me.rdStudent.UseVisualStyleBackColor = True
        '
        'rdDebtors
        '
        Me.rdDebtors.AutoSize = True
        Me.rdDebtors.Location = New System.Drawing.Point(357, 66)
        Me.rdDebtors.Name = "rdDebtors"
        Me.rdDebtors.Size = New System.Drawing.Size(103, 17)
        Me.rdDebtors.TabIndex = 1
        Me.rdDebtors.TabStop = True
        Me.rdDebtors.Text = "DEBTORS LIST"
        Me.rdDebtors.UseVisualStyleBackColor = True
        '
        'rdIncome
        '
        Me.rdIncome.AutoSize = True
        Me.rdIncome.Location = New System.Drawing.Point(357, 29)
        Me.rdIncome.Name = "rdIncome"
        Me.rdIncome.Size = New System.Drawing.Size(125, 17)
        Me.rdIncome.TabIndex = 0
        Me.rdIncome.TabStop = True
        Me.rdIncome.Text = "INCOME SUMMARY"
        Me.rdIncome.UseVisualStyleBackColor = True
        '
        'rptIncome
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AccountingBindingSource
        Me.rptIncome.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptIncome.LocalReport.ReportEmbeddedResource = "GKQS.rptAccounting.rdlc"
        Me.rptIncome.Location = New System.Drawing.Point(101, 118)
        Me.rptIncome.Name = "rptIncome"
        Me.rptIncome.Size = New System.Drawing.Size(664, 377)
        Me.rptIncome.TabIndex = 1
        Me.rptIncome.Visible = False
        '
        'rptDebtors
        '
        Me.rptDebtors.DocumentMapWidth = 62
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.OUTSTANDINGBindingSource
        Me.rptDebtors.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptDebtors.LocalReport.ReportEmbeddedResource = "GKQS.rptDebtors.rdlc"
        Me.rptDebtors.Location = New System.Drawing.Point(101, 117)
        Me.rptDebtors.Name = "rptDebtors"
        Me.rptDebtors.Size = New System.Drawing.Size(664, 377)
        Me.rptDebtors.TabIndex = 2
        Me.rptDebtors.Visible = False
        '
        'rptStudents
        '
        Me.rptStudents.DocumentMapWidth = 17
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.StudentsBindingSource
        Me.rptStudents.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rptStudents.LocalReport.ReportEmbeddedResource = "GKQS.rptStudent.rdlc"
        Me.rptStudents.Location = New System.Drawing.Point(101, 118)
        Me.rptStudents.Name = "rptStudents"
        Me.rptStudents.Size = New System.Drawing.Size(664, 377)
        Me.rptStudents.TabIndex = 3
        Me.rptStudents.Visible = False
        '
        'rptstaff
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.Staff_ProfileBindingSource
        Me.rptstaff.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rptstaff.LocalReport.ReportEmbeddedResource = "GKQS.rptStaff.rdlc"
        Me.rptstaff.Location = New System.Drawing.Point(101, 117)
        Me.rptstaff.Name = "rptstaff"
        Me.rptstaff.Size = New System.Drawing.Size(664, 377)
        Me.rptstaff.TabIndex = 4
        Me.rptstaff.Visible = False
        '
        'rptPayroll
        '
        Me.rptPayroll.DocumentMapWidth = 10
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.Staff_ProfileBindingSource
        Me.rptPayroll.LocalReport.DataSources.Add(ReportDataSource5)
        Me.rptPayroll.LocalReport.ReportEmbeddedResource = "GKQS.rptPayroll.rdlc"
        Me.rptPayroll.Location = New System.Drawing.Point(101, 117)
        Me.rptPayroll.Name = "rptPayroll"
        Me.rptPayroll.Size = New System.Drawing.Size(664, 377)
        Me.rptPayroll.TabIndex = 5
        Me.rptPayroll.Visible = False
        '
        'Staff_ProfileBindingSource
        '
        Me.Staff_ProfileBindingSource.DataMember = "Staff_Profile"
        Me.Staff_ProfileBindingSource.DataSource = Me.GKQSDataSet
        '
        'GKQSDataSet
        '
        Me.GKQSDataSet.DataSetName = "GKQSDataSet"
        Me.GKQSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.GKQSDataSet
        '
        'OUTSTANDINGBindingSource
        '
        Me.OUTSTANDINGBindingSource.DataMember = "OUTSTANDING"
        Me.OUTSTANDINGBindingSource.DataSource = Me.GKQSDataSet
        '
        'AccountingBindingSource
        '
        Me.AccountingBindingSource.DataMember = "Accounting"
        Me.AccountingBindingSource.DataSource = Me.GKQSDataSet
        '
        'AccountingTableAdapter
        '
        Me.AccountingTableAdapter.ClearBeforeFill = True
        '
        'OUTSTANDINGTableAdapter
        '
        Me.OUTSTANDINGTableAdapter.ClearBeforeFill = True
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'Staff_ProfileTableAdapter
        '
        Me.Staff_ProfileTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 525)
        Me.Controls.Add(Me.rptPayroll)
        Me.Controls.Add(Me.rptstaff)
        Me.Controls.Add(Me.rptStudents)
        Me.Controls.Add(Me.rptDebtors)
        Me.Controls.Add(Me.rptIncome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Staff_ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GKQSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OUTSTANDINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdIncome As System.Windows.Forms.RadioButton
    Friend WithEvents rptIncome As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AccountingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GKQSDataSet As GKQS.GKQSDataSet
    Friend WithEvents AccountingTableAdapter As GKQS.GKQSDataSetTableAdapters.AccountingTableAdapter
    Friend WithEvents rptDebtors As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rdDebtors As System.Windows.Forms.RadioButton
    Friend WithEvents OUTSTANDINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OUTSTANDINGTableAdapter As GKQS.GKQSDataSetTableAdapters.OUTSTANDINGTableAdapter
    Friend WithEvents rdStaff As System.Windows.Forms.RadioButton
    Friend WithEvents rdStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rptStudents As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptstaff As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As GKQS.GKQSDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents Staff_ProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Staff_ProfileTableAdapter As GKQS.GKQSDataSetTableAdapters.Staff_ProfileTableAdapter
    Friend WithEvents rdPayroll As System.Windows.Forms.RadioButton
    Friend WithEvents rptPayroll As Microsoft.Reporting.WinForms.ReportViewer
End Class
