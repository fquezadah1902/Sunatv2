Imports Sunatv2.DA
Public Class ProvinciaBL
    Dim objeto As New ProvinciaDA
    Public Function Get_Provincia_SelectAll(ByVal IdDepartamento As Integer) As DataTable
        Return objeto.Get_Provincia_SelectAll(IdDepartamento)
    End Function
End Class
