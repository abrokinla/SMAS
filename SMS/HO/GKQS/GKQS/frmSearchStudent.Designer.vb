<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchStudent))
        Me.rdNur = New System.Windows.Forms.RadioButton()
        Me.rdCol = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxClass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxStudent = New System.Windows.Forms.ComboBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdNur
        '
        Me.rdNur.AutoSize = True
        Me.rdNur.Location = New System.Drawing.Point(15, 21)
        Me.rdNur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.rdCol.Location = New System.Drawing.Point(135, 21)
        Me.rdCol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdCol.Name = "rdCol"
        Me.rdCol.Size = New System.Drawing.Size(92, 23)
        Me.rdCol.TabIndex = 1
        Me.rdCol.TabStop = True
        Me.rdCol.Text = "COLLEGE"
        Me.rdCol.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CLASS"
        '
        'cbxClass
        '
        Me.cbxClass.FormattingEnabled = True
        Me.cbxClass.Location = New System.Drawing.Point(13, 101)
        Me.cbxClass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(199, 27)
        Me.cbxClass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "STUDENT NAME"
        '
        'cbxStudent
        '
        Me.cbxStudent.FormattingEnabled = True
        Me.cbxStudent.Location = New System.Drawing.Point(13, 164)
        Me.cbxStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxStudent.Name = "cbxStudent"
        Me.cbxStudent.Size = New System.Drawing.Size(358, 27)
        Me.cbxStudent.TabIndex = 5
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(54, 239)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(112, 34)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(201, 239)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSearchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 302)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cbxStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxClass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdCol)
        Me.Controls.Add(Me.rdNur)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSearchStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdNur As System.Windows.Forms.RadioButton
    Friend WithEvents rdCol As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxStudent As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
