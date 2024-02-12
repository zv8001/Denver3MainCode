Public Class GoPlayHLAlyx
    Private Sub GoPlayHLAlyx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserFoler = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Try
            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/TriumphR.wav", UserFoler & "\HLMUSIC.WAV")
        Catch ex As Exception

        End Try

        My.Computer.Audio.Play(UserFoler & "\HLMUSIC.WAV", AudioPlayMode.BackgroundLoop)
    End Sub
End Class