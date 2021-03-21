Public Class FrmEmpleado
    Private tabla As New DataTable
    Public bandera As New Boolean
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = DateTime.Now
        ComboBuscar.Text = "Nombre"
        dataListado.Columns.Item("Eliminar").Visible = False
        If (bandera = True) Then
            btnInsertar.Visible = False
            CheckEliminar.Visible = False
            btnCerrarSecion.Text = "Cargar"
        End If
        Mostrar()
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New FrmEmpleado
        Me.Close()
        Formulario.Show()
    End Sub

    Private Sub Mostrar()
        Try
            Dim funciones As New FEmpleado
            tabla = funciones.MostrarM
            If tabla.Rows.Count <> 0 Then
                dataListado.DataSource = tabla
                dataListado.ColumnHeadersVisible = True
            Else
                dataListado.DataSource = Nothing
                dataListado.ColumnHeadersVisible = False
            End If
        Catch evento As Exception
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim data As New DataSet
            data.Tables.Add(tabla.Copy)
            Dim vista As New DataView(data.Tables(0))
            vista.RowFilter = "emp" & ComboBuscar.Text & " like '" & txtBuscar.Text & "%'"
            If (vista.Count <> 0) Then
                dataListado.DataSource = vista
                ocultarColumnas()
            Else
                dataListado.DataSource = Nothing
            End If
        Catch evento As Exception
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ocultarColumnas()
        Try
            dataListado.Columns(1).Visible = False
            If (bandera = True) Then
                For i = 0 To dataListado.Rows.Count - 1
                    If (dataListado.Item(8, i).Value <> "Mensajero") Then
                        dataListado.Rows(i).Visible = False
                    End If
                Next
            End If
        Catch evento As Exception
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        BtnGuardar.Visible = True
        btnInsertar.Visible = False
        CheckEliminar.Visible = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If (bandera = True) Then
            BtnCancelar.Visible = False
        Else
            BtnCancelar.Visible = True
        End If
        gbPersonal.Visible = True
        Me.Width = 816
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtIdentidad.Text <> "" And txtCorreo.Text <> "" And comboPuesto.Text <> "" And txtUsuario.Text <> "" And txtContraseña.Text <> "") Then
            Try
                Dim Entidad As New EEmpleado
                Dim funciones As New FEmpleado
                If (funciones.Mostrar1(txtUsuario.Text, txtContraseña.Text) <> "No encontrado") Then
                    MsgBox("Lo sentimos Pero El Usuario ya esta Registrado intente con otro", MsgBoxStyle.Information, "Usuario existente")
                Else
                    Entidad.PempNombre = txtNombre.Text
                    Entidad.PempApellido = txtApellido.Text
                    Entidad.PempDireccion = txtDireccion.Text
                    Entidad.PempTelefono = txtTelefono.Text
                    Entidad.PempIdentidad = txtIdentidad.Text
                    Entidad.PempCorreo = txtCorreo.Text
                    Entidad.PempPuesto = comboPuesto.Text
                    Entidad.PempFechaIngreso = dtpFecha.Value
                    Entidad.PempUsuario = txtUsuario.Text
                    Entidad.PempContraseña = txtContraseña.Text
                    If (funciones.Insertar(Entidad)) Then
                        MessageBox.Show("El Empleado fue registrada correctamente", "Guardado registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo registrar el Empleado", "Guardando registo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Limpiar()
                End If
            Catch evento As Exception
                MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If (txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtIdentidad.Text <> "" And txtCorreo.Text <> "" And comboPuesto.Text <> "" And txtUsuario.Text <> "" And txtContraseña.Text <> "") Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Desea Modificar los datos", "Confirmacion de actualizacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (resultado = Windows.Forms.DialogResult.OK) Then
                Try
                    Dim Entidad As New EEmpleado
                    Dim funciones As New FEmpleado
                    If (funciones.Mostrar1(txtUsuario.Text, txtContraseña.Text) <> "No encontrado") Then
                        MsgBox("Lo sentimos Pero El Usuario ya esta Registrado intente con otro", MsgBoxStyle.Information, "Usuario existente")
                    Else
                        Entidad.PempCodigo = txtCodigo.Text
                        Entidad.PempNombre = txtNombre.Text
                        Entidad.PempApellido = txtApellido.Text
                        Entidad.PempDireccion = txtDireccion.Text
                        Entidad.PempTelefono = txtTelefono.Text
                        Entidad.PempIdentidad = txtIdentidad.Text
                        Entidad.PempCorreo = txtCorreo.Text
                        Entidad.PempPuesto = comboPuesto.Text
                        Entidad.PempFechaIngreso = dtpFecha.Value
                        Entidad.PempUsuario = txtUsuario.Text
                        Entidad.PempContraseña = txtContraseña.Text
                        If (funciones.Actualizar(Entidad)) Then
                            MessageBox.Show("Los datos del Empleado fue actualizada correctamente", "actualizada registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se pudo actualizar los datos del Empleado", "Fallo al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        Limpiar()
                    End If
                Catch evento As Exception
                    MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MessageBox.Show("Cancelado por el usuario", "Actualizando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        trasladoInformacion()
        If bandera = True Then
            gbPersonal.Enabled = False
            BtnActualizar.Visible = False
        Else
            BtnActualizar.Visible = True
            btnInsertar.Visible = False
            BtnGuardar.Visible = False
        End If
        Habilitar()

    End Sub

    Private Sub trasladoInformacion()
        txtCodigo.Text = dataListado.SelectedCells.Item(1).Value
        txtNombre.Text = dataListado.SelectedCells.Item(2).Value
        txtApellido.Text = dataListado.SelectedCells.Item(3).Value
        txtIdentidad.Text = dataListado.SelectedCells.Item(4).Value
        txtTelefono.Text = dataListado.SelectedCells.Item(5).Value
        txtCorreo.Text = dataListado.SelectedCells.Item(6).Value
        txtDireccion.Text = dataListado.SelectedCells.Item(7).Value
        comboPuesto.Text = dataListado.SelectedCells.Item(8).Value
        dtpFecha.Value = dataListado.SelectedCells.Item(9).Value
        txtUsuario.Text = dataListado.SelectedCells.Item(10).Value
        txtContraseña.Text = dataListado.SelectedCells.Item(11).Value
    End Sub

    Private Sub CheckEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEliminar.CheckedChanged
        If (CheckEliminar.CheckState = CheckState.Checked) Then
            dataListado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
            gbPersonal.Enabled = False
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
            BtnEliminar.Visible = False
            gbPersonal.Enabled = True
        End If

    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If (e.ColumnIndex = Me.dataListado.Columns.Item("Eliminar").Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
        btnInsertar.Visible = False
        BtnGuardar.Visible = False
        If (bandera = True) Then
            BtnActualizar.Visible = False
        Else
            BtnActualizar.Visible = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Seguro que desea eliminar", "Confirmacion de eliminacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (resultado = Windows.Forms.DialogResult.OK) Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcada As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If (marcada) Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("empCodigo").Value)
                        Dim Entidad As New EEmpleado
                        Dim Funciones As New FEmpleado
                        Entidad.PempCodigo = llavePrimaria
                        If (Funciones.Eliminar(Entidad)) Then
                            MessageBox.Show("El Empleado fue Despedido correctamente", "Eliminada registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se pudo despedir al Empleado", "Fallo al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
            Catch evento As Exception
                MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Cancelado por el usuario", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Limpiar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub

    Private Sub btnCerrarSecion_Click(sender As Object, e As EventArgs) Handles btnCerrarSecion.Click
        If bandera = True Then
            Me.Close()
        Else
            Dim Formulario As New FrmLogin
            Formulario.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtBuscar_MouseHover(sender As Object, e As EventArgs) Handles txtBuscar.MouseHover
        ttMensaje.SetToolTip(txtBuscar, "Buscar por medio del: " & ComboBuscar.Text)
        ttMensaje.ToolTipTitle = "Buscar"
    End Sub

    Private Sub CheckEliminar_MouseHover(sender As Object, e As EventArgs) Handles CheckEliminar.MouseHover
        ttMensaje.SetToolTip(CheckEliminar, "Activa la columna de eliminacion de datos")
        ttMensaje.ToolTipTitle = "Eliminar"
    End Sub

    Private Sub ComboBuscar_MouseHover(sender As Object, e As EventArgs) Handles ComboBuscar.MouseHover
        ttMensaje.ToolTipTitle = "Filtrar"
    End Sub

    Private Sub dataListado_MouseHover(sender As Object, e As EventArgs) Handles dataListado.MouseHover
        ttMensaje.ToolTipTitle = "Registros"
    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover
        ttMensaje.ToolTipTitle = "Eliminar"
        BtnEliminar.ForeColor = Color.Gold
    End Sub

    Private Sub btnCerrarSecion_MouseHover(sender As Object, e As EventArgs) Handles btnCerrarSecion.MouseHover
        If bandera = True Then
            BtnCancelar.ForeColor = Color.Gold
            ttMensaje.ToolTipTitle = "Cargar elementos"
            ttMensaje.SetToolTip(btnCerrarSecion, "Sirve para enviar los elementos al Formulario que lo abrio")

        Else
            ttMensaje.ToolTipTitle = "Cerrar Seccion"
            btnCerrarSecion.BackgroundImage = Proyecto_Final.My.Resources.Salir
            btnCerrarSecion.Text = ""
        End If

    End Sub

    Private Sub btnCerrarSecion_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrarSecion.MouseLeave
        If bandera = True Then
            BtnEliminar.ForeColor = Color.White
        Else
            btnCerrarSecion.BackgroundImage = Nothing
            btnCerrarSecion.Text = "Cerrar Sesion"
        End If
    End Sub

    Private Sub BtnCancelar_MouseHover(sender As Object, e As EventArgs) Handles BtnCancelar.MouseHover
        ttMensaje.ToolTipTitle = "Cancelar"
        BtnCancelar.ForeColor = Color.Gold
    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover
        ttMensaje.ToolTipTitle = "Actualizar"
        BtnActualizar.ForeColor = Color.Gold
    End Sub

    Private Sub BtnGuardar_MouseHover(sender As Object, e As EventArgs) Handles BtnGuardar.MouseHover
        ttMensaje.ToolTipTitle = "Guardar"
        BtnGuardar.ForeColor = Color.Gold
    End Sub

    Private Sub btnInsertar_MouseHover(sender As Object, e As EventArgs) Handles btnInsertar.MouseHover
        ttMensaje.ToolTipTitle = "Inseratar"
        btnInsertar.ForeColor = Color.Gold
    End Sub

    Private Sub BtnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles BtnEliminar.MouseLeave
        BtnEliminar.ForeColor = Color.White
    End Sub

    Private Sub btnInsertar_MouseLeave(sender As Object, e As EventArgs) Handles btnInsertar.MouseLeave
        btnInsertar.ForeColor = Color.White
    End Sub

    Private Sub BtnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles BtnGuardar.MouseLeave
        BtnGuardar.ForeColor = Color.White
    End Sub

    Private Sub BtnActualizar_MouseLeave(sender As Object, e As EventArgs) Handles BtnActualizar.MouseLeave
        BtnActualizar.ForeColor = Color.White
    End Sub

    Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancelar.MouseLeave
        BtnCancelar.ForeColor = Color.White
    End Sub

    Private Sub gbPersonal_MouseHover(sender As Object, e As EventArgs) Handles gbPersonal.MouseHover
        ttMensaje.ToolTipTitle = "Registros Particulares"
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, caracter As KeyPressEventArgs) Handles txtNombre.KeyPress
        caracter.Handled = Procesos.ValidarString(caracter.KeyChar)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtApellido.KeyPress
        Caracter.Handled = Procesos.ValidarString(Caracter.KeyChar)
    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, caracter As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        caracter.Handled = Procesos.ValidarInteger(caracter.KeyChar)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, caracter As KeyPressEventArgs) Handles txtTelefono.KeyPress
        caracter.Handled = Procesos.ValidarInteger(caracter.KeyChar)
    End Sub

End Class