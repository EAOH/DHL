<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAtencion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAtencion))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCerrarSecion = New System.Windows.Forms.Button()
        Me.btnNuevocliente = New System.Windows.Forms.Button()
        Me.btnEnvio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 34)
        Me.Label4.TabIndex = 8
        '
        'ttMensaje
        '
        Me.ttMensaje.AutoPopDelay = 5000
        Me.ttMensaje.InitialDelay = 900
        Me.ttMensaje.ReshowDelay = 100
        Me.ttMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnCerrarSecion
        '
        Me.btnCerrarSecion.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarSecion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSecion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSecion.Location = New System.Drawing.Point(92, 135)
        Me.btnCerrarSecion.Name = "btnCerrarSecion"
        Me.btnCerrarSecion.Size = New System.Drawing.Size(83, 54)
        Me.btnCerrarSecion.TabIndex = 15
        Me.btnCerrarSecion.Text = "Cerrar Sesion"
        Me.ttMensaje.SetToolTip(Me.btnCerrarSecion, "Cerrar Secion y volver al Login")
        Me.btnCerrarSecion.UseVisualStyleBackColor = False
        '
        'btnNuevocliente
        '
        Me.btnNuevocliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevocliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevocliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevocliente.ForeColor = System.Drawing.Color.White
        Me.btnNuevocliente.Location = New System.Drawing.Point(12, 41)
        Me.btnNuevocliente.Name = "btnNuevocliente"
        Me.btnNuevocliente.Size = New System.Drawing.Size(118, 88)
        Me.btnNuevocliente.TabIndex = 16
        Me.btnNuevocliente.Text = "Nuevo Cliente"
        Me.ttMensaje.SetToolTip(Me.btnNuevocliente, "Lleva a un formulario especial para agregar un nuevo cliente")
        Me.btnNuevocliente.UseVisualStyleBackColor = False
        '
        'btnEnvio
        '
        Me.btnEnvio.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEnvio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnvio.ForeColor = System.Drawing.Color.White
        Me.btnEnvio.Location = New System.Drawing.Point(136, 41)
        Me.btnEnvio.Name = "btnEnvio"
        Me.btnEnvio.Size = New System.Drawing.Size(118, 88)
        Me.btnEnvio.TabIndex = 18
        Me.btnEnvio.Text = "Realizar Envio"
        Me.ttMensaje.SetToolTip(Me.btnEnvio, "Lleva al formulario para realizar un envio")
        Me.btnEnvio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 34)
        Me.Label1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FrmMenuAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(265, 225)
        Me.Controls.Add(Me.btnEnvio)
        Me.Controls.Add(Me.btnNuevocliente)
        Me.Controls.Add(Me.btnCerrarSecion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMenuAtencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu atencion al cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents btnCerrarSecion As Button
    Friend WithEvents btnNuevocliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnvio As Button
End Class
