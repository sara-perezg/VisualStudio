Public Class Promedio

    Dim notaTotal As Integer = 0
    Dim promedio As Double
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim cantidad As Integer = Val(txtBCantidad.Text)
        Dim ingresar As String

        For i = 1 To cantidad
            ingresar = InputBox("Ingresa la nota del alumno", "Ingresar", "nota")
            notaTotal += Val(ingresar)
        Next

        promedio = notaTotal / cantidad
        txtBPromedio.Text = promedio

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        promedio = 0
        notaTotal = 0
        txtBCantidad.Clear()
        txtBPromedio.Clear()
    End Sub

End Class
