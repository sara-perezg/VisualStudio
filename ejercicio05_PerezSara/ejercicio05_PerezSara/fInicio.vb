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

        validar = ValidarDatos(nombre, dni, telefono, direccion, genero)

    End Sub

    Function ValidarDatos(parnombre As String, pardni As String, partelefono As String, pardireccion As String, pargenero As String) As Boolean
        Dim titleMsgBox As String = "Informacion"

        validar = False
        If parnombre = "" Then
            MsgBox("Ingrese el nombre", MsgBoxStyle.Critical, titleMsgBox)
            ErrorProviderValidar.SetError(txtNombre, "Ingrese nombre")
        ElseIf pardni = "" Then
            MsgBox("Ingrese el DNI", MsgBoxStyle.Critical, titleMsgBox)
            ErrorProviderValidar.SetError(txtDNI, "Ingrese DNI")
        ElseIf partelefono = "" Then
            MsgBox("Ingresse el Telefono", MsgBoxStyle.Critical, titleMsgBox)
            ErrorProviderValidar.SetError(txtTelefono, "Ingrese telefono")
        ElseIf pardireccion = "" Then
            MsgBox("Ingresse el Direccion", MsgBoxStyle.Critical, titleMsgBox)
            ErrorProviderValidar.SetError(txtDireccion, "Ingrese telefono")
        ElseIf pargenero = "" Then
            MsgBox("Ingresse el Genero", MsgBoxStyle.Critical, titleMsgBox)
            ErrorProviderValidar.SetError(cbGenero, "Ingrese telefono")
        Else
            validar = True
            ErrorProviderValidar.SetError(txtNombre, "")
            ErrorProviderValidar.SetError(txtDireccion, "")
            ErrorProviderValidar.SetError(txtDNI, "")
            ErrorProviderValidar.SetError(txtTelefono, "")
            ErrorProviderValidar.SetError(cbGenero, "")
        End If

        Return validar
    End Function

End Class
