Public Class frmResults

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        For Each clsProcess As Process In Process.GetProcesses
            If clsProcess.ProcessName = "cmd" Then
                clsProcess.Kill()
            End If
        Next
        Me.Close()
    End Sub

    Private Sub frmResults_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Focus()
    End Sub
End Class