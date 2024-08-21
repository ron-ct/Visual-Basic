Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ObjectDemonstrations

    Private Sub ItalicBoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicBoldCheckBox.CheckedChanged
        UpdateFontStyle()
    End Sub
    Private Sub UpdateFontStyle()
        Dim fontStyle As FontStyle = FontStyle.Regular

        ' Check if italic and bold checkbox is checked 
        If ItalicBoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic Or FontStyle.Bold
        End If

        ' Apply the combined font style to the textbox 
        EnterTextBox.Font = New Font(EnterTextBox.Font, fontStyle)
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged

        If ItalicCheckBox.Checked Then
            EnterTextBox.Font = New Font(ItalicCheckBox.Font, ItalicCheckBox.Font.Style Or
FontStyle.Italic)
        Else
            EnterTextBox.Font = New Font(ItalicCheckBox.Font, ItalicCheckBox.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub BoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldCheckBox.CheckedChanged
        If BoldCheckBox.Checked Then
            EnterTextBox.Font = New Font(BoldCheckBox.Font, BoldCheckBox.Font.Style Or
FontStyle.Bold)
        Else
            EnterTextBox.Font = New Font(BoldCheckBox.Font, BoldCheckBox.Font.Style And Not FontStyle.Bold)
        End If
    End Sub


    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        If GreenRadioButton.Checked Then
            EnterTextBox.ForeColor = Color.Green
        Else
            ' Set the font color back to default when unchecked 
            EnterTextBox.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            EnterTextBox.ForeColor = Color.Blue
        Else
            ' Set the font color back to default when unchecked 
            EnterTextBox.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            EnterTextBox.ForeColor = Color.Red
        Else
            ' Set the font color back to default when unchecked 
            EnterTextBox.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked Then
            EnterTextBox.Font = New Font("Tahoma", EnterTextBox.Font.Size, EnterTextBox.Font.Style)
        Else
            ' Set the font back to default when unchecked 
            EnterTextBox.Font = New Font(DefaultFont.FontFamily, EnterTextBox.Font.Size, EnterTextBox.Font.Style)
        End If
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked Then
            EnterTextBox.Font = New Font("Magneto", MagnetoRadioButton.Font.Size,
EnterTextBox.Font.Style)
        Else
            ' Set the font back to default when unchecked 
            EnterTextBox.Font = New Font(DefaultFont.FontFamily, EnterTextBox.Font.Size,
EnterTextBox.Font.Style)
        End If
    End Sub

    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked Then
            EnterTextBox.Font = New Font("Garamond", EnterTextBox.Font.Size, EnterTextBox.Font.Style)
        Else
            ' Set the font back to default when unchecked 
            EnterTextBox.Font = New Font(DefaultFont.FontFamily, EnterTextBox.Font.Size,
EnterTextBox.Font.Style)
        End If
    End Sub

    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        ' Create an instance of OpenFileDialog 
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to only allow image files 
        openFileDialog.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"

        ' Set the initial directory (optional) 
        openFileDialog.InitialDirectory = "C:\"

        ' Show the dialog and check if the user selected a file 
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path 
            Dim imagePath As String = openFileDialog.FileName

            ' Display the image in PictureBox1 
            LoadPictureBox.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        WelcomeForm.Show()
        Me.Close()
    End Sub

End Class