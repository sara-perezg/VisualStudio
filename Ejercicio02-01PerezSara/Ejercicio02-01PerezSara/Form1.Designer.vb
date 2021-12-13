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
        Me.gbClase = New System.Windows.Forms.GroupBox()
        Me.rbProfesional = New System.Windows.Forms.RadioButton()
        Me.rbTecnico = New System.Windows.Forms.RadioButton()
        Me.rbAdministrativo = New System.Windows.Forms.RadioButton()
        Me.rbObrero = New System.Windows.Forms.RadioButton()
        Me.gbYears = New System.Windows.Forms.GroupBox()
        Me.rb10years = New System.Windows.Forms.RadioButton()
        Me.rb5to10years = New System.Windows.Forms.RadioButton()
        Me.rb5years = New System.Windows.Forms.RadioButton()
        Me.gbSindicato = New System.Windows.Forms.GroupBox()
        Me.rbSindicatoNo = New System.Windows.Forms.RadioButton()
        Me.rbSindicatoYes = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dudHijos = New System.Windows.Forms.DomainUpDown()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbClase.SuspendLayout()
        Me.gbYears.SuspendLayout()
        Me.gbSindicato.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbClase
        '
        Me.gbClase.Controls.Add(Me.rbProfesional)
        Me.gbClase.Controls.Add(Me.rbTecnico)
        Me.gbClase.Controls.Add(Me.rbAdministrativo)
        Me.gbClase.Controls.Add(Me.rbObrero)
        Me.gbClase.Location = New System.Drawing.Point(44, 63)
        Me.gbClase.Name = "gbClase"
        Me.gbClase.Size = New System.Drawing.Size(211, 277)
        Me.gbClase.TabIndex = 0
        Me.gbClase.TabStop = False
        Me.gbClase.Text = "Clase Trabajador"
        '
        'rbProfesional
        '
        Me.rbProfesional.AutoSize = True
        Me.rbProfesional.Location = New System.Drawing.Point(32, 193)
        Me.rbProfesional.Name = "rbProfesional"
        Me.rbProfesional.Size = New System.Drawing.Size(100, 21)
        Me.rbProfesional.TabIndex = 3
        Me.rbProfesional.TabStop = True
        Me.rbProfesional.Text = "Profesional"
        Me.rbProfesional.UseVisualStyleBackColor = True
        '
        'rbTecnico
        '
        Me.rbTecnico.AutoSize = True
        Me.rbTecnico.Location = New System.Drawing.Point(32, 147)
        Me.rbTecnico.Name = "rbTecnico"
        Me.rbTecnico.Size = New System.Drawing.Size(79, 21)
        Me.rbTecnico.TabIndex = 2
        Me.rbTecnico.TabStop = True
        Me.rbTecnico.Text = "Tecnico"
        Me.rbTecnico.UseVisualStyleBackColor = True
        '
        'rbAdministrativo
        '
        Me.rbAdministrativo.AutoSize = True
        Me.rbAdministrativo.Location = New System.Drawing.Point(32, 101)
        Me.rbAdministrativo.Name = "rbAdministrativo"
        Me.rbAdministrativo.Size = New System.Drawing.Size(117, 21)
        Me.rbAdministrativo.TabIndex = 1
        Me.rbAdministrativo.TabStop = True
        Me.rbAdministrativo.Text = "Administrativo"
        Me.rbAdministrativo.UseVisualStyleBackColor = True
        '
        'rbObrero
        '
        Me.rbObrero.AutoSize = True
        Me.rbObrero.Checked = True
        Me.rbObrero.Location = New System.Drawing.Point(32, 55)
        Me.rbObrero.Name = "rbObrero"
        Me.rbObrero.Size = New System.Drawing.Size(74, 21)
        Me.rbObrero.TabIndex = 0
        Me.rbObrero.TabStop = True
        Me.rbObrero.Text = "Obrero"
        Me.rbObrero.UseVisualStyleBackColor = True
        '
        'gbYears
        '
        Me.gbYears.Controls.Add(Me.rb10years)
        Me.gbYears.Controls.Add(Me.rb5to10years)
        Me.gbYears.Controls.Add(Me.rb5years)
        Me.gbYears.Location = New System.Drawing.Point(571, 63)
        Me.gbYears.Name = "gbYears"
        Me.gbYears.Size = New System.Drawing.Size(193, 277)
        Me.gbYears.TabIndex = 1
        Me.gbYears.TabStop = False
        Me.gbYears.Text = "Años de Servicio"
        '
        'rb10years
        '
        Me.rb10years.AutoSize = True
        Me.rb10years.Location = New System.Drawing.Point(37, 193)
        Me.rb10years.Name = "rb10years"
        Me.rb10years.Size = New System.Drawing.Size(130, 21)
        Me.rb10years.TabIndex = 7
        Me.rb10years.TabStop = True
        Me.rb10years.Text = "Más de 10 años"
        Me.rb10years.UseVisualStyleBackColor = True
        '
        'rb5to10years
        '
        Me.rb5to10years.AutoSize = True
        Me.rb5to10years.Location = New System.Drawing.Point(37, 124)
        Me.rb5to10years.Name = "rb5to10years"
        Me.rb5to10years.Size = New System.Drawing.Size(141, 21)
        Me.rb5to10years.TabIndex = 6
        Me.rb5to10years.TabStop = True
        Me.rb5to10years.Text = "Entre 5 y 10 años"
        Me.rb5to10years.UseVisualStyleBackColor = True
        '
        'rb5years
        '
        Me.rb5years.AutoSize = True
        Me.rb5years.Checked = True
        Me.rb5years.Location = New System.Drawing.Point(37, 55)
        Me.rb5years.Name = "rb5years"
        Me.rb5years.Size = New System.Drawing.Size(122, 21)
        Me.rb5years.TabIndex = 5
        Me.rb5years.TabStop = True
        Me.rb5years.Text = "Más de 5 años"
        Me.rb5years.UseVisualStyleBackColor = True
        '
        'gbSindicato
        '
        Me.gbSindicato.Controls.Add(Me.rbSindicatoNo)
        Me.gbSindicato.Controls.Add(Me.rbSindicatoYes)
        Me.gbSindicato.Location = New System.Drawing.Point(293, 63)
        Me.gbSindicato.Name = "gbSindicato"
        Me.gbSindicato.Size = New System.Drawing.Size(226, 277)
        Me.gbSindicato.TabIndex = 1
        Me.gbSindicato.TabStop = False
        Me.gbSindicato.Text = "Inscrito en un Sindicato"
        '
        'rbSindicatoNo
        '
        Me.rbSindicatoNo.AutoSize = True
        Me.rbSindicatoNo.Checked = True
        Me.rbSindicatoNo.Location = New System.Drawing.Point(56, 147)
        Me.rbSindicatoNo.Name = "rbSindicatoNo"
        Me.rbSindicatoNo.Size = New System.Drawing.Size(47, 21)
        Me.rbSindicatoNo.TabIndex = 5
        Me.rbSindicatoNo.TabStop = True
        Me.rbSindicatoNo.Text = "No"
        Me.rbSindicatoNo.UseVisualStyleBackColor = True
        '
        'rbSindicatoYes
        '
        Me.rbSindicatoYes.AutoSize = True
        Me.rbSindicatoYes.Location = New System.Drawing.Point(56, 80)
        Me.rbSindicatoYes.Name = "rbSindicatoYes"
        Me.rbSindicatoYes.Size = New System.Drawing.Size(41, 21)
        Me.rbSindicatoYes.TabIndex = 4
        Me.rbSindicatoYes.Text = "Si"
        Me.rbSindicatoYes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de hijos"
        '
        'dudHijos
        '
        Me.dudHijos.Location = New System.Drawing.Point(190, 372)
        Me.dudHijos.Name = "dudHijos"
        Me.dudHijos.Size = New System.Drawing.Size(120, 22)
        Me.dudHijos.TabIndex = 3
        Me.dudHijos.Text = "0"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(412, 392)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(82, 34)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(545, 392)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 34)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(678, 392)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 34)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dudHijos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbYears)
        Me.Controls.Add(Me.gbSindicato)
        Me.Controls.Add(Me.gbClase)
        Me.Name = "Form1"
        Me.Text = "Salario"
        Me.gbClase.ResumeLayout(False)
        Me.gbClase.PerformLayout()
        Me.gbYears.ResumeLayout(False)
        Me.gbYears.PerformLayout()
        Me.gbSindicato.ResumeLayout(False)
        Me.gbSindicato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbClase As GroupBox
    Friend WithEvents rbProfesional As RadioButton
    Friend WithEvents rbTecnico As RadioButton
    Friend WithEvents rbAdministrativo As RadioButton
    Friend WithEvents rbObrero As RadioButton
    Friend WithEvents gbYears As GroupBox
    Friend WithEvents rb10years As RadioButton
    Friend WithEvents rb5to10years As RadioButton
    Friend WithEvents rb5years As RadioButton
    Friend WithEvents gbSindicato As GroupBox
    Friend WithEvents rbSindicatoNo As RadioButton
    Friend WithEvents rbSindicatoYes As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dudHijos As DomainUpDown
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
