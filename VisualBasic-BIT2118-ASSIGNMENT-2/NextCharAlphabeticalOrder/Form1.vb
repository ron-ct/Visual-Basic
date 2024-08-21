Public Class Form1
    Private Sub GetNextCharacterButton_Click(sender As Object, e As EventArgs) Handles GetNextCharacterButton.Click
        ' Prompt the user to input a character
        Dim userInput As String = InputBox("Enter a character:", "Input Character")

        ' Check if the user input is not empty
        If Not String.IsNullOrEmpty(userInput) Then
            ' Call the function to get the next character
            Dim nextCharacter As Char = GetNextCharacter(userInput)

            ' Display the result using MessageBox
            MessageBox.Show($"The character following '{userInput}' is '{nextCharacter}'.", "Next Character")
        End If
    End Sub

    Private Function GetNextCharacter(inputChar As Char) As Char
        Dim nextAsciiValue As Integer = Asc(inputChar) + 1

        Dim nextCharacter As Char = Chr(nextAsciiValue)
        Return nextCharacter
    End Function
End Class
