<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVentaProducto
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnVerTotales = New System.Windows.Forms.Button()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtPrecioTotal)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPrecioU)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(544, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar productos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Precio total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Precio Unidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Código"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(150, 82)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 24)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(36, 82)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 24)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(427, 54)
        Me.txtPrecioTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtPrecioTotal.TabIndex = 9
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(364, 54)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(49, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'txtPrecioU
        '
        Me.txtPrecioU.Location = New System.Drawing.Point(276, 54)
        Me.txtPrecioU.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(76, 20)
        Me.txtPrecioU.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 54)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(130, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(36, 54)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvProductos)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 154)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(544, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos agregados"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnVerTotales)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.txtIva)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 358)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(544, 122)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SubTotal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "IVA 21%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(410, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Total"
        '
        'btnVerTotales
        '
        Me.btnVerTotales.Location = New System.Drawing.Point(36, 59)
        Me.btnVerTotales.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerTotales.Name = "btnVerTotales"
        Me.btnVerTotales.Size = New System.Drawing.Size(76, 29)
        Me.btnVerTotales.TabIndex = 15
        Me.btnVerTotales.Text = "Ver Totales"
        Me.btnVerTotales.UseVisualStyleBackColor = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(150, 63)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtSubTotal.TabIndex = 11
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(276, 63)
        Me.txtIva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(108, 20)
        Me.txtIva.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(413, 63)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtTotal.TabIndex = 15
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(36, 18)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(467, 150)
        Me.dgvProductos.TabIndex = 0
        '
        'fVentaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 510)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "fVentaProducto"
        Me.Text = "Venta de productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnVerTotales As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvProductos As DataGridView
End Class
