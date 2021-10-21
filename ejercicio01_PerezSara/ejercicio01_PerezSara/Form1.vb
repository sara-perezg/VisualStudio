Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBColores.Location = New Point(220, 30)
    End Sub
    Private Sub rbNaranja_CheckedChanged(sender As Object, e As EventArgs) Handles rbNaranja.CheckedChanged
        txtBColores.BackColor = Color.Wheat
    End Sub
    Private Sub rbBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlanco.CheckedChanged
        txtBColores.BackColor = Color.White
    End Sub

    Private Sub rbAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rbAmarillo.CheckedChanged
        txtBColores.BackColor = Color.LightYellow
    End Sub

    Private Sub rbAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rbAzul.CheckedChanged
        txtBColores.BackColor = Color.LightBlue
    End Sub

    Private Sub rbArriba_CheckedChanged(sender As Object, e As EventArgs) Handles rbArriba.CheckedChanged
        txtBColores.Location = New Point(220, 30)

    End Sub

    Private Sub rbAbajo_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbajo.CheckedChanged
        txtBColores.Location = New Point(220, 220)
    End Sub
End Class
