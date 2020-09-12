Imports Sunatv2.BL

Public Class Form1
    Dim Departamento As New DepartamentoBL
    Dim Provincia As New ProvinciaBL
    Dim Distrito As New DistritoBL

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbDepartamento.DataSource = Departamento.Get_Departamento_SelectAll()
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        If cmbDepartamento.SelectedIndex > 0 Then

        Else

        End If
    End Sub
End Class