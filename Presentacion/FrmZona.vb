Public Class FrmZona
    Private tabla As New DataTable
    Public bandera As New Boolean
    Public Peso, Dimension As Double
    Private Sub FrmZona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBuscar.Text = "Tipo"
        dataListado.Columns.Item("Eliminar").Visible = False
        If (bandera = True) Then
            btnInsertar.Visible = False
            CheckEliminar.Visible = False
            btnVolver.Text = "Cargar"
        End If
        Mostrar()
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New FrmZona
        Me.Close()
        Formulario.Show()
    End Sub

    Private Sub Mostrar()
        Try
            Dim funciones As New FZona
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
            vista.RowFilter = "zon" & ComboBuscar.Text & " like '" & txtBuscar.Text & "%'"
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
                        If (Val(dataListado.Item(2, i).Value) <> Peso) Then
                            dataListado.Rows(i).Visible = False
                        End If
                    Next
                Else
                    For i = 0 To dataListado.Rows.Count - 1
                        If (Val(dataListado.Item(2, i).Value) <> (Dimension / 5000)) Then
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
        If (txtPeso.Text <> "" And comboTipo.Text <> "") Then
            Try
                Dim Entidad As New EZona
                Dim funciones As New FZona
                Entidad.ZonPeso1 = txtPeso.Text
                Entidad.Zon11 = txtZona1.Text
                Entidad.Zon21 = txtZona2.Text
                Entidad.Zon31 = txtZona3.Text
                Entidad.Zon41 = txtZona4.Text
                Entidad.Zon51 = txtZona5.Text
                Entidad.Zon61 = txtZona6.Text
                Entidad.Zon71 = txtZona7.Text
                Entidad.ZonTipo1 = comboTipo.Text
                Entidad.ZonCiudad1 = txtCiudad.Text
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
        If (txtPeso.Text <> "" And comboTipo.Text <> "") Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Desea Modificar los datos", "Confirmacion de actualizacion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (resultado = Windows.Forms.DialogResult.OK) Then
                Try
                    Dim Entidad As New EZona
                    Dim funciones As New FZona
                    Entidad.ZonCodigo1 = txtCodigo.Text
                    Entidad.ZonPeso1 = txtPeso.Text
                    Entidad.Zon11 = txtZona1.Text
                    Entidad.Zon21 = txtZona2.Text
                    Entidad.Zon31 = txtZona3.Text
                    Entidad.Zon41 = txtZona4.Text
                    Entidad.Zon51 = txtZona5.Text
                    Entidad.Zon61 = txtZona6.Text
                    Entidad.Zon71 = txtZona7.Text
                    Entidad.ZonTipo1 = comboTipo.Text
                    Entidad.ZonCiudad1 = txtCiudad.Text
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
        txtPeso.Text = dataListado.SelectedCells.Item(2).Value
        txtZona1.Text = dataListado.SelectedCells.Item(3).Value
        txtZona2.Text = dataListado.SelectedCells.Item(4).Value
        txtZona3.Text = dataListado.SelectedCells.Item(5).Value
        txtZona4.Text = dataListado.SelectedCells.Item(6).Value
        txtZona5.Text = dataListado.SelectedCells.Item(7).Value
        txtZona6.Text = dataListado.SelectedCells.Item(8).Value
        txtZona7.Text = dataListado.SelectedCells.Item(9).Value
        comboTipo.Text = dataListado.SelectedCells.Item(10).Value
        txtCiudad.Text = dataListado.SelectedCells.Item(11).Value
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
                        Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells("zonCodigo").Value)
                        Dim Entidad As New EZona
                        Dim Funciones As New FZona
                        Entidad.ZonCodigo1 = llavePrimaria
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

    Private Sub txtPeso_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtPeso.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtPeso.Text)
    End Sub

    Private Sub txtZona1_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona1.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona1.Text)
    End Sub

    Private Sub txtZona1_LostFocus(sender As Object, e As EventArgs) Handles txtZona1.LostFocus
        txtZona1.Text = Procesos.Textopunto(txtZona1.Text)
    End Sub

    Private Sub txtZona2_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona2.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona2.Text)
    End Sub

    Private Sub txtZona2_LostFocus(sender As Object, e As EventArgs) Handles txtZona2.LostFocus
        txtZona2.Text = Procesos.Textopunto(txtZona2.Text)
    End Sub

    Private Sub txtZona3_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona3.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona3.Text)
    End Sub

    Private Sub txtZona3_LostFocus(sender As Object, e As EventArgs) Handles txtZona3.LostFocus
        txtZona3.Text = Procesos.Textopunto(txtZona3.Text)
    End Sub

    Private Sub txtZona4_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona4.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona4.Text)
    End Sub

    Private Sub txtZona4_LostFocus(sender As Object, e As EventArgs) Handles txtZona4.LostFocus
        txtZona4.Text = Procesos.Textopunto(txtZona4.Text)
    End Sub

    Private Sub txtZona5_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona5.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona5.Text)
    End Sub

    Private Sub txtZona5_LostFocus(sender As Object, e As EventArgs) Handles txtZona5.LostFocus
        txtZona5.Text = Procesos.Textopunto(txtZona5.Text)
    End Sub

    Private Sub txtZona6_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona6.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona6.Text)
    End Sub

    Private Sub txtZona6_LostFocus(sender As Object, e As EventArgs) Handles txtZona6.LostFocus
        txtZona6.Text = Procesos.Textopunto(txtZona6.Text)
    End Sub

    Private Sub txtZona7_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtZona7.KeyPress
        Caracter.Handled = Procesos.ValidarDouble(Caracter.KeyChar, txtZona7.Text)
    End Sub

    Private Sub txtZona7_LostFocus(sender As Object, e As EventArgs) Handles txtZona7.LostFocus
        txtZona7.Text = Procesos.Textopunto(txtZona7.Text)
    End Sub

    Private Sub txtCiudad_KeyPress(sender As Object, Caracter As KeyPressEventArgs) Handles txtCiudad.KeyPress
        Caracter.Handled = Procesos.ValidarString(Caracter.KeyChar)
    End Sub

    Private Sub txtPeso_LostFocus(sender As Object, e As EventArgs) Handles txtPeso.LostFocus
        txtPeso.Text = Procesos.Textopunto(txtPeso.Text)
    End Sub

    Private Sub comboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipo.SelectedIndexChanged
        If (comboTipo.Text = "Local") Then
            txtZona2.Enabled = False
            txtZona3.Enabled = False
            txtZona4.Enabled = False
            txtZona5.Enabled = False
            txtZona6.Enabled = False
            txtZona7.Enabled = False
            txtZona2.Text = 0
            txtZona3.Text = 0
            txtZona4.Text = 0
            txtZona5.Text = 0
            txtZona6.Text = 0
            txtZona7.Text = 0
        Else
            txtZona2.Enabled = True
            txtZona3.Enabled = True
            txtZona4.Enabled = True
            txtZona5.Enabled = True
            txtZona6.Enabled = True
            txtZona7.Enabled = True
        End If
    End Sub

End Class