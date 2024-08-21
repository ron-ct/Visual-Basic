Public Class Object_Demonstrations


    Private Sub cbitalic_CheckedChanged(sender As Object, e As EventArgs) Handles cbitalic.CheckedChanged
        If cbitalic.Checked Then
            textbox1.Font = New Font(cbitalic.Font, cbitalic.Font.Style Or FontStyle.Italic)
        Else
            textbox1.Font = New Font(cbitalic.Font, cbitalic.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub cbbold_CheckedChanged(sender As Object, e As EventArgs) Handles cbbold.CheckedChanged
        If cbbold.Checked Then
            textbox1.Font = New Font(cbbold.Font, cbbold.Font.Style Or FontStyle.Bold)
        Else
            textbox1.Font = New Font(cbbold.Font, cbbold.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub cbitalicbold_CheckedChanged(sender As Object, e As EventArgs) Handles cbitalicbold.CheckedChanged
        UpdateFontStyle()

    End Sub
    Private Sub UpdateFontStyle()
        Dim fontStyle As FontStyle = FontStyle.Regular

        ' Check if italic and bold checkbox is checked
        If cbitalicbold.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic Or FontStyle.Bold
        End If

        ' Apply the combined font style to the textbox
        textbox1.Font = New Font(textbox1.Font, fontStyle)
    End Sub

    Private Sub btngreen_CheckedChanged(sender As Object, e As EventArgs) Handles btngreen.CheckedChanged
        If btngreen.Checked Then
            textbox1.ForeColor = Color.Green
        Else
            ' Set the font color back to default when unchecked
            textbox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub btnblue_CheckedChanged(sender As Object, e As EventArgs) Handles btnblue.CheckedChanged
        If btnblue.Checked Then
            textbox1.ForeColor = Color.Blue
        Else
            ' Set the font color back to default when unchecked
            textbox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub btnred_CheckedChanged(sender As Object, e As EventArgs) Handles btnred.CheckedChanged
        If btnred.Checked Then
            textbox1.ForeColor = Color.Red
        Else
            ' Set the font color back to default when unchecked
            textbox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub btntahoma_CheckedChanged(sender As Object, e As EventArgs) Handles btntahoma.CheckedChanged
        If btntahoma.Checked Then
            textbox1.Font = New Font("Tahoma", textbox1.Font.Size, textbox1.Font.Style)
        Else
            ' Set the font back to default when unchecked
            textbox1.Font = New Font(DefaultFont.FontFamily, textbox1.Font.Size, textbox1.Font.Style)
        End If
    End Sub

    Private Sub btnmagneto_CheckedChanged(sender As Object, e As EventArgs) Handles btnmagneto.CheckedChanged
        If btnmagneto.Checked Then
            textbox1.Font = New Font("Magneto", textbox1.Font.Size, textbox1.Font.Style)
        Else
            ' Set the font back to default when unchecked
            textbox1.Font = New Font(DefaultFont.FontFamily, textbox1.Font.Size, textbox1.Font.Style)
        End If
    End Sub

    Private Sub btngaramond_CheckedChanged(sender As Object, e As EventArgs) Handles btngaramond.CheckedChanged
        If btngaramond.Checked Then
            textbox1.Font = New Font("Garamond", textbox1.Font.Size, textbox1.Font.Style)
        Else
            ' Set the font back to default when unchecked
            textbox1.Font = New Font(DefaultFont.FontFamily, textbox1.Font.Size, textbox1.Font.Style)
        End If
    End Sub

    Private Sub btnloadpicture_Click(sender As Object, e As EventArgs) Handles btnloadpicture.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to only allow image files
        openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"

        ' Set the initial directory (optional)
        openFileDialog.InitialDirectory = "C:\"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim imagePath As String = openFileDialog.FileName

            ' Display the image in PictureBox1
            picturebox1.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnexitobject.Click
        Me.Close()
    End Sub
End Class