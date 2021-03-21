Imports System.Data.SqlClient
Public Class FEmpleado
    Inherits Conexion
    Dim comandos As New SqlCommand

    Public Function Mostrar1(Usuario As String, Contraseña As String) As String
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sEmpleado")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            If (comandos.ExecuteNonQuery) Then
                Dim Leer As SqlDataReader = comandos.ExecuteReader()
                While Leer.Read()
                    If (Usuario = Leer(9) And Contraseña = Leer(10)) Then
                        Return Leer(7)
                    End If
                End While
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return "No encontrado"
        Finally
            desconectar()
        End Try
        Return "No encontrado"
    End Function
    Public Function MostrarM() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sEmpleado")
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
    Public Function Insertar(tabla As EEmpleado) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iEmpleado")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@empNombre", tabla.PempNombre)
            comandos.Parameters.AddWithValue("@empApellido", tabla.PempApellido)
            comandos.Parameters.AddWithValue("@empDireccion", tabla.PempDireccion)
            comandos.Parameters.AddWithValue("@empTelefono", tabla.PempTelefono)
            comandos.Parameters.AddWithValue("@empIdentidad", tabla.PempIdentidad)
            comandos.Parameters.AddWithValue("@empCorreo", tabla.PempCorreo)
            comandos.Parameters.AddWithValue("@empPuesto", tabla.PempPuesto)
            comandos.Parameters.AddWithValue("@empFechaIngreso", tabla.PempFechaIngreso)
            comandos.Parameters.AddWithValue("@empUsuario", tabla.PempUsuario)
            comandos.Parameters.AddWithValue("@empContraseña", tabla.PempContraseña)
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
    Public Function Actualizar(tabla As EEmpleado) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aEmpleado")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@empCodigo", tabla.PempCodigo)
            comandos.Parameters.AddWithValue("@empNombre", tabla.PempNombre)
            comandos.Parameters.AddWithValue("@empApellido", tabla.PempApellido)
            comandos.Parameters.AddWithValue("@empDireccion", tabla.PempDireccion)
            comandos.Parameters.AddWithValue("@empTelefono", tabla.PempTelefono)
            comandos.Parameters.AddWithValue("@empIdentidad", tabla.PempIdentidad)
            comandos.Parameters.AddWithValue("@empCorreo", tabla.PempCorreo)
            comandos.Parameters.AddWithValue("@empPuesto", tabla.PempPuesto)
            comandos.Parameters.AddWithValue("@empFechaIngreso", tabla.PempFechaIngreso)
            comandos.Parameters.AddWithValue("@empUsuario", tabla.PempUsuario)
            comandos.Parameters.AddWithValue("@empContraseña", tabla.PempContraseña)

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
    Public Function Eliminar(tabla As EEmpleado) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eEmpleado")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@empCodigo", tabla.PempCodigo)

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
