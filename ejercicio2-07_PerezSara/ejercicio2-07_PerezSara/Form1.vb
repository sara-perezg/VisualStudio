Imports System.IO 'Para trabajar con archivos y carpetas
Imports System.Threading 'Para realizar pausas



Public Class Form1
    'Declaramos algunas variables que usaremos mas adelante
    '-----------------------------------------------------------
    Dim directoryPath As String = ""
    Dim nombreArchivo As String = ""
    Dim Ruta As String
    Dim txt As New TextBox
    Dim Misfiles As String()

    Dim Diferencia As Integer = 0
    Dim Restante As Integer = 0
    Dim Progreso As Integer = 0
    Dim Contador As Integer = 0

    Dim total As Integer = 0



    Private Sub btnCargarSolo_Click(sender As Object, e As EventArgs) Handles btnCargarSolo.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ruta = FolderBrowserDialog1.SelectedPath

            If Ruta.Length > 1 Then
                directoryPath = Ruta
                txt.Text = ""
            End If

        End If

        Misfiles = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories)

        ProgressBar1.Maximum = Misfiles.Length
        Dim cont As Integer = 0

        For Each s As String In Misfiles
            directoryPath = Path.GetDirectoryName(s) ' Capturamos la ruta
            nombreArchivo = Path.GetFileName(s)      ' Capturamos el nombre del archivo

            cont = cont + 1
            ProgressBar1.Value = cont

            txtArchivos.Text = txtArchivos.Text & nombreArchivo & vbNewLine
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Misfiles = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories)
        total = Misfiles.Length
        Contador = 0

        For Each s As String In Misfiles
            directoryPath = Path.GetDirectoryName(s) ' Capturamos la ruta
            nombreArchivo = Path.GetFileName(s)      ' Capturamos el nombre del archivo


            txt.Text = txt.Text & nombreArchivo & vbNewLine
            'Esta parte es sólo para informar del progreso

            Contador = Contador + 1
            Diferencia = total
            Restante = ((CInt(Diferencia) - Contador) / Diferencia) * 100
            Progreso = 100 - Restante

            BackgroundWorker1.ReportProgress(CInt(Progreso), "Running..." & Progreso.ToString)

            'Se ejecuta cuando cancelamos la operación
            '------------------------------------------------
            If BackgroundWorker1.CancellationPending Then
                e.Cancel = True
                Exit For
            End If
            '-------------------------------------------------


            Thread.Sleep(100) ' No es necesario, sólo lo uso para crear una leve pausa en el proceso
            '-------------------------------------------------------------------------------------------------
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        lbEstado.Text = e.ProgressPercentage & "% completado"
        lbEncontrados.Text = Contador
        txtArchivos.Text = txt.Text
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Cancelled Then
            MessageBox.Show("Tarea cancelada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Tarea completada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ruta = FolderBrowserDialog1.SelectedPath

            If Ruta.Length > 1 Then
                directoryPath = Ruta

                txt.Text = ""
                BackgroundWorker1.RunWorkerAsync()

            End If

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BackgroundWorker1.CancelAsync()
    End Sub
End Class


