
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared


'Public Class PrincipalBarcos
'    Inherits System.Windows.Forms.Form

'#Region " Código generado por el Diseñador de Windows Forms "

'    Public Sub New()
'        MyBase.New()

'        'El Diseñador de Windows Forms requiere esta llamada.
'        InitializeComponent()

'        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

'    End Sub

'    'Form reemplaza a Dispose para limpiar la lista de componentes.
'    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            If Not (components Is Nothing) Then
'                components.Dispose()
'            End If
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'    'Requerido por el Diseñador de Windows Forms
'    Private components As System.ComponentModel.IContainer

'    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
'    'Puede modificarse utilizando el Diseñador de Windows Forms. 
'    'No lo modifique con el editor de código.
'    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
'    Friend WithEvents mnuDatos As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuNewEmpl As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuModifEmpl As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuContratos As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuNuevoContrato As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuRevisionSueldo As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuVerHistorico As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuBajaEmpleado As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuVerEmpl As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuGProyectos As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuPorProyecto As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAltaProyecto As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuAuxiliares As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxCalendario As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxContratos As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxJornadas As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxUbicacion As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxCategorias As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxCategoriasBoslan As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxVariables As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListados As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuSalir As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoPersona As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoProyecto As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoFecha As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadosHoras As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuConsultas As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuFremap As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuSeguroVida As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuControlContratos As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuFiniquitos As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuConsultasFix As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuConsultasGen As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadosWeb As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoPerWeb As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoProWeb As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoFechaWeb As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAltaCliente As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListadoHistorico As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuListHistoWEB As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuUsuarios As System.Windows.Forms.MenuItem
'    Friend WithEvents menuAuxCostes As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuFormacionAltas As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuAuxCuentasCotizacion As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuTablaCostes As System.Windows.Forms.MenuItem
'    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
'    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
'    Friend WithEvents mnuVerDatos As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
'    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
'    Friend WithEvents MnuEstadisticas As System.Windows.Forms.MenuItem
'    Friend WithEvents btnSalir As System.Windows.Forms.Button
'    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
'    Friend WithEvents MNUFormacionAltas As System.Windows.Forms.MenuItem
'    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
'        Me.components = New System.ComponentModel.Container
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Principal))
'        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
'        Me.mnuVerDatos = New System.Windows.Forms.MenuItem
'        Me.mnuVerEmpl = New System.Windows.Forms.MenuItem
'        Me.MenuItem1 = New System.Windows.Forms.MenuItem
'        Me.mnuVerHistorico = New System.Windows.Forms.MenuItem
'        Me.mnuDatos = New System.Windows.Forms.MenuItem
'        Me.mnuNewEmpl = New System.Windows.Forms.MenuItem
'        Me.mnuModifEmpl = New System.Windows.Forms.MenuItem
'        Me.MenuItem4 = New System.Windows.Forms.MenuItem
'        Me.MenuBajaEmpleado = New System.Windows.Forms.MenuItem
'        Me.MenuItem5 = New System.Windows.Forms.MenuItem
'        Me.MenuContratos = New System.Windows.Forms.MenuItem
'        Me.MenuNuevoContrato = New System.Windows.Forms.MenuItem
'        Me.MenuRevisionSueldo = New System.Windows.Forms.MenuItem
'        Me.MenuControlContratos = New System.Windows.Forms.MenuItem
'        Me.MnuFiniquitos = New System.Windows.Forms.MenuItem
'        Me.MenuGProyectos = New System.Windows.Forms.MenuItem
'        Me.MenuPorProyecto = New System.Windows.Forms.MenuItem
'        Me.MenuItem2 = New System.Windows.Forms.MenuItem
'        Me.MnuAltaProyecto = New System.Windows.Forms.MenuItem
'        Me.MnuAltaCliente = New System.Windows.Forms.MenuItem
'        Me.MnuConsultas = New System.Windows.Forms.MenuItem
'        Me.mnuConsultasGen = New System.Windows.Forms.MenuItem
'        Me.mnuConsultasFix = New System.Windows.Forms.MenuItem
'        Me.MnuListados = New System.Windows.Forms.MenuItem
'        Me.MnuListadosHoras = New System.Windows.Forms.MenuItem
'        Me.MnuListadoPersona = New System.Windows.Forms.MenuItem
'        Me.MnuListadoProyecto = New System.Windows.Forms.MenuItem
'        Me.MnuListadoFecha = New System.Windows.Forms.MenuItem
'        Me.MnuListadoHistorico = New System.Windows.Forms.MenuItem
'        Me.MnuListadosWeb = New System.Windows.Forms.MenuItem
'        Me.MnuListadoPerWeb = New System.Windows.Forms.MenuItem
'        Me.MnuListadoProWeb = New System.Windows.Forms.MenuItem
'        Me.MnuListadoFechaWeb = New System.Windows.Forms.MenuItem
'        Me.MnuListHistoWEB = New System.Windows.Forms.MenuItem
'        Me.MnuTablaCostes = New System.Windows.Forms.MenuItem
'        Me.MNUFormacionAltas = New System.Windows.Forms.MenuItem
'        Me.MenuAuxiliares = New System.Windows.Forms.MenuItem
'        Me.MnuAuxCalendario = New System.Windows.Forms.MenuItem
'        Me.MnuAuxContratos = New System.Windows.Forms.MenuItem
'        Me.menuAuxCostes = New System.Windows.Forms.MenuItem
'        Me.MnuAuxJornadas = New System.Windows.Forms.MenuItem
'        Me.MnuAuxUbicacion = New System.Windows.Forms.MenuItem
'        Me.MnuAuxCategorias = New System.Windows.Forms.MenuItem
'        Me.MnuAuxCategoriasBoslan = New System.Windows.Forms.MenuItem
'        Me.MnuAuxVariables = New System.Windows.Forms.MenuItem
'        Me.mnuUsuarios = New System.Windows.Forms.MenuItem
'        Me.MnuAuxCuentasCotizacion = New System.Windows.Forms.MenuItem
'        Me.MenuItem8 = New System.Windows.Forms.MenuItem
'        Me.MnuFremap = New System.Windows.Forms.MenuItem
'        Me.MenuItem10 = New System.Windows.Forms.MenuItem
'        Me.MenuFormacionAltas = New System.Windows.Forms.MenuItem
'        Me.MenuItem11 = New System.Windows.Forms.MenuItem
'        Me.MnuSeguroVida = New System.Windows.Forms.MenuItem
'        Me.MnuEstadisticas = New System.Windows.Forms.MenuItem
'        Me.MenuSalir = New System.Windows.Forms.MenuItem
'        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
'        Me.btnSalir = New System.Windows.Forms.Button
'        Me.SuspendLayout()
'        '
'        'MainMenu1
'        '
'        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuVerDatos, Me.mnuDatos, Me.MenuGProyectos, Me.MnuConsultas, Me.MnuListados, Me.MenuAuxiliares, Me.MenuItem8, Me.MnuEstadisticas, Me.MenuSalir})
'        '
'        'mnuVerDatos
'        '
'        Me.mnuVerDatos.Index = 0
'        Me.mnuVerDatos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuVerEmpl, Me.MenuItem1, Me.mnuVerHistorico})
'        Me.mnuVerDatos.Text = "Ver EMPLEADOS                 "
'        '
'        'mnuVerEmpl
'        '
'        Me.mnuVerEmpl.Index = 0
'        Me.mnuVerEmpl.Text = "VER  Datos Empleados"
'        '
'        'MenuItem1
'        '
'        Me.MenuItem1.Index = 1
'        Me.MenuItem1.Text = "-"
'        '
'        'mnuVerHistorico
'        '
'        Me.mnuVerHistorico.Index = 2
'        Me.mnuVerHistorico.Text = "HISTORICO"
'        '
'        'mnuDatos
'        '
'        Me.mnuDatos.Index = 1
'        Me.mnuDatos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewEmpl, Me.mnuModifEmpl, Me.MenuItem4, Me.MenuBajaEmpleado, Me.MenuItem5, Me.MenuContratos, Me.MenuControlContratos, Me.MnuFiniquitos})
'        Me.mnuDatos.Text = "EMPLEADOS          "
'        '
'        'mnuNewEmpl
'        '
'        Me.mnuNewEmpl.Index = 0
'        Me.mnuNewEmpl.Text = "ALTA  Empleado"
'        '
'        'mnuModifEmpl
'        '
'        Me.mnuModifEmpl.Index = 1
'        Me.mnuModifEmpl.Text = "MODIFICAR  Datos Actuales"
'        '
'        'MenuItem4
'        '
'        Me.MenuItem4.Index = 2
'        Me.MenuItem4.Text = "-"
'        '
'        'MenuBajaEmpleado
'        '
'        Me.MenuBajaEmpleado.Index = 3
'        Me.MenuBajaEmpleado.Text = "Pasar Empleado a HISTORICO"
'        '
'        'MenuItem5
'        '
'        Me.MenuItem5.Index = 4
'        Me.MenuItem5.Text = "-"
'        '
'        'MenuContratos
'        '
'        Me.MenuContratos.Index = 5
'        Me.MenuContratos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuNuevoContrato, Me.MenuRevisionSueldo})
'        Me.MenuContratos.Text = "CONTRATOS"
'        '
'        'MenuNuevoContrato
'        '
'        Me.MenuNuevoContrato.Index = 0
'        Me.MenuNuevoContrato.Text = "Nuevo Contrato"
'        '
'        'MenuRevisionSueldo
'        '
'        Me.MenuRevisionSueldo.Index = 1
'        Me.MenuRevisionSueldo.Text = "Revisión Sueldo"
'        '
'        'MenuControlContratos
'        '
'        Me.MenuControlContratos.Index = 6
'        Me.MenuControlContratos.Text = "Control de Contratos"
'        '
'        'MnuFiniquitos
'        '
'        Me.MnuFiniquitos.Index = 7
'        Me.MnuFiniquitos.Text = "Control Finiquitos"
'        '
'        'MenuGProyectos
'        '
'        Me.MenuGProyectos.Index = 2
'        Me.MenuGProyectos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuPorProyecto, Me.MenuItem2, Me.MnuAltaProyecto, Me.MnuAltaCliente})
'        Me.MenuGProyectos.Text = "PROYECTOS        "
'        '
'        'MenuPorProyecto
'        '
'        Me.MenuPorProyecto.Index = 0
'        Me.MenuPorProyecto.Text = "Relacion Proyectos / Empleados"
'        '
'        'MenuItem2
'        '
'        Me.MenuItem2.Index = 1
'        Me.MenuItem2.Text = "-"
'        '
'        'MnuAltaProyecto
'        '
'        Me.MnuAltaProyecto.Index = 2
'        Me.MnuAltaProyecto.Text = "Alta/Modif Proyecto"
'        '
'        'MnuAltaCliente
'        '
'        Me.MnuAltaCliente.Index = 3
'        Me.MnuAltaCliente.Text = "Alta/Modif Cliente"
'        '
'        'MnuConsultas
'        '
'        Me.MnuConsultas.Index = 3
'        Me.MnuConsultas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConsultasGen, Me.mnuConsultasFix})
'        Me.MnuConsultas.Text = "CONSULTAS             "
'        '
'        'mnuConsultasGen
'        '
'        Me.mnuConsultasGen.Index = 0
'        Me.mnuConsultasGen.Text = "Consultas Generales"
'        '
'        'mnuConsultasFix
'        '
'        Me.mnuConsultasFix.Index = 1
'        Me.mnuConsultasFix.Text = "Consultas Específicas"
'        '
'        'MnuListados
'        '
'        Me.MnuListados.Index = 4
'        Me.MnuListados.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuListadosHoras, Me.MnuListadosWeb, Me.MnuTablaCostes, Me.MNUFormacionAltas})
'        Me.MnuListados.Text = "LISTADOS"
'        '
'        'MnuListadosHoras
'        '
'        Me.MnuListadosHoras.Index = 0
'        Me.MnuListadosHoras.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuListadoPersona, Me.MnuListadoProyecto, Me.MnuListadoFecha, Me.MnuListadoHistorico})
'        Me.MnuListadosHoras.Text = "Horas Costes"
'        '
'        'MnuListadoPersona
'        '
'        Me.MnuListadoPersona.Index = 0
'        Me.MnuListadoPersona.Text = "Por Persona"
'        '
'        'MnuListadoProyecto
'        '
'        Me.MnuListadoProyecto.Index = 1
'        Me.MnuListadoProyecto.Text = "Por Proyecto"
'        '
'        'MnuListadoFecha
'        '
'        Me.MnuListadoFecha.Index = 2
'        Me.MnuListadoFecha.Text = "Por Fechas"
'        '
'        'MnuListadoHistorico
'        '
'        Me.MnuListadoHistorico.Index = 3
'        Me.MnuListadoHistorico.Text = "Historico"
'        '
'        'MnuListadosWeb
'        '
'        Me.MnuListadosWeb.Index = 1
'        Me.MnuListadosWeb.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuListadoPerWeb, Me.MnuListadoProWeb, Me.MnuListadoFechaWeb, Me.MnuListHistoWEB})
'        Me.MnuListadosWeb.Text = "Horas Web"
'        '
'        'MnuListadoPerWeb
'        '
'        Me.MnuListadoPerWeb.Index = 0
'        Me.MnuListadoPerWeb.Text = "Por Persona"
'        '
'        'MnuListadoProWeb
'        '
'        Me.MnuListadoProWeb.Index = 1
'        Me.MnuListadoProWeb.Text = "Por Proyecto"
'        '
'        'MnuListadoFechaWeb
'        '
'        Me.MnuListadoFechaWeb.Index = 2
'        Me.MnuListadoFechaWeb.Text = "Por Fechas"
'        '
'        'MnuListHistoWEB
'        '
'        Me.MnuListHistoWEB.Index = 3
'        Me.MnuListHistoWEB.Text = "Historico"
'        '
'        'MnuTablaCostes
'        '
'        Me.MnuTablaCostes.Index = 2
'        Me.MnuTablaCostes.Text = "Exportar Costes"
'        '
'        'MNUFormacionAltas
'        '
'        Me.MNUFormacionAltas.Index = 3
'        Me.MNUFormacionAltas.Text = "Formación Altas"
'        '
'        'MenuAuxiliares
'        '
'        Me.MenuAuxiliares.Index = 5
'        Me.MenuAuxiliares.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuAuxCalendario, Me.MnuAuxContratos, Me.menuAuxCostes, Me.MnuAuxJornadas, Me.MnuAuxUbicacion, Me.MnuAuxCategorias, Me.MnuAuxCategoriasBoslan, Me.MnuAuxVariables, Me.mnuUsuarios, Me.MnuAuxCuentasCotizacion})
'        Me.MenuAuxiliares.Text = "AUXILIARES     "
'        '
'        'MnuAuxCalendario
'        '
'        Me.MnuAuxCalendario.Index = 0
'        Me.MnuAuxCalendario.Text = "Calendarios"
'        '
'        'MnuAuxContratos
'        '
'        Me.MnuAuxContratos.Index = 1
'        Me.MnuAuxContratos.Text = "Contratos"
'        '
'        'menuAuxCostes
'        '
'        Me.menuAuxCostes.Index = 2
'        Me.menuAuxCostes.Text = "Costes Seguridad Social"
'        '
'        'MnuAuxJornadas
'        '
'        Me.MnuAuxJornadas.Index = 3
'        Me.MnuAuxJornadas.Text = "Jornadas"
'        '
'        'MnuAuxUbicacion
'        '
'        Me.MnuAuxUbicacion.Index = 4
'        Me.MnuAuxUbicacion.Text = "Ubicacion"
'        '
'        'MnuAuxCategorias
'        '
'        Me.MnuAuxCategorias.Index = 5
'        Me.MnuAuxCategorias.Text = "Categorias"
'        '
'        'MnuAuxCategoriasBoslan
'        '
'        Me.MnuAuxCategoriasBoslan.Index = 6
'        Me.MnuAuxCategoriasBoslan.Text = "Categorias Boslan"
'        '
'        'MnuAuxVariables
'        '
'        Me.MnuAuxVariables.Index = 7
'        Me.MnuAuxVariables.Text = "Variables"
'        '
'        'mnuUsuarios
'        '
'        Me.mnuUsuarios.Index = 8
'        Me.mnuUsuarios.Text = "Usuarios"
'        '
'        'MnuAuxCuentasCotizacion
'        '
'        Me.MnuAuxCuentasCotizacion.Index = 9
'        Me.MnuAuxCuentasCotizacion.Text = "Cuentas Cotizacion"
'        '
'        'MenuItem8
'        '
'        Me.MenuItem8.Index = 6
'        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFremap, Me.MenuItem10, Me.MenuFormacionAltas, Me.MenuItem11, Me.MnuSeguroVida})
'        Me.MenuItem8.Text = "SALUD      "
'        '
'        'MnuFremap
'        '
'        Me.MnuFremap.Index = 0
'        Me.MnuFremap.Text = "Prevencion"
'        '
'        'MenuItem10
'        '
'        Me.MenuItem10.Index = 1
'        Me.MenuItem10.Text = "-"
'        '
'        'MenuFormacionAltas
'        '
'        Me.MenuFormacionAltas.Index = 2
'        Me.MenuFormacionAltas.Text = "Control Formación Altas"
'        '
'        'MenuItem11
'        '
'        Me.MenuItem11.Index = 3
'        Me.MenuItem11.Text = "-"
'        '
'        'MnuSeguroVida
'        '
'        Me.MnuSeguroVida.Index = 4
'        Me.MnuSeguroVida.Text = "Seguro Vida"
'        '
'        'MnuEstadisticas
'        '
'        Me.MnuEstadisticas.Index = 7
'        Me.MnuEstadisticas.Text = "Estadisticas"
'        '
'        'MenuSalir
'        '
'        Me.MenuSalir.Index = 8
'        Me.MenuSalir.Text = "SALIR"
'        '
'        'ImageList1
'        '
'        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
'        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
'        Me.ImageList1.Images.SetKeyName(0, "group.ico")
'        Me.ImageList1.Images.SetKeyName(1, "EYE.ICO")
'        Me.ImageList1.Images.SetKeyName(2, "{{P00A.ICO")
'        Me.ImageList1.Images.SetKeyName(3, "ANUM04A.ICO")
'        Me.ImageList1.Images.SetKeyName(4, "impres1.ico")
'        '
'        'btnSalir
'        '
'        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
'        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnSalir.Location = New System.Drawing.Point(829, 24)
'        Me.btnSalir.Name = "btnSalir"
'        Me.btnSalir.Size = New System.Drawing.Size(79, 42)
'        Me.btnSalir.TabIndex = 105
'        Me.btnSalir.Text = "SALIR"
'        Me.btnSalir.UseVisualStyleBackColor = False
'        '
'        'Form_Principal
'        '
'        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
'        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
'        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
'        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.ClientSize = New System.Drawing.Size(947, 713)
'        Me.Controls.Add(Me.btnSalir)
'        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
'        Me.IsMdiContainer = True
'        Me.Menu = Me.MainMenu1
'        Me.Name = "Form_Principal"
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'        Me.Text = "PersonaBSE> GESTION del PERSONAL de BSE"
'        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'        Me.ResumeLayout(False)

'    End Sub

'#End Region

'    Private Sub Form_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim formC As New Form_Login

'        ' Nueva versión a partir de la de María Regil (hasta jul/2013)
'        'gAplVers = "v2.0 (30/04/2014)"
'        ' si no tiene contrato, cascaba
'        ' control errores; estadísticas
'        'gAplVers = "v2.0a (07/05/2014)"
'        ' más cambios
'        'gAplVers = "v2.0b (08/05/2014)"
'        ' errores con fechas de baja
'        ' valores privilegios
'        'gAplVers = "v2.0c (09/05/2014)"
'        ' se quita mensaje finiquitos
'        ' altas Proyectos y Clientes, también permiten modificar
'        'gAplVers = "v2.1 (19/05/2014)"
'        ' se quitan iconos en menú principal
'        'gAplVers = "v2.2 (26/01/2015)"
'        ' variables ordenadas por año
'        'gAplVers = "v2.3 (26/01/2016)"
'        ' PureComponents caducado
'        ' reordenar opciones y quitar opciones no usadas
'        'gAplVers = "v2.4 (17/03/2016)"
'        ' ajustes
'        'gAplVers = "v2.5 (29/03/2016)"
'        ' cambio usuario de conexión a BSE
'        'gAplVers = "v2.5a (13/05/2016)"
'        ' cambio usuario de conexión a BSE también en ucContratos
'        'gAplVers = "v2.5b (01/06/2016)"
'        ' se añade campo IBAN
'        'gAplVers = "v2.6 (18/07/2016)"
'        ' cambio proyectos 'B0000x' a 'S0000x'
'        'gAplVers = "v2.7 (20/07/2016)"
'        ' ver usuario en ficha
'        ' no imprime las consultas
'        'gAplVers = "v2.8 (20/02/2017)"
'        'gAplVers = "v2.8 (02/03/2017)"
'        ' botones de acciones más usadas en pantalla
'        'gAplVers = "v2.9 (05/04/2017)"
'        ' repaso direcciones informes
'        'gAplVers = "v3.0 (07/04/2017)"
'        ' cambio nombre tabla DATOS_TRABAJO a EMPLEADOS_DATOS
'        ' no se cambia la reserva de matrícula hasta que se graba el nuevo empleado
'        'gAplVers = "v3.1 (03/05/2017)"
'        ' se cambia aspecto y se reordenan los menús
'        ' se cambia texto de Fecha Alta por Fecha Antiguedad
'        'gAplVers = "v3.2 (29/09/2017)"
'        ' salvado y comprobación fechas de antiguedad
'        'gAplVers = "v3.2a (03/10/2017)"

'        ' conexión a BOSSQL00
'        'gAplVers = "v4.0 (13/11/2017)"
'        ' gPrivMin=1 para ejecutar Agustín
'        'gAplVers = "v4.0a (27/11/2017)"
'        gAplVers = "v5.0a (18/01/2018) - Versión Prácticas"

'        gAplNam = "PersonBSE> "
'        gAplDisk = "C:\"

'        'gUsuario = NombreUsuario()
'        gUsuario = Environ("Username")
'        gOrdenador = Environ("Computername")
'        gPriv = -1
'        gLogin = ""
'        gPrivMin = 1
'        gPrivMod = 3
'        gPrivMax = 5

'        'gNamBD = "personal_webSQL"
'        'gUsrBD = "usuario_bos"
'        'gPwdBD = "boslan_personal"
'        'dbconexion = New SqlClient.SqlConnection("packet size=4096;user id=usuario_bos;password=boslan_personal;Data Source=LAN108;Initial Catalog=personal_webSQL;persist security info=False")

'        'gNamBD = "BSE_Personal"
'        'gUsrBD = "usuario_BSE"
'        'gPwdBD = "usuario3web"
'        'gSrvBD = "LAN108"
'        gNamBD = "PersonBSE"
'        'gUsrBD = "pantxo"
'        'gPwdBD = "6999495F2F4F401E6C9247"
'        gUsrBD = "sa"
'        gPwdBD = "Pa$$w0rd"
'        gSrvBD = "LAN265\SQLEXPRESS"
'        gAplDir = gAplDisk + "Users\agrijalbaf\Documents\Angel\BSE\"
'        gAplRpt = gAplDir + "Informes\"
'        gAplFot = gAplDir + "Fotos\"
'        gAplCV = gAplDir + "CVs\"
'        gAplCto = "CTOS\"
'        gAplDat = gAplDisk + "Datos a Enviar\"

'        gConexion = "packet size=4096;user id=" + gUsrBD + ";password=" + gPwdBD + ";Data Source=" + gSrvBD + ";Initial Catalog=" + gNamBD + ";persist security info=False"
'        dbConexion = New SqlClient.SqlConnection(gConexion)

'        formC.ShowDialog()
'        If gUsuario = "" Or gLogin = "" Then End

'        gPriv = NivelUsuario(LCase(gUsuario))
'        If gPriv < gPrivMin Then
'            MsgBox("NO TIENE AUTORIZACION PARA USAR ESTE PROGRAMA", MsgBoxStyle.Critical, "AVISO")
'            End
'        End If

'        Me.Text = Me.Text & "  -  " & gAplVers
'    End Sub

'    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
'        Me.Close()
'    End Sub

'    Private Sub MenuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSalir.Click
'        Me.Close()
'    End Sub


'    Private Sub MenuNuevoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNuevoContrato.Click
'        Dim form1 As New Form_Empleados
'        'Dim davariables As SqlClient.SqlDataAdapter
'        'Dim dsvariables As Data.DataSet

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

'        'Abrimos un hijo
'        form1.MdiParent = Me
'        gSeleccion = "TODOS"
'        form1.btnSeleccion.Enabled = False
'        form1.btnSeleccion.Visible = False
'        form1.btnGuardarModif.Enabled = False
'        form1.btnGuardarModif.Visible = False
'        form1.btnEmpleadoNuevo.Enabled = False
'        form1.btnEmpleadoNuevo.Visible = False
'        form1.btnAñadirSueldo.Enabled = False
'        form1.btnAñadirSueldo.Visible = False
'        form1.btnAltaContratoySueldo.Enabled = False
'        form1.btnAltaContratoySueldo.Visible = False
'        form1.btnPasarHistorico.Enabled = False
'        form1.btnPasarHistorico.Visible = False
'        form1.btnVerDatos.Enabled = False
'        form1.btnVerDatos.Visible = False
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'        form1.Text = "  NUEVO  CONTRATO "
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub mnuModifEmpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModifEmpl.Click
'        Dim form1 As New Form_Empleados

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        gSeleccion = "TODOS"
'        form1.btnSeleccion.Enabled = True
'        form1.btnSeleccion.Visible = True
'        form1.btnEmpleadoNuevo.Enabled = False
'        form1.btnEmpleadoNuevo.Visible = False
'        form1.btnAñadirContrato.Enabled = False
'        form1.btnAñadirContrato.Visible = False
'        form1.btnAñadirSueldo.Enabled = False
'        form1.btnAñadirSueldo.Visible = False
'        form1.btnAltaContratoySueldo.Enabled = False
'        form1.btnAltaContratoySueldo.Visible = False
'        form1.btnPasarHistorico.Enabled = False
'        form1.btnPasarHistorico.Visible = False
'        form1.btnVerDatos.Enabled = False
'        form1.btnVerDatos.Visible = False
'        form1.btnFichaAlta.Enabled = True
'        form1.btnFichaAlta.Visible = True
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.ShowDialog()
'        form1.Text = "  MODIFICAR  DATOS "
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub mnuNewEmpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewEmpl.Click
'        Dim form1 As New Form_Empleados

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        'Abrimos un hijo
'        form1.MdiParent = Me
'        gSeleccion = "TODOS"
'        form1.btnSeleccion.Enabled = False
'        form1.btnSeleccion.Visible = False
'        form1.btnGuardarModif.Enabled = False
'        form1.btnGuardarModif.Visible = False
'        form1.lblempleado.Visible = False
'        form1.txtMat.Visible = False
'        form1.ComboEmpleado.Enabled = False
'        form1.ComboEmpleado.Visible = False
'        form1.btnAñadirContrato.Enabled = False
'        form1.btnAñadirContrato.Visible = False
'        form1.btnAñadirSueldo.Enabled = False
'        form1.btnAñadirSueldo.Visible = False
'        form1.btnAltaContratoySueldo.Enabled = False
'        form1.btnAltaContratoySueldo.Visible = False
'        form1.txtmatric.Enabled = True
'        form1.btnPasarHistorico.Enabled = False
'        form1.btnPasarHistorico.Visible = False
'        form1.btnVerDatos.Enabled = False
'        form1.btnVerDatos.Visible = False
'        form1.btnFichaAlta.Enabled = False
'        form1.btnFichaAlta.Visible = False
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.TabPage2.Enabled = False
'        form1.TabPage3.Enabled = False
'        form1.TabPage3.Visible = False
'        form1.TabPage2.Visible = False
'        form1.Show()
'        form1.Text = "  ALTA  EMPLEADO"
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MenuRevisionSueldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRevisionSueldo.Click
'        Dim form1 As New Form_Empleados

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        'Abrimos un hijo
'        form1.MdiParent = Me
'        gSeleccion = "TODOS"
'        form1.btnSeleccion.Enabled = False
'        form1.btnSeleccion.Visible = False
'        form1.btnGuardarModif.Enabled = False
'        form1.btnGuardarModif.Visible = False
'        form1.btnEmpleadoNuevo.Enabled = False
'        form1.btnEmpleadoNuevo.Visible = False
'        form1.btnAñadirContrato.Enabled = False
'        form1.btnAñadirContrato.Visible = False
'        form1.btnAltaContratoySueldo.Enabled = False
'        form1.btnAltaContratoySueldo.Visible = False
'        form1.btnPasarHistorico.Enabled = False
'        form1.btnPasarHistorico.Visible = False
'        form1.btnVerDatos.Enabled = False
'        form1.btnVerDatos.Visible = False
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'        form1.Text = "  REVISION  SUELDO "
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub mnuVerHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerHistorico.Click
'        Dim form1 As New Form_Empleados_Hist

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        tipo_empleado = "historico"
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MenuBajaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBajaEmpleado.Click
'        Dim form1 As New Form_Empleados

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        'Abrimos un hijo
'        form1.MdiParent = Me
'        gSeleccion = "TODOS"
'        form1.btnSeleccion.Enabled = False
'        form1.btnSeleccion.Visible = False
'        form1.btnGuardarModif.Enabled = False
'        form1.btnGuardarModif.Visible = False
'        form1.btnEmpleadoNuevo.Enabled = False
'        form1.btnEmpleadoNuevo.Visible = False
'        form1.btnAñadirContrato.Enabled = False
'        form1.btnAñadirContrato.Visible = False
'        form1.btnAñadirSueldo.Enabled = False
'        form1.btnAñadirSueldo.Visible = False
'        form1.btnAltaContratoySueldo.Enabled = False
'        form1.btnAltaContratoySueldo.Visible = False
'        form1.btnVerDatos.Enabled = False
'        form1.btnVerDatos.Visible = False
'        form1.btnFichaAlta.Enabled = True
'        form1.btnFichaAlta.Visible = True
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'        form1.Text = "  BAJA  EMPLEADO "
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MenuConsultarHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim form1 As New Form_BorraHist

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MenuVerDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerEmpl.Click
'        Dim form1 As New Form_Empleados_Hist

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        tipo_empleado = "actual"
'        form1.Show()
'        form1.Text = "  VER  DATOS  EMPLEADO "
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MenuPorProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPorProyecto.Click
'        Dim form1 As New Form_proyectos_empleados

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        'Abrimos un hijo
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.TabControl1.SelectedIndex = 0
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuAltaProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAltaProyecto.Click
'        Dim form1 As New Form_Proyectos

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuAuxCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxCalendario.Click
'        Dim form1 As New Form_AuxCalendario

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuAuxContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxContratos.Click
'        Dim form1 As New Form_AuxContratos

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuAuxJornadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxJornadas.Click
'        Dim form1 As New Form_AuxJornadas

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuAuxUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxUbicacion.Click
'        Dim form1 As New Form_AuxUbicacion

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuAuxVariables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxVariables.Click
'        Dim form1 As New Form_AuxVariables

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuAuxCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxCategorias.Click
'        Dim form1 As New Form_AuxCategorias

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuAuxCategoriasBoslan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxCategoriasBoslan.Click
'        Dim form1 As New Form_AuxCategBoslan

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub


'    Private Sub MnuListadoPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoPersona.Click
'        Dim form1 As New Form_Elegir_Empleado

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = False
'        form1.lblproyecto.Visible = False
'        form1.cmbproyectos.Visible = False
'        form1.btnPorpersona.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuListadoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoProyecto.Click
'        Dim form1 As New Form_Elegir_Empleado

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = False
'        form1.lblempleado.Visible = False
'        form1.CmbEmpleado.Visible = False
'        form1.btnPorproyecto.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuListadoFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoFecha.Click
'        Dim form1 As New Form_Elegir_Empleado

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = False
'        form1.lblempleado.Visible = False
'        form1.CmbEmpleado.Visible = False
'        form1.lblproyecto.Visible = False
'        form1.cmbproyectos.Visible = False
'        form1.btnCompleto.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuEstadisticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEstadisticas.Click
'        Dim form1 As New Form_Estadisticas

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuFremap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFremap.Click
'        Dim form1 As New Form_MC_prevencion

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuSeguroVida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSeguroVida.Click
'        Dim form1 As New Form_seguro_vida

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MenuControlContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuControlContratos.Click
'        Dim form1 As New Form_Control_Contratos

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuFiniquitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFiniquitos.Click
'        Dim form1 As New Form_Control_Contratos

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Label1.Text = "Fecha fin contrato"
'        form1.Label3.Visible = False
'        form1.txtenviadofirma.Visible = False
'        form1.Button3.Visible = False
'        form1.Label4.Visible = False
'        form1.txtrecibidobilbao.Visible = False
'        form1.Button4.Visible = False
'        form1.chcontrolar.Visible = False
'        form1.Show()
'    End Sub

'    Private Sub mnuConsultasFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultasFix.Click
'        Dim form1 As New Form_inicio_consultas

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub mnuConsultasGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultasGen.Click
'        Dim form1 As New Form_Consultas_Generales

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuListadoPerWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoPerWeb.Click
'        Dim form1 As New Form_Elegir_Emp_Web

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = False
'        form1.lblproyecto.Visible = False
'        form1.cmbproyectos.Visible = False
'        form1.btnPorpersona.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuListadoProWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoProWeb.Click
'        Dim form1 As New Form_Elegir_Emp_Web

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = False
'        form1.lblempleado.Visible = False
'        form1.CmbEmpleado.Visible = False
'        form1.btnPorproyecto.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuListadoFechaWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoFechaWeb.Click
'        Dim form1 As New Form_Elegir_Emp_Web

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.lblempleado.Visible = False
'        form1.CmbEmpleado.Visible = False
'        form1.chkhistorico.Visible = False
'        form1.lblproyecto.Visible = False
'        form1.cmbproyectos.Visible = False
'        form1.btnCompleto.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuAltaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAltaCliente.Click
'        Dim form1 As New Form_Clientes

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuListadoHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListadoHistorico.Click
'        Dim form1 As New Form_Elegir_Empleado

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = True
'        form1.chkhistorico.Checked = True
'        form1.lblproyecto.Visible = False
'        form1.cmbproyectos.Visible = False
'        form1.btnPorpersona.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub MnuListHistoWEB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuListHistoWEB.Click
'        Dim form1 As New Form_Elegir_Emp_Web

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.chkhistorico.Visible = True
'        form1.chkhistorico.Checked = True
'        form1.lblproyecto.Visible = False
'        form1.cmbproyectos.Visible = False
'        form1.btnPorpersona.BackColor = Color.Red
'        form1.Show()
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub mnuUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUsuarios.Click
'        Dim form1 As New Form_Usuarios

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MnuTablaCostes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuTablaCostes.Click
'        Dim form1 As New Form_MesAño
'        Dim dstablacostos As Data.DataSet
'        Dim datablacostos As SqlClient.SqlDataAdapter
'        Dim mesnum As String, fichero As String
'        Dim fechaini, fechafin As String
'        Dim añoselec, diasmes As String
'        Dim k As Integer
'        'Dim dr As Data.DataRow

'        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'        dstablacostos = New Data.DataSet

'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.ShowDialog()

'        If Mes = "" And Año = 0 Then
'            MsgBox("¿ NO TE DECIDES, MAJO/A ?")
'            Me.Cursor = System.Windows.Forms.Cursors.Default
'            Exit Sub
'        End If

'        mesnum = NumMes
'        diasmes = Date.DaysInMonth(Año, NumMes)

'        añoselec = Año.ToString
'        fechaini = añoselec + "/" + mesnum + "/01"
'        fechafin = añoselec + "/" + mesnum + "/" + diasmes

'        'Procedure
'        datablacostos = New SqlClient.SqlDataAdapter
'        Dim cmdCommand As New SqlClient.SqlCommand
'        datablacostos.SelectCommand = cmdCommand
'        datablacostos.SelectCommand.Connection = dbConexion
'        datablacostos.SelectCommand.CommandType = CommandType.StoredProcedure
'        datablacostos.SelectCommand.CommandText = "Consulta_Empleados_por_proyecto_" & añoselec

'        Dim miParam1 As New SqlClient.SqlParameter("@pfechaini", SqlDbType.DateTime)
'        datablacostos.SelectCommand.Parameters.Add(miParam1)
'        datablacostos.SelectCommand.Parameters("@pfechaini").Value = CDate(fechaini)
'        Dim miParam2 As New SqlClient.SqlParameter("@pfechafin", SqlDbType.DateTime)
'        datablacostos.SelectCommand.Parameters.Add(miParam2)
'        datablacostos.SelectCommand.Parameters("@pfechafin").Value = CDate(fechafin)

'        datablacostos.Fill(dstablacostos, "TABLA_COSTOS")
'        k = dstablacostos.Tables(0).Rows.Count
'        If k = 0 Then
'            Me.Cursor = System.Windows.Forms.Cursors.Default
'            MsgBox("NO TENEMOS DATOS. ¡ TE HAS DESPISTAO !")
'            Exit Sub
'        End If

'        'dstablacostos.WriteXml("N:\NUEVO_PERSONAL\datos a enviar\lis_costos_" & añoselec.ToString & "_" & mesnum.ToString & ".xml")
'        fichero = gAplDat & "lis_costos_" & añoselec.ToString & "_" & mesnum.ToString & ".xml"
'        dstablacostos.WriteXml(fichero)
'        MsgBox("Generado Fichero " + fichero)
'        Me.Cursor = System.Windows.Forms.Cursors.Default
'    End Sub

'    Private Sub menuAuxCostes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAuxCostes.Click
'        Dim form1 As New Form_AuxCosteSS

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MenuFormacionAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFormacionAltas.Click
'        Dim form1 As New Form_FormacionAltas

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'    Private Sub MNUFormacionAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUFormacionAltas.Click
'        Dim form2 As New Form_Listado_DataSet
'        'Dim mselect As String
'        Dim danuevos As SqlClient.SqlDataAdapter
'        Dim dsempleadosnuevos As New Data.DataSet
'        Dim form1 As New Form_MesAño
'        Dim dsdatohoras As Data.DataSet
'        'Dim datohoras As SqlClient.SqlDataAdapter
'        Dim k, horas As Integer

'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.lblmes.Visible = False
'        form1.ComboMes.Visible = False
'        form1.ShowDialog()

'        dsdatohoras = New Data.DataSet
'        horas = HorasOficiales(Año)
'        'Procedure
'        danuevos = New SqlClient.SqlDataAdapter
'        Dim cmdCommand As New SqlClient.SqlCommand
'        danuevos.SelectCommand = cmdCommand
'        danuevos.SelectCommand.Connection = dbConexion
'        danuevos.SelectCommand.CommandType = CommandType.StoredProcedure
'        danuevos.SelectCommand.CommandText = "Formacion_Altas_" & Año.ToString

'        Dim miParam1 As New SqlClient.SqlParameter("@phoras", SqlDbType.SmallInt)
'        danuevos.SelectCommand.Parameters.Add(miParam1)
'        danuevos.SelectCommand.Parameters("@phoras").Value = horas
'        danuevos.Fill(dsempleadosnuevos, "FORMACION_ALTAS")

'        k = dsempleadosnuevos.Tables(0).Rows.Count
'        If k = 0 Then
'            MsgBox("NO TENEMOS DATOS. ¡ TE HAS DESPISTAO !")
'            Exit Sub
'        End If
'        'dsempleadosnuevos.WriteXmlSchema("N:\NUEVO_PERSONAL\bin\informes\lis_formacionaltas.xsd")
'        'tipo_listado = "N:\NUEVO_PERSONAL\bin\informes\Lis_formacion_altas3.rpt"
'        tipo_listado = gAplRpt & "Lis_formacion_altas3.rpt"

'        Dim milistado As New ReportDocument
'        milistado.Load(tipo_listado)
'        milistado.SetDataSource(dsempleadosnuevos)

'        form2.Location = New Point(0, 0)
'        form2.StartPosition = FormStartPosition.CenterScreen
'        form2.CRVWlistadodataset.ReportSource = milistado
'        form2.Show()
'    End Sub

'    Private Sub MnuAuxCuentasCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAuxCuentasCotizacion.Click
'        Dim form1 As New Form_AuxCuentasCotiza

'        form1.MdiParent = Me
'        form1.Location = New Point(0, 0)
'        form1.StartPosition = FormStartPosition.CenterScreen
'        form1.Show()
'    End Sub

'End Class
