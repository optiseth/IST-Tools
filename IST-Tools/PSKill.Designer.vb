<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPSKill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPSKill))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbProcessList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProcess = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnListProcesses = New System.Windows.Forms.Button()
        Me.btnKillProcess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(82, 168)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbProcessList
        '
        Me.cmbProcessList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProcessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProcessList.FormattingEnabled = True
        Me.cmbProcessList.Items.AddRange(New Object() {"Custom", "Internet Explorer", "Firefox", "Google Chrome"})
        Me.cmbProcessList.Location = New System.Drawing.Point(60, 13)
        Me.cmbProcessList.Name = "cmbProcessList"
        Me.cmbProcessList.Size = New System.Drawing.Size(168, 21)
        Me.cmbProcessList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Process:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Custom Process:"
        '
        'txtProcess
        '
        Me.txtProcess.Location = New System.Drawing.Point(101, 48)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(127, 20)
        Me.txtProcess.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Do not add .exe"
        '
        'btnListProcesses
        '
        Me.btnListProcesses.Location = New System.Drawing.Point(9, 93)
        Me.btnListProcesses.Name = "btnListProcesses"
        Me.btnListProcesses.Size = New System.Drawing.Size(219, 23)
        Me.btnListProcesses.TabIndex = 6
        Me.btnListProcesses.Text = "List Processes"
        Me.btnListProcesses.UseVisualStyleBackColor = True
        '
        'btnKillProcess
        '
        Me.btnKillProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKillProcess.Location = New System.Drawing.Point(9, 122)
        Me.btnKillProcess.Name = "btnKillProcess"
        Me.btnKillProcess.Size = New System.Drawing.Size(219, 23)
        Me.btnKillProcess.TabIndex = 7
        Me.btnKillProcess.Text = "Kill Process"
        Me.btnKillProcess.UseVisualStyleBackColor = True
        '
        'frmPSKill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 203)
        Me.Controls.Add(Me.btnKillProcess)
        Me.Controls.Add(Me.btnListProcesses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProcess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbProcessList)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPSKill"
        Me.Text = "PSKill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmbProcessList As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProcess As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnListProcesses As System.Windows.Forms.Button
    Friend WithEvents btnKillProcess As System.Windows.Forms.Button
End Class
