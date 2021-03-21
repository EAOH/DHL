Imports System.ComponentModel

Public Class FrmMenuAtencion
    Private Sub btnCerrarSecion_Click(sender As Object, e As EventArgs) Handles btnCerrarSecion.Click
        Dim Formulario As New FrmLogin
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrarSecion_MouseHover(sender As Object, e As EventArgs) Handles btnCerrarSecion.MouseHover
        ttMensaje.ToolTipTitle = "Cerrar Sesion"
        btnCerrarSecion.BackgroundImage = Proyecto_Final.My.Resources.Salir
        btnCerrarSecion.Text = ""
    End Sub

    Private Sub btnCerrarSecion_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrarSecion.MouseLeave
        btnCerrarSecion.BackgroundImage = Nothing
        btnCerrarSecion.Text = "Cerrar Sesion"
    End Sub

    Private Sub btnNuevocliente_Click(sender As Object, e As EventArgs) Handles btnNuevocliente.Click
        Dim Formulario As New FrmCliente
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevocliente_MouseHover(sender As Object, e As EventArgs) Handles btnNuevocliente.MouseHover
        ttMensaje.ToolTipTitle = "Agregar a un nuevo Cliente"
        btnNuevocliente.ForeColor = Color.Gold
    End Sub

    Private Sub btnNuevocliente_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevocliente.MouseLeave
        btnNuevocliente.ForeColor = Color.White
    End Sub

    Private Sub btnEnvio_Click(sender As Object, e As EventArgs) Handles btnEnvio.Click
        Dim Formulario As New FrmEnvio
        Formulario.Show()
        Me.Close()
    End Sub
    Private Sub btnEnvio_MouseHover(sender As Object, e As EventArgs) Handles btnEnvio.MouseHover
        ttMensaje.ToolTipTitle = "Realizar envio"
        btnEnvio.ForeColor = Color.Gold
    End Sub

    Private Sub btnEnvio_MouseLeave(sender As Object, e As EventArgs) Handles btnEnvio.MouseLeave
        btnEnvio.ForeColor = Color.White
    End Sub

End Class