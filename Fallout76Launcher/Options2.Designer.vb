<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options2
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Detail = New System.Windows.Forms.TabPage()
        Me.View = New System.Windows.Forms.TabPage()
        Me.OK = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.CausesValidation = False
        Me.TabControl.Controls.Add(Me.Detail)
        Me.TabControl.Controls.Add(Me.View)
        Me.TabControl.Location = New System.Drawing.Point(6, 7)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(351, 433)
        Me.TabControl.TabIndex = 0
        Me.TabControl.TabStop = False
        '
        'Detail
        '
        Me.Detail.Location = New System.Drawing.Point(4, 22)
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New System.Windows.Forms.Padding(3)
        Me.Detail.Size = New System.Drawing.Size(343, 407)
        Me.Detail.TabIndex = 0
        Me.Detail.Text = "Detail"
        Me.Detail.UseVisualStyleBackColor = True
        '
        'View
        '
        Me.View.Location = New System.Drawing.Point(4, 22)
        Me.View.Name = "View"
        Me.View.Padding = New System.Windows.Forms.Padding(3)
        Me.View.Size = New System.Drawing.Size(343, 407)
        Me.View.TabIndex = 1
        Me.View.Text = "View Distance"
        Me.View.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(279, 444)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(77, 25)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Options2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 475)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(1196, 346)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Fallout 76 Advanced Options"
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents Detail As TabPage
    Friend WithEvents View As TabPage
    Friend WithEvents OK As Button
End Class
