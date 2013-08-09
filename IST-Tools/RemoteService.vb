Public Class frmRemoteService

    Private Sub btnExecute_Click(sender As System.Object, e As System.EventArgs) Handles btnExecute.Click
        Dim strIPAddress As String = frmISTTools.txtIPAddress.Text
        Dim strPSServicePath As String = "C:\Program Files (x86)\IST-Tools\PSTools\psservice.exe"
        Dim strCMDPath As String = "C:\Windows\System32\cmd.exe"
        Dim intService As Integer = cmbServices.SelectedIndex

        'Set variables for custom service
        Dim strCustomService = txtCustomProcess.Text
        Dim strCustomArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & strCustomService & Chr(34)
        Dim strCustomArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & strCustomService & Chr(34)

        'Set variables for VNC4 Services
        Dim strVNC4ArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "WinVNC4" & Chr(34)
        Dim strVNC4ArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "WinVNC4" & Chr(34)

        'Set variables for VNC5 services
        Dim strVNC5ArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "vncserver" & Chr(34)
        Dim strVNC5ArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "vncserver" & Chr(34)

        'Set variables for RemoteRegistry Service
        Dim strRRArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "RemoteRegistry" & Chr(34)
        Dim strRRArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "RemoteRegistry" & Chr(34)

        'Set variables for Windows Firewall service
        Dim strWFArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "MpsSvc" & Chr(34)
        Dim strWFArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "MpsSvc" & Chr(34)

        'Set variables for Print Spooler
        Dim strPSArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "Spooler" & Chr(34)
        Dim strPSArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "Spooler" & Chr(34)

        'Set variables for enabling/disabling VNC4 on start up in services.msc
        Dim strEnableVNC4 As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config winvnc4 start= auto" & Chr(34)
        Dim strDisableVNC4 As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config winvnc4 start= disabled" & Chr(34)

        'Set variables for enabling/disabling VNC5 on start up in services.msc
        Dim strEnableVNC5 As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config vncserver start= auto" & Chr(34)
        Dim strDisableVNC5 As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config vncserver start= disabled" & Chr(34)

        'Set variables for enabling/disabling Custom service on start up in services.msc
        Dim strCustomEnable As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config " & strCustomService & " start= auto" & Chr(34)
        Dim strCustomDisable As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config " & strCustomService & " start= disabled" & Chr(34)

        'Set variables for enabling/disabling RemoteRegistry service on start up in services.msc
        Dim strEnableRR As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config RemoteRegistry start= auto" & Chr(34)
        Dim strDisableRR As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config RemoteRegistry start= disabled" & Chr(34)

        'Set variables for enabling/disabling  WindowsFirewall service on start up in services.msc
        Dim strEnableWF As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config MpsSvc start= auto" & Chr(34)
        Dim strDisableWF As String = " /k " & Chr(34) & "sc \\" & strIPAddress & " config MpsSvc start= disabled" & Chr(34)


        Select Case intService
            Case 0
                If My.Computer.FileSystem.FileExists("\\" & strIPAddress & _
                                                     "\c$\Program Files\RealVNC\VNC Server\vncserver.exe") Then
                    If rdbStart.Checked Then
                        Try
                            Process.Start(strPSServicePath, strVNC5ArgsStart)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbStop.Checked Then
                        Try
                            Process.Start(strPSServicePath, strVNC5ArgsStop)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbRestart.Checked Then
                        Try
                            Process.Start(strPSServicePath, strVNC5ArgsStop)
                            'Pause for 5 seconds
                            System.Threading.Thread.Sleep(5000)
                            Process.Start(strPSServicePath, strVNC5ArgsStart)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbEnableService.Checked Then
                        Try
                            Process.Start(strCMDPath, strEnableVNC5)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbDisableService.Checked Then
                        Try
                            Process.Start(strCMDPath, strDisableVNC5)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    End If
                Else
                    If rdbStart.Checked Then
                        Try
                            Process.Start(strPSServicePath, strVNC4ArgsStart)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbStop.Checked Then
                        Try
                            Process.Start(strPSServicePath, strVNC4ArgsStop)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbRestart.Checked Then
                        Try
                            Process.Start(strPSServicePath, strVNC4ArgsStop)
                            'Pause for service to stop
                            System.Threading.Thread.Sleep(5000)
                            Process.Start(strPSServicePath, strVNC4ArgsStart)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbEnableService.Checked Then
                        Try
                            Process.Start(strCMDPath, strEnableVNC4)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    ElseIf rdbEnableService.Checked Then
                        Try
                            Process.Start(strCMDPath, strDisableVNC4)
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    Else
                        MessageBox.Show("Please select ""Start"", ""Stop"", ""Restart"", ""Enable"", or ""Disable""", "Error", MessageBoxButtons.OK, _
                                        MessageBoxIcon.Warning)
                    End If
                End If
            Case 1
                If rdbStart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strRRArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbStop.Checked Then
                    Try
                        Process.Start(strPSServicePath, strRRArgsStop)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbRestart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strRRArgsStop)
                        'Pause for service stop
                        System.Threading.Thread.Sleep(5000)
                        Process.Start(strPSServicePath, strRRArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbEnableService.Checked Then
                    Try
                        Process.Start(strCMDPath, strEnableRR)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbDisableService.Checked Then
                    Try
                        Process.Start(strCMDPath, strDisableRR)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Please select ""Start"", ""Stop"", ""Restart"", ""Enable"", or ""Disable""", "Error", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Warning)
                End If
            Case 2
                If rdbStart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strWFArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbStop.Checked Then
                    Try
                        Process.Start(strPSServicePath, strWFArgsStop)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbRestart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strWFArgsStop)
                        'Pause for service stop
                        System.Threading.Thread.Sleep(5000)
                        Process.Start(strPSServicePath, strWFArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbEnableService.Checked Then
                    Try
                        Process.Start(strCMDPath, strEnableWF)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbDisableService.Checked Then
                    Try
                        Process.Start(strCMDPath, strDisableWF)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Please select ""Start"", ""Stop"", ""Restart"", ""Enable"", or ""Disable""", "Error", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Warning)
                End If
            Case 3
                If rdbStart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strPSArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbStop.Checked Then
                    Try
                        Process.Start(strPSServicePath, strPSArgsStop)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbRestart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strPSArgsStop)
                        'Pause for service stop
                        System.Threading.Thread.Sleep(5000)
                        Process.Start(strPSServicePath, strPSArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Please select ""Start"", ""Stop"", or ""Restart""", "Error", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Warning)
                End If
            Case 4
                If rdbStart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strCustomArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbStop.Checked Then
                    Try
                        Process.Start(strPSServicePath, strCustomArgsStop)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbRestart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strCustomArgsStop)
                        'Pause
                        System.Threading.Thread.Sleep(5000)
                        Process.Start(strPSServicePath, strCustomArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbEnableService.Checked Then
                    Try
                        Process.Start(strCMDPath, strCustomEnable)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbDisableService.Checked Then
                    Try
                        Process.Start(strCMDPath, strCustomDisable)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                End If
            Case Else
                MessageBox.Show("No service specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub
    Private Sub frmRemoteService_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmbServices.SelectedIndex = 0
    End Sub

    Private Sub cmbServices_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbServices.SelectedIndexChanged
        If cmbServices.SelectedIndex = 4 Then
            txtCustomProcess.Enabled = True
        Else
            txtCustomProcess.Enabled = False
        End If
    End Sub
End Class