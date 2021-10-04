Public Class Form1

    Private Sub limpiar()
        cmbBoxSuma.Items.Clear()
        cmbBResta.Items.Clear()
        cmBMultiplicar.Items.Clear()
        cmbBDividir.Items.Clear()
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        limpiar()
        Dim num, suma, resta, multi As Integer
        Dim div As Double
        num = Val(txtBoxNumero.Text)


        For i = 1 To 10 Step 1
            suma = num + i
            resta = num - i
            multi = num * i
            div = num / i
            cmbBoxSuma.Items.Add(num & "+" & i & "=" & suma)
            cmbBResta.Items.Add(num & "-" & i & "=" & resta)
            cmBMultiplicar.Items.Add(num & "*" & i & "=" & multi)
            cmbBDividir.Items.Add(num & "/" & i & "=" & div)

        Next

    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtBoxNumero.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
