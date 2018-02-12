'Public Class FormPrincipal
'    Inherits System.Windows.Forms.Form



'    ' Versión y Fecha de la Aplicación
'    Public aplnam As String, aplver As String, apldate As String
'    Public aplfcol As Double, aplbcol As Double, aplmsg As String
'    Public diskprj As String, dirapl As String, dirdat As String, dirloa As String, dirgen As String
'    Public dirusr As String, dirlis As String

'    ' Versión y Fecha del Programa
'    Public pronam As String, newver As String, fechacon As Date
'    ' quién y dónde
'    Public username As String, userpc As String
'    ' servidor, BD, usuario, contraseña
'    Public srvBD As String, namBD As String, usrBD As String, pwdBD As String
'    Public srvBDAux As String, namBDAux As String, usrBDAux As String, pwdBDAux As String
'    ' marcadores
'    Public oFin As Boolean, oDebug As Boolean

'    ' Base Datos para acceso a datos
'    ' Public dbHoras As New ADODb.Connection
'    Dim dbHoras As New ADODB.Connection
'    'Dim dbAux As New ADODB.Connection
'    'He añadido referencia a biblioteca Microsoft ActiveX Data Objects 6 

'    Dim dia As String
'    Dim mes As String
'    Dim año As String
'    Dim fini As Date

'    'Dim sConAux As String
'    Dim sCon As String

'    Dim gReloj = 0
'    Dim gRelojMax = 30

'    Public Caption As String
'    Dim lintext As String

'    Dim gUser As String

'    Private Sub FormPrincipalLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim formC As New Form_Login
'        '
'        'name:      MENU
'        'descr:     menú principal de la aplicación
'        'author:    pantxo
'        'date:      may/14
'        '
'        Dim gModulo = "MENU>"
'        Dim pronam = gModulo

'        Dim aplnam = "EmpleaBSE> "
'        ' se quita formulario MDI de inicio
'        '    MENU.aplver = "V2.0.0": MENU.apldate = "(2014/05/02)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' retoques
'        '    MENU.aplver = "V2.0.0": MENU.apldate = "(2014/05/05)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' retoques
'        '    MENU.aplver = "V2.0.1": MENU.apldate = "(2014/05/07)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' error en arreglar vacaciones
'        '    MENU.aplver = "V2.1": MENU.apldate = "(2015/01/15)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' mismo aspecto que BOS, BMX, BTP
'        ' se quita ver Versión del Menú Principal
'        '    MENU.aplver = "V2.2": MENU.apldate = "(2015/01/21)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' en windows 8 se pierden algunos colores de fondo
'        '    MENU.aplver = "V2.2a": MENU.apldate = "(2015/05/18)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' control BdD web y personal
'        '    MENU.aplver = "V3.0": MENU.apldate = "(2015/05/19)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' cálculo de costes no funcionaba bien
'        '    MENU.aplver = "V3.1": MENU.apldate = "(2015/05/21)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' cambio usuario conexión a BSE
'        '    MENU.aplver = "V3.1a": MENU.apldate = "(2016/05/13)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' cambio proyectos 'B0000x' a 'S0000x'
'        '    MENU.aplver = "V3.2": MENU.apldate = "(2016/07/20)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' se apagan opciones dudosas o que son peligrosas en Control Vacaciones
'        '    MENU.aplver = "V3.3": MENU.apldate = "(2017/01/02)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' descarga de nóminas
'        '    MENU.aplver = "V3.4": MENU.apldate = "(2017/03/03)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        ' cálculo de costes sólo para Administradores
'        '    MENU.aplver = "V3.5": MENU.apldate = "(2017/05/03)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen

'        ' conexión a BOSSQL00; se quita conexión BdD auxiliar de BOSLAN
'        '    MENU.aplver = "V4.0": MENU.apldate = "(2017/11/13)": MENU.aplfcol = vbWhite: MENU.aplbcol = vbDarkGreen
'        'MENU.aplver = "V4.0a" : MENU.apldate = "(2017/12/20)" : MENU.aplfcol = vbWhite : MENU.aplbcol = vbDarkGreen
'        Dim aplver = "V5.0" : Dim apldate = "(2018/Enero/22)" : Dim aplfcol = "vbWhite" : Dim aplbcol = "vbDarkGreen"

'        On Error GoTo 0
'        Dim aplmsg = aplnam + " " + aplver + " " + apldate
'        Caption = Caption + " " + aplmsg

'        ' mnuAdmon.Visible = False

'        'vbOrange = &H80FF&
'        'vbPaleRed = &H8080FF
'        'vbPaleBlue = &HFFFFC0
'        'vbPink = &HC0C0FF
'        'vbGris = &H8000000F
'        'vbPaleGris = &HE0E0E0
'        'vbDarkGreen = &H8000&
'        'vbPaleGreen = &HC0FFC0
'        'vbPaleMagenta = &HFFC0FF

'        'fechacon = Now
'        'fini = Now
'        'dia = Format(Day(fini), "00")
'        'mes = Format(Month(fini), "00")
'        'año = Year(fini)
'        'gNow = año + mes + dia

'        Dim gFecha As DateTime = DateTime.Today


'        'gFecha = dia + "/" + mes + "/" + año


'        Dim dirwin = Environ("windir") + "\"
'        username = Trim(UCase(Environ("USERNAME")))
'        userpc = Trim(UCase(Environ("COMPUTERNAME")))
'        gUser = username
'        Dim gUserName = gUser + "-" + userpc
'        Dim gPriv = 0

'        ' características ejecución
'        On Error GoTo 0
'        Dim lbMsg = "Estableciendo Directorios ..."

'        Dim diskprj = "C:\"
'        Dim dirapl = diskprj + "C:\Users\agrijalbaf\Documents\Angel\BSE\EmpleaBSE_4.0a\"
'        Dim dirdat = dirapl

'        ' se comprueba si está montado el disco principal
'        On Error GoTo nodisk
'        Dim kk = Dir(diskprj, vbDirectory)
'        If Dir(diskprj, vbDirectory) = "" Then
'            lintext = "NO ESTAS AUTORIZADO !!!! "
'            MsgBox(lintext, vbCritical, aplmsg)
'            GoTo fin
'        End If

'        On Error GoTo 0
'        ' directorios principales
'        'MENU.dirgen = MENU.dirdat + "Datos a Enviar\"
'        'MENU.dirloa = MENU.dirdat + "Datos_Cargar\"
'        dirlis = dirdat + "Informes\"
'        dirgen = diskprj + "Users\agrijalbaf\Documents\Angel\BSE\"

'        ' se abre la base de datos personal
'        On Error GoTo 0
'        lintext = "Abriendo Conexión SQL con BSE PERSONAL ..."
'        lbMsg = lintext

'        namBD = "PersonBSE"
'        'MENU.usrBD = "usuario_bse"
'        'MENU.pwdBD = "usuario3web"
'        'MENU.srvBD = "LAN108"
'        usrBD = "sa"
'        pwdBD = "Pa$$w0rd"
'        srvBD = "LAN265\SQLEXPRESS"
'        '    MENU.namBDAux = "personal_webSQL"
'        '    MENU.usrBDAux = "usuario_bos"
'        '    MENU.pwdBDAux = "boslan_personal"
'        '    MENU.srvBDAux = MENU.srvBD
'        sCon = "Provider=SQLOLEDB.1;Persist Security nfo=False;User ID=" + usrBD +
'        ";password=" + pwdBD + ";Initial Catalog=" + namBD + ";Data Source=" + srvBD +
'        ";Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False"

'        '    lintext = "Abriendo Conexión SQL con BD Auxiliar ..."
'        '    lbMsg.Caption = lintext
'        '    sConAux = "Provider=SQLOLEDB.1;Persist Security nfo=False;User ID=" + MENU.usrBDAux + _
'        '    ";password=" + MENU.pwdBDAux + ";Initial Catalog=" + MENU.namBDAux + ";Data Source=" + MENU.srvBDAux + _
'        '    ";Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False"

'        On Error GoTo nomdb
'        Dim ConnectionString = sCon
'        dbHoras.Open()
'        '    MENU.dbAux.ConnectionString = sConAux
'        '    MENU.dbAux.Open

'        On Error GoTo 0

'        'Form_Login.vb.Show()


'        ' mnuAdmon.Visible = True


'        'valores iniciales
'        On Error GoTo 0
'        ValoresIniciales()
'        'CargarColores

'        'por defecto, se trabaja siempre con la base de datos de Personal
'        'sPER = "P_"
'        'Mensaje ""

'        Exit Sub
'nomdb:
'        lintext = "Error Accediendo a las Bases de Datos" + vbCr + "ERROR = " + 'Error(Err)
'            MsgBox(lintext, vbCritical, aplmsg)
'        GoTo fin
'        Exit Sub
'nodisk:
'        lintext = "El Disco de Red   N:\   NO está Accesible"
'        MsgBox(lintext, vbCritical, aplmsg)
'fin:
'        On Error Resume Next
'        End
'    End Sub

'    Private Sub Form_Unload(Cancel As Integer)
'        dbHoras.Close()
'    End Sub

'    Public Sub ValoresIniciales()
'        Dim rsA As New ADODB.Recordset
'        Dim sSql As String
'        Dim ierr As Integer
'        Dim sCal As String

'        On Error GoTo 0
'        ierr = 0

'        Dim gMediaDieta = 0#

'        sSql = "select * from ATRIBUTOS where CODIGO='MONEDA'"
'        rsA.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'        rsA.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
'        If rsA.RecordCount = 0 Then
'            MsgBox("No se encuentra el ATRIBUTO 'MONEDA' ")
'            ierr = 1
'        End If
'        Dim gMoneda = rsA(1)
'        Dim gMonedaDes = rsA(3)
'        rsA.Close()

'        sSql = "select * from ATRIBUTOS where CODIGO='CAMBIO'"
'        rsA.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'        rsA.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
'        If rsA.RecordCount = 0 Then
'            MsgBox("No se encuentra el ATRIBUTO 'CAMBIO' ")
'            ierr = 1
'        End If
'        'Dim gCambioEUR = PuntoPorComa(rsA(2))
'        rsA.Close()

'        sSql = "select * from ATRIBUTOS where CODIGO='HORA_EXTRA'"
'        rsA.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'        rsA.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
'        If rsA.RecordCount = 0 Then
'            MsgBox("No se encuentra el ATRIBUTO 'HORA_EXTRA' ")
'            ierr = 1
'        Else
'            'gPrecioHE = PuntoPorComa(rsA(2))
'            'MsgBox "Precio Hora Extra : " + CStr(gPrecioHE) + gMoneda
'        End If
'        rsA.Close()

'        If ierr = 1 Then
'            MsgBox("NO SE PUEDE CONTINUAR")
'            End
'        End If
'    End Sub

'    Private Sub mnuSalir_Click()
'        Me.Close()
'    End Sub

'    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
'        'gUsuario = ""
'        Me.Close()
'        End
'    End Sub










'    Private Sub mnuHoras_Click()
'        Dim Mensaje = ""
'        Dim sPER = "P_"
'        'EMPHORAS.Show()
'    End Sub

'    '    Private Sub bHoras_Click()
'    '        Mensaje = ""
'    '        sPER = ""
'    '        EMPHORAS.Show
'    '    End Sub

'    '    Private Sub mnuHorasweb_Click()
'    '        Mensaje ""
'    '    sPER = ""
'    '        EMPHORAS.Show
'    '    End Sub

'    '    Private Sub mnuGrupos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        EMPGRUPO.Show
'    '    End Sub

'    '    Private Sub bGrupos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        EMPGRUPO.Show
'    '    End Sub

'    '    Private Sub mnuVacas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        EMPVACAS.Show
'    '    End Sub

'    '    Private Sub bVacas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        EMPVACAS.Show
'    '    End Sub

'    '    Private Sub mnuVacasWeb_Click()
'    '        Mensaje ""
'    '    sPER = ""
'    '        EMPVACAS.Show
'    '    End Sub

'    '    Private Sub mnuGastos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        EMPGASTOS.Show
'    '    End Sub

'    '    Private Sub bGastos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        EMPGASTOS.Show
'    '    End Sub

'    '    Private Sub mnuGastosWeb_Click()
'    '        Mensaje ""
'    '    sPER = ""
'    '        EMPGASTOS.Show
'    '    End Sub

'    '    Private Sub mnuLisGastos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        gAño = Year(Now)
'    '        gMes = Month(Now)

'    '        SELAÑO.Show vbModal
'    '    If bCancelAño Then Exit Sub

'    '        LISGASTOS.Show
'    '    End Sub

'    '    Private Sub bLisGastos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        gAño = Year(Now)
'    '        gMes = Month(Now)

'    '        SELAÑO.Show vbModal
'    '    If bCancelAño Then Exit Sub

'    '        LISGASTOS.Show
'    '    End Sub

'    '    Private Sub mnuCtlGastos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        gAño = Year(Now)
'    '        gMes = Month(Now)

'    '        SELAÑO.Show vbModal
'    '    If bCancelAño Then Exit Sub

'    '        LISGASTSH.Show
'    '    End Sub

'    '    Private Sub bCtlGastos_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        gAño = Year(Now)
'    '        gMes = Month(Now)

'    '        SELAÑO.Show vbModal
'    '    If bCancelAño Then Exit Sub

'    '        LISGASTSH.Show
'    '    End Sub

'    '    Private Sub mnuLisPerson_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        LISPERSON.Show
'    '    End Sub

'    '    Private Sub bLisPerson_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        LISPERSON.Show
'    '    End Sub

'    '    Private Sub mnuCtlVacas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLVACAS.Show
'    '    End Sub

'    '    Private Sub bCtlVacas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLVACAS.Show
'    '    End Sub

'    '    Private Sub mnuCtlEnero_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLENERO.Show
'    '    End Sub

'    '    Private Sub bVEnero_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLENERO.Show
'    '    End Sub

'    '    Private Sub mnuCtlHWeb_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLWEB.T_DATOS = "W"
'    '        CTLWEB.Show
'    '    End Sub

'    '    Private Sub bCtlHWeb_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLWEB.T_DATOS = "W"
'    '        CTLWEB.Show
'    '    End Sub

'    '    Private Sub mnuCtlHPers_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLWEB.T_DATOS = "P"
'    '        CTLWEB.Show
'    '    End Sub

'    '    Private Sub bCtlHPers_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        CTLWEB.T_DATOS = "P"
'    '        CTLWEB.Show
'    '    End Sub

'    '    Private Sub mnuNominas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        GENNOMINA.Show
'    '    End Sub

'    '    Private Sub bNominas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        GENNOMINA.Show
'    '    End Sub

'    '    Private Sub mnuLisNomina_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        gAño = Year(Now)
'    '        gMes = Month(Now)

'    '        SELAÑO.Show vbModal
'    '    If bCancelAño Then Exit Sub

'    '        LISNOMCOM.Show
'    '    End Sub

'    '    Private Sub bLisNomina_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        gAño = Year(Now)
'    '        gMes = Month(Now)

'    '        SELAÑO.Show vbModal
'    '    If bCancelAño Then Exit Sub

'    '        LISNOMCOM.Show
'    '    End Sub

'    '    Private Sub bCargaNom_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        LOANOMINA.Show
'    '    End Sub

'    '    Private Sub mnuCargaNom_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        LOANOMINA.Show
'    '    End Sub

'    '    Private Sub mnuCalendas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        GENCALEND.Show vbModal
'    'End Sub

'    '    Private Sub bCalendas_Click()
'    '        Mensaje ""
'    '    sPER = "P_"
'    '        GENCALEND.Show vbModal
'    'End Sub


'    Private Sub Timer1_Timer()
'        gReloj = gReloj + 1
'        If gReloj > gRelojMax Then
'            'APLABO.Show
'        End If
'    End Sub



'    Dim usuario As String

'    Private Sub FormLogin_Load()
'        '
'        'name:      APLLOG
'        'descr:     login en la aplicación
'        'author:    pantxo
'        'date:      may/14
'        '
'        Dim gModulo = "APLLOG>"
'        Dim pronam = gModulo
'        '    MENU.newver = "v1.0 (2014/05/02)"
'        ' se pone versión aplicación
'        Dim newver = "v2 (2018/01/23)"

'        Dim gReloj = 0
'        Dim Caption = aplnam + ">> " + aplver + " " + apldate
'        usuario = gUser
'        txtUserName.value.text = gUser
'    End Sub

'    Private Sub bSalir_Click()
'        usuario = ""
'        gPriv = -1
'        End
'    End Sub

'    Private Sub bOK_Click()
'        Dim kk As String, cc As String

'        usuario = txtUserName.text
'        Me.Close()

'    End Sub

'    Private Function Contraseña(sUsu As String) As String
'        Dim rsA As New ADODB.Recordset
'        Dim sSql As String, nivel As Integer

'        sSql = "select CONTRASEÑA, NIVEL from USUARIOS where NOMBRE='" & sUsu & "'"
'        rsA.CursorLocation = adUseClient
'        rsA.Open sSql, Menu.dbHoras, adOpenStatic, adLockReadOnly
'        If rsA.RecordCount <> 0 Then
'            Contraseña = rsA(0)
'            nivel = rsA(1)
'            gPriv = nivel
'        Else
'            Contraseña = ""
'            gPriv = 0
'        End If
'        rsA.Close()
'    End Function










'End Class