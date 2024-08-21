<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesCalculatorForm
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
        CalculateButton = New Button()
        NameTextBox = New TextBox()
        SalesTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        ResultListBox = New ListBox()
        SuspendLayout()
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(71, 129)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(149, 37)
        CalculateButton.TabIndex = 0
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(112, 15)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(191, 23)
        NameTextBox.TabIndex = 1
        ' 
        ' SalesTextBox
        ' 
        SalesTextBox.Location = New Point(112, 53)
        SalesTextBox.Name = "SalesTextBox"
        SalesTextBox.Size = New Size(191, 23)
        SalesTextBox.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 3
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 4
        Label2.Text = "Sales"
        ' 
        ' ResultListBox
        ' 
        ResultListBox.FormattingEnabled = True
        ResultListBox.ItemHeight = 15
        ResultListBox.Location = New Point(400, 15)
        ResultListBox.Name = "ResultListBox"
        ResultListBox.Size = New Size(221, 394)
        ResultListBox.TabIndex = 5
        ' 
        ' SalesCalculatorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ResultListBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SalesTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(CalculateButton)
        Name = "SalesCalculatorForm"
        Text = "Sales Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultListBox As ListBox

End Class
