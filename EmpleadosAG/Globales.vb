''
'' name:     globales
'' author:   mregila (hasta jul/2013)
'' descr:    declaración de variables y funciones públicas
'' modif:    pantxo
'' se quitan los string de conexiones a SQLserver y se pasan al form Principal
'' más variables globales
'' version:  2.0 (2014/04/30)
'' valores de privilegios
'' version:  2.1 (2014/05/09)
'' retoques
'' version:  2.2 (2016/02/16)

Imports Microsoft.VisualBasic

Module Globales
    '    Structure SCalendarios
    '        Dim CAL As String
    '        Dim ID As Int16
    '        Dim Mes As String
    '        Dim Dias() As String
    '        Dim Total As Single
    '        Dim DiasT As Int16
    '    End Structure

    '    Public tipo_empleado As String
    Public dbConexion As SqlClient.SqlConnection

    '    ' quien y donde
    Public gLogin As String, gUsuario As String, gContraseña As String, gOrdenador As String, gPriv As Short
    Public gPrivMin As Short, gPrivMod As Short, gPrivMax As Short
    '    Public gMatricula As Integer

    '    ' servidor, BD, usuario, contraseña
    Public gSrvBD As String, gNamBD As String, gUsrBD As String, gPwdBD As String
    '    ' directorios
    Public gAplNam As String, gAplVers As String, gConexion As String
    Public gAplDisk As String, gAplDir As String, gAplDat As String
    Public gAplRpt As String, gAplFot As String
    Public gAplCV As String, gAplCto As String
    Public gModulo As String
    Public sPER As String
    Public dbHoras As New ADODB.Connection
    Public gReloj As Integer
    Public bWeb As Boolean


#Region "colores"
    Public ReadOnly Property G_ROSA_CLARITO As Color = Color.FromName("LightPink")
    Public ReadOnly Property G_AMARILLO_CLARITO As Color = Color.FromName("LightGoldenrodYellow")
    Public ReadOnly Property G_VERDE_CLARITO As Color = Color.FromName("LightGreen")
    Public ReadOnly Property G_ROSA As Color = Color.FromName("MistyRose")
    Public ReadOnly Property C_VERDE As Color = Color.FromName("LawnGreen")
    Public ReadOnly Property G_NEGRO As Color = Color.FromName("Black")
    Public ReadOnly Property vbBlack As Color = Color.FromName("Black")
    Public ReadOnly Property G_ROJO As Color = Color.FromName("Red")
    Public ReadOnly Property vbRed As Color = Color.FromName("Red")
    Public ReadOnly Property G_NARANJA As Color = Color.FromName("Orange")
    Public ReadOnly Property G_AMARILLO As Color = Color.FromName("Yellow")
    Public ReadOnly Property G_VERDE As Color = Color.FromName("Green")
    Public ReadOnly Property G_AZUL As Color = Color.FromName("Blue")
    Public ReadOnly Property G_AZULOSC As Color = Color.FromName("DarkBlue")
    Public ReadOnly Property G_MAGENTA As Color = Color.FromName("Magenta")
    Public ReadOnly Property G_ROSA_FUERTE As Color = Color.FromName("Fuchsia")
    Public ReadOnly Property G_MARRON As Color = Color.FromName("SaddleBrown")
    Public ReadOnly Property G_VERDEOS As Color = Color.FromName("DarkGreen")
    Public ReadOnly Property G_GRISOS As Color = Color.FromName("Gray")
    Public ReadOnly Property G_MORADO As Color = Color.FromName("Purple")
    Public ReadOnly Property G_BLANCO As Color = Color.FromName("White")
    'Sin definir, revisar colores
    Public ReadOnly Property G_12 As Color = Color.FromName("MediumAquamarine")
    Public ReadOnly Property G_13 As Color = Color.FromName("MediumAquamarine")
    'Public Const G_12 = &HFFC0FF
    'Public Const G_13 = &HC0C0FF
    Public ReadOnly Property G_VERDE_CLARO As Color = Color.FromName("LimeGreen")
    Public ReadOnly Property G_AMARILLO_CLARO As Color = Color.FromName("Chartreuse")

    'Sin definir, revisar colores
    Public ReadOnly Property G_TERM As Color = Color.FromName("MediumAquamarine")
    Public ReadOnly Property G_NO_TERM As Color = Color.FromName("MediumAquamarine")
    'Public Const G_TERM = &H8080FF
    'Public Const G_NO_TERM = &HC0FFC0

#End Region

    Public txBD As Form




    '    Public gModNam As String, gModVers As String
    '    Public gCosteFijo As Double
    '    Public gSeleccion As String

    '    Public tipo_listado As String
    '    Public tipo_consulta As Integer
    '    Public Mes As String
    '    Public NumMes As Int16
    '    Public CodMes As String
    '    Public Año As Int16
    '    Public texto_seleccionado As String
    '    Public valor_seleccionado As Object
    '    Public indice_seleccionado As Integer
    '    Public estoy_aqui_error As String
    '    Public fecha_inicial As Date
    '    Public bProc As Boolean
    Public usuario As String
    Public gEmpId As Integer
    Public gEmpNom As String
    Public gMes As Integer
    Public gAño As Integer

    '    Public ppvd As Boolean
    '    Public pauxilios As Boolean
    '    Public priesgo As Boolean
    '    Public pprl As Boolean
    '    Public pprloficinas As Boolean
    '    Public pprlconstruc As Boolean
    '    Public pprlelectri As Boolean
    '    Public psupprl As Boolean
    '    Public pcoorss As Boolean
    '    Public potros As Boolean

    '    Public pguantes As Boolean
    '    Public pcasco As Boolean
    '    Public ptapones As Boolean
    '    Public pgafas As Boolean
    '    Public pbotas As Boolean
    '    Public parnes As Boolean
    '    Public propa As Boolean
    '    Public propaign As Boolean
    '    Public pepis As Boolean

    '    Declare Function GetUserName Lib "advapi32.dll" Alias _
    '    "GetUserNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer


    '    Public Function Encripta(ByVal Pass As String) As String
    '        Dim Clave As String, i As Integer, Pass2 As String
    '        Dim CAR As String, Codigo As String
    '        Clave = "%ü&/@#$A"
    '        Pass2 = ""
    '        For i = 1 To Len(Pass)
    '            CAR = Mid(Pass, i, 1)
    '            Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
    '            Pass2 = Pass2 & Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
    '        Next i
    '        Encripta = Pass2
    '    End Function

    '    Public Function valoresnulos(ByVal entrada As Object, Optional ByVal bNum As Boolean = False) As String
    '        If IsDBNull(entrada) Then
    '            If bNum Then
    '                valoresnulos = "0"
    '            Else
    '                valoresnulos = ""
    '            End If
    '        Else
    '            valoresnulos = Trim(entrada.ToString)
    '        End If
    '        Return valoresnulos
    '    End Function

    '    Public Function EjecutarTransaccion(ByVal SQL() As String, ByVal numT As Short, ByVal db As SqlClient.SqlConnection) As Boolean
    '        'Execute the SQL statement.  Return true if executed successfully; otherwise return false
    '        Dim i As Short
    '        Dim trans As SqlClient.SqlTransaction

    '        db.Open()
    '        trans = db.BeginTransaction()
    '        For i = 0 To numT - 1
    '            Try
    '                'Create a command to hold the SQL statement
    '                Dim oCmd As New SqlClient.SqlCommand(SQL(i), db)
    '                oCmd.Transaction = trans

    '                'Execute the SQL Statement
    '                oCmd.ExecuteNonQuery()

    '            Catch oledbError As SqlClient.SqlException
    '                trans.Rollback()
    '                'sMensajeError = oledbError.Message
    '                'sSentenciaError = SQL(i)
    '                db.Close()

    '                Return False
    '            Catch objError As Exception
    '                'An error has occurred.  If page tracing is turned on, display detailed error; otherwise default to generic error message.
    '                trans.Rollback()
    '                'sMensajeError = objError.Message
    '                'sSentenciaError = SQL(i)
    '                db.Close()

    '                Return False
    '            End Try
    '        Next
    '        'Return with success flag
    '        trans.Commit()
    '        'Close the database connection
    '        db.Close()
    '        Return True
    '    End Function

    '    Public Function EjecutarUpdate(ByVal SQL As String, ByVal db As SqlClient.SqlConnection) As Boolean
    '        'Execute the SQL statement.  Return true if executed successfully; otherwise return false
    '        'Dim i As Short
    '        'Create a command to hold the SQL statement
    '        'Dim oCmd As New OleDb.OleDbCommand(SQL, db)
    '        Dim oCmd As New SqlClient.SqlCommand(SQL, dbConexion)
    '        'Execute the SQL Statement
    '        db.Open()

    '        Try
    '            oCmd.ExecuteNonQuery()

    '        Catch oledbError As SqlClient.SqlException
    '            db.Close()
    '            Return False
    '        Catch objError As Exception
    '            db.Close()
    '            Return False
    '        End Try
    '        db.Close()
    '        Return True
    '    End Function

    '    Public Sub ControlAcceso(ByVal f As Form, ByVal nivel As Int16)
    '        Dim cCon As Control
    '        Dim cText As TextBox
    '        'Dim cTab As TabPage
    '        For Each cCon In f.Controls
    '            If cCon.Controls.Count > 0 Then
    '                ControlAc(cCon, nivel)
    '            End If
    '            If IsNumeric(cCon.Tag) Then
    '                If cCon.Tag > nivel Then
    '                    If Left(cCon.Name, 3) = "txt" Then
    '                        cText = CType(cCon, TextBox)
    '                        cText.PasswordChar = "*"
    '                        cText.Refresh()
    '                    ElseIf Left(cCon.Name, 3) = "btn" Then
    '                        cCon.Enabled = False
    '                    Else
    '                        cCon.Visible = False
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End Sub

    '    Public Sub ControlAc(ByVal cont As Control, ByVal nivel As Int16)
    '        Dim cCon As Control
    '        Dim cText As TextBox
    '        'Dim cTab As TabPage
    '        For Each cCon In cont.Controls
    '            If cCon.Controls.Count > 0 Then
    '                ControlAc(cCon, nivel)
    '            End If
    '            If IsNumeric(cCon.Tag) Then
    '                If cCon.Tag > nivel Then
    '                    If Left(cCon.Name, 3) = "txt" Then
    '                        cText = CType(cCon, TextBox)
    '                        cText.PasswordChar = "*"
    '                    ElseIf Left(cCon.Name, 3) = "btn" Then
    '                        cCon.Enabled = False
    '                    Else
    '                        cCon.Visible = False
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End Sub

    '    Public Function PuntoPorComa(ByVal cad As String) As String
    '        Dim pos As Integer
    '        'Dim sCad As String

    '        pos = InStr(1, cad, ".")
    '        If pos <> 0 Then
    '            PuntoPorComa = Mid(cad, 1, pos - 1) + "," + Mid(cad, pos + 1)
    '        Else
    '            PuntoPorComa = cad
    '        End If
    '    End Function

    '    Public Function ComaPorPunto(ByVal cad As String) As String
    '        Dim pos As Integer
    '        'Dim sCad As String

    '        pos = InStr(1, cad, ",")
    '        If pos <> 0 Then
    '            ComaPorPunto = Mid(cad, 1, pos - 1) + "." + Mid(cad, pos + 1)
    '        Else
    '            ComaPorPunto = cad
    '        End If
    '    End Function

    '    Public Function EsLaboral(ByVal fec As Date, ByVal cal As String, ByRef nH As Single) As Boolean
    '        Dim dY, dM, dD As Integer
    '        Dim DA As SqlClient.SqlDataAdapter
    '        Dim ds As New DataSet
    '        Dim sSql As String

    '        dY = Year(fec)
    '        dM = Month(fec)
    '        dD = Day(fec)

    '        sSql = "select [" & CStr(dD) & "] from calendario_" & CStr(dY) & " where cal='" & cal & "' and id=" & dM & ";"
    '        DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
    '        DA.Fill(ds, "DIA")
    '        If ds.Tables(0).Rows.Count = 1 Then
    '            If IsNumeric(ds.Tables(0).Rows(0).Item(0)) Then
    '                nH = PuntoPorComa(ds.Tables(0).Rows(0).Item(0))
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Else
    '            Return False
    '        End If
    '    End Function

    '    Public Function HorasOficiales(ByVal dAño As Int16) As Single
    '        Dim sSql As String
    '        Dim DA As SqlClient.SqlDataAdapter
    '        Dim ds As New DataSet

    '        sSql = "select horas_oficiales from variables where año=" & dAño.ToString
    '        DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
    '        DA.Fill(ds, "HO")
    '        If ds.Tables(0).Rows.Count = 1 Then
    '            Return ds.Tables(0).Rows(0).Item(0)
    '        Else
    '            Return 0
    '        End If
    '    End Function

    '    Public Function DatoVariable(ByVal sVariable As String, ByVal dAño As Int16) As String
    '        Dim sSql As String
    '        Dim DA As SqlClient.SqlDataAdapter
    '        Dim ds As New DataSet

    '        sSql = "select " & sVariable & " from variables where año=" & dAño.ToString
    '        DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
    '        DA.Fill(ds, "HO")
    '        If ds.Tables(0).Rows.Count = 1 Then
    '            Return ds.Tables(0).Rows(0).Item(0)
    '        Else
    '            Return ""
    '        End If
    '    End Function

    '    Public Function NombreProyecto(ByVal codp As String) As String
    '        Dim sSql As String
    '        Dim DA As SqlClient.SqlDataAdapter
    '        Dim ds As New DataSet

    '        sSql = "select nombre_proyecto from proyectos where código_proyecto='" & codp & "'"
    '        DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
    '        DA.Fill(ds, "HO")
    '        If ds.Tables(0).Rows.Count = 1 Then
    '            Return ds.Tables(0).Rows(0).Item(0)
    '        Else
    '            Return ""
    '        End If
    '    End Function

    '    Public Function RecogerMes(ByVal cal As String, ByVal mes As Short, ByVal año As Short, ByRef sMes As SCalendarios) As Boolean
    '        Dim DA As SqlClient.SqlDataAdapter
    '        Dim ds As New DataSet
    '        Dim sSql As String
    '        Dim dr As DataRow
    '        Dim i As Short

    '        sSql = "select * from calendario_" & CStr(año) & " where cal='" & cal & "' and id=" & mes.ToString & ";"
    '        Try
    '            DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
    '            DA.Fill(ds, "DIA")
    '        Catch objError As Exception
    '            Return False
    '        End Try

    '        If ds.Tables(0).Rows.Count = 1 Then
    '            dr = ds.Tables(0).Rows(0)
    '            sMes.CAL = cal
    '            sMes.ID = mes
    '            sMes.Mes = dr.Item("MES")
    '            sMes.DiasT = dr.Item("DIAS")
    '            sMes.Total = dr.Item("TOTAL")
    '            ReDim sMes.Dias(30)
    '            For i = 0 To 30
    '                If IsDBNull(dr.Item(CStr(i + 1))) Then
    '                    sMes.Dias(i) = ""
    '                Else
    '                    sMes.Dias(i) = dr.Item(CStr(i + 1))
    '                End If
    '            Next
    '        Else
    '            Return False
    '        End If
    '        Return True
    '    End Function

    '    Public Function RecogerAño(ByVal cal As String, ByVal año As Short, ByRef sMes() As SCalendarios) As Boolean
    '        Dim DA As SqlClient.SqlDataAdapter
    '        Dim ds As New DataSet
    '        Dim sSql As String
    '        Dim dr As DataRow
    '        Dim i, j As Short

    '        sSql = "select * from calendario_" & CStr(año) & " where cal='" & cal & "' and id <> 13 order by id;"
    '        Try
    '            DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
    '            DA.Fill(ds, "DIA")
    '        Catch objError As Exception
    '            Return False
    '        End Try

    '        'If ds.Tables(0).Rows.Count = 1 Then
    '        For j = 0 To ds.Tables(0).Rows.Count - 1
    '            ReDim Preserve sMes(j)
    '            dr = ds.Tables(0).Rows(j)
    '            sMes(j).CAL = cal
    '            sMes(j).ID = Mes
    '            sMes(j).Mes = dr.Item("MES")
    '            sMes(j).DiasT = dr.Item("DIAS")
    '            sMes(j).Total = dr.Item("TOTAL")
    '            ReDim sMes(j).Dias(30)
    '            For i = 0 To 30
    '                If IsDBNull(dr.Item(CStr(i + 1))) Then
    '                    sMes(j).Dias(i) = ""
    '                Else
    '                    sMes(j).Dias(i) = dr.Item(CStr(i + 1))
    '                End If
    '            Next
    '        Next
    '        Return True
    '    End Function

    '    Public Function ActualizarMes(ByVal cal As String, ByVal mes As Short, ByVal año As Short, ByVal sMes As SCalendarios) As Boolean
    '        Dim sSql As String

    '        sSql = "update calendario_" & CStr(año) &
    '            " set TOTAL=" & ComaPorPunto(sMes.Total) & ", DIAS=" & sMes.DiasT & " where cal='" & cal & "' and id=" & mes.ToString & ";"
    '        If EjecutarUpdate(sSql, dbConexion) Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    End Function

    '    Public Sub controlar_errores(ByVal donde As String, ByVal exc As ErrObject)
    '        Dim form1 As New CtlError

    '        form1.TextBox1.Text = donde + vbCrLf +
    '                              "Nº " + CStr(exc.Number) + vbCrLf +
    '                              exc.Description +
    '                              vbCrLf + " VOY A " + estoy_aqui_error
    '        form1.Show()
    '    End Sub

    '    Public Function ComprobarFechas(ByVal textofecha As String) As String
    '        Dim linea As String
    '        Dim fecha As Date
    '        Dim año As Integer

    '        If textofecha <> "" Then
    '            If IsDate(textofecha) = False Then
    '                linea = "Fecha Errónea"
    '                MsgBox(linea, MsgBoxStyle.OkOnly, "¡ AVISO !")
    '                ComprobarFechas = ""
    '            Else
    '                If CDate(textofecha).Year < 1900 Then
    '                    linea = "Fecha Errónea"
    '                    MsgBox(linea, MsgBoxStyle.OkOnly, "¡ AVISO !")
    '                    ComprobarFechas = ""
    '                Else
    '                    fecha = CType(textofecha, Date)
    '                    año = Year(fecha)
    '                    ComprobarFechas = Format(fecha, "dd/MM/yyyy")
    '                End If
    '            End If
    '        Else
    '            ComprobarFechas = ""
    '        End If
    '    End Function

    '    Public Function ComprobarFechasActuales(ByVal textofecha As String) As String
    '        Dim linea As String
    '        Dim fecha As Date
    '        Dim año As Integer

    '        If textofecha <> "" Then
    '            If IsDate(textofecha) = False Then
    '                linea = "Fecha Errónea"
    '                MsgBox(linea, MsgBoxStyle.OkOnly, "¡ AVISO !")
    '                ComprobarFechasActuales = ""
    '            Else
    '                fecha = CType(textofecha, Date)
    '                año = Year(fecha)
    '                If año > 1999 And año < 2100 Then
    '                    ComprobarFechasActuales = Format(fecha, "dd/MM/yyyy")
    '                Else
    '                    linea = "¡Año Erróneo!"
    '                    MsgBox(linea, MsgBoxStyle.OkOnly, "¡ AVISO !")
    '                    ComprobarFechasActuales = ""
    '                End If
    '            End If
    '        Else
    '            ComprobarFechasActuales = ""
    '        End If
    '    End Function

    '    Public Function Dosdecimales(ByVal dNum As Double) As String
    '        '*******************************************************************************
    '        ' Poner los numeros dobles con dos decimales
    '        '*******************************************************************************
    '        Dim snum As String, nentera As String, ndecimal As String
    '        Dim pos As Integer

    '        snum = CStr(dNum)
    '        'Vemos la posición de la coma
    '        pos = InStr(1, snum, ",")
    '        'Si no hay coma le añadimos dos ceros decimales
    '        If pos = 0 Then
    '            Dosdecimales = CStr(dNum)
    '        Else
    '            'Cogemos la parte entera
    '            nentera = Mid(snum, 1, pos - 1)
    '            'Cogemos la parte decimal
    '            ndecimal = Mid(snum, pos + 1, 2)
    '            'Componemos lo que queremos que salga
    '            snum = nentera + "," + ndecimal
    '            Dosdecimales = snum
    '        End If
    '    End Function

    '    Function NombreUsuario() As String
    '        Dim Ret As Integer
    '        Dim UserName As String
    '        Dim Buffer As String

    '        Buffer = New String(CChar(" "), 25)
    '        Ret = GetUserName(Buffer, 25)
    '        UserName = Left(Buffer, InStr(Buffer, Chr(0)) - 1)
    '        NombreUsuario = UserName
    '        'NombreUsuario = Environ("Username")
    '    End Function

    Function NivelUsuario(ByVal nom As String) As Int16
        Dim DA As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sSql As String

        sSql = "select * from usuarios where nombre='" & nom & "'"
        Try
            DA = New SqlClient.SqlDataAdapter(sSql, dbConexion)
            DA.Fill(ds, "USU")
        Catch objError As Exception
            Return -1
        End Try

        If ds.Tables(0).Rows.Count = 1 Then
            NivelUsuario = ds.Tables(0).Rows(0).Item(1)
        Else
            NivelUsuario = -1
        End If
    End Function

    '    Public Function EjecutarTransaccion_web(ByVal SQL() As String, ByVal numT As Short, ByVal db As SqlClient.SqlConnection) As Boolean
    '        'Execute the SQL statement.  Return true if executed successfully; otherwise return false
    '        Dim i As Short
    '        Dim trans As SqlClient.SqlTransaction

    '        db.Open()

    '        trans = db.BeginTransaction()
    '        For i = 0 To numT - 1
    '            Try
    '                'Create a command to hold the SQL statement
    '                Dim oCmd As New SqlClient.SqlCommand(SQL(i), db)
    '                oCmd.Transaction = trans

    '                'Execute the SQL Statement
    '                oCmd.ExecuteNonQuery()

    '            Catch oledbError As SqlClient.SqlException
    '                trans.Rollback()
    '                db.Close()
    '                Return False
    '            Catch objError As Exception
    '                'An error has occurred.  If page tracing is turned on, display detailed error; otherwise default to generic error message.
    '                trans.Rollback()
    '                db.Close()
    '                Return False
    '            End Try
    '        Next
    '        'Return with success flag
    '        trans.Commit()
    '        'Close the database connection
    '        db.Close()
    '        Return True
    '    End Function

    '    Sub RellenarOficinaCotizacion(ByVal combo As ComboBox)
    '        Dim dacuenta As SqlClient.SqlDataAdapter
    '        Dim dscuenta As Data.DataSet
    '        'Dim dr As Data.DataRow
    '        'Dim i As Int16

    '        dacuenta = New SqlClient.SqlDataAdapter("select distinct(ubicacion), cuenta_cotizacion from CUENTA_COTIZACION", dbConexion)
    '        dscuenta = New Data.DataSet
    '        Try
    '            dacuenta.Fill(dscuenta, "CUENTA_COTIZACION")
    '        Catch ex As Exception
    '            MessageBox.Show("Error en Fill 'CUENTA_COTIZACION':" & vbCrLf & ex.Message)
    '        End Try

    '        'Rellenamos el combo con las ubicaciones que existen
    '        combo.Items.Clear()
    '        combo.DataSource = dscuenta.Tables(0)
    '        combo.DisplayMember = "UBICACION"
    '        combo.ValueMember = "CUENTA_COTIZACION"
    '    End Sub

    Public Sub RellenarAño(cbA As ComboBox)
        Dim DA As Integer
        Dim i As Integer, j As Integer

        cbA.Items.Clear()
        DA = Year(Now)
        j = 0
        For i = DA - 5 To DA + 1
            cbA.Items.Add(CStr(i))
            'cbA.ItemData(j) = i
            j = j + 1
        Next
    End Sub

    Public Sub RellenarMes(cbM As ComboBox)
        Dim i As Integer

        cbM.Items.Clear()

        For i = 1 To 12
            cbM.Items.Add(UCase(MonthName(i)))
            'cbM.ItemData(i - 1) = i
        Next
    End Sub

    Public Sub ListaEmpleados(combo As ComboBox, sUbi As String)
        Dim rsE As New ADODB.Recordset
        Dim i As Integer
        Dim bR As Boolean
        Dim sW As String

        '    If MENU.lbBD = "DATOS WEB" Then
        If sPER = "" Then
            If sUbi <> "" Then
                sW = "empleados_web where ubicacion='" & sUbi & "' order by nombre"
            Else
                sW = "empleados_web  order by nombre"
            End If
            bR = RSEmpleados(rsE, sW)
        Else
            bR = RSEmpleados(rsE, "empleados order by apel1, apel2, nombre")
        End If

        If bR Then
            rsE.MoveFirst()
            combo.Items.Clear()

            For i = 0 To rsE.RecordCount - 1
                'If MENU.lbBD = "DATOS WEB" Then
                If sPER = "" Then
                    combo.Items.Add(rsE("nombre"))
                Else
                    combo.Items.Add(String.Concat(rsE("apel1"), " ", rsE("apel2"), " ", rsE("nombre")))
                End If
                'combo.ItemData(i) = rsE("Matricula")
                rsE.MoveNext()
            Next
            combo.SelectedIndex = -1
        End If
        rsE.Close()
    End Sub

    Public Function RSEmpleados(ByRef rsE As ADODB.Recordset, tabla As String) As Boolean
        Dim sSql As String

        sSql = "select * from " + tabla
        rsE.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsE.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
        If rsE.RecordCount <> 0 Then
            RSEmpleados = True
        Else
            RSEmpleados = False
        End If
    End Function

    Public Function PuntoPorComa(ByVal cad As String) As String
        Dim pos As Integer

        pos = InStr(1, cad, ".")
        If pos <> 0 Then
            PuntoPorComa = Mid(cad, 1, pos - 1) + "," + Mid(cad, pos + 1)
        Else
            PuntoPorComa = cad
        End If
    End Function

    Public Function EsSQLServer(db As ADODB.Connection) As Boolean
        If db.Provider = "Microsoft.Jet.OLEDB.4.0" Then
            EsSQLServer = False
        Else
            EsSQLServer = True
        End If
    End Function

    Public lbC(9) As Label
    'creación de componentes gráficos en serie
    Public Sub CrearLabel()

        For n = 0 To 9
            lbC(n) = New Label()
            lbC(n).Text = n
        Next
    End Sub

    'Public cbProy(5) As ComboBox

    'Public Sub CrearCbProy()

    '    For n = 0 To 5
    '        cbProy(n) = New ComboBox()
    '        cbProy(n).Text = n
    '    Next
    'End Sub

    Public txtTHP(10) As TextBox
    Public Sub CreartxtTHP()

        For n = 0 To 9
            txtTHP(n) = New TextBox()
            txtTHP(n).Text = n
        Next
    End Sub

    Public txtTEP(10) As TextBox
    Public Sub CreartxtTEP()

        For n = 0 To 9
            txtTEP(n) = New TextBox()
            txtTEP(n).Text = n
        Next
    End Sub

    Public txtTH(10) As TextBox
    Public Sub CreartxtTH()

        For n = 0 To 9
            txtTH(n) = New TextBox()
            txtTH(n).Text = n

        Next
    End Sub

    Public txtTE(10) As TextBox
    Public Sub CreartxtTE()

        For n = 0 To 9
            txtTE(n) = New TextBox()
            txtTE(n).Text = n
        Next
    End Sub

    'Dim txtDia(7) As TextBox
    'Public Sub CreartxtDia()

    '    For n = 0 To 7
    '        txtDia(n) = New TextBox()
    '        txtDia(n).Text = n
    '        FlowLayoutPanel1.Controls.Add(txtDia)
    '    Next
    'End Sub

End Module
