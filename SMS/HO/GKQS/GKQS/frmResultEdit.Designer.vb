<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultEdit))
        Me.rdNur = New System.Windows.Forms.RadioButton()
        Me.rdCol = New System.Windows.Forms.RadioButton()
        Me.cbxClass = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdExam = New System.Windows.Forms.RadioButton()
        Me.rdMid = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxStudent = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTerm = New System.Windows.Forms.ComboBox()
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.txtSes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblFilename1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdNur
        '
        Me.rdNur.AutoSize = True
        Me.rdNur.Location = New System.Drawing.Point(32, 23)
        Me.rdNur.Margin = New System.Windows.Forms.Padding(4)
        Me.rdNur.Name = "rdNur"
        Me.rdNur.Size = New System.Drawing.Size(93, 23)
        Me.rdNur.TabIndex = 0
        Me.rdNur.TabStop = True
        Me.rdNur.Text = "NUR/PRY"
        Me.rdNur.UseVisualStyleBackColor = True
        '
        'rdCol
        '
        Me.rdCol.AutoSize = True
        Me.rdCol.Location = New System.Drawing.Point(176, 23)
        Me.rdCol.Margin = New System.Windows.Forms.Padding(4)
        Me.rdCol.Name = "rdCol"
        Me.rdCol.Size = New System.Drawing.Size(92, 23)
        Me.rdCol.TabIndex = 1
        Me.rdCol.TabStop = True
        Me.rdCol.Text = "COLLEGE"
        Me.rdCol.UseVisualStyleBackColor = True
        '
        'cbxClass
        '
        Me.cbxClass.FormattingEnabled = True
        Me.cbxClass.Location = New System.Drawing.Point(12, 200)
        Me.cbxClass.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(225, 27)
        Me.cbxClass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CLASS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdCol)
        Me.GroupBox1.Controls.Add(Me.rdNur)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(390, 57)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdExam)
        Me.GroupBox2.Controls.Add(Me.rdMid)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 78)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(223, 98)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'rdExam
        '
        Me.rdExam.AutoSize = True
        Me.rdExam.Location = New System.Drawing.Point(42, 57)
        Me.rdExam.Margin = New System.Windows.Forms.Padding(4)
        Me.rdExam.Name = "rdExam"
        Me.rdExam.Size = New System.Drawing.Size(160, 23)
        Me.rdExam.TabIndex = 1
        Me.rdExam.Text = "TERMINAL RESULT"
        Me.rdExam.UseVisualStyleBackColor = True
        '
        'rdMid
        '
        Me.rdMid.AutoSize = True
        Me.rdMid.Checked = True
        Me.rdMid.Location = New System.Drawing.Point(42, 23)
        Me.rdMid.Margin = New System.Windows.Forms.Padding(4)
        Me.rdMid.Name = "rdMid"
        Me.rdMid.Size = New System.Drawing.Size(158, 23)
        Me.rdMid.TabIndex = 0
        Me.rdMid.TabStop = True
        Me.rdMid.Text = "MID TERM RESULT"
        Me.rdMid.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "STUDENT"
        '
        'cbxStudent
        '
        Me.cbxStudent.FormattingEnabled = True
        Me.cbxStudent.Location = New System.Drawing.Point(9, 259)
        Me.cbxStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxStudent.Name = "cbxStudent"
        Me.cbxStudent.Size = New System.Drawing.Size(385, 27)
        Me.cbxStudent.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(0, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(210, 37)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(209, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(205, 37)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TERM"
        '
        'cbxTerm
        '
        Me.cbxTerm.FormattingEnabled = True
        Me.cbxTerm.Items.AddRange(New Object() {"FIRST", "SECOND", "THIRD"})
        Me.cbxTerm.Location = New System.Drawing.Point(10, 36)
        Me.cbxTerm.Name = "cbxTerm"
        Me.cbxTerm.Size = New System.Drawing.Size(121, 27)
        Me.cbxTerm.TabIndex = 10
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.txtSes)
        Me.grpEdit.Controls.Add(Me.Label4)
        Me.grpEdit.Controls.Add(Me.Label3)
        Me.grpEdit.Controls.Add(Me.cbxTerm)
        Me.grpEdit.Location = New System.Drawing.Point(244, 78)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(159, 150)
        Me.grpEdit.TabIndex = 11
        Me.grpEdit.TabStop = False
        '
        'txtSes
        '
        Me.txtSes.Location = New System.Drawing.Point(10, 99)
        Me.txtSes.Name = "txtSes"
        Me.txtSes.Size = New System.Drawing.Size(121, 26)
        Me.txtSes.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SESSION"
        '
        'lblFilename
        '
        Me.lblFilename.BackColor = System.Drawing.Color.White
        Me.lblFilename.Location = New System.Drawing.Point(26, 307)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(315, 27)
        Me.lblFilename.TabIndex = 13
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(159, 347)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 27)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(240, 347)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 27)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "VIEW>>"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'lblFilename1
        '
        Me.lblFilename1.BackColor = System.Drawing.Color.White
        Me.lblFilename1.Location = New System.Drawing.Point(26, 307)
        Me.lblFilename1.Name = "lblFilename1"
        Me.lblFilename1.Size = New System.Drawing.Size(315, 27)
        Me.lblFilename1.TabIndex = 13
        Me.lblFilename1.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(291, 234)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(56, 19)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "Label5"
        Me.lblID.Visible = False
        '
        'frmResultEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 440)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblFilename1)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.grpEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxClass)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmResultEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdNur As System.Windows.Forms.RadioButton
    Friend WithEvents rdCol As System.Windows.Forms.RadioButton
    Friend WithEvents cbxClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdExam As System.Windows.Forms.RadioButton
    Friend WithEvents rdMid As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxStudent As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTerm As System.Windows.Forms.ComboBox
    Friend WithEvents grpEdit As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSes As System.Windows.Forms.TextBox
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblFilename1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
