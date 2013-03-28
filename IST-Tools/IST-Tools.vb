Public Class frmISTTools
    Implements System.IDisposable
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
        Dim strRemotePC As String = " \\" & txtIPAddress.Text
        Dim strArgs As String = strPSLoggedOnPath & strRemotePC

        'Attempt to launch cmd.exe to run psloggedon against remote PC
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter and IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                Process.Start(strCMDPath, strArgs)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnContinuousPing_Click(sender As System.Object, e As System.EventArgs) Handles btnContinuousPing.Click
        'Set process info
        Dim CMDProc As New ProcessStartInfo
        With CMDProc
            .WorkingDirectory = "C:\Windows\System32"
            .FileName = "ping.exe"
            .UseShellExecute = True
            .Arguments = "-t " & txtIPAddress.Text
        End With

        'Continuous ping on the remote PC
        If txtIPAddress.Text = "" Then
            MessageBox.Show("Please enter an IP address or host name!", "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Warning)
        Else
            Try
                Process.Start(CMDProc)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLaunchVNCViewer_Click(sender As System.Object, e As System.EventArgs) Handles btnLaunchVNCViewer.Click
        'Set process info for VNC4
        Dim procVNC4 As ProcessStartInfo
        procVNC4 = New ProcessStartInfo
        With procVNC4
            .WorkingDirectory = "C:\Program Files\RealVNC\VNC4"
            .FileName = "vncviewer.exe"
            .Arguments = txtIPAddress.Text
        End With

        'Set process info for VNC5
        Dim procVNC5 As ProcessStartInfo
        procVNC5 = New ProcessStartInfo
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
        'Dim strPSShutdownPath As String = "C:\Program Files (x86)\IST-Tools\PSTools\psshutdown.exe"
        'Dim strArgs As String = "\\" & txtIPAddress.Text & " /r /t 15 /f"

        Dim procForcedRestart As New ProcessStartInfo
        With procForcedRestart
            .WorkingDirectory = "C:\Program Files (x86)\IST-Tools\PSTools"
            .FileName = "psshutdown.exe"
            .Arguments = "\\" & txtIPAddress.Text & " /r /t 15 /f"
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
        'Set Paths
        Dim strCMDPath As String = "C:\Windows\System32\cmd.exe"
        Dim strPSInfoPath As String = " /k " & Chr(34) & "C:\Program Files (x86)\IST-Tools\PSTools\psinfo.exe" & Chr(34)
        Dim strRemotePC As String = " /s " & "\\" & txtIPAddress.Text & " > " & "C:\temp\psinfo.txt"
        Dim strArgs As String = strPSInfoPath & strRemotePC
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
                    btnRemoteInfo.Text = "This takes a few seconds..."
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
                    strResults = My.Computer.FileSystem.ReadAllText("C:\temp\psinfo.txt")
                    frmResults.txtResults.Text = strResults
                    frmResults.Show()
                    procResults.Close()
                    If My.Computer.FileSystem.FileExists("C:\temp\psinfo.txt") Then
                        My.Computer.FileSystem.DeleteFile("C:\temp\psinfo.txt")

                    End If
            Catch ex As Exception
                procResults.Kill()
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub
    Public Function isProcessRunning(name As String) As Boolean
        'Get a list of running processes
        For Each clsProcess As Process In Process.GetProcesses
            If clsProcess.ProcessName.StartsWith(name) Then
                'Process is still running
                Return True
            End If
        Next
        'Process is done
        Return False
    End Function
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
