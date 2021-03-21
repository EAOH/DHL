<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOtrosGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOtrosGastos))
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
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkPeso = New System.Windows.Forms.CheckBox()
        Me.checkPorcentaje = New System.Windows.Forms.CheckBox()
        Me.checkFijo = New System.Windows.Forms.CheckBox()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.txtFijo = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.BtnActualizar.Location = New System.Drawing.Point(339, 328)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(93, 51)
        Me.BtnActualizar.TabIndex = 37
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
        Me.BtnGuardar.Location = New System.Drawing.Point(168, 328)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 51)
        Me.BtnGuardar.TabIndex = 36
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
        Me.btnInsertar.Location = New System.Drawing.Point(13, 329)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(83, 50)
        Me.btnInsertar.TabIndex = 35
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
        Me.btnVolver.Location = New System.Drawing.Point(412, 325)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 54)
        Me.btnVolver.TabIndex = 34
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
        Me.Label13.Location = New System.Drawing.Point(0, 382)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(507, 34)
        Me.Label13.TabIndex = 32
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
        Me.gbRegistro.Location = New System.Drawing.Point(12, 36)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(482, 286)
        Me.gbRegistro.TabIndex = 30
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
        Me.ComboBuscar.Items.AddRange(New Object() {"Tipo", "Descripcion"})
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.gbPersonal.Controls.Add(Me.txtPeso)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.GroupBox1)
        Me.gbPersonal.Controls.Add(Me.comboTipo)
        Me.gbPersonal.Controls.Add(Me.txtFijo)
        Me.gbPersonal.Controls.Add(Me.txtPorcentaje)
        Me.gbPersonal.Controls.Add(Me.txtDescripcion)
        Me.gbPersonal.Controls.Add(Me.txtCodigo)
        Me.gbPersonal.Controls.Add(Me.Label7)
        Me.gbPersonal.Controls.Add(Me.Label6)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPersonal.Location = New System.Drawing.Point(13, 36)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(288, 286)
        Me.gbPersonal.TabIndex = 29
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Datos"
        Me.gbPersonal.Visible = False
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtPeso.Enabled = False
        Me.txtPeso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(120, 250)
        Me.txtPeso.MaxLength = 12
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(155, 26)
        Me.txtPeso.TabIndex = 20
        Me.txtPeso.Text = "0"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttMensaje.SetToolTip(Me.txtPeso, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Peso:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkPeso)
        Me.GroupBox1.Controls.Add(Me.checkPorcentaje)
        Me.GroupBox1.Controls.Add(Me.checkFijo)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 58)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cobros Posibles"
        '
        'checkPeso
        '
        Me.checkPeso.AutoSize = True
        Me.checkPeso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPeso.Location = New System.Drawing.Point(208, 25)
        Me.checkPeso.Name = "checkPeso"
        Me.checkPeso.Size = New System.Drawing.Size(58, 23)
        Me.checkPeso.TabIndex = 2
        Me.checkPeso.Text = "Peso"
        Me.checkPeso.UseVisualStyleBackColor = True
        '
        'checkPorcentaje
        '
        Me.checkPorcentaje.AutoSize = True
        Me.checkPorcentaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPorcentaje.Location = New System.Drawing.Point(86, 25)
        Me.checkPorcentaje.Name = "checkPorcentaje"
        Me.checkPorcentaje.Size = New System.Drawing.Size(93, 23)
        Me.checkPorcentaje.TabIndex = 1
        Me.checkPorcentaje.Text = "Porcentaje"
        Me.checkPorcentaje.UseVisualStyleBackColor = True
        '
        'checkFijo
        '
        Me.checkFijo.AutoSize = True
        Me.checkFijo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFijo.Location = New System.Drawing.Point(6, 25)
        Me.checkFijo.Name = "checkFijo"
        Me.checkFijo.Size = New System.Drawing.Size(52, 23)
        Me.checkFijo.TabIndex = 0
        Me.checkFijo.Text = "Fijo"
        Me.checkFijo.UseVisualStyleBackColor = True
        '
        'comboTipo
        '
        Me.comboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Items.AddRange(New Object() {"Opcional", "Adicional"})
        Me.comboTipo.Location = New System.Drawing.Point(120, 56)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(155, 27)
        Me.comboTipo.TabIndex = 17
        '
        'txtFijo
        '
        Me.txtFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtFijo.Enabled = False
        Me.txtFijo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFijo.Location = New System.Drawing.Point(120, 185)
        Me.txtFijo.MaxLength = 12
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.Size = New System.Drawing.Size(155, 26)
        Me.txtFijo.TabIndex = 16
        Me.txtFijo.Text = "0"
        Me.txtFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttMensaje.SetToolTip(Me.txtFijo, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtPorcentaje.Enabled = False
        Me.txtPorcentaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.Location = New System.Drawing.Point(120, 218)
        Me.txtPorcentaje.MaxLength = 7
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(155, 26)
        Me.txtPorcentaje.TabIndex = 16
        Me.txtPorcentaje.Text = "0"
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttMensaje.SetToolTip(Me.txtPorcentaje, "Sirve para mostrar, agregar o editar los dato del personal")
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 89)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(155, 26)
        Me.txtDescripcion.TabIndex = 13
        Me.ttMensaje.SetToolTip(Me.txtDescripcion, "Sirve para mostrar, agregar o editar los dato del personal")
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Porcentaje:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fijo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Cobro:"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(534, 328)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(89, 51)
        Me.BtnCancelar.TabIndex = 38
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
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
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
        Me.Label14.Location = New System.Drawing.Point(0, -1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(507, 34)
        Me.Label14.TabIndex = 31
        '
        'FrmOtrosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(508, 415)
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
        Me.Name = "FrmOtrosGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Gastos adicionales y Opcionales"
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
    Friend WithEvents txtFijo As TextBox
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkPeso As CheckBox
    Friend WithEvents checkPorcentaje As CheckBox
    Friend WithEvents checkFijo As CheckBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label4 As Label
End Class
