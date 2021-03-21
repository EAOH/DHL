<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAdministrador))
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnCerrarSecion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOtrosGastos = New System.Windows.Forms.Button()
        Me.btnPais = New System.Windows.Forms.Button()
        Me.btnZona = New System.Windows.Forms.Button()
        Me.btnAlmacenaje = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnArticulos
        '
        Me.btnArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnArticulos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnArticulos.ForeColor = System.Drawing.Color.White
        Me.btnArticulos.Location = New System.Drawing.Point(12, 39)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(118, 88)
        Me.btnArticulos.TabIndex = 21
        Me.btnArticulos.Text = "Gestion de Articulos"
        Me.ttMensaje.SetToolTip(Me.btnArticulos, "Lleva a un formulario especial para la gestion de articulos")
        Me.btnArticulos.UseVisualStyleBackColor = False
        '
        'btnCerrarSecion
        '
        Me.btnCerrarSecion.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarSecion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSecion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSecion.Location = New System.Drawing.Point(260, 133)
        Me.btnCerrarSecion.Name = "btnCerrarSecion"
        Me.btnCerrarSecion.Size = New System.Drawing.Size(118, 88)
        Me.btnCerrarSecion.TabIndex = 20
        Me.btnCerrarSecion.Text = "Cerrar Sesion"
        Me.ttMensaje.SetToolTip(Me.btnCerrarSecion, "Cerrar Secion y volver al Login")
        Me.btnCerrarSecion.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(389, 34)
        Me.Label4.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 34)
        Me.Label1.TabIndex = 22
        '
        'ttMensaje
        '
        Me.ttMensaje.AutoPopDelay = 5000
        Me.ttMensaje.InitialDelay = 900
        Me.ttMensaje.ReshowDelay = 100
        Me.ttMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnOtrosGastos
        '
        Me.btnOtrosGastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOtrosGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOtrosGastos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOtrosGastos.ForeColor = System.Drawing.Color.White
        Me.btnOtrosGastos.Location = New System.Drawing.Point(136, 39)
        Me.btnOtrosGastos.Name = "btnOtrosGastos"
        Me.btnOtrosGastos.Size = New System.Drawing.Size(118, 88)
        Me.btnOtrosGastos.TabIndex = 23
        Me.btnOtrosGastos.Text = "Gestion de otros Gastos"
        Me.ttMensaje.SetToolTip(Me.btnOtrosGastos, "Lleva a un formulario especial para la gestion de Otros gastos")
        Me.btnOtrosGastos.UseVisualStyleBackColor = False
        '
        'btnPais
        '
        Me.btnPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPais.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPais.ForeColor = System.Drawing.Color.White
        Me.btnPais.Location = New System.Drawing.Point(12, 133)
        Me.btnPais.Name = "btnPais"
        Me.btnPais.Size = New System.Drawing.Size(118, 88)
        Me.btnPais.TabIndex = 24
        Me.btnPais.Text = "Gestion de los paises"
        Me.ttMensaje.SetToolTip(Me.btnPais, "Lleva a un formulario especial para la gestion de los Paises")
        Me.btnPais.UseVisualStyleBackColor = False
        '
        'btnZona
        '
        Me.btnZona.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnZona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnZona.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnZona.ForeColor = System.Drawing.Color.White
        Me.btnZona.Location = New System.Drawing.Point(136, 133)
        Me.btnZona.Name = "btnZona"
        Me.btnZona.Size = New System.Drawing.Size(118, 88)
        Me.btnZona.TabIndex = 25
        Me.btnZona.Text = "Gestion de la Zona"
        Me.ttMensaje.SetToolTip(Me.btnZona, "Lleva a un formulario especial para la gestion de las Zonas")
        Me.btnZona.UseVisualStyleBackColor = False
        '
        'btnAlmacenaje
        '
        Me.btnAlmacenaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAlmacenaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlmacenaje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlmacenaje.ForeColor = System.Drawing.Color.White
        Me.btnAlmacenaje.Location = New System.Drawing.Point(260, 39)
        Me.btnAlmacenaje.Name = "btnAlmacenaje"
        Me.btnAlmacenaje.Size = New System.Drawing.Size(118, 88)
        Me.btnAlmacenaje.TabIndex = 26
        Me.btnAlmacenaje.Text = "Gestion del Almacenaje"
        Me.ttMensaje.SetToolTip(Me.btnAlmacenaje, "Dirige al formulario para la gestion del almacenaje")
        Me.btnAlmacenaje.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmMenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(388, 259)
        Me.Controls.Add(Me.btnAlmacenaje)
        Me.Controls.Add(Me.btnZona)
        Me.Controls.Add(Me.btnPais)
        Me.Controls.Add(Me.btnOtrosGastos)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.btnCerrarSecion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMenuAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu del Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnArticulos As Button
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents btnCerrarSecion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOtrosGastos As Button
    Friend WithEvents btnPais As Button
    Friend WithEvents btnZona As Button
    Friend WithEvents btnAlmacenaje As Button
End Class
