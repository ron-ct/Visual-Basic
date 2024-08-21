


Public Class Form1



    Private Sub btnloaddemo_Click(sender As Object, e As EventArgs) Handles btnloaddemo.Click
        Object_Demonstrations.Show()

    End Sub

    Private Sub frmMain_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub btnloaddemo_MouseHover(sender As Object, e As EventArgs) Handles btnloaddemo.MouseHover

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class
