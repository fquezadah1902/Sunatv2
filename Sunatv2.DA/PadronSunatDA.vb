﻿Imports System.Data.SqlClient
Imports System.Data
Public Class PadronSunatDA


    Public Function Get_PadronSunat_SelectAll(ByVal Cadena As String) As DataTable
        Using cn As New SqlConnection(strConexion)
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.CommandText = "SP_PadronSunat_SEL01"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Cadena", SqlDbType.NVarChar).Value = Cadena

            Dim da = New SqlDataAdapter()
            Dim dt As New DataTable()
            da.SelectCommand = cmd
            cn.Open()
            da.Fill(dt)
            Return dt
        End Using
    End Function


End Class
