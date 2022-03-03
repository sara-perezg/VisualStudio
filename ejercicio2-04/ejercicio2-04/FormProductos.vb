Public Class FormProductos
    Dim a As Integer

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 1
        If a = 2 Then
            PictureBox1.Image = My.Resources.portatil1
            Label1.Visible = True
            Label1.Text = "portatil 1"
        End If
        If a = 3 Then
            PictureBox1.Image = My.Resources.portatil2
            Label1.Visible = True
            Label1.Text = "portatil 2"

        End If
        If a = 4 Then
            PictureBox1.Image = My.Resources.portatil3
            Label1.Visible = True
            Label1.Text = "portatil 3"

        End If
        If a = 5 Then
            PictureBox1.Image = My.Resources.portatil4
            Label1.Visible = True
            Label1.Text = "portatil 4"
        End If
        If a = 6 Then
            PictureBox1.Image = My.Resources.portatil5
            Label1.Visible = True
            Label1.Text = "portatil 5"
        End If



    End Sub

End Class