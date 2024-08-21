Public Class WelcomeForm
    Private Sub LoadObjectDemoButton_Click(sender As Object, e As EventArgs) Handles LoadObjectDemoButton.Click
        Me.Hide()
        ObjectDemonstrations.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub WelcomeForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub LoadObjectDemoButton_MouseHover(sender As Object, e As EventArgs) Handles LoadObjectDemoButton.MouseHover
        ToolTip1.Show("Press here to load the Object Form", LoadObjectDemoButton)

    End Sub

    Private Sub ExitButton_MouseHover(sender As Object, e As EventArgs) Handles ExitButton.MouseHover
        ToolTip2.Show("Click here to exit application", ExitButton)
    End Sub

End Class