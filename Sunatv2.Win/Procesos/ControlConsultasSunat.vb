Imports ComponentFactory.Krypton

Public Class ControlConsultasSunat

    'Dim Clientes As New ClientesBL

    Private Sub ControlClienteProveedor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.kryptonSplitContainerMain.Panel1Collapsed = True
        Cargar()
    End Sub
    Sub Cargar()

        Dim Cadena = ""

        If ChkNumDocuCliente.Checked = True Then
            If Me.txtNumDocCliente.Text <> "" Then
                Cadena = Cadena & " AND c.NumDocumento LIKE '%" & Me.txtNumDocCliente.Text.Trim & "%'"
            End If
        End If

        If chkNomCliente.Checked = True Then
            If Me.txtNomCliente.Text <> "" Then
                Cadena = Cadena & " AND c.Nom_Entidad LIKE '%" & Me.txtNomCliente.Text.Trim & "%'"
            End If
        End If

        'DgClientes.DataSource = Clientes.GetLista_Clientes(Cadena)
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        'Dim IdCliente As Integer = 0

        'Dim frm As New FrmPopClienteProveedor(IdCliente)
        'frm.ShowDialog()
        'frm.Dispose()
        'Cargar()
    End Sub

    Private Sub FiltrarToolStripButton_Click(sender As Object, e As EventArgs) Handles FiltrarToolStripButton.Click
        If Me.kryptonSplitContainerMain.Panel1Collapsed = True Then
            Me.kryptonSplitContainerMain.Panel1Collapsed = False
        Else
            Me.kryptonSplitContainerMain.Panel1Collapsed = True
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        ''   FrmPopClienteProveedor.Show()

        'Dim IdCliente As Integer = 0

        'Dim frm As New FrmPopClienteProveedor(IdCliente)
        'frm.ShowDialog()
        'frm.Dispose()
        'Cargar()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click

        If Me.DgClientes.SelectedRows.Count = 0 Then
            Toolkit.KryptonMessageBox.Show("Debe seleccionar un detalle primero para adicionar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Evento_Modificar()
    End Sub
    Sub Evento_Modificar()
        'Dim pos = DgClientes.CurrentRow.Index
        'Dim IdCliente As Integer = DgClientes.Rows(pos).Cells("IdCliente").Value

        'Dim frm As New FrmPopClienteProveedor(IdCliente)
        'frm.ShowDialog()
        'frm.Dispose()
        'Cargar()
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

    Private Sub ExportarToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportarToolStripButton.Click

    End Sub
End Class
