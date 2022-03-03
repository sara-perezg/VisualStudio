Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ComboBox1.Items.Clear() 'Borra todo los items que tenga el comboBox
            For Each fuentes As FontFamily In FontFamily.Families ' Instalar las fuentes que tenemos en nuestro pc
                Dim tipo As String  'Las fuentes se guardan en la variable tipo
                tipo = fuentes.Name
                ComboBox1.Items.Add(tipo) 'Va añadir las fuentes en el comboBox
            Next
            Try
                ComboBox1.Text = "Calibri" 'Fuente por defecto
            Catch ex As Exception
                ComboBox1.SelectedItem = 0 'Si da error que coloque la primera
            End Try
        Catch ex As Exception
        End Try
    End Sub
    'Nuevo    
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub
    'Guardar
    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        Dim MyStreamWriter As System.IO.StreamWriter
        save.Filter = "text (*.txt) |*.txt |Html(*.html*) |*.html|php(*.php*) | *.php*|All Files(*.*)|*.*"
        save.CheckFileExists = False
        save.Title = "Guardar como"
        save.ShowDialog(Me)
        Try
            MyStreamWriter = System.IO.File.AppendText(save.FileName)
            MyStreamWriter.Write(RichTextBox1.Text)
            MyStreamWriter.Flush()

        Catch ex As Exception
        End Try
    End Sub

    'Abrir
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog
        Dim MyStreamReader As System.IO.StreamReader
        Open.Filter = "text (*.txt)|*.txt|All Files(*.*)|*.*"
        Open.CheckFileExists = True
        Open.Title = "Abrir como"
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            MyStreamReader = System.IO.File.OpenText(Open.FileName)
            RichTextBox1.Text = MyStreamReader.ReadToEnd()

        Catch ex As Exception

        End Try
    End Sub


    'Salir
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    'copiar
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    'cortar
    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    'Pegar
    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    'Seleccionar todo
    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    'Deshacer
    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    'Rehacer
    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Dim negrita As Boolean = False
    Dim cursiva As Boolean = False


    'ComboBox1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If negrita = True Then
            RichTextBox1.SelectionFont = New Font(ComboBox1.SelectedItem.ToString, Int(txtSize.Text), FontStyle.Bold)
        Else
            RichTextBox1.SelectionFont = New Font(ComboBox1.SelectedItem.ToString, Int(txtSize.Text), FontStyle.Regular)
        End If
    End Sub
    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ComboBox1.DrawItem
        e.DrawBackground() 'Se produce cuando cambia la apariencia de un control

        'Este código sirve para que cada elemento del cmboBox tenga un estilo diferente, si es calibri que sea calibri...
        Dim texto As String = ComboBox1.Items(e.Index).ToString
        Dim fon As New Font(texto, e.Font.Size)
        e.Graphics.DrawString(texto, fon, New SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2)
        e.DrawFocusRectangle()
    End Sub
    'Negrita
    Private Sub lblNegrita_Click(sender As Object, e As EventArgs) Handles lblNegrita.Click
        If negrita = False Then
            'cuando seleccionamos un texto solo le apliquemos ese estilo de fuente
            RichTextBox1.SelectionFont = New Font(ComboBox1.Text, Int(txtSize.Text), FontStyle.Bold)
            lblNegrita.ForeColor = Color.Chocolate
            negrita = True
        Else
            RichTextBox1.SelectionFont = New Font(ComboBox1.Text, Int(txtSize.Text), FontStyle.Regular)
            lblNegrita.ForeColor = Color.White
            negrita = False
        End If
    End Sub
    'Cursiva
    Private Sub lblCursiva_Click(sender As Object, e As EventArgs) Handles lblCursiva.Click
        Try
            If cursiva = False Then
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, Int(txtSize.Text), FontStyle.Italic)
                lblCursiva.ForeColor = Color.Chocolate
                cursiva = True
            Else
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, Int(txtSize.Text), FontStyle.Regular)
                lblCursiva.ForeColor = Color.White
                cursiva = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    'TextBox tamaño fuente
    Private Sub txtSize_TextChanged(sender As Object, e As EventArgs) Handles txtSize.TextChanged
        Try
            If negrita = True Then
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, Int(txtSize.Text), FontStyle.Italic)
            Else
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, Int(txtSize.Text), FontStyle.Regular)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'PictureBox Color
    Private Sub pcColor_Click(sender As Object, e As EventArgs) Handles pcColor.Click
        Try
            Dim dig As ColorDialog = New ColorDialog
            dig.Color = RichTextBox1.SelectionColor

            If dig.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionColor = dig.Color

                pcColor.BackColor = dig.Color
            End If

        Catch ex As Exception
        End Try
    End Sub

    'TrackBar
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        lblTamanio.Text = TrackBar1.Value * 100 & "%"
        RichTextBox1.ZoomFactor = TrackBar1.Value
    End Sub

    'RichTextBox
    Dim estado As Integer = 0
    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        Try
            ComboBox1.Text = RichTextBox1.SelectionFont.Name
            txtSize.Text = RichTextBox1.SelectionFont.Size
            estado = RichTextBox1.SelectionFont.Style
            If estado = 0 Then
                lblNegrita.ForeColor = Color.White
                lblCursiva.ForeColor = Color.White
            ElseIf estado = 1 Then
                lblNegrita.ForeColor = Color.Chocolate
                lblCursiva.ForeColor = Color.White
            ElseIf estado = 2 Then
                lblNegrita.ForeColor = Color.White
                lblCursiva.ForeColor = Color.Chocolate

            End If
            pcColor.BackColor = RichTextBox1.SelectionColor
        Catch ex As Exception

        End Try
    End Sub


End Class
