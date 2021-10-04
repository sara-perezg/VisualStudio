<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoxNumero = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbBDividir = New System.Windows.Forms.ComboBox()
        Me.lblDividir = New System.Windows.Forms.Label()
        Me.cmBMultiplicar = New System.Windows.Forms.ComboBox()
        Me.lblMultiplicar = New System.Windows.Forms.Label()
        Me.cmbBResta = New System.Windows.Forms.ComboBox()
        Me.lblResta = New System.Windows.Forms.Label()
        Me.cmbBoxSuma = New System.Windows.Forms.ComboBox()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(586, 52)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 29)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(586, 165)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 29)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(586, 108)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(94, 29)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(38, 107)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(63, 20)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Numero"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoxNumero)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 241)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'txtBoxNumero
        '
        Me.txtBoxNumero.Location = New System.Drawing.Point(130, 108)
        Me.txtBoxNumero.Name = "txtBoxNumero"
        Me.txtBoxNumero.Size = New System.Drawing.Size(222, 27)
        Me.txtBoxNumero.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbBDividir)
        Me.GroupBox2.Controls.Add(Me.lblDividir)
        Me.GroupBox2.Controls.Add(Me.cmBMultiplicar)
        Me.GroupBox2.Controls.Add(Me.lblMultiplicar)
        Me.GroupBox2.Controls.Add(Me.cmbBResta)
        Me.GroupBox2.Controls.Add(Me.lblResta)
        Me.GroupBox2.Controls.Add(Me.cmbBoxSuma)
        Me.GroupBox2.Controls.Add(Me.lblSuma)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 181)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aritmetica"
        '
        'cmbBDividir
        '
        Me.cmbBDividir.FormattingEnabled = True
        Me.cmbBDividir.Location = New System.Drawing.Point(552, 91)
        Me.cmbBDividir.Name = "cmbBDividir"
        Me.cmbBDividir.Size = New System.Drawing.Size(151, 28)
        Me.cmbBDividir.TabIndex = 14
        '
        'lblDividir
        '
        Me.lblDividir.AutoSize = True
        Me.lblDividir.Location = New System.Drawing.Point(552, 68)
        Me.lblDividir.Name = "lblDividir"
        Me.lblDividir.Size = New System.Drawing.Size(53, 20)
        Me.lblDividir.TabIndex = 13
        Me.lblDividir.Text = "Dividir"
        '
        'cmBMultiplicar
        '
        Me.cmBMultiplicar.FormattingEnabled = True
        Me.cmBMultiplicar.Location = New System.Drawing.Point(377, 91)
        Me.cmBMultiplicar.Name = "cmBMultiplicar"
        Me.cmBMultiplicar.Size = New System.Drawing.Size(151, 28)
        Me.cmBMultiplicar.TabIndex = 12
        '
        'lblMultiplicar
        '
        Me.lblMultiplicar.AutoSize = True
        Me.lblMultiplicar.Location = New System.Drawing.Point(377, 68)
        Me.lblMultiplicar.Name = "lblMultiplicar"
        Me.lblMultiplicar.Size = New System.Drawing.Size(80, 20)
        Me.lblMultiplicar.TabIndex = 11
        Me.lblMultiplicar.Text = "Multiplicar"
        '
        'cmbBResta
        '
        Me.cmbBResta.FormattingEnabled = True
        Me.cmbBResta.Location = New System.Drawing.Point(201, 91)
        Me.cmbBResta.Name = "cmbBResta"
        Me.cmbBResta.Size = New System.Drawing.Size(151, 28)
        Me.cmbBResta.TabIndex = 10
        '
        'lblResta
        '
        Me.lblResta.AutoSize = True
        Me.lblResta.Location = New System.Drawing.Point(201, 68)
        Me.lblResta.Name = "lblResta"
        Me.lblResta.Size = New System.Drawing.Size(45, 20)
        Me.lblResta.TabIndex = 9
        Me.lblResta.Text = "Resta"
        '
        'cmbBoxSuma
        '
        Me.cmbBoxSuma.FormattingEnabled = True
        Me.cmbBoxSuma.Location = New System.Drawing.Point(22, 91)
        Me.cmbBoxSuma.Name = "cmbBoxSuma"
        Me.cmbBoxSuma.Size = New System.Drawing.Size(151, 28)
        Me.cmbBoxSuma.TabIndex = 8
        '
        'lblSuma
        '
        Me.lblSuma.AutoSize = True
        Me.lblSuma.Location = New System.Drawing.Point(22, 68)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(46, 20)
        Me.lblSuma.TabIndex = 4
        Me.lblSuma.Text = "Suma"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBoxNumero As TextBox
    Friend WithEvents cmbBDividir As ComboBox
    Friend WithEvents lblDividir As Label
    Friend WithEvents cmBMultiplicar As ComboBox
    Friend WithEvents lblMultiplicar As Label
    Friend WithEvents cmbBResta As ComboBox
    Friend WithEvents lblResta As Label
    Friend WithEvents cmbBoxSuma As ComboBox
    Friend WithEvents lblSuma As Label
End Class
