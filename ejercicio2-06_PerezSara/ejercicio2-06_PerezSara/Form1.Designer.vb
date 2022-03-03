<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSetting = New FontAwesome.Sharp.IconButton()
        Me.btnMarketing = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnOrders = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnSetting)
        Me.PanelMenu.Controls.Add(Me.btnMarketing)
        Me.PanelMenu.Controls.Add(Me.btnCustomers)
        Me.PanelMenu.Controls.Add(Me.btnProducts)
        Me.PanelMenu.Controls.Add(Me.btnOrders)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(293, 554)
        Me.PanelMenu.TabIndex = 0
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(293, 123)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnMaximize)
        Me.PanelTitulo.Controls.Add(Me.btnMinimize)
        Me.PanelTitulo.Controls.Add(Me.btnExit)
        Me.PanelTitulo.Controls.Add(Me.lblFormTitle)
        Me.PanelTitulo.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(293, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(774, 80)
        Me.PanelTitulo.TabIndex = 1
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.ejercicio2_06_PerezSara.My.Resources.Resources.IconoMaximizar
        Me.btnMaximize.Location = New System.Drawing.Point(697, 23)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(27, 25)
        Me.btnMaximize.TabIndex = 4
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ejercicio2_06_PerezSara.My.Resources.Resources.IconoMinimizar
        Me.btnMinimize.Location = New System.Drawing.Point(662, 23)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(27, 25)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.ejercicio2_06_PerezSara.My.Resources.Resources.IconocerrarFN
        Me.btnExit.Location = New System.Drawing.Point(732, 23)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(27, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFormTitle.Location = New System.Drawing.Point(83, 22)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(76, 25)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "HOME"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(293, 80)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(774, 474)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ejercicio2_06_PerezSara.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(774, 474)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 75
        Me.IconCurrentForm.Location = New System.Drawing.Point(0, 0)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(4)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(75, 80)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'btnSetting
        '
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnSetting.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSetting.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSetting.IconSize = 40
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(0, 368)
        Me.btnSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnSetting.Size = New System.Drawing.Size(293, 49)
        Me.btnSetting.TabIndex = 6
        Me.btnSetting.Text = "Herramientas"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnMarketing
        '
        Me.btnMarketing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarketing.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarketing.FlatAppearance.BorderSize = 0
        Me.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarketing.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.btnMarketing.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMarketing.IconSize = 40
        Me.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarketing.Location = New System.Drawing.Point(0, 319)
        Me.btnMarketing.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMarketing.Name = "btnMarketing"
        Me.btnMarketing.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnMarketing.Size = New System.Drawing.Size(293, 49)
        Me.btnMarketing.TabIndex = 5
        Me.btnMarketing.Text = "Marketing"
        Me.btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMarketing.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnCustomers.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 40
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 270)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(293, 49)
        Me.btnCustomers.TabIndex = 4
        Me.btnCustomers.Text = "Clientes"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btnProducts.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.IconSize = 40
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 221)
        Me.btnProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnProducts.Size = New System.Drawing.Size(293, 49)
        Me.btnProducts.TabIndex = 3
        Me.btnProducts.Text = "Productos"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnOrders.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOrders.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOrders.IconSize = 40
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.Location = New System.Drawing.Point(0, 172)
        Me.btnOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnOrders.Size = New System.Drawing.Size(293, 49)
        Me.btnOrders.TabIndex = 2
        Me.btnOrders.Text = "Compras"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnDashboard.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 40
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 123)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(293, 49)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'imgHome
        '
        Me.imgHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgHome.Image = Global.ejercicio2_06_PerezSara.My.Resources.Resources.LOGO
        Me.imgHome.Location = New System.Drawing.Point(0, 0)
        Me.imgHome.Margin = New System.Windows.Forms.Padding(4)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(293, 123)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
End Class
