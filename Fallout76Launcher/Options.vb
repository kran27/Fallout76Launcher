Imports System.Management
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
#End Region

#Region " .ini Presets "
    Public Preset As String
    Public Sub Set_L() Handles Low.Click
        Aspect.SelectedIndex = 0
        Resolution.SelectedIndex = 4
        Antialias.SelectedIndex = 1
        Anisotropic.SelectedIndex = 0
        Preset = "_low"
        MsgBox("Video settings have been set for Low Quality.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Video settings have been set for Low Quality.")
    End Sub
    Public Sub Set_M() Handles Medium.Click
        Aspect.SelectedIndex = 0
        Resolution.SelectedIndex = 4
        Antialias.SelectedIndex = 2
        Anisotropic.SelectedIndex = 5
        Preset = "_med"
        MsgBox("Video settings have been set for Medium Quality.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Video settings have been set for Medium Quality.")
    End Sub
    Public Sub Set_H() Handles High.Click
        Aspect.SelectedIndex = 0
        Resolution.SelectedIndex = 4
        Antialias.SelectedIndex = 2
        Anisotropic.SelectedIndex = 5
        Preset = "_high"
        MsgBox("Video settings have been set for High Quality.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Video settings have been set for High Quality.")
    End Sub
    Public Sub Set_U() Handles Ultra.Click
        Aspect.SelectedIndex = 0
        Resolution.SelectedIndex = 4
        Antialias.SelectedIndex = 2
        Anisotropic.SelectedIndex = 5
        Preset = "_ultra"
        MsgBox("Video settings have been set for Ultra Quality.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Video settings have been set for Ultra Quality.")
    End Sub
    Public Sub Set_Auto() Handles Reset.Click
        Dim query As New SelectQuery("Win32_VideoController")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            Dim GPUName As String = info("Name").ToString
            MsgBox(GPUName)
        Next
    End Sub
    Public Sub Copy_ini() Handles OK.Click
        If Preset IsNot Nothing Then
            Dim cnamel As Byte = My.Computer.Name.Length
            Dim uname As String = My.User.Name.Remove(0, cnamel + 1)
            Dim dirst1 As String = "C:\Users\"
            Dim dirst2 As String = "\Documents\My Games\Fallout 76\Fallout76.ini"
            If Preset Is "_low" Then
                System.IO.File.WriteAllText(dirst1 & uname & dirst2, My.Resources.Low)
                Close()
            ElseIf Preset Is "_med" Then
                System.IO.File.WriteAllText(dirst1 & uname & dirst2, My.Resources.Medium)
                Close()
            ElseIf Preset Is "_high" Then
                System.IO.File.WriteAllText(dirst1 & uname & dirst2, My.Resources.High)
                Close()
            ElseIf Preset Is "_ultra" Then
                System.IO.File.WriteAllText(dirst1 & uname & dirst2, My.Resources.Ultra)
                Close()
            End If
        End If
    End Sub
#End Region

#Region " .ini Edits "
    Public Sub InvalidatePresets() Handles Aspect.SelectedIndexChanged, Resolution.SelectedIndexChanged, ResWin1610.SelectedIndexChanged, ResWin169.SelectedIndexChanged, Antialias.SelectedIndexChanged, Anisotropic.SelectedIndexChanged, Windowed.CheckedChanged, Borderless.CheckedChanged
        Preset = ""
    End Sub

#End Region

End Class