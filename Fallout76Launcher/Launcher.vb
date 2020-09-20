Public Class Launcher

#Region " Move Form "

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Me.MouseDown, PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Me.MouseMove, PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Me.MouseUp, PictureBox1.MouseUp, PictureBox2.MouseUp, PictureBox3.MouseUp, PictureBox4.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub
#End Region

#Region " Button Hover "

    Private Sub PlayButton_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Image = My.Resources.playlit
    End Sub

    Private Sub PlayButton_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.play
    End Sub
    Private Sub OptionsButton_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseMove
        PictureBox2.Image = My.Resources.optionslit
    End Sub

    Private Sub OptionsButton_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.options
    End Sub
    Private Sub SupportButton_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Image = My.Resources.supportlit
    End Sub

    Private Sub SupportButton_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.support
    End Sub
    Private Sub ExitButton_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Image = My.Resources.exitlit
    End Sub

    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources._exit
    End Sub

#End Region

#Region " Button Clicks "
    Private Sub Play_Click(ByVal sender As System.Object,
                            ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim clickedLabel = TryCast(sender, Label)
        MoveForm = False
        System.Diagnostics.Process.Start("steam://rungameid/1151340")
        Application.Exit()
    End Sub
    Private Sub Options_Click(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim clickedLabel = TryCast(sender, Label)
        MoveForm = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Options.ShowDialog()
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
    End Sub
    Private Sub Support_Click(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim clickedLabel = TryCast(sender, Label)
        MoveForm = False
        System.Diagnostics.Process.Start("http://github.com/kran27/Fallout76Launcher")
    End Sub
    Private Sub Exit_Click(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim clickedLabel = TryCast(sender, Label)
        Application.Exit()
    End Sub

#End Region

End Class