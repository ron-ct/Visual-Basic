<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComputeCircle
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
        Label1 = New Label()
        RadiusTextBox = New TextBox()
        ComputeButton = New Button()
        ExitButton = New Button()
        Label2 = New Label()
        Label3 = New Label()
        CircumferenceTextBox = New TextBox()
        AreaTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter the radius of the circle:"
        ' 
        ' RadiusTextBox
        ' 
        RadiusTextBox.Location = New Point(238, 41)
        RadiusTextBox.Name = "RadiusTextBox"
        RadiusTextBox.Size = New Size(100, 23)
        RadiusTextBox.TabIndex = 1
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Location = New Point(238, 270)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(90, 43)
        ComputeButton.TabIndex = 2
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(392, 395)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 23)
        ExitButton.TabIndex = 4
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(105, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 7
        Label2.Text = "Circumference"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(337, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 8
        Label3.Text = "Area"
        ' 
        ' CircumferenceTextBox
        ' 
        CircumferenceTextBox.Location = New Point(105, 189)
        CircumferenceTextBox.Name = "CircumferenceTextBox"
        CircumferenceTextBox.Size = New Size(100, 23)
        CircumferenceTextBox.TabIndex = 9
        ' 
        ' AreaTextBox
        ' 
        AreaTextBox.Location = New Point(337, 189)
        AreaTextBox.Name = "AreaTextBox"
        AreaTextBox.Size = New Size(100, 23)
        AreaTextBox.TabIndex = 10
        ' 
        ' ComputeCircle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(AreaTextBox)
        Controls.Add(CircumferenceTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ExitButton)
        Controls.Add(ComputeButton)
        Controls.Add(RadiusTextBox)
        Controls.Add(Label1)
        Name = "ComputeCircle"
        Text = "Circumference and Area"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadiusTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CircumferenceTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox

End Class
