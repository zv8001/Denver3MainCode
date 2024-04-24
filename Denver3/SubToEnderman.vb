Public Class SubToEnderman
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("https://www.youtube.com/channel/UCWb-66XSFCV5vgKEbl22R6Q?sub_confirmation=1")
        Catch ex As Exception
            MsgBox("failed to open default web browser do you have one set?", 0 + 16, "Denver3 error")
        End Try
    End Sub
End Class