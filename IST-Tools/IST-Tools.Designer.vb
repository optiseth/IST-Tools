<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISTTools
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmISTTools))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpNetwork = New System.Windows.Forms.TabPage()
        Me.btnRemotePush = New System.Windows.Forms.Button()
        Me.btnContinuousPing = New System.Windows.Forms.Button()
        Me.btnNetworkClose = New System.Windows.Forms.Button()
        Me.btnNavigateToRoot = New System.Windows.Forms.Button()
        Me.btnEditHostsFile = New System.Windows.Forms.Button()
        Me.btnLaunchVNCViewer = New System.Windows.Forms.Button()
        Me.tpPSTools = New System.Windows.Forms.TabPage()
        Me.btnRemoteInfo = New System.Windows.Forms.Button()
        Me.btnPSToolsClose = New System.Windows.Forms.Button()
        Me.btnRestartRemoteService = New System.Windows.Forms.Button()
        Me.btnForcedRemoteRestart = New System.Windows.Forms.Button()
        Me.btnLoggedOnUser = New System.Windows.Forms.Button()
        Me.tpAbout = New System.Windows.Forms.TabPage()
        Me.btnAboutClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.btnPSExec = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpNetwork.SuspendLayout()
        Me.tpPSTools.SuspendLayout()
        Me.tpAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpNetwork)
        Me.TabControl1.Controls.Add(Me.tpPSTools)
        Me.TabControl1.Controls.Add(Me.tpAbout)
        Me.TabControl1.Location = New System.Drawing.Point(13, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(293, 256)
        Me.TabControl1.TabIndex = 8
        '
        'tpNetwork
        '
        Me.tpNetwork.BackColor = System.Drawing.SystemColors.Control
        Me.tpNetwork.Controls.Add(Me.btnRemotePush)
        Me.tpNetwork.Controls.Add(Me.btnContinuousPing)
        Me.tpNetwork.Controls.Add(Me.btnNetworkClose)
        Me.tpNetwork.Controls.Add(Me.btnNavigateToRoot)
        Me.tpNetwork.Controls.Add(Me.btnEditHostsFile)
        Me.tpNetwork.Controls.Add(Me.btnLaunchVNCViewer)
        Me.tpNetwork.Location = New System.Drawing.Point(4, 22)
        Me.tpNetwork.Name = "tpNetwork"
        Me.tpNetwork.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNetwork.Size = New System.Drawing.Size(285, 230)
        Me.tpNetwork.TabIndex = 0
        Me.tpNetwork.Text = "Network"
        Me.tpNetwork.ToolTipText = "Contains Windows function to use against remote PC."
        '
        'btnRemotePush
        '
        Me.btnRemotePush.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemotePush.Location = New System.Drawing.Point(7, 127)
        Me.btnRemotePush.Name = "btnRemotePush"
        Me.btnRemotePush.Size = New System.Drawing.Size(272, 23)
        Me.btnRemotePush.TabIndex = 6
        Me.btnRemotePush.Text = "Push File to c$\temp"
        Me.btnRemotePush.UseVisualStyleBackColor = True
        '
        'btnContinuousPing
        '
        Me.btnContinuousPing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContinuousPing.Location = New System.Drawing.Point(7, 97)
        Me.btnContinuousPing.Name = "btnContinuousPing"
        Me.btnContinuousPing.Size = New System.Drawing.Size(272, 23)
        Me.btnContinuousPing.TabIndex = 5
        Me.btnContinuousPing.Text = "Continuous Ping"
        Me.btnContinuousPing.UseVisualStyleBackColor = True
        '
        'btnNetworkClose
        '
        Me.btnNetworkClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNetworkClose.Location = New System.Drawing.Point(109, 201)
        Me.btnNetworkClose.Name = "btnNetworkClose"
        Me.btnNetworkClose.Size = New System.Drawing.Size(75, 23)
        Me.btnNetworkClose.TabIndex = 4
        Me.btnNetworkClose.Text = "Close"
        Me.btnNetworkClose.UseVisualStyleBackColor = True
        '
        'btnNavigateToRoot
        '
        Me.btnNavigateToRoot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavigateToRoot.Location = New System.Drawing.Point(7, 67)
        Me.btnNavigateToRoot.Name = "btnNavigateToRoot"
        Me.btnNavigateToRoot.Size = New System.Drawing.Size(272, 23)
        Me.btnNavigateToRoot.TabIndex = 3
        Me.btnNavigateToRoot.Text = "Navigate to C$"
        Me.btnNavigateToRoot.UseVisualStyleBackColor = True
        '
        'btnEditHostsFile
        '
        Me.btnEditHostsFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditHostsFile.Location = New System.Drawing.Point(7, 37)
        Me.btnEditHostsFile.Name = "btnEditHostsFile"
        Me.btnEditHostsFile.Size = New System.Drawing.Size(272, 23)
        Me.btnEditHostsFile.TabIndex = 2
        Me.btnEditHostsFile.Text = "Edit hosts file"
        Me.btnEditHostsFile.UseVisualStyleBackColor = True
        '
        'btnLaunchVNCViewer
        '
        Me.btnLaunchVNCViewer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaunchVNCViewer.Location = New System.Drawing.Point(7, 7)
        Me.btnLaunchVNCViewer.Name = "btnLaunchVNCViewer"
        Me.btnLaunchVNCViewer.Size = New System.Drawing.Size(272, 23)
        Me.btnLaunchVNCViewer.TabIndex = 1
        Me.btnLaunchVNCViewer.Text = "Launch VNC Viewer"
        Me.btnLaunchVNCViewer.UseVisualStyleBackColor = True
        '
        'tpPSTools
        '
        Me.tpPSTools.BackColor = System.Drawing.SystemColors.Control
        Me.tpPSTools.Controls.Add(Me.btnPSExec)
        Me.tpPSTools.Controls.Add(Me.btnRemoteInfo)
        Me.tpPSTools.Controls.Add(Me.btnPSToolsClose)
        Me.tpPSTools.Controls.Add(Me.btnRestartRemoteService)
        Me.tpPSTools.Controls.Add(Me.btnForcedRemoteRestart)
        Me.tpPSTools.Controls.Add(Me.btnLoggedOnUser)
        Me.tpPSTools.Location = New System.Drawing.Point(4, 22)
        Me.tpPSTools.Name = "tpPSTools"
        Me.tpPSTools.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPSTools.Size = New System.Drawing.Size(285, 230)
        Me.tpPSTools.TabIndex = 1
        Me.tpPSTools.Text = "PSTools"
        Me.tpPSTools.ToolTipText = "Contains the PSTools suite to use against the remote PC."
        '
        'btnRemoteInfo
        '
        Me.btnRemoteInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoteInfo.Location = New System.Drawing.Point(7, 95)
        Me.btnRemoteInfo.Name = "btnRemoteInfo"
        Me.btnRemoteInfo.Size = New System.Drawing.Size(271, 23)
        Me.btnRemoteInfo.TabIndex = 4
        Me.btnRemoteInfo.Text = "Display Remote PC Info"
        Me.btnRemoteInfo.UseVisualStyleBackColor = True
        '
        'btnPSToolsClose
        '
        Me.btnPSToolsClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPSToolsClose.Location = New System.Drawing.Point(109, 201)
        Me.btnPSToolsClose.Name = "btnPSToolsClose"
        Me.btnPSToolsClose.Size = New System.Drawing.Size(75, 23)
        Me.btnPSToolsClose.TabIndex = 3
        Me.btnPSToolsClose.Text = "Close"
        Me.btnPSToolsClose.UseVisualStyleBackColor = True
        '
        'btnRestartRemoteService
        '
        Me.btnRestartRemoteService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestartRemoteService.Location = New System.Drawing.Point(6, 65)
        Me.btnRestartRemoteService.Name = "btnRestartRemoteService"
        Me.btnRestartRemoteService.Size = New System.Drawing.Size(272, 23)
        Me.btnRestartRemoteService.TabIndex = 2
        Me.btnRestartRemoteService.Text = "Restart Remote Service"
        Me.btnRestartRemoteService.UseVisualStyleBackColor = True
        '
        'btnForcedRemoteRestart
        '
        Me.btnForcedRemoteRestart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForcedRemoteRestart.Location = New System.Drawing.Point(6, 36)
        Me.btnForcedRemoteRestart.Name = "btnForcedRemoteRestart"
        Me.btnForcedRemoteRestart.Size = New System.Drawing.Size(273, 23)
        Me.btnForcedRemoteRestart.TabIndex = 1
        Me.btnForcedRemoteRestart.Text = "Forced Remote Restart After 15 Seconds"
        Me.btnForcedRemoteRestart.UseVisualStyleBackColor = True
        '
        'btnLoggedOnUser
        '
        Me.btnLoggedOnUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoggedOnUser.Location = New System.Drawing.Point(7, 7)
        Me.btnLoggedOnUser.Name = "btnLoggedOnUser"
        Me.btnLoggedOnUser.Size = New System.Drawing.Size(272, 23)
        Me.btnLoggedOnUser.TabIndex = 0
        Me.btnLoggedOnUser.Text = "Show Logged On User"
        Me.btnLoggedOnUser.UseVisualStyleBackColor = True
        '
        'tpAbout
        '
        Me.tpAbout.BackColor = System.Drawing.SystemColors.Control
        Me.tpAbout.Controls.Add(Me.btnAboutClose)
        Me.tpAbout.Controls.Add(Me.Label2)
        Me.tpAbout.Controls.Add(Me.Label1)
        Me.tpAbout.Controls.Add(Me.btnAbout)
        Me.tpAbout.Location = New System.Drawing.Point(4, 22)
        Me.tpAbout.Name = "tpAbout"
        Me.tpAbout.Size = New System.Drawing.Size(285, 230)
        Me.tpAbout.TabIndex = 3
        Me.tpAbout.Text = "About"
        Me.tpAbout.ToolTipText = "Contains the About page."
        '
        'btnAboutClose
        '
        Me.btnAboutClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAboutClose.Location = New System.Drawing.Point(109, 201)
        Me.btnAboutClose.Name = "btnAboutClose"
        Me.btnAboutClose.Size = New System.Drawing.Size(75, 23)
        Me.btnAboutClose.TabIndex = 3
        Me.btnAboutClose.Text = "Close"
        Me.btnAboutClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "QuickNetworkAccess Tool."
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This tool is based on Nate's"
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(109, 95)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 0
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(5, 16)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(61, 13)
        Me.lblIPAddress.TabIndex = 1
        Me.lblIPAddress.Text = "IP Address:"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIPAddress.Location = New System.Drawing.Point(72, 13)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(230, 20)
        Me.txtIPAddress.TabIndex = 0
        '
        'btnPSExec
        '
        Me.btnPSExec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPSExec.Location = New System.Drawing.Point(7, 125)
        Me.btnPSExec.Name = "btnPSExec"
        Me.btnPSExec.Size = New System.Drawing.Size(271, 23)
        Me.btnPSExec.TabIndex = 5
        Me.btnPSExec.Text = "PSExec to remote PC"
        Me.btnPSExec.UseVisualStyleBackColor = True
        '
        'frmISTTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 322)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Controls.Add(Me.lblIPAddress)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmISTTools"
        Me.Text = "IST Tool"
        Me.TabControl1.ResumeLayout(False)
        Me.tpNetwork.ResumeLayout(False)
        Me.tpPSTools.ResumeLayout(False)
        Me.tpAbout.ResumeLayout(False)
        Me.tpAbout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpNetwork As System.Windows.Forms.TabPage
    Friend WithEvents btnNetworkClose As System.Windows.Forms.Button
    Friend WithEvents btnNavigateToRoot As System.Windows.Forms.Button
    Friend WithEvents btnEditHostsFile As System.Windows.Forms.Button
    Friend WithEvents btnLaunchVNCViewer As System.Windows.Forms.Button
    Friend WithEvents tpPSTools As System.Windows.Forms.TabPage
    Friend WithEvents btnPSToolsClose As System.Windows.Forms.Button
    Friend WithEvents btnRestartRemoteService As System.Windows.Forms.Button
    Friend WithEvents btnForcedRemoteRestart As System.Windows.Forms.Button
    Friend WithEvents btnLoggedOnUser As System.Windows.Forms.Button
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnContinuousPing As System.Windows.Forms.Button
    Friend WithEvents btnRemoteInfo As System.Windows.Forms.Button
    Friend WithEvents tpAbout As System.Windows.Forms.TabPage
    Friend WithEvents btnAboutClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnRemotePush As System.Windows.Forms.Button
    Friend WithEvents btnPSExec As System.Windows.Forms.Button

End Class
