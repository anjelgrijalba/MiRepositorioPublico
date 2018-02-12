Public Class FormPrincipalConejos
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub


    ' Versión y Fecha de la Aplicación
    Public aplnam As String, aplver As String, apldate As String
    Public aplfcol As Double, aplbcol As Double, aplmsg As String
    Public diskprj As String, dirapl As String, dirdat As String, dirloa As String, dirgen As String
    Public dirusr As String, dirlis As String

    ' Versión y Fecha del Programa
    Public pronam As String, newver As String, fechacon As Date
    ' quién y dónde
    Public username As String, userpc As String
    ' servidor, BD, usuario, contraseña
    Public srvBD As String, namBD As String, usrBD As String, pwdBD As String
    Public srvBDAux As String, namBDAux As String, usrBDAux As String, pwdBDAux As String
    ' marcadores
    Public oFin As Boolean, oDebug As Boolean

    ' Base Datos para acceso a datos
    ' Public dbHoras As New ADODb.Connection
    Dim dbHoras As New ADODB.Connection
    'Dim dbAux As New ADODB.Connection
    'He añadido referencia a biblioteca Microsoft ActiveX Data Objects 6 

    Dim dia As String
    Dim mes As String
    Dim año As String

    Private Sub InitializeComponent()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHoras = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(645, 201)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 0
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHoras, Me.VacacionesToolStripMenuItem, Me.GastosToolStripMenuItem, Me.ToolStripSeparator1, Me.GruposToolStripMenuItem, Me.ToolStripSeparator2, Me.HorasWebToolStripMenuItem, Me.VacacionesWebToolStripMenuItem, Me.GastosWebToolStripMenuItem})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'mnuHoras
        '
        Me.mnuHoras.Name = "mnuHoras"
        Me.mnuHoras.Size = New System.Drawing.Size(159, 22)
        Me.mnuHoras.Text = "Horas"
        '
        'VacacionesToolStripMenuItem
        '
        Me.VacacionesToolStripMenuItem.Name = "VacacionesToolStripMenuItem"
        Me.VacacionesToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VacacionesToolStripMenuItem.Text = "Vacaciones"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'HorasWebToolStripMenuItem
        '
        Me.HorasWebToolStripMenuItem.Name = "HorasWebToolStripMenuItem"
        Me.HorasWebToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HorasWebToolStripMenuItem.Text = "Horas Web"
        '
        'VacacionesWebToolStripMenuItem
        '
        Me.VacacionesWebToolStripMenuItem.Name = "VacacionesWebToolStripMenuItem"
        Me.VacacionesWebToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VacacionesWebToolStripMenuItem.Text = "Vacaciones Web"
        '
        'GastosWebToolStripMenuItem
        '
        Me.GastosWebToolStripMenuItem.Name = "GastosWebToolStripMenuItem"
        Me.GastosWebToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GastosWebToolStripMenuItem.Text = "Gastos Web"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(156, 6)
        '
        'FormPrincipalConejos
        '
        Me.ClientSize = New System.Drawing.Size(794, 446)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormPrincipalConejos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHoras As ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VacacionesWebToolStripMenuItem As ToolStripMenuItem

    Private Sub mnuHoras_Click(sender As Object, e As EventArgs) Handles mnuHoras.Click
        'Dim Mensaje = ""
        'sPER = "P_"
        EMPHORAS.Show()
    End Sub

    Friend WithEvents GastosWebToolStripMenuItem As ToolStripMenuItem
    Dim fini As Date

    'Dim sConAux As String
    Dim sCon As String

    Private Sub Menu1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Dim gReloj = 0
    Dim gRelojMax = 30

    Public Caption As String
    Dim lintext As String

    Dim gUser As String

    Private Sub FormPrincipalLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim formC As New Form_Login
        '
        'name:      MENU
        'descr:     menú principal de la aplicación
        'author:    pantxo
        'date:      may/14
        '
        Dim gModulo = "MENU>"
        Dim pronam = gModulo

        aplnam = "PersonBSE> "

        Dim aplver = "V5.0" : Dim apldate = "(2018/Enero/22)" : Dim aplfcol = "vbWhite" : Dim aplbcol = "vbDarkGreen"

        On Error GoTo 0
        Dim aplmsg = aplnam + " " + aplver + " " + apldate
        Caption = Caption + " " + aplmsg

        Dim gFecha As DateTime = DateTime.Today

        'gUsuario = NombreUsuario()
        gUsuario = Environ("Username")
        gOrdenador = Environ("Computername")
        gPriv = -1
        gLogin = ""
        gPrivMin = 1
        gPrivMod = 3
        gPrivMax = 5

        gNamBD = "PersonBSE"
        'gUsrBD = "pantxo"
        'gPwdBD = "6999495F2F4F401E6C9247"
        gUsrBD = "sa"
        gPwdBD = "Pa$$w0rd"
        gSrvBD = "LAN309\SQLEXPRESS"
        gAplDir = gAplDisk + "Users\Osanchezs\Desktop\Oihane\BSE\"
        gAplRpt = gAplDir + "Informes\"
        gAplFot = gAplDir + "Fotos\"
        gAplCV = gAplDir + "CVs\"
        gAplCto = "CTOS\"
        gAplDat = gAplDisk + "Datos a Enviar\"

        gConexion = "packet size=4096;user id=" + gUsrBD + ";password=" + gPwdBD + ";Data Source=" + gSrvBD + ";Initial Catalog=" + gNamBD + ";persist security info=False"
        dbConexion = New SqlClient.SqlConnection(gConexion)

        formC.ShowDialog()
        gPriv = NivelUsuario(LCase(gUsuario))
        If gPriv < gPrivMin Then
            MsgBox("NO TIENE AUTORIZACION PARA USAR ESTE PROGRAMA", MsgBoxStyle.Critical, "AVISO")
            End
        End If
        Me.Text = Me.Text & "  -  " & gAplVers
    End Sub

    Private Sub Form_Unload(Cancel As Integer)
        dbHoras.Close()
    End Sub

    Public Sub ValoresIniciales()
        Dim rsA As New ADODB.Recordset
        Dim sSql As String
        Dim ierr As Integer
        Dim sCal As String

        On Error GoTo 0
        ierr = 0

        Dim gMediaDieta = 0#

        sSql = "select * from ATRIBUTOS where CODIGO='MONEDA'"
        rsA.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsA.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
        If rsA.RecordCount = 0 Then
            MsgBox("No se encuentra el ATRIBUTO 'MONEDA' ")
            ierr = 1
        End If
        Dim gMoneda = rsA(1)
        Dim gMonedaDes = rsA(3)
        rsA.Close()

        sSql = "select * from ATRIBUTOS where CODIGO='CAMBIO'"
        rsA.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsA.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
        If rsA.RecordCount = 0 Then
            MsgBox("No se encuentra el ATRIBUTO 'CAMBIO' ")
            ierr = 1
        End If
        'Dim gCambioEUR = PuntoPorComa(rsA(2))
        rsA.Close()

        sSql = "select * from ATRIBUTOS where CODIGO='HORA_EXTRA'"
        rsA.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsA.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
        If rsA.RecordCount = 0 Then
            MsgBox("No se encuentra el ATRIBUTO 'HORA_EXTRA' ")
            ierr = 1
        Else
            'gPrecioHE = PuntoPorComa(rsA(2))
            'MsgBox "Precio Hora Extra : " + CStr(gPrecioHE) + gMoneda
        End If
        rsA.Close()

        If ierr = 1 Then
            MsgBox("NO SE PUEDE CONTINUAR")
            End
        End If
    End Sub

    Private Sub mnuSalir_Click()
        Me.Close()
    End Sub












    'Private Sub mnuHoras_Click()
    '    Dim Mensaje = ""
    '    Dim sPER = "P_"
    '    'EMPHORAS.Show()
    'End Sub

    '    Private Sub bHoras_Click()
    '        Mensaje = ""
    '        sPER = ""
    '        EMPHORAS.Show
    '    End Sub

    '    Private Sub mnuHorasweb_Click()
    '        Mensaje ""
    '    sPER = ""
    '        EMPHORAS.Show
    '    End Sub

    '    Private Sub mnuGrupos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        EMPGRUPO.Show
    '    End Sub

    '    Private Sub bGrupos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        EMPGRUPO.Show
    '    End Sub

    '    Private Sub mnuVacas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        EMPVACAS.Show
    '    End Sub

    '    Private Sub bVacas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        EMPVACAS.Show
    '    End Sub

    '    Private Sub mnuVacasWeb_Click()
    '        Mensaje ""
    '    sPER = ""
    '        EMPVACAS.Show
    '    End Sub

    '    Private Sub mnuGastos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        EMPGASTOS.Show
    '    End Sub

    '    Private Sub bGastos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        EMPGASTOS.Show
    '    End Sub

    '    Private Sub mnuGastosWeb_Click()
    '        Mensaje ""
    '    sPER = ""
    '        EMPGASTOS.Show
    '    End Sub

    '    Private Sub mnuLisGastos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        gAño = Year(Now)
    '        gMes = Month(Now)

    '        SELAÑO.Show vbModal
    '    If bCancelAño Then Exit Sub

    '        LISGASTOS.Show
    '    End Sub

    '    Private Sub bLisGastos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        gAño = Year(Now)
    '        gMes = Month(Now)

    '        SELAÑO.Show vbModal
    '    If bCancelAño Then Exit Sub

    '        LISGASTOS.Show
    '    End Sub

    '    Private Sub mnuCtlGastos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        gAño = Year(Now)
    '        gMes = Month(Now)

    '        SELAÑO.Show vbModal
    '    If bCancelAño Then Exit Sub

    '        LISGASTSH.Show
    '    End Sub

    '    Private Sub bCtlGastos_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        gAño = Year(Now)
    '        gMes = Month(Now)

    '        SELAÑO.Show vbModal
    '    If bCancelAño Then Exit Sub

    '        LISGASTSH.Show
    '    End Sub

    '    Private Sub mnuLisPerson_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        LISPERSON.Show
    '    End Sub

    '    Private Sub bLisPerson_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        LISPERSON.Show
    '    End Sub

    '    Private Sub mnuCtlVacas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLVACAS.Show
    '    End Sub

    '    Private Sub bCtlVacas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLVACAS.Show
    '    End Sub

    '    Private Sub mnuCtlEnero_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLENERO.Show
    '    End Sub

    '    Private Sub bVEnero_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLENERO.Show
    '    End Sub

    '    Private Sub mnuCtlHWeb_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLWEB.T_DATOS = "W"
    '        CTLWEB.Show
    '    End Sub

    '    Private Sub bCtlHWeb_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLWEB.T_DATOS = "W"
    '        CTLWEB.Show
    '    End Sub

    '    Private Sub mnuCtlHPers_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLWEB.T_DATOS = "P"
    '        CTLWEB.Show
    '    End Sub

    '    Private Sub bCtlHPers_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        CTLWEB.T_DATOS = "P"
    '        CTLWEB.Show
    '    End Sub

    '    Private Sub mnuNominas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        GENNOMINA.Show
    '    End Sub

    '    Private Sub bNominas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        GENNOMINA.Show
    '    End Sub

    '    Private Sub mnuLisNomina_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        gAño = Year(Now)
    '        gMes = Month(Now)

    '        SELAÑO.Show vbModal
    '    If bCancelAño Then Exit Sub

    '        LISNOMCOM.Show
    '    End Sub

    '    Private Sub bLisNomina_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        gAño = Year(Now)
    '        gMes = Month(Now)

    '        SELAÑO.Show vbModal
    '    If bCancelAño Then Exit Sub

    '        LISNOMCOM.Show
    '    End Sub

    '    Private Sub bCargaNom_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        LOANOMINA.Show
    '    End Sub

    '    Private Sub mnuCargaNom_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        LOANOMINA.Show
    '    End Sub

    '    Private Sub mnuCalendas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        GENCALEND.Show vbModal
    'End Sub

    '    Private Sub bCalendas_Click()
    '        Mensaje ""
    '    sPER = "P_"
    '        GENCALEND.Show vbModal
    'End Sub


    Private Sub Timer1_Timer()
        gReloj = gReloj + 1
        If gReloj > gRelojMax Then
            'APLABO.Show
        End If
    End Sub



    'Dim usuario As String

    Private Sub FormLogin_Load()
        '
        'name:      APLLOG
        'descr:     login en la aplicación
        'author:    pantxo
        'date:      may/14
        '
        gModulo = "APLLOG>"
        'Dim pronam = gModulo
        '    MENU.newver = "v1.0 (2014/05/02)"
        ' se pone versión aplicación
        Dim newver = "v2 (2018/01/23)"

        Dim gReloj = 0
        Dim Caption = aplnam + ">> " + aplver + " " + apldate
        usuario = gUser
        'txtUsuario.value.text = gUser
    End Sub

    Private Sub bSalir_Click()
        usuario = ""
        gPriv = -1
        End
    End Sub

    Private Sub bOK_Click()
        Dim kk As String, cc As String

        'usuario = txtUsuario.text
        usuario = gUser


        Me.Close()

    End Sub

    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator


    'TODO: NO SABEMOS POR QUÉ HACE ESTO DE SACAR LAS CONTRASEÑAQS Y EL NIVEL
    'Private Function Contraseña(sUsu As String) As String
    '    Dim rsA As New ADODB.Recordset
    '    Dim sSql As String, nivel As Integer

    '    sSql = "select CONTRASEÑA, NIVEL from USUARIOS where NOMBRE='" & sUsu & "'"
    '    rsA.CursorLocation = adUseClient
    '    rsA.Open(sSql, dbHoras, adOpenStatic, adLockReadOnly)
    '    If rsA.RecordCount <> 0 Then
    '        Contraseña = rsA(0)
    '        nivel = rsA(1)
    '        gPriv = nivel
    '    Else
    '        Contraseña = ""
    '        gPriv = 0
    '    End If
    '    rsA.Close()
    'End Function










End Class