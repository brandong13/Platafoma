Imports System.Data.Sql
Imports System.Data.SqlClient
Module ConexionLogin
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public dt As DataTable
    Public dr As SqlDataReader

    Sub abrirLogin()
        Try
            conexion = New SqlConnection("Data Source=ARMY-MONTSE\SQLEXPRESS;Initial Catalog=Plataforma;Integrated Security=True")
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            'MsgBox("Error en la conexion" + ex.ToString)
        End Try
    End Sub

    Function alumno(ByVal nombreUs As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select No_control from Estudiantes where No_control='" & nombreUs & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function alumno_contra(ByVal nombreUs As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contraseña from Estudiantes where Contraseña='" & nombreUs & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("Contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Aspirante(ByVal nombreAsp As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select no_solicitud from Aspirantes where no_solicitud='" & nombreAsp & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function aspirante_contra(ByVal nombreAsp As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select contraseña_asp from Aspirantes where contraseña_asp='" & nombreAsp & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("contraseña_asp")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function maestro(ByVal nombreAsp As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select matricula_maes from Maestros where matricula_maes='" & nombreAsp & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function maestro_contra(ByVal nombreAsp As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select contraseña_maes from Maestros where contraseña_maes='" & nombreAsp & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("contraseña_maes")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Sub llenarComboBoxMaterias(ByVal cb As ComboBox)
        Try
            enunciado = New SqlCommand("Select Materia from Materias", conexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                cb.Items.Add(respuesta.Item("Materia"))
            End While
            respuesta.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub llenarComboBoxEspecialidad(ByVal cb As ComboBox)
        Try
            enunciado = New SqlCommand("Select nom_especialidad from Especialidades", conexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                cb.Items.Add(respuesta.Item("nom_especialidad"))
            End While
            respuesta.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub llenarComboBoxHorario(ByVal cb As ComboBox)
        Try
            enunciado = New SqlCommand("Select Horario from Horario", conexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                cb.Items.Add(respuesta.Item("Horario"))
            End While
            respuesta.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub llenarComboBoxGenero(ByVal cb As ComboBox)
        Try
            enunciado = New SqlCommand("Select Genero from Genero", conexion)
            respuesta = enunciado.ExecuteReader
            While respuesta.Read
                cb.Items.Add(respuesta.Item("Genero"))
            End While
            respuesta.Close()
        Catch ex As Exception
        End Try
    End Sub


End Module
