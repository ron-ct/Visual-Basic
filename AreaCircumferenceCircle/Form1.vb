Public Class ComputeCircle
    Private Sub ComputeButton_Clicked(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Dim Area As Double
        Dim Circumference As Double
        Dim radius As Integer
        radius = Val(RadiusTextBox.Text)

        Area = 3.142 * radius * radius
        Circumference = radius * 2 * 3.142

        CircumferenceTextBox.Text = Circumference
        AreaTextBox.Text = Area
    End Sub
    Private Sub ExitButton_Clicked(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class