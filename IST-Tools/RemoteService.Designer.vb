﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoteService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemoteService))
        Me.cmbServices = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbStart = New System.Windows.Forms.RadioButton()
        Me.rdbStop = New System.Windows.Forms.RadioButton()
        Me.rdbRestart = New System.Windows.Forms.RadioButton()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomProcess = New System.Windows.Forms.TextBox()
        Me.rdbEnableService = New System.Windows.Forms.RadioButton()
        Me.rdbDisableService = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmbServices
        '
        Me.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServices.FormattingEnabled = True
        Me.cmbServices.Items.AddRange(New Object() {"VNC", "Remote Registry", "Windows Firewall", "Print Spooler", "Custom"})
        Me.cmbServices.Location = New System.Drawing.Point(16, 39)
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.Size = New System.Drawing.Size(185, 21)
        Me.cmbServices.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please select a service:"
        '
        'rdbStart
        '
        Me.rdbStart.AutoSize = True
        Me.rdbStart.Location = New System.Drawing.Point(16, 132)
        Me.rdbStart.Name = "rdbStart"
        Me.rdbStart.Size = New System.Drawing.Size(47, 17)
        Me.rdbStart.TabIndex = 2
        Me.rdbStart.TabStop = True
        Me.rdbStart.Text = "Start"
        Me.rdbStart.UseVisualStyleBackColor = True
        '
        'rdbStop
        '
        Me.rdbStop.AutoSize = True
        Me.rdbStop.Location = New System.Drawing.Point(85, 132)
        Me.rdbStop.Name = "rdbStop"
        Me.rdbStop.Size = New System.Drawing.Size(47, 17)
        Me.rdbStop.TabIndex = 3
        Me.rdbStop.TabStop = True
        Me.rdbStop.Text = "Stop"
        Me.rdbStop.UseVisualStyleBackColor = True
        '
        'rdbRestart
        '
        Me.rdbRestart.AutoSize = True
        Me.rdbRestart.Location = New System.Drawing.Point(142, 132)
        Me.rdbRestart.Name = "rdbRestart"
        Me.rdbRestart.Size = New System.Drawing.Size(59, 17)
        Me.rdbRestart.TabIndex = 4
        Me.rdbRestart.TabStop = True
        Me.rdbRestart.Text = "Restart"
        Me.rdbRestart.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(69, 204)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 5
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Custom:"
        '
        'txtCustomProcess
        '
        Me.txtCustomProcess.Enabled = False
        Me.txtCustomProcess.Location = New System.Drawing.Point(69, 73)
        Me.txtCustomProcess.Name = "txtCustomProcess"
        Me.txtCustomProcess.Size = New System.Drawing.Size(132, 20)
        Me.txtCustomProcess.TabIndex = 7
        '
        'rdbEnableService
        '
        Me.rdbEnableService.AutoSize = True
        Me.rdbEnableService.Location = New System.Drawing.Point(16, 166)
        Me.rdbEnableService.Name = "rdbEnableService"
        Me.rdbEnableService.Size = New System.Drawing.Size(58, 17)
        Me.rdbEnableService.TabIndex = 8
        Me.rdbEnableService.TabStop = True
        Me.rdbEnableService.Text = "Enable"
        Me.rdbEnableService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbEnableService.UseVisualStyleBackColor = True
        '
        'rdbDisableService
        '
        Me.rdbDisableService.AutoSize = True
        Me.rdbDisableService.Location = New System.Drawing.Point(142, 166)
        Me.rdbDisableService.Name = "rdbDisableService"
        Me.rdbDisableService.Size = New System.Drawing.Size(60, 17)
        Me.rdbDisableService.TabIndex = 9
        Me.rdbDisableService.TabStop = True
        Me.rdbDisableService.Text = "Disable"
        Me.rdbDisableService.UseVisualStyleBackColor = True
        '
        'frmRemoteService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 239)
        Me.Controls.Add(Me.rdbDisableService)
        Me.Controls.Add(Me.rdbEnableService)
        Me.Controls.Add(Me.txtCustomProcess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.rdbRestart)
        Me.Controls.Add(Me.rdbStop)
        Me.Controls.Add(Me.rdbStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbServices)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemoteService"
        Me.Text = "Remote Service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbServices As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbStart As System.Windows.Forms.RadioButton
    Friend WithEvents rdbStop As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRestart As System.Windows.Forms.RadioButton
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomProcess As System.Windows.Forms.TextBox
    Friend WithEvents rdbEnableService As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDisableService As System.Windows.Forms.RadioButton
End Class
