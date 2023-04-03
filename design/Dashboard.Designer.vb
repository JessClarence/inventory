<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.subPanelCustomer = New System.Windows.Forms.Panel()
        Me.btnOrderDet = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnListofCust = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.subPanelSupplier = New System.Windows.Forms.Panel()
        Me.btnDeliDet = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnListofSupplier = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUOM = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSideMenu.SuspendLayout()
        Me.subPanelCustomer.SuspendLayout()
        Me.subPanelSupplier.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnLogout)
        Me.PanelSideMenu.Controls.Add(Me.subPanelCustomer)
        Me.PanelSideMenu.Controls.Add(Me.btnCustomer)
        Me.PanelSideMenu.Controls.Add(Me.subPanelSupplier)
        Me.PanelSideMenu.Controls.Add(Me.btnSupplier)
        Me.PanelSideMenu.Controls.Add(Me.Button2)
        Me.PanelSideMenu.Controls.Add(Me.Button1)
        Me.PanelSideMenu.Controls.Add(Me.btnUOM)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(200, 881)
        Me.PanelSideMenu.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogout.Location = New System.Drawing.Point(0, 603)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(200, 50)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'subPanelCustomer
        '
        Me.subPanelCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.subPanelCustomer.Controls.Add(Me.btnOrderDet)
        Me.subPanelCustomer.Controls.Add(Me.btnOrders)
        Me.subPanelCustomer.Controls.Add(Me.btnListofCust)
        Me.subPanelCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.subPanelCustomer.Location = New System.Drawing.Point(0, 473)
        Me.subPanelCustomer.Name = "subPanelCustomer"
        Me.subPanelCustomer.Size = New System.Drawing.Size(200, 130)
        Me.subPanelCustomer.TabIndex = 7
        '
        'btnOrderDet
        '
        Me.btnOrderDet.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrderDet.FlatAppearance.BorderSize = 0
        Me.btnOrderDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnOrderDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnOrderDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderDet.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderDet.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnOrderDet.Location = New System.Drawing.Point(0, 80)
        Me.btnOrderDet.Name = "btnOrderDet"
        Me.btnOrderDet.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnOrderDet.Size = New System.Drawing.Size(200, 40)
        Me.btnOrderDet.TabIndex = 3
        Me.btnOrderDet.Text = "Order Details"
        Me.btnOrderDet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderDet.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrders.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnOrders.Location = New System.Drawing.Point(0, 40)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnOrders.Size = New System.Drawing.Size(200, 40)
        Me.btnOrders.TabIndex = 2
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnListofCust
        '
        Me.btnListofCust.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListofCust.FlatAppearance.BorderSize = 0
        Me.btnListofCust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnListofCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnListofCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListofCust.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListofCust.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnListofCust.Location = New System.Drawing.Point(0, 0)
        Me.btnListofCust.Name = "btnListofCust"
        Me.btnListofCust.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnListofCust.Size = New System.Drawing.Size(200, 40)
        Me.btnListofCust.TabIndex = 1
        Me.btnListofCust.Text = "List of Customer"
        Me.btnListofCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListofCust.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomer.Location = New System.Drawing.Point(0, 423)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCustomer.Size = New System.Drawing.Size(200, 50)
        Me.btnCustomer.TabIndex = 6
        Me.btnCustomer.Text = "CUSTOMER"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'subPanelSupplier
        '
        Me.subPanelSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.subPanelSupplier.Controls.Add(Me.btnDeliDet)
        Me.subPanelSupplier.Controls.Add(Me.btnDelivery)
        Me.subPanelSupplier.Controls.Add(Me.btnListofSupplier)
        Me.subPanelSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.subPanelSupplier.Location = New System.Drawing.Point(0, 293)
        Me.subPanelSupplier.Name = "subPanelSupplier"
        Me.subPanelSupplier.Size = New System.Drawing.Size(200, 130)
        Me.subPanelSupplier.TabIndex = 5
        '
        'btnDeliDet
        '
        Me.btnDeliDet.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDeliDet.FlatAppearance.BorderSize = 0
        Me.btnDeliDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDeliDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDeliDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeliDet.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliDet.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeliDet.Location = New System.Drawing.Point(0, 80)
        Me.btnDeliDet.Name = "btnDeliDet"
        Me.btnDeliDet.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnDeliDet.Size = New System.Drawing.Size(200, 40)
        Me.btnDeliDet.TabIndex = 3
        Me.btnDeliDet.Text = "Delivery Details"
        Me.btnDeliDet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeliDet.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelivery.FlatAppearance.BorderSize = 0
        Me.btnDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelivery.Location = New System.Drawing.Point(0, 40)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnDelivery.Size = New System.Drawing.Size(200, 40)
        Me.btnDelivery.TabIndex = 2
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'btnListofSupplier
        '
        Me.btnListofSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListofSupplier.FlatAppearance.BorderSize = 0
        Me.btnListofSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnListofSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnListofSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListofSupplier.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListofSupplier.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnListofSupplier.Location = New System.Drawing.Point(0, 0)
        Me.btnListofSupplier.Name = "btnListofSupplier"
        Me.btnListofSupplier.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnListofSupplier.Size = New System.Drawing.Size(200, 40)
        Me.btnListofSupplier.TabIndex = 1
        Me.btnListofSupplier.Text = "List of Supplier"
        Me.btnListofSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListofSupplier.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupplier.Location = New System.Drawing.Point(0, 243)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSupplier.Size = New System.Drawing.Size(200, 50)
        Me.btnSupplier.TabIndex = 4
        Me.btnSupplier.Text = "SUPPLIER"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(0, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(200, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "PRODUCT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(0, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CATEGORY"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUOM
        '
        Me.btnUOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUOM.FlatAppearance.BorderSize = 0
        Me.btnUOM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnUOM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUOM.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUOM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnUOM.Location = New System.Drawing.Point(0, 93)
        Me.btnUOM.Name = "btnUOM"
        Me.btnUOM.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUOM.Size = New System.Drawing.Size(200, 50)
        Me.btnUOM.TabIndex = 1
        Me.btnUOM.Text = "UOM"
        Me.btnUOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUOM.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.Label1)
        Me.panelLogo.Controls.Add(Me.PictureBox)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(200, 93)
        Me.panelLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN"
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.design.My.Resources.Resources.administrator_102921__1_
        Me.PictureBox.Location = New System.Drawing.Point(57, 3)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(65, 67)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'PanelContainer
        '
        Me.PanelContainer.Location = New System.Drawing.Point(199, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1471, 869)
        Me.PanelContainer.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.design.My.Resources.Resources.forbiddenmark_87303__1_
        Me.PictureBox1.Location = New System.Drawing.Point(1632, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1664, 881)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.PanelSideMenu.ResumeLayout(False)
        Me.subPanelCustomer.ResumeLayout(False)
        Me.subPanelSupplier.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        Me.panelLogo.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents subPanelSupplier As Panel
    Friend WithEvents btnDeliDet As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnListofSupplier As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUOM As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents subPanelCustomer As Panel
    Friend WithEvents btnOrderDet As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnListofCust As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
