﻿Public Class Form1
    Dim UserFoler = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Dim InstallPath = UserFoler & "\Denver3"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Process.Start(InstallPath & "\Denver3.exe")
        Catch ex As Exception
            MsgBox("error current Target not found", 0 + 16, "DEN_V3")
        End Try

        Try
            Process.Start(Application.ExecutablePath & ".Denver3.exe")
        Catch ex As Exception
            MsgBox("The program seems to be corrupted", 0 + 16, Application.ExecutablePath)
        End Try
        Me.Close()
    End Sub
End Class