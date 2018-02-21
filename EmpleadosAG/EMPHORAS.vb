


Imports System.Data.SqlClient

Public Class EMPHORAS


    Dim EmpCal As String
    Dim EmpCalAct As String
    Dim EmpVac As Single
    Dim EmpNom As String

    Dim EmpId As Integer
    Dim EmpUbi As String

    Dim dMes As Integer
    Dim dAño As Integer
    Dim ColorAnt As Color

    Const NUMFIL = 7

    Dim txtDia(6) As TextBox

    Dim BotonBloqueado As Boolean = False

    Public cbProy(13) As ComboBox
    'Public Sub CrearCbProy()
    '    For n = 0 To NUMFIL

    '        cbProy(n) = New ComboBox()
    '        cbProy(n).Text = n

    '    Next
    'End Sub
    Public Sub CreartxtDia()
        Dim lbProyectos = New Label
        lbProyectos.Text = "PROYECTOS"
        TableLayoutPanel1.Controls.Add(lbProyectos, 0, 0)
        Dim lbTotal = New Label
        lbTotal.Text = "TOTAL"
        TableLayoutPanel1.Controls.Add(lbTotal, 8, 0)
        For n = 0 To 6
            txtDia(n) = New TextBox()
            If (n >= 0 And n <= 4) Then
                txtDia(n).BackColor = G_AMARILLO_CLARITO
            ElseIf (n >= 5 And n <= 6) Then
                txtDia(n).BackColor = G_VERDE_CLARITO
            End If
            TableLayoutPanel1.Controls.Add(txtDia(n), n + 1, 0)
            TableLayoutPanel1.SetColumnSpan(txtDia(n), 2)
            TableLayoutPanel1.SetColumnSpan(lbTotal, 2)
        Next
    End Sub
    Public txtH1(9) As TextBox
    Public txtE1(9) As TextBox
    Public Sub CreartxtH1()
        Dim c As Integer
        For c = 1 To 9
            txtH1(c) = New TextBox()
            txtH1(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH1(c), 1, c)
            txtE1(c) = New TextBox()
            txtE1(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtE1(c), 2, c)
            txtH1(c).BackColor = G_AMARILLO_CLARITO
            txtE1(c).BackColor = G_AMARILLO_CLARITO
            cbProy(c) = New ComboBox()
            'AddHandler cbProy(c).SelectedIndexChanged, AddressOf cbProy_SelectedIndexChanged

            TableLayoutPanel1.Controls.Add(cbProy(c), 0, c)
        Next
    End Sub
    Public txtH2(9) As TextBox
    Public txtE2(9) As TextBox
    Public Sub CreartxtH2()
        Dim c As Integer
        For c = 1 To 9
            txtH2(c) = New TextBox()
            txtH2(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH2(c), 3, c)
            txtE2(c) = New TextBox()
            txtE2(c).Width = 45
            txtH2(c).BackColor = G_AMARILLO_CLARITO
            txtE2(c).BackColor = G_AMARILLO_CLARITO
            TableLayoutPanel1.Controls.Add(txtE2(c), 4, c)
        Next
    End Sub
    Public txtH3(9) As TextBox
    Public txtE3(9) As TextBox
    Public Sub CreartxtH3()
        Dim c As Integer
        For c = 1 To 9
            txtH3(c) = New TextBox()
            txtH3(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH3(c), 4, c)
            txtE3(c) = New TextBox()
            txtE3(c).Width = 45
            txtH3(c).BackColor = G_AMARILLO_CLARITO
            txtE3(c).BackColor = G_AMARILLO_CLARITO
            TableLayoutPanel1.Controls.Add(txtE3(c), 5, c)
        Next
    End Sub
    Public txtH4(9) As TextBox
    Public txtE4(9) As TextBox
    Public Sub CreartxtH4()
        Dim c As Integer
        For c = 1 To 9
            txtH4(c) = New TextBox()
            txtH4(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH4(c), 6, c)
            txtE4(c) = New TextBox()
            txtE4(c).Width = 45
            txtH4(c).BackColor = G_AMARILLO_CLARITO
            txtE4(c).BackColor = G_AMARILLO_CLARITO
            TableLayoutPanel1.Controls.Add(txtE4(c), 7, c)
        Next
    End Sub
    Public txtH5(9) As TextBox
    Public txtE5(9) As TextBox
    Public Sub CreartxtH5()
        Dim c As Integer
        For c = 1 To 9
            txtH5(c) = New TextBox()
            txtH5(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH5(c), 8, c)
            txtE5(c) = New TextBox()
            txtE5(c).Width = 45
            txtH5(c).BackColor = G_AMARILLO_CLARITO
            txtE5(c).BackColor = G_AMARILLO_CLARITO
            TableLayoutPanel1.Controls.Add(txtE5(c), 9, c)
        Next
    End Sub
    Public txtH6(9) As TextBox
    Public txtE6(9) As TextBox
    Public Sub CreartxtH6()
        Dim c As Integer
        For c = 1 To 9
            txtH6(c) = New TextBox()
            txtH6(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH6(c), 10, c)
            txtE6(c) = New TextBox()
            txtE6(c).Width = 45
            txtH6(c).BackColor = G_VERDE_CLARITO
            txtE6(c).BackColor = G_VERDE_CLARITO
            TableLayoutPanel1.Controls.Add(txtE6(c), 11, c)
        Next
    End Sub
    Public txtH7(9) As TextBox
    Public txtE7(9) As TextBox
    Public Sub CreartxtH7()
        Dim c As Integer
        For c = 1 To 9
            txtH7(c) = New TextBox()
            txtH7(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtH7(c), 12, c)
            txtE7(c) = New TextBox()
            txtE7(c).Width = 45
            txtH7(c).BackColor = G_VERDE_CLARITO
            txtE7(c).BackColor = G_VERDE_CLARITO
            TableLayoutPanel1.Controls.Add(txtE7(c), 13, c)
        Next
    End Sub

    Public txtTHP(9) As TextBox
    Public txtTEP(9) As TextBox
    Public Sub CreartxtTHP()
        Dim c As Integer
        For c = 1 To 9
            txtTHP(c) = New TextBox()
            txtTHP(c).Width = 45
            TableLayoutPanel1.Controls.Add(txtTHP(c), 14, c)
            txtTEP(c) = New TextBox()
            txtTEP(c).Width = 45
            txtTHP(c).BackColor = G_ROSA_CLARITO
            txtTEP(c).BackColor = G_ROSA_CLARITO
            TableLayoutPanel1.Controls.Add(txtTEP(c), 15, c)
        Next
    End Sub

    ' Dim txtDia(7) As TextBox

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PersonBSEDataSetWeb.EMPLEADOS_WEB' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOS_WEBTableAdapter.Fill(Me.PersonBSEDataSetWeb.EMPLEADOS_WEB)
        'TODO: esta línea de código carga datos en la tabla 'PersonBSEDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter.Fill(Me.PersonBSEDataSet.EMPLEADOS)
        Me.EMPLEADOSTableAdapter.FillByEmpleados(Me.PersonBSEDataSet.EMPLEADOS)
        Me.EMPLEADOS_WEBTableAdapter.FillByEmpleadosWeb(Me.PersonBSEDataSetWeb.EMPLEADOS_WEB)
        '
        'name:      EMPHORAS
        'descr:     rellenar parte de horas
        'author:    pantxo
        'date:      may/14
        '
        gModulo = "EMPHORAS> "
        'Dim pronam = gModulo
        '    MENU.newver = "v1.0 (2014/05/02)"
        ' control BdD web y personal
        Dim newver = "v2 (2018/01/29)"

        Dim gReloj = 0
        '    Me.Top = 0
        '    Me.Left = 0

        ColorAnt = picBoton.BackColor

        Dim numbers(4) As TextBox


        CrearLabel()
        'CrearCbProy()
        CreartxtTH()
        CreartxtTE()
        CreartxtDia()
        CreartxtH1()
        CreartxtH2()
        CreartxtH3()
        CreartxtH4()
        CreartxtH5()
        CreartxtH6()
        CreartxtH7()
        CreartxtTHP()




        RellenarAño(cbAño)
        RellenarMes(cbMes)
        ListaProyectos(0)
        'ListaEmpleados(cbEmp, "")
        cbEmp.SelectedValue = -1
        cbEmp.SelectedText = ""
        cbId.Text = ""

        cbAño.Text = Year(Now)
        cbMes.SelectedIndex = Month(Now) - 1

        If sPER = "" Then bWeb = True


        If bWeb Then
            Me.BackColor = G_ROSA
            Picture2.BackColor = G_ROSA
            txBD.Text = "DATOS BD WEB"
        Else
            Me.BackColor = G_VERDE_CLARO
            Picture2.BackColor = G_VERDE_CLARO
            txBD.Text = "DATOS BD PERSONAL"
        End If
    End Sub

    Private Sub Form_Unload(Cancel As Integer)
        'por defecto, la base de datos de Personal
        sPER = "P_"
        bWeb = False
    End Sub

    Private Sub bSalir_Click()
        Me.Close()

    End Sub
    Public Sub CreartxtTH()

        For n = 0 To 9
            txtTH(n) = New TextBox()
            txtTH(n).Text = n

        Next
    End Sub
    Private Sub bChgBD_Click(sender As Object, e As EventArgs) Handles bChgBD.Click
        gReloj = 0
        If sPER = "" Then
            bWeb = False
            sPER = "P_"
            Me.BackColor = G_VERDE_CLARO
            Picture2.BackColor = G_VERDE_CLARO
            txBD.Text = "DATOS BD PERSONAL"
            Me.EMPLEADOSTableAdapter.GetDataByEmpleados()
            cbEmp.DataSource = EMPLEADOSTableAdapter.GetDataByEmpleados()
            Me.cbEmp.DisplayMember = "NOMBRECOMPLETO"

        Else
            bWeb = True
            sPER = ""
            Me.BackColor = G_ROSA
            Picture2.BackColor = G_ROSA
            txBD.Text = "DATOS BD WEB"
            Me.EMPLEADOS_WEBTableAdapter.GetDataByEmpleadosWeb()
            cbEmp.DataSource = EMPLEADOS_WEBTableAdapter.GetDataByEmpleadosWeb()
            Me.cbEmp.DisplayMember = "NOMBRE"
        End If
        cbMes_SelectedIndexChanged()
    End Sub

    Private Sub cbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAño.SelectedIndexChanged
        cbMes_SelectedIndexChanged()
    End Sub

    Private Sub cbEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmp.SelectedIndexChanged
        LimpiarDatos()

        EmpId = CType(cbEmp.SelectedValue, Integer)

        DatosOtroUsuario(EmpId, EmpNom, EmpCalAct, EmpVac, EmpUbi)

        lbCal.Text = EmpCalAct
        ListaProyectos(EmpId)
        cbMes_SelectedIndexChanged()
        cbId.Text = EmpId
    End Sub

    Private Sub cbMes_SelectedIndexChanged() Handles cbMes.SelectedIndexChanged
        Dim fDia As Date
        Dim dia, i, j As Integer
        Dim tH As Single
        Dim bCerrado As Boolean

        If cbEmp.Text = "" Then Exit Sub

        dMes = cbMes.SelectedIndex + 1
        dAño = cbAño.Text

        If dAño < Year(Now) Then
            EmpCal = CalendarioEmpleadoAño(EmpId, dAño)
        Else
            EmpCal = EmpCalAct
        End If

        'EmpCal = "CAL_EXT"
        '    If MENU.lbBD.Caption = "DATOS WEB" Then
        If sPER = "" Then
            bCerrado = MesCerradoWEB(dMes, dAño, EmpUbi)
        Else
            bCerrado = MesCerrado(dMes, dAño)
        End If

        If bCerrado Then
            lbMsg.Text() = "EL MES DE " & UCase(MonthName(dMes)) & " ESTA CERRADO, NO SE PUEDEN REALIZAR MODIFICACIONES"
            cmdGrabar.Enabled = False
            cmdMes.Enabled = False
            cmdAbrirMes.Visible = True
        Else
            cmdGrabar.Enabled = True
            cmdMes.Enabled = True
            cmdAbrirMes.Visible = False
        End If

        fDia = DateSerial(dAño, dMes, 1)
        dia = Weekday(fDia)
        If dia = 1 Then
            dia = 7
        Else
            dia = dia - 1
        End If
        LimpiarDatos()
        'lbCal.Caption = EmpCal
        lbUbi.Text = EmpUbi
        ActualizarHoras_Emp(EmpId, dAño)

        For i = dia To 7
            txtDia(i - 1).Text = Format(fDia, "dd/MM/yy")
            If EsLaboral(fDia, EmpCal, tH) Then
                If Cargar_Horas_Dia(fDia, EmpId, i) Then
                    txtDia(i - 1).ForeColor = G_NEGRO
                    txtDia(i - 1).Font = New Font(txtDia(i - 1).Font, FontStyle.Regular)
                Else
                    txtDia(i - 1).ForeColor = G_ROJO
                    txtDia(i - 1).Font = New Font(txtDia(i - 1).Font, FontStyle.Bold)
                End If
            Else
                txtDia(i - 1).ForeColor = G_VERDE
                txtDia(i - 1).Font = New Font(txtDia(i - 1).Font, FontStyle.Bold)
            End If
            fDia = DateAdd("d", 1, fDia)
        Next
    End Sub

    'Private Sub cmdAbrirMes_Click()
    '    cmdGrabar.Enabled = True
    '    cmdAbrirMes.Visible = False
    '    cmdCerrarMes.Visible = True
    '    picBoton.BackColor = G_ROJO
    'End Sub

    'Private Sub cmdBloquear_Click()
    '    If BloquearHorasMes(EmpId, dMes, dAño, True) Then
    '        lbMsg.Text() = "HORAS BLOQUEADAS CORRECTAMENTE"
    '        If txtDia(6).Text <> "" Then
    '            SemanaAnterior(CDate((txtDia(6).Text)).AddDays(1))
    '        Else
    '            SemanaSiguiente(CDate((txtDia(6).Text)).AddDays(-1))
    '        End If
    '    Else
    '        lbMsg.Text() = "NO SE HAN PODIDO BLOQUEAR LAS HORAS"
    '    End If
    'End Sub

    Private Sub cmdCerrarMes_Click()
        cmdGrabar.Enabled = False
        cmdAbrirMes.Visible = True
        cmdCerrarMes.Visible = False
        picBoton.BackColor = ColorAnt
    End Sub

    Private Sub cmdComprobar_Click()
        Dim fil, col, totFil As Integer
        Dim oTxt As Object
        Dim oDia As TextBox
        Dim oLbl As Label
        Dim sNom As String
        Dim dTot, dTE, dTH As Double
        Dim Horas As Single

        Dim lbMsg = ""
        totFil = 0
        'fila 1
        For fil = 0 To NUMFIL
            If cbProy(fil).SelectedIndex <> -1 Then
                totFil = totFil + 1
                dTot = 0
                dTE = 0
                dTH = 0
                For col = 0 To 6
                    If txtDia(col).Text <> "" And txtDia(col).Font.Bold = False Then
                        sNom = "txtE" & CStr(col + 1)
                        For Each oTxt In Me.Controls
                            If Mid(oTxt.Name, 1, 5) = sNom Then
                                If IsNumeric(oTxt.text) And oTxt.Index = fil Then
                                    dTE = dTE + PuntoPorComa(oTxt.text)
                                    Exit For
                                End If
                            End If
                        Next
                        sNom = "txtH" & CStr(col + 1)
                        For Each oTxt In Me.Controls
                            If Mid(oTxt.Name, 1, 5) = sNom Then
                                If IsNumeric(oTxt.text) And oTxt.Index = fil Then
                                    dTH = dTH + PuntoPorComa(oTxt.text)
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                Next
                txtTHP(fil).Text = dTH
                txtTEP(fil).Text = dTE
            End If
        Next

        'por dia
        For col = 0 To 6
            dTot = 0
            dTE = 0
            dTH = 0
            If txtDia(col).Text <> "" And txtDia(col).Font.Bold = False Then
                For fil = 0 To totFil - 1
                    sNom = "txtH" & CStr(col + 1)
                    For Each oTxt In Me.Controls
                        If Mid(oTxt.Name, 1, 5) = sNom Then
                            If IsNumeric(oTxt.text) And oTxt.Index = fil Then
                                dTH = dTH + PuntoPorComa(oTxt.text)
                                Exit For
                            End If
                        End If
                    Next
                    sNom = "txtE" & CStr(col + 1)
                    For Each oTxt In Me.Controls
                        If Mid(oTxt.Name, 1, 5) = sNom Then
                            If IsNumeric(oTxt.text) And oTxt.Index = fil Then
                                dTE = dTE + PuntoPorComa(oTxt.text)
                                Exit For
                            End If
                        End If
                    Next
                Next
                If EsLaboral(CDate(txtDia(col).Text), EmpCal, Horas) Then
                    If Horas < dTH Then
                        lbMsg = "Las horas introducidas superan las permitidas"
                        txtTH(col).ForeColor = vbRed
                        txtTH(col).Font = New Font(txtTH(col).Font, FontStyle.Bold)
                    Else
                        txtTH(col).ForeColor = vbBlack
                        txtTH(col).Font = New Font(txtTH(col).Font, FontStyle.Regular)
                    End If
                End If
                txtTH(col).Text = dTH
                txtTE(col).Text = dTE
            End If
        Next

        dTot = 0
        For col = 0 To 6
            If IsNumeric(txtTH(col).Text) Then
                dTot = dTot + PuntoPorComa(txtTH(col).Text)
            End If
        Next
        txtTTH.Text = dTot

        dTot = 0
        For col = 0 To 6
            If IsNumeric(txtTE(col).Text) Then
                dTot = dTot + PuntoPorComa(txtTE(col).Text)
            End If
        Next
        txtTTE.Text = dTot
    End Sub

    Private Sub cmdDesb_Click()
        If BloquearHorasMes(EmpId, dMes, dAño, False) Then
            lbMsg.Text() = "HORAS DESBLOQUEADAS CORRECTAMENTE"
            If txtDia(6).Text <> "" Then
                SemanaAnterior(CDate((txtDia(6).Text)).AddDays(1))
            Else
                SemanaSiguiente(CDate((txtDia(6).Text)).AddDays(-1))
            End If
        Else
            lbMsg.Text() = "NO SE HAN PODIDO DESBLOQUEAR LAS HORAS"
        End If
    End Sub

    Private Sub cmdGrabar_Click()
        Dim i, col, fil As Integer
        Dim sNom As String
        Dim oTxt As Object
        Dim dTH, dTE As Single
        Dim sSql() As String
        Dim sDel As String
        Dim nS As Integer
        Dim rv As Boolean
        Dim dFec As Date
        Dim sCom As String
        Dim bSql As Boolean

        bSql = EsSQLServer(dbHoras)

        'comprobar datos antes de grabar
        Dim Mensaje = ""
        For i = 0 To 6
            txtTH(i).Font = New Font(txtTH(i).Font, FontStyle.Regular)
        Next
        cmdComprobar_Click()

        For i = 0 To 6
            If txtTH(i).Font.Bold = True Then
                lbMsg.Text() = "Tiene algunos errores en las horas introducidas"
                Exit Sub
            End If
        Next

        nS = 0
        'guardar datos
        'por dia
        For col = 0 To 6
            If txtDia(col).Text <> "" And txtDia(col).Font.Bold = False Then
                'borrar horas actuales
                dFec = CDate(txtDia(col).Text)
                sDel = "DELETE from " & sPER & "HORAS_" & CStr(dAño) & " WHERE fecha=" & FormatFecha(dFec, bSql) &
                    " and bloqueo=0 and Matricula=" & CStr(EmpId) & " and proyecto<>'S00002'"
                'Execute the SQL statement
                If EjecutarSql(sDel) Then
                    For fil = 0 To NUMFIL
                        If lbC(fil).Text() <> "" And lbC(fil).Text() <> "0" Then
                            dTH = 0
                            dTE = 0
                            sNom = "txtH" & CStr(col + 1)
                            For Each oTxt In Me.Controls
                                If Mid(oTxt.Name, 1, 5) = sNom Then
                                    If IsNumeric(oTxt.text) And oTxt.Index = fil Then
                                        dTH = CSng(PuntoPorComa(oTxt.text))
                                        sCom = oTxt.ToolTipText
                                        Exit For
                                    End If
                                End If
                            Next
                            sNom = "txtE" & CStr(col + 1)
                            For Each oTxt In Me.Controls
                                If Mid(oTxt.Name, 1, 5) = sNom Then
                                    If IsNumeric(oTxt.text) And oTxt.Index = fil Then
                                        dTE = CSng(PuntoPorComa(oTxt.text))
                                        Exit For
                                    End If
                                End If
                            Next

                            If dTH <> 0 Or dTE <> 0 Then
                                If lbC(fil).Text() <> "S00002" Then
                                    ReDim Preserve sSql(nS)
                                    sSql(nS) = "insert into " & sPER & "HORAS_" & CStr(dAño) & " values (" & CStr(EmpId) & "," _
                                    & FormatFecha(dFec, bSql) & ",'" & lbC(fil).Text() & "'," & ComaPorPunto(dTH) &
                                    "," & ComaPorPunto(dTE) & ",0,'" & sCom & "'," & CStr(DatePart("ww", dFec, vbMonday)) & ",0);"
                                    nS = nS + 1
                                    'Execute the SQL statement
                                    'rv = EjecutarSql(sSql)
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Next

        If nS <> 0 Then
            If EjecutarSqlTrans(sSql, nS) Then
                Mensaje = "Proceso terminado correctamente"
            Else
                Mensaje = "NO SE HAN PODIDO INTRODUCIR LOS DATOS EN LA BD"
            End If
        End If

        If txtDia(6).Text <> "" Then
            SemanaSiguiente(CDate(txtDia(6).Text))
        End If
    End Sub

    'Private Sub cmdLimpiar_Click()
    '    LimpiarDatos()
    'End Sub

    Private Sub cmdListaHoras_Click()
        If cbId.Text <> "" Then
            gEmpId = EmpId
            gAño = dAño
            gMes = dMes
            gEmpNom = EmpNom
            'LISHORASP.Show()
        End If
    End Sub

    Private Sub cmdMes_Click()
        Dim pMes As Date
        Dim fMes As Date
        Dim numDias As Integer
        Dim i As Integer
        Dim tH As Single, HIntro As Single, HFaltan As Single
        Dim sSql() As String
        Dim nS As Integer
        Dim bSql As Boolean

        bSql = EsSQLServer(dbHoras)
        If lbC(0).Text() = "S00002" Then
            MsgBox("NO SE`PUEDE ASIGNAR TODO EL MES A VACACIONES", vbInformation)
            Exit Sub
        End If

        If MsgBox("El PROYECTO AL QUE VAS ASIGNAR TODO EL MES ES: " & cbProy(0).Text & vbCrLf &
      "ESTAS SEGURA ? ", vbYesNo + vbInformation) = vbNo Then Exit Sub

        If cbProy(0).Text <> "" Then
            pMes = DateSerial(dAño, dMes, 1)
            fMes = DateSerial(dAño, dMes + 1, 1)
            numDias = DateDiff("d", pMes, fMes) - 1
            fMes = DateAdd("d", numDias, pMes)
            nS = 0
            For i = 0 To numDias
                If EsLaboral(pMes, EmpCal, tH) Then
                    HIntro = Horas_del_dia(pMes, EmpId)
                    HFaltan = tH - HIntro
                    If HFaltan > 0 Then
                        ReDim Preserve sSql(nS)
                        sSql(nS) = "insert into " & sPER & "HORAS_" & CStr(dAño) & " values (" & CStr(EmpId) & "," _
                               & FormatFecha(pMes, bSql) & ",'" & lbC(0).Text() & "'," & ComaPorPunto(CStr(HFaltan)) &
                               ",0,0,''," & CStr(DatePart("ww", pMes, vbMonday)) & ",0);"
                        nS = nS + 1
                    End If
                End If
                pMes = DateAdd("d", 1, pMes)
            Next

            If nS <> 0 Then
                If EjecutarSqlTrans(sSql, nS) Then
                    lbMsg.Text() = "Proceso terminado correctamente"
                    cbMes_SelectedIndexChanged()
                Else
                    lbMsg.Text() = "NO SE HAN PODIDO INTRODUCIR LOS DATOS EN LA BD"
                End If
            End If
        End If
    End Sub

    Private Sub cmdPonerCero_Click()
        Dim i As Integer
        Dim oObj As Control
        Dim toolTip1 As New ToolTip()
        toolTip1.Show("", oObj)
        For Each oObj In Me.Controls
            If Mid(oObj.Name, 1, 3) = "txt" Then
                If (Mid(oObj.Name, 1, 4) = "txtE" Or Mid(oObj.Name, 1, 4) = "txtH") And oObj.Enabled = True Then
                    If IsNumeric(oObj.Text) Then
                        oObj.Text = "0"
                        oObj.Tag = ""
                        toolTip1.SetToolTip(oObj, "")

                    End If
                End If
            End If
        Next
    End Sub

    Private Sub cmdSemAnt_Click(sender As Object, e As EventArgs) Handles cmdSemAnt.Click
        If txtDia(0).Text = "" Then Exit Sub

        SemanaAnterior(CDate(txtDia(0).Text))
    End Sub


    Private Sub SemanaAnterior(sFec As Date)
        Dim fDia As Date
        Dim uDia As Date
        Dim numDias, i As Integer
        Dim oTxt As String
        Dim oCtrl As TextBox
        Dim tH As Single
        ' Dim rs As New ADODB.Recordset
        'Dim resp As VbMsgBoxResult

        fDia = sFec
        fDia = DateAdd("d", -1, fDia)
        If Month(fDia) <> cbMes.SelectedIndex + 1 Then Exit Sub

        uDia = DateSerial(Year(fDia), Month(fDia), 1)
        LimpiarDatos()
        lbCal.Text = EmpCal
        lbUbi.Text = EmpUbi

        'LimpiarHoras()
        For i = 6 To 0 Step -1
            txtDia(i).Text = Format(fDia, "dd/MM/yy")
            If EsLaboral(fDia, EmpCal, tH) Then
                If Cargar_Horas_Dia(fDia, EmpId, i + 1) Then
                    txtDia(i).Font = New Font(txtDia(i).Font, FontStyle.Regular)
                    txtDia(i).ForeColor = G_NEGRO
                Else
                    txtDia(i).Font = New Font(txtDia(i).Font, FontStyle.Bold)
                    txtDia(i).ForeColor = G_ROJO
                End If
            Else
                txtDia(i).Font = New Font(txtDia(i).Font, FontStyle.Bold)
                txtDia(i).ForeColor = G_VERDE
            End If
            fDia = DateAdd("d", -1, fDia)
            If fDia < uDia Then
                Exit For
            End If
        Next
    End Sub


    Private Sub cmdSemSig_Click(sender As Object, e As EventArgs) Handles cmdSemSig.Click
        If txtDia(6).Text = "" Then Exit Sub

        SemanaSiguiente(CDate(txtDia(6).Text))
    End Sub


    Private Sub SemanaSiguiente(sFec As Date)
        Dim fDia As Date
        Dim uDia As Date
        Dim numDias, i As Integer
        Dim oTxt As String
        Dim oCtrl As TextBox
        Dim tH As Single


        fDia = sFec
        fDia = DateAdd("d", 1, fDia)
        Dim M = Month(fDia)
        Dim b = cbMes.SelectedIndex + 1

        If Month(fDia) <> cbMes.SelectedIndex + 1 Then Exit Sub

        uDia = DateSerial(Year(fDia), Month(fDia) + 1, 1)
        numDias = DateDiff("d", fDia, uDia)
        uDia = DateAdd("d", numDias - 1, fDia)
        LimpiarDatos()
        lbCal.Text = EmpCal
        lbUbi.Text = EmpUbi

        'LimpiarHoras()
        For i = 0 To 6
            txtDia(i).Text = Format(fDia, "dd/MM/yy")
            If EsLaboral(fDia, EmpCal, tH) Then
                If Cargar_Horas_Dia(fDia, EmpId, i + 1) Then
                    txtDia(i).Font = New Font(txtDia(i).Font, FontStyle.Regular)
                    txtDia(i).ForeColor = vbBlack
                Else
                    txtDia(i).Font = New Font(txtDia(i).Font, FontStyle.Bold)
                    txtDia(i).ForeColor = vbRed
                End If
            Else
                txtDia(i).Font = New Font(txtDia(i).Font, FontStyle.Bold)
                txtDia(i).ForeColor = G_VERDE
            End If
            fDia = DateAdd("d", 1, fDia)
            If fDia > uDia Then
                Exit For
            End If
        Next
    End Sub

    'Private Sub cbProy_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim fDia As Date
    '    fDia = DateTime.Now


    '    dMes = cbMes.SelectedIndex + 1
    '    dAño = cbAño.Text

    '    Dim año As Integer = Year(fDia)
    '    Dim nId As Integer = 1
    '    Dim con As IDbConnection
    '    con = New SqlConnection(gConexion)
    '    sPER = "P_"
    '    Using (con)

    '        con.Open()

    '        Dim com As IDbCommand = con.CreateCommand()

    '        com.CommandText = "SELECT " & sPER & "HORAS_" & CStr(año) & ".*, PROYECTOS.Nombre_Proyecto " &
    '      "FROM " & sPER & "HORAS_" & CStr(año) & " LEFT JOIN PROYECTOS ON " & sPER & "HORAS_" & CStr(año) & ".Proyecto = PROYECTOS.Código_Proyecto " &
    '      "WHERE " & sPER & "HORAS_" & CStr(año) & ".Matricula=" & CStr(nId) &
    '      " and fecha=" & FormatFecha(fDia, True) & " order by proyectos.código_Proyecto;"

    '        Dim dr As IDataReader = com.ExecuteReader()

    '        Dim dia As Integer
    '        For i = dia To 7
    '            txtDia(i - 1).Text = Format(fDia, "dd/MM/yy")
    '            If EsLaboral(fDia, EmpCal, 3) Then
    '                If Cargar_Horas_Dia(fDia, EmpId, i) Then
    '                    txtDia(i - 1).ForeColor = G_NEGRO
    '                    txtDia(i - 1).Font = New Font(txtDia(i - 1).Font, FontStyle.Regular)
    '                Else
    '                    txtDia(i - 1).ForeColor = G_ROJO
    '                    txtDia(i - 1).Font = New Font(txtDia(i - 1).Font, FontStyle.Bold)
    '                End If
    '            Else
    '                txtDia(i - 1).ForeColor = G_VERDE
    '                txtDia(i - 1).Font = New Font(txtDia(i - 1).Font, FontStyle.Bold)
    '            End If
    '            fDia = DateAdd("d", 1, fDia)
    '        Next



    '        If dr.Read() Then

    '        End If
    '    End Using


    'End Sub

    Private Function Cargar_Horas_Dia(ByVal dia As Date, ByVal nId As Integer, ByVal col As Integer) As Boolean

        Dim sNom As String
        Dim fil, pro_act, dPr As Integer
        Dim oObj As Object
        Dim encontrado As Integer
        Dim Horas As Single

        Dim año As Integer = Year(dia)

        Cargar_Horas_Dia = True
        EsLaboral(dia, EmpCal, Horas)

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)

        Using (con)

            con.Open()

            Dim com As IDbCommand = con.CreateCommand()

            com.CommandText = "SELECT " & sPER & "HORAS_" & CStr(año) & ".*, PROYECTOS.Nombre_Proyecto " &
          "FROM " & sPER & "HORAS_" & CStr(año) & " LEFT JOIN PROYECTOS ON " & sPER & "HORAS_" & CStr(año) & ".Proyecto = PROYECTOS.Código_Proyecto " &
          "WHERE " & sPER & "HORAS_" & CStr(año) & ".Matricula=" & CStr(nId) &
          " and fecha=" & FormatFecha(dia, True) & " order by proyectos.código_Proyecto;"

            Dim dr As IDataReader = com.ExecuteReader()
            Dim vacio As Boolean = True

            If dr.Read() Then
                Do
                    For fil = 0 To NUMFIL
                        If lbC(fil).Text() = "" Then
                            encontrado = -1
                            pro_act = fil
                            Exit For
                        End If
                        If lbC(fil).Text() = dr("Proyecto").ToString() Then
                            encontrado = fil
                            Exit For
                        End If
                    Next

                    If encontrado = -1 Then
                        'nuevo proyecto
                        fil = pro_act
                        If IsNothing(dr("Nombre_proyecto")) Then
                            cbProyVal.Items.Add(dr("Proyecto"))
                            For i = 0 To NUMFIL
                                cbProy(i).Items.Add(dr("Proyecto").ToString() & "| - FALTA EN BD")
                            Next
                        End If
                        lbC(fil).Text() = dr("Proyecto")
                        'On Error Resume Next
                        cbProyVal.Text = ""
                        cbProyVal.Text = lbC(fil).Text()
                        cbProy(fil).SelectedIndex() = cbProyVal.SelectedIndex()
                        'On Error GoTo 0
                        lbC(fil).Text() = dr("Proyecto")
                    Else
                        'el proyecto ya existe
                        fil = encontrado
                    End If
                    'cargar horas al proyecto y dia
                    For Each oObj In Me.TableLayoutPanel1.Controls
                        If Mid(oObj.Name, 1, 4) = "txtH" Then
                            If oObj.Name = "txtH" + CStr(col) And oObj.Index = fil Then
                                Exit For
                            End If
                        End If
                    Next
                    oObj.text = Format(dr("horas"), "#0.00")
                    If dr("Comentarios").ToString() <> "" Then
                        oObj.ToolTipText = dr("Comentarios")
                        oObj.ForeColor = vbBlack
                        oObj.BackColor = G_AZUL
                    End If
                    oObj.Enabled = True
                    If dr("bloqueo").ToString = True Then
                        If dr("proyecto").ToString <> "S00002" Then
                            Cargar_Horas_Dia = False
                        End If
                        oObj.Enabled = False
                    End If
                    For Each oObj In Me.Controls
                        If Mid(oObj.Name, 1, 4) = "txtE" Then
                            If oObj.Name = "txtE" + CStr(col) And oObj.Index = fil Then
                                Exit For
                            End If
                        End If
                    Next
                    oObj.text = Format(dr("horasextras"), "#0.00")
                    oObj.Enabled = True
                    If dr("bloqueo").ToString = True Then
                        If dr("proyecto").ToString <> "S00002" Then
                            Cargar_Horas_Dia = False
                        Else
                            If dr("horas").ToString = Horas Then
                                Cargar_Horas_Dia = False
                            End If
                        End If
                        oObj.Enabled = False
                    End If

                Loop While (dr.Read())

            Else
                If EsLaboral(dia, EmpCal, Horas) Then
                    'cargar horas por defecto
                    For fil = 0 To NUMFIL
                        If lbC(fil).Text() = "" Then
                            pro_act = fil
                            Exit For
                        End If
                    Next
                    For Each oObj In Me.TableLayoutPanel1.Controls
                        If Mid(oObj.Name, 1, 4) = "txtH" Then
                            If oObj.Name = "txtH" + CStr(col) And oObj.Index = pro_act Then
                                Exit For
                            End If
                        End If
                    Next
                    oObj.text = CStr(Horas)

                    Cargar_Horas_Dia = True
                    oObj.Enabled = True
                End If

            End If

        End Using

    End Function

    Private Sub ListaProyectos(id As Integer)
        Dim con As IDbConnection = New SqlConnection(gConexion)
        Using (con)

            con.Open()

            Dim com As IDbCommand = con.CreateCommand()

            'com.CommandText = "SELECT PROYECTOS.*, ACTIVO" &
            '" FROM PROYECTOS INNER JOIN PROYECTOS_EMPLEADOS ON PROYECTOS.Código_Proyecto = PROYECTOS_EMPLEADOS.CODIGO_PROYECTO " &
            '" WHERE PROYECTOS_EMPLEADOS.MATRICULA=" & CStr(id) & " order by fecha_fin, activo, código_proyecto;"
            com.CommandText = "SELECT PROYECTOS.Código_Proyecto as CODIGO,
                                      PROYECTOS.Nombre_Proyecto as NOMBRE,
                                      PROYECTOS.FECHA_FIN as FECHA_FIN FROM [PersonBSE].[dbo].[PROYECTOS] INNER JOIN [PersonBSE].[dbo].[PROYECTOS_EMPLEADOS] 
                                     On  [PersonBSE].[dbo].[PROYECTOS].Código_Proyecto = [PersonBSE].[dbo].[PROYECTOS_EMPLEADOS].CODIGO_PROYECTO
									 WHERE MATRICULA =" & CStr(id).ToString

            Dim dr As IDataReader = com.ExecuteReader()

            For a = 1 To NUMFIL
                cbProy(a).Items.Clear()
                cbProy(a).Items.Add("")
            Next

            While dr.Read()

                For a = 1 To NUMFIL

                    If (dr("FECHA_FIN")) Is Nothing Then
                        cbProy(a).Items.Add(dr("CODIGO").ToString() + "| * " + dr("NOMBRE").ToString) 'proyecto terminado

                    Else 'proyecto activo
                        cbProy(a).Items.Add(dr("CODIGO").ToString() + "| " + dr("NOMBRE").ToString())
                    End If

                    cbProy(a).SelectedIndex = 0

                Next

            End While

            'CargarIDProy(cbProyVal, dr)
        End Using
    End Sub

    'Public Sub CargarProy(ByRef Lista As ComboBox, ByRef dr As IDataReader)

    '    Lista.Items.Clear()
    '    'Lista.Items.Add("<sin proyecto>")
    '    Lista.Items.Add("")


    '    While (dr.Read())

    '        ' cbProy(i).Text = dr("Nombre_proyecto")
    '        If IsNothing(dr("FECHA_FIN")) Then
    '            Lista.Items.Add(dr("CODIGO").ToString() + "| * " + dr("NOMBRE").ToString) 'proyecto terminado
    '            'esto está deprecated
    '            'ElseIf rsP("ACTIVO")  Then
    '            'Lista.Items.Add(rsP("código_proyecto").ToString() + "| ** " + rsP("nombre_proyecto").ToString())
    '        Else 'proyecto activo
    '            Lista.Items.Add(dr("CODIGO").ToString() + "| " + dr("NOMBRE").ToString())
    '        End If

    '    End While
    '    Lista.SelectedIndex = 0

    'End Sub

    Public Sub CargarIDProy(ByVal Lista As ComboBox, ByVal rsP As ADODB.Recordset)
        Dim i As Integer

        rsP.MoveFirst()
        Lista.Items.Clear()
        Lista.Items.Add("")

        For i = 0 To rsP.RecordCount - 1
            Lista.Items.Add(rsP("código_proyecto"))
            rsP.MoveNext()
        Next
        Lista.SelectedIndex = 0
    End Sub

    Private Sub LimpiarDatos()
        Dim i As Integer
        Dim oObj As Control
        Dim tooltip1 As New ToolTip()
        Dim dia As TextBox
        For Each dia In txtDia
            If Not IsNothing(dia) Then
                dia.Text = ""
            End If
        Next

        For Each oObj In Me.TableLayoutPanel1.Controls


            If Mid(oObj.Name, 1, 3) = "txt" Then
                oObj.Text = ""
                'oObj.Alignment = 1
                oObj.ForeColor = vbBlack
                oObj.BackColor = G_VERDE
                oObj.Enabled = True
                oObj.Tag = ""
                tooltip1.SetToolTip(oObj, "")
            End If

            If Mid(oObj.Name, 1, 2) = "lb" Then
                oObj.Text = ""
            End If
            If Mid(oObj.Name, 1, 3) = "cbP" Then
                'oObj.ListIndex = -1
            End If
        Next
    End Sub

    Private Sub cbId_KeyPress(KeyAscii As Integer)
        Dim vbKeyReturn As Integer
        If KeyAscii = vbKeyReturn And IsNumeric(cbId) Then
            cbEmp.Text = ""
            BuscarEmpleado(CInt(IsNumeric(cbId)), cbEmp)
        End If
    End Sub

    Private Sub txtDia_DblClick(Index As Integer)
        Dim sUpd(1) As String
        Dim dDia As Date
        '    If MENU.lbBD = "DATOS WEB" Then
        If sPER = "" Then
            dDia = CDate(txtDia(Index).Text)
            If txtDia(Index).Font.Bold = True Then 'dia bloqueado
                If MsgBox("Quieres desbloquear el dia: " & txtDia(Index).Text & "?. (Se borra de personal)", vbYesNo) = vbYes Then
                    sUpd(0) = "update horas_" & CStr(Year(dDia)) & " set bloqueo=0, visado=0 where matricula= " & cbId.Text &
                    " and fecha='" & txtDia(Index).Text & "'"
                    sUpd(1) = "delete from p_horas_" & CStr(Year(dDia)) & " where matricula= " & cbId.Text &
                    " and fecha='" & txtDia(Index).Text & "'"
                    If Not EjecutarSqlTrans(sUpd, 2) Then
                        MsgBox("No se ha podido desbloquear el dia: " & txtDia(Index).Text, vbInformation)
                    Else
                        txtDia(Index).Font = New Font(txtDia(Index).Font, FontStyle.Regular)

                    End If
                End If
            Else  'no bloqueado
                If MsgBox("Quieres bloquear el dia: " & txtDia(Index).Text & "? (se inserta en personal)", vbYesNo) = vbYes Then
                    sUpd(0) = "update horas_" & CStr(Year(dDia)) & " set bloqueo=1, visado=1 where matricula= " & cbId.Text &
                    " and fecha='" & txtDia(Index).Text & "'"
                    sUpd(1) = "insert into p_horas_" & CStr(Year(dDia)) & " select * from horas_" & CStr(Year(dDia)) & " where matricula= " & cbId.Text &
                    " and fecha='" & txtDia(Index).Text & "'"
                    If Not EjecutarSqlTrans(sUpd, 2) Then
                        MsgBox("No se ha podido bloquear el dia: " & txtDia(Index).Text, vbInformation)
                    Else
                        txtDia(Index).Font = New Font(txtDia(Index).Font, FontStyle.Bold)
                    End If
                End If
            End If
            If txtDia(6).Text <> "" Then
                SemanaAnterior(DateAdd("d", 1, CDate(txtDia(6).Text)))
            Else
                SemanaSiguiente(DateAdd("d", -1, CDate(txtDia(0).Text)))
            End If
        End If
    End Sub

    Public Function DatosOtroUsuario(ByVal id As Integer, ByRef Nombre As String,
      ByRef cal As String, ByRef horasV As Single, ByRef ubi As String) As Boolean

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)

        Using (con)
            con.Open()
            Dim com As IDbCommand = con.CreateCommand()
            com.CommandText = "select * from empleados_web where Matricula=" & id
            Dim dr As IDataReader = com.ExecuteReader()
            DatosOtroUsuario = False
            While (dr.Read())
                cbId.Text = dr("Matricula")
                lbUbi.Text() = dr("Ubicacion")
                ubi = dr("Ubicacion")
                cal = dr("Calendario")
                horasV = dr("horas_vacaciones")
                DatosOtroUsuario = True
            End While
            dr.Dispose()
            dr.Close()

        End Using
    End Function

    Public Function MesCerrado(mes As Integer, año As Integer) As Boolean

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)

        Using (con)

            con.Open()

            Dim com2 As IDbCommand = con.CreateCommand()

            com2.CommandText = "select * from control_mes where  mes=" & CStr(mes) & " and año=" & CStr(año)

            Dim dr As IDataReader = com2.ExecuteReader()

            If Not dr.Read() Then
                MesCerrado = False
            Else
                MesCerrado = True
            End If
        End Using
    End Function

    Public Function CalendarioEmpleadoAño(id As Integer, dAño As Integer) As String
        Dim con As IDbConnection
        con = New SqlConnection(gConexion)

        Using (con)

            con.Open()

            Dim com As IDbCommand = con.CreateCommand()

            com.CommandText = "select * from vacaciones_hist where matricula=" & CStr(id) & " and año=" & CStr(dAño)

            Dim dr As IDataReader = com.ExecuteReader()
            CalendarioEmpleadoAño = "GEN"
            While (dr.Read())
                If IsDBNull(dr(3)) Then
                    CalendarioEmpleadoAño = "GEN"
                Else
                    CalendarioEmpleadoAño = dr(3)
                End If

            End While
            dr.Dispose()
            dr.Close()

        End Using


    End Function

    Public Function MesCerradoWEB(mes As Integer, año As Integer, sUbi As String) As Boolean
        Dim num As Integer
        Dim sMes As String

        If MesCerrado(mes, año) Then
            MesCerradoWEB = True
            Exit Function
        End If

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)
        Using (con)

            con.Open()

            Dim comWeb As IDbCommand = con.CreateCommand()
            sMes = "[" & CStr(mes) & "]"
            comWeb.CommandText = "select " & sMes & " from control_mes_ubi where ubicacion='" & sUbi & "' and año=" & CStr(año)

            Dim dr As IDataReader = comWeb.ExecuteReader()

            If Not dr.Read() Then
                dr.Close()

                MesCerradoWEB = False
                Dim com2 As IDbCommand = con.CreateCommand()
                com2.CommandText = "insert into control_mes_ubi values ('" & sUbi & "'," & CStr(año) & ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)"
                num = comWeb.ExecuteNonQuery()
            Else
                Do
                    If dr(0) = 0 Then
                        MesCerradoWEB = False
                    End If

                Loop While dr.Read()
            End If


        End Using
    End Function





    'Private Sub EMPHORAS_Load(sender As Object, e As EventArgs)
    '    'TODO: esta línea de código carga datos en la tabla 'PersonBSEDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
    '    Me.EMPLEADOSTableAdapter.Fill(Me.PersonBSEDataSet.EMPLEADOS)

    'End Sub

    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
    '    Try
    '        Me.EMPLEADOSTableAdapter.Fill(Me.PersonBSEDataSet.EMPLEADOS)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Public Function ActualizarHoras_Emp(ByVal id As Integer, año As Integer) As Boolean
        Dim sSql As String

        sSql = "delete  from " & sPER & "HORAS_" & CStr(año) & " where Matricula=" & CStr(id) & " and horas=0 and HorasExtras=0;"
        If EjecutarSql(sSql) Then
            ActualizarHoras_Emp = True
        Else
            ActualizarHoras_Emp = False
        End If
    End Function

    Public Function EjecutarSql(ByVal SQL As String) As Boolean
        On Error GoTo fallo
        dbHoras.ExecuteNonQuery(SQL)
        EjecutarSql = True
        Exit Function

fallo:
        EjecutarSql = False
    End Function

    'Private Sub EMPHORAS_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Public Function EsLaboral(ByVal fec As Date, ByVal cal As String, ByRef nH As Single) As Boolean
        Dim dY As Integer, dM As Integer, dD As Integer

        dY = Year(fec)
        dM = Month(fec)
        dD = fec.Day

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)
        '// :TODO
        cal = "MAD_8"
        Using (con)

            con.Open()

            Dim com As IDbCommand = con.CreateCommand()

            'com.CommandText = "select [" & CStr(dD) & "] from calendario_" & CStr(dY) & " where cal='" & cal & "' and id=" & dM & ";"
            com.CommandText = "select [" & CStr(dD) & "] from calendario_" & CStr(dY) & " where cal='" & cal & "' and id=" & dM & ";"

            Dim dr As IDataReader = com.ExecuteReader()

            EsLaboral = False

            While (dr.Read())
                If IsNumeric(dr(0)) Then
                    nH = PuntoPorComa(dr(0))
                    EsLaboral = True
                End If
            End While

        End Using





        'sSql = "select [" & CStr(dD) & "] from calendario_" & CStr(dY) & " where cal='" & cal & "' and id=" & dM & ";"
        'Using connection As New SqlConnection(gConexion)
        '    Dim command As New SqlCommand(sSql, connection)
        '    command.Connection.Open()
        '    command.ExecuteNonQuery()
        '    Dim Count = command.ExecuteScalar()

        '    If Count <> 0 Then
        '        If IsNumeric(rsCal(0)) Then
        '            nH = PuntoPorComa(rsCal(0))
        '            EsLaboral = True
        '        Else
        '            EsLaboral = False
        '        End If
        '    Else
        '        EsLaboral = False
        '    End If
        'End Using
        'rsCal.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'rsCal.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)
        'If rsCal.RecordCount <> 0 Then
        '    If IsNumeric(rsCal(0)) Then
        '        nH = PuntoPorComa(rsCal(0))
        '        EsLaboral = True
        '    Else
        '        EsLaboral = False
        '    End If
        'Else
        '    EsLaboral = False
        'End If
    End Function

    Public Function BloquearHorasMes(id As Integer, mes As Integer, año As Integer, valor As Boolean) As Boolean
        Dim sSql As String
        Dim pMes As Date
        Dim fMes As Date
        Dim numDias As Integer
        Dim bSql As Boolean

        bSql = EsSQLServer(dbHoras)

        pMes = DateSerial(año, mes, 1)
        fMes = DateSerial(año, mes + 1, 1)
        numDias = DateDiff("d", pMes, fMes)
        fMes = DateAdd("d", numDias, pMes)

        If valor Then
            sSql = "update " & sPER & "HORAS_" & CStr(año) & " set bloqueo=" & FormatSN(True, bSql) & ", visado=" &
                FormatSN(True, bSql) & " where Matricula=" & CStr(id) &
              " and (fecha>=" & FormatFecha(pMes, bSql) & " " &
              " and fecha<=" & FormatFecha(fMes, bSql) & ") and proyecto<>'S00002'"
        Else
            sSql = "update " & sPER & "HORAS_" & CStr(año) & " set bloqueo=" & FormatSN(False, bSql) & ", visado=" &
                FormatSN(False, bSql) & " where Matricula=" & CStr(id) &
              " and (fecha>=" & FormatFecha(pMes, bSql) & " " &
              " and fecha<=" & FormatFecha(fMes, bSql) & ") and proyecto<>'S00002'"
        End If

        BloquearHorasMes = EjecutarSql(sSql)
    End Function

    Public Function FormatFecha(dFec As Date, bWeb As Boolean) As String
        If bWeb Then
            FormatFecha = "'" & Format(dFec, "dd/MM/yyyy") & "'"
        Else
            FormatFecha = "#" & Format(dFec, "yyyy/MM/dd") & "#"
        End If
    End Function

    Public Function FormatSN(valor As Boolean, bWeb As Boolean) As String
        If bWeb Then
            If valor Then
                FormatSN = "1"
            Else
                FormatSN = "0"
            End If
        Else
            If valor Then
                FormatSN = "-1"
            Else
                FormatSN = "0"
            End If
        End If
    End Function

    Public Function ComaPorPunto(ByVal cad As String) As String
        Dim pos As Integer
        Dim sCad As String

        pos = InStr(1, cad, ",")
        If pos <> 0 Then
            ComaPorPunto = Mid(cad, 1, pos - 1) + "." + Mid(cad, pos + 1)
        Else
            ComaPorPunto = cad
        End If
    End Function

    Public Function EjecutarSqlTrans(SQL() As String, num As Integer) As Boolean
        Dim i As Integer

        On Error GoTo fallo
        dbHoras.BeginTrans()

        For i = 0 To num - 1
            dbHoras.ExecuteNonQuery(SQL(i))
        Next
        EjecutarSqlTrans = True
        dbHoras.CommitTrans()
        Exit Function

fallo:
        Dim Mensaje = "Error: " & Err.Number & " " & Err.Description & vbCrLf & SQL(i)

        'TODO: QURE SALGA ESTE MENSAJE

        'MsgBox(CType("Error: " & Err.Number & " " & Err.Description & vbCrLf & SQL(i)))
        dbHoras.RollbackTrans()
        EjecutarSqlTrans = False
    End Function

    Public Function Partes_del_dia(ByVal fDia As Date, ByVal id As Integer, ByRef dr As IDataReader) As Boolean

        Dim año As Integer
        año = Year(fDia)

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)

        Using (con)

            con.Open()

            Dim com As IDbCommand = con.CreateCommand()

            com.CommandText = "SELECT " & sPER & "HORAS_" & CStr(año) & ".*, PROYECTOS.Nombre_Proyecto " &
          "FROM " & sPER & "HORAS_" & CStr(año) & " LEFT JOIN PROYECTOS ON " & sPER & "HORAS_" & CStr(año) & ".Proyecto = PROYECTOS.Código_Proyecto " &
          "WHERE " & sPER & "HORAS_" & CStr(año) & ".Matricula=" & CStr(id) &
          " and fecha=" & FormatFecha(fDia, bWeb) & " order by proyectos.código_Proyecto;"

            dr = com.ExecuteReader()
            If IsDBNull(dr.Item(0)) Then
                Partes_del_dia = False
            Else
                Partes_del_dia = True
            End If

        End Using
    End Function

    '    bSql = EsSQLServer(dbHoras)
    '    año = Year(fDia)
    '    sSql = "SELECT " & sPER & "HORAS_" & CStr(año) & ".*, PROYECTOS.Nombre_Proyecto " &
    '      "FROM " & sPER & "HORAS_" & CStr(año) & " LEFT JOIN PROYECTOS ON " & sPER & "HORAS_" & CStr(año) & ".Proyecto = PROYECTOS.Código_Proyecto " &
    '      "WHERE " & sPER & "HORAS_" & CStr(año) & ".Matricula=" & CStr(id) &
    '      " and fecha=" & FormatFecha(fDia, bSql) & " order by proyectos.código_Proyecto;"

    '    rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '    rs.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)

    '    If rs.RecordCount <> 0 Then
    '        Partes_del_dia = True
    '    Else
    '        Partes_del_dia = False
    '    End If



    Public Function BuscarEmpleado(id As Integer, combo As ComboBox) As Boolean
        Dim i As Integer
        Dim enc As Boolean

        enc = False
        For i = 0 To combo.Items.Count - 1
            If combo.Items.Item(i) = id Then

                enc = True
                combo.SelectedIndex = i
                Exit For
            End If
        Next
        Return enc
    End Function

    Public Function Horas_del_dia(ByVal fDia As Date, ByVal id As Integer) As Single

        Dim bSql As Boolean
        Dim año As Integer
        año = Year(fDia)

        Dim con As IDbConnection
        con = New SqlConnection(gConexion)

        Using (con)

            con.Open()

            Dim com As IDbCommand = con.CreateCommand()

            com.CommandText = "SELECT sum(Horas) " &
            "FROM P_HORAS_" & CStr(año) &
            " WHERE Matricula=" & CStr(id) &
            " and fecha=" & FormatFecha(fDia, bSql) & ""
            'com.CommandText = "SELECT sum(Horas) " &
            '"FROM " & sPER & "HORAS_" & CStr(año) &
            '" WHERE Matricula=" & CStr(id) &
            '" and fecha=" & FormatFecha(fDia, bSql) & ""

            Dim dr As IDataReader = com.ExecuteReader()
            Horas_del_dia = 0
            While (dr.Read())
                If dr(0) IsNot Nothing Then
                    Horas_del_dia = dr(0)
                End If

            End While

        End Using


    End Function

    Public Function Vacaciones_del_dia(ByVal fDia As Date, ByVal id As Integer, ByVal DA As Integer) As Single
        Dim sSql As String
        Dim año As Integer
        Dim rs As New ADODB.Recordset
        Dim bSql As Boolean

        bSql = EsSQLServer(dbHoras)
        año = Year(fDia)

        sSql = "SELECT sum(Horas) " &
            "FROM " & sPER & "VACACIONES_" & CStr(DA) &
            " WHERE Matricula=" & CStr(id) &
            " and fecha=" & FormatFecha(fDia, bSql) & ""

        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.Open(sSql, dbHoras, ADODB.CursorTypeEnum.adOpenStatic)

        If Not IsDBNull(rs(0)) Then
            'Vacaciones_del_dia = CType(rs(0), )
            'TODO
        Else
            Vacaciones_del_dia = 0
        End If
    End Function

    Public Function Proyectos(dr As IDataReader) As Boolean

        Proyectos = False

        While (dr.Read())
            Proyectos = True
        End While

    End Function

    Private Sub cmdBloquear_Click(sender As Object, e As EventArgs) Handles cmdBloquear.Click
        If BotonBloqueado Then
            cmdBloquear.Text = "Desbloquear Mes"

            cmdGrabar.Enabled = True
            cmdAbrirMes.Visible = False
            cmdCerrarMes.Visible = True
            'picBoton.BackColor = G_ROJO
            BotonBloqueado = True
        ElseIf Not BotonBloqueado Then
            cmdBloquear.Text = "Bloquear Mes"
            BotonBloqueado = False
            If BloquearHorasMes(EmpId, dMes, dAño, True) Then
                lbMsg.Text() = "HORAS BLOQUEADAS CORRECTAMENTE"
                If txtDia(6).Text <> "" Then
                    SemanaAnterior(CDate((txtDia(6).Text)).AddDays(1))
                Else
                    SemanaSiguiente(CDate((txtDia(6).Text)).AddDays(-1))
                End If
            Else
                lbMsg.Text() = "NO SE HAN PODIDO BLOQUEAR LAS HORAS"
            End If
        End If
    End Sub
    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        LimpiarDatos()

    End Sub
    'Private Sub cmdDesb_Click(sender As Object, e As EventArgs) Handles cmdDesb.Click
    '    cmdGrabar.Enabled = True
    '    cmdAbrirMes.Visible = False
    '    cmdCerrarMes.Visible = True
    '    picBoton.BackColor = G_ROJO
    'End Sub









    'Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    'End Sub
End Class

