Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        ' Clear the list box
        InterestListBox.Items.Clear()

        Const principal As Decimal = 1000000
        Const annualInterestRate As Decimal = 0.05

        ' Calculate and display the amount for each year
        For CurrentYear = 1 To 10
            Dim amount As Decimal = principal * (1 + annualInterestRate) ^ CurrentYear
            InterestListBox.Items.Add($"Year {CurrentYear}: KSh {amount:N2}")
        Next
    End Sub


End Class
