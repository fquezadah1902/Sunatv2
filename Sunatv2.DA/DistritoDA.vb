Imports System.Data.SqlClient
Imports System.Data




Public Class DistritoDA

    Public Function Get_Distrito_SelectAll(ByVal IdDepartamento As Integer, ByVal IdProvincia As Integer) As DataTable
        Using cn As New SqlConnection(strConexion)
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.CommandText = "SP_Provincia_SEL01"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdDepartamento", SqlDbType.NVarChar).Value = IdDepartamento
            cmd.Parameters.Add("@IdProvincia", SqlDbType.NVarChar).Value = IdProvincia

            Dim da = New SqlDataAdapter()
            Dim dt As New DataTable()
            da.SelectCommand = cmd
            cn.Open()
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
