Public Class Form1

    Public totalScore As Integer = 0

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
        PlantasTest.Close()
        AnimalesTest1.Close()
        HongosTest.Close()
        AnimalesTest2.Close()
    End Sub

    Private Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        AnimalesTest1.Show()
        Me.Hide()
    End Sub

    Private Sub Test2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem.Click
        AnimalesTest2.Show()
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

    Private Sub btnPuntuacion_Click(sender As Object, e As EventArgs) Handles btnPuntuacion.Click
        Dim msg As String = "Tu puntuacion total es " & Val(totalScore)
        MsgBox(msg)
    End Sub
End Class
