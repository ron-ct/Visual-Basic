Public Class ComputeForm
    Private Sub ComputeButton_Click(Sender As Object, e As EventArgs) Handles ComputeButton.Click
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer

        FirstNumber = Number1Textbox.Text
        SecondNumber = Number2Textbox.Text

        ResultsTextbox.Text = FirstNumber + SecondNumber

    End Sub

    Private Sub ExitButton_Click(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class