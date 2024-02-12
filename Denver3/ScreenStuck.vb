Public Class ScreenStuck
    Private Sub ScreenStuck_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub

    Private Sub ScreenStuck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "https://denver3289yf998dh287hd9hd9827h.netlify.app/karo.mp3"

    End Sub
End Class