<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacenaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacenaje))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.ComboBuscar = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.comboCiudad = New System.Windows.Forms.ComboBox()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudPesomax = New System.Windows.Forms.NumericUpDown()
        Me.nudPesomin = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboTipoCarga = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudDiamax = New System.Windows.Forms.NumericUpDown()
        Me.nudDiamin = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCostoFijo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTramoF = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTramoI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.CheckEliminar = New System.Windows.Forms.CheckBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
        CType(Me.nudPesomax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPesomin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiamax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiamin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(410, 427)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 54)
        Me.btnVolver.TabIndex = 64
        Me.btnVolver.Text = "Volver al Menu"
        Me.ttMensaje.SetToolTip(Me.btnVolver, "Retorno al menu principal")
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-1, 484)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(508, 34)
        Me.Label13.TabIndex = 62
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(533, 430)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(89, 51)
        Me.BtnCancelar.TabIndex = 68
        Me.BtnCancelar.Text = "Cancelar"
        Me.ttMensaje.SetToolTip(Me.BtnCancelar, "Cancela cualquier funcion y reinicia el formulario")
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
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Location = New System.Drawing.Point(338, 430)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(93, 51)
        Me.BtnActualizar.TabIndex = 67
        Me.BtnActualizar.Text = "Actualizar"
        Me.ttMensaje.SetToolTip(Me.BtnActualizar, "Actualiza los datos del formulario en caso de haber cambios")
        Me.BtnActualizar.UseVisualStyleBackColor = False
        Me.BtnActualizar.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(167, 430)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 51)
        Me.BtnGuardar.TabIndex = 66
        Me.BtnGuardar.Text = "Guardar"
        Me.ttMensaje.SetToolTip(Me.BtnGuardar, "Guarda un nuevo registro")
        Me.BtnGuardar.UseVisualStyleBackColor = False
        Me.BtnGuardar.Visible = False
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsertar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar.ForeColor = System.Drawing.Color.White
        Me.btnInsertar.Location = New System.Drawing.Point(12, 431)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(83, 50)
        Me.btnInsertar.TabIndex = 65
        Me.btnInsertar.Text = "Insertar"
        Me.ttMensaje.SetToolTip(Me.btnInsertar, "Prepara el entorno para guardar datos")
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'ComboBuscar
        '
        Me.ComboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBuscar.FormattingEnabled = True
        Me.ComboBuscar.Items.AddRange(New Object() {"Ciudad"})
        Me.ComboBuscar.Location = New System.Drawing.Point(73, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(150, 27)
        Me.ComboBuscar.TabIndex = 1
        Me.ttMensaje.SetToolTip(Me.ComboBuscar, "Selecciona la categoria del filtro")
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(272, 327)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.ttMensaje.SetToolTip(Me.BtnEliminar, "Elimina registro")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
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
        Me.dataListado.Size = New System.Drawing.Size(469, 262)
        Me.dataListado.TabIndex = 0
        Me.ttMensaje.SetToolTip(Me.dataListado, "Muestra todos los datos de la tabla")
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
        Me.gbPersonal.Controls.Add(Me.comboCiudad)
        Me.gbPersonal.Controls.Add(Me.comboTipo)
        Me.gbPersonal.Controls.Add(Me.Label10)
        Me.gbPersonal.Controls.Add(Me.nudPesomax)
        Me.gbPersonal.Controls.Add(Me.nudPesomin)
        Me.gbPersonal.Controls.Add(Me.Label7)
        Me.gbPersonal.Controls.Add(Me.Label8)
        Me.gbPersonal.Controls.Add(Me.comboTipoCarga)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.nudDiamax)
        Me.gbPersonal.Controls.Add(Me.nudDiamin)
        Me.gbPersonal.Controls.Add(Me.Label11)
        Me.gbPersonal.Controls.Add(Me.txtCostoFijo)
        Me.gbPersonal.Controls.Add(Me.Label9)
        Me.gbPersonal.Controls.Add(Me.txtTramoF)
        Me.gbPersonal.Controls.Add(Me.Label6)
        Me.gbPersonal.Controls.Add(Me.txtTramoI)
        Me.gbPersonal.Controls.Add(Me.Label5)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.txtCodigo)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 37)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(288, 387)
        Me.gbPersonal.TabIndex = 59
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Datos"
        Me.ttMensaje.SetToolTip(Me.gbPersonal, "Sirve para Mostrar, Agregar y Modificar un dato en particular")
        Me.gbPersonal.Visible = False
        '
        'comboCiudad
        '
        Me.comboCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCiudad.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.comboCiudad.FormattingEnabled = True
        Me.comboCiudad.Items.AddRange(New Object() {"Tegucigalpa", "San pedro sula"})
        Me.comboCiudad.Location = New System.Drawing.Point(120, 346)
        Me.comboCiudad.Name = "comboCiudad"
        Me.comboCiudad.Size = New System.Drawing.Size(155, 27)
        Me.comboCiudad.TabIndex = 47
        '
        'comboTipo
        '
        Me.comboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Items.AddRange(New Object() {"Especial", "Estatico"})
        Me.comboTipo.Location = New System.Drawing.Point(120, 56)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(155, 27)
        Me.comboTipo.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 19)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Tipo de Cobro:"
        '
        'nudPesomax
        '
        Me.nudPesomax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.nudPesomax.DecimalPlaces = 2
        Me.nudPesomax.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nudPesomax.Location = New System.Drawing.Point(120, 282)
        Me.nudPesomax.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudPesomax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPesomax.Name = "nudPesomax"
        Me.nudPesomax.Size = New System.Drawing.Size(155, 26)
        Me.nudPesomax.TabIndex = 43
        Me.nudPesomax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPesomin
        '
        Me.nudPesomin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.nudPesomin.DecimalPlaces = 2
        Me.nudPesomin.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nudPesomin.Location = New System.Drawing.Point(120, 250)
        Me.nudPesomin.Maximum = New Decimal(New Integer() {99998, 0, 0, 0})
        Me.nudPesomin.Name = "nudPesomin"
        Me.nudPesomin.Size = New System.Drawing.Size(155, 26)
        Me.nudPesomin.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Peso maximos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Peso minimo:"
        '
        'comboTipoCarga
        '
        Me.comboTipoCarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboTipoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipoCarga.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.comboTipoCarga.FormattingEnabled = True
        Me.comboTipoCarga.Items.AddRange(New Object() {"General", "Cuarto frio", "Materiales peligrosos", "Boveda aereo"})
        Me.comboTipoCarga.Location = New System.Drawing.Point(120, 153)
        Me.comboTipoCarga.Name = "comboTipoCarga"
        Me.comboTipoCarga.Size = New System.Drawing.Size(155, 27)
        Me.comboTipoCarga.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Tipo de carga:"
        '
        'nudDiamax
        '
        Me.nudDiamax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.nudDiamax.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nudDiamax.Location = New System.Drawing.Point(120, 121)
        Me.nudDiamax.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudDiamax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDiamax.Name = "nudDiamax"
        Me.nudDiamax.Size = New System.Drawing.Size(155, 26)
        Me.nudDiamax.TabIndex = 37
        Me.nudDiamax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDiamin
        '
        Me.nudDiamin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.nudDiamin.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nudDiamin.Location = New System.Drawing.Point(120, 89)
        Me.nudDiamin.Maximum = New Decimal(New Integer() {99998, 0, 0, 0})
        Me.nudDiamin.Name = "nudDiamin"
        Me.nudDiamin.Size = New System.Drawing.Size(155, 26)
        Me.nudDiamin.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Ciudad:"
        '
        'txtCostoFijo
        '
        Me.txtCostoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtCostoFijo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoFijo.Location = New System.Drawing.Point(120, 314)
        Me.txtCostoFijo.MaxLength = 12
        Me.txtCostoFijo.Name = "txtCostoFijo"
        Me.txtCostoFijo.Size = New System.Drawing.Size(155, 26)
        Me.txtCostoFijo.TabIndex = 29
        Me.txtCostoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Costo Fijo:"
        '
        'txtTramoF
        '
        Me.txtTramoF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtTramoF.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTramoF.Location = New System.Drawing.Point(120, 218)
        Me.txtTramoF.MaxLength = 15
        Me.txtTramoF.Name = "txtTramoF"
        Me.txtTramoF.Size = New System.Drawing.Size(155, 26)
        Me.txtTramoF.TabIndex = 23
        Me.txtTramoF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tramo Final:"
        '
        'txtTramoI
        '
        Me.txtTramoI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtTramoI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTramoI.Location = New System.Drawing.Point(120, 186)
        Me.txtTramoI.MaxLength = 15
        Me.txtTramoI.Name = "txtTramoI"
        Me.txtTramoI.Size = New System.Drawing.Size(155, 26)
        Me.txtTramoI.TabIndex = 21
        Me.txtTramoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tramo inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Dias maximos:"
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
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dias minimos:"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
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
        Me.gbRegistro.Location = New System.Drawing.Point(11, 37)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(482, 387)
        Me.gbRegistro.TabIndex = 60
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro del personal"
        '
        'CheckEliminar
        '
        Me.CheckEliminar.AutoSize = True
        Me.CheckEliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEliminar.Location = New System.Drawing.Point(123, 344)
        Me.CheckEliminar.Name = "CheckEliminar"
        Me.CheckEliminar.Size = New System.Drawing.Size(84, 23)
        Me.CheckEliminar.TabIndex = 13
        Me.CheckEliminar.Text = "Eliminar"
        Me.CheckEliminar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(249, 27)
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
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(-1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(508, 34)
        Me.Label14.TabIndex = 61
        '
        'FrmAlmacenaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 506)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbRegistro)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Label14)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAlmacenaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion del almacenaje"
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        CType(Me.nudPesomax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPesomin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiamax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiamin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents ComboBuscar As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCostoFijo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTramoF As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTramoI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents CheckEliminar As CheckBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents comboTipoCarga As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudDiamax As NumericUpDown
    Friend WithEvents nudDiamin As NumericUpDown
    Friend WithEvents nudPesomax As NumericUpDown
    Friend WithEvents nudPesomin As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents comboCiudad As ComboBox
End Class
