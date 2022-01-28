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
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1150, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 560)
        Me.PanelMenu.TabIndex = 1
        '
        'panelContenedor
        '
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(930, 560)
        Me.panelContenedor.TabIndex = 2
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Location = New System.Drawing.Point(182, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Button1"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 600)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnMenu As Button
End Class
