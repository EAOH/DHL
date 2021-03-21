<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.comboPuesto = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckEliminar = New System.Windows.Forms.CheckBox()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnCerrarSecion = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbPersonal.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPersonal
        '
        Me.gbPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbPersonal.Controls.Add(Me.comboPuesto)
        Me.gbPersonal.Controls.Add(Me.dtpFecha)
        Me.gbPersonal.Controls.Add(Me.txtContraseña)
        Me.gbPersonal.Controls.Add(Me.txtUsuario)
        Me.gbPersonal.Controls.Add(Me.txtCorreo)
        Me.gbPersonal.Controls.Add(Me.txtDireccion)
        Me.gbPersonal.Controls.Add(Me.txtTelefono)
        Me.gbPersonal.Controls.Add(Me.txtIdentidad)
        Me.gbPersonal.Controls.Add(Me.txtApellido)
        Me.gbPersonal.Controls.Add(Me.txtNombre)
        Me.gbPersonal.Controls.Add(Me.txtCodigo)
        Me.gbPersonal.Controls.Add(Me.Label11)
        Me.gbPersonal.Controls.Add(Me.Label10)
        Me.gbPersonal.Controls.Add(Me.Label9)
        Me.gbPersonal.Controls.Add(Me.Label8)
        Me.gbPersonal.Controls.Add(Me.Label7)
        Me.gbPersonal.Controls.Add(Me.Label6)
        Me.gbPersonal.Controls.Add(Me.Label5)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 37)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(288, 386)
        Me.gbPersonal.TabIndex = 0
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Datos"
        Me.gbPersonal.Visible = False
        '
        'comboPuesto
        '
        Me.comboPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPuesto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboPuesto.FormattingEnabled = True
        Me.comboPuesto.Items.AddRange(New Object() {"Recursos humanos", "Atencion al cliente", "Administrador", "Mensajero"})
        Me.comboPuesto.Location = New System.Drawing.Point(103, 248)
        Me.comboPuesto.Name = "comboPuesto"
        Me.comboPuesto.Size = New System.Drawing.Size(155, 27)
        Me.comboPuesto.TabIndex = 21
        Me.ttMensaje.SetToolTip(Me.comboPuesto, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(141, 282)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(117, 26)
        Me.dtpFecha.TabIndex = 20
        Me.ttMensaje.SetToolTip(Me.dtpFecha, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtContraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(103, 346)
        Me.txtContraseña.MaxLength = 50
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseña.Size = New System.Drawing.Size(155, 26)
        Me.txtContraseña.TabIndex = 18
        Me.ttMensaje.SetToolTip(Me.txtContraseña, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(103, 314)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(155, 26)
        Me.txtUsuario.TabIndex = 17
        Me.ttMensaje.SetToolTip(Me.txtUsuario, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(103, 184)
        Me.txtCorreo.MaxLength = 200
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(155, 26)
        Me.txtCorreo.TabIndex = 16
        Me.ttMensaje.SetToolTip(Me.txtCorreo, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(103, 216)
        Me.txtDireccion.MaxLength = 200
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(155, 26)
        Me.txtDireccion.TabIndex = 16
        Me.ttMensaje.SetToolTip(Me.txtDireccion, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(103, 152)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(155, 26)
        Me.txtTelefono.TabIndex = 15
        Me.ttMensaje.SetToolTip(Me.txtTelefono, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtIdentidad
        '
        Me.txtIdentidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtIdentidad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidad.Location = New System.Drawing.Point(103, 120)
        Me.txtIdentidad.MaxLength = 14
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(155, 26)
        Me.txtIdentidad.TabIndex = 14
        Me.ttMensaje.SetToolTip(Me.txtIdentidad, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtApellido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(103, 88)
        Me.txtApellido.MaxLength = 100
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(155, 26)
        Me.txtApellido.TabIndex = 13
        Me.ttMensaje.SetToolTip(Me.txtApellido, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(103, 56)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(155, 26)
        Me.txtNombre.TabIndex = 12
        Me.ttMensaje.SetToolTip(Me.txtNombre, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(103, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(155, 26)
        Me.txtCodigo.TabIndex = 11
        Me.ttMensaje.SetToolTip(Me.txtCodigo, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Contraseña:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Usuario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha de Ingreso:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Puesto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Identidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
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
        'ttMensaje
        '
        Me.ttMensaje.AutoPopDelay = 5000
        Me.ttMensaje.InitialDelay = 900
        Me.ttMensaje.ReshowDelay = 100
        Me.ttMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'CheckEliminar
        '
        Me.CheckEliminar.AutoSize = True
        Me.CheckEliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEliminar.Location = New System.Drawing.Point(120, 334)
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
        Me.ComboBuscar.Items.AddRange(New Object() {"Nombre", "Apellido", "Direccion", "Identidad", "Telefono", "Correo", "Puesto", "Usuario"})
        Me.ComboBuscar.Location = New System.Drawing.Point(73, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(110, 27)
        Me.ComboBuscar.TabIndex = 1
        Me.ttMensaje.SetToolTip(Me.ComboBuscar, "Determina el tipo de filtro que se realizara")
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(270, 317)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.ttMensaje.SetToolTip(Me.BtnEliminar, "Elimina los elementos seleccionados")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataListado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataListado.Location = New System.Drawing.Point(7, 59)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(469, 249)
        Me.dataListado.TabIndex = 0
        Me.ttMensaje.SetToolTip(Me.dataListado, "Muestra los datos de todo el personal")
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'btnCerrarSecion
        '
        Me.btnCerrarSecion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCerrarSecion.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarSecion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSecion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSecion.Location = New System.Drawing.Point(419, 426)
        Me.btnCerrarSecion.Name = "btnCerrarSecion"
        Me.btnCerrarSecion.Size = New System.Drawing.Size(83, 54)
        Me.btnCerrarSecion.TabIndex = 14
        Me.btnCerrarSecion.Text = "Cerrar Sesion"
        Me.ttMensaje.SetToolTip(Me.btnCerrarSecion, "Cerrar Secion y volver al Login")
        Me.btnCerrarSecion.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(535, 429)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(89, 51)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.ttMensaje.SetToolTip(Me.BtnCancelar, "Cancela el proceso pendiente")
        Me.BtnCancelar.UseVisualStyleBackColor = False
        Me.BtnCancelar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Location = New System.Drawing.Point(340, 428)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(93, 51)
        Me.BtnActualizar.TabIndex = 17
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
        Me.BtnGuardar.Location = New System.Drawing.Point(171, 428)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 51)
        Me.BtnGuardar.TabIndex = 16
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
        Me.btnInsertar.Location = New System.Drawing.Point(12, 429)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(83, 50)
        Me.btnInsertar.TabIndex = 15
        Me.btnInsertar.Text = "Insertar"
        Me.ttMensaje.SetToolTip(Me.btnInsertar, "Activa los campos para ingresar un nuevo dato")
        Me.btnInsertar.UseVisualStyleBackColor = False
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
        Me.gbRegistro.Location = New System.Drawing.Point(12, 37)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(482, 386)
        Me.gbRegistro.TabIndex = 4
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro del personal"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(229, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(174, 26)
        Me.txtBuscar.TabIndex = 12
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
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 483)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(507, 34)
        Me.Label13.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
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
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(507, 34)
        Me.Label14.TabIndex = 7
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 517)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnCerrarSecion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.gbRegistro)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de Personal"
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents CheckEliminar As CheckBox
    Friend WithEvents ComboBuscar As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCerrarSecion As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents comboPuesto As ComboBox
End Class
