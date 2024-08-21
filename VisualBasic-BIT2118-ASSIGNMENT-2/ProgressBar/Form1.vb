Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ProgressForm
    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick
        ProgressBar1.Value += 10

        Label1.Text = "Progress: " & ProgressBar1.Value & "%"

        ' Check if progress reaches 100%
        If ProgressBar1.Value = 100 Then
            ' Stop the timer
            SimulationTimer.Enabled = False
            MessageBox.Show("Process completed!")
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        SimulationTimer.Enabled = True

    End Sub
End Class
