Public Class FrmAlmacenaje
    Private tabla As New DataTable
    Public bandera As New Boolean
    Public Peso, Dimension As Double
    Public Dia As Integer
    Private Sub FrmAlmacenaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBuscar.Text = "Ciudad"
        dataListado.Columns.Item("Eliminar").Visible = False
        If (bandera = True) Then
            btnInsertar.Visible = False
            CheckEliminar.Visible = False
            btnVolver.Text = "Cargar"
        End If
        Mostrar()
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New FrmAlmacenaje
        Me.Close()
        Formulario.Show()
    End Sub

    Private Sub Mostrar()
        Try
            Dim funciones As New FAlmacenaje
            tabla = funciones.Mostrar
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
            vista.RowFilter = "alm" & ComboBuscar.Text & " like '" & txtBuscar.Text & "%'"
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
                If (Peso > (Dimension / 5000)) Then
                    For i = 0 To dataListado.Rows.Count - 1
                        If ((Val(dataListado.Item(7, i).Value) > Peso Or Peso > Val(dataListado.Item(8, i).Value)) Or (Dia > Val(dataListado.Item(3, i).Value) Or Dia < Val(dataListado.Item(2, i).Value))) Then
                            dataListado.Rows(i).Visible = False
                        End If
                    Next
                Else
                    For i = 0 To dataListado.Rows.Count - 1
                        If ((Val(dataListado.Item(7, i).Value) > (Dimension / 5000) Or (Dimension / 5000) > Val(dataListado.Item(8, i).Value)) Or (Dia > Val(dataListado.Item(3, i).Value) Or Dia < Val(dataListado.Item(2, i).Value))) Then
                            dataListado.Rows(i).Visible = False
                        End If
                    Next
                End If
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
        If (comboTipoCarga.Text <> "" And comboTipo.Text <> "" And txtTramoI.Text <> "" And txtTramoF.Text <> "" And txtCostoFijo.Text <> "" And comboCiudad.Text <> "") Then
            Try
                Dim Entidad As New EAlmacenaje
                Dim funciones As New FAlmacenaje
                Entidad.AlmTipo1 = comboTipo.Text
                Entidad.AlmDiasmin1 = nudDiamin.Value
                Entidad.AlmDiasMAX1 = nudDiamax.Value
                Entidad.AlmTipoCagar1 = comboTipoCarga.Text
                Entidad.AlmTramoInicial1 = txtTramoI.Text
                Entidad.AlmTramoFinal1 = txtTramoF.Text
                Entidad.AlmPesomin1 = nudPesomin.Value
                Entidad.AlmPesoMax1 = nudPesomax.Value
                Entidad.AlmCostoFijo1 = txtCostoFijo.Text
                Entidad.AlmCiudad1 = comboCiudad.Text
                If (funciones.Insertar(Entidad)) Then
                    MessageBox.Show("El registro fue registrada correctamente", "Guardado registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se pudo registrar el registro", "Guardando registo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Limpiar()
            Catch evento As Exception
                MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If (comboTipoCarga.Text <> "" And comboTipo.Text <> "" And txtTramoI.Text <> "" And txtTramoF.Text <> "" And txtCostoFijo.Text <> "" And comboCiudad.Text <> "") Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Desea Modificar los datos", "Confirmacion de actualizacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (resultado = Windows.Forms.DialogResult.OK) Then
                Try
                    Dim Entidad As New EAlmacenaje
                    Dim funciones As New FAlmacenaje
                    Entidad.AlmCodigo1 = txtCodigo.Text
                    Entidad.AlmTipo1 = comboTipo.Text
                    Entidad.AlmDiasmin1 = nudDiamin.Value
                    Entidad.AlmDiasMAX1 = nudDiamax.Value
                    Entidad.AlmTipoCagar1 = comboTipoCarga.Text
                    Entidad.AlmTramoInicial1 = txtTramoI.Text
                    Entidad.AlmTramoFinal1 = txtTramoF.Text
                    Entidad.AlmPesomin1 = nudPesomin.Value
                    Entidad.AlmPesoMax1 = nudPesomax.Value
                    Entidad.AlmCostoFijo1 = txtCostoFijo.Text
                    Entidad.AlmCiudad1 = comboCiudad.Text
                    If (funciones.Actualizar(Entidad)) Then
                        MessageBox.Show("el registro fue actualizada correctamente", "actualizada registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo actualizar el registro", "Fallo al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Limpiar()
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
        nudDiamin.Value = dataListado.SelectedCells.Item(2).Value
        nudDiamax.Value = dataListado.SelectedCells.Item(3).Value
        comboTipoCarga.Text = dataListado.SelectedCells.Item(4).Value
        txtTramoI.Text = dataListado.SelectedCells.Item(5).Value
        txtTramoF.Text = dataListado.SelectedCells.Item(6).Value
        nudPesomin.Value = dataListado.SelectedCells.Item(7).Value
        nudPesomax.Value = dataListado.SelectedCells.Item(8).Value
        txtCostoFijo.Text = dataListado.SelectedCells.Item(9).Value
        comboTipo.Text = dataListado.SelectedCells.Item(10).Value
        comboCiudad.Text = dataListado.SelectedCells.Item(11).Value
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
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("almCodigo").Value)
                        Dim Entidad As New EAlmacenaje
                        Dim Funciones As New FAlmacenaje
                        Entidad.AlmCodigo1 = llavePrimaria
                        If (Funciones.Eliminar(Entidad)) Then
                            MessageBox.Show("el registro fue eliminado correctamente", "Eliminada registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If bandera = True Then
            Me.Close()
            bandera = False
        Else
            Dim Formulario As New FrmMenuAdministrador
            Formulario.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtBuscar_MouseHover(sender As Object, e As EventArgs) Handles txtBuscar.MouseHover
        ttMensaje.SetToolTip(txtBuscar, "Buscar por medio del: " & ComboBuscar.Text)
        ttMensaje.ToolTipTitle = "Buscar"
    End Sub

    Private Sub CheckEliminar_MouseHover(sender As Object, e As EventArgs) Handles CheckEliminar.MouseHover
        ttMensaje.SetToolTip(CheckEliminar, "Habilita la opcion de eliminar registro")
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
        If bandera = True Then
            ttMensaje.ToolTipTitle = "Cargar elementos"
            ttMensaje.SetToolTip(btnVolver, "Sirve para enviar los elementos al Formulario que lo abrio")

        Else
            ttMensaje.ToolTipTitle = "Volver Al menu Principal"
        End If
        btnVolver.ForeColor = Color.Gold
    End Sub

    Private Sub btnVolver_MouseLeave(sender As Object, e As EventArgs) Handles btnVolver.MouseLeave
        btnVolver.ForeColor = Color.White
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

    Private Sub txtTramoI_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtTramoI.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtTramoI.Text)
    End Sub

    Private Sub txtTramoF_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtTramoF.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtTramoF.Text)
    End Sub

    Private Sub txtTramoI_LostFocus(sender As Object, e As EventArgs) Handles txtTramoI.LostFocus
        txtTramoI.Text = Procesos.Textopunto(txtTramoI.Text)
    End Sub

    Private Sub txtTramoF_LostFocus(sender As Object, e As EventArgs) Handles txtTramoF.LostFocus
        txtTramoF.Text = Procesos.Textopunto(txtTramoF.Text)
    End Sub

    Private Sub txtCostoFijo_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtCostoFijo.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtCostoFijo.Text)
    End Sub

    Private Sub txtCostoFijo_LostFocus(sender As Object, e As EventArgs) Handles txtCostoFijo.LostFocus
        txtCostoFijo.Text = Procesos.Textopunto(txtCostoFijo.Text)
    End Sub

    Private Sub nudDiamin_ValueChanged(sender As Object, e As EventArgs) Handles nudDiamin.ValueChanged
        If (nudDiamin.Value >= nudDiamax.Value) Then
            nudDiamax.Value = nudDiamin.Value + 1
        End If
    End Sub

    Private Sub nudPesomin_ValueChanged(sender As Object, e As EventArgs) Handles nudPesomin.ValueChanged
        If (nudPesomin.Value >= nudPesomax.Value) Then
            nudPesomax.Value = nudPesomin.Value + 1
        End If
    End Sub

    Private Sub nudDiamax_ValueChanged(sender As Object, e As EventArgs) Handles nudDiamax.ValueChanged
        If (nudDiamax.Value <= nudDiamin.Value) Then
            nudDiamin.Value = nudDiamax.Value - 1
        End If

    End Sub

    Private Sub nudPesomax_ValueChanged(sender As Object, e As EventArgs) Handles nudPesomax.ValueChanged
        If (nudPesomax.Value <= nudPesomin.Value) Then
            nudPesomin.Value = nudPesomax.Value - 1
        End If

    End Sub
    Private Sub comboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipo.SelectedIndexChanged
        If (comboTipo.Text = "Estatico") Then
            txtTramoI.Text = 0
            txtTramoF.Text = 0
            txtTramoF.Enabled = False
            txtTramoI.Enabled = False
        Else
            txtTramoF.Enabled = True
            txtTramoI.Enabled = True
        End If
    End Sub

End Class