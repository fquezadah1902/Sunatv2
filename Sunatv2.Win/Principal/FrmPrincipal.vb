Imports System.Windows.Forms
Imports ComponentFactory.Krypton

'Imports Outsourcing.BusinessEntity
'Imports Outsourcing.BussinesLogicLayer

'Imports Sistema.Gestion.Ventas.Entidad
'Imports Sistema.Gestion.Ventas.Negocio


Public Class FrmPrincipal

    'Dim Usuario As New Outsourcing.BussinesLogicLayer.UsuarioBL
    'Dim StUsuario As New Outsourcing.BusinessEntity.UsuarioBE
    'Dim Ventana As New Outsourcing.BussinesLogicLayer.VentanaBL
    ' Dim UserPermiso As New Outsourcing.BussinesLogicLayer.UsuarioBL

    Public oldControl As Windows.Forms.Control = Nothing
    Dim Permiso As DataTable

    'Dim StUsuario As New UsuarioBE

    Public NIdCaja As Int32



    Private rng As New Random

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        '' Cree una nueva instancia del formulario secundario.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Ventana " & m_ChildFormNumber

        'ChildForm.Show()
        'Dim f3 As New FrmPedido
        'f3.ShowInTaskbar = False
        'f3.ShowDialog()
        'f3.Show()

    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del primario.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private m_ChildFormNumber As Integer = 0
    Sub LLenarData()
        'objproceso.llenarEmployee()
        'objproceso.llenarUsuarios()
        'objproceso.llenarUnidad()
    End Sub

    ' ''Sub llenarPermisos()
    ' ''    'Dim total = tablaPermisoUsuario.Rows.Count
    ' ''    'Dim x

    ' ''    'For x = 0 To total - 1

    ' ''    '    Dim permis = tablaPermisoUsuario.Rows(x)("id_permiso").ToString
    ' ''    '    Select Case permis
    ' ''    '        Case 1
    ' ''    '            Me.EmpleadosToolStripMenuItem.Enabled = True
    ' ''    '        Case 2
    ' ''    '            Me.UsuariosToolStripMenuItem.Enabled = True
    ' ''    '        Case 3
    ' ''    '            Me.CambioDePasswordToolStripMenuItem.Enabled = True
    ' ''    '        Case 4
    ' ''    '            Me.DocumentosToolStripMenuItem.Enabled = True
    ' ''    '        Case 5
    ' ''    '            Me.PedidoDeDocumentosToolStripMenuItem.Enabled = True
    ' ''    '        Case 6
    ' ''    '            Me.AtenciónToolStripMenuItem.Enabled = True
    ' ''    '            'Case 7
    ' ''    '            '    Me.DevoluciónToolStripMenuItem.Enabled = True
    ' ''    '            'Case 8
    ' ''    '            '    Me.ProducciónToolStripMenuItem.Enabled = True
    ' ''    '        Case 9
    ' ''    '            Me.DocumentosSinDevolverToolStripMenuItem.Enabled = True
    ' ''    '            'Case 10
    ' ''    '            '    Me.HistorialDeDocumentosToolStripMenuItem.Enabled = True
    ' ''    '            'Case 11
    ' ''    '            '    Me.MantenimientosGeneralesToolStripMenuItem.Enabled = True
    ' ''    '            'Case 12
    ' ''    '            '    Me.RecepciónDePlantillasToolStripMenuItem.Enabled = True
    ' ''    '            'Case 13
    ' ''    '            '    Me.UbicacionesToolStripMenuItem.Enabled = True
    ' ''    '            'Case 14
    ' ''    '            '    Me.LiberarDocumentoToolStripMenuItem.Enabled = True
    ' ''    '        Case 15
    ' ''    '            Me.InventarioToolStripMenuItem.Enabled = True
    ' ''    '            'Case 16
    ' ''    '            '    Me.CargosToolStripMenuItem.Enabled = True
    ' ''    '            'Case 18
    ' ''    '            '    Me.CuadrosEstadisticosToolStripMenuItem.Enabled = True

    ' ''    '        Case 17
    ' ''    '    End Select
    ' ''    'Next
    ' ''End Sub

    Public Sub MostrarMantenerModulo(ByVal Control As UserControl)
        pcMain.SuspendLayout()
        Try
            '    Me.pbImagen.Visible = False
            MostrarMantenerModulo(Control, oldControl, GroupControl1)
            oldControl = Control

        Finally
            pcMain.ResumeLayout()
        End Try
    End Sub

    Private Sub FrmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'ToolStripStatusNUsuario.Text = frmLogin.lblNVal_Usuario.Text
        'ComodinTooldUsuario.Text = frmLogin.lblNVal_IdUsuario.Text

        'ComodinToolIdCaja.Text = frmLogin.NVal_IdCaja
        'If ComodinToolIdCaja.Text = "" Then
        '    NIdCaja = 0
        'Else
        '    NIdCaja = frmLogin.NVal_IdCaja
        'End If


        'ToolStripLabelFecchaCaja.Text = frmLogin.lblNVal_FechaCaja.Text


        Dim control As New ControlFondo
        MostrarMantenerModulo(control)


        llenarPermisos()


    End Sub



    Sub Genera_correo()
        Dim tborreo As DataTable
    End Sub

    Sub InicioPermiso()




        MantenimientosGeneralesToolStripMenuItem.Visible = False
        EmpleadosToolStripMenuItem.Visible = False
        UsuariosToolStripMenuItem.Visible = False



        CambioDePasswordToolStripMenuItem.Enabled = False




    End Sub

    Sub llenarPermisos()


    End Sub


    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CerrarLaSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarLaSesionToolStripMenuItem.Click
        Dim op% = Toolkit.KryptonMessageBox.Show("Desea cerrar la sesión", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If op = 6 Then
            'frmLogin.Show()
            Me.Dispose()
        End If
    End Sub


    Function MostrarMantenerModulo(ByVal Control As UserControl, ByVal oldControl As Windows.Forms.Control, ByVal groupControl As Panel) As Boolean

        Dim currentCursor As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        groupControl.Parent.SuspendLayout()
        groupControl.SuspendLayout()
        Try
            Control.Bounds = groupControl.DisplayRectangle
            'Instance.CurrentModuleBase = item
            Control.Visible = False
            groupControl.Controls.Add(Control)
            Control.Dock = DockStyle.Fill

            'CloseCustomizationForm(oldControl)

            Control.Visible = True


            If Not oldControl Is Nothing Then
                If Control.Equals(oldControl) Then
                Else
                    oldControl.Visible = False
                End If

            End If
        Finally
            oldControl = Control
            groupControl.ResumeLayout(True)
            groupControl.Parent.ResumeLayout(True)
            Cursor.Current = currentCursor
        End Try

        Return True
    End Function

    Private Sub FrmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If objproceso.ValidarSeleccionMultiple(CLControl.Item_Ventana) = True Then e.Cancel = True

        'Dim op = MessageBox.Show("Desea salir del sistema", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If op = 6 Then

        '    StUsuario.NombreUser = Me.ToolStripStatusLabel1.Text
        '    StUsuario.Activo = 0
        '    StUsuario.TerminalActivo = System.Environment.MachineName

        '    Usuario.SetUpdateUsuario_Activo(StUsuario)
        'Else
        '    e.Cancel = True
        'End If
    End Sub


    Private procesoSeleccionado As ModuleSelected = ModuleSelected.Ninguno
    Public Property ProccessSelected() As ModuleSelected
        Get
            Return procesoSeleccionado
        End Get
        Set(ByVal value As ModuleSelected)
            procesoSeleccionado = value
        End Set
    End Property

    Private Monitoreocomponente As Boolean
    Private DespachoComponnete As Boolean

    Public Enum ModuleSelected
        Ninguno = 0
        DespachoComponentes = 1
        CajaEnviadaPorCliente = 2
        Observacion = 3
        'DatoGeneral = 4
        Departamento = 5
        Area = 6
        UnidadAlmacenamiento = 7
        'TipoDocumental = 8
        PersonaAutorizada = 9
        Pedido = 10
        PedidoPorAtender = 11
        Atencion = 12
        AtencionPorDevolver = 13
        Devolucion = 14
        Informe = 15
        SerieDocumental = 16
        SubSerie = 17
        Indicador = 18
    End Enum



    Private Sub TramitesEnProcesoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlTramiteProc1.BringToFront()
        'Me.ControlTramiteProc1.Dock = DockStyle.Fill
        'ControlTramiteProc1.CargarData()

        'Dim NIdVentana As Integer
        'NIdVentana = 6

        'Dim control As New ControlTramiteProc(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.CargarData()
    End Sub

    Private Sub CierreDeTramitesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

        Dim NIdVentana As Integer
        NIdVentana = 8

        'Me.ControlRegistroCierre1.BringToFront()
        'Me.ControlRegistroCierre1.Dock = DockStyle.Fill
        'Me.ControlRegistroCierre1.Cargar()

        'Dim control As New ControlRegistroCierre(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub


    Private Sub AsignacionDeTramitesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlAtencionMonitoreo1.BringToFront()
        'Me.ControlAtencionMonitoreo1.Dock = DockStyle.Fill
        'Me.ControlAtencionMonitoreo1.Cargar_Cargar_Usuarios()
        'Me.ControlAtencionMonitoreo1.CargarControl()


        'Dim control As New ControlAtencionMonitoreo
        'MostrarMantenerModulo(control)
        'control.CargarControl()

    End Sub

    Private Sub LLamadaDeTramitesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlRegistroLLamada1.BringToFront()
        'Me.ControlRegistroLLamada1.Dock = DockStyle.Fill

        'ControlRegistroLLamada1.Cargar()

        Dim NIdVentana As Integer
        NIdVentana = 7


        'Dim control As New ControlRegistroLLamada(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.Cargar()

    End Sub

    Private Sub MantenimientosGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientosGeneralesToolStripMenuItem.Click

        'Dim control As New MantenimientoGeneralUC
        'MostrarMantenerModulo(control)

        'Me.MantenimientoGeneralUC1.BringToFront()
        'Me.MantenimientoGeneralUC1.Dock = DockStyle.Fill
    End Sub
    Private Sub ReporteTotalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlBusqueda1.BringToFront()
        'Me.ControlBusqueda1.Dock = DockStyle.Fill

        'Dim control As New ControlBusqueda
        'MostrarMantenerModulo(control)
    End Sub
    Private Sub EmpleadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        'FrmEmpleados.Show()
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        'FrmAccesoUser.Show()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlRegistroAtencion1.BringToFront()
        'Me.ControlRegistroAtencion1.Dock = DockStyle.Fill

        'ControlRegistroAtencion1.Cargar()

        Dim NIdVentana As Integer
        NIdVentana = 1

        'Dim control As New ControlRegistroAtencion(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.Cargar()

    End Sub
    Private Sub EstadisticaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlEstadisticos1.BringToFront()
        'Me.ControlEstadisticos1.Dock = DockStyle.Fill
        'ControlEstadisticos1.Cargar()

        'Dim control As New ControlEstadisticos
        'MostrarMantenerModulo(control)
        'control.Cargar()

    End Sub

    Private Sub CuadroResumenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlDistribucion1.BringToFront()
        'Me.ControlDistribucion1.Dock = DockStyle.Fill

        'Dim control As New ControlDistribucion
        'MostrarMantenerModulo(control)


    End Sub
    Private Sub CuadroProduccionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlProduccion1.BringToFront()
        'Me.ControlProduccion1.Dock = DockStyle.Fill

        'Dim control As New ControlProduccion
        'MostrarMantenerModulo(control)

    End Sub
    Private Sub Estadistica2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlEstadisticos22.BringToFront()
        'ControlEstadisticos22.Dock = DockStyle.Fill

        'Dim control As New ControlEstadisticos2
        'MostrarMantenerModulo(control)

    End Sub
    Private Sub CambioDePasswordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambioDePasswordToolStripMenuItem.Click

        'FrmPassword.ShowInTaskbar = False
        'FrmPassword.ShowDialog()
    End Sub
    Private Sub ConsultasTramitesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlBusquedaStandar1.BringToFront()
        'ControlBusquedaStandar1.Dock = DockStyle.Fill

        Dim NIdVentana As Integer
        NIdVentana = 9

        'Dim control As New ControlBusquedaStandar(NIdVentana)
        'MostrarMantenerModulo(control)

    End Sub
    Private Sub ReporteTiemposDeAtencionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlTiempo1.BringToFront()
        'ControlTiempo1.Dock = DockStyle.Fill

        'Dim control As New ControlTiempo
        'MostrarMantenerModulo(control)

    End Sub
    Private Sub FechaNoLaboralesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'FrmMantenimientoHorarios.Show()
    End Sub
    Private Sub UsuarioTipoTramiteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'FrmMantUsuarioTipoTramite.Show()
    End Sub
    Private Sub MantenimientoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        'FrmMantenimiento.Show()
    End Sub
    Private Sub TramitesEnProcesoAuditoriaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlAuditoriaMedica1.BringToFront()
        'ControlAuditoriaMedica1.Dock = DockStyle.Fill

        'ControlAuditoriaMedica1.CargarData()

        Dim NIdVentana As Integer
        NIdVentana = 16


        'Dim control As New ControlAuditoriaMedica(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.CargarData()

    End Sub
    Private Sub CitasMédicasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlMenu1.BringToFront()
        'ControlMenu1.Dock = DockStyle.Fill


        'Dim control As New ControlMenu
        'MostrarMantenerModulo(control)

        'ControlAudControlMenu1itoriaMedica1.CargarData()
    End Sub
    Private Sub ControlLotesStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.ControlLLamadasPool1.BringToFront()
        'ControlLLamadasPool1.Dock = DockStyle.Fill

        Dim NIdVentana As Integer
        NIdVentana = 18

        'Dim control As New ControlLoteLLamadas(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub


    Sub Actualizar()
        'Dim slice As New ToastForm(Me.rng.Next(2000, 10000), "Slice " & sliceCount)
        'Dim slice As New ToastForm(Me.rng.Next(1000, 20000), "Slice ")

        'slice.Height = Me.rng.Next(50, 400)
        'slice.Show()

    End Sub


    Private Sub AtenciónCajaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim NIdVentana As Integer
        NIdVentana = 23

        'Dim control As New ControlAtencionCaja(NIdVentana)
        'MostrarMantenerModulo(control)
    End Sub
    Private Sub AtencionFarmaciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

        Dim NIdVentana As Integer

        NIdVentana = 22
        'Dim control As New ControlMenuFarmacia(NIdVentana)
        'MostrarMantenerModulo(control)
    End Sub

    Private Sub AtenciónPreOperatoriosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

        Dim NIdVentana As Integer
        NIdVentana = 25

        'Dim control As New ControlPreOperativos(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.CargarData()
        'control.AbrirFiltro()
    End Sub
    Private Sub LLamadaAsistencialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim NIdVentana As Integer

        'NIdVentana = 24
        'Dim control As New ControlRegistroLLamadaAsistencial(NIdVentana)
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub
    Private Sub ReporteTiempoDeAtenciónFarmaciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim control As New ControlTiempoFarmacia
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub
    Private Sub ReporteDeMensajeEnviadosPacienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim control As New ControlMensajeCliente
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub
    Private Sub AutorizacionServicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'FrmAutorizacionServicio.Show()
    End Sub
    Private Sub ConsultasTramitesAutorizadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    'Private Sub ConsultasTramitesAutorizadosFarmaciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultasTramitesAutorizadosFarmaciaToolStripMenuItem.Click
    '    Dim control As New ControlTramitesAutorizadoFar
    '    MostrarMantenerModulo(control)
    '    'control.Cargar()
    'End Sub

    'Private Sub AtenciónFarmaciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AtenciónFarmaciaToolStripMenuItem.Click
    '    Dim control As New ControlAtencionFarmacia
    '    MostrarMantenerModulo(control)
    '    control.CargarData()
    '    ' control.Filtro()
    'End Sub
    Private Sub ConsultaTiemposAtencionRecetasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim control As New ControlTiemposRecetas
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub

    Private Sub ReporteTiempoAtenciónDePOOLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConfigurarCorreosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim control As New ServicioAtencion
        'MostrarMantenerModulo(control)
        'control.Cargar()
    End Sub

    Private Sub GrupoDeCorreosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ' FrmPopGrupoCorreos.Show()
    End Sub

    Private Sub ReporteFlujoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Dim control As New ControlTiempoFlujo
        'MostrarMantenerModulo(control)
    End Sub

    Private Sub RegistroProductosComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim control As New RegistroActivos
        'MostrarMantenerModulo(control)

    End Sub

    Private Sub InventarioActivosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim control As New InventarioActivos
        'MostrarMantenerModulo(control)

    End Sub

    Private Sub AtencionArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim control As New Atenciones
        'MostrarMantenerModulo(control)

    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim NIdVentana As Integer
        'NIdVentana = 25

        'Dim control As New ControlCajaPagos
        'MostrarMantenerModulo(control)

    End Sub



    Private Sub TableroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableroToolStripMenuItem.Click

    End Sub

    Private Sub ComponenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComponenteToolStripMenuItem.Click

    End Sub

    Private Sub SubCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoriasToolStripMenuItem.Click

    End Sub

    Private Sub ProgramarMozosZonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramarMozosZonasToolStripMenuItem.Click


    End Sub

    Private Sub RegistroPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroPedidosToolStripMenuItem.Click

    End Sub

    Private Sub RegistroComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroComprasToolStripMenuItem.Click
        'Dim control As New ControlOrdenCompra
        'MostrarMantenerModulo(control)
    End Sub

    Private Sub RecepcionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepcionToolStripMenuItem.Click

    End Sub

    Private Sub AlmacenCentralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenCentralToolStripMenuItem.Click


    End Sub

    Private Sub ServicioComedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicioComedorToolStripMenuItem.Click

    End Sub



    Private Sub AtencionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtencionToolStripMenuItem.Click

    End Sub

    Private Sub ServicioRapidoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServicioRapidoToolStripMenuItem1.Click
        'Dim control As New ControlServicioRapido
        'MostrarMantenerModulo(control)

    End Sub

    Private Sub ComanderoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComanderoToolStripMenuItem1.Click

    End Sub

    Private Sub InsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsumosToolStripMenuItem.Click

    End Sub

    Private Sub ControlCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlCajaToolStripMenuItem.Click

    End Sub

    Private Sub TesoreriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesoreriaToolStripMenuItem.Click

    End Sub

    Private Sub AutorizacionesComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizacionesComprasToolStripMenuItem.Click

    End Sub

    Private Sub GrupoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoToolStripMenuItem.Click

    End Sub

    Private Sub LogSunatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogSunatToolStripMenuItem.Click

    End Sub

    Private Sub IngresoAlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoAlmacenToolStripMenuItem.Click

    End Sub



    Private Sub CocinaCalienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CocinaCalienteToolStripMenuItem.Click



    End Sub
    Private Sub BarraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarraToolStripMenuItem.Click

    End Sub
    Private Sub BrazasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrazasToolStripMenuItem.Click

    End Sub

    Private Sub ConfiguracionCalendarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionCalendarioToolStripMenuItem.Click



    End Sub

    Private Sub CuponBonusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuponBonusToolStripMenuItem.Click

    End Sub

    Private Sub ConfiguracionProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionProductosToolStripMenuItem.Click

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub ConsultasIngresoRestauranteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasIngresoRestauranteToolStripMenuItem.Click

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub PagosProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosProveedoresToolStripMenuItem.Click

    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click

    End Sub

    Private Sub ConsultasIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasIngresosToolStripMenuItem.Click

    End Sub

    Private Sub AnuladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnuladosToolStripMenuItem.Click

    End Sub

    Private Sub DescagarComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescagarComprobanteToolStripMenuItem.Click

    End Sub



    Private Sub ResumenDiarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResumenDiarioToolStripMenuItem1.Click


    End Sub

    Private Sub NotasCreditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasCreditoToolStripMenuItem.Click

    End Sub

    Private Sub ComprobantesGeneradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobantesGeneradosToolStripMenuItem.Click

    End Sub

    Private Sub ProductosVariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
