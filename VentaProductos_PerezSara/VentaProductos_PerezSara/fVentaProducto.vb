Public Class fVentaProducto
    Dim listaProductos As New List(Of Producto)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaProductos.Add(New Producto("ARROZ X 500GR", 2))
        listaProductos.Add(New Producto("ACEITE X 1L", 5))
        listaProductos.Add(New Producto("LATA DE ATUN MARCA WYZ", 3))
        listaProductos.Add(New Producto("LATA DE TOMATE MARCA WYZ", 1))
        listaProductos.Add(New Producto("PAN X 1KG", 1))

    End Sub

    Private Sub LimpiaTextBox()

        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecioU.Clear()
        txtCantidad.Clear()
        txtPrecioTotal.Clear()

    End Sub

    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus
        If txtCantidad.Text <> "" And Val(txtCantidad.Text) > 0 Then
            Dim total As Double = Val(txtPrecioU.Text) * Val(txtCantidad.Text)
            txtPrecioTotal.Text = total.ToString
        End If
    End Sub

    Private Sub desactivaTextBox()
        txtDescripcion.Enabled = False
        txtPrecioU.Enabled = False
        txtPrecioTotal.Enabled = False
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        Try
            Dim codigo As String = txtCodigo.Text.ToUpper

            For i = 0 To listaProductos.Count - 1 Step 1
                If codigo.Equals(listaProductos.Item(i).Codigo_Producto) Then
                    txtDescripcion.Text = listaProductos.Item(i).Descripcion_Producto
                    txtPrecioU.Text = listaProductos.Item(i).Precio_Producto
                    Exit For

                End If
            Next
        Catch ex As Exception
            MsgBox("El código ingresado no existe")
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgvProductos.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecioU.Text, txtCantidad.Text, txtPrecioTotal.Text)
    End Sub

    Private Sub btnVerTotales_Click(sender As Object, e As EventArgs) Handles btnVerTotales.Click
        Dim total As Double = 0
        For i = 0 To dgvProductos.Rows.Count - 1 Step 1
            total += dgvProductos.Rows.Item(i).Cells.Item(4).Value
        Next
        Dim subtotal As Double = total - (total * 0.21)
        Dim iva As Double = total * 0.21
        txtSubTotal.Text = subtotal.ToString
        txtIva.Text = iva.ToString
        txtTotal.Text = total.ToString
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiaTextBox()
    End Sub
End Class
