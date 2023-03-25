<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLock))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.t6 = New System.Windows.Forms.TextBox()
        Me.t5 = New System.Windows.Forms.TextBox()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lques = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.lAns = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lOld = New System.Windows.Forms.Label()
        Me.lNew = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtOldCode = New System.Windows.Forms.TextBox()
        Me.txtNewCode = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lRec = New System.Windows.Forms.Label()
        Me.txtRecode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnLock)
        Me.GroupBox1.Controls.Add(Me.t6)
        Me.GroupBox1.Controls.Add(Me.t5)
        Me.GroupBox1.Controls.Add(Me.t4)
        Me.GroupBox1.Controls.Add(Me.t3)
        Me.GroupBox1.Controls.Add(Me.t2)
        Me.GroupBox1.Controls.Add(Me.t1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 316)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(160, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Change Lock Code!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(45, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Forgot Password?"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(156, 209)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.Location = New System.Drawing.Point(48, 209)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(89, 29)
        Me.btnLock.TabIndex = 7
        Me.btnLock.Text = "LOCK"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        't6
        '
        Me.t6.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t6.Location = New System.Drawing.Point(254, 99)
        Me.t6.Name = "t6"
        Me.t6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t6.Size = New System.Drawing.Size(35, 36)
        Me.t6.TabIndex = 6
        Me.t6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't5
        '
        Me.t5.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.Location = New System.Drawing.Point(205, 99)
        Me.t5.Name = "t5"
        Me.t5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t5.Size = New System.Drawing.Size(35, 36)
        Me.t5.TabIndex = 5
        Me.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't4
        '
        Me.t4.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.Location = New System.Drawing.Point(156, 99)
        Me.t4.Name = "t4"
        Me.t4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t4.Size = New System.Drawing.Size(35, 36)
        Me.t4.TabIndex = 4
        Me.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't3
        '
        Me.t3.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.Location = New System.Drawing.Point(107, 99)
        Me.t3.Name = "t3"
        Me.t3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t3.Size = New System.Drawing.Size(35, 36)
        Me.t3.TabIndex = 3
        Me.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't2
        '
        Me.t2.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(58, 99)
        Me.t2.Name = "t2"
        Me.t2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t2.Size = New System.Drawing.Size(35, 36)
        Me.t2.TabIndex = 2
        Me.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(9, 99)
        Me.t1.Name = "t1"
        Me.t1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t1.Size = New System.Drawing.Size(35, 36)
        Me.t1.TabIndex = 1
        Me.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(101, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOCK!"
        '
        'lques
        '
        Me.lques.AutoSize = True
        Me.lques.ForeColor = System.Drawing.Color.Crimson
        Me.lques.Location = New System.Drawing.Point(330, 9)
        Me.lques.Name = "lques"
        Me.lques.Size = New System.Drawing.Size(124, 19)
        Me.lques.TabIndex = 1
        Me.lques.Text = "Secret Question?"
        Me.lques.Visible = False
        '
        'txtQuestion
        '
        Me.txtQuestion.Enabled = False
        Me.txtQuestion.Location = New System.Drawing.Point(334, 33)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(239, 68)
        Me.txtQuestion.TabIndex = 2
        Me.txtQuestion.Visible = False
        '
        'lAns
        '
        Me.lAns.AutoSize = True
        Me.lAns.ForeColor = System.Drawing.Color.Crimson
        Me.lAns.Location = New System.Drawing.Point(330, 101)
        Me.lAns.Name = "lAns"
        Me.lAns.Size = New System.Drawing.Size(62, 19)
        Me.lAns.TabIndex = 3
        Me.lAns.Text = "Answer"
        Me.lAns.Visible = False
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(334, 123)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(239, 47)
        Me.txtAnswer.TabIndex = 4
        Me.txtAnswer.Visible = False
        '
        'lOld
        '
        Me.lOld.AutoSize = True
        Me.lOld.ForeColor = System.Drawing.Color.Crimson
        Me.lOld.Location = New System.Drawing.Point(330, 191)
        Me.lOld.Name = "lOld"
        Me.lOld.Size = New System.Drawing.Size(71, 19)
        Me.lOld.TabIndex = 5
        Me.lOld.Text = "Old Code"
        Me.lOld.Visible = False
        '
        'lNew
        '
        Me.lNew.AutoSize = True
        Me.lNew.ForeColor = System.Drawing.Color.Crimson
        Me.lNew.Location = New System.Drawing.Point(330, 241)
        Me.lNew.Name = "lNew"
        Me.lNew.Size = New System.Drawing.Size(79, 19)
        Me.lNew.TabIndex = 5
        Me.lNew.Text = "New Code"
        Me.lNew.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(414, 295)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 33)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'txtOldCode
        '
        Me.txtOldCode.Location = New System.Drawing.Point(335, 215)
        Me.txtOldCode.MaxLength = 6
        Me.txtOldCode.Name = "txtOldCode"
        Me.txtOldCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldCode.Size = New System.Drawing.Size(91, 26)
        Me.txtOldCode.TabIndex = 6
        Me.txtOldCode.Visible = False
        '
        'txtNewCode
        '
        Me.txtNewCode.Location = New System.Drawing.Point(335, 263)
        Me.txtNewCode.MaxLength = 6
        Me.txtNewCode.Name = "txtNewCode"
        Me.txtNewCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewCode.Size = New System.Drawing.Size(91, 26)
        Me.txtNewCode.TabIndex = 7
        Me.txtNewCode.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(498, 176)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 32)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = True
        Me.btnEnter.Visible = False
        '
        'lRec
        '
        Me.lRec.AutoSize = True
        Me.lRec.ForeColor = System.Drawing.Color.Crimson
        Me.lRec.Location = New System.Drawing.Point(461, 241)
        Me.lRec.Name = "lRec"
        Me.lRec.Size = New System.Drawing.Size(96, 19)
        Me.lRec.TabIndex = 5
        Me.lRec.Text = "Retype Code"
        Me.lRec.Visible = False
        '
        'txtRecode
        '
        Me.txtRecode.Location = New System.Drawing.Point(465, 263)
        Me.txtRecode.MaxLength = 6
        Me.txtRecode.Name = "txtRecode"
        Me.txtRecode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRecode.Size = New System.Drawing.Size(91, 26)
        Me.txtRecode.TabIndex = 8
        Me.txtRecode.Visible = False
        '
        'frmLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(319, 342)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtRecode)
        Me.Controls.Add(Me.txtNewCode)
        Me.Controls.Add(Me.txtOldCode)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lRec)
        Me.Controls.Add(Me.lNew)
        Me.Controls.Add(Me.lOld)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lAns)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.lques)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmLock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents t6 As System.Windows.Forms.TextBox
    Friend WithEvents t5 As System.Windows.Forms.TextBox
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lques As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents lAns As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lOld As System.Windows.Forms.Label
    Friend WithEvents lNew As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtOldCode As System.Windows.Forms.TextBox
    Friend WithEvents txtNewCode As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lRec As System.Windows.Forms.Label
    Friend WithEvents txtRecode As System.Windows.Forms.TextBox
End Class
