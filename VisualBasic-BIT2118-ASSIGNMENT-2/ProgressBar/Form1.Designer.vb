<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgressForm
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
        Label1 = New Label()
        SimulationTimer = New Timer(components)
        ProgressBar1 = New System.Windows.Forms.ProgressBar()
        StartButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(327, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "Progress: 0%"
        ' 
        ' SimulationTimer
        ' 
        SimulationTimer.Interval = 1000
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(142, 205)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(422, 28)
        ProgressBar1.TabIndex = 1
        ' 
        ' StartButton
        ' 
        StartButton.Location = New Point(272, 283)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(180, 33)
        StartButton.TabIndex = 2
        StartButton.Text = "Click here to start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' ProgressForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 450)
        Controls.Add(StartButton)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Name = "ProgressForm"
        Text = "Progress Simulation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SimulationTimer As Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StartButton As Button

End Class
