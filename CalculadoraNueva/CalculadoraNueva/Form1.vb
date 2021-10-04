Public Class Form1

    Private Sub limpiar()
        cmbBoxSuma.Items.Clear()
        cmbBResta.Items.Clear()
        cmBMultiplicar.Items.Clear()
        cmbBDividir.Items.Clear()
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click


        Dim num As Integer
        num = Val(txtBoxNumero.Text)
        limpiar()

        For i = 1 To 10 Step 1

            cmbBoxSuma.Items.Add(num & "+" & i & "=" & num + i)
            cmbBResta.Items.Add(num & "-" & i & "=" & num - i)
            cmBMultiplicar.Items.Add(num & "*" & i & "=" & num * i)
            cmbBDividir.Items.Add(num & "/" & i & "=" & num / i)

        Next

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtBoxNumero.Clear()
        limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
