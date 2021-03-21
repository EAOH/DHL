Public Class FrmEnvio
    Private tablaEnvio As New DataTable
    Private TablaOtrosGastos As New DataTable
    Private Sub FrmEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBuscar.Text = "Descripcion"
        FrmArticulos.Show()
        For i = 0 To FrmArticulos.dataListado.Rows.Count - 1
            Listart.Items.Add(FrmArticulos.dataListado.Item(2, i).Value)
        Next
        FrmArticulos.Close()
        Mostrar()
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New FrmEnvio
        Me.Close()
        Formulario.Show()
    End Sub

    Private Sub Mostrar()
        Try
            Dim funciones As New FEnvios
            tablaEnvio = funciones.Mostrar
            dataListado.Columns.Item("Eliminar").Visible = False
            If tablaEnvio.Rows.Count <> 0 Then
                dataListado.DataSource = tablaEnvio
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

    Private Sub mostrarotga()

        Try
            Dim Funcion As New FServicioEnvio
            Dim Entidad As New EServicioEnvio
            Entidad.EnvCodigo1 = txtCodigo.Text
            TablaOtrosGastos = Funcion.Mostrar(Entidad)
            datalistadootga.Columns.Item(0).Visible = False
            If TablaOtrosGastos.Rows.Count <> 0 Then
                datalistadootga.DataSource = TablaOtrosGastos
                datalistadootga.ColumnHeadersVisible = True
                ocultarColumnaProduto()
            Else
                datalistadootga.DataSource = Nothing
                datalistadootga.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim data As New DataSet
            data.Tables.Add(tablaEnvio.Copy)
            Dim vista As New DataView(data.Tables(0))
            vista.RowFilter = "env" & ComboBuscar.Text & " like '" & txtBuscar.Text & "%'"
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
            dataListado.Columns(4).Visible = False
            dataListado.Columns(8).Visible = False
            dataListado.Columns(14).Visible = False
            dataListado.Columns(18).Visible = False
            dataListado.Columns(25).Visible = False
            dataListado.Columns(36).Visible = False
        Catch evento As Exception
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ocultarColumnaProduto()
        datalistadootga.Columns(1).Visible = False
        datalistadootga.Columns(7).Visible = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        tcDatos.SelectedIndex = 0
        BtnGuardar.Visible = True
        btnInsertar.Visible = False
        CheckEliminar.Visible = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        BtnCancelar.Visible = True
        tcDatos.Visible = True
        Me.Width = 825
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (txtpaiCodigo.Text <> "" And comboTipo.Text <> "" And comboPago.Text <> "" And txtcliECodigo.Text <> "" And txtcliRCodigo.Text <> "" And txtempCodigo.Text <> "" And txtDescripcion.Text <> "" And txtDimencion.Text <> "" And txtPeso.Text <> "" And txtzonCodigo.Text <> "" And txtalmCodigo.Text <> "") Then
            Try
                Dim Entidad As New EEnvios
                Dim funciones As New FEnvios
                Entidad.EnvTipoServicio1 = comboTipo.Text
                Entidad.EnvTipoPago1 = comboPago.Text
                Entidad.EnvDescripcion1 = txtDescripcion.Text
                Entidad.EnvPesoKG1 = txtPeso.Text
                Entidad.EnvDimenciones1 = txtDimencion.Text
                Entidad.EnvDiasAlmacenados1 = nudDias.Value
                Entidad.CliCodigoE1 = txtcliECodigo.Text
                Entidad.CliCodigoR1 = txtcliRCodigo.Text
                Entidad.EmpCodigo1 = txtempCodigo.Text
                Entidad.PaiCodigoD1 = txtpaiCodigo.Text
                Entidad.ZonCodigo1 = txtzonCodigo.Text
                Entidad.AlmCodigo1 = txtalmCodigo.Text
                If (funciones.Insertar(Entidad)) Then
                    MessageBox.Show("El registro fue registrada correctamente", "Guardado registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se pudo registrar el registro", "Guardando registo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                'Limpiar()
                Mostrar()
                dataListado.Rows(0).Selected = True
                trasladoInformacion()
                gbOtga.Enabled = True
            Catch evento As Exception
                MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If (txtpaiCodigo.Text <> "" And comboTipo.Text <> "" And comboPago.Text <> "" And txtcliECodigo.Text <> "" And txtcliRCodigo.Text <> "" And txtempCodigo.Text <> "" And txtDescripcion.Text <> "" And txtDimencion.Text <> "" And txtPeso.Text <> "" And txtzonCodigo.Text <> "" And txtalmCodigo.Text <> "") Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Desea Modificar los datos", "Confirmacion de actualizacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (resultado = Windows.Forms.DialogResult.OK) Then
                Try
                    Dim Entidad As New EEnvios
                    Dim funciones As New FEnvios
                    Entidad.EnvCodigo1 = txtCodigo.Text
                    Entidad.EnvTipoServicio1 = comboTipo.Text
                    Entidad.EnvTipoPago1 = comboPago.Text
                    Entidad.EnvDescripcion1 = txtDescripcion.Text
                    Entidad.EnvPesoKG1 = txtPeso.Text
                    Entidad.EnvDimenciones1 = txtDimencion.Text
                    Entidad.EnvDiasAlmacenados1 = nudDias.Value
                    Entidad.CliCodigoE1 = txtcliECodigo.Text
                    Entidad.CliCodigoR1 = txtcliRCodigo.Text
                    Entidad.EmpCodigo1 = txtempCodigo.Text
                    Entidad.PaiCodigoD1 = txtpaiCodigo.Text
                    Entidad.ZonCodigo1 = txtzonCodigo.Text
                    Entidad.AlmCodigo1 = txtalmCodigo.Text
                    If (funciones.Actualizar(Entidad)) Then
                        MessageBox.Show("El registro fue actualizada correctamente", "actualizada registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo actualizar el registro", "Fallo al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    gbOtga.Enabled = True
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
        tcDatos.SelectedIndex = 0
        trasladoInformacion()
        mostrarotga()
        If datalistadootga.Rows.Count <> 0 Then
            datalistadootga.Rows(0).Selected = True
            trasladoInformacionOtga()
        End If
        BtnActualizar.Visible = True
        btnInsertar.Visible = False
        BtnGuardar.Visible = False
        datalistadootga.Enabled = True
        Habilitar()
        gbOtga.Enabled = True
        btnCalcular.Visible = True

    End Sub

    Private Sub trasladoInformacion()
        txtCodigo.Text = dataListado.SelectedCells.Item(1).Value
        comboTipo.Items.Add(dataListado.SelectedCells.Item(2).Value)
        comboTipo.Text = dataListado.SelectedCells.Item(2).Value
        comboPago.Text = dataListado.SelectedCells.Item(3).Value
        txtcliECodigo.Text = dataListado.SelectedCells.Item(4).Value
        txtcliENombre.Text = dataListado.SelectedCells.Item(5).Value & " " & dataListado.SelectedCells.Item(6).Value
        txtcliEDireccion.Text = dataListado.SelectedCells.Item(7).Value
        txtcliRCodigo.Text = dataListado.SelectedCells.Item(8).Value
        txtcliRNombre.Text = dataListado.SelectedCells.Item(9).Value & " " & dataListado.SelectedCells.Item(10).Value
        txtcliRDireccion.Text = dataListado.SelectedCells.Item(11).Value
        txtcliRId.Text = dataListado.SelectedCells.Item(12).Value
        txtcliRtel.Text = dataListado.SelectedCells.Item(13).Value
        txtempCodigo.Text = dataListado.SelectedCells.Item(14).Value
        txtempNombre.Text = dataListado.SelectedCells.Item(15).Value & " " & dataListado.SelectedCells.Item(16).Value
        txtempPuesto.Text = dataListado.SelectedCells.Item(17).Value
        txtpaiCodigo.Text = dataListado.SelectedCells.Item(18).Value
        txtpaiPais.Text = dataListado.SelectedCells.Item(19).Value
        txtpaiZona.Text = dataListado.SelectedCells.Item(20).Value
        txtDescripcion.Text = dataListado.SelectedCells.Item(21).Value
        txtDimencion.Text = dataListado.SelectedCells.Item(22).Value
        txtPeso.Text = dataListado.SelectedCells.Item(23).Value
        nudDias.Value = dataListado.SelectedCells.Item(24).Value
        txtzonCodigo.Text = dataListado.SelectedCells.Item(25).Value
        If (txtpaiZona.Text = 1) Then
            txtzon.Text = dataListado.SelectedCells.Item(26).Value
        ElseIf (txtpaiZona.Text = 2) Then
            txtzon.Text = dataListado.SelectedCells.Item(27).Value
        ElseIf (txtpaiZona.Text = 3) Then
            txtzon.Text = dataListado.SelectedCells.Item(28).Value
        ElseIf (txtpaiZona.Text = 4) Then
            txtzon.Text = dataListado.SelectedCells.Item(29).Value
        ElseIf (txtpaiZona.Text = 5) Then
            txtzon.Text = dataListado.SelectedCells.Item(30).Value
        ElseIf (txtpaiZona.Text = 6) Then
            txtzon.Text = dataListado.SelectedCells.Item(31).Value
        ElseIf (txtpaiZona.Text = 7) Then
            txtzon.Text = dataListado.SelectedCells.Item(32).Value
        End If
        txtzonTipo.Text = dataListado.SelectedCells.Item(33).Value
        txtzonCiudad.Text = dataListado.SelectedCells.Item(34).Value
        txtalmCodigo.Text = dataListado.SelectedCells.Item(35).Value
        txtalmCiudad.Text = dataListado.SelectedCells.Item(36).Value
        txtalmTipoA.Text = dataListado.SelectedCells.Item(37).Value
        txtalmTipoC.Text = dataListado.SelectedCells.Item(38).Value
        txtalmCosto.Text = dataListado.SelectedCells.Item(39).Value
        txtalmTramoI.Text = dataListado.SelectedCells.Item(40).Value
        txtalmTramoF.Text = dataListado.SelectedCells.Item(41).Value
    End Sub

    Private Sub CheckEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEliminar.CheckedChanged
        If (CheckEliminar.CheckState = CheckState.Checked) Then
            dataListado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
            tcDatos.Enabled = False
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
            BtnEliminar.Visible = False
            tcDatos.Enabled = True
        End If

    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        tcDatos.SelectedIndex = 0
        If (e.ColumnIndex = Me.dataListado.Columns.Item("Eliminar").Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
        btnInsertar.Visible = False
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Seguro que desea eliminar", "Confirmacion de eliminacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (resultado = Windows.Forms.DialogResult.OK) Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcada As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If (marcada) Then
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("envCodigo").Value)
                        Dim Entidad As New EEnvios
                        Dim Funciones As New FEnvios
                        Entidad.EnvCodigo1 = llavePrimaria
                        Funciones.EliminarTodo(Entidad)
                        If (Funciones.Eliminar(Entidad)) Then
                            MessageBox.Show("El registro fue eliminado correctamente", "Eliminada registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se pudo Eliminar el registro", "Fallo al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Dim Formulario As New FrmMenuAtencion
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub txtBuscar_MouseHover(sender As Object, e As EventArgs) Handles txtBuscar.MouseHover
        ttMensaje.SetToolTip(txtBuscar, "Buscar por medio del: " & ComboBuscar.Text)
        ttMensaje.ToolTipTitle = "Buscar"
    End Sub

    Private Sub CheckEliminar_MouseHover(sender As Object, e As EventArgs) Handles CheckEliminar.MouseHover
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

    Private Sub btnVolver_MouseHover(sender As Object, e As EventArgs) Handles btnVolver.MouseHover

        ttMensaje.ToolTipTitle = "Volver al menu Principal"

        btnVolver.ForeColor = Color.Gold
    End Sub

    Private Sub btnVolver_MouseLeave(sender As Object, e As EventArgs) Handles btnVolver.MouseLeave
        BtnEliminar.ForeColor = Color.White
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

    Private Sub tcDatos_MouseHover(sender As Object, e As EventArgs) Handles tcDatos.MouseHover
        ttMensaje.ToolTipTitle = "Registros Particulares"
    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover
        ttMensaje.ToolTipTitle = "Agregar"
        btnAgregar.ForeColor = Color.Gold
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.ForeColor = Color.White
    End Sub


    Private Sub btnCargar_MouseHover(sender As Object, e As EventArgs) Handles btnCargar.MouseHover
        ttMensaje.ToolTipTitle = "Cargar"
        btnCargar.ForeColor = Color.Gold
    End Sub

    Private Sub btnCargar_MouseLeave(sender As Object, e As EventArgs) Handles btnCargar.MouseLeave
        btnCargar.ForeColor = Color.White
    End Sub

    Private Sub btnQuitar_MouseHover(sender As Object, e As EventArgs) Handles btnQuitar.MouseHover
        ttMensaje.ToolTipTitle = "Quitar"
        btnQuitar.ForeColor = Color.Gold
    End Sub

    Private Sub btnQuitar_MouseLeave(sender As Object, e As EventArgs) Handles btnQuitar.MouseLeave
        btnQuitar.ForeColor = Color.White
    End Sub

    Private Sub btnPais_Click(sender As Object, e As EventArgs) Handles btnPais.Click
        comboTipo.Items.Clear()
        comboTipo.Enabled = True
        Dim Formulario As New FrmPais
        Formulario.bandera = True
        Formulario.ShowDialog()
        txtpaiCodigo.Text = Formulario.txtCodigo.Text
        txtpaiPais.Text = Formulario.txtNombre.Text
        txtpaiZona.Text = Formulario.comboZona.Text
        If (Formulario.checkEw.Checked = True) Then
            comboTipo.Items.Add(Formulario.checkEw.Text)
        End If
        If (Formulario.checkE12.Checked = True) Then
            comboTipo.Items.Add(Formulario.checkE12.Text)
        End If
        If (Formulario.checkE9.Checked = True) Then
            comboTipo.Items.Add(Formulario.checkE9.Text)
        End If
        If (Formulario.checkImportar.Checked = True) Then
            comboTipo.Items.Add(Formulario.checkImportar.Text)
        End If
        If (txtPeso.Text <> "" And txtpaiZona.Text <> "" And txtDimencion.Text <> "") Then
            btnZon.Enabled = True
        Else
            btnZon.Enabled = False
        End If
    End Sub

    Private Sub btncliE_Click(sender As Object, e As EventArgs) Handles btncliE.Click
        Dim Formulario As New FrmCliente
        Formulario.bandera = True
        Formulario.ShowDialog()
        txtcliECodigo.Text = Formulario.txtCodigo.Text
        txtcliENombre.Text = Formulario.txtNombre.Text & " " & Formulario.txtApellido.Text
        txtcliEDireccion.Text = Formulario.txtDireccion.Text

    End Sub

    Private Sub btncliR_Click(sender As Object, e As EventArgs) Handles btncliR.Click
        Dim Formulario As New FrmCliente
        Formulario.bandera = True
        Formulario.ShowDialog()
        txtcliRCodigo.Text = Formulario.txtCodigo.Text
        txtcliRNombre.Text = Formulario.txtNombre.Text & " " & Formulario.txtApellido.Text
        txtcliRDireccion.Text = Formulario.txtDireccion.Text
        txtcliRtel.Text = Formulario.txtTelefono.Text
        txtcliRId.Text = Formulario.txtIdentidad.Text
    End Sub

    Private Sub btnemp_Click(sender As Object, e As EventArgs) Handles btnemp.Click
        Dim Formulario As New FrmEmpleado
        Formulario.bandera = True
        Formulario.ShowDialog()
        txtempCodigo.Text = Formulario.txtCodigo.Text
        txtempNombre.Text = Formulario.txtNombre.Text & " " & FrmEmpleado.txtApellido.Text
        txtempPuesto.Text = Formulario.comboPuesto.Text
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        tcDatos.SelectedIndex = 1
    End Sub

    Private Sub txtPeso_TextChanged(sender As Object, e As EventArgs) Handles txtPeso.TextChanged
        If (txtPeso.Text <> "" And txtpaiZona.Text <> "" And txtDimencion.Text <> "") Then
            btnZon.Enabled = True
        Else
            btnZon.Enabled = False
        End If
        If (nudDias.Value = 0 Or txtDimencion.Text = "" Or txtPeso.Text = "") Then
            btnalm.Enabled = False
        Else
            btnalm.Enabled = True
        End If
    End Sub

    Private Sub txtDimencion_TextChanged(sender As Object, e As EventArgs) Handles txtDimencion.TextChanged
        If (txtPeso.Text <> "" And txtpaiZona.Text <> "" And txtDimencion.Text <> "") Then
            btnZon.Enabled = True
        Else
            btnZon.Enabled = False
        End If
        If (nudDias.Value = 0 Or txtDimencion.Text = "" Or txtPeso.Text = "") Then
            btnalm.Enabled = False
        Else
            btnalm.Enabled = True
        End If
    End Sub

    Private Sub btnZon_Click(sender As Object, e As EventArgs) Handles btnZon.Click
        Dim Formulario As New FrmZona
        Formulario.bandera = True
        Formulario.Peso = txtPeso.Text
        Formulario.Dimension = txtDimencion.Text
        Formulario.ShowDialog()
        txtzonCodigo.Text = Formulario.txtCodigo.Text
        If (txtpaiZona.Text = 1) Then
            txtzon.Text = Formulario.txtZona1.Text
        ElseIf (txtpaiZona.Text = 2) Then
            txtzon.Text = Formulario.txtZona2.Text
        ElseIf (txtpaiZona.Text = 3) Then
            txtzon.Text = Formulario.txtZona3.Text
        ElseIf (txtpaiZona.Text = 4) Then
            txtzon.Text = Formulario.txtZona4.Text
        ElseIf (txtpaiZona.Text = 5) Then
            txtzon.Text = Formulario.txtZona5.Text
        ElseIf (txtpaiZona.Text = 6) Then
            txtzon.Text = Formulario.txtZona6.Text
        ElseIf (txtpaiZona.Text = 7) Then
            txtzon.Text = Formulario.txtZona7.Text
        End If
        txtzonTipo.Text = Formulario.comboTipo.Text
        txtzonCiudad.Text = Formulario.txtCiudad.Text

    End Sub

    Private Sub nudDias_ValueChanged(sender As Object, e As EventArgs) Handles nudDias.ValueChanged
        If (nudDias.Value = 0 Or txtDimencion.Text = "" Or txtPeso.Text = "") Then
            btnalm.Enabled = False
        Else
            btnalm.Enabled = True
        End If

    End Sub

    Private Sub btnalm_Click(sender As Object, e As EventArgs) Handles btnalm.Click
        Dim Formulario As New FrmAlmacenaje
        Formulario.Dimension = txtDimencion.Text
        Formulario.Peso = txtPeso.Text
        Formulario.Dia = nudDias.Value
        Formulario.bandera = True
        Formulario.ShowDialog()
        txtalmCodigo.Text = Formulario.txtCodigo.Text
        txtalmCiudad.Text = Formulario.comboCiudad.Text
        txtalmTipoA.Text = Formulario.comboTipo.Text
        txtalmTipoC.Text = Formulario.comboTipoCarga.Text
        txtalmCosto.Text = Formulario.txtCostoFijo.Text
        txtalmTramoI.Text = Formulario.txtTramoI.Text
        txtalmTramoF.Text = Formulario.txtTramoF.Text
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        tcDatos.SelectedIndex = 0

    End Sub

    Private Sub txtDimencion_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtDimencion.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtDimencion.Text)
    End Sub

    Private Sub txtDimencion_LostFocus(sender As Object, e As EventArgs) Handles txtDimencion.LostFocus
        txtDimencion.Text = Procesos.Textopunto(txtDimencion.Text)
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtPeso.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtPeso.Text)
    End Sub

    Private Sub txtPeso_LostFocus(sender As Object, e As EventArgs) Handles txtPeso.LostFocus
        txtPeso.Text = Procesos.Textopunto(txtPeso.Text)
    End Sub

    Private Sub datalistadootga_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadootga.CellContentClick
        If e.ColumnIndex = Me.datalistadootga.Columns.Item(0).Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadootga.Rows(e.RowIndex).Cells(0)
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistadootga_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistadootga.CellClick
        trasladoInformacionOtga()
        gbOtga.Enabled = True
        dehabilitar()
    End Sub
    Private Sub dehabilitar()
        tcDatos.SelectedIndex = 2
        Habilitar()
        dataListado.Enabled = False
        CheckEliminar.Enabled = False
        ComboBuscar.Enabled = False
        txtBuscar.Enabled = False
        btnAgregar.Visible = False
        BtnActualizar.Visible = False
        BtnGuardar.Visible = False
        btnCalcular.Visible = False
    End Sub

    Private Sub trasladoInformacionOtga()
        lbTarifa.Text = "Tarifa"
        txtotgaCodigo.Text = dataListado.SelectedCells.Item(1).Value
        txtotgaDescripcion.Text = dataListado.SelectedCells.Item(2).Value
        txtotgaTipo.Text = dataListado.SelectedCells.Item(3).Value

        Dim Cobro(3) As Double
        Dim Total As Double = 0
        If (comboTipo.Text = "DHL Express 9:00") Then
            Total += 20
        ElseIf (comboTipo.Text = "DHL Express 12:00 ") Then
            Total += 8
        End If
        Total += Val(txtzon.Text)
        If (txtalmTipoA.Text = "Estatico") Then
            Total += Val(txtalmCosto.Text)
        ElseIf (txtalmTipoA.Text = "Especial") Then
            If (Val(txtPeso.Text) > (Val(txtDimencion.Text) / 5000)) Then
                Total += (((nudDias.Value * Val(txtPeso.Text) * Val(txtalmTramoI.Text)) + 3.94) + (Val(txtPeso.Text) * Val(txtalmTramoF.Text)) + Val(txtalmCosto.Text))
                Cobro(2) = (datalistadootga.SelectedCells.Item(6).Value * Val(txtPeso.Text))
            Else
                Total += (((nudDias.Value * Val(txtDimencion.Text) * Val(txtalmTramoI.Text)) + 3.94) + (Val(txtDimencion.Text) * Val(txtalmTramoF.Text)) + Val(txtalmCosto.Text))
                Cobro(2) = (datalistadootga.SelectedCells.Item(6).Value * Val(txtDimencion.Text))
            End If
        End If
        Cobro(0) = datalistadootga.SelectedCells.Item(4).Value
        Cobro(1) = (Total * (datalistadootga.SelectedCells.Item(5).Value / 100))
        If (Cobro(0) = Cobro.Max) Then
            lbTarifa.Text &= " Fija"
            txtotgaTarifa.Text = datalistadootga.SelectedCells.Item(4).Value
        ElseIf (Cobro(1) = Cobro.Max) Then
            lbTarifa.Text &= " En Porcentaje"
            txtotgaTarifa.Text = datalistadootga.SelectedCells.Item(5).Value
        ElseIf (Cobro(2) = Cobro.Max) Then
            lbTarifa.Text &= " Por peso"
            txtotgaTarifa.Text = datalistadootga.SelectedCells.Item(6).Value
        End If
        txtotgaPrecioT.Text = Cobro.Max
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        lbTarifa.Text = "Tarifa"
        btnCargar.Visible = True
        btnAgregar.Visible = False
        Dim Formulario As New FrmOtrosGastos
        Formulario.bandera = True
        Formulario.ShowDialog()
        tcDatos.SelectedIndex = 2
        txtotgaCodigo.Text = Formulario.txtCodigo.Text
        txtotgaDescripcion.Text = Formulario.txtDescripcion.Text
        txtotgaTipo.Text = Formulario.comboTipo.Text

        Dim Cobro(3) As Double
        Dim Total As Double = 0
        If (comboTipo.Text = "DHL Express 9:00") Then
            Total += 20
        ElseIf (comboTipo.Text = "DHL Express 12:00 ") Then
            Total += 8
        End If
        Total += Val(txtzon.Text)
        If (txtalmTipoA.Text = "Estatico") Then
            Total += Val(txtalmCosto.Text)
        ElseIf (txtalmTipoA.Text = "Especial") Then
            If (Val(txtPeso.Text) > (Val(txtDimencion.Text) / 5000)) Then
                Total += (((nudDias.Value * Val(txtPeso.Text) * Val(txtalmTramoI.Text)) + 3.94) + (Val(txtPeso.Text) * Val(txtalmTramoF.Text)) + Val(txtalmCosto.Text))
                Cobro(2) = (Val(Formulario.txtPeso.Text) * Val(txtPeso.Text))
            Else
                Total += (((nudDias.Value * Val(txtDimencion.Text) * Val(txtalmTramoI.Text)) + 3.94) + (Val(txtDimencion.Text) * Val(txtalmTramoF.Text)) + Val(txtalmCosto.Text))
                Cobro(2) = (Val(Formulario.txtPeso.Text) * Val(txtDimencion.Text))
            End If
        End If
        Cobro(0) = Val(Formulario.txtFijo.Text)
        Cobro(1) = (Total * (Val(Formulario.txtPorcentaje.Text) / 100))
        If (Cobro(0) = Cobro.Max) Then
            lbTarifa.Text &= " Fija"
            txtotgaTarifa.Text = Formulario.txtFijo.Text
        ElseIf (Cobro(1) = Cobro.Max) Then
            lbTarifa.Text &= " En Porcentaje"
            txtotgaTarifa.Text = Formulario.txtPorcentaje.Text
        ElseIf (Cobro(2) = Cobro.Max) Then
            lbTarifa.Text &= " Por peso"
            txtotgaTarifa.Text = Formulario.txtPeso.Text
        End If
        txtotgaPrecioT.Text = Cobro.Max
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If (txtotgaCodigo.Text <> "") Then
            Try
                Dim Entidad As New EServicioEnvio
                Dim Funciones As New FServicioEnvio
                Entidad.EnvCodigo1 = txtCodigo.Text
                Entidad.OtgaCodigo1 = txtotgaCodigo.Text
                If Funciones.Insertar(Entidad) Then
                    MessageBox.Show("registrado correctamente",
                                    "Guardando registro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                Else
                    MessageBox.Show("no fue registrado correctamente",
                                    "Guardando registro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End If
                mostrarotga()
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Desea insertar Servicio extra",
                                "Guardando registro", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
                If resultado = Windows.Forms.DialogResult.No Then
                    Limpiar()
                Else
                    btnCargar.Visible = False
                    btnAgregar.Visible = True
                    checkQuitar.Enabled = True
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar",
                            "Guardando registro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub checkQuitar_CheckedChanged(sender As Object, e As EventArgs) Handles checkQuitar.CheckedChanged
        If checkQuitar.CheckState = CheckState.Checked Then
            datalistadootga.Columns.Item(0).Visible = True
            btnQuitar.Visible = True
            btnAgregar.Visible = False
        Else
            datalistadootga.Columns.Item(0).Visible = False
            btnQuitar.Visible = False
            btnAgregar.Visible = True
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar los datos", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistadootga.Rows
                    Dim lineaMarcada As Boolean = Convert.ToBoolean(row.Cells(0).Value)
                    If lineaMarcada Then
                        Dim llavePrimaria1 As Integer = Convert.ToInt32(row.Cells(1).Value)
                        Dim llavePrimaria2 As Integer = Convert.ToInt32(row.Cells(7).Value)
                        Dim Entidad As New EServicioEnvio
                        Dim Funcion As New FServicioEnvio
                        Entidad.OtgaCodigo1 = llavePrimaria1
                        Entidad.EnvCodigo1 = llavePrimaria2
                        If Funcion.Eliminar(Entidad) Then
                            MessageBox.Show("fue eliminado correctamente",
                                            "Eliminando registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("no fue eliminado correctamente",
                                            "Elimando registro", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error)
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion por el usuario",
                         "Eliminando registro", MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
        End If
        Limpiar()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        txtPagoTipoServicio.Text = 0
        txtPagoZona.Text = 0
        txtPagoPorAlacenaje.Text = 0
        txtpagootga.Text = 0
        txttotal.Text = 0
        Dim Cobro(3) As Double
        tcDatos.SelectedIndex = 3
        If (comboTipo.Text = "DHL Express 9:00") Then
            txtPagoTipoServicio.Text = 20
        ElseIf (comboTipo.Text = "DHL Express 12:00 ") Then
            txtPagoTipoServicio.Text = 8
        End If
        txtPagoZona.Text = Val(txtzon.Text)
        If (txtalmTipoA.Text = "Estatico") Then
            txtPagoPorAlacenaje.Text = Val(txtalmCosto.Text)
        ElseIf (txtalmTipoA.Text = "Especial") Then
            If (Val(txtPeso.Text) > (Val(txtDimencion.Text) / 5000)) Then
                txtPagoPorAlacenaje.Text = (((nudDias.Value * Val(txtPeso.Text) * Val(txtalmTramoI.Text)) + 3.94) + (Val(txtPeso.Text) * Val(txtalmTramoF.Text)) + Val(txtalmCosto.Text))
            Else
                txtPagoPorAlacenaje.Text = (((nudDias.Value * Val(txtDimencion.Text) * Val(txtalmTramoI.Text)) + 3.94) + (Val(txtDimencion.Text) * Val(txtalmTramoF.Text)) + Val(txtalmCosto.Text))
            End If
        End If
        For index = 0 To datalistadootga.Rows.Count - 1
            If (Val(txtPeso.Text) > (Val(txtDimencion.Text) / 5000)) Then
                Cobro(2) = (datalistadootga.Item(6, index).Value * Val(txtPeso.Text))
            Else
                Cobro(2) = (datalistadootga.Item(6, index).Value * Val(txtDimencion.Text))
            End If
            Cobro(0) = datalistadootga.Item(4, index).Value
            Cobro(1) = ((Val(txtPagoTipoServicio.Text) + Val(txtPagoZona.Text) + Val(txtPagoPorAlacenaje.Text)) * (datalistadootga.Item(5, index).Value / 100))
            txtpagootga.Text += Cobro.Max
        Next
        txttotal.Text = (Val(txtPagoTipoServicio.Text) + Val(txtPagoZona.Text) + Val(txtPagoPorAlacenaje.Text) + Val(txtpagootga.Text))
        txtPagoTipoServicio.Text = Val(txtPagoTipoServicio.Text).ToString("C")
        txtPagoZona.Text = Val(txtPagoZona.Text).ToString("C")
        txtPagoPorAlacenaje.Text = Val(txtPagoPorAlacenaje.Text).ToString("C")
        txtpagootga.Text = Val(txtpagootga.Text).ToString("C")
        txttotal.Text = Val(txttotal.Text).ToString("C")
    End Sub

End Class