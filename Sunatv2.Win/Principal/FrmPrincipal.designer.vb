<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm
    'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recepcionadas", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Por Entregar Taller", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alerta Recepccion", 3, 3)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recepcion Componentes", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Despachadas", 1, 1)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Por Despachar", 2, 2)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alerta Despacho", 3, 3)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Despacho de Componentes", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node30")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node31")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node32")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cores / Fuera de Servicio", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node33")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node34")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node35")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node28", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte Dinamico", 7, 7)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reportes", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode17})
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pcMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.GroupControl1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.BtnRececepcion = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.treeView = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonHeader = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonBorderEdge4 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.BtnIngreso = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonBorderEdge3 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.BtnRecepTaller = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.BtnCorres = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonCheckButton6 = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarLaSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmbienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoTableroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.GrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProgramarMozosZonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MososToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerraminetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionCalendarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CuponBonusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancoBonusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteArqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TesoreriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtencionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioComedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioRapidoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComanderoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CocinaCalienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrazasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesGeneradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnuladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDiarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescagarComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogSunatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogisticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizacionesComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenCentralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultasIngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasEgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasIngresoRestauranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VersionToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip.SuspendLayout()
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcMain.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(840, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        Me.ToolStrip.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'pcMain
        '
        Me.pcMain.Controls.Add(Me.GroupControl1)
        Me.pcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcMain.Location = New System.Drawing.Point(0, 24)
        Me.pcMain.Name = "pcMain"
        Me.pcMain.Size = New System.Drawing.Size(938, 488)
        Me.pcMain.TabIndex = 13
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(938, 488)
        Me.GroupControl1.TabIndex = 14
        '
        'BtnRececepcion
        '
        Me.BtnRececepcion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRececepcion.Location = New System.Drawing.Point(0, 242)
        Me.BtnRececepcion.Name = "BtnRececepcion"
        Me.BtnRececepcion.Size = New System.Drawing.Size(117, 25)
        Me.BtnRececepcion.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.BtnRececepcion.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnRececepcion.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnRececepcion.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnRececepcion.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnRececepcion.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnRececepcion.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnRececepcion.TabIndex = 16
        Me.BtnRececepcion.Values.Text = "Recepcion"
        '
        'treeView
        '
        Me.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView.HideSelection = False
        Me.treeView.ImageIndex = 0
        Me.treeView.ImageList = Me.ImageList1
        Me.treeView.Location = New System.Drawing.Point(0, 30)
        Me.treeView.Name = "treeView"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Node21"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Recepcionadas"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "Node22"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "Por Entregar Taller"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "Node23"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "Alerta Recepccion"
        TreeNode4.ImageIndex = 4
        TreeNode4.Name = "MRecepcion"
        TreeNode4.SelectedImageIndex = 4
        TreeNode4.Text = "Recepcion Componentes"
        TreeNode5.ImageIndex = 1
        TreeNode5.Name = "Node24"
        TreeNode5.SelectedImageIndex = 1
        TreeNode5.Text = "Despachadas"
        TreeNode6.ImageIndex = 2
        TreeNode6.Name = "Node25"
        TreeNode6.SelectedImageIndex = 2
        TreeNode6.Text = "Por Despachar"
        TreeNode7.ImageIndex = 3
        TreeNode7.Name = "Node26"
        TreeNode7.SelectedImageIndex = 3
        TreeNode7.Text = "Alerta Despacho"
        TreeNode8.ImageIndex = 4
        TreeNode8.Name = "MDespacho"
        TreeNode8.SelectedImageIndex = 4
        TreeNode8.Text = "Despacho de Componentes"
        TreeNode9.Name = "Node30"
        TreeNode9.Text = "Node30"
        TreeNode10.Name = "Node31"
        TreeNode10.Text = "Node31"
        TreeNode11.Name = "Node32"
        TreeNode11.Text = "Node32"
        TreeNode12.Name = "Node27"
        TreeNode12.Text = "Cores / Fuera de Servicio"
        TreeNode13.Name = "Node33"
        TreeNode13.Text = "Node33"
        TreeNode14.Name = "Node34"
        TreeNode14.Text = "Node34"
        TreeNode15.Name = "Node35"
        TreeNode15.Text = "Node35"
        TreeNode16.Name = "Node28"
        TreeNode16.Text = "Node28"
        TreeNode17.ImageIndex = 7
        TreeNode17.Name = "Node41"
        TreeNode17.SelectedImageIndex = 7
        TreeNode17.Text = "Reporte Dinamico"
        TreeNode18.ImageIndex = 4
        TreeNode18.Name = "Node40"
        TreeNode18.SelectedImageIndex = 4
        TreeNode18.Text = "Reportes"
        Me.treeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8, TreeNode12, TreeNode16, TreeNode18})
        Me.treeView.SelectedImageIndex = 0
        Me.treeView.Size = New System.Drawing.Size(117, 237)
        Me.treeView.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search.ico")
        Me.ImageList1.Images.SetKeyName(1, "ball_green.ico")
        Me.ImageList1.Images.SetKeyName(2, "ball_yellow.ico")
        Me.ImageList1.Images.SetKeyName(3, "ball_red.ico")
        Me.ImageList1.Images.SetKeyName(4, "027-folder_search.ico")
        Me.ImageList1.Images.SetKeyName(5, "Open2.ico")
        Me.ImageList1.Images.SetKeyName(6, "Closed1.ico")
        Me.ImageList1.Images.SetKeyName(7, "playlist.png")
        '
        'kryptonBorderEdge5
        '
        Me.kryptonBorderEdge5.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge5.Location = New System.Drawing.Point(0, 29)
        Me.kryptonBorderEdge5.Name = "kryptonBorderEdge5"
        Me.kryptonBorderEdge5.Size = New System.Drawing.Size(117, 1)
        Me.kryptonBorderEdge5.Text = "kryptonBorderEdge5"
        '
        'kryptonHeader
        '
        Me.kryptonHeader.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1, Me.ButtonSpecAny2})
        Me.kryptonHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonHeader.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeader.Name = "kryptonHeader"
        Me.kryptonHeader.Size = New System.Drawing.Size(117, 29)
        Me.kryptonHeader.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonHeader.TabIndex = 5
        Me.kryptonHeader.Values.Description = ""
        Me.kryptonHeader.Values.Heading = "Calendar"
        Me.kryptonHeader.Values.Image = Nothing
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.Text = "<<"
        Me.ButtonSpecAny1.UniqueName = "5E8362A170054752489F0C23F85F8849"
        '
        'ButtonSpecAny2
        '
        Me.ButtonSpecAny2.Image = CType(resources.GetObject("ButtonSpecAny2.Image"), System.Drawing.Image)
        Me.ButtonSpecAny2.UniqueName = "138F08949F1847D68D8E073B0394879D"
        '
        'kryptonBorderEdge4
        '
        Me.kryptonBorderEdge4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge4.Location = New System.Drawing.Point(0, 267)
        Me.kryptonBorderEdge4.Name = "kryptonBorderEdge4"
        Me.kryptonBorderEdge4.Size = New System.Drawing.Size(117, 1)
        Me.kryptonBorderEdge4.Text = "kryptonBorderEdge4"
        '
        'BtnIngreso
        '
        Me.BtnIngreso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnIngreso.Location = New System.Drawing.Point(453, 13)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(117, 25)
        Me.BtnIngreso.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.BtnIngreso.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnIngreso.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnIngreso.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnIngreso.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnIngreso.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnIngreso.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnIngreso.TabIndex = 2
        Me.BtnIngreso.Values.Image = CType(resources.GetObject("BtnIngreso.Values.Image"), System.Drawing.Image)
        Me.BtnIngreso.Values.Text = "Ingreso"
        '
        'kryptonBorderEdge3
        '
        Me.kryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge3.Location = New System.Drawing.Point(0, 293)
        Me.kryptonBorderEdge3.Name = "kryptonBorderEdge3"
        Me.kryptonBorderEdge3.Size = New System.Drawing.Size(117, 1)
        Me.kryptonBorderEdge3.Text = "kryptonBorderEdge3"
        '
        'BtnRecepTaller
        '
        Me.BtnRecepTaller.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRecepTaller.Location = New System.Drawing.Point(0, 294)
        Me.BtnRecepTaller.Name = "BtnRecepTaller"
        Me.BtnRecepTaller.Size = New System.Drawing.Size(117, 25)
        Me.BtnRecepTaller.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.BtnRecepTaller.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnRecepTaller.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnRecepTaller.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnRecepTaller.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnRecepTaller.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnRecepTaller.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnRecepTaller.TabIndex = 3
        Me.BtnRecepTaller.Values.Image = CType(resources.GetObject("BtnRecepTaller.Values.Image"), System.Drawing.Image)
        Me.BtnRecepTaller.Values.Text = "Recepcion Talleres"
        '
        'kryptonBorderEdge2
        '
        Me.kryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge2.Location = New System.Drawing.Point(0, 319)
        Me.kryptonBorderEdge2.Name = "kryptonBorderEdge2"
        Me.kryptonBorderEdge2.Size = New System.Drawing.Size(117, 1)
        Me.kryptonBorderEdge2.Text = "kryptonBorderEdge2"
        '
        'BtnCorres
        '
        Me.BtnCorres.Checked = True
        Me.BtnCorres.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCorres.Location = New System.Drawing.Point(0, 320)
        Me.BtnCorres.Name = "BtnCorres"
        Me.BtnCorres.Size = New System.Drawing.Size(117, 25)
        Me.BtnCorres.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.BtnCorres.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnCorres.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnCorres.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnCorres.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnCorres.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BtnCorres.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BtnCorres.TabIndex = 4
        Me.BtnCorres.Values.Image = CType(resources.GetObject("BtnCorres.Values.Image"), System.Drawing.Image)
        Me.BtnCorres.Values.Text = "Tiempo"
        '
        'kryptonBorderEdge1
        '
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 345)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(117, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        '
        'KryptonCheckButton6
        '
        Me.KryptonCheckButton6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonCheckButton6.Location = New System.Drawing.Point(0, 346)
        Me.KryptonCheckButton6.Name = "KryptonCheckButton6"
        Me.KryptonCheckButton6.Size = New System.Drawing.Size(117, 25)
        Me.KryptonCheckButton6.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.KryptonCheckButton6.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonCheckButton6.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonCheckButton6.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonCheckButton6.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonCheckButton6.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonCheckButton6.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonCheckButton6.TabIndex = 5
        Me.KryptonCheckButton6.Values.Image = CType(resources.GetObject("KryptonCheckButton6.Values.Image"), System.Drawing.Image)
        Me.KryptonCheckButton6.Values.Text = "Reportas"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarLaSesionToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarLaSesionToolStripMenuItem
        '
        Me.CerrarLaSesionToolStripMenuItem.Name = "CerrarLaSesionToolStripMenuItem"
        Me.CerrarLaSesionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CerrarLaSesionToolStripMenuItem.Text = "Cerrar la Sesión"
        Me.CerrarLaSesionToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosGeneralesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.AmbienteToolStripMenuItem, Me.TipoTableroToolStripMenuItem, Me.TableroToolStripMenuItem, Me.ToolStripSeparator11, Me.GrupoToolStripMenuItem, Me.SubCategoriasToolStripMenuItem, Me.ComponenteToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.ToolStripSeparator2, Me.ProgramarMozosZonasToolStripMenuItem, Me.ToolStripSeparator4, Me.ClientesToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'MantenimientosGeneralesToolStripMenuItem
        '
        Me.MantenimientosGeneralesToolStripMenuItem.Image = CType(resources.GetObject("MantenimientosGeneralesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimientosGeneralesToolStripMenuItem.Name = "MantenimientosGeneralesToolStripMenuItem"
        Me.MantenimientosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MantenimientosGeneralesToolStripMenuItem.Text = "Generales"
        Me.MantenimientosGeneralesToolStripMenuItem.Visible = False
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EmpleadosToolStripMenuItem.Text = "&Empleados"
        Me.EmpleadosToolStripMenuItem.Visible = False
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        Me.UsuariosToolStripMenuItem.Visible = False
        '
        'AmbienteToolStripMenuItem
        '
        Me.AmbienteToolStripMenuItem.Name = "AmbienteToolStripMenuItem"
        Me.AmbienteToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AmbienteToolStripMenuItem.Text = "&Ambiente"
        Me.AmbienteToolStripMenuItem.Visible = False
        '
        'TipoTableroToolStripMenuItem
        '
        Me.TipoTableroToolStripMenuItem.Name = "TipoTableroToolStripMenuItem"
        Me.TipoTableroToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.TipoTableroToolStripMenuItem.Text = "&Tipo Tablero"
        Me.TipoTableroToolStripMenuItem.Visible = False
        '
        'TableroToolStripMenuItem
        '
        Me.TableroToolStripMenuItem.Name = "TableroToolStripMenuItem"
        Me.TableroToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.TableroToolStripMenuItem.Text = "&Tablero"
        Me.TableroToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(200, 6)
        Me.ToolStripSeparator11.Visible = False
        '
        'GrupoToolStripMenuItem
        '
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.GrupoToolStripMenuItem.Text = "&Grupo"
        '
        'SubCategoriasToolStripMenuItem
        '
        Me.SubCategoriasToolStripMenuItem.Name = "SubCategoriasToolStripMenuItem"
        Me.SubCategoriasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SubCategoriasToolStripMenuItem.Text = "&Sub Categorias"
        '
        'ComponenteToolStripMenuItem
        '
        Me.ComponenteToolStripMenuItem.Name = "ComponenteToolStripMenuItem"
        Me.ComponenteToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ComponenteToolStripMenuItem.Text = "&Productos"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.InsumosToolStripMenuItem.Text = "&Insumos"
        Me.InsumosToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'ProgramarMozosZonasToolStripMenuItem
        '
        Me.ProgramarMozosZonasToolStripMenuItem.Name = "ProgramarMozosZonasToolStripMenuItem"
        Me.ProgramarMozosZonasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ProgramarMozosZonasToolStripMenuItem.Text = "Programar Mozos Zonas"
        Me.ProgramarMozosZonasToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.EgresosToolStripMenuItem, Me.MososToolStripMenuItem, Me.IngresosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        Me.ReportesToolStripMenuItem.Visible = False
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.VentasToolStripMenuItem.Text = "&Ventas"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
        '
        'MososToolStripMenuItem
        '
        Me.MososToolStripMenuItem.Name = "MososToolStripMenuItem"
        Me.MososToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.MososToolStripMenuItem.Text = "&Mosos"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IngresosToolStripMenuItem.Text = "&Ingresos"
        '
        'HerraminetasToolStripMenuItem
        '
        Me.HerraminetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioDePasswordToolStripMenuItem})
        Me.HerraminetasToolStripMenuItem.Name = "HerraminetasToolStripMenuItem"
        Me.HerraminetasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerraminetasToolStripMenuItem.Text = "Herramientas"
        Me.HerraminetasToolStripMenuItem.Visible = False
        '
        'CambioDePasswordToolStripMenuItem
        '
        Me.CambioDePasswordToolStripMenuItem.Image = CType(resources.GetObject("CambioDePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambioDePasswordToolStripMenuItem.Name = "CambioDePasswordToolStripMenuItem"
        Me.CambioDePasswordToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CambioDePasswordToolStripMenuItem.Text = "Cambio de Password"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionCalendarioToolStripMenuItem, Me.ConfiguracionProductosToolStripMenuItem, Me.ToolStripSeparator1, Me.CuponBonusToolStripMenuItem, Me.BancoBonusToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(89, 20)
        Me.ToolStripMenuItem2.Text = "&Promociones"
        Me.ToolStripMenuItem2.Visible = False
        '
        'ConfiguracionCalendarioToolStripMenuItem
        '
        Me.ConfiguracionCalendarioToolStripMenuItem.Name = "ConfiguracionCalendarioToolStripMenuItem"
        Me.ConfiguracionCalendarioToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ConfiguracionCalendarioToolStripMenuItem.Text = "&Configuracion Calendario"
        '
        'ConfiguracionProductosToolStripMenuItem
        '
        Me.ConfiguracionProductosToolStripMenuItem.Name = "ConfiguracionProductosToolStripMenuItem"
        Me.ConfiguracionProductosToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ConfiguracionProductosToolStripMenuItem.Text = "&Configuracion Productos (Promoción)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(274, 6)
        '
        'CuponBonusToolStripMenuItem
        '
        Me.CuponBonusToolStripMenuItem.Name = "CuponBonusToolStripMenuItem"
        Me.CuponBonusToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.CuponBonusToolStripMenuItem.Text = "&Cupon Bonus Generados"
        '
        'BancoBonusToolStripMenuItem
        '
        Me.BancoBonusToolStripMenuItem.Name = "BancoBonusToolStripMenuItem"
        Me.BancoBonusToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.BancoBonusToolStripMenuItem.Text = "&Banco Bonus Clientes (Bitcoins)"
        Me.BancoBonusToolStripMenuItem.Visible = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.CajasToolStripMenuItem, Me.ToolStripMenuItem2, Me.AtencionToolStripMenuItem, Me.ProduccionToolStripMenuItem, Me.ComprobantesToolStripMenuItem, Me.LogisticaToolStripMenuItem, Me.AlmacenToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerraminetasToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(938, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CajasToolStripMenuItem
        '
        Me.CajasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlCajaToolStripMenuItem, Me.ReporteArqueoToolStripMenuItem, Me.ToolStripSeparator5, Me.TesoreriaToolStripMenuItem})
        Me.CajasToolStripMenuItem.Name = "CajasToolStripMenuItem"
        Me.CajasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.CajasToolStripMenuItem.Text = "&Control Cajas"
        '
        'ControlCajaToolStripMenuItem
        '
        Me.ControlCajaToolStripMenuItem.Name = "ControlCajaToolStripMenuItem"
        Me.ControlCajaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ControlCajaToolStripMenuItem.Text = "Control Caja"
        '
        'ReporteArqueoToolStripMenuItem
        '
        Me.ReporteArqueoToolStripMenuItem.Name = "ReporteArqueoToolStripMenuItem"
        Me.ReporteArqueoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ReporteArqueoToolStripMenuItem.Text = "Reporte Arqueo"
        Me.ReporteArqueoToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(154, 6)
        Me.ToolStripSeparator5.Visible = False
        '
        'TesoreriaToolStripMenuItem
        '
        Me.TesoreriaToolStripMenuItem.Name = "TesoreriaToolStripMenuItem"
        Me.TesoreriaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TesoreriaToolStripMenuItem.Text = "&Tesoreria"
        Me.TesoreriaToolStripMenuItem.Visible = False
        '
        'AtencionToolStripMenuItem
        '
        Me.AtencionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServicioComedorToolStripMenuItem, Me.ServicioRapidoToolStripMenuItem1, Me.ComanderoToolStripMenuItem1})
        Me.AtencionToolStripMenuItem.Name = "AtencionToolStripMenuItem"
        Me.AtencionToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AtencionToolStripMenuItem.Text = "&Atencion"
        '
        'ServicioComedorToolStripMenuItem
        '
        Me.ServicioComedorToolStripMenuItem.Name = "ServicioComedorToolStripMenuItem"
        Me.ServicioComedorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ServicioComedorToolStripMenuItem.Text = "&Servicio Comedor"
        Me.ServicioComedorToolStripMenuItem.Visible = False
        '
        'ServicioRapidoToolStripMenuItem1
        '
        Me.ServicioRapidoToolStripMenuItem1.Name = "ServicioRapidoToolStripMenuItem1"
        Me.ServicioRapidoToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ServicioRapidoToolStripMenuItem1.Text = "&Atención Ventas"
        '
        'ComanderoToolStripMenuItem1
        '
        Me.ComanderoToolStripMenuItem1.Name = "ComanderoToolStripMenuItem1"
        Me.ComanderoToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ComanderoToolStripMenuItem1.Text = "&Comandero"
        Me.ComanderoToolStripMenuItem1.Visible = False
        '
        'ProduccionToolStripMenuItem
        '
        Me.ProduccionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CocinaCalienteToolStripMenuItem, Me.BarraToolStripMenuItem, Me.BrazasToolStripMenuItem})
        Me.ProduccionToolStripMenuItem.Name = "ProduccionToolStripMenuItem"
        Me.ProduccionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ProduccionToolStripMenuItem.Text = "&Produccion"
        Me.ProduccionToolStripMenuItem.Visible = False
        '
        'CocinaCalienteToolStripMenuItem
        '
        Me.CocinaCalienteToolStripMenuItem.Name = "CocinaCalienteToolStripMenuItem"
        Me.CocinaCalienteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CocinaCalienteToolStripMenuItem.Text = "&Cocina Caliente"
        '
        'BarraToolStripMenuItem
        '
        Me.BarraToolStripMenuItem.Name = "BarraToolStripMenuItem"
        Me.BarraToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BarraToolStripMenuItem.Text = "&Barra"
        '
        'BrazasToolStripMenuItem
        '
        Me.BrazasToolStripMenuItem.Name = "BrazasToolStripMenuItem"
        Me.BrazasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BrazasToolStripMenuItem.Text = "Brazas"
        Me.BrazasToolStripMenuItem.Visible = False
        '
        'ComprobantesToolStripMenuItem
        '
        Me.ComprobantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobantesGeneradosToolStripMenuItem, Me.AnuladosToolStripMenuItem, Me.NotasCreditoToolStripMenuItem, Me.NotasDebitoToolStripMenuItem, Me.ToolStripSeparator6, Me.EnviosToolStripMenuItem, Me.DescagarComprobanteToolStripMenuItem, Me.LogSunatToolStripMenuItem})
        Me.ComprobantesToolStripMenuItem.Name = "ComprobantesToolStripMenuItem"
        Me.ComprobantesToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ComprobantesToolStripMenuItem.Text = "&Comprobantes"
        '
        'ComprobantesGeneradosToolStripMenuItem
        '
        Me.ComprobantesGeneradosToolStripMenuItem.Name = "ComprobantesGeneradosToolStripMenuItem"
        Me.ComprobantesGeneradosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ComprobantesGeneradosToolStripMenuItem.Text = "&Comprobantes Generados"
        '
        'AnuladosToolStripMenuItem
        '
        Me.AnuladosToolStripMenuItem.Name = "AnuladosToolStripMenuItem"
        Me.AnuladosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AnuladosToolStripMenuItem.Text = "&Comprobantes Baja"
        '
        'NotasCreditoToolStripMenuItem
        '
        Me.NotasCreditoToolStripMenuItem.Name = "NotasCreditoToolStripMenuItem"
        Me.NotasCreditoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.NotasCreditoToolStripMenuItem.Text = "&Notas Credito"
        Me.NotasCreditoToolStripMenuItem.Visible = False
        '
        'NotasDebitoToolStripMenuItem
        '
        Me.NotasDebitoToolStripMenuItem.Name = "NotasDebitoToolStripMenuItem"
        Me.NotasDebitoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.NotasDebitoToolStripMenuItem.Text = "&Notas Debito"
        Me.NotasDebitoToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(211, 6)
        '
        'EnviosToolStripMenuItem
        '
        Me.EnviosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenDiarioToolStripMenuItem1})
        Me.EnviosToolStripMenuItem.Name = "EnviosToolStripMenuItem"
        Me.EnviosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.EnviosToolStripMenuItem.Text = "&Envios Resumen Diario"
        '
        'ResumenDiarioToolStripMenuItem1
        '
        Me.ResumenDiarioToolStripMenuItem1.Name = "ResumenDiarioToolStripMenuItem1"
        Me.ResumenDiarioToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ResumenDiarioToolStripMenuItem1.Text = "&Resumen Diario"
        '
        'DescagarComprobanteToolStripMenuItem
        '
        Me.DescagarComprobanteToolStripMenuItem.Name = "DescagarComprobanteToolStripMenuItem"
        Me.DescagarComprobanteToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DescagarComprobanteToolStripMenuItem.Text = "Descargar Comprobante"
        '
        'LogSunatToolStripMenuItem
        '
        Me.LogSunatToolStripMenuItem.Name = "LogSunatToolStripMenuItem"
        Me.LogSunatToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.LogSunatToolStripMenuItem.Text = "&Log Comunicación SUNAT"
        '
        'LogisticaToolStripMenuItem
        '
        Me.LogisticaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroPedidosToolStripMenuItem, Me.RegistroComprasToolStripMenuItem, Me.AutorizacionesComprasToolStripMenuItem, Me.PagosProveedoresToolStripMenuItem})
        Me.LogisticaToolStripMenuItem.Name = "LogisticaToolStripMenuItem"
        Me.LogisticaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LogisticaToolStripMenuItem.Text = "&Logistica"
        Me.LogisticaToolStripMenuItem.Visible = False
        '
        'RegistroPedidosToolStripMenuItem
        '
        Me.RegistroPedidosToolStripMenuItem.Name = "RegistroPedidosToolStripMenuItem"
        Me.RegistroPedidosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RegistroPedidosToolStripMenuItem.Text = "&Registro Pedidos"
        '
        'RegistroComprasToolStripMenuItem
        '
        Me.RegistroComprasToolStripMenuItem.Name = "RegistroComprasToolStripMenuItem"
        Me.RegistroComprasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RegistroComprasToolStripMenuItem.Text = "&Registro Compras"
        '
        'AutorizacionesComprasToolStripMenuItem
        '
        Me.AutorizacionesComprasToolStripMenuItem.Name = "AutorizacionesComprasToolStripMenuItem"
        Me.AutorizacionesComprasToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AutorizacionesComprasToolStripMenuItem.Text = "&Autorizaciones Compras"
        '
        'PagosProveedoresToolStripMenuItem
        '
        Me.PagosProveedoresToolStripMenuItem.Name = "PagosProveedoresToolStripMenuItem"
        Me.PagosProveedoresToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PagosProveedoresToolStripMenuItem.Text = "Pagos Proveedores"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecepcionToolStripMenuItem, Me.IngresoAlmacenToolStripMenuItem, Me.AlmacenCentralToolStripMenuItem})
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AlmacenToolStripMenuItem.Text = "&Almacen"
        Me.AlmacenToolStripMenuItem.Visible = False
        '
        'RecepcionToolStripMenuItem
        '
        Me.RecepcionToolStripMenuItem.Name = "RecepcionToolStripMenuItem"
        Me.RecepcionToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RecepcionToolStripMenuItem.Text = "&Recepcion"
        '
        'IngresoAlmacenToolStripMenuItem
        '
        Me.IngresoAlmacenToolStripMenuItem.Name = "IngresoAlmacenToolStripMenuItem"
        Me.IngresoAlmacenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.IngresoAlmacenToolStripMenuItem.Text = "&Ingreso Almacen"
        '
        'AlmacenCentralToolStripMenuItem
        '
        Me.AlmacenCentralToolStripMenuItem.Name = "AlmacenCentralToolStripMenuItem"
        Me.AlmacenCentralToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AlmacenCentralToolStripMenuItem.Text = "&Almacen Central"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ConsultasIngresosToolStripMenuItem, Me.ConsultasEgresosToolStripMenuItem, Me.ConsultasIngresoRestauranteToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        Me.ConsultasToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(230, 6)
        Me.ToolStripSeparator3.Visible = False
        '
        'ConsultasIngresosToolStripMenuItem
        '
        Me.ConsultasIngresosToolStripMenuItem.Name = "ConsultasIngresosToolStripMenuItem"
        Me.ConsultasIngresosToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ConsultasIngresosToolStripMenuItem.Text = "&Consultas Ingresos"
        Me.ConsultasIngresosToolStripMenuItem.Visible = False
        '
        'ConsultasEgresosToolStripMenuItem
        '
        Me.ConsultasEgresosToolStripMenuItem.Name = "ConsultasEgresosToolStripMenuItem"
        Me.ConsultasEgresosToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ConsultasEgresosToolStripMenuItem.Text = "Consultas Egresos"
        Me.ConsultasEgresosToolStripMenuItem.Visible = False
        '
        'ConsultasIngresoRestauranteToolStripMenuItem
        '
        Me.ConsultasIngresoRestauranteToolStripMenuItem.Name = "ConsultasIngresoRestauranteToolStripMenuItem"
        Me.ConsultasIngresoRestauranteToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ConsultasIngresoRestauranteToolStripMenuItem.Text = "&Consultas Ingreso Restaurante"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 20)
        '
        'statusStrip1
        '
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.VersionToolStripStatusLabel, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 512)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(938, 22)
        Me.statusStrip1.TabIndex = 157
        Me.statusStrip1.Text = "statusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel2.Text = "Versión"
        '
        'VersionToolStripStatusLabel
        '
        Me.VersionToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionToolStripStatusLabel.Name = "VersionToolStripStatusLabel"
        Me.VersionToolStripStatusLabel.Size = New System.Drawing.Size(102, 17)
        Me.VersionToolStripStatusLabel.Text = "Versión  1.0.3    "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel6.Text = "   "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(938, 534)
        Me.Controls.Add(Me.pcMain)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.statusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sunat"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcMain.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip

    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton

    Private WithEvents treeView As System.Windows.Forms.TreeView
    Private WithEvents kryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Private WithEvents kryptonHeader As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents kryptonBorderEdge4 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Private WithEvents BtnIngreso As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Private WithEvents kryptonBorderEdge3 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Private WithEvents BtnRecepTaller As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Private WithEvents kryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Private WithEvents BtnCorres As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Private WithEvents kryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Private WithEvents KryptonCheckButton6 As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private WithEvents BtnRececepcion As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    'Friend WithEvents ControlAlmCore1 As SwRecepcion.ControlAlmCore

    Private WithEvents pcMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarLaSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerraminetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents GroupControl1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VersionToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents CajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmbienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoTableroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents GrupoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComponenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogisticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramarMozosZonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecepcionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenCentralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtencionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicioComedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicioRapidoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComanderoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteArqueoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MososToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogSunatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnuladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TesoreriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorizacionesComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CocinaCalienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrazasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasIngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasEgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ConfiguracionCalendarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuponBonusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancoBonusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ConsultasIngresoRestauranteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasCreditoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasDebitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents DescagarComprobanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumenDiarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComprobantesGeneradosToolStripMenuItem As ToolStripMenuItem
End Class



'' '' ''<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
'' '' ''Partial Class FrmPrincipal
'' '' ''    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

'' '' ''    'Form reemplaza a Dispose para limpiar la lista de componentes.
'' '' ''    <System.Diagnostics.DebuggerNonUserCode()> _
'' '' ''    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'' '' ''        If disposing AndAlso components IsNot Nothing Then
'' '' ''            components.Dispose()
'' '' ''        End If
'' '' ''        MyBase.Dispose(disposing)
'' '' ''    End Sub


'' '' ''    'Requerido por el Diseñador de Windows Forms
'' '' ''    Private components As System.ComponentModel.IContainer

'' '' ''    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
'' '' ''    'Se puede modificar usando el Diseñador de Windows Forms.  
'' '' ''    'No lo modifique con el editor de código.
'' '' ''    <System.Diagnostics.DebuggerStepThrough()> _
'' '' ''    Private Sub InitializeComponent()
'' '' ''        Me.components = New System.ComponentModel.Container
'' '' ''        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
'' '' ''        Me.MenuStrip = New System.Windows.Forms.MenuStrip
'' '' ''        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.CerrarLaSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
'' '' ''        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.MantenimientosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.RecepciónDePlantillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.UbicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.DocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.UnidadDeAlmacenamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.SerieDocumentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.LiberarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.MigradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.PedidoDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.AtenciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.DevoluciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.ProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.DocumentosSinDevolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.HistorialDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.HerraminetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.CambioDePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.AlertaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.AlertaAtencionInternoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.AlertaAtencionExternosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
'' '' ''        Me.ToolStrip = New System.Windows.Forms.ToolStrip
'' '' ''        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
'' '' ''        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
'' '' ''        Me.StatusStrip = New System.Windows.Forms.StatusStrip
'' '' ''        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
'' '' ''        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
'' '' ''        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
'' '' ''        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
'' '' ''        Me.PictureBox1 = New System.Windows.Forms.PictureBox
'' '' ''        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
'' '' ''        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
'' '' ''        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
'' '' ''        Me.MenuStrip.SuspendLayout()
'' '' ''        Me.ToolStrip.SuspendLayout()
'' '' ''        Me.StatusStrip.SuspendLayout()
'' '' ''        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
'' '' ''        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
'' '' ''        Me.KryptonPanel1.SuspendLayout()
'' '' ''        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
'' '' ''        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
'' '' ''        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
'' '' ''        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
'' '' ''        Me.KryptonSplitContainer1.SuspendLayout()
'' '' ''        Me.SuspendLayout()
'' '' ''        '
'' '' ''        'MenuStrip
'' '' ''        '
'' '' ''        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!)
'' '' ''        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerraminetasToolStripMenuItem, Me.AyudaToolStripMenuItem})
'' '' ''        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
'' '' ''        Me.MenuStrip.Name = "MenuStrip"
'' '' ''        Me.MenuStrip.Size = New System.Drawing.Size(793, 24)
'' '' ''        Me.MenuStrip.TabIndex = 5
'' '' ''        Me.MenuStrip.Text = "MenuStrip"
'' '' ''        '
'' '' ''        'ArchivoToolStripMenuItem
'' '' ''        '
'' '' ''        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarLaSesionToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
'' '' ''        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
'' '' ''        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
'' '' ''        Me.ArchivoToolStripMenuItem.Text = "Archivo"
'' '' ''        '
'' '' ''        'CerrarLaSesionToolStripMenuItem
'' '' ''        '
'' '' ''        Me.CerrarLaSesionToolStripMenuItem.Image = CType(resources.GetObject("CerrarLaSesionToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.CerrarLaSesionToolStripMenuItem.Name = "CerrarLaSesionToolStripMenuItem"
'' '' ''        Me.CerrarLaSesionToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
'' '' ''        Me.CerrarLaSesionToolStripMenuItem.Text = "Cerrar la Sesión"
'' '' ''        '
'' '' ''        'ToolStripMenuItem1
'' '' ''        '
'' '' ''        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
'' '' ''        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 6)
'' '' ''        '
'' '' ''        'SalirToolStripMenuItem
'' '' ''        '
'' '' ''        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
'' '' ''        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
'' '' ''        Me.SalirToolStripMenuItem.Text = "Salir"
'' '' ''        '
'' '' ''        'MantenimientoToolStripMenuItem
'' '' ''        '
'' '' ''        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosGeneralesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.RecepciónDePlantillasToolStripMenuItem, Me.UbicacionesToolStripMenuItem, Me.DocumentosToolStripMenuItem, Me.UnidadDeAlmacenamientoToolStripMenuItem, Me.SerieDocumentalToolStripMenuItem, Me.LiberarDocumentoToolStripMenuItem, Me.MigradorToolStripMenuItem})
'' '' ''        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
'' '' ''        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
'' '' ''        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
'' '' ''        '
'' '' ''        'MantenimientosGeneralesToolStripMenuItem
'' '' ''        '
'' '' ''        Me.MantenimientosGeneralesToolStripMenuItem.Image = CType(resources.GetObject("MantenimientosGeneralesToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.MantenimientosGeneralesToolStripMenuItem.Name = "MantenimientosGeneralesToolStripMenuItem"
'' '' ''        Me.MantenimientosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.MantenimientosGeneralesToolStripMenuItem.Text = "Generales"
'' '' ''        '
'' '' ''        'EmpleadosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.EmpleadosToolStripMenuItem.Image = CType(resources.GetObject("EmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
'' '' ''        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
'' '' ''        '
'' '' ''        'UsuariosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
'' '' ''        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
'' '' ''        '
'' '' ''        'RecepciónDePlantillasToolStripMenuItem
'' '' ''        '
'' '' ''        Me.RecepciónDePlantillasToolStripMenuItem.Image = CType(resources.GetObject("RecepciónDePlantillasToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.RecepciónDePlantillasToolStripMenuItem.Name = "RecepciónDePlantillasToolStripMenuItem"
'' '' ''        Me.RecepciónDePlantillasToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.RecepciónDePlantillasToolStripMenuItem.Text = "Recepción de Plantillas"
'' '' ''        '
'' '' ''        'UbicacionesToolStripMenuItem
'' '' ''        '
'' '' ''        Me.UbicacionesToolStripMenuItem.Image = CType(resources.GetObject("UbicacionesToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.UbicacionesToolStripMenuItem.Name = "UbicacionesToolStripMenuItem"
'' '' ''        Me.UbicacionesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.UbicacionesToolStripMenuItem.Text = "Ubicaciones"
'' '' ''        '
'' '' ''        'DocumentosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.DocumentosToolStripMenuItem.Image = CType(resources.GetObject("DocumentosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.DocumentosToolStripMenuItem.Name = "DocumentosToolStripMenuItem"
'' '' ''        Me.DocumentosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.DocumentosToolStripMenuItem.Text = "Documentos"
'' '' ''        '
'' '' ''        'UnidadDeAlmacenamientoToolStripMenuItem
'' '' ''        '
'' '' ''        Me.UnidadDeAlmacenamientoToolStripMenuItem.Name = "UnidadDeAlmacenamientoToolStripMenuItem"
'' '' ''        Me.UnidadDeAlmacenamientoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.UnidadDeAlmacenamientoToolStripMenuItem.Text = "Unidad de Almacenamiento"
'' '' ''        Me.UnidadDeAlmacenamientoToolStripMenuItem.Visible = False
'' '' ''        '
'' '' ''        'SerieDocumentalToolStripMenuItem
'' '' ''        '
'' '' ''        Me.SerieDocumentalToolStripMenuItem.Name = "SerieDocumentalToolStripMenuItem"
'' '' ''        Me.SerieDocumentalToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.SerieDocumentalToolStripMenuItem.Text = "Serie Documental"
'' '' ''        Me.SerieDocumentalToolStripMenuItem.Visible = False
'' '' ''        '
'' '' ''        'LiberarDocumentoToolStripMenuItem
'' '' ''        '
'' '' ''        Me.LiberarDocumentoToolStripMenuItem.Image = CType(resources.GetObject("LiberarDocumentoToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.LiberarDocumentoToolStripMenuItem.Name = "LiberarDocumentoToolStripMenuItem"
'' '' ''        Me.LiberarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.LiberarDocumentoToolStripMenuItem.Text = "Liberar Documento"
'' '' ''        '
'' '' ''        'MigradorToolStripMenuItem
'' '' ''        '
'' '' ''        Me.MigradorToolStripMenuItem.Image = CType(resources.GetObject("MigradorToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.MigradorToolStripMenuItem.Name = "MigradorToolStripMenuItem"
'' '' ''        Me.MigradorToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
'' '' ''        Me.MigradorToolStripMenuItem.Text = "Migrador"
'' '' ''        '
'' '' ''        'ProcesosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidoDeDocumentosToolStripMenuItem, Me.AtenciónToolStripMenuItem, Me.DevoluciónToolStripMenuItem})
'' '' ''        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
'' '' ''        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
'' '' ''        Me.ProcesosToolStripMenuItem.Text = "Procesos"
'' '' ''        '
'' '' ''        'PedidoDeDocumentosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.PedidoDeDocumentosToolStripMenuItem.Image = CType(resources.GetObject("PedidoDeDocumentosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.PedidoDeDocumentosToolStripMenuItem.Name = "PedidoDeDocumentosToolStripMenuItem"
'' '' ''        Me.PedidoDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
'' '' ''        Me.PedidoDeDocumentosToolStripMenuItem.Text = "Pedido"
'' '' ''        '
'' '' ''        'AtenciónToolStripMenuItem
'' '' ''        '
'' '' ''        Me.AtenciónToolStripMenuItem.Image = CType(resources.GetObject("AtenciónToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.AtenciónToolStripMenuItem.Name = "AtenciónToolStripMenuItem"
'' '' ''        Me.AtenciónToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
'' '' ''        Me.AtenciónToolStripMenuItem.Text = "Atención"
'' '' ''        '
'' '' ''        'DevoluciónToolStripMenuItem
'' '' ''        '
'' '' ''        Me.DevoluciónToolStripMenuItem.Image = CType(resources.GetObject("DevoluciónToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.DevoluciónToolStripMenuItem.Name = "DevoluciónToolStripMenuItem"
'' '' ''        Me.DevoluciónToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
'' '' ''        Me.DevoluciónToolStripMenuItem.Text = "Devolución"
'' '' ''        '
'' '' ''        'ReportesToolStripMenuItem
'' '' ''        '
'' '' ''        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProducciónToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.DocumentosSinDevolverToolStripMenuItem, Me.HistorialDeDocumentosToolStripMenuItem, Me.CargosToolStripMenuItem})
'' '' ''        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
'' '' ''        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
'' '' ''        Me.ReportesToolStripMenuItem.Text = "Reportes"
'' '' ''        '
'' '' ''        'ProducciónToolStripMenuItem
'' '' ''        '
'' '' ''        Me.ProducciónToolStripMenuItem.Image = CType(resources.GetObject("ProducciónToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.ProducciónToolStripMenuItem.Name = "ProducciónToolStripMenuItem"
'' '' ''        Me.ProducciónToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
'' '' ''        Me.ProducciónToolStripMenuItem.Text = "Producción"
'' '' ''        '
'' '' ''        'InventarioToolStripMenuItem
'' '' ''        '
'' '' ''        Me.InventarioToolStripMenuItem.Image = CType(resources.GetObject("InventarioToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
'' '' ''        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
'' '' ''        Me.InventarioToolStripMenuItem.Text = "Inventario"
'' '' ''        '
'' '' ''        'DocumentosSinDevolverToolStripMenuItem
'' '' ''        '
'' '' ''        Me.DocumentosSinDevolverToolStripMenuItem.Image = CType(resources.GetObject("DocumentosSinDevolverToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.DocumentosSinDevolverToolStripMenuItem.Name = "DocumentosSinDevolverToolStripMenuItem"
'' '' ''        Me.DocumentosSinDevolverToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
'' '' ''        Me.DocumentosSinDevolverToolStripMenuItem.Text = "Documentos sin Devolver"
'' '' ''        '
'' '' ''        'HistorialDeDocumentosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.HistorialDeDocumentosToolStripMenuItem.Image = CType(resources.GetObject("HistorialDeDocumentosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.HistorialDeDocumentosToolStripMenuItem.Name = "HistorialDeDocumentosToolStripMenuItem"
'' '' ''        Me.HistorialDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
'' '' ''        Me.HistorialDeDocumentosToolStripMenuItem.Text = "Historial de Documentos"
'' '' ''        '
'' '' ''        'CargosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.CargosToolStripMenuItem.Image = CType(resources.GetObject("CargosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
'' '' ''        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
'' '' ''        Me.CargosToolStripMenuItem.Text = "Generar Cargos"
'' '' ''        '
'' '' ''        'HerraminetasToolStripMenuItem
'' '' ''        '
'' '' ''        Me.HerraminetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioDePasswordToolStripMenuItem, Me.AlertaToolStripMenuItem})
'' '' ''        Me.HerraminetasToolStripMenuItem.Name = "HerraminetasToolStripMenuItem"
'' '' ''        Me.HerraminetasToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
'' '' ''        Me.HerraminetasToolStripMenuItem.Text = "Herramientas"
'' '' ''        '
'' '' ''        'CambioDePasswordToolStripMenuItem
'' '' ''        '
'' '' ''        Me.CambioDePasswordToolStripMenuItem.Image = CType(resources.GetObject("CambioDePasswordToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.CambioDePasswordToolStripMenuItem.Name = "CambioDePasswordToolStripMenuItem"
'' '' ''        Me.CambioDePasswordToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
'' '' ''        Me.CambioDePasswordToolStripMenuItem.Text = "Cambio de Password"
'' '' ''        '
'' '' ''        'AlertaToolStripMenuItem
'' '' ''        '
'' '' ''        Me.AlertaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlertaAtencionInternoToolStripMenuItem, Me.AlertaAtencionExternosToolStripMenuItem})
'' '' ''        Me.AlertaToolStripMenuItem.Image = CType(resources.GetObject("AlertaToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.AlertaToolStripMenuItem.Name = "AlertaToolStripMenuItem"
'' '' ''        Me.AlertaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
'' '' ''        Me.AlertaToolStripMenuItem.Text = "Alerta"
'' '' ''        '
'' '' ''        'AlertaAtencionInternoToolStripMenuItem
'' '' ''        '
'' '' ''        Me.AlertaAtencionInternoToolStripMenuItem.Image = CType(resources.GetObject("AlertaAtencionInternoToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.AlertaAtencionInternoToolStripMenuItem.Name = "AlertaAtencionInternoToolStripMenuItem"
'' '' ''        Me.AlertaAtencionInternoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
'' '' ''        Me.AlertaAtencionInternoToolStripMenuItem.Text = "Alerta Atencion Interno"
'' '' ''        '
'' '' ''        'AlertaAtencionExternosToolStripMenuItem
'' '' ''        '
'' '' ''        Me.AlertaAtencionExternosToolStripMenuItem.Image = CType(resources.GetObject("AlertaAtencionExternosToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.AlertaAtencionExternosToolStripMenuItem.Name = "AlertaAtencionExternosToolStripMenuItem"
'' '' ''        Me.AlertaAtencionExternosToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
'' '' ''        Me.AlertaAtencionExternosToolStripMenuItem.Text = "Alerta Atencion Externos"
'' '' ''        '
'' '' ''        'AyudaToolStripMenuItem
'' '' ''        '
'' '' ''        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
'' '' ''        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
'' '' ''        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
'' '' ''        Me.AyudaToolStripMenuItem.Text = "Ayuda"
'' '' ''        '
'' '' ''        'AcercaDeToolStripMenuItem
'' '' ''        '
'' '' ''        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
'' '' ''        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
'' '' ''        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
'' '' ''        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
'' '' ''        '
'' '' ''        'ToolStrip
'' '' ''        '
'' '' ''        Me.ToolStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
'' '' ''        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
'' '' ''        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
'' '' ''        Me.ToolStrip.Name = "ToolStrip"
'' '' ''        Me.ToolStrip.Size = New System.Drawing.Size(793, 25)
'' '' ''        Me.ToolStrip.TabIndex = 6
'' '' ''        Me.ToolStrip.Text = "ToolStrip"
'' '' ''        Me.ToolStrip.Visible = False
'' '' ''        '
'' '' ''        'ToolStripButton1
'' '' ''        '
'' '' ''        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'' '' ''        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
'' '' ''        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
'' '' ''        Me.ToolStripButton1.Name = "ToolStripButton1"
'' '' ''        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
'' '' ''        Me.ToolStripButton1.Text = "ToolStripButton1"
'' '' ''        '
'' '' ''        'ToolStripButton2
'' '' ''        '
'' '' ''        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
'' '' ''        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
'' '' ''        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
'' '' ''        Me.ToolStripButton2.Name = "ToolStripButton2"
'' '' ''        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
'' '' ''        Me.ToolStripButton2.Text = "ToolStripButton2"
'' '' ''        '
'' '' ''        'StatusStrip
'' '' ''        '
'' '' ''        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1})
'' '' ''        Me.StatusStrip.Location = New System.Drawing.Point(0, 465)
'' '' ''        Me.StatusStrip.Name = "StatusStrip"
'' '' ''        Me.StatusStrip.Size = New System.Drawing.Size(793, 22)
'' '' ''        Me.StatusStrip.TabIndex = 7
'' '' ''        Me.StatusStrip.Text = "StatusStrip"
'' '' ''        '
'' '' ''        'ToolStripStatusLabel2
'' '' ''        '
'' '' ''        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'' '' ''        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
'' '' ''        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(79, 17)
'' '' ''        Me.ToolStripStatusLabel2.Text = "Versión 1.0.5"
'' '' ''        '
'' '' ''        'ToolStripStatusLabel
'' '' ''        '
'' '' ''        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'' '' ''        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
'' '' ''        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(65, 17)
'' '' ''        Me.ToolStripStatusLabel.Text = "USUARIO :"
'' '' ''        '
'' '' ''        'ToolStripStatusLabel1
'' '' ''        '
'' '' ''        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'' '' ''        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
'' '' ''        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 17)
'' '' ''        Me.ToolStripStatusLabel1.Text = "usuario"
'' '' ''        '
'' '' ''        'PictureBox1
'' '' ''        '
'' '' ''        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
'' '' ''        Me.PictureBox1.Location = New System.Drawing.Point(24, 35)
'' '' ''        Me.PictureBox1.Name = "PictureBox1"
'' '' ''        Me.PictureBox1.Size = New System.Drawing.Size(746, 384)
'' '' ''        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
'' '' ''        Me.PictureBox1.TabIndex = 9
'' '' ''        Me.PictureBox1.TabStop = False
'' '' ''        '
'' '' ''        'KryptonPanel1
'' '' ''        '
'' '' ''        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
'' '' ''        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
'' '' ''        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 24)
'' '' ''        Me.KryptonPanel1.Name = "KryptonPanel1"
'' '' ''        Me.KryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
'' '' ''        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
'' '' ''        Me.KryptonPanel1.Size = New System.Drawing.Size(793, 441)
'' '' ''        Me.KryptonPanel1.TabIndex = 13
'' '' ''        '
'' '' ''        'KryptonSplitContainer1
'' '' ''        '
'' '' ''        Me.KryptonSplitContainer1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
'' '' ''        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
'' '' ''        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
'' '' ''        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
'' '' ''        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
'' '' ''        Me.KryptonSplitContainer1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
'' '' ''        '
'' '' ''        'KryptonSplitContainer1.Panel1
'' '' ''        '
'' '' ''        Me.KryptonSplitContainer1.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
'' '' ''        Me.KryptonSplitContainer1.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
'' '' ''        Me.KryptonSplitContainer1.Panel1Collapsed = True
'' '' ''        Me.KryptonSplitContainer1.Panel1MinSize = 0
'' '' ''        '
'' '' ''        'KryptonSplitContainer1.Panel2
'' '' ''        '
'' '' ''        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
'' '' ''        Me.KryptonSplitContainer1.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
'' '' ''        Me.KryptonSplitContainer1.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
'' '' ''        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile
'' '' ''        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(793, 441)
'' '' ''        Me.KryptonSplitContainer1.SplitterDistance = 264
'' '' ''        Me.KryptonSplitContainer1.TabIndex = 0
'' '' ''        '
'' '' ''        'FrmPrincipal
'' '' ''        '
'' '' ''        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
'' '' ''        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'' '' ''        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
'' '' ''        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'' '' ''        Me.ClientSize = New System.Drawing.Size(793, 487)
'' '' ''        Me.Controls.Add(Me.KryptonPanel1)
'' '' ''        Me.Controls.Add(Me.ToolStrip)
'' '' ''        Me.Controls.Add(Me.MenuStrip)
'' '' ''        Me.Controls.Add(Me.StatusStrip)
'' '' ''        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
'' '' ''        Me.IsMdiContainer = True
'' '' ''        Me.KeyPreview = True
'' '' ''        Me.MainMenuStrip = Me.MenuStrip
'' '' ''        Me.Name = "FrmPrincipal"
'' '' ''        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'' '' ''        Me.Text = "Sistema de Gestión de Archivos [SGA] "
'' '' ''        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'' '' ''        Me.MenuStrip.ResumeLayout(False)
'' '' ''        Me.MenuStrip.PerformLayout()
'' '' ''        Me.ToolStrip.ResumeLayout(False)
'' '' ''        Me.ToolStrip.PerformLayout()
'' '' ''        Me.StatusStrip.ResumeLayout(False)
'' '' ''        Me.StatusStrip.PerformLayout()
'' '' ''        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
'' '' ''        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
'' '' ''        Me.KryptonPanel1.ResumeLayout(False)
'' '' ''        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
'' '' ''        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
'' '' ''        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
'' '' ''        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
'' '' ''        Me.KryptonSplitContainer1.ResumeLayout(False)
'' '' ''        Me.ResumeLayout(False)
'' '' ''        Me.PerformLayout()

'' '' ''    End Sub
'' '' ''    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
'' '' ''    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
'' '' ''    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
'' '' ''    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
'' '' ''    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
'' '' ''    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
'' '' ''    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
'' '' ''    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents HerraminetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents CambioDePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents CerrarLaSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
'' '' ''    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents DocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents PedidoDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents AtenciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents DevoluciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents ProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents DocumentosSinDevolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents HistorialDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
'' '' ''    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents UnidadDeAlmacenamientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents SerieDocumentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    '  Friend WithEvents MantenimientoGeneralUC1 As Sistema.Gestion.Archivos.MantenimientoGeneralUC
'' '' ''    Friend WithEvents MantenimientosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents RecepciónDePlantillasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
'' '' ''    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents UbicacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents CargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents LiberarDocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
'' '' ''    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
'' '' ''    Friend WithEvents GenerarPedido1 As Sistema.Gestion.Archivos.GenerarPedido
'' '' ''    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
'' '' ''    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
'' '' ''    Friend WithEvents MantenimientoGeneralUC1 As Sistema.Gestion.Archivos.MantenimientoGeneralUC
'' '' ''    Friend WithEvents GenerarRecepcion1 As Sistema.Gestion.Archivos.GenerarRecepcion
'' '' ''    Friend WithEvents GenerarRegistros1 As Sistema.Gestion.Archivos.GenerarRegistros
'' '' ''    Friend WithEvents GenerarAtencion1 As Sistema.Gestion.Archivos.GenerarAtencion
'' '' ''    Friend WithEvents GenerarDevolucion1 As Sistema.Gestion.Archivos.GenerarDevolucion
'' '' ''    Friend WithEvents ControlInventario1 As Sistema.Gestion.Archivos.ControlInventario
'' '' ''    Friend WithEvents ControlSinDevolver1 As Sistema.Gestion.Archivos.ControlSinDevolver
'' '' ''    Friend WithEvents ControlHistorial1 As Sistema.Gestion.Archivos.ControlHistorial
'' '' ''    Friend WithEvents MigradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents AlertaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents AlertaAtencionInternoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'' '' ''    Friend WithEvents AlertaAtencionExternosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

'' '' ''End Class
