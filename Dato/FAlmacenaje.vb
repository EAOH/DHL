Imports System.Data.SqlClient
Public Class FAlmacenaje
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sAlmacenaje")
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
    Public Function Insertar(tabla As EAlmacenaje) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iAlmacenaje")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@almDiasmin", tabla.AlmDiasmin1)
            comandos.Parameters.AddWithValue("@almDiasMax", tabla.AlmDiasMAX1)
            comandos.Parameters.AddWithValue("@almTipoCarga", tabla.AlmTipoCagar1)
            comandos.Parameters.AddWithValue("@almVTramoInicial", tabla.AlmTramoInicial1)
            comandos.Parameters.AddWithValue("@almVTramoFinal", tabla.AlmTramoFinal1)
            comandos.Parameters.AddWithValue("@almPesoKmin", tabla.AlmPesomin1)
            comandos.Parameters.AddWithValue("@almPesoKMax", tabla.AlmPesoMax1)
            comandos.Parameters.AddWithValue("@almCostoFijo", tabla.AlmCostoFijo1)
            comandos.Parameters.AddWithValue("@almTipo", tabla.AlmTipo1)
            comandos.Parameters.AddWithValue("@almCiudad", tabla.AlmCiudad1)
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
    Public Function Actualizar(tabla As EAlmacenaje) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aAlmacenaje")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@almCodigo", tabla.AlmCodigo1)
            comandos.Parameters.AddWithValue("@almDiasmin", tabla.AlmDiasmin1)
            comandos.Parameters.AddWithValue("@almDiasMax", tabla.AlmDiasMAX1)
            comandos.Parameters.AddWithValue("@almTipoCarga", tabla.AlmTipoCagar1)
            comandos.Parameters.AddWithValue("@almVTramoInicial", tabla.AlmTramoInicial1)
            comandos.Parameters.AddWithValue("@almVTramoFinal", tabla.AlmTramoFinal1)
            comandos.Parameters.AddWithValue("@almPesoKmin", tabla.AlmPesomin1)
            comandos.Parameters.AddWithValue("@almPesoKMax", tabla.AlmPesoMax1)
            comandos.Parameters.AddWithValue("@almCostoFijo", tabla.AlmCostoFijo1)
            comandos.Parameters.AddWithValue("@almTipo", tabla.AlmTipo1)
            comandos.Parameters.AddWithValue("@almCiudad", tabla.AlmCiudad1)

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
    Public Function Eliminar(tabla As EAlmacenaje) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eAlmacenaje")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@almCodigo", tabla.AlmCodigo1)

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
