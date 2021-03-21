Imports System.Data.SqlClient
Public Class FOtrosGastos
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sOtrosGastos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            If (comandos.ExecuteNonQuery) Then
                Dim tabla As New DataTable
                Dim adactador As New SqlDataAdapter(comandos)
                adactador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If

        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    'Insertar
    Public Function Insertar(tabla As EOtrosGastos) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iOtrosGastos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@otgaTipo", tabla.OtgaTipo1)
            comandos.Parameters.AddWithValue("@otgaDescripcion", tabla.OtgaDescripcion1)
            comandos.Parameters.AddWithValue("@otgaFijo", tabla.OtgaFijo1)
            comandos.Parameters.AddWithValue("@otgaPorcentaje", tabla.OtgaPorcentaje1)
            comandos.Parameters.AddWithValue("@otgaPeso", tabla.OtgaPeso1)
            If (comandos.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            desconectar()

        End Try

    End Function

    'Actualizar
    Public Function Actualizar(tabla As EOtrosGastos) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aOtrosGastos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@otgaCodigo", tabla.OtgaCodigo1)
            comandos.Parameters.AddWithValue("@otgaTipo", tabla.OtgaTipo1)
            comandos.Parameters.AddWithValue("@otgaDescripcion", tabla.OtgaDescripcion1)
            comandos.Parameters.AddWithValue("@otgaFijo", tabla.OtgaFijo1)
            comandos.Parameters.AddWithValue("@otgaPorcentaje", tabla.OtgaPorcentaje1)
            comandos.Parameters.AddWithValue("@otgaPeso", tabla.OtgaPeso1)

            If (comandos.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            desconectar()

        End Try

    End Function

    'Eliminar
    Public Function Eliminar(tabla As EOtrosGastos) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eOtrosGastos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@otgaCodigo", tabla.OtgaCodigo1)

            If (comandos.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            desconectar()

        End Try

    End Function

End Class
