<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demonstrations
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
        textbox1 = New TextBox()
        picturebox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        btntahoma = New RadioButton()
        btnmagneto = New RadioButton()
        btngaramond = New RadioButton()
        GroupBox2 = New GroupBox()
        cbitalicbold = New CheckBox()
        cbbold = New CheckBox()
        cbitalic = New CheckBox()
        GroupBox3 = New GroupBox()
        btnred = New RadioButton()
        btnblue = New RadioButton()
        btngreen = New RadioButton()
        btnloadpicture = New Button()
        btnexitobject = New Button()
        CType(picturebox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' textbox1
        ' 
        textbox1.Location = New Point(170, 118)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(200, 39)
        textbox1.TabIndex = 0
        ' 
        ' picturebox1
        ' 
        picturebox1.BorderStyle = BorderStyle.Fixed3D
        picturebox1.Location = New Point(75, 229)
        picturebox1.Name = "picturebox1"
        picturebox1.Size = New Size(586, 372)
        picturebox1.TabIndex = 1
        picturebox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btntahoma)
        GroupBox1.Controls.Add(btnmagneto)
        GroupBox1.Controls.Add(btngaramond)
        GroupBox1.Location = New Point(857, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(843, 130)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Font"
        ' 
        ' btntahoma
        ' 
        btntahoma.AutoSize = True
        btntahoma.Location = New Point(593, 52)
        btntahoma.Name = "btntahoma"
        btntahoma.Size = New Size(128, 36)
        btntahoma.TabIndex = 2
        btntahoma.TabStop = True
        btntahoma.Text = "Tahoma"
        btntahoma.UseVisualStyleBackColor = True
        ' 
        ' btnmagneto
        ' 
        btnmagneto.AutoSize = True
        btnmagneto.Location = New Point(291, 52)
        btnmagneto.Name = "btnmagneto"
        btnmagneto.Size = New Size(142, 36)
        btnmagneto.TabIndex = 1
        btnmagneto.TabStop = True
        btnmagneto.Text = "Magneto"
        btnmagneto.UseVisualStyleBackColor = True
        ' 
        ' btngaramond
        ' 
        btngaramond.AutoSize = True
        btngaramond.Location = New Point(45, 52)
        btngaramond.Name = "btngaramond"
        btngaramond.Size = New Size(156, 36)
        btngaramond.TabIndex = 0
        btngaramond.TabStop = True
        btngaramond.Text = "Garamond"
        btngaramond.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbitalicbold)
        GroupBox2.Controls.Add(cbbold)
        GroupBox2.Controls.Add(cbitalic)
        GroupBox2.Location = New Point(861, 232)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(329, 369)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font Style"
        ' 
        ' cbitalicbold
        ' 
        cbitalicbold.AutoSize = True
        cbitalicbold.Location = New Point(55, 270)
        cbitalicbold.Name = "cbitalicbold"
        cbitalicbold.Size = New Size(150, 36)
        cbitalicbold.TabIndex = 2
        cbitalicbold.Text = "Italic Bold"
        cbitalicbold.UseVisualStyleBackColor = True
        ' 
        ' cbbold
        ' 
        cbbold.AutoSize = True
        cbbold.Location = New Point(55, 179)
        cbbold.Name = "cbbold"
        cbbold.Size = New Size(94, 36)
        cbbold.TabIndex = 1
        cbbold.Text = "Bold"
        cbbold.UseVisualStyleBackColor = True
        ' 
        ' cbitalic
        ' 
        cbitalic.AutoSize = True
        cbitalic.Location = New Point(55, 73)
        cbitalic.Name = "cbitalic"
        cbitalic.Size = New Size(95, 36)
        cbitalic.TabIndex = 0
        cbitalic.Text = "Italic"
        cbitalic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnred)
        GroupBox3.Controls.Add(btnblue)
        GroupBox3.Controls.Add(btngreen)
        GroupBox3.Location = New Point(1328, 224)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(333, 377)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font color"
        ' 
        ' btnred
        ' 
        btnred.AutoSize = True
        btnred.Location = New Point(64, 250)
        btnred.Name = "btnred"
        btnred.Size = New Size(85, 36)
        btnred.TabIndex = 2
        btnred.TabStop = True
        btnred.Text = "Red"
        btnred.UseVisualStyleBackColor = True
        ' 
        ' btnblue
        ' 
        btnblue.AutoSize = True
        btnblue.Location = New Point(64, 177)
        btnblue.Name = "btnblue"
        btnblue.Size = New Size(92, 36)
        btnblue.TabIndex = 1
        btnblue.TabStop = True
        btnblue.Text = "Blue"
        btnblue.UseVisualStyleBackColor = True
        ' 
        ' btngreen
        ' 
        btngreen.AutoSize = True
        btngreen.Location = New Point(64, 92)
        btngreen.Name = "btngreen"
        btngreen.Size = New Size(109, 36)
        btngreen.TabIndex = 0
        btngreen.TabStop = True
        btngreen.Text = "Green"
        btngreen.UseVisualStyleBackColor = True
        ' 
        ' btnloadpicture
        ' 
        btnloadpicture.ImageAlign = ContentAlignment.TopLeft
        btnloadpicture.Location = New Point(127, 662)
        btnloadpicture.Name = "btnloadpicture"
        btnloadpicture.Size = New Size(446, 55)
        btnloadpicture.TabIndex = 5
        btnloadpicture.Text = "Load Picture"
        btnloadpicture.UseVisualStyleBackColor = True
        ' 
        ' btnexitobject
        ' 
        btnexitobject.Location = New Point(1342, 641)
        btnexitobject.Name = "btnexitobject"
        btnexitobject.Size = New Size(291, 73)
        btnexitobject.TabIndex = 6
        btnexitobject.Text = "Exit"
        btnexitobject.UseVisualStyleBackColor = True
        ' 
        ' Object_Demonstrations
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1791, 729)
        Controls.Add(btnexitobject)
        Controls.Add(btnloadpicture)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(picturebox1)
        Controls.Add(textbox1)
        Name = "Object_Demonstrations"
        Text = "Object_Demonstrations"
        CType(picturebox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox1 As TextBox
    Friend WithEvents picturebox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btntahoma As RadioButton
    Friend WithEvents btnmagneto As RadioButton
    Friend WithEvents btngaramond As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbitalicbold As CheckBox
    Friend WithEvents cbbold As CheckBox
    Friend WithEvents cbitalic As CheckBox
    Friend WithEvents btnred As RadioButton
    Friend WithEvents btnblue As RadioButton
    Friend WithEvents btngreen As RadioButton
    Friend WithEvents btnloadpicture As Button
    Friend WithEvents btnexitobject As Button
End Class
