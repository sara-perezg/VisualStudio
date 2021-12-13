Public Class Form1

    Dim trabajador As New Trabajador
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        setSueldo()
        MsgBox(trabajador.sueldo)
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
        End If
    End Sub

    Private Sub setYear()

    End Sub

    Private Sub setHijos()

    End Sub

End Class
