Imports System.IO

Public Class fInicio
    Dim nombre, dni, direccion, telefono, genero As String
    Dim validar, validarDNi As Boolean
    Dim filaActual As Integer
    Dim separator As String = ";"

    Private Sub fInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim archivoLeer As StreamReader = New StreamReader(".\datos.txt")

        While Not archivoLeer.EndOfStream
            Dim cadena As String = archivoLeer.ReadLine
            Dim leer As String() = cadena.Split(New Char() {separator})
            dgvContactos.Rows.Add(leer)
        End While
        archivoLeer.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        nombre = txtNombre.Text
        dni = txtDNI.Text
        telefono = txtTelefono.Text
        direccion = txtDireccion.Text
        genero = cbGenero.Text


    End Sub

End Class
