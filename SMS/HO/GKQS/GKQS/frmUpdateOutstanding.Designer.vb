<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateOutstanding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateOutstanding))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxStudents = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxClass = New System.Windows.Forms.ComboBox()
        Me.rdCol = New System.Windows.Forms.RadioButton()
        Me.rdNur = New System.Windows.Forms.RadioButton()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtOutstanding = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'cbxStudents
        '
        Me.cbxStudents.FormattingEnabled = True
        Me.cbxStudents.Location = New System.Drawing.Point(26, 142)
        Me.cbxStudents.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxStudents.Name = "cbxStudents"
        Me.cbxStudents.Size = New System.Drawing.Size(345, 28)
        Me.cbxStudents.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CLASS"
        '
        'cbxClass
        '
        Me.cbxClass.FormattingEnabled = True
        Me.cbxClass.Location = New System.Drawing.Point(26, 86)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(167, 28)
        Me.cbxClass.TabIndex = 3
        '
        'rdCol
        '
        Me.rdCol.AutoSize = True
        Me.rdCol.Location = New System.Drawing.Point(44, 24)
        Me.rdCol.Name = "rdCol"
        Me.rdCol.Size = New System.Drawing.Size(103, 24)
        Me.rdCol.TabIndex = 4
        Me.rdCol.TabStop = True
        Me.rdCol.Text = "COLLEGE"
        Me.rdCol.UseVisualStyleBackColor = True
        '
        'rdNur
        '
        Me.rdNur.AutoSize = True
        Me.rdNur.Location = New System.Drawing.Point(163, 24)
        Me.rdNur.Name = "rdNur"
        Me.rdNur.Size = New System.Drawing.Size(99, 24)
        Me.rdNur.TabIndex = 5
        Me.rdNur.TabStop = True
        Me.rdNur.Text = "NUR/PRY"
        Me.rdNur.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(301, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(57, 20)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "Label3"
        Me.lblID.Visible = False
        '
        'txtOutstanding
        '
        Me.txtOutstanding.Location = New System.Drawing.Point(26, 224)
        Me.txtOutstanding.Name = "txtOutstanding"
        Me.txtOutstanding.Size = New System.Drawing.Size(115, 26)
        Me.txtOutstanding.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "OUTSTANDING"
        '
        'btnUpdate
        '
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUpdate.Location = New System.Drawing.Point(0, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(541, 38)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoad.Location = New System.Drawing.Point(147, 218)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(115, 32)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.Text = "Load Outstanding"
        Me.btnLoad.UseVisualStyleBackColor = True
        Me.btnLoad.Visible = False
        '
        'frmUpdateOutstanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(541, 315)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOutstanding)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.rdNur)
        Me.Controls.Add(Me.rdCol)
        Me.Controls.Add(Me.cbxClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxStudents)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUpdateOutstanding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxStudents As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxClass As System.Windows.Forms.ComboBox
    Friend WithEvents rdCol As System.Windows.Forms.RadioButton
    Friend WithEvents rdNur As System.Windows.Forms.RadioButton
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtOutstanding As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
End Class
