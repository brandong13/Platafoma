Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Conexion
        Public conexion As SqlConnection
        Public enunciado As SqlCommand
        Public respuesta As SqlDataReader
    Public dt As DataTable
    Public dr As SqlDataReader
    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=ARMY-MONTSE\SQLEXPRESS;Initial Catalog=Plataforma;Integrated Security=True")
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            'MsgBox("Error en la conexion" + ex.ToString)
        End Try
    End Sub



End Class
