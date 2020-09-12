Imports System.Data.SqlClient
Imports System.Data
Public Class ProvinciaDA

    Public Function Get_Provincia_SelectAll(ByVal IdDepartamento As Integer) As DataTable
        Using cn As New SqlConnection(strConexion)
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.CommandText = "SP_Provincia_SEL01"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdDepartamento", SqlDbType.NVarChar).Value = IdDepartamento

            Dim da = New SqlDataAdapter()
            Dim dt As New DataTable()
            da.SelectCommand = cmd
            cn.Open()
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
