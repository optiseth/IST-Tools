<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemotePCInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemotePCInfo))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtRemoteInfo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(391, 278)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtRemoteInfo
        '
        Me.txtRemoteInfo.Location = New System.Drawing.Point(13, 13)
        Me.txtRemoteInfo.Multiline = True
        Me.txtRemoteInfo.Name = "txtRemoteInfo"
        Me.txtRemoteInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRemoteInfo.Size = New System.Drawing.Size(453, 259)
        Me.txtRemoteInfo.TabIndex = 1
        '
        'RemotePCInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 313)
        Me.Controls.Add(Me.txtRemoteInfo)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RemotePCInfo"
        Me.Text = "RemotePCInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtRemoteInfo As System.Windows.Forms.TextBox
End Class
