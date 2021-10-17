<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBStockInicial = New System.Windows.Forms.TextBox()
        Me.txtBStock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadPersona = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnRepartir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Inicial"
        '
        'txtBStockInicial
        '
        Me.txtBStockInicial.Location = New System.Drawing.Point(175, 64)
        Me.txtBStockInicial.Name = "txtBStockInicial"
        Me.txtBStockInicial.Size = New System.Drawing.Size(100, 22)
        Me.txtBStockInicial.TabIndex = 1
        '
        'txtBStock
        '
        Me.txtBStock.Location = New System.Drawing.Point(175, 201)
        Me.txtBStock.Name = "txtBStock"
        Me.txtBStock.Size = New System.Drawing.Size(100, 22)
        Me.txtBStock.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stock"
        '
        'txtCantidadPersona
        '
        Me.txtCantidadPersona.Location = New System.Drawing.Point(175, 264)
        Me.txtCantidadPersona.Name = "txtCantidadPersona"
        Me.txtCantidadPersona.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidadPersona.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad Personas"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(65, 138)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 35)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnRepartir
        '
        Me.btnRepartir.Location = New System.Drawing.Point(188, 138)
        Me.btnRepartir.Name = "btnRepartir"
        Me.btnRepartir.Size = New System.Drawing.Size(75, 35)
        Me.btnRepartir.TabIndex = 7
        Me.btnRepartir.Text = "Repartir"
        Me.btnRepartir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(300, 138)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 35)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 358)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRepartir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtCantidadPersona)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBStock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBStockInicial)
        Me.Controls.Add(Me.Label1)
        Me.Name = "stock"
        Me.Text = "Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBStockInicial As TextBox
    Friend WithEvents txtBStock As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidadPersona As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRepartir As Button
    Friend WithEvents btnSalir As Button
End Class
