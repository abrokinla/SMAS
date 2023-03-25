<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentSummary))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbxStudents = New System.Windows.Forms.ComboBox()
        Me.cbxClass = New System.Windows.Forms.ComboBox()
        Me.rdCol = New System.Windows.Forms.RadioButton()
        Me.rdNur = New System.Windows.Forms.RadioButton()
        Me.picPassport = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblNat = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblLga = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIDtag = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSummary = New System.Windows.Forms.DataGridView()
        Me.GKQSDataSet = New GKQS.GKQSDataSet()
        Me.GKQSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OFDLoadImage = New System.Windows.Forms.OpenFileDialog()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.cbxSession = New System.Windows.Forms.ComboBox()
        Me.cbxTerm = New System.Windows.Forms.ComboBox()
        Me.rdTerm = New System.Windows.Forms.RadioButton()
        Me.rdMid = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picPassport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GKQSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GKQSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.cbxStudents)
        Me.GroupBox1.Controls.Add(Me.cbxClass)
        Me.GroupBox1.Controls.Add(Me.rdCol)
        Me.GroupBox1.Controls.Add(Me.rdNur)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResult.Location = New System.Drawing.Point(671, 20)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(89, 13)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Check Result>>>"
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Location = New System.Drawing.Point(521, 58)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(260, 23)
        Me.lblID.TabIndex = 4
        '
        'cbxStudents
        '
        Me.cbxStudents.FormattingEnabled = True
        Me.cbxStudents.Location = New System.Drawing.Point(40, 60)
        Me.cbxStudents.Name = "cbxStudents"
        Me.cbxStudents.Size = New System.Drawing.Size(457, 21)
        Me.cbxStudents.TabIndex = 3
        '
        'cbxClass
        '
        Me.cbxClass.FormattingEnabled = True
        Me.cbxClass.Location = New System.Drawing.Point(263, 16)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(121, 21)
        Me.cbxClass.TabIndex = 2
        Me.cbxClass.Text = "CLASS"
        '
        'rdCol
        '
        Me.rdCol.AutoSize = True
        Me.rdCol.Location = New System.Drawing.Point(144, 19)
        Me.rdCol.Name = "rdCol"
        Me.rdCol.Size = New System.Drawing.Size(60, 17)
        Me.rdCol.TabIndex = 1
        Me.rdCol.TabStop = True
        Me.rdCol.Text = "College"
        Me.rdCol.UseVisualStyleBackColor = True
        '
        'rdNur
        '
        Me.rdNur.AutoSize = True
        Me.rdNur.Location = New System.Drawing.Point(40, 19)
        Me.rdNur.Name = "rdNur"
        Me.rdNur.Size = New System.Drawing.Size(98, 17)
        Me.rdNur.TabIndex = 0
        Me.rdNur.TabStop = True
        Me.rdNur.Text = "Nursery/Prmary"
        Me.rdNur.UseVisualStyleBackColor = True
        '
        'picPassport
        '
        Me.picPassport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPassport.Image = Global.GKQS.My.Resources.Resources.user_48px
        Me.picPassport.InitialImage = Global.GKQS.My.Resources.Resources.user_48px
        Me.picPassport.Location = New System.Drawing.Point(608, 23)
        Me.picPassport.Name = "picPassport"
        Me.picPassport.Size = New System.Drawing.Size(149, 148)
        Me.picPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPassport.TabIndex = 1
        Me.picPassport.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRESENT CLASS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DATE OF BIRTH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NATIONALITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(363, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "STATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(363, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "L.G.A."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(19, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 9
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(19, 114)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(0, 13)
        Me.lblClass.TabIndex = 10
        '
        'lblDob
        '
        Me.lblDob.Location = New System.Drawing.Point(19, 158)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(73, 17)
        Me.lblDob.TabIndex = 11
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(19, 202)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(0, 13)
        Me.lblGender.TabIndex = 12
        '
        'lblNat
        '
        Me.lblNat.AutoSize = True
        Me.lblNat.Location = New System.Drawing.Point(364, 70)
        Me.lblNat.Name = "lblNat"
        Me.lblNat.Size = New System.Drawing.Size(0, 13)
        Me.lblNat.TabIndex = 13
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(364, 114)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(0, 13)
        Me.lblState.TabIndex = 14
        '
        'lblLga
        '
        Me.lblLga.AutoSize = True
        Me.lblLga.Location = New System.Drawing.Point(364, 158)
        Me.lblLga.Name = "lblLga"
        Me.lblLga.Size = New System.Drawing.Size(0, 13)
        Me.lblLga.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIDtag)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblLga)
        Me.GroupBox2.Controls.Add(Me.picPassport)
        Me.GroupBox2.Controls.Add(Me.lblState)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblNat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblGender)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblDob)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblClass)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 234)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BIODATA"
        '
        'lblIDtag
        '
        Me.lblIDtag.AutoSize = True
        Me.lblIDtag.Location = New System.Drawing.Point(623, 203)
        Me.lblIDtag.Name = "lblIDtag"
        Me.lblIDtag.Size = New System.Drawing.Size(0, 13)
        Me.lblIDtag.TabIndex = 16
        Me.lblIDtag.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSummary)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(822, 192)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PAYMENT RECORD"
        '
        'dgvSummary
        '
        Me.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSummary.Location = New System.Drawing.Point(18, 19)
        Me.dgvSummary.Name = "dgvSummary"
        Me.dgvSummary.Size = New System.Drawing.Size(784, 165)
        Me.dgvSummary.TabIndex = 0
        '
        'GKQSDataSet
        '
        Me.GKQSDataSet.DataSetName = "GKQSDataSet"
        Me.GKQSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GKQSDataSetBindingSource
        '
        Me.GKQSDataSetBindingSource.DataSource = Me.GKQSDataSet
        Me.GKQSDataSetBindingSource.Position = 0
        '
        'OFDLoadImage
        '
        Me.OFDLoadImage.FileName = "OpenFileDialog1"
        '
        'grpResult
        '
        Me.grpResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grpResult.Controls.Add(Me.btnCancel)
        Me.grpResult.Controls.Add(Me.btnView)
        Me.grpResult.Controls.Add(Me.lblFilename)
        Me.grpResult.Controls.Add(Me.cbxSession)
        Me.grpResult.Controls.Add(Me.cbxTerm)
        Me.grpResult.Controls.Add(Me.rdTerm)
        Me.grpResult.Controls.Add(Me.rdMid)
        Me.grpResult.Location = New System.Drawing.Point(595, 41)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(254, 213)
        Me.grpResult.TabIndex = 6
        Me.grpResult.TabStop = False
        Me.grpResult.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(79, 180)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(160, 180)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 15
        Me.btnView.Text = "VIEW>>>"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'lblFilename
        '
        Me.lblFilename.BackColor = System.Drawing.Color.White
        Me.lblFilename.Location = New System.Drawing.Point(15, 142)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(220, 27)
        Me.lblFilename.TabIndex = 14
        '
        'cbxSession
        '
        Me.cbxSession.FormattingEnabled = True
        Me.cbxSession.Items.AddRange(New Object() {"2019/2020", "2020/2021", "2021/2022", "2022/2023", "2023/2024", "2024/2025"})
        Me.cbxSession.Location = New System.Drawing.Point(18, 106)
        Me.cbxSession.Name = "cbxSession"
        Me.cbxSession.Size = New System.Drawing.Size(121, 21)
        Me.cbxSession.TabIndex = 3
        Me.cbxSession.Text = "...SESSION..."
        '
        'cbxTerm
        '
        Me.cbxTerm.FormattingEnabled = True
        Me.cbxTerm.Items.AddRange(New Object() {"FIRST", "SECOND", "THIRD"})
        Me.cbxTerm.Location = New System.Drawing.Point(18, 79)
        Me.cbxTerm.Name = "cbxTerm"
        Me.cbxTerm.Size = New System.Drawing.Size(121, 21)
        Me.cbxTerm.TabIndex = 2
        Me.cbxTerm.Text = "...TERM..."
        '
        'rdTerm
        '
        Me.rdTerm.AutoSize = True
        Me.rdTerm.Location = New System.Drawing.Point(18, 42)
        Me.rdTerm.Name = "rdTerm"
        Me.rdTerm.Size = New System.Drawing.Size(132, 17)
        Me.rdTerm.TabIndex = 1
        Me.rdTerm.TabStop = True
        Me.rdTerm.Text = "END OF TERM EXAM"
        Me.rdTerm.UseVisualStyleBackColor = True
        '
        'rdMid
        '
        Me.rdMid.AutoSize = True
        Me.rdMid.Location = New System.Drawing.Point(18, 19)
        Me.rdMid.Name = "rdMid"
        Me.rdMid.Size = New System.Drawing.Size(112, 17)
        Me.rdMid.TabIndex = 0
        Me.rdMid.TabStop = True
        Me.rdMid.Text = "MID TERM EXAM"
        Me.rdMid.UseVisualStyleBackColor = True
        '
        'frmStudentSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(896, 539)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudentSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Summary"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picPassport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GKQSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GKQSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxStudents As System.Windows.Forms.ComboBox
    Friend WithEvents cbxClass As System.Windows.Forms.ComboBox
    Friend WithEvents rdCol As System.Windows.Forms.RadioButton
    Friend WithEvents rdNur As System.Windows.Forms.RadioButton
    Friend WithEvents picPassport As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblNat As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblLga As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSummary As System.Windows.Forms.DataGridView
    Friend WithEvents GKQSDataSet As GKQS.GKQSDataSet
    Friend WithEvents GKQSDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblIDtag As System.Windows.Forms.Label
    Friend WithEvents OFDLoadImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents grpResult As System.Windows.Forms.GroupBox
    Friend WithEvents cbxSession As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTerm As System.Windows.Forms.ComboBox
    Friend WithEvents rdTerm As System.Windows.Forms.RadioButton
    Friend WithEvents rdMid As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblFilename As System.Windows.Forms.Label
End Class
