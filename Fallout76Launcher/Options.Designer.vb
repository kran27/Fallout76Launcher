<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Borderless = New System.Windows.Forms.CheckBox()
        Me.Windowed = New System.Windows.Forms.CheckBox()
        Me.Aspect = New System.Windows.Forms.ComboBox()
        Me.Resolution = New System.Windows.Forms.ComboBox()
        Me.Antialias = New System.Windows.Forms.ComboBox()
        Me.Anisotropic = New System.Windows.Forms.ComboBox()
        Me.AspectLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ResWin169 = New System.Windows.Forms.ComboBox()
        Me.ResWin1610 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Graphics Adapter and Resolution"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(370, 283)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(77, 25)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(274, 283)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(77, 25)
        Me.OK.TabIndex = 2
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Borderless
        '
        Me.Borderless.AutoSize = True
        Me.Borderless.Location = New System.Drawing.Point(23, 267)
        Me.Borderless.Name = "Borderless"
        Me.Borderless.Size = New System.Drawing.Size(75, 17)
        Me.Borderless.TabIndex = 3
        Me.Borderless.Text = "Borderless"
        Me.Borderless.UseVisualStyleBackColor = True
        '
        'Windowed
        '
        Me.Windowed.AutoSize = True
        Me.Windowed.Location = New System.Drawing.Point(23, 247)
        Me.Windowed.Name = "Windowed"
        Me.Windowed.Size = New System.Drawing.Size(107, 17)
        Me.Windowed.TabIndex = 4
        Me.Windowed.Text = "Windowed Mode"
        Me.Windowed.UseVisualStyleBackColor = True
        '
        'Aspect
        '
        Me.Aspect.Cursor = System.Windows.Forms.Cursors.Default
        Me.Aspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Aspect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Aspect.FormattingEnabled = True
        Me.Aspect.Items.AddRange(New Object() {"16:9 Widescreen", "16:10 Widescreen"})
        Me.Aspect.Location = New System.Drawing.Point(152, 34)
        Me.Aspect.Name = "Aspect"
        Me.Aspect.Size = New System.Drawing.Size(263, 21)
        Me.Aspect.TabIndex = 5
        '
        'Resolution
        '
        Me.Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Resolution.FormattingEnabled = True
        Me.Resolution.Items.AddRange(New Object() {"1280x720", "1360x768", "1366x768", "1600x900", "1920x1080", "2560x1440", "3840x2160"})
        Me.Resolution.Location = New System.Drawing.Point(152, 59)
        Me.Resolution.Name = "Resolution"
        Me.Resolution.Size = New System.Drawing.Size(263, 21)
        Me.Resolution.TabIndex = 6
        '
        'Antialias
        '
        Me.Antialias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Antialias.FormattingEnabled = True
        Me.Antialias.Items.AddRange(New Object() {"Off (Best performance)", "FXAA (Low)", "TAA (Best quality)"})
        Me.Antialias.Location = New System.Drawing.Point(152, 84)
        Me.Antialias.Name = "Antialias"
        Me.Antialias.Size = New System.Drawing.Size(263, 21)
        Me.Antialias.TabIndex = 7
        '
        'Anisotropic
        '
        Me.Anisotropic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Anisotropic.FormattingEnabled = True
        Me.Anisotropic.Items.AddRange(New Object() {"Off (Best performance)", "2 Samples", "4 Samples", "8 Samples", "12 Samples", "16 Samples"})
        Me.Anisotropic.Location = New System.Drawing.Point(152, 109)
        Me.Anisotropic.Name = "Anisotropic"
        Me.Anisotropic.Size = New System.Drawing.Size(263, 21)
        Me.Anisotropic.TabIndex = 8
        '
        'AspectLabel
        '
        Me.AspectLabel.AutoSize = True
        Me.AspectLabel.Location = New System.Drawing.Point(80, 37)
        Me.AspectLabel.Name = "AspectLabel"
        Me.AspectLabel.Size = New System.Drawing.Size(68, 13)
        Me.AspectLabel.TabIndex = 9
        Me.AspectLabel.Text = "Aspect Ratio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Resolutions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Antialiasing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Anisotropic Filtering"
        '
        'ResWin169
        '
        Me.ResWin169.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResWin169.FormattingEnabled = True
        Me.ResWin169.Items.AddRange(New Object() {"800x450", "1280x720", "1440x810", "1920x1080"})
        Me.ResWin169.Location = New System.Drawing.Point(152, 59)
        Me.ResWin169.Name = "ResWin169"
        Me.ResWin169.Size = New System.Drawing.Size(263, 21)
        Me.ResWin169.TabIndex = 13
        '
        'ResWin1610
        '
        Me.ResWin1610.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResWin1610.FormattingEnabled = True
        Me.ResWin1610.Items.AddRange(New Object() {"800x500", "1024x640", "1280x800", "1440x900", "1680x1050"})
        Me.ResWin1610.Location = New System.Drawing.Point(152, 59)
        Me.ResWin1610.Name = "ResWin1610"
        Me.ResWin1610.Size = New System.Drawing.Size(263, 21)
        Me.ResWin1610.TabIndex = 14
        '
        'Options
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(456, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.ResWin1610)
        Me.Controls.Add(Me.ResWin169)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AspectLabel)
        Me.Controls.Add(Me.Anisotropic)
        Me.Controls.Add(Me.Antialias)
        Me.Controls.Add(Me.Resolution)
        Me.Controls.Add(Me.Aspect)
        Me.Controls.Add(Me.Windowed)
        Me.Controls.Add(Me.Borderless)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Options"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fallout 76 Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Borderless As CheckBox
    Friend WithEvents Windowed As CheckBox
    Friend WithEvents Aspect As ComboBox
    Friend WithEvents Resolution As ComboBox
    Friend WithEvents Antialias As ComboBox
    Friend WithEvents Anisotropic As ComboBox
    Friend WithEvents AspectLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ResWin169 As ComboBox
    Friend WithEvents ResWin1610 As ComboBox
End Class
