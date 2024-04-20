Public Class GoPlayHL2
    Private Sub GoPlayHL2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserFoler = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim InstallPath = UserFoler & "\Denver3"
        Try
            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/CPViolation.wav", InstallPath & "\HLMUSIC2.WAV")
        Catch ex As Exception

        End Try

        My.Computer.Audio.Play(InstallPath & "\HLMUSIC2.WAV", AudioPlayMode.BackgroundLoop)
    End Sub
End Class