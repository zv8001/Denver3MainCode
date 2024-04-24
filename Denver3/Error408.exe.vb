Public Class Error408
    Dim ServerAddr = "https://denver3289yf998dh287hd9hd9827h.netlify.app/"
    Private Sub Error408_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Video by 4906 on youtube.", 0 + 64, "VIDEO INFO")
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        AxWindowsMediaPlayer1.URL = ServerAddr & "error.mp4"


    End Sub
End Class