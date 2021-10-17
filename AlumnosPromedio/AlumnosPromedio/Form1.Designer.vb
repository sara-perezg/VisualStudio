<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promedio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBCantidad = New System.Windows.Forms.TextBox()
        Me.txtBPromedio = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Promedio"
        '
        'txtBCantidad
        '
        Me.txtBCantidad.Location = New System.Drawing.Point(212, 63)
        Me.txtBCantidad.Name = "txtBCantidad"
        Me.txtBCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtBCantidad.TabIndex = 2
        '
        'txtBPromedio
        '
        Me.txtBPromedio.Location = New System.Drawing.Point(212, 248)
        Me.txtBPromedio.Name = "txtBPromedio"
        Me.txtBPromedio.Size = New System.Drawing.Size(100, 22)
        Me.txtBPromedio.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(94, 160)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 36)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(226, 160)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 36)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(351, 160)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 36)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Promedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 346)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtBPromedio)
        Me.Controls.Add(Me.txtBCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Promedio"
        Me.Text = "Promedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBCantidad As TextBox
    Friend WithEvents txtBPromedio As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
End Class
