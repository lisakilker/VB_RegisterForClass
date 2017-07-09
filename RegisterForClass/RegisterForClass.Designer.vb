<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterForClass
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
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.lblRegisterForClasses = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblNumberOfUnit = New System.Windows.Forms.Label()
        Me.mskStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfUnits = New System.Windows.Forms.TextBox()
        Me.gboResidence = New System.Windows.Forms.GroupBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.gboHousing = New System.Windows.Forms.GroupBox()
        Me.radJulianSuites = New System.Windows.Forms.RadioButton()
        Me.radPercyHall = New System.Windows.Forms.RadioButton()
        Me.radCooperDorm = New System.Windows.Forms.RadioButton()
        Me.btnCalculateCosts = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.ddpMajor = New System.Windows.Forms.ComboBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboResidence.SuspendLayout()
        Me.gboHousing.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Image = Global.RegisterForClass.My.Resources.Resources.College
        Me.picPicture.Location = New System.Drawing.Point(5, 0)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(203, 144)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'lblRegisterForClasses
        '
        Me.lblRegisterForClasses.AutoSize = True
        Me.lblRegisterForClasses.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterForClasses.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegisterForClasses.Location = New System.Drawing.Point(232, 28)
        Me.lblRegisterForClasses.Name = "lblRegisterForClasses"
        Me.lblRegisterForClasses.Size = New System.Drawing.Size(289, 64)
        Me.lblRegisterForClasses.TabIndex = 1
        Me.lblRegisterForClasses.Text = "Register For Classes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Raven College"
        Me.lblRegisterForClasses.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblStudentID.Location = New System.Drawing.Point(22, 165)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(84, 18)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Student ID:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblStudentName.Location = New System.Drawing.Point(22, 207)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(111, 18)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name:"
        '
        'lblNumberOfUnit
        '
        Me.lblNumberOfUnit.AutoSize = True
        Me.lblNumberOfUnit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfUnit.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblNumberOfUnit.Location = New System.Drawing.Point(22, 248)
        Me.lblNumberOfUnit.Name = "lblNumberOfUnit"
        Me.lblNumberOfUnit.Size = New System.Drawing.Size(126, 18)
        Me.lblNumberOfUnit.TabIndex = 4
        Me.lblNumberOfUnit.Text = "Number Of Units:"
        '
        'mskStudentID
        '
        Me.mskStudentID.Location = New System.Drawing.Point(154, 162)
        Me.mskStudentID.Mask = "000-00-0000"
        Me.mskStudentID.Name = "mskStudentID"
        Me.mskStudentID.Size = New System.Drawing.Size(67, 20)
        Me.mskStudentID.TabIndex = 1
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(154, 205)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(180, 20)
        Me.txtStudentName.TabIndex = 2
        '
        'txtNumberOfUnits
        '
        Me.txtNumberOfUnits.Location = New System.Drawing.Point(154, 246)
        Me.txtNumberOfUnits.Name = "txtNumberOfUnits"
        Me.txtNumberOfUnits.Size = New System.Drawing.Size(39, 20)
        Me.txtNumberOfUnits.TabIndex = 3
        '
        'gboResidence
        '
        Me.gboResidence.Controls.Add(Me.radOnCampus)
        Me.gboResidence.Controls.Add(Me.radOffCampus)
        Me.gboResidence.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboResidence.ForeColor = System.Drawing.Color.OrangeRed
        Me.gboResidence.Location = New System.Drawing.Point(49, 289)
        Me.gboResidence.Name = "gboResidence"
        Me.gboResidence.Size = New System.Drawing.Size(112, 68)
        Me.gboResidence.TabIndex = 5
        Me.gboResidence.TabStop = False
        Me.gboResidence.Text = "Residence"
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Location = New System.Drawing.Point(7, 44)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(95, 20)
        Me.radOnCampus.TabIndex = 5
        Me.radOnCampus.TabStop = True
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Location = New System.Drawing.Point(7, 20)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(94, 20)
        Me.radOffCampus.TabIndex = 4
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'gboHousing
        '
        Me.gboHousing.Controls.Add(Me.radJulianSuites)
        Me.gboHousing.Controls.Add(Me.radPercyHall)
        Me.gboHousing.Controls.Add(Me.radCooperDorm)
        Me.gboHousing.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboHousing.ForeColor = System.Drawing.Color.OrangeRed
        Me.gboHousing.Location = New System.Drawing.Point(187, 289)
        Me.gboHousing.Name = "gboHousing"
        Me.gboHousing.Size = New System.Drawing.Size(117, 96)
        Me.gboHousing.TabIndex = 6
        Me.gboHousing.TabStop = False
        Me.gboHousing.Text = "Housing"
        '
        'radJulianSuites
        '
        Me.radJulianSuites.AutoSize = True
        Me.radJulianSuites.Location = New System.Drawing.Point(6, 65)
        Me.radJulianSuites.Name = "radJulianSuites"
        Me.radJulianSuites.Size = New System.Drawing.Size(100, 20)
        Me.radJulianSuites.TabIndex = 8
        Me.radJulianSuites.TabStop = True
        Me.radJulianSuites.Text = "Julian Suites"
        Me.radJulianSuites.UseVisualStyleBackColor = True
        '
        'radPercyHall
        '
        Me.radPercyHall.AutoSize = True
        Me.radPercyHall.Location = New System.Drawing.Point(6, 42)
        Me.radPercyHall.Name = "radPercyHall"
        Me.radPercyHall.Size = New System.Drawing.Size(93, 20)
        Me.radPercyHall.TabIndex = 7
        Me.radPercyHall.TabStop = True
        Me.radPercyHall.Text = "Percey Hall"
        Me.radPercyHall.UseVisualStyleBackColor = True
        '
        'radCooperDorm
        '
        Me.radCooperDorm.AutoSize = True
        Me.radCooperDorm.Location = New System.Drawing.Point(6, 19)
        Me.radCooperDorm.Name = "radCooperDorm"
        Me.radCooperDorm.Size = New System.Drawing.Size(102, 20)
        Me.radCooperDorm.TabIndex = 6
        Me.radCooperDorm.TabStop = True
        Me.radCooperDorm.Text = "Cooper Dorm"
        Me.radCooperDorm.UseVisualStyleBackColor = True
        '
        'btnCalculateCosts
        '
        Me.btnCalculateCosts.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalculateCosts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCosts.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCalculateCosts.Location = New System.Drawing.Point(96, 410)
        Me.btnCalculateCosts.Name = "btnCalculateCosts"
        Me.btnCalculateCosts.Size = New System.Drawing.Size(125, 28)
        Me.btnCalculateCosts.TabIndex = 10
        Me.btnCalculateCosts.Text = "Calculate Costs"
        Me.btnCalculateCosts.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Location = New System.Drawing.Point(321, 410)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 28)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCalculation.Location = New System.Drawing.Point(149, 456)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(72, 16)
        Me.lblCalculation.TabIndex = 11
        Me.lblCalculation.Text = "Calculation"
        Me.lblCalculation.Visible = False
        '
        'ddpMajor
        '
        Me.ddpMajor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddpMajor.ForeColor = System.Drawing.Color.OrangeRed
        Me.ddpMajor.FormattingEnabled = True
        Me.ddpMajor.Items.AddRange(New Object() {"Computer Science", "Accounting", "Political Science", "Welding", "Art"})
        Me.ddpMajor.Location = New System.Drawing.Point(368, 289)
        Me.ddpMajor.Name = "ddpMajor"
        Me.ddpMajor.Size = New System.Drawing.Size(137, 24)
        Me.ddpMajor.TabIndex = 12
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblMajor.Location = New System.Drawing.Point(318, 289)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(44, 16)
        Me.lblMajor.TabIndex = 9
        Me.lblMajor.Text = "Major:"
        '
        'frmRegisterForClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 493)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.ddpMajor)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCosts)
        Me.Controls.Add(Me.gboHousing)
        Me.Controls.Add(Me.gboResidence)
        Me.Controls.Add(Me.txtNumberOfUnits)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.mskStudentID)
        Me.Controls.Add(Me.lblNumberOfUnit)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblRegisterForClasses)
        Me.Controls.Add(Me.picPicture)
        Me.Name = "frmRegisterForClass"
        Me.Text = "College Registration Costs"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboResidence.ResumeLayout(False)
        Me.gboResidence.PerformLayout()
        Me.gboHousing.ResumeLayout(False)
        Me.gboHousing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblRegisterForClasses As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfUnit As System.Windows.Forms.Label
    Friend WithEvents mskStudentID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfUnits As System.Windows.Forms.TextBox
    Friend WithEvents gboResidence As System.Windows.Forms.GroupBox
    Friend WithEvents radOnCampus As System.Windows.Forms.RadioButton
    Friend WithEvents radOffCampus As System.Windows.Forms.RadioButton
    Friend WithEvents gboHousing As System.Windows.Forms.GroupBox
    Friend WithEvents radJulianSuites As System.Windows.Forms.RadioButton
    Friend WithEvents radPercyHall As System.Windows.Forms.RadioButton
    Friend WithEvents radCooperDorm As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculateCosts As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblCalculation As System.Windows.Forms.Label
    Friend WithEvents ddpMajor As System.Windows.Forms.ComboBox
    Friend WithEvents lblMajor As System.Windows.Forms.Label

End Class
