<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        InterestListBox = New ListBox()
        CalculateButton = New Button()
        SuspendLayout()
        ' 
        ' InterestListBox
        ' 
        InterestListBox.FormattingEnabled = True
        InterestListBox.ItemHeight = 15
        InterestListBox.Location = New Point(139, 60)
        InterestListBox.Name = "InterestListBox"
        InterestListBox.Size = New Size(525, 184)
        InterestListBox.TabIndex = 0
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(139, 328)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(170, 33)
        CalculateButton.TabIndex = 1
        CalculateButton.Text = "Calculate Button"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CalculateButton)
        Controls.Add(InterestListBox)
        Name = "Form1"
        Text = "Interest"
        ResumeLayout(False)
    End Sub

    Friend WithEvents InterestListBox As ListBox
    Friend WithEvents CalculateButton As Button

End Class
