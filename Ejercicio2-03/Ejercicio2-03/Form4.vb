Public Class Form4
    Dim ofd As New OpenFileDialog
    Dim ruta As String
    Sub abrir()
        ofd.Filter = "Musica en MP3 | *.mp3;"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = ofd.FileName
            Form1.AxWindowsMediaPlayer1.URL = ruta
            Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
            ListBox1.Items.Add(ruta)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        abrir()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Form1.AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem.ToString
        Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo de texto | *.txt"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(save.FileName)
            For Each item In ListBox1.Items
                sw.WriteLine(item.ToString)
            Next
            sw.Close()
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim stRuta As String = ""
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Text(*.Text*.txt|*.Text;*.txt|Todos los archivos(*.*)|*.*)"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyMusic
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                stRuta = .FileName
            End If
        End With
        Dim sr As New System.IO.StreamReader(stRuta)
        While Not sr.EndOfStream
            ListBox1.Items.Add(sr.ReadLine())
        End While
        sr.Close()
    End Sub
End Class
