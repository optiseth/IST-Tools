<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPSExec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPSExec))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnIPList = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnExecutePSExec = New System.Windows.Forms.Button()
        Me.rdbSinglePC = New System.Windows.Forms.RadioButton()
        Me.rdbMultiplePCs = New System.Windows.Forms.RadioButton()
        Me.txtIPList = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(105, 317)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(13, 248)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectFile.TabIndex = 2
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'btnIPList
        '
        Me.btnIPList.Location = New System.Drawing.Point(197, 248)
        Me.btnIPList.Name = "btnIPList"
        Me.btnIPList.Size = New System.Drawing.Size(75, 23)
        Me.btnIPList.TabIndex = 3
        Me.btnIPList.Text = "IP List"
        Me.btnIPList.UseVisualStyleBackColor = True
        '
        'btnExecutePSExec
        '
        Me.btnExecutePSExec.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecutePSExec.Location = New System.Drawing.Point(13, 288)
        Me.btnExecutePSExec.Name = "btnExecutePSExec"
        Me.btnExecutePSExec.Size = New System.Drawing.Size(259, 23)
        Me.btnExecutePSExec.TabIndex = 4
        Me.btnExecutePSExec.Text = "Execute PSExec on Remote Target(s)"
        Me.btnExecutePSExec.UseVisualStyleBackColor = True
        '
        'rdbSinglePC
        '
        Me.rdbSinglePC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdbSinglePC.AutoSize = True
        Me.rdbSinglePC.Location = New System.Drawing.Point(13, 219)
        Me.rdbSinglePC.Name = "rdbSinglePC"
        Me.rdbSinglePC.Size = New System.Drawing.Size(71, 17)
        Me.rdbSinglePC.TabIndex = 5
        Me.rdbSinglePC.TabStop = True
        Me.rdbSinglePC.Text = "Single PC"
        Me.rdbSinglePC.UseVisualStyleBackColor = True
        '
        'rdbMultiplePCs
        '
        Me.rdbMultiplePCs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdbMultiplePCs.AutoSize = True
        Me.rdbMultiplePCs.Location = New System.Drawing.Point(197, 219)
        Me.rdbMultiplePCs.Name = "rdbMultiplePCs"
        Me.rdbMultiplePCs.Size = New System.Drawing.Size(83, 17)
        Me.rdbMultiplePCs.TabIndex = 6
        Me.rdbMultiplePCs.TabStop = True
        Me.rdbMultiplePCs.Text = "Multiple PCs"
        Me.rdbMultiplePCs.UseVisualStyleBackColor = True
        '
        'txtIPList
        '
        Me.txtIPList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIPList.Location = New System.Drawing.Point(13, 13)
        Me.txtIPList.Multiline = True
        Me.txtIPList.Name = "txtIPList"
        Me.txtIPList.ReadOnly = True
        Me.txtIPList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIPList.Size = New System.Drawing.Size(259, 200)
        Me.txtIPList.TabIndex = 7
        '
        'frmPSExec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 352)
        Me.Controls.Add(Me.txtIPList)
        Me.Controls.Add(Me.rdbMultiplePCs)
        Me.Controls.Add(Me.rdbSinglePC)
        Me.Controls.Add(Me.btnExecutePSExec)
        Me.Controls.Add(Me.btnIPList)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPSExec"
        Me.Text = "PSExec"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSelectFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnIPList As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnExecutePSExec As System.Windows.Forms.Button
    Friend WithEvents rdbSinglePC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMultiplePCs As System.Windows.Forms.RadioButton
    Friend WithEvents txtIPList As System.Windows.Forms.TextBox
End Class
