Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class BaseDeDatos
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

    Function generarCodigo()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            enunciado = New SqlCommand("Select count(no_solicitud) as totalRegistros from Aspirantes", conexion)
            dr = enunciado.ExecuteReader
            If dr.Read Then
                total = CInt(dr.Item("totalRegistros"))
            End If
            dr.Close()

            If total < 10 Then
                codigo = "15000000"
            ElseIf total < 100 Then
                codigo = "1500000"
            ElseIf total < 1000 Then
                codigo = "150000"
            ElseIf total < 10000 Then
                codigo = "15000"
            ElseIf total < 100000 Then
                codigo = "1500"
            ElseIf total < 1000000 Then
                codigo = "150" + total
            ElseIf total < 10000000 Then
                codigo = "15" + total
            End If
        Catch ex As Exception

        End Try
        Return codigo
    End Function
End Class
