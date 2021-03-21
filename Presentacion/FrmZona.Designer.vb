<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmZona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmZona))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtZona7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtZona6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtZona5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtZona4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZona3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtZona2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtZona1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistro.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Location = New System.Drawing.Point(339, 430)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(93, 51)
        Me.BtnActualizar.TabIndex = 57
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
        Me.BtnGuardar.Location = New System.Drawing.Point(168, 430)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 51)
        Me.BtnGuardar.TabIndex = 56
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
        Me.btnInsertar.Location = New System.Drawing.Point(13, 431)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(83, 50)
        Me.btnInsertar.TabIndex = 55
        Me.btnInsertar.Text = "Insertar"
        Me.ttMensaje.SetToolTip(Me.btnInsertar, "Prepara el entorno para guardar datos")
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(412, 427)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 54)
        Me.btnVolver.TabIndex = 54
        Me.btnVolver.Text = "Volver al Menu"
        Me.ttMensaje.SetToolTip(Me.btnVolver, "Retorno al menu principal")
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 484)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(509, 34)
        Me.Label13.TabIndex = 52
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
        Me.gbRegistro.Location = New System.Drawing.Point(13, 37)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(482, 387)
        Me.gbRegistro.TabIndex = 50
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
        'ComboBuscar
        '
        Me.ComboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBuscar.FormattingEnabled = True
        Me.ComboBuscar.Items.AddRange(New Object() {"Tipo", "Ciudad"})
        Me.ComboBuscar.Location = New System.Drawing.Point(73, 27)
        Me.ComboBuscar.Name = "ComboBuscar"
        Me.ComboBuscar.Size = New System.Drawing.Size(150, 27)
        Me.ComboBuscar.TabIndex = 1
        Me.ttMensaje.SetToolTip(Me.ComboBuscar, "Selecciona la categoria del filtro")
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
        Me.BtnEliminar.Location = New System.Drawing.Point(272, 327)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.ttMensaje.SetToolTip(Me.BtnEliminar, "Elimina registro")
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.gbPersonal.Controls.Add(Me.comboTipo)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.txtCiudad)
        Me.gbPersonal.Controls.Add(Me.Label11)
        Me.gbPersonal.Controls.Add(Me.txtZona7)
        Me.gbPersonal.Controls.Add(Me.Label10)
        Me.gbPersonal.Controls.Add(Me.txtZona6)
        Me.gbPersonal.Controls.Add(Me.Label9)
        Me.gbPersonal.Controls.Add(Me.txtZona5)
        Me.gbPersonal.Controls.Add(Me.Label8)
        Me.gbPersonal.Controls.Add(Me.txtZona4)
        Me.gbPersonal.Controls.Add(Me.Label7)
        Me.gbPersonal.Controls.Add(Me.txtZona3)
        Me.gbPersonal.Controls.Add(Me.Label6)
        Me.gbPersonal.Controls.Add(Me.txtZona2)
        Me.gbPersonal.Controls.Add(Me.Label5)
        Me.gbPersonal.Controls.Add(Me.txtZona1)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.txtPeso)
        Me.gbPersonal.Controls.Add(Me.txtCodigo)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPersonal.Location = New System.Drawing.Point(13, 37)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(288, 387)
        Me.gbPersonal.TabIndex = 49
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Datos"
        Me.ttMensaje.SetToolTip(Me.gbPersonal, "Sirve para Mostrar, Agregar y Modificar un dato en particular")
        Me.gbPersonal.Visible = False
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtCiudad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(120, 346)
        Me.txtCiudad.MaxLength = 100
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(155, 26)
        Me.txtCiudad.TabIndex = 33
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
        'txtZona7
        '
        Me.txtZona7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona7.Location = New System.Drawing.Point(120, 314)
        Me.txtZona7.MaxLength = 12
        Me.txtZona7.Name = "txtZona7"
        Me.txtZona7.Size = New System.Drawing.Size(155, 26)
        Me.txtZona7.TabIndex = 31
        Me.txtZona7.Text = "0"
        Me.txtZona7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 19)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Zona 7:"
        '
        'txtZona6
        '
        Me.txtZona6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona6.Location = New System.Drawing.Point(120, 282)
        Me.txtZona6.MaxLength = 12
        Me.txtZona6.Name = "txtZona6"
        Me.txtZona6.Size = New System.Drawing.Size(155, 26)
        Me.txtZona6.TabIndex = 29
        Me.txtZona6.Text = "0"
        Me.txtZona6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Zona 6:"
        '
        'txtZona5
        '
        Me.txtZona5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona5.Location = New System.Drawing.Point(120, 250)
        Me.txtZona5.MaxLength = 12
        Me.txtZona5.Name = "txtZona5"
        Me.txtZona5.Size = New System.Drawing.Size(155, 26)
        Me.txtZona5.TabIndex = 27
        Me.txtZona5.Text = "0"
        Me.txtZona5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Zona 5:"
        '
        'txtZona4
        '
        Me.txtZona4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona4.Location = New System.Drawing.Point(120, 218)
        Me.txtZona4.MaxLength = 12
        Me.txtZona4.Name = "txtZona4"
        Me.txtZona4.Size = New System.Drawing.Size(155, 26)
        Me.txtZona4.TabIndex = 25
        Me.txtZona4.Text = "0"
        Me.txtZona4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Zona 4:"
        '
        'txtZona3
        '
        Me.txtZona3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona3.Location = New System.Drawing.Point(120, 186)
        Me.txtZona3.MaxLength = 12
        Me.txtZona3.Name = "txtZona3"
        Me.txtZona3.Size = New System.Drawing.Size(155, 26)
        Me.txtZona3.TabIndex = 23
        Me.txtZona3.Text = "0"
        Me.txtZona3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Zona 3:"
        '
        'txtZona2
        '
        Me.txtZona2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona2.Location = New System.Drawing.Point(120, 154)
        Me.txtZona2.MaxLength = 12
        Me.txtZona2.Name = "txtZona2"
        Me.txtZona2.Size = New System.Drawing.Size(155, 26)
        Me.txtZona2.TabIndex = 21
        Me.txtZona2.Text = "0"
        Me.txtZona2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Zona 2:"
        '
        'txtZona1
        '
        Me.txtZona1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtZona1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona1.Location = New System.Drawing.Point(120, 122)
        Me.txtZona1.MaxLength = 12
        Me.txtZona1.Name = "txtZona1"
        Me.txtZona1.Size = New System.Drawing.Size(155, 26)
        Me.txtZona1.TabIndex = 19
        Me.txtZona1.Text = "0"
        Me.txtZona1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Zona 1:"
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtPeso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(120, 57)
        Me.txtPeso.MaxLength = 12
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(155, 26)
        Me.txtPeso.TabIndex = 13
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso:"
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
        Me.Label14.Size = New System.Drawing.Size(509, 34)
        Me.Label14.TabIndex = 51
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(534, 430)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(89, 51)
        Me.BtnCancelar.TabIndex = 58
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
        'comboTipo
        '
        Me.comboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Items.AddRange(New Object() {"Importacion", "Exportacion", "Local"})
        Me.comboTipo.Location = New System.Drawing.Point(120, 89)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(155, 27)
        Me.comboTipo.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Tipo:"
        '
        'FrmZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(509, 517)
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
        Me.Name = "FrmZona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Zonas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnActualizar As Button
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
    Friend WithEvents txtZona7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtZona6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtZona5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtZona4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtZona3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtZona2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtZona1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents Label2 As Label
End Class
