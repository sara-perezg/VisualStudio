<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNaranja = New System.Windows.Forms.RadioButton()
        Me.rbAmarillo = New System.Windows.Forms.RadioButton()
        Me.rbBlanco = New System.Windows.Forms.RadioButton()
        Me.rbAzul = New System.Windows.Forms.RadioButton()
        Me.rbArriba = New System.Windows.Forms.RadioButton()
        Me.rbAbajo = New System.Windows.Forms.RadioButton()
        Me.txtBColores = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAzul)
        Me.GroupBox1.Controls.Add(Me.rbBlanco)
        Me.GroupBox1.Controls.Add(Me.rbAmarillo)
        Me.GroupBox1.Controls.Add(Me.rbNaranja)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colores"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbAbajo)
        Me.GroupBox2.Controls.Add(Me.rbArriba)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 168)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Posicion"
        '
        'rbNaranja
        '
        Me.rbNaranja.AutoSize = True
        Me.rbNaranja.Location = New System.Drawing.Point(23, 41)
        Me.rbNaranja.Name = "rbNaranja"
        Me.rbNaranja.Size = New System.Drawing.Size(79, 21)
        Me.rbNaranja.TabIndex = 2
        Me.rbNaranja.TabStop = True
        Me.rbNaranja.Text = "Naranja"
        Me.rbNaranja.UseVisualStyleBackColor = True
        '
        'rbAmarillo
        '
        Me.rbAmarillo.AutoSize = True
        Me.rbAmarillo.Location = New System.Drawing.Point(23, 82)
        Me.rbAmarillo.Name = "rbAmarillo"
        Me.rbAmarillo.Size = New System.Drawing.Size(79, 21)
        Me.rbAmarillo.TabIndex = 3
        Me.rbAmarillo.TabStop = True
        Me.rbAmarillo.Text = "Amarillo"
        Me.rbAmarillo.UseVisualStyleBackColor = True
        '
        'rbBlanco
        '
        Me.rbBlanco.AutoSize = True
        Me.rbBlanco.Location = New System.Drawing.Point(23, 120)
        Me.rbBlanco.Name = "rbBlanco"
        Me.rbBlanco.Size = New System.Drawing.Size(72, 21)
        Me.rbBlanco.TabIndex = 4
        Me.rbBlanco.TabStop = True
        Me.rbBlanco.Text = "Blanco"
        Me.rbBlanco.UseVisualStyleBackColor = True
        '
        'rbAzul
        '
        Me.rbAzul.AutoSize = True
        Me.rbAzul.Location = New System.Drawing.Point(23, 155)
        Me.rbAzul.Name = "rbAzul"
        Me.rbAzul.Size = New System.Drawing.Size(56, 21)
        Me.rbAzul.TabIndex = 5
        Me.rbAzul.TabStop = True
        Me.rbAzul.Text = "Azul"
        Me.rbAzul.UseVisualStyleBackColor = True
        '
        'rbArriba
        '
        Me.rbArriba.AutoSize = True
        Me.rbArriba.Location = New System.Drawing.Point(23, 58)
        Me.rbArriba.Name = "rbArriba"
        Me.rbArriba.Size = New System.Drawing.Size(67, 21)
        Me.rbArriba.TabIndex = 4
        Me.rbArriba.TabStop = True
        Me.rbArriba.Text = "Arriba"
        Me.rbArriba.UseVisualStyleBackColor = True
        '
        'rbAbajo
        '
        Me.rbAbajo.AutoSize = True
        Me.rbAbajo.Location = New System.Drawing.Point(23, 103)
        Me.rbAbajo.Name = "rbAbajo"
        Me.rbAbajo.Size = New System.Drawing.Size(65, 21)
        Me.rbAbajo.TabIndex = 5
        Me.rbAbajo.TabStop = True
        Me.rbAbajo.Text = "Abajo"
        Me.rbAbajo.UseVisualStyleBackColor = True
        '
        'txtBColores
        '
        Me.txtBColores.BackColor = System.Drawing.Color.Wheat
        Me.txtBColores.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtBColores.Location = New System.Drawing.Point(299, 30)
        Me.txtBColores.Multiline = True
        Me.txtBColores.Name = "txtBColores"
        Me.txtBColores.Size = New System.Drawing.Size(315, 162)
        Me.txtBColores.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 484)
        Me.Controls.Add(Me.txtBColores)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Colores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbAzul As RadioButton
    Friend WithEvents rbBlanco As RadioButton
    Friend WithEvents rbAmarillo As RadioButton
    Friend WithEvents rbNaranja As RadioButton
    Friend WithEvents rbAbajo As RadioButton
    Friend WithEvents rbArriba As RadioButton
    Friend WithEvents txtBColores As TextBox
End Class
