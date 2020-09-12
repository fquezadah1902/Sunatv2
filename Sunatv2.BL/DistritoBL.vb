Imports Sunatv2.DA
Public Class DistritoBL

    Dim objeto As New DistritoDA
    Public Function Get_Distrito_SelectAll(ByVal IdDepartamento As Integer, ByVal IdProvincia As Integer) As DataTable
        Return objeto.Get_Distrito_SelectAll(IdDepartamento, IdProvincia)
    End Function

End Class
