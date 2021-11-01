Public Class FormPrestamo
    Dim iRaza1 As Double = 0.1
    Dim iRaza2 As Double = 0.15
    Dim iLugar As Integer = 95
    Dim solucion As Double
    Private Sub FormPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = FormInicio.txtBName.Text

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormInicio.Show()
    End Sub

    Private Sub btnConSolicitud_Click(sender As Object, e As EventArgs) Handles btnConSolicitud.Click
        Dim monto = Val(txtMonto.Text)

        If cbRaza.Text = "Hombre" Or cbRaza.Text = "Elfo" Or cbRaza.Text = "Enano" Then
            solucion = monto + monto * iRaza1
        Else
            solucion = monto + monto * iRaza2
        End If

        If cbOrigen.Text = "La Comarca" Or cbOrigen.Text = "Mordor" Then
            solucion = solucion + 95
        End If

        If cbCuotas.Text = "6 meses" Then
            solucion = solucion / 6
        ElseIf cbCuotas.Text = "9 meses" Then
            solucion = solucion / 9
        ElseIf cbCuotas.Text = "12 meses" Then
            solucion = solucion / 12
        ElseIf cbCuotas.Text = "24 meses" Then
            solucion = solucion / 24
        ElseIf cbCuotas.Text = "32 meses" Then
            solucion = solucion / 32
        End If

        FormSolucion.txtBSolucion.Text = solucion

        Me.Hide()
        FormSolucion.Show()
    End Sub


End Class