Public Class frmRemotePush
    Public strFileName As String
    Public strSafeFileName As String

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnSelectFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectFile.Click
        'Set the OpenDialog properties
        With OpenFileDialog1
            .Filter = "All Files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "File to Push"
        End With

        'Show the open file dialog and if the user clicks ok then try to push the file to the remote pc
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the path
                strFileName = OpenFileDialog1.FileName
                strSafeFileName = OpenFileDialog1.SafeFileName
                lblPath.Text = strFileName
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPushFile_Click(sender As System.Object, e As System.EventArgs) Handles btnPushFile.Click
        'Set path for remote PC
        Dim strArgs As String = "\\" & frmISTTools.txtIPAddress.Text & "\c$\temp\" & strSafeFileName
        Dim strDirectoryExistsArgs As String = "\\" & frmISTTools.txtIPAddress.Text & "\c$\temp"
        Dim strCreateDirectory As String = "\\" & frmISTTools.txtIPAddress.Text & "\c$\temp"

        'Check to see if c$\temp exists, if not create it
        If My.Computer.FileSystem.DirectoryExists(strDirectoryExistsArgs) Then
            Try
                My.Computer.FileSystem.CopyFile(strFileName, strArgs, FileIO.UIOption.AllDialogs)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Else
            My.Computer.FileSystem.CreateDirectory(strCreateDirectory)
            Try
                My.Computer.FileSystem.CopyFile(strFileName, strArgs, FileIO.UIOption.AllDialogs)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub
End Class