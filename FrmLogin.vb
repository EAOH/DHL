Public Class FrmLogin
    Dim Funcion As New FEmpleado
    Dim Puesto As String

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (txtUsuario.Text <> "" And txtContraseña.Text <> "") Then
            Puesto = Funcion.Mostrar1(txtUsuario.Text, txtContraseña.Text)
            If (Puesto = "No encontrado") Then
                MsgBox("Usuario o Contraseña Invalido.", MsgBoxStyle.Exclamation, Puesto)
                txtContraseña.Text = ""
                txtContraseña.Select()
            ElseIf (Puesto = "Recursos humanos") Then
                Dim Formulario As New FrmEmpleado
                Formulario.Show()
                Me.Hide()
                txtContraseña.Text = ""
                txtUsuario.Text = ""
            ElseIf (Puesto = "Atencion al cliente") Then
                Dim Formulario As New FrmMenuAtencion
                Formulario.Show()
                Me.Hide()
                txtContraseña.Text = ""
                txtUsuario.Text = ""
            ElseIf (Puesto = "Administrador") Then
                Dim Formulario As New FrmMenuAdministrador
                Formulario.Show()
                Me.Hide()
                txtContraseña.Text = ""
                txtUsuario.Text = ""
            Else
                MsgBox("No se permiten espacios en blanco", MsgBoxStyle.Information, "Faltan datos que llenar")
            End If
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ttMensaje.ToolTipTitle = "Usuario"
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        ttMensaje.ToolTipTitle = "Contraseña"
    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ttMensaje.ToolTipTitle = "Ingresar"
        btnIngresar.ForeColor = Color.Gold
    End Sub

    Private Sub btnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles btnIngresar.MouseLeave
        btnIngresar.ForeColor = Color.White
    End Sub

End Class
