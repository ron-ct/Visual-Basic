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
        components = New ComponentModel.Container()
        btnexit = New Button()
        btnloaddemo = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' btnexit
        ' 
        btnexit.AutoSize = True
        btnexit.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit.ForeColor = SystemColors.ControlText
        btnexit.Location = New Point(873, 552)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(267, 88)
        btnexit.TabIndex = 0
        btnexit.Text = "EXIT"
        btnexit.TextAlign = ContentAlignment.TopLeft
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' btnloaddemo
        ' 
        btnloaddemo.Font = New Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnloaddemo.ImageAlign = ContentAlignment.TopRight
        btnloaddemo.Location = New Point(277, 553)
        btnloaddemo.Name = "btnloaddemo"
        btnloaddemo.Size = New Size(346, 87)
        btnloaddemo.TabIndex = 1
        btnloaddemo.Text = "Load Object Demo"
        btnloaddemo.TextAlign = ContentAlignment.TopLeft
        ToolTip1.SetToolTip(btnloaddemo, "click to open" & vbCrLf & vbCrLf)
        btnloaddemo.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipTitle = "info"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1865, 899)
        Controls.Add(btnloaddemo)
        Controls.Add(btnexit)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Welcoming Form"
        ToolTip1.SetToolTip(Me, "click to open object Demo" & vbCrLf)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents btnloaddemo As Button
    Friend WithEvents ToolTip1 As ToolTip

End Class
