<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstrations
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
        EnterTextBox = New TextBox()
        Label1 = New Label()
        LoadPictureBox = New PictureBox()
        LoadPictureButton = New Button()
        GroupBox1 = New GroupBox()
        TahomaRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        GaramondRadioButton = New RadioButton()
        GroupBox2 = New GroupBox()
        ItalicBoldCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        ItalicCheckBox = New CheckBox()
        GroupBox3 = New GroupBox()
        RedRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        ExitButton = New Button()
        CType(LoadPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' EnterTextBox
        ' 
        EnterTextBox.Location = New Point(51, 41)
        EnterTextBox.Name = "EnterTextBox"
        EnterTextBox.Size = New Size(166, 23)
        EnterTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter some Text:"
        ' 
        ' LoadPictureBox
        ' 
        LoadPictureBox.Location = New Point(60, 149)
        LoadPictureBox.Name = "LoadPictureBox"
        LoadPictureBox.Size = New Size(197, 176)
        LoadPictureBox.TabIndex = 2
        LoadPictureBox.TabStop = False
        ' 
        ' LoadPictureButton
        ' 
        LoadPictureButton.Location = New Point(82, 345)
        LoadPictureButton.Name = "LoadPictureButton"
        LoadPictureButton.Size = New Size(151, 30)
        LoadPictureButton.TabIndex = 3
        LoadPictureButton.Text = "Load Picture"
        LoadPictureButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TahomaRadioButton)
        GroupBox1.Controls.Add(MagnetoRadioButton)
        GroupBox1.Controls.Add(GaramondRadioButton)
        GroupBox1.Location = New Point(329, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(362, 95)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Font"
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(244, 42)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(67, 19)
        TahomaRadioButton.TabIndex = 2
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(123, 42)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(73, 19)
        MagnetoRadioButton.TabIndex = 1
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(6, 42)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(81, 19)
        GaramondRadioButton.TabIndex = 0
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ItalicBoldCheckBox)
        GroupBox2.Controls.Add(BoldCheckBox)
        GroupBox2.Controls.Add(ItalicCheckBox)
        GroupBox2.Location = New Point(338, 160)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(160, 194)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font Style"
        ' 
        ' ItalicBoldCheckBox
        ' 
        ItalicBoldCheckBox.AutoSize = True
        ItalicBoldCheckBox.Location = New Point(11, 102)
        ItalicBoldCheckBox.Name = "ItalicBoldCheckBox"
        ItalicBoldCheckBox.Size = New Size(78, 19)
        ItalicBoldCheckBox.TabIndex = 2
        ItalicBoldCheckBox.Text = "Italic Bold"
        ItalicBoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Location = New Point(11, 67)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(50, 19)
        BoldCheckBox.TabIndex = 1
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Location = New Point(11, 30)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(51, 19)
        ItalicCheckBox.TabIndex = 0
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RedRadioButton)
        GroupBox3.Controls.Add(BlueRadioButton)
        GroupBox3.Controls.Add(GreenRadioButton)
        GroupBox3.Location = New Point(529, 160)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(162, 194)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Color"
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(16, 102)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(45, 19)
        RedRadioButton.TabIndex = 2
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(16, 66)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(48, 19)
        BlueRadioButton.TabIndex = 1
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(16, 30)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(56, 19)
        GreenRadioButton.TabIndex = 0
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(395, 388)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(176, 39)
        ExitButton.TabIndex = 7
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ObjectDemonstrations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(LoadPictureButton)
        Controls.Add(LoadPictureBox)
        Controls.Add(Label1)
        Controls.Add(EnterTextBox)
        Name = "ObjectDemonstrations"
        Text = "Object demonstrations"
        CType(LoadPictureBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EnterTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadPictureBox As PictureBox
    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ItalicBoldCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
End Class
