<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreTools_Basic
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
        Me.CPUZ = New System.Windows.Forms.Button()
        Me.GPUZ = New System.Windows.Forms.Button()
        Me.RapidCRC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CPUZ
        '
        Me.CPUZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CPUZ.Location = New System.Drawing.Point(12, 12)
        Me.CPUZ.Name = "CPUZ"
        Me.CPUZ.Size = New System.Drawing.Size(72, 29)
        Me.CPUZ.TabIndex = 12
        Me.CPUZ.Text = "CPU-Z"
        Me.CPUZ.UseVisualStyleBackColor = True
        '
        'GPUZ
        '
        Me.GPUZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GPUZ.Location = New System.Drawing.Point(12, 47)
        Me.GPUZ.Name = "GPUZ"
        Me.GPUZ.Size = New System.Drawing.Size(72, 29)
        Me.GPUZ.TabIndex = 12
        Me.GPUZ.Text = "GPU-Z"
        Me.GPUZ.UseVisualStyleBackColor = True
        '
        'RapidCRC
        '
        Me.RapidCRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RapidCRC.Location = New System.Drawing.Point(12, 82)
        Me.RapidCRC.Name = "RapidCRC"
        Me.RapidCRC.Size = New System.Drawing.Size(72, 29)
        Me.RapidCRC.TabIndex = 12
        Me.RapidCRC.Text = "RapidCRC"
        Me.RapidCRC.UseVisualStyleBackColor = True
        '
        'MoreTools_Basic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RapidCRC)
        Me.Controls.Add(Me.GPUZ)
        Me.Controls.Add(Me.CPUZ)
        Me.Name = "MoreTools_Basic"
        Me.Text = "MoreTools_Basic"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPUZ As System.Windows.Forms.Button
    Friend WithEvents GPUZ As System.Windows.Forms.Button
    Friend WithEvents RapidCRC As System.Windows.Forms.Button
End Class
