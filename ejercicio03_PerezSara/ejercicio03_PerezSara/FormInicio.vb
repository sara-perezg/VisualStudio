Public Class FormInicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrestamo.Click

        If txtBName.Text.Contains("1") Or txtBName.Text.Contains("2") Or txtBName.Text.Contains("3") Or txtBName.Text.Contains("4") Or
        txtBName.Text.Contains("5") Or txtBName.Text.Contains("6") Or txtBName.Text.Contains("7") Or txtBName.Text.Contains("8") Or
            txtBName.Text.Contains("9") Or txtBName.Text.Contains("0") Then
            ErrorProvider1.SetError(Me.txtBName, "No puede contener numeros")

        ElseIf txtBName.Text = "" Then
            ErrorProvider1.SetError(Me.txtBName, "No puede dejar el campo vacio")
        Else
            Dim prestamo = New FormPrestamo()
            prestamo.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub txtBName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBName.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
