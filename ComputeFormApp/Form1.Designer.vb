<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComputeForm
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
        ComputeButton = New Button()
        ExitButton = New Button()
        Number1Label = New Label()
        Number2Label = New Label()
        ResultsLabel = New Label()
        Number1Textbox = New TextBox()
        Number2Textbox = New TextBox()
        ResultsTextbox = New TextBox()
        SuspendLayout()
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Location = New Point(290, 274)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(106, 39)
        ComputeButton.TabIndex = 0
        ComputeButton.Text = "&Compute"
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(514, 274)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(109, 39)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Number1Label
        ' 
        Number1Label.AutoSize = True
        Number1Label.Location = New Point(186, 44)
        Number1Label.Name = "Number1Label"
        Number1Label.Size = New Size(127, 15)
        Number1Label.TabIndex = 2
        Number1Label.Text = "Enter the first Number:"
        ' 
        ' Number2Label
        ' 
        Number2Label.AutoSize = True
        Number2Label.Location = New Point(186, 87)
        Number2Label.Name = "Number2Label"
        Number2Label.Size = New Size(144, 15)
        Number2Label.TabIndex = 3
        Number2Label.Text = "Enter the Second number:"
        ' 
        ' ResultsLabel
        ' 
        ResultsLabel.AutoSize = True
        ResultsLabel.Location = New Point(186, 128)
        ResultsLabel.Name = "ResultsLabel"
        ResultsLabel.Size = New Size(44, 15)
        ResultsLabel.TabIndex = 4
        ResultsLabel.Text = "Results"
        ' 
        ' Number1Textbox
        ' 
        Number1Textbox.Location = New Point(398, 41)
        Number1Textbox.Name = "Number1Textbox"
        Number1Textbox.Size = New Size(171, 23)
        Number1Textbox.TabIndex = 5
        ' 
        ' Number2Textbox
        ' 
        Number2Textbox.Location = New Point(396, 84)
        Number2Textbox.Name = "Number2Textbox"
        Number2Textbox.Size = New Size(173, 23)
        Number2Textbox.TabIndex = 6
        ' 
        ' ResultsTextbox
        ' 
        ResultsTextbox.Location = New Point(397, 125)
        ResultsTextbox.Name = "ResultsTextbox"
        ResultsTextbox.Size = New Size(172, 23)
        ResultsTextbox.TabIndex = 7
        ' 
        ' ComputeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(ResultsTextbox)
        Controls.Add(Number2Textbox)
        Controls.Add(Number1Textbox)
        Controls.Add(ResultsLabel)
        Controls.Add(Number2Label)
        Controls.Add(Number1Label)
        Controls.Add(ExitButton)
        Controls.Add(ComputeButton)
        Name = "ComputeForm"
        Text = "COMPUTE APP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComputeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Number1Label As Label
    Friend WithEvents Number2Label As Label
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents Number1Textbox As TextBox
    Friend WithEvents Number2Textbox As TextBox
    Friend WithEvents ResultsTextbox As TextBox

End Class
