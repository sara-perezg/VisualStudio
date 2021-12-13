Public Class Trabajador

    Enum SueldoBase
        Obrero = 800
        Administrativo = 900
        Tecnico = 1000
        Profesional = 1200
    End Enum
    Public Property type As Integer
    Public Property sindicato As Boolean
    Public Property years As Integer
    Public Property hijos As Integer
    Public Property sueldo As Integer

    Public Sub calcularSueldo()
        If (sindicato) Then
            sueldo = sueldo + 50
        End If

        If years = 2 Then
            sueldo = sueldo + 100
        ElseIf years = 3 Then
            sueldo = sueldo + 200
        End If

        For i = 1 To hijos
            sueldo = sueldo + 100
        Next

    End Sub

End Class