<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreTools
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Bginfo", "CPU-Z", "GPU-Z", "RapidCRC", "TeamViewer", "Windows Error Lookup Tool"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(189, 225)
        Me.ListBox1.TabIndex = 10
        '
        'Button12
        '
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(400, 178)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(76, 43)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "Launch"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(207, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(269, 164)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "Click on a tool to the left to see information about it."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "** NOTE: This is work in progress and may not work!"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(318, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 43)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(210, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 43)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MoreTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 249)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "MoreTools"
        Me.Text = "MoreTools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
