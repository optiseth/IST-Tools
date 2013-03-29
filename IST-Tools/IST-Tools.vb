Public Class frmISTTools
    Private Sub btnPSToolsClose_Click(sender As System.Object, e As System.EventArgs) Handles btnPSToolsClose.Click
        Me.Close()
    End Sub

    Private Sub btnNetworkClose_Click(sender As System.Object, e As System.EventArgs) Handles btnNetworkClose.Click
        Me.Close()
    End Sub

    Private Sub btnEditHostsFile_Click(sender As System.Object, e As System.EventArgs) Handles btnEditHostsFile.Click
        'Set process info
        Dim procEditHosts As New ProcessStartInfo
        With procEditHosts
            .WorkingDirectory = "C:\Windows\System32"
            .FileName = "notepad.exe"
            .Arguments = "\\" & txtIPAddress.Text & "\c$\Windows\System32\drivers\etc\hosts"
        End With

        'Attempt to open remote hosts file using notepad
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or hostname!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                Process.Start(procEditHosts)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnNavigateToRoot_Click(sender As System.Object, e As System.EventArgs) Handles btnNavigateToRoot.Click
        'Set paths
        Dim strRootPath As String = "\\" & txtIPAddress.Text & "\c$"

        'Attempt to open root of C: on remote PC
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter and IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                Process.Start(strRootPath)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLoggedOnUser_Click(sender As System.Object, e As System.EventArgs) Handles btnLoggedOnUser.Click
        'Set paths
        Dim strCMDPath As String = "C:\Windows\system32\cmd.exe"
        Dim strPSLoggedOnPath As String = " /k " & Chr(34) & "C:\Program Files (x86)\IST-Tools\PSTools\psloggedon.exe" & Chr(34)
        Dim strRemotePC As String = " \\" & txtIPAddress.Text & " > C:\temp\psloggedon.txt"
        Dim strArgs As String = strPSLoggedOnPath & strRemotePC
        Dim procLoggedOnUser As New ProcessStartInfo
        Dim procResults As Process
        Dim strResults As String
        Dim isNotFinished As Boolean = True

        With procLoggedOnUser
            .WorkingDirectory = "C:\Windows\System32"
            .FileName = "cmd.exe"
            .Arguments = strArgs
            .WindowStyle = ProcessWindowStyle.Hidden
        End With
        'Attempt to launch cmd.exe to run psloggedon against remote PC
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter and IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                'Check to see if C:\temp exists. If not, create it.
                If tempCheck() = False Then
                    My.Computer.FileSystem.CreateDirectory("C:\temp")
                End If

                'Check to see if psloggedon.txt exists and delete
                If My.Computer.FileSystem.FileExists("C:\temp\psloggedon.txt") Then
                    My.Computer.FileSystem.DeleteFile("C:\temp\psloggedon.txt")
                End If

                procResults = Process.Start(procLoggedOnUser)

                'Check to see if process is still running
                While isNotFinished = True
                    Threading.Thread.Sleep(1000)
                    If isProcessRunning("psloggedon") = True Then
                        isNotFinished = True
                    Else
                        isNotFinished = False
                    End If
                End While

                'Check to see if psloggedon.txt is still in use
                While FileInUse("psloggedon.txt") = True
                    Threading.Thread.Sleep(1000)
                End While

                'If text file exists, load it into results form and show
                If My.Computer.FileSystem.FileExists("C:\temp\psloggedon.txt") Then
                    strResults = My.Computer.FileSystem.ReadAllText("C:\temp\psloggedon.txt")
                    frmResults.txtResults.Text = strResults
                    frmResults.Show()
                    procResults.Dispose()
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            'Delete psloggedon.txt
            If My.Computer.FileSystem.FileExists("C:\temp\psloggedon.txt") Then
                My.Computer.FileSystem.DeleteFile("C:\temp\psloggedon.txt")
            End If
        End If
    End Sub

    Private Sub btnContinuousPing_Click(sender As System.Object, e As System.EventArgs) Handles btnContinuousPing.Click
        'Set process info
        Dim procPing As New ProcessStartInfo
        With procPing
            .WorkingDirectory = "C:\Windows\System32"
            .FileName = "ping.exe"
            .Arguments = "-t " & txtIPAddress.Text
        End With

        'Continuous ping on the remote PC
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                Process.Start(procPing)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLaunchVNCViewer_Click(sender As System.Object, e As System.EventArgs) Handles btnLaunchVNCViewer.Click
        'Set process info for VNC4
        Dim procVNC4 As New ProcessStartInfo
        With procVNC4
            .WorkingDirectory = "C:\Program Files\RealVNC\VNC4"
            .FileName = "vncviewer.exe"
            .Arguments = txtIPAddress.Text
        End With

        'Set process info for VNC5
        Dim procVNC5 As New ProcessStartInfo
        With procVNC5
            .WorkingDirectory = "C:\Program Files\RealVNC\VNC Viewer"
            .FileName = "vncviewer.exe"
            .Arguments = txtIPAddress.Text
        End With

        If My.Computer.FileSystem.DirectoryExists("C:\Program Files\RealVNC\VNC Viewer") Then
            If txtIPAddress.Text = "" Then
                MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                                MessageBoxIcon.Warning)
            Else
                Try
                    Process.Start(procVNC5)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            End If
        Else
            If txtIPAddress.Text = "" Then
                MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                                MessageBoxIcon.Warning)
            Else
                Try
                    Process.Start(procVNC4)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnForcedRemoteRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnForcedRemoteRestart.Click
        'Force a restart on remote PC. User is givin a warning that the PC will restart in less than 1 minute.
        Dim procForcedRestart As New ProcessStartInfo
        With procForcedRestart
            .WorkingDirectory = "C:\Program Files (x86)\IST-Tools\PSTools"
            .FileName = "psshutdown.exe"
            .Arguments = "\\" & txtIPAddress.Text & " /r /t 15 /f"
            .WindowStyle = ProcessWindowStyle.Hidden
        End With

        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                Process.Start(procForcedRestart)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRestartRemoteService_Click(sender As System.Object, e As System.EventArgs) Handles btnRestartRemoteService.Click
        'Open remote service form
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            frmRemoteService.Show()
        End If
    End Sub

    Private Sub btnRemoteInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoteInfo.Click
        'Set arguments string
        Dim strArgs As String = " /k " & Chr(34) & "C:\Program Files (x86)\IST-Tools\PSTools\psinfo.exe" & Chr(34) & _
                                " /s " & "\\" & txtIPAddress.Text & " > C:\temp\psinfo.txt"
        Dim strResults As String
        Dim procResults As New Process
        Dim isNotFinished As Boolean = True

        Dim procRemoteInfo As New ProcessStartInfo
        With procRemoteInfo
            .WorkingDirectory = "C:\Windows\System32"
            .FileName = "cmd.exe"
            .Arguments = strArgs
            .WindowStyle = ProcessWindowStyle.Hidden
        End With

        'Run psinfo against remote PC to display PC info and installed software
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            'Delete psinfo.txt if it already exists
            If My.Computer.FileSystem.FileExists("C:\temp\psinfo.txt") Then
                My.Computer.FileSystem.DeleteFile("C:\temp\psinfo.txt")
            End If
            Try
                'Start process
                procResults = Process.Start(procRemoteInfo)

                'Check to see if process is still running
                While isNotFinished = True
                    btnRemoteInfo.Text = "This takes approx. 15 seconds..."
                    btnRemoteInfo.Refresh()
                    Threading.Thread.Sleep(1000)
                    If isProcessRunning("PsInfo") = True Then
                        isNotFinished = True
                    Else
                        isNotFinished = False
                    End If
                End While
                btnRemoteInfo.Text = "Display Remote PC Info"
                btnRemoteInfo.Refresh()

                'Load info into new window
                If My.Computer.FileSystem.FileExists("C:\temp\psinfo.txt") Then
                    strResults = My.Computer.FileSystem.ReadAllText("C:\temp\psinfo.txt")
                    frmResults.txtResults.Text = strResults
                    frmResults.Show()
                    procResults.Dispose()
                    My.Computer.FileSystem.DeleteFile("C:\temp\psinfo.txt")
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click
        AboutBox.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnAboutClose.Click
        Me.Close()
    End Sub

    Private Sub btnRemotePush_Click(sender As System.Object, e As System.EventArgs) Handles btnRemotePush.Click
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            frmRemotePush.Show()
        End If
    End Sub

    Private Sub btnPSExec_Click(sender As System.Object, e As System.EventArgs) Handles btnPSExec.Click
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            frmPSExec.Show()
        End If
    End Sub

    Private Sub btnPSKillProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnPSKillProcess.Click
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            frmPSKill.Show()
        End If
    End Sub
End Class
