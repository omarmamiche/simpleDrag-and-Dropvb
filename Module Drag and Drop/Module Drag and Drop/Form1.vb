Public Class Form1
    Dim posX As Integer
    Dim posY As Integer
    Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.H_MOVE))

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If (e.Button = MouseButtons.Left) Then
            posX = e.X
            posY = e.Y
            PictureBox1.Cursor = cur
        End If
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        If (e.Button = MouseButtons.Left) Then
            posX = e.X
            posY = e.Y
            PictureBox2.Cursor = cur
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove, MyBase.MouseMove
        If (e.Button = MouseButtons.Left) Then
            PictureBox1.Top += (e.Y - posY)
            PictureBox1.Left += (e.X - posX)
            ToolStripStatusLabel1.Text = "Picturebox1: " & PictureBox1.Left & "," & PictureBox1.Top
            PictureBox1.BringToFront()
            If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                ToolStripStatusLabel3.Text = "Picturebox1 is over Picturebox 2"
            Else
                ToolStripStatusLabel3.Text = ""
            End If
        End If
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove, MyBase.MouseMove
        If (e.Button = MouseButtons.Left) Then
            PictureBox2.Top += (e.Y - posY)
            PictureBox2.Left += (e.X - posX)
            ToolStripStatusLabel1.Text = "Picturebox2: " & PictureBox2.Left & "," & PictureBox2.Top
            PictureBox2.BringToFront()
            If PictureBox2.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                ToolStripStatusLabel3.Text = "Picturebox2 is over Picturebox 1"
            Else
                ToolStripStatusLabel3.Text = ""
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.Cursor = Cursors.Default
    End Sub
End Class
