<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPais
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPais))
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.CheckEliminar = New System.Windows.Forms.CheckBox()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkImportar = New System.Windows.Forms.CheckBox()
        Me.checkE9 = New System.Windows.Forms.CheckBox()
        Me.checkE12 = New System.Windows.Forms.CheckBox()
        Me.checkEw = New System.Windows.Forms.CheckBox()
        Me.comboZona = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbRegistro.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Location = New System.Drawing.Point(338, 327)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(93, 51)
        Me.BtnActualizar.TabIndex = 47
        Me.BtnActualizar.Text = "Actualizar"
        Me.ttMensaje.SetToolTip(Me.BtnActualizar, "Actualiza el dato seleccionado")
        Me.BtnActualizar.UseVisualStyleBackColor = False
        Me.BtnActualizar.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(167, 327)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 51)
        Me.BtnGuardar.TabIndex = 46
        Me.BtnGuardar.Text = "Guardar"
        Me.ttMensaje.SetToolTip(Me.BtnGuardar, "Guarda el nuevo dato")
        Me.BtnGuardar.UseVisualStyleBackColor = False
        Me.BtnGuardar.Visible = False
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsertar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar.ForeColor = System.Drawing.Color.White
        Me.btnInsertar.Location = New System.Drawing.Point(12, 328)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(83, 50)
        Me.btnInsertar.TabIndex = 45
        Me.btnInsertar.Text = "Insertar"
        Me.ttMensaje.SetToolTip(Me.btnInsertar, "Activa los campos para ingresar un nuevo dato")
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(409, 324)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 54)
        Me.btnVolver.TabIndex = 44
        Me.btnVolver.Text = "Volver al Menu"
        Me.ttMensaje.SetToolTip(Me.btnVolver, "Cierra el formulario y regresa al Usuario al menu principal")
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-1, 381)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(507, 34)
        Me.Label13.TabIndex = 42
        '
        'gbRegistro
        '
        Me.gbRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRegistro.Controls.Add(Me.CheckEliminar)
        Me.gbRegistro.Controls.Add(Me.ComboBuscar)
        Me.gbRegistro.Controls.Add(Me.txtBuscar)
        Me.gbRegistro.Controls.Add(Me.BtnEliminar)
        Me.gbRegistro.Controls.Add(Me.Label12)
        Me.gbRegistro.Controls.Add(Me.dataListado)
        Me.gbRegistro.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegistro.Location = New System.Drawing.Point(10, 35)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(482, 286)
        Me.gbRegistro.TabIndex = 40
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro del personal"
        '
        'CheckEliminar
        '
        Me.CheckEliminar.AutoSize = True
        Me.CheckEliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEliminar.Location = New System.Drawing.Point(120, 243)
        Me.CheckEliminar.Name = "CheckEliminar"
        Me.CheckEliminar.Size = New System.Drawing.Size(84, 23)
        Me.CheckEliminar.TabIndex = 13
        Me.CheckEliminar.Text = "Eliminar"
        Me.ttMensaje.SetToolTip(Me.CheckEliminar, "Activa los marcadores de Eliminacion")
        Me.CheckEliminar.UseVisualStyleBackColor = True
        '
        'ComboBuscar
        '
        Me.ComboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBuscar.FormattingEnabled = True
        Me.ComboBuscar.Items.AddRange(New Object() {"Nombre"})
        Me.ComboBuscar.Location = New System.Drawing.Point(73, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(150, 27)
        Me.ComboBuscar.TabIndex = 1
        Me.ttMensaje.SetToolTip(Me.ComboBuscar, "Determina el tipo de filtro que se realizara")
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(249, 27)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(174, 26)
        Me.txtBuscar.TabIndex = 12
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(269, 226)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.ttMensaje.SetToolTip(Me.BtnEliminar, "Elimina los elementos seleccionados")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Buscar:"
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataListado.Location = New System.Drawing.Point(7, 59)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(469, 161)
        Me.dataListado.TabIndex = 0
        Me.ttMensaje.SetToolTip(Me.dataListado, "Muestra los datos de todo el personal")
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'gbPersonal
        '
        Me.gbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbPersonal.Controls.Add(Me.GroupBox1)
        Me.gbPersonal.Controls.Add(Me.comboZona)
        Me.gbPersonal.Controls.Add(Me.txtNombre)
        Me.gbPersonal.Controls.Add(Me.txtCodigo)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 35)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(288, 286)
        Me.gbPersonal.TabIndex = 39
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Datos"
        Me.gbPersonal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkImportar)
        Me.GroupBox1.Controls.Add(Me.checkE9)
        Me.GroupBox1.Controls.Add(Me.checkE12)
        Me.GroupBox1.Controls.Add(Me.checkEw)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 145)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicios"
        '
        'checkImportar
        '
        Me.checkImportar.AutoSize = True
        Me.checkImportar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkImportar.Location = New System.Drawing.Point(6, 112)
        Me.checkImportar.Name = "checkImportar"
        Me.checkImportar.Size = New System.Drawing.Size(101, 23)
        Me.checkImportar.TabIndex = 3
        Me.checkImportar.Text = "Importacion"
        Me.checkImportar.UseVisualStyleBackColor = True
        '
        'checkE9
        '
        Me.checkE9.AutoSize = True
        Me.checkE9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkE9.Location = New System.Drawing.Point(6, 83)
        Me.checkE9.Name = "checkE9"
        Me.checkE9.Size = New System.Drawing.Size(141, 23)
        Me.checkE9.TabIndex = 2
        Me.checkE9.Text = "DHL Express 9:00"
        Me.checkE9.UseVisualStyleBackColor = True
        '
        'checkE12
        '
        Me.checkE12.AutoSize = True
        Me.checkE12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkE12.Location = New System.Drawing.Point(6, 54)
        Me.checkE12.Name = "checkE12"
        Me.checkE12.Size = New System.Drawing.Size(153, 23)
        Me.checkE12.TabIndex = 1
        Me.checkE12.Text = "DHL Express 12:00 "
        Me.checkE12.UseVisualStyleBackColor = True
        '
        'checkEw
        '
        Me.checkEw.AutoSize = True
        Me.checkEw.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkEw.Location = New System.Drawing.Point(6, 25)
        Me.checkEw.Name = "checkEw"
        Me.checkEw.Size = New System.Drawing.Size(181, 23)
        Me.checkEw.TabIndex = 0
        Me.checkEw.Text = "DHL Express Worldwide"
        Me.checkEw.UseVisualStyleBackColor = True
        '
        'comboZona
        '
        Me.comboZona.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboZona.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.comboZona.FormattingEnabled = True
        Me.comboZona.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.comboZona.Location = New System.Drawing.Point(120, 88)
        Me.comboZona.Name = "comboZona"
        Me.comboZona.Size = New System.Drawing.Size(155, 27)
        Me.comboZona.TabIndex = 17
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(120, 57)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(155, 26)
        Me.txtNombre.TabIndex = 13
        Me.ttMensaje.SetToolTip(Me.txtNombre, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(120, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(155, 26)
        Me.txtCodigo.TabIndex = 11
        Me.ttMensaje.SetToolTip(Me.txtCodigo, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Zona:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(533, 327)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(89, 51)
        Me.BtnCancelar.TabIndex = 48
        Me.BtnCancelar.Text = "Cancelar"
        Me.ttMensaje.SetToolTip(Me.BtnCancelar, "Cancela el proceso pendiente")
        Me.BtnCancelar.UseVisualStyleBackColor = False
        Me.BtnCancelar.Visible = False
        '
        'ttMensaje
        '
        Me.ttMensaje.AutoPopDelay = 5000
        Me.ttMensaje.InitialDelay = 900
        Me.ttMensaje.ReshowDelay = 100
        Me.ttMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(-1, -2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(507, 34)
        Me.Label14.TabIndex = 41
        '
        'FrmPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(504, 415)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.gbRegistro)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion del Pais"
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnActualizar As Button
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents CheckEliminar As CheckBox
    Friend WithEvents ComboBuscar As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkE9 As CheckBox
    Friend WithEvents checkE12 As CheckBox
    Friend WithEvents checkEw As CheckBox
    Friend WithEvents comboZona As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents checkImportar As CheckBox
End Class
