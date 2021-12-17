Public Class AnimalesTest2

    Public score As Integer
    Private Sub AnimalesTest2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
        PlantasTest.Close()
        Form1.Close()
        HongosTest.Close()
        AnimalesTest1.Close()
    End Sub
    Private Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        AnimalesTest1.Show()
        Me.Hide()
    End Sub

    Private Sub Test1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem1.Click
        PlantasTest.Show()
        Me.Hide()
    End Sub

    Private Sub Test1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem2.Click
        HongosTest.Show()
        Me.Hide()
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCorregir_Click_1(sender As Object, e As EventArgs) Handles btnCorregir.Click
        If RadioButton1.Checked = True Then
            Form1.totalScore = Form1.totalScore + 1
            RadioButton1.ForeColor = Color.Green
        End If

        If RadioButton6.Checked = True Then
            Form1.totalScore = Form1.totalScore + 1
            RadioButton6.ForeColor = Color.Green
        End If
        If RadioButton8.Checked = True Then
            Form1.totalScore = Form1.totalScore + 1
            RadioButton8.ForeColor = Color.Green
        End If

        MsgBox("Test corregido, vuelva a la pantalla de inicio para ver su puntiacion")
    End Sub
End Class