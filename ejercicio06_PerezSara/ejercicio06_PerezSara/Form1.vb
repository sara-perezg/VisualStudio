Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ListBox1.Items.Add(txtNombre.Text)
        txtNombre.Text = ""
        txtNombre.Focus()

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

        ' Declaramos la variable guardar como nuevo cuadro de diálogo
        ' La variable guardar va a ser un archivo de texto
        ' Condición, utilzamos el sistema windows para realizar el cuadro de diálogo de guardar.
        ' En la variable sw se guardará lo que escribamos y con for each guardamos cada línea de texto en en el txt

        Dim guardar As New SaveFileDialog
        guardar.Filter = "Archivo Text | *.txt"
        If guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(guardar.FileName)

            For Each item In ListBox1.Items
                sw.WriteLine(item.ToString())
            Next

            sw.Close()
        End If

        Dim respuesta As MsgBoxResult
        respuesta = MessageBox.Show("¿Desea limpiar la lista", "Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = vbYes Then
            ListBox1.Items.Clear()
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim ruta As String = ""
        Dim abrirFD As New OpenFileDialog()
        With abrirFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Text(*.Txt*.txt)|*.Txt;*txt|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = .FileName
            End If
        End With
        Dim sr As New System.IO.StreamReader(ruta)
        While Not sr.EndOfStream
            ListBox1.Items.Add(sr.ReadLine())
        End While
        sr.Close()


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    'Es opcional
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnAdd.PerformClick()
        End If
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim I As String
        I = ListBox1.SelectedItem
        If ListBox1.SelectedItem = "Star Wars 1" Then
            PictureBox1.Image = My.Resources.img1
        End If
        If ListBox1.SelectedItem = "Star Wars 2" Then
            PictureBox1.Image = My.Resources.img4
        End If
        If ListBox1.SelectedItem = "Pulp Fiction" Then
            PictureBox1.Image = My.Resources.img2
        End If
        If ListBox1.SelectedItem = "Motel" Then
            PictureBox1.Image = My.Resources.img3
        End If
    End Sub
End Class
