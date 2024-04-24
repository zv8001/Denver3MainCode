Public Class SubToZeRoTeCh00
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("https://www.youtube.com/@ZeRoTeCh00/videos?sub_confirmation=1")
        Catch ex As Exception

        End Try
    End Sub
End Class