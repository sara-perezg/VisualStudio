Public Class Form1

    Dim trabajador As New Trabajador
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        setSueldo()
        setSindicato()
        setYear()
        setHijos()
        trabajador.calcularSueldo()
        MsgBox("El sueldo del trabajador es " & trabajador.sueldo)
    End Sub

    Private Sub setSueldo()

        If rbObrero.Checked = True Then
            trabajador.sueldo = Trabajador.SueldoBase.Obrero
            trabajador.sueldo = Convert.ToInt32(Trabajador.SueldoBase.Obrero)
        ElseIf rbAdministrativo.Checked = True Then
            trabajador.sueldo = Trabajador.SueldoBase.Administrativo
            trabajador.sueldo = Convert.ToInt32(Trabajador.SueldoBase.Administrativo)
        ElseIf rbTecnico.Checked = True Then
            trabajador.sueldo = Trabajador.SueldoBase.Tecnico
            trabajador.sueldo = Convert.ToInt32(Trabajador.SueldoBase.Tecnico)
        ElseIf rbProfesional.Checked = True Then
            trabajador.sueldo = Trabajador.SueldoBase.Profesional
            trabajador.sueldo = Convert.ToInt32(Trabajador.SueldoBase.Profesional)
        End If
    End Sub

    Private Sub setSindicato()
        If rbSindicatoYes.Checked = True Then
            trabajador.sindicato = True
        Else
            trabajador.sindicato = False
        End If
    End Sub

    Private Sub setYear()
        If rb5to10years.Checked = True Then
            trabajador.years = 2
        ElseIf rb10years.Checked = True Then
            trabajador.years = 3
        Else
            trabajador.years = 1
        End If
    End Sub

    Private Sub setHijos()
        trabajador.hijos = dudHijos.Text
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        rbObrero.Checked = True
        rbSindicatoNo.Checked = True
        rb5years.Checked = True
        dudHijos.Text = 0
    End Sub
End Class
