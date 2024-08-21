<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiplicationTableForm
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
        MultiplicationTextBox = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' MultiplicationTextBox
        ' 
        MultiplicationTextBox.Location = New Point(195, 68)
        MultiplicationTextBox.Multiline = True
        MultiplicationTextBox.Name = "MultiplicationTextBox"
        MultiplicationTextBox.Size = New Size(362, 169)
        MultiplicationTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(195, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 15)
        Label1.TabIndex = 1
        Label1.Text = "Multiplication Table"
        ' 
        ' MultiplicationTableForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(MultiplicationTextBox)
        Name = "MultiplicationTableForm"
        Text = "Multiplication Table"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MultiplicationTextBox As TextBox
    Friend WithEvents Label1 As Label

End Class
