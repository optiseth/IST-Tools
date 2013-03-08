Public Class frmPSExec
    Public strFileName As String
    Public strSafeFileName As String
    Public strIPListName As String
    Public strSafeIPListName As String

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSelectFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectFile.Click
        With OpenFileDialog1
            .Filter = "MSI Files (*.msi)|*.msi|Exe Files (*.exe)|*.exe|Batch Files (*.bat)|*.bat|Reg Files (*.reg)|*.reg|All Files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "File to Execute"
        End With

        'Show the open file dialog and if the user clicks ok then save the path and file name of the selected file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the path
                strFileName = OpenFileDialog1.FileName
                strSafeFileName = OpenFileDialog1.SafeFileName
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnIPList_Click(sender As System.Object, e As System.EventArgs) Handles btnIPList.Click
        Dim strFileContents As String
        With OpenFileDialog2
            .Filter = "Text Files (*.txt)|*.txt"
            .FilterIndex = 1
            .Title = "IP List"
        End With

        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save IP file path
                strIPListName = OpenFileDialog2.FileName
                strSafeIPListName = OpenFileDialog2.SafeFileName
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            'Load the text file contents into the strFileContents string variable
            strFileContents = My.Computer.FileSystem.ReadAllText(strIPListName)

            'Load text file contents into the text box
            'This currently only loads the file for viewing, not for editing
            'I plan on implementing the editing portion later
            txtIPList.Text = strFileContents
        End If
    End Sub

    Private Sub btnExecutePSExec_Click(sender As System.Object, e As System.EventArgs) Handles btnExecutePSExec.Click
        'Set path for PSExec
        Dim strCMDPath As String = "C:\Windows\system32\cmd.exe"
        Dim strPSExec As String = " /k " & Chr(34) & Chr(34) & "C:\Program Files (x86)\IST-Tools\PSTools\psexec.exe" & Chr(34)
        Dim strArgs As String = " \\" & frmISTTools.txtIPAddress.Text & " -s msiexec.exe /i " & _
            Chr(34) & strFileName & Chr(34) & " /q" & Chr(34)
        Dim strSingleArgs As String = strPSExec & strArgs
        Dim strMultiArgs As String = " @" & strIPListName & " -s msiexec.exe /i " & Chr(34) & strFileName & Chr(34) & " /q"

        If rdbSinglePC.Checked And strFileName <> "" Then
            Try
                'MessageBox.Show(strCMDPath & strSingleArgs, "Test")
                Process.Start(strCMDPath, strSingleArgs)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        ElseIf rdbMultiplePCs.Checked And strIPListName <> "" Then
            Try
                Process.Start(strPSExec, strMultiArgs)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Else
            MessageBox.Show("You did not choose single/multiple PCs or you didn't choose a file!", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub rdbSinglePC_Click(sender As Object, e As System.EventArgs) Handles rdbSinglePC.Click
        txtIPList.Text = frmISTTools.txtIPAddress.Text
    End Sub
End Class