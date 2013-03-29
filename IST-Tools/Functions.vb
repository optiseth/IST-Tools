Module Functions
    Public Function isProcessRunning(name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses
            If clsProcess.ProcessName.StartsWith(name) Then
                'Process is running. Return true.
                Return True
            End If
        Next
        'Process is not running. Return false.
        Return False
    End Function

    Public Function tempCheck() As Boolean
        If My.Computer.FileSystem.DirectoryExists("C:\temp") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FileInUse(ByVal File As String) As Boolean
        Dim thisFileInUse As Boolean = False
        Dim sFile As String = "C:\temp\" & File
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
                    thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function

    Public Sub FileCheck(ByVal name As String)
        If My.Computer.FileSystem.FileExists("C:\temp\" & name) Then
            My.Computer.FileSystem.DeleteFile("C:\temp\" & name)
        End If
    End Sub
End Module
