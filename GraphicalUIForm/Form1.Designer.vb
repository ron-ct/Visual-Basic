<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUIForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIForm))
        NameLabel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        SingleRadioButton = New RadioButton()
        MarriedRadioButton = New RadioButton()
        DivorcedRadioButton = New RadioButton()
        WidowRadioButton = New RadioButton()
        MaleRadioButton = New RadioButton()
        FemaleRadioButton = New RadioButton()
        OthersRadioButton = New RadioButton()
        Label8 = New Label()
        TuitionCheckBox = New CheckBox()
        MedicalCheckBox = New CheckBox()
        AccomodationCheckbox = New CheckBox()
        SportsCheckbox = New CheckBox()
        PaymentsButton = New Button()
        ExitButton = New Button()
        RichTextBox1 = New RichTextBox()
        StudentNameTextBox = New TextBox()
        AddressTextBox = New TextBox()
        CourseTextBox = New TextBox()
        TelephoneNumberTextBox = New TextBox()
        OthersRichTextBox = New RichTextBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(48, 9)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(88, 15)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Student Names"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 1
        Label2.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 2
        Label3.Text = "Course"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 3
        Label4.Text = "Telephone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 4
        Label5.Text = "Others"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Cyan
        GroupBox1.Controls.Add(OthersRadioButton)
        GroupBox1.Controls.Add(FemaleRadioButton)
        GroupBox1.Controls.Add(MaleRadioButton)
        GroupBox1.Location = New Point(48, 255)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(120, 125)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(551, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 108)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        GroupBox2.Controls.Add(WidowRadioButton)
        GroupBox2.Controls.Add(DivorcedRadioButton)
        GroupBox2.Controls.Add(MarriedRadioButton)
        GroupBox2.Controls.Add(SingleRadioButton)
        GroupBox2.Location = New Point(328, 255)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(217, 151)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Marital Status"
        ' 
        ' SingleRadioButton
        ' 
        SingleRadioButton.AutoSize = True
        SingleRadioButton.Location = New Point(14, 27)
        SingleRadioButton.Name = "SingleRadioButton"
        SingleRadioButton.Size = New Size(57, 19)
        SingleRadioButton.TabIndex = 1
        SingleRadioButton.TabStop = True
        SingleRadioButton.Text = "Single"
        SingleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MarriedRadioButton
        ' 
        MarriedRadioButton.AutoSize = True
        MarriedRadioButton.Location = New Point(13, 60)
        MarriedRadioButton.Name = "MarriedRadioButton"
        MarriedRadioButton.Size = New Size(66, 19)
        MarriedRadioButton.TabIndex = 2
        MarriedRadioButton.TabStop = True
        MarriedRadioButton.Text = "Married"
        MarriedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DivorcedRadioButton
        ' 
        DivorcedRadioButton.AutoSize = True
        DivorcedRadioButton.Location = New Point(13, 94)
        DivorcedRadioButton.Name = "DivorcedRadioButton"
        DivorcedRadioButton.Size = New Size(72, 19)
        DivorcedRadioButton.TabIndex = 3
        DivorcedRadioButton.TabStop = True
        DivorcedRadioButton.Text = "Divorced"
        DivorcedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' WidowRadioButton
        ' 
        WidowRadioButton.AutoSize = True
        WidowRadioButton.Location = New Point(13, 125)
        WidowRadioButton.Name = "WidowRadioButton"
        WidowRadioButton.Size = New Size(114, 19)
        WidowRadioButton.TabIndex = 4
        WidowRadioButton.TabStop = True
        WidowRadioButton.Text = "Widow/Widower"
        WidowRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MaleRadioButton
        ' 
        MaleRadioButton.AutoSize = True
        MaleRadioButton.Location = New Point(14, 29)
        MaleRadioButton.Name = "MaleRadioButton"
        MaleRadioButton.Size = New Size(51, 19)
        MaleRadioButton.TabIndex = 0
        MaleRadioButton.TabStop = True
        MaleRadioButton.Text = "Male"
        MaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FemaleRadioButton
        ' 
        FemaleRadioButton.AutoSize = True
        FemaleRadioButton.Location = New Point(13, 60)
        FemaleRadioButton.Name = "FemaleRadioButton"
        FemaleRadioButton.Size = New Size(63, 19)
        FemaleRadioButton.TabIndex = 1
        FemaleRadioButton.TabStop = True
        FemaleRadioButton.Text = "Female"
        FemaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' OthersRadioButton
        ' 
        OthersRadioButton.AutoSize = True
        OthersRadioButton.Location = New Point(13, 91)
        OthersRadioButton.Name = "OthersRadioButton"
        OthersRadioButton.Size = New Size(60, 19)
        OthersRadioButton.TabIndex = 2
        OthersRadioButton.TabStop = True
        OthersRadioButton.Text = "Others"
        OthersRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(53, 394)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 10
        Label8.Text = "Payments"
        ' 
        ' TuitionCheckBox
        ' 
        TuitionCheckBox.AutoSize = True
        TuitionCheckBox.Location = New Point(53, 421)
        TuitionCheckBox.Name = "TuitionCheckBox"
        TuitionCheckBox.Size = New Size(63, 19)
        TuitionCheckBox.TabIndex = 11
        TuitionCheckBox.Text = "Tuition"
        TuitionCheckBox.UseVisualStyleBackColor = True
        ' 
        ' MedicalCheckBox
        ' 
        MedicalCheckBox.AutoSize = True
        MedicalCheckBox.Location = New Point(53, 446)
        MedicalCheckBox.Name = "MedicalCheckBox"
        MedicalCheckBox.Size = New Size(68, 19)
        MedicalCheckBox.TabIndex = 12
        MedicalCheckBox.Text = "Medical"
        MedicalCheckBox.UseVisualStyleBackColor = True
        ' 
        ' AccomodationCheckbox
        ' 
        AccomodationCheckbox.AutoSize = True
        AccomodationCheckbox.Location = New Point(53, 471)
        AccomodationCheckbox.Name = "AccomodationCheckbox"
        AccomodationCheckbox.Size = New Size(105, 19)
        AccomodationCheckbox.TabIndex = 13
        AccomodationCheckbox.Text = "Accomodation"
        AccomodationCheckbox.UseVisualStyleBackColor = True
        ' 
        ' SportsCheckbox
        ' 
        SportsCheckbox.AutoSize = True
        SportsCheckbox.Location = New Point(53, 496)
        SportsCheckbox.Name = "SportsCheckbox"
        SportsCheckbox.Size = New Size(59, 19)
        SportsCheckbox.TabIndex = 14
        SportsCheckbox.Text = "Sports"
        SportsCheckbox.UseVisualStyleBackColor = True
        ' 
        ' PaymentsButton
        ' 
        PaymentsButton.Location = New Point(304, 488)
        PaymentsButton.Name = "PaymentsButton"
        PaymentsButton.Size = New Size(100, 33)
        PaymentsButton.TabIndex = 15
        PaymentsButton.Text = "Payments"
        PaymentsButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(454, 489)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(92, 32)
        ExitButton.TabIndex = 16
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(551, 180)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(143, 99)
        RichTextBox1.TabIndex = 17
        RichTextBox1.Text = ""
        ' 
        ' StudentNameTextBox
        ' 
        StudentNameTextBox.Location = New Point(178, 9)
        StudentNameTextBox.Name = "StudentNameTextBox"
        StudentNameTextBox.Size = New Size(100, 23)
        StudentNameTextBox.TabIndex = 18
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.BackColor = Color.Black
        AddressTextBox.ForeColor = Color.White
        AddressTextBox.Location = New Point(178, 40)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(100, 23)
        AddressTextBox.TabIndex = 19
        ' 
        ' CourseTextBox
        ' 
        CourseTextBox.Location = New Point(178, 79)
        CourseTextBox.Name = "CourseTextBox"
        CourseTextBox.Size = New Size(100, 23)
        CourseTextBox.TabIndex = 20
        ' 
        ' TelephoneNumberTextBox
        ' 
        TelephoneNumberTextBox.Location = New Point(178, 125)
        TelephoneNumberTextBox.Name = "TelephoneNumberTextBox"
        TelephoneNumberTextBox.Size = New Size(100, 23)
        TelephoneNumberTextBox.TabIndex = 21
        ' 
        ' OthersRichTextBox
        ' 
        OthersRichTextBox.Location = New Point(178, 179)
        OthersRichTextBox.Name = "OthersRichTextBox"
        OthersRichTextBox.Size = New Size(123, 71)
        OthersRichTextBox.TabIndex = 22
        OthersRichTextBox.Text = ""
        ' 
        ' GUIForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(800, 555)
        Controls.Add(OthersRichTextBox)
        Controls.Add(TelephoneNumberTextBox)
        Controls.Add(CourseTextBox)
        Controls.Add(AddressTextBox)
        Controls.Add(StudentNameTextBox)
        Controls.Add(RichTextBox1)
        Controls.Add(ExitButton)
        Controls.Add(PaymentsButton)
        Controls.Add(SportsCheckbox)
        Controls.Add(AccomodationCheckbox)
        Controls.Add(MedicalCheckBox)
        Controls.Add(TuitionCheckBox)
        Controls.Add(Label8)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NameLabel)
        Name = "GUIForm"
        Text = "GUI Test App"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OthersRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents WidowRadioButton As RadioButton
    Friend WithEvents DivorcedRadioButton As RadioButton
    Friend WithEvents MarriedRadioButton As RadioButton
    Friend WithEvents SingleRadioButton As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents TuitionCheckBox As CheckBox
    Friend WithEvents MedicalCheckBox As CheckBox
    Friend WithEvents AccomodationCheckbox As CheckBox
    Friend WithEvents SportsCheckbox As CheckBox
    Friend WithEvents PaymentsButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents TelephoneNumberTextBox As TextBox
    Friend WithEvents OthersRichTextBox As RichTextBox

End Class
