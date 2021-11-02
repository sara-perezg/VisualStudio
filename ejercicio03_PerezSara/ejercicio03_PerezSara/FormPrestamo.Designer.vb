<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrestamo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.cbRaza = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.cbCuotas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConSolicitud = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(81, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido,"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblName.Location = New System.Drawing.Point(243, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 31)
        Me.lblName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbOrigen)
        Me.GroupBox1.Controls.Add(Me.cbRaza)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 133)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cbOrigen
        '
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Items.AddRange(New Object() {"La Comarca", "Mordor", "Isengar", "Moria", "Ciudad Bajo la Montaña"})
        Me.cbOrigen.Location = New System.Drawing.Point(132, 82)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(121, 24)
        Me.cbOrigen.TabIndex = 3
        '
        'cbRaza
        '
        Me.cbRaza.CausesValidation = False
        Me.cbRaza.FormattingEnabled = True
        Me.cbRaza.Items.AddRange(New Object() {"Hombre", "Elfo", "Enano", "Orco", "Troll"})
        Me.cbRaza.Location = New System.Drawing.Point(132, 28)
        Me.cbRaza.Name = "cbRaza"
        Me.cbRaza.Size = New System.Drawing.Size(121, 24)
        Me.cbRaza.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Lugar de Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Raza"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtMonto)
        Me.GroupBox2.Controls.Add(Me.cbCuotas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 133)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(170, 31)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(121, 22)
        Me.txtMonto.TabIndex = 3
        '
        'cbCuotas
        '
        Me.cbCuotas.FormattingEnabled = True
        Me.cbCuotas.Items.AddRange(New Object() {"6 meses", "9 meses", "12 meses", "24 meses", "32 meses"})
        Me.cbCuotas.Location = New System.Drawing.Point(170, 82)
        Me.cbCuotas.Name = "cbCuotas"
        Me.cbCuotas.Size = New System.Drawing.Size(121, 24)
        Me.cbCuotas.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cuotas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Monto del prestamo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label3.Location = New System.Drawing.Point(84, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Datos Personales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label4.Location = New System.Drawing.Point(419, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Detalles del prestamo"
        '
        'btnConSolicitud
        '
        Me.btnConSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConSolicitud.Location = New System.Drawing.Point(351, 352)
        Me.btnConSolicitud.Name = "btnConSolicitud"
        Me.btnConSolicitud.Size = New System.Drawing.Size(117, 56)
        Me.btnConSolicitud.TabIndex = 6
        Me.btnConSolicitud.Text = "Confirmar Solicitud"
        Me.btnConSolicitud.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(682, 409)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 32)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Volver"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ejercicio03_PerezSara.My.Resources.Resources.cropped_800_500_943385
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConSolicitud)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prestamos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConSolicitud As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cbOrigen As ComboBox
    Friend WithEvents cbRaza As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents cbCuotas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
