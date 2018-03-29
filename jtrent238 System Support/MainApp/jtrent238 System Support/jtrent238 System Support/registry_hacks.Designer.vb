<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registry_hacks
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
        Me.checkbox_take_ownership = New System.Windows.Forms.CheckBox()
        Me.button_apply = New System.Windows.Forms.Button()
        Me.checkbox_windows_update_auto_reboot = New System.Windows.Forms.CheckBox()
        Me.checkbox_open_with_notepad = New System.Windows.Forms.CheckBox()
        Me.checkbox_add_registry_editor_to_control_panel = New System.Windows.Forms.CheckBox()
        Me.notice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkbox_take_ownership
        '
        Me.checkbox_take_ownership.AutoSize = True
        Me.checkbox_take_ownership.Location = New System.Drawing.Point(12, 12)
        Me.checkbox_take_ownership.Name = "checkbox_take_ownership"
        Me.checkbox_take_ownership.Size = New System.Drawing.Size(104, 17)
        Me.checkbox_take_ownership.TabIndex = 0
        Me.checkbox_take_ownership.Text = "Take Ownership"
        Me.checkbox_take_ownership.UseVisualStyleBackColor = True
        '
        'button_apply
        '
        Me.button_apply.Location = New System.Drawing.Point(527, 100)
        Me.button_apply.Name = "button_apply"
        Me.button_apply.Size = New System.Drawing.Size(75, 23)
        Me.button_apply.TabIndex = 1
        Me.button_apply.Text = "Apply"
        Me.button_apply.UseVisualStyleBackColor = True
        '
        'checkbox_windows_update_auto_reboot
        '
        Me.checkbox_windows_update_auto_reboot.AutoSize = True
        Me.checkbox_windows_update_auto_reboot.Location = New System.Drawing.Point(12, 35)
        Me.checkbox_windows_update_auto_reboot.Name = "checkbox_windows_update_auto_reboot"
        Me.checkbox_windows_update_auto_reboot.Size = New System.Drawing.Size(171, 17)
        Me.checkbox_windows_update_auto_reboot.TabIndex = 2
        Me.checkbox_windows_update_auto_reboot.Text = "Windows Update Auto Reboot"
        Me.checkbox_windows_update_auto_reboot.UseVisualStyleBackColor = True
        '
        'checkbox_open_with_notepad
        '
        Me.checkbox_open_with_notepad.AutoSize = True
        Me.checkbox_open_with_notepad.Location = New System.Drawing.Point(12, 58)
        Me.checkbox_open_with_notepad.Name = "checkbox_open_with_notepad"
        Me.checkbox_open_with_notepad.Size = New System.Drawing.Size(200, 17)
        Me.checkbox_open_with_notepad.TabIndex = 2
        Me.checkbox_open_with_notepad.Text = """Open With"" Notepad Context Menu"
        Me.checkbox_open_with_notepad.UseVisualStyleBackColor = True
        '
        'checkbox_add_registry_editor_to_control_panel
        '
        Me.checkbox_add_registry_editor_to_control_panel.AutoSize = True
        Me.checkbox_add_registry_editor_to_control_panel.Location = New System.Drawing.Point(12, 81)
        Me.checkbox_add_registry_editor_to_control_panel.Name = "checkbox_add_registry_editor_to_control_panel"
        Me.checkbox_add_registry_editor_to_control_panel.Size = New System.Drawing.Size(194, 17)
        Me.checkbox_add_registry_editor_to_control_panel.TabIndex = 2
        Me.checkbox_add_registry_editor_to_control_panel.Text = "Add Registry Editor to Control Panel"
        Me.checkbox_add_registry_editor_to_control_panel.UseVisualStyleBackColor = True
        '
        'notice
        '
        Me.notice.AutoSize = True
        Me.notice.Location = New System.Drawing.Point(9, 110)
        Me.notice.Name = "notice"
        Me.notice.Size = New System.Drawing.Size(471, 13)
        Me.notice.TabIndex = 3
        Me.notice.Text = "* NOTE: After pressing apply Click ""Yes"" and ""Yes"" again to add the Registry keys" &
    " to your registry!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jtrent238_System_Support.My.Resources.Resources.regedit_icon
        Me.PictureBox1.Location = New System.Drawing.Point(527, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'registry_hacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 132)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.notice)
        Me.Controls.Add(Me.checkbox_add_registry_editor_to_control_panel)
        Me.Controls.Add(Me.checkbox_open_with_notepad)
        Me.Controls.Add(Me.checkbox_windows_update_auto_reboot)
        Me.Controls.Add(Me.button_apply)
        Me.Controls.Add(Me.checkbox_take_ownership)
        Me.Name = "registry_hacks"
        Me.Text = "registry_hacks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkbox_take_ownership As CheckBox
    Friend WithEvents button_apply As Button
    Friend WithEvents checkbox_windows_update_auto_reboot As CheckBox
    Friend WithEvents checkbox_open_with_notepad As CheckBox
    Friend WithEvents checkbox_add_registry_editor_to_control_panel As CheckBox
    Friend WithEvents notice As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
