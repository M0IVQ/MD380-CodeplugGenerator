<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabRadioSettings = New System.Windows.Forms.TabPage()
        Me.tabScanLists = New System.Windows.Forms.TabPage()
        Me.tabRxGroups = New System.Windows.Forms.TabPage()
        Me.tabZones = New System.Windows.Forms.TabPage()
        Me.tabChannels = New System.Windows.Forms.TabPage()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallRxTone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabContacts = New System.Windows.Forms.TabPage()
        Me.tabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabRadioSettings)
        Me.tabMain.Controls.Add(Me.tabContacts)
        Me.tabMain.Controls.Add(Me.tabScanLists)
        Me.tabMain.Controls.Add(Me.tabRxGroups)
        Me.tabMain.Controls.Add(Me.tabZones)
        Me.tabMain.Controls.Add(Me.tabChannels)
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(810, 511)
        Me.tabMain.TabIndex = 0
        '
        'tabRadioSettings
        '
        Me.tabRadioSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabRadioSettings.Name = "tabRadioSettings"
        Me.tabRadioSettings.Size = New System.Drawing.Size(802, 485)
        Me.tabRadioSettings.TabIndex = 5
        Me.tabRadioSettings.Text = "Radio Settings"
        Me.tabRadioSettings.UseVisualStyleBackColor = True
        '
        'tabScanLists
        '
        Me.tabScanLists.Location = New System.Drawing.Point(4, 22)
        Me.tabScanLists.Name = "tabScanLists"
        Me.tabScanLists.Padding = New System.Windows.Forms.Padding(3)
        Me.tabScanLists.Size = New System.Drawing.Size(802, 485)
        Me.tabScanLists.TabIndex = 1
        Me.tabScanLists.Text = "Scan Lists"
        Me.tabScanLists.UseVisualStyleBackColor = True
        '
        'tabRxGroups
        '
        Me.tabRxGroups.Location = New System.Drawing.Point(4, 22)
        Me.tabRxGroups.Name = "tabRxGroups"
        Me.tabRxGroups.Size = New System.Drawing.Size(802, 485)
        Me.tabRxGroups.TabIndex = 2
        Me.tabRxGroups.Text = "Rx Groups"
        Me.tabRxGroups.UseVisualStyleBackColor = True
        '
        'tabZones
        '
        Me.tabZones.Location = New System.Drawing.Point(4, 22)
        Me.tabZones.Name = "tabZones"
        Me.tabZones.Size = New System.Drawing.Size(802, 485)
        Me.tabZones.TabIndex = 3
        Me.tabZones.Text = "Zones"
        Me.tabZones.UseVisualStyleBackColor = True
        '
        'tabChannels
        '
        Me.tabChannels.Location = New System.Drawing.Point(4, 22)
        Me.tabChannels.Name = "tabChannels"
        Me.tabChannels.Size = New System.Drawing.Size(802, 485)
        Me.tabChannels.TabIndex = 4
        Me.tabChannels.Text = "Channels"
        Me.tabChannels.UseVisualStyleBackColor = True
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'CallType
        '
        Me.CallType.HeaderText = "Call Type"
        Me.CallType.Name = "CallType"
        '
        'CallID
        '
        Me.CallID.HeaderText = "Call ID"
        Me.CallID.Name = "CallID"
        '
        'CallRxTone
        '
        Me.CallRxTone.HeaderText = "Call Received Tone"
        Me.CallRxTone.Name = "CallRxTone"
        '
        'tabContacts
        '
        Me.tabContacts.Location = New System.Drawing.Point(4, 22)
        Me.tabContacts.Name = "tabContacts"
        Me.tabContacts.Size = New System.Drawing.Size(802, 485)
        Me.tabContacts.TabIndex = 6
        Me.tabContacts.Text = "Contacts"
        Me.tabContacts.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 535)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabRadioSettings As TabPage
    Friend WithEvents tabScanLists As TabPage
    Friend WithEvents tabRxGroups As TabPage
    Friend WithEvents tabZones As TabPage
    Friend WithEvents tabChannels As TabPage
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents ContactName As DataGridViewTextBoxColumn
    Friend WithEvents CallType As DataGridViewTextBoxColumn
    Friend WithEvents CallID As DataGridViewTextBoxColumn
    Friend WithEvents CallRxTone As DataGridViewTextBoxColumn
    Friend WithEvents tabContacts As TabPage
End Class
