<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
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
        components = New ComponentModel.Container()
        LoadObjectDemoButton = New Button()
        ExitButton = New Button()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' LoadObjectDemoButton
        ' 
        LoadObjectDemoButton.Location = New Point(106, 288)
        LoadObjectDemoButton.Name = "LoadObjectDemoButton"
        LoadObjectDemoButton.Size = New Size(222, 46)
        LoadObjectDemoButton.TabIndex = 0
        LoadObjectDemoButton.Text = "&Load Object Demo"
        LoadObjectDemoButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(458, 288)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(225, 50)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&XIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(LoadObjectDemoButton)
        Name = "WelcomeForm"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadObjectDemoButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip

End Class
