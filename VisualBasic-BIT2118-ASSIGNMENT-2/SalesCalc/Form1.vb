Public Class SalesCalculatorForm
    Const weeklyBasePay As Decimal = 2500
    Const quota As Decimal = 1000
    Const commissionRate As Decimal = 0.15

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim salespersonName As String = NameTextBox.Text
        Dim dailySales As Decimal

        If Decimal.TryParse(SalesTextBox.Text, dailySales) Then
            Dim weeklySales As Decimal = dailySales * 7
            Dim weeklySalary As Decimal = weeklyBasePay

            If weeklySales > quota Then
                Dim commission As Decimal = commissionRate * weeklySales
                weeklySalary += commission
            End If

            ResultListBox.Items.Add($"Salesperson: {salespersonName}")
            ResultListBox.Items.Add($"Daily Sales: {dailySales:C}")
            ResultListBox.Items.Add($"Weekly Sales: {weeklySales:C}")
            ResultListBox.Items.Add($"Weekly Salary: {weeklySalary:C}")
            ResultListBox.Items.Add("----------------------------")
        Else
            MessageBox.Show("Invalid input for daily sales. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Clear input fields after calculation
        NameTextBox.Clear()
        SalesTextBox.Clear()
    End Sub
End Class
