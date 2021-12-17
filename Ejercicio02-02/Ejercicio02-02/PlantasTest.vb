Public Class PlantasTest

    Public score As Integer
    Private Sub PlantasTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
        AnimalesTest1.Close()
        Form1.Close()
        HongosTest.Close()
        AnimalesTest2.Close()
    End Sub
    Private Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        AnimalesTest1.Show()
        Me.Hide()
    End Sub

    Private Sub Test1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem2.Click
        HongosTest.Show()
        Me.Hide()
    End Sub

    Private Sub Test2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem.Click
        AnimalesTest2.Show()
        Me.Hide()
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub btnCorregir_Click_1(sender As Object, e As EventArgs) Handles btnCorregir.Click
        If RadioButton1.Checked = True Then
            Form1.totalScore = Form1.totalScore + 1
        End If

        If RadioButton6.Checked = True Then
            Form1.totalScore = Form1.totalScore + 1
        End If
        If RadioButton8.Checked = True Then
            Form1.totalScore = Form1.totalScore + 1
        End If

        MsgBox("Test corregido, vuelva a la pantalla de inicio para ver su puntiacion")
    End Sub
End Class