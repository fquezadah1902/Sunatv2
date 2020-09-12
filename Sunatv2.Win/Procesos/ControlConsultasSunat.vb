Imports ComponentFactory.Krypton
Imports Sunatv2.BL

Public Class ControlConsultasSunat

    Dim Departamento As New DepartamentoBL
    Dim Provincia As New ProvinciaBL
    Dim Distrito As New DistritoBL
    Dim PadronSunat As New PadronSunatBL

    Private Sub ControlClienteProveedor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.kryptonSplitContainerMain.Panel1Collapsed = True
        cmbDepartamento.DataSource = Departamento.Get_Departamento_SelectAll()
    End Sub

    Sub Cargar()

        Dim Cadena = ""
        If ChkNumDocuCliente.Checked = True Then
            If Me.txtNumeroRuc.Text <> "" Then
                Cadena = Cadena & " AND s.RUC = '" & Me.txtNumeroRuc.Text.Trim & "'"
            End If
        End If
        If Me.chkFechaRegistro.Checked = True Then
            If Me.dtFRegistroIni.Value.Date > Me.dtFRegistroFin.Value.Date Then
                Toolkit.KryptonMessageBox.Show("Fechas seleccionadas no son validas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Cadena = Cadena & " AND CAST(s.FechaRegistroSistema AS DATE) BETWEEN '" & Format(Convert.ToDateTime(Me.dtFRegistroIni.Text), "dd/MM/yyyy") & "' AND '" & Format(Convert.ToDateTime(Me.dtFRegistroFin.Text), "dd/MM/yyyy") & " '"
        End If

        If chkDepartamento.Checked = True Then
            If cmbDepartamento.SelectedIndex > -1 Then
                Cadena = Cadena & " AND s.IdDepartamento = " & cmbDepartamento.SelectedValue.ToString()
            End If
        End If

        If chkProvincia.Checked = True Then
            If cmbProvincia.SelectedIndex > -1 Then
                Cadena = Cadena & " AND s.IdProvincia = " & cmbProvincia.SelectedValue.ToString()
            End If
        End If



        If chkDistrito.Checked = True Then
            If cmbDistrito.SelectedIndex > -1 Then
                Cadena = Cadena & " AND s.IdDistrito = " & cmbDistrito.SelectedValue.ToString()
            End If
        End If


        'If chkDepartamento.Checked = True Then
        '    If Me.txtNomCliente.Text <> "" Then
        '        Cadena = Cadena & " AND c.Nom_Entidad LIKE '%" & Me.txtNomCliente.Text.Trim & "%'"
        '    End If
        'End If
        DgAfiliadosSunat.DataSource = PadronSunat.Get_Padron_SelectAll(Cadena)

        Me.kryptonSplitContainerMain.Panel1Collapsed = True
        KryptonHeaderGroup1.ValuesPrimary.Heading = "Ubicado Sunat: " & DgAfiliadosSunat.Rows.Count

    End Sub

    Private Sub FiltrarToolStripButton_Click(sender As Object, e As EventArgs) Handles FiltrarToolStripButton.Click
        If Me.kryptonSplitContainerMain.Panel1Collapsed = True Then
            Me.kryptonSplitContainerMain.Panel1Collapsed = False
        Else
            Me.kryptonSplitContainerMain.Panel1Collapsed = True
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Cargar()
    End Sub

    Private Sub ActualizarToolStripButton_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripButton.Click
        Cargar()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim control As New ControlFondo
        MDI.MostrarMantenerModulo(control)
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        If cmbDepartamento.SelectedIndex > -1 Then
            Dim IdDepartameto As Integer
            IdDepartameto = cmbDepartamento.SelectedValue
            cmbProvincia.DataSource = Provincia.Get_Provincia_SelectAll(IdDepartameto)
        Else
        End If
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
        If cmbProvincia.SelectedIndex > -1 Then
            Dim IdDepartamento As Integer
            Dim IdProvincia As Integer
            IdDepartamento = Me.cmbDepartamento.SelectedValue
            IdProvincia = Me.cmbProvincia.SelectedValue

            cmbDistrito.DataSource = Distrito.Get_Distrito_SelectAll(IdDepartamento, IdProvincia)
        Else

        End If
    End Sub

End Class
