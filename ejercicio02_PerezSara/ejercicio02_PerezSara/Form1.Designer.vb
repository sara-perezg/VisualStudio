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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.txtBPassword = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nombre"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(23, 122)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Contraseña"
        '
        'txtBName
        '
        Me.txtBName.Location = New System.Drawing.Point(110, 59)
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(100, 22)
        Me.txtBName.TabIndex = 2
        '
        'txtBPassword
        '
        Me.txtBPassword.Location = New System.Drawing.Point(110, 117)
        Me.txtBPassword.MaxLength = 6
        Me.txtBPassword.Name = "txtBPassword"
        Me.txtBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtBPassword.TabIndex = 3
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(26, 178)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(184, 22)
        Me.dtpDate.TabIndex = 4
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(236, 59)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(110, 105)
        Me.pbImage.TabIndex = 5
        Me.pbImage.TabStop = False
        '
        'btnLoadImage
        '
        Me.btnLoadImage.Location = New System.Drawing.Point(236, 170)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(110, 45)
        Me.btnLoadImage.TabIndex = 6
        Me.btnLoadImage.Text = "Cargar Imagen"
        Me.btnLoadImage.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(98, 244)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 37)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(204, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnLoadImage)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtBPassword)
        Me.Controls.Add(Me.txtBName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Profile"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtBName As TextBox
    Friend WithEvents txtBPassword As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnLoadImage As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
End Class
