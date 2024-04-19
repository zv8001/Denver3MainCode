Public Class still_using_this_computer
    Private Sub still_using_this_computer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim random As New Random()
            Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
            Dim randomX As Integer = random.Next(0, screenWidth - Me.Width)
            Dim randomY As Integer = random.Next(0, screenHeight - Me.Height)

            ' Set form's location to the random coordinates
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(randomX, randomY)
        Catch ex As Exception

        End Try

    End Sub
End Class