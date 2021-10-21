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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAzul = New System.Windows.Forms.RadioButton()
        Me.rbBlanco = New System.Windows.Forms.RadioButton()
        Me.rbVerde = New System.Windows.Forms.RadioButton()
        Me.rbNaranja = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbAbajo = New System.Windows.Forms.RadioButton()
        Me.rbArriba = New System.Windows.Forms.RadioButton()
        Me.txtBColores = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAzul)
        Me.GroupBox1.Controls.Add(Me.rbBlanco)
        Me.GroupBox1.Controls.Add(Me.rbVerde)
        Me.GroupBox1.Controls.Add(Me.rbNaranja)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 245)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colores"
        '
        'rbAzul
        '
        Me.rbAzul.AutoSize = True
        Me.rbAzul.Location = New System.Drawing.Point(23, 184)
        Me.rbAzul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbAzul.Name = "rbAzul"
        Me.rbAzul.Size = New System.Drawing.Size(61, 23)
        Me.rbAzul.TabIndex = 5
        Me.rbAzul.TabStop = True
        Me.rbAzul.Text = "Azul"
        Me.rbAzul.UseVisualStyleBackColor = True
        '
        'rbBlanco
        '
        Me.rbBlanco.AutoSize = True
        Me.rbBlanco.Location = New System.Drawing.Point(23, 144)
        Me.rbBlanco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbBlanco.Name = "rbBlanco"
        Me.rbBlanco.Size = New System.Drawing.Size(77, 23)
        Me.rbBlanco.TabIndex = 4
        Me.rbBlanco.TabStop = True
        Me.rbBlanco.Text = "Blanco"
        Me.rbBlanco.UseVisualStyleBackColor = True
        '
        'rbVerde
        '
        Me.rbVerde.AutoSize = True
        Me.rbVerde.Location = New System.Drawing.Point(23, 97)
        Me.rbVerde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbVerde.Name = "rbVerde"
        Me.rbVerde.Size = New System.Drawing.Size(71, 23)
        Me.rbVerde.TabIndex = 3
        Me.rbVerde.TabStop = True
        Me.rbVerde.Text = "Verde"
        Me.rbVerde.UseVisualStyleBackColor = True
        '
        'rbNaranja
        '
        Me.rbNaranja.AutoSize = True
        Me.rbNaranja.Location = New System.Drawing.Point(23, 49)
        Me.rbNaranja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbNaranja.Name = "rbNaranja"
        Me.rbNaranja.Size = New System.Drawing.Size(85, 23)
        Me.rbNaranja.TabIndex = 2
        Me.rbNaranja.TabStop = True
        Me.rbNaranja.Text = "Naranja"
        Me.rbNaranja.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbAbajo)
        Me.GroupBox2.Controls.Add(Me.rbArriba)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 302)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 198)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Posicion"
        '
        'rbAbajo
        '
        Me.rbAbajo.AutoSize = True
        Me.rbAbajo.Location = New System.Drawing.Point(23, 122)
        Me.rbAbajo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbAbajo.Name = "rbAbajo"
        Me.rbAbajo.Size = New System.Drawing.Size(71, 23)
        Me.rbAbajo.TabIndex = 5
        Me.rbAbajo.TabStop = True
        Me.rbAbajo.Text = "Abajo"
        Me.rbAbajo.UseVisualStyleBackColor = True
        '
        'rbArriba
        '
        Me.rbArriba.AutoSize = True
        Me.rbArriba.Location = New System.Drawing.Point(23, 69)
        Me.rbArriba.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbArriba.Name = "rbArriba"
        Me.rbArriba.Size = New System.Drawing.Size(74, 23)
        Me.rbArriba.TabIndex = 4
        Me.rbArriba.TabStop = True
        Me.rbArriba.Text = "Arriba"
        Me.rbArriba.UseVisualStyleBackColor = True
        '
        'txtBColores
        '
        Me.txtBColores.BackColor = System.Drawing.Color.Wheat
        Me.txtBColores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBColores.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtBColores.Location = New System.Drawing.Point(283, 36)
        Me.txtBColores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBColores.Multiline = True
        Me.txtBColores.Name = "txtBColores"
        Me.txtBColores.Size = New System.Drawing.Size(315, 192)
        Me.txtBColores.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(645, 575)
        Me.Controls.Add(Me.txtBColores)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents rbVerde As RadioButton
    Friend WithEvents rbNaranja As RadioButton
    Friend WithEvents rbAbajo As RadioButton
    Friend WithEvents rbArriba As RadioButton
    Friend WithEvents txtBColores As TextBox
End Class
