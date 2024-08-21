Public Class DemoForm
    Private Sub DemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeDemoForm()
    End Sub

    Public Sub ResizeDemoForm()
        Dim screenWidth As Integer
        Dim screenHeight As Integer
        Dim formHeight As Integer
        Dim formWidth As Integer

        ' Get the dimensions of the screen
        screenWidth = Screen.PrimaryScreen.Bounds.Width
        screenHeight = Screen.PrimaryScreen.Bounds.Height

        ' Calculate half of the screen height and three-quarters of the screen width
        formHeight = screenHeight * 0.5
        formWidth = screenWidth * 0.75

        ' Set the size of DemoForm
        Me.Width = formWidth
        Me.Height = formHeight
    End Sub

End Class
