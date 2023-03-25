<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditPayment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdCol = New System.Windows.Forms.RadioButton()
        Me.rdNur = New System.Windows.Forms.RadioButton()
        Me.cbxClass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.cbxStudent = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSes = New System.Windows.Forms.TextBox()
        Me.cbxTerm = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAccounting = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAccounting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS"
        '
        'rdCol
        '
        Me.rdCol.AutoSize = True
        Me.rdCol.Location = New System.Drawing.Point(119, 12)
        Me.rdCol.Name = "rdCol"
        Me.rdCol.Size = New System.Drawing.Size(77, 23)
        Me.rdCol.TabIndex = 1
        Me.rdCol.TabStop = True
        Me.rdCol.Text = "College"
        Me.rdCol.UseVisualStyleBackColor = True
        '
        'rdNur
        '
        Me.rdNur.AutoSize = True
        Me.rdNur.Location = New System.Drawing.Point(215, 12)
        Me.rdNur.Name = "rdNur"
        Me.rdNur.Size = New System.Drawing.Size(86, 23)
        Me.rdNur.TabIndex = 2
        Me.rdNur.TabStop = True
        Me.rdNur.Text = "Nur/Pry"
        Me.rdNur.UseVisualStyleBackColor = True
        '
        'cbxClass
        '
        Me.cbxClass.FormattingEnabled = True
        Me.cbxClass.Location = New System.Drawing.Point(76, 37)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(158, 27)
        Me.cbxClass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TERM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SESSION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStuID)
        Me.GroupBox1.Controls.Add(Me.cbxStudent)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSes)
        Me.GroupBox1.Controls.Add(Me.cbxTerm)
        Me.GroupBox1.Controls.Add(Me.cbxClass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 173)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(639, 87)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(56, 19)
        Me.lblStuID.TabIndex = 11
        Me.lblStuID.Text = "Label5"
        Me.lblStuID.Visible = False
        '
        'cbxStudent
        '
        Me.cbxStudent.FormattingEnabled = True
        Me.cbxStudent.Location = New System.Drawing.Point(171, 82)
        Me.cbxStudent.Name = "cbxStudent"
        Me.cbxStudent.Size = New System.Drawing.Size(439, 27)
        Me.cbxStudent.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "STUDENT NAME"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(143, 127)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(439, 27)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSes
        '
        Me.txtSes.Location = New System.Drawing.Point(538, 38)
        Me.txtSes.Name = "txtSes"
        Me.txtSes.Size = New System.Drawing.Size(146, 26)
        Me.txtSes.TabIndex = 7
        '
        'cbxTerm
        '
        Me.cbxTerm.FormattingEnabled = True
        Me.cbxTerm.Items.AddRange(New Object() {"FIRST", "SECOND", "THIRD"})
        Me.cbxTerm.Location = New System.Drawing.Point(316, 37)
        Me.cbxTerm.Name = "cbxTerm"
        Me.cbxTerm.Size = New System.Drawing.Size(121, 27)
        Me.cbxTerm.TabIndex = 6
        Me.cbxTerm.Text = "SELECT"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(316, 211)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 26)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAccounting)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 250)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'dgvAccounting
        '
        Me.dgvAccounting.AllowUserToAddRows = False
        Me.dgvAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounting.Location = New System.Drawing.Point(6, 16)
        Me.dgvAccounting.Name = "dgvAccounting"
        Me.dgvAccounting.ReadOnly = True
        Me.dgvAccounting.Size = New System.Drawing.Size(817, 186)
        Me.dgvAccounting.TabIndex = 10
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(410, 211)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmEditPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 504)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdNur)
        Me.Controls.Add(Me.rdCol)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEditPayment"
        Me.Text = "EDIT PAYMENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAccounting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdCol As System.Windows.Forms.RadioButton
    Friend WithEvents rdNur As System.Windows.Forms.RadioButton
    Friend WithEvents cbxClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxStudent As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSes As System.Windows.Forms.TextBox
    Friend WithEvents cbxTerm As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAccounting As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblStuID As System.Windows.Forms.Label
End Class
