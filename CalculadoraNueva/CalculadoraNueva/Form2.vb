Public Class Form2

    Private Sub calcular(n1 As Integer, n2 As Integer, operacion As String)

        Dim resultado As Double

        Select Case operacion
            Case "s"
                resultado = n1 + n2
            Case "m"
                resultado = n1 * n2
            Case "r"
                resultado = n1 - n2
            Case "d"
                resultado = n1 / n2
        End Select
    End Sub

End Class