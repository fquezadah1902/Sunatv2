Imports Sunatv2.DA
Public Class DepartamentoBL

    Dim objeto As New DepartamentoDA
    Public Function Get_Departamento_SelectAll() As DataTable
        Return objeto.Get_Departamento_SelectAll()
    End Function


End Class
