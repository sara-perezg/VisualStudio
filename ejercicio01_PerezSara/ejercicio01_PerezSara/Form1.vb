Public Class Form1
    Dim posTop = New Point(290, 40)
    Dim posDown = New Point(290, 300)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el textBox en la posicion inicial arriba
        txtBColores.Location = posTop
    End Sub
    Private Sub rbNaranja_CheckedChanged(sender As Object, e As EventArgs) Handles rbNaranja.CheckedChanged
        txtBColores.BackColor = Color.Wheat
    End Sub
    Private Sub rbBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlanco.CheckedChanged
        txtBColores.BackColor = Color.White
    End Sub

    Private Sub rbVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rbVerde.CheckedChanged
        txtBColores.BackColor = Color.LightGreen
    End Sub

    Private Sub rbAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rbAzul.CheckedChanged
        txtBColores.BackColor = Color.LightBlue
    End Sub

    Private Sub rbArriba_CheckedChanged(sender As Object, e As EventArgs) Handles rbArriba.CheckedChanged
        txtBColores.Location = posTop

    End Sub

    Private Sub rbAbajo_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbajo.CheckedChanged
        txtBColores.Location = posDown
    End Sub
End Class
