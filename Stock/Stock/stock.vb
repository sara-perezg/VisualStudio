Public Class stock

    Dim personas As Integer = 0
    Dim cantidadTotalPedida As Integer = 0
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnRepartir_Click(sender As Object, e As EventArgs) Handles btnRepartir.Click
        Dim stock As Integer = Val(txtBStock.Text)
        Dim stockInicial As Integer = Val(txtBStockInicial.Text)
        Dim cantidadPedida As String


        cantidadPedida = InputBox("Ingrese la cantidad", "Reparto", "cantidad")
        cantidadTotalPedida += cantidadPedida
        stock = stockInicial - cantidadTotalPedida

        If (stock < 10) Or (stock < 0) Then
            MessageBox.Show("No se pueden hacer más pedidos")
        Else
            txtBStock.Text = stock
            personas += 1
            txtCantidadPersona.Text = personas
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        personas = 0
        cantidadTotalPedida = 0
        txtCantidadPersona.Clear()
        txtBStockInicial.Clear()
        txtBStock.Clear()
    End Sub
End Class
