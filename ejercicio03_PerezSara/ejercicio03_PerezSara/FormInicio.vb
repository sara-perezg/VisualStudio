Public Class FormInicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrestamo.Click

        If txtBName.Text = "" Then
            ErrorProvider1.SetError(Me.txtBName, "No puede dejar el campo vacio")
        Else
            Dim prestamo = New FormPrestamo()
            prestamo.Show()
            Me.Hide()
        End If
    End Sub


End Class
