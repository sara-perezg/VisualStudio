Public Class FormPrestamo
    Private Sub FormPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = FormInicio.txtBName.Text

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormInicio.Show()
    End Sub

    Private Sub btnConSolicitud_Click(sender As Object, e As EventArgs) Handles btnConSolicitud.Click
        Me.Hide()
        FormSolucion.Show()
    End Sub
End Class