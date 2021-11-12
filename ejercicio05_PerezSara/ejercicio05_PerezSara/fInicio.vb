Imports System.IO

Public Class fInicio
    Dim nombre, dni, direccion, telefono, genero As String
    Dim validar, validarDni As Boolean
    Dim filaActual As Integer
    Dim separator As String = ";"
    Dim file As String = ".\datos.txt"

    Private Sub fInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim archivoLeer As StreamReader = New StreamReader(file)

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

        If validar = True Then
            validarDni = ValidarIdentificacion(dni)
            If validarDni = True Then
                dgvContactos.Rows.Add(nombre, dni, telefono, direccion, genero)
                MsgBox("El contacto se ha resgistrado")
                limpiar()
            End If
        End If

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

    Function ValidarIdentificacion(pardni As String) As Boolean
        validarDni = True
        For i = 0 To dgvContactos.RowCount - 1
            If pardni = dgvContactos.Rows(i).Cells("Column2").Value Then
                MsgBox("Ya existe un contacto con ese dni", MsgBoxStyle.Critical, "Informacion")
                ErrorProviderValidar.SetError(txtDNI, "Ingrese otro DNI")
                validar = False
                Exit For
            Else
                ErrorProviderValidar.SetError(txtDNI, "")
            End If
        Next
        Return validarDni

    End Function

    Private Sub limpiar()
        txtNombre.Clear()
        txtDNI.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        cbGenero.Text = ""
    End Sub

    Private Sub ActivarBotones()
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub DesactivarBotones()
        btnAgregar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub GuardarDatos()
        Dim archivoEscritura As StreamWriter
        Dim linea As String
        archivoEscritura = New StreamWriter(file)
        With dgvContactos
            For i = 0 To .RowCount - 1
                ' contatenacion de un string
                linea = .Rows(i).Cells("Column1").Value & separator &
                .Rows(i).Cells("Column2").Value & separator &
                .Rows(i).Cells("Column3").Value & separator &
                .Rows(i).Cells("Column4").Value & separator &
                .Rows(i).Cells("Column5").Value & separator

                archivoEscritura.WriteLine(linea)
            Next
            MsgBox("Los datos se han guardao correctamente")
        End With
        archivoEscritura.Close()
    End Sub

End Class
