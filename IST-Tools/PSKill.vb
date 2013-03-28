Public Class frmPSKill
    Public strCMDPath As String = "C:\Windows\System32\cmd.exe"

    Public Sub tempCheck()
        If Not My.Computer.FileSystem.DirectoryExists("C:\temp") Then
            My.Computer.FileSystem.CreateDirectory("C:\temp")
        End If
    End Sub

    Private Sub frmPSKill_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmbProcessList.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnListProcesses_Click(sender As System.Object, e As System.EventArgs) Handles btnListProcesses.Click
        'Set path for pslist
        Dim strPSListPath As String = " /k " & Chr(34) & Chr(34) & "C:\Program Files (x86)\IST-Tools\PSTools\pslist.exe" & Chr(34)
        'Concatenate agurments
        Dim strArgs As String = strPSListPath & " \\" & _
            frmISTTools.txtIPAddress.Text & " > " & Chr(34) & "C:\temp\pslist.txt" & Chr(34) & Chr(34)
        Dim strResults As String

        Dim procPSList As New ProcessStartInfo
        With procPSList
            .WorkingDirectory = "C:\Program Files (x86)\IST-Tools\PSTools"
            .FileName = "pslist.exe"
            .Arguments = "\\" & frmISTTools.txtIPAddress.Text & " > " & Chr(34) & "C:\temp\pslist.txt" & Chr(34)
        End With

        Try
            If My.Computer.FileSystem.FileExists("C:\temp\pslist.txt") Then
                My.Computer.FileSystem.DeleteFile("C:\temp\pslist.txt")
            End If

            'Check to see if C:\temp exists. If not, creat it.
            tempCheck()
            Process.Start(strCMDPath, strArgs)
            'Process.Start(procPSList)

            Threading.Thread.Sleep(5000)
            'Read text from pslist.txt and assign it to strResulsts
            strResults = My.Computer.FileSystem.ReadAllText("C:\temp\pslist.txt")
            frmResults.txtResults.Text = strResults

            'Delete pslist.txt
            If My.Computer.FileSystem.FileExists("C:\temp\pslist.txt") Then
                My.Computer.FileSystem.DeleteFile("C:\temp\pslist.txt")
            End If

            frmResults.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnKillProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnKillProcess.Click
        'Set path for psKill
        Dim strPSKillPath As String = " /k " & Chr(34) & "C:\Program Files (x86)\IST-Tools\PSTools\pskill.exe" & Chr(34)
        Dim intProcessSelect As Integer = cmbProcessList.SelectedIndex
        Dim strArgs As String

        Select Case intProcessSelect
            Case 0
                strArgs = strPSKillPath & " -t " & " \\" & frmISTTools.txtIPAddress.Text & " " & txtProcess.Text
                If txtProcess.Text = "" Then
                    MessageBox.Show("You did not enter a process name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                Try
                    Process.Start(strCMDPath, strArgs)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                    End Try
                End If
            Case 1
                strArgs = strPSKillPath & " -t" & " \\" & frmISTTools.txtIPAddress.Text & " iexplore"
                Try
                    Process.Start(strCMDPath, strArgs)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            Case 2
                strArgs = strPSKillPath & " -t" & " \\" & frmISTTools.txtIPAddress.Text & " firefox"
                Try
                    Process.Start(strCMDPath, strArgs)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            Case 3
                strArgs = strPSKillPath & " -t" & " \\" & frmISTTools.txtIPAddress.Text & " chrome"
                Try
                    Process.Start(strCMDPath, strArgs)
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            Case Else
                MessageBox.Show("You did not choose or enter a process!", "Error", MessageBoxButtons.OK, _
                                MessageBoxIcon.Warning)
        End Select
    End Sub
End Class