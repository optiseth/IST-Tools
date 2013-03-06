Public Class frmRemoteService

    Private Sub btnExecute_Click(sender As System.Object, e As System.EventArgs) Handles btnExecute.Click
        Dim strIPAddress As String = frmISTTools.txtIPAddress.Text
        Dim strPSServicePath As String = "C:\Program Files (x86)\IST-Tools\PSTools\psservice.exe"
        Dim intService As Integer = cmbServices.SelectedIndex

        'Set variables for VNC Services
        Dim strVNCArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "WinVNC4" & Chr(34)
        Dim strVNCArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "WinVNC4" & Chr(34)

        'Set variables for RemoteRegistry Service
        Dim strRRArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "RemoteRegistry" & Chr(34)
        Dim strRRArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "RemoteRegistry" & Chr(34)

        'Set variables for Windows Firewall service
        Dim strWFArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "MpsSvc" & Chr(34)
        Dim strWFArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "MpsSvc" & Chr(34)

        'Set variables for Print Spooler
        Dim strPSArgsStart As String = "\\" & strIPAddress & " start " & Chr(34) & "Spooler" & Chr(34)
        Dim strPSArgsStop As String = "\\" & strIPAddress & " stop " & Chr(34) & "Spooler" & Chr(34)


        Select Case intService
            Case 0
                If rdbStart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strVNCArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbStop.Checked Then
                    Try
                        Process.Start(strPSServicePath, strVNCArgsStop)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                ElseIf rdbRestart.Checked Then
                    Try
                        Process.Start(strPSServicePath, strVNCArgsStop)
                        'Pause for service to stop
                        System.Threading.Thread.Sleep(5000)
                        Process.Start(strPSServicePath, strVNCArgsStart)
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Please select ""Start"", ""Stop"", or ""Restart""", "Error", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Warning)
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
                Else
                    MessageBox.Show("Please select ""Start"", ""Stop"", or ""Restart""", "Error", MessageBoxButtons.OK, _
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
                Else
                    MessageBox.Show("Please select ""Start"", ""Stop"", or ""Restart""", "Error", MessageBoxButtons.OK, _
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
            Case Else
                MessageBox.Show("No service specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub


    Private Sub frmRemoteService_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmbServices.SelectedIndex = 0
    End Sub
End Class