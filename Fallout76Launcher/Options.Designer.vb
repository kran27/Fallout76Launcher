<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Borderless = New System.Windows.Forms.CheckBox()
        Me.Windowed = New System.Windows.Forms.CheckBox()
        Me.Aspect = New System.Windows.Forms.ComboBox()
        Me.Resolution = New System.Windows.Forms.ComboBox()
        Me.Antialias = New System.Windows.Forms.ComboBox()
        Me.Anisotropic = New System.Windows.Forms.ComboBox()
        Me.AspectLabel = New System.Windows.Forms.Label()
        Me.ResolutionLabel = New System.Windows.Forms.Label()
        Me.AntialiasLabel = New System.Windows.Forms.Label()
        Me.AnisotropicLabel = New System.Windows.Forms.Label()
        Me.ResWin169 = New System.Windows.Forms.ComboBox()
        Me.ResWin1610 = New System.Windows.Forms.ComboBox()
        Me.Low = New System.Windows.Forms.Button()
        Me.Medium = New System.Windows.Forms.Button()
        Me.High = New System.Windows.Forms.Button()
        Me.Ultra = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Advanced = New System.Windows.Forms.Button()
        Me.Detail = New System.Windows.Forms.GroupBox()
        Me.GraphAdaptRes = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
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
        'ResolutionLabel
        '
        Me.ResolutionLabel.AutoSize = True
        Me.ResolutionLabel.Location = New System.Drawing.Point(86, 62)
        Me.ResolutionLabel.Name = "ResolutionLabel"
        Me.ResolutionLabel.Size = New System.Drawing.Size(62, 13)
        Me.ResolutionLabel.TabIndex = 10
        Me.ResolutionLabel.Text = "Resolutions"
        '
        'AntialiasLabel
        '
        Me.AntialiasLabel.AutoSize = True
        Me.AntialiasLabel.Location = New System.Drawing.Point(88, 86)
        Me.AntialiasLabel.Name = "AntialiasLabel"
        Me.AntialiasLabel.Size = New System.Drawing.Size(60, 13)
        Me.AntialiasLabel.TabIndex = 11
        Me.AntialiasLabel.Text = "Antialiasing"
        '
        'AnisotropicLabel
        '
        Me.AnisotropicLabel.AutoSize = True
        Me.AnisotropicLabel.Location = New System.Drawing.Point(50, 112)
        Me.AnisotropicLabel.Name = "AnisotropicLabel"
        Me.AnisotropicLabel.Size = New System.Drawing.Size(98, 13)
        Me.AnisotropicLabel.TabIndex = 12
        Me.AnisotropicLabel.Text = "Anisotropic Filtering"
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
        'Low
        '
        Me.Low.Location = New System.Drawing.Point(22, 176)
        Me.Low.Name = "Low"
        Me.Low.Size = New System.Drawing.Size(68, 25)
        Me.Low.TabIndex = 16
        Me.Low.Text = "Low"
        Me.Low.UseVisualStyleBackColor = True
        '
        'Medium
        '
        Me.Medium.Location = New System.Drawing.Point(91, 176)
        Me.Medium.Name = "Medium"
        Me.Medium.Size = New System.Drawing.Size(68, 25)
        Me.Medium.TabIndex = 17
        Me.Medium.Text = "Medium"
        Me.Medium.UseVisualStyleBackColor = True
        '
        'High
        '
        Me.High.Location = New System.Drawing.Point(160, 176)
        Me.High.Name = "High"
        Me.High.Size = New System.Drawing.Size(68, 25)
        Me.High.TabIndex = 18
        Me.High.Text = "High"
        Me.High.UseVisualStyleBackColor = True
        '
        'Ultra
        '
        Me.Ultra.Location = New System.Drawing.Point(229, 176)
        Me.Ultra.Name = "Ultra"
        Me.Ultra.Size = New System.Drawing.Size(68, 25)
        Me.Ultra.TabIndex = 19
        Me.Ultra.Text = "Ultra"
        Me.Ultra.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(298, 176)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(137, 25)
        Me.Reset.TabIndex = 20
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Advanced
        '
        Me.Advanced.Location = New System.Drawing.Point(299, 204)
        Me.Advanced.Name = "Advanced"
        Me.Advanced.Size = New System.Drawing.Size(136, 25)
        Me.Advanced.TabIndex = 21
        Me.Advanced.Text = "Advanced"
        Me.Advanced.UseVisualStyleBackColor = True
        '
        'Detail
        '
        Me.Detail.Location = New System.Drawing.Point(11, 156)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(434, 80)
        Me.Detail.TabIndex = 22
        Me.Detail.TabStop = False
        Me.Detail.Text = "Detail"
        '
        'GraphAdaptRes
        '
        Me.GraphAdaptRes.Location = New System.Drawing.Point(11, 11)
        Me.GraphAdaptRes.Name = "GraphAdaptRes"
        Me.GraphAdaptRes.Size = New System.Drawing.Size(434, 137)
        Me.GraphAdaptRes.TabIndex = 23
        Me.GraphAdaptRes.TabStop = False
        Me.GraphAdaptRes.Text = "Graphics Adapter and Resolution"
        '
        'Options
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(456, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.Advanced)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Ultra)
        Me.Controls.Add(Me.High)
        Me.Controls.Add(Me.Medium)
        Me.Controls.Add(Me.Low)
        Me.Controls.Add(Me.ResWin1610)
        Me.Controls.Add(Me.ResWin169)
        Me.Controls.Add(Me.AnisotropicLabel)
        Me.Controls.Add(Me.AntialiasLabel)
        Me.Controls.Add(Me.ResolutionLabel)
        Me.Controls.Add(Me.AspectLabel)
        Me.Controls.Add(Me.Anisotropic)
        Me.Controls.Add(Me.Antialias)
        Me.Controls.Add(Me.Resolution)
        Me.Controls.Add(Me.Aspect)
        Me.Controls.Add(Me.Windowed)
        Me.Controls.Add(Me.Borderless)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.GraphAdaptRes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Options"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fallout 76 Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Borderless As CheckBox
    Friend WithEvents Windowed As CheckBox
    Friend WithEvents Aspect As ComboBox
    Friend WithEvents Resolution As ComboBox
    Friend WithEvents Antialias As ComboBox
    Friend WithEvents Anisotropic As ComboBox
    Friend WithEvents AspectLabel As Label
    Friend WithEvents ResolutionLabel As Label
    Friend WithEvents AntialiasLabel As Label
    Friend WithEvents AnisotropicLabel As Label
    Friend WithEvents ResWin169 As ComboBox
    Friend WithEvents ResWin1610 As ComboBox
    Friend WithEvents Low As Button
    Friend WithEvents Medium As Button
    Friend WithEvents High As Button
    Friend WithEvents Ultra As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Advanced As Button
    Friend WithEvents Detail As GroupBox
    Friend WithEvents GraphAdaptRes As GroupBox
End Class
