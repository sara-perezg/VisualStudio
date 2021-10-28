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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.txtBPassword = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblName.Location = New System.Drawing.Point(23, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblName.Size = New System.Drawing.Size(64, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nombre"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPassword.Location = New System.Drawing.Point(23, 122)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPassword.Size = New System.Drawing.Size(91, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Contraseña"
        '
        'txtBName
        '
        Me.txtBName.BackColor = System.Drawing.Color.FloralWhite
        Me.txtBName.Location = New System.Drawing.Point(120, 59)
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(100, 22)
        Me.txtBName.TabIndex = 2
        '
        'txtBPassword
        '
        Me.txtBPassword.BackColor = System.Drawing.Color.FloralWhite
        Me.txtBPassword.Location = New System.Drawing.Point(120, 117)
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
        Me.dtpDate.Size = New System.Drawing.Size(194, 22)
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
        Me.btnLoadImage.BackColor = System.Drawing.Color.FloralWhite
        Me.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadImage.Location = New System.Drawing.Point(236, 170)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(110, 45)
        Me.btnLoadImage.TabIndex = 6
        Me.btnLoadImage.Text = "Cargar Imagen"
        Me.btnLoadImage.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FloralWhite
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(98, 244)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 37)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FloralWhite
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(204, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
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
    Friend WithEvents ofd As OpenFileDialog
End Class
