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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlantasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HongosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CiudadesToolStripMenuItem, Me.PlantasToolStripMenuItem, Me.HongosToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'CiudadesToolStripMenuItem
        '
        Me.CiudadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem, Me.Test2ToolStripMenuItem})
        Me.CiudadesToolStripMenuItem.Name = "CiudadesToolStripMenuItem"
        Me.CiudadesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CiudadesToolStripMenuItem.Text = "Animales"
        '
        'Test1ToolStripMenuItem
        '
        Me.Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Me.Test1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Test1ToolStripMenuItem.Text = "Test1"
        '
        'Test2ToolStripMenuItem
        '
        Me.Test2ToolStripMenuItem.Name = "Test2ToolStripMenuItem"
        Me.Test2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Test2ToolStripMenuItem.Text = "Test2"
        '
        'PlantasToolStripMenuItem
        '
        Me.PlantasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem1})
        Me.PlantasToolStripMenuItem.Name = "PlantasToolStripMenuItem"
        Me.PlantasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PlantasToolStripMenuItem.Text = "Plantas"
        '
        'Test1ToolStripMenuItem1
        '
        Me.Test1ToolStripMenuItem1.Name = "Test1ToolStripMenuItem1"
        Me.Test1ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.Test1ToolStripMenuItem1.Text = "Test1"
        '
        'HongosToolStripMenuItem
        '
        Me.HongosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem2})
        Me.HongosToolStripMenuItem.Name = "HongosToolStripMenuItem"
        Me.HongosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HongosToolStripMenuItem.Text = "Hongos"
        '
        'Test1ToolStripMenuItem2
        '
        Me.Test1ToolStripMenuItem2.Name = "Test1ToolStripMenuItem2"
        Me.Test1ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.Test1ToolStripMenuItem2.Text = "Test1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ejercicio02_02.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(704, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlantasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HongosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Test1ToolStripMenuItem2 As ToolStripMenuItem
End Class
