Imports System.ComponentModel

Public Class FrmMenuAdministrador
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

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Dim Formulario As New FrmArticulos
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnArticulos_MouseHover(sender As Object, e As EventArgs) Handles btnArticulos.MouseHover
        ttMensaje.ToolTipTitle = "Gestionar articulo P/R"
        btnArticulos.ForeColor = Color.Gold
    End Sub

    Private Sub btnArticulos_MouseLeave(sender As Object, e As EventArgs) Handles btnArticulos.MouseLeave
        btnArticulos.ForeColor = Color.White
    End Sub

    Private Sub btnOtrosGastos_MouseHover(sender As Object, e As EventArgs) Handles btnOtrosGastos.MouseHover
        ttMensaje.ToolTipTitle = "Gestionar Otros gastos"
        btnOtrosGastos.ForeColor = Color.Gold
    End Sub

    Private Sub btnOtrosGastos_MouseLeave(sender As Object, e As EventArgs) Handles btnOtrosGastos.MouseLeave
        btnOtrosGastos.ForeColor = Color.White
    End Sub

    Private Sub btnOtrosGastos_Click(sender As Object, e As EventArgs) Handles btnOtrosGastos.Click
        Dim Formulario As New FrmOtrosGastos
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnPais_Click(sender As Object, e As EventArgs) Handles btnPais.Click
        Dim Formulario As New FrmPais
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnPais_MouseHover(sender As Object, e As EventArgs) Handles btnPais.MouseHover
        ttMensaje.ToolTipTitle = "Gestionar de los Paises"
        btnPais.ForeColor = Color.Gold
    End Sub

    Private Sub btnPais_MouseLeave(sender As Object, e As EventArgs) Handles btnPais.MouseLeave
        btnPais.ForeColor = Color.White
    End Sub

    Private Sub btnZona_Click(sender As Object, e As EventArgs) Handles btnZona.Click
        Dim Formulario As New FrmZona
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnZona_MouseHover(sender As Object, e As EventArgs) Handles btnZona.MouseHover
        ttMensaje.ToolTipTitle = "Gestionar de las zonas"
        btnZona.ForeColor = Color.Gold
    End Sub

    Private Sub btnZona_MouseLeave(sender As Object, e As EventArgs) Handles btnZona.MouseLeave
        btnZona.ForeColor = Color.White
    End Sub

    Private Sub btnAlmacenaje_Click(sender As Object, e As EventArgs) Handles btnAlmacenaje.Click
        Dim Formulario As New FrmAlmacenaje
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnAlmacenaje_MouseHover(sender As Object, e As EventArgs) Handles btnAlmacenaje.MouseHover
        ttMensaje.ToolTipTitle = "Gestionar del Almacenaje"
        btnAlmacenaje.ForeColor = Color.Gold
    End Sub

    Private Sub btnAlmacenaje_MouseLeave(sender As Object, e As EventArgs) Handles btnAlmacenaje.MouseLeave
        btnAlmacenaje.ForeColor = Color.White
    End Sub

End Class