Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MultiplicationTableForm
    Private Sub MultiplicationTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GenerateMultiplicationTable()

    End Sub


    Public Sub GenerateMultiplicationTable()
        MultiplicationTextBox.Text = String.Empty

        MultiplicationTextBox.Text &= "* 1 2 3 4 5 6 7" & Environment.NewLine

        For i As Integer = 1 To 7
            MultiplicationTextBox.Text &= i.ToString()

            For j As Integer = 1 To 7
                MultiplicationTextBox.Text &= " " & (i * j).ToString()
            Next

            MultiplicationTextBox.Text &= Environment.NewLine
        Next
    End Sub


End Class
