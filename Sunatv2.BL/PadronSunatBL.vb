Imports Sunatv2.DA
Public Class PadronSunatBL

    Dim objeto As New PadronSunatDA

    Public Function Get_Padron_SelectAll(ByVal Cadena As String) As DataTable
        Return objeto.Get_PadronSunat_SelectAll(Cadena)
    End Function


End Class
