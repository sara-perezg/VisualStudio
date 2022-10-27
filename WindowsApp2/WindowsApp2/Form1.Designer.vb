<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCargarSolo = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtArchivos = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbEncontrados = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCargarSolo
        '
        Me.btnCargarSolo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCargarSolo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarSolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarSolo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarSolo.Location = New System.Drawing.Point(511, 12)
        Me.btnCargarSolo.Name = "btnCargarSolo"
        Me.btnCargarSolo.Size = New System.Drawing.Size(209, 99)
        Me.btnCargarSolo.TabIndex = 0
        Me.btnCargarSolo.Text = "Cargar sin backGroundWorker"
        Me.btnCargarSolo.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.Location = New System.Drawing.Point(36, 87)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(393, 24)
        Me.ProgressBar1.TabIndex = 1
        '
        'txtArchivos
        '
        Me.txtArchivos.Location = New System.Drawing.Point(36, 165)
        Me.txtArchivos.Multiline = True
        Me.txtArchivos.Name = "txtArchivos"
        Me.txtArchivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArchivos.Size = New System.Drawing.Size(393, 232)
        Me.txtArchivos.TabIndex = 2
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbEstado.Location = New System.Drawing.Point(508, 165)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(106, 23)
        Me.lbEstado.TabIndex = 3
        Me.lbEstado.Text = "Estado: 0%"
        '
        'lbEncontrados
        '
        Me.lbEncontrados.AutoSize = True
        Me.lbEncontrados.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEncontrados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbEncontrados.Location = New System.Drawing.Point(508, 203)
        Me.lbEncontrados.Name = "lbEncontrados"
        Me.lbEncontrados.Size = New System.Drawing.Size(224, 23)
        Me.lbEncontrados.TabIndex = 4
        Me.lbEncontrados.Text = "Archivos encontrados: 0"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSeleccionar.Location = New System.Drawing.Point(36, 12)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(183, 49)
        Me.btnSeleccionar.TabIndex = 5
        Me.btnSeleccionar.Text = "Seleccionar carpeta"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCancelar.Location = New System.Drawing.Point(247, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(182, 49)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar operación"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(763, 444)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lbEncontrados)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.txtArchivos)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnCargarSolo)
        Me.Name = "Form1"
        Me.Text = "Barra de progreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCargarSolo As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtArchivos As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbEncontrados As Label
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnCancelar As Button
End Class
