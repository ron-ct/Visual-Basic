Public Class GUIForm
    Private Sub GUIForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        With Me
            .Width = 500
            .Height = 500
            .BackColor = Color.Green
        End With

        With StudentNameTextBox
            .BackColor = Color.Black
            .ForeColor = Color.White
        End With
        MarriedRadioButton.Checked = True
        OthersRichTextBox.SelectionColor = Color.Blue
        MaleRadioButton.Checked = True
        FemaleRadioButton.Checked = True

    End Sub
    Private Sub GUIForm_DoubleClick(Sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.BackColor = Color.Purple
        StudentNameTextBox.Text = String.Empty

    End Sub

    Private Sub PaymentsButton_Click(Sender As Object, e As EventArgs) Handles PaymentsButton.Click
        Dim Payments As Double = 0
        If TuitionCheckBox.Checked Then
            Payments = Payments + 60000
        End If
        If AccomodationCheckbox.Checked Then
            Payments = Payments + 8000
        End If

        MsgBox("Your payments is: " & ControlChars.NewLine & Payments)
    End Sub

    Private Sub ExitButton_Clicked(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class