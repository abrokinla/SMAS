<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenditure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpenditure))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnViewExp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvExpenditure = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSes = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAprov = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCollect = New System.Windows.Forms.TextBox()
        Me.rdCash = New System.Windows.Forms.RadioButton()
        Me.rdCheque = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvExpenditure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DESCRIPTION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 179)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AMOUNT"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(19, 54)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(148, 26)
        Me.txtDate.TabIndex = 3
        Me.txtDate.Text = "dd/mm/yyyy"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(19, 111)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(368, 60)
        Me.txtDesc.TabIndex = 4
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(19, 202)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(275, 26)
        Me.txtAmount.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(141, 381)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 27)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(232, 381)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 27)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnViewExp
        '
        Me.btnViewExp.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewExp.ForeColor = System.Drawing.Color.DarkRed
        Me.btnViewExp.Location = New System.Drawing.Point(364, 51)
        Me.btnViewExp.Name = "btnViewExp"
        Me.btnViewExp.Size = New System.Drawing.Size(75, 23)
        Me.btnViewExp.TabIndex = 8
        Me.btnViewExp.Text = "VIEW>>>"
        Me.btnViewExp.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvExpenditure)
        Me.Panel1.Location = New System.Drawing.Point(462, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 408)
        Me.Panel1.TabIndex = 9
        '
        'dgvExpenditure
        '
        Me.dgvExpenditure.AllowUserToAddRows = False
        Me.dgvExpenditure.AllowUserToDeleteRows = False
        Me.dgvExpenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpenditure.Location = New System.Drawing.Point(3, 3)
        Me.dgvExpenditure.Name = "dgvExpenditure"
        Me.dgvExpenditure.ReadOnly = True
        Me.dgvExpenditure.Size = New System.Drawing.Size(473, 402)
        Me.dgvExpenditure.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SESSION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TERM"
        '
        'lblSes
        '
        Me.lblSes.AutoSize = True
        Me.lblSes.BackColor = System.Drawing.Color.White
        Me.lblSes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSes.Location = New System.Drawing.Point(260, 24)
        Me.lblSes.Name = "lblSes"
        Me.lblSes.Size = New System.Drawing.Size(70, 21)
        Me.lblSes.TabIndex = 11
        Me.lblSes.Text = "SESSION"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.BackColor = System.Drawing.Color.White
        Me.lblTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTerm.Location = New System.Drawing.Point(260, 53)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(52, 21)
        Me.lblTerm.TabIndex = 11
        Me.lblTerm.Text = "TERM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "APPROVED BY:"
        '
        'txtAprov
        '
        Me.txtAprov.Location = New System.Drawing.Point(19, 265)
        Me.txtAprov.Name = "txtAprov"
        Me.txtAprov.Size = New System.Drawing.Size(275, 26)
        Me.txtAprov.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "COLLECTED BY:"
        '
        'txtCollect
        '
        Me.txtCollect.Location = New System.Drawing.Point(22, 319)
        Me.txtCollect.Name = "txtCollect"
        Me.txtCollect.Size = New System.Drawing.Size(272, 26)
        Me.txtCollect.TabIndex = 15
        '
        'rdCash
        '
        Me.rdCash.AutoSize = True
        Me.rdCash.Location = New System.Drawing.Point(329, 290)
        Me.rdCash.Name = "rdCash"
        Me.rdCash.Size = New System.Drawing.Size(65, 23)
        Me.rdCash.TabIndex = 16
        Me.rdCash.TabStop = True
        Me.rdCash.Text = "CASH"
        Me.rdCash.UseVisualStyleBackColor = True
        '
        'rdCheque
        '
        Me.rdCheque.AutoSize = True
        Me.rdCheque.Location = New System.Drawing.Point(329, 319)
        Me.rdCheque.Name = "rdCheque"
        Me.rdCheque.Size = New System.Drawing.Size(85, 23)
        Me.rdCheque.TabIndex = 17
        Me.rdCheque.TabStop = True
        Me.rdCheque.Text = "CHEQUE"
        Me.rdCheque.UseVisualStyleBackColor = True
        '
        'frmExpenditure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 416)
        Me.Controls.Add(Me.rdCheque)
        Me.Controls.Add(Me.rdCash)
        Me.Controls.Add(Me.txtCollect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAprov)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.lblSes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnViewExp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmExpenditure"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvExpenditure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnViewExp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvExpenditure As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSes As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAprov As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCollect As System.Windows.Forms.TextBox
    Friend WithEvents rdCash As System.Windows.Forms.RadioButton
    Friend WithEvents rdCheque As System.Windows.Forms.RadioButton
End Class
