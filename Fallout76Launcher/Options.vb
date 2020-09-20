Public Class Options

#Region " Startup Code "
    Private Sub Box_Setup() Handles MyBase.VisibleChanged
        Resolution.SelectedIndex = 4
        Resolution.Visible = True
        ResWin1610.Visible = False
        ResWin169.Visible = False
        Antialias.SelectedIndex = 2
        Anisotropic.SelectedIndex = 5
    End Sub

#End Region

#Region " Switching Etc. "
    Private Sub Enable_Disable(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, Windowed.CheckedChanged
        Dim x As Boolean = Windowed.CheckState
        If x = False Then
            Resolution.SelectedIndex = 4
            Aspect.Enabled = False
            Aspect.SelectedIndex = 0
            Borderless.Enabled = False
            Borderless.CheckState = False
        Else
            Aspect.Enabled = True
            Borderless.Enabled = True
        End If
    End Sub
    Private Sub Windowed_to_Full(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windowed.CheckedChanged, Aspect.SelectedValueChanged
        Dim x As Byte = Aspect.SelectedIndex
        Dim y As Boolean = Windowed.Checked
        If y = False Then
            Resolution.SelectedIndex = 4
            Resolution.Visible = True
            ResWin1610.Visible = False
            ResWin169.Visible = False
        ElseIf y = True And x = 0 Then
            ResWin169.SelectedIndex = 0
            Resolution.Visible = False
            ResWin1610.Visible = False
            ResWin169.Visible = True
        ElseIf y = True And x = 1 Then
            ResWin1610.SelectedIndex = 0
            Resolution.Visible = False
            ResWin1610.Visible = True
            ResWin169.Visible = False
        End If
    End Sub

    Private Sub Advanced_Click(sender As Object, e As EventArgs) Handles Advanced.Click
        Options2.ShowDialog()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Options.HideDialog()

    End Sub
#End Region

End Class