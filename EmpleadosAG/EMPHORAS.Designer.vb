<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPHORAS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Picture2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbAño = New System.Windows.Forms.Label()
        Me.cbAño = New System.Windows.Forms.ComboBox()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.lbEmp = New System.Windows.Forms.Label()
        Me.cbId = New System.Windows.Forms.TextBox()
        Me.cbEmp = New System.Windows.Forms.ComboBox()
        Me.EMPLEADOSWEBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBSEDataSetWeb = New EmpleadosAG.PersonBSEDataSetWeb()
        Me.lbUbi = New System.Windows.Forms.TextBox()
        Me.lbCal = New System.Windows.Forms.TextBox()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonBSEDataSet = New EmpleadosAG.PersonBSEDataSet()
        Me.EMPLEADOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdMes = New System.Windows.Forms.Button()
        Me.cmdAbrirMes = New System.Windows.Forms.Button()
        Me.cmdCerrarMes = New System.Windows.Forms.Button()
        Me.cmdSemAnt = New System.Windows.Forms.Button()
        Me.cmdSemSig = New System.Windows.Forms.Button()
        Me.cmdListaHoras = New System.Windows.Forms.Button()
        Me.cmdPonerCero = New System.Windows.Forms.Button()
        Me.cmdDesb = New System.Windows.Forms.Button()
        Me.cmdBloquear = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdComprobar = New System.Windows.Forms.Button()
        Me.picBoton = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbMsg = New System.Windows.Forms.Label()
        Me.cbProyVal = New System.Windows.Forms.ComboBox()
        Me.txtTTH = New System.Windows.Forms.TextBox()
        Me.txtTTE = New System.Windows.Forms.TextBox()
        Me.bChgBD = New System.Windows.Forms.Button()
        Me.txBD = New System.Windows.Forms.TextBox()
        Me.EMPLEADOSTableAdapter = New EmpleadosAG.PersonBSEDataSetTableAdapters.EMPLEADOSTableAdapter()
        Me.EMPLEADOS_WEBTableAdapter = New EmpleadosAG.PersonBSEDataSetWebTableAdapters.EMPLEADOS_WEBTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Picture2.SuspendLayout()
        CType(Me.EMPLEADOSWEBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBSEDataSetWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBoton.SuspendLayout()
        Me.SuspendLayout()
        '
        'Picture2
        '
        Me.Picture2.Controls.Add(Me.lbAño)
        Me.Picture2.Controls.Add(Me.cbAño)
        Me.Picture2.Controls.Add(Me.lbMes)
        Me.Picture2.Controls.Add(Me.cbMes)
        Me.Picture2.Controls.Add(Me.lbEmp)
        Me.Picture2.Controls.Add(Me.cbId)
        Me.Picture2.Controls.Add(Me.cbEmp)
        Me.Picture2.Controls.Add(Me.lbUbi)
        Me.Picture2.Controls.Add(Me.lbCal)
        Me.Picture2.Location = New System.Drawing.Point(12, 12)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.Size = New System.Drawing.Size(894, 45)
        Me.Picture2.TabIndex = 0
        '
        'lbAño
        '
        Me.lbAño.AutoSize = True
        Me.lbAño.Location = New System.Drawing.Point(3, 0)
        Me.lbAño.Name = "lbAño"
        Me.lbAño.Size = New System.Drawing.Size(26, 13)
        Me.lbAño.TabIndex = 0
        Me.lbAño.Text = "Año"
        '
        'cbAño
        '
        Me.cbAño.FormattingEnabled = True
        Me.cbAño.Location = New System.Drawing.Point(35, 3)
        Me.cbAño.Name = "cbAño"
        Me.cbAño.Size = New System.Drawing.Size(63, 21)
        Me.cbAño.TabIndex = 1
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(104, 0)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(27, 13)
        Me.lbMes.TabIndex = 2
        Me.lbMes.Text = "Mes"
        '
        'cbMes
        '
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(137, 3)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(109, 21)
        Me.cbMes.TabIndex = 3
        '
        'lbEmp
        '
        Me.lbEmp.AutoSize = True
        Me.lbEmp.Location = New System.Drawing.Point(252, 0)
        Me.lbEmp.Name = "lbEmp"
        Me.lbEmp.Size = New System.Drawing.Size(28, 13)
        Me.lbEmp.TabIndex = 4
        Me.lbEmp.Text = "Emp"
        '
        'cbId
        '
        Me.cbId.Location = New System.Drawing.Point(286, 3)
        Me.cbId.Name = "cbId"
        Me.cbId.Size = New System.Drawing.Size(36, 20)
        Me.cbId.TabIndex = 6
        '
        'cbEmp
        '
        Me.cbEmp.DataSource = Me.EMPLEADOSWEBBindingSource
        Me.cbEmp.DisplayMember = "NOMBRE"
        Me.cbEmp.FormattingEnabled = True
        Me.cbEmp.Location = New System.Drawing.Point(328, 3)
        Me.cbEmp.Name = "cbEmp"
        Me.cbEmp.Size = New System.Drawing.Size(334, 21)
        Me.cbEmp.TabIndex = 5
        Me.cbEmp.ValueMember = "MATRICULA"
        '
        'EMPLEADOSWEBBindingSource
        '
        Me.EMPLEADOSWEBBindingSource.DataMember = "EMPLEADOS_WEB"
        Me.EMPLEADOSWEBBindingSource.DataSource = Me.PersonBSEDataSetWeb
        '
        'PersonBSEDataSetWeb
        '
        Me.PersonBSEDataSetWeb.DataSetName = "PersonBSEDataSetWeb"
        Me.PersonBSEDataSetWeb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbUbi
        '
        Me.lbUbi.Location = New System.Drawing.Point(668, 3)
        Me.lbUbi.Name = "lbUbi"
        Me.lbUbi.Size = New System.Drawing.Size(100, 20)
        Me.lbUbi.TabIndex = 7
        '
        'lbCal
        '
        Me.lbCal.Location = New System.Drawing.Point(774, 3)
        Me.lbCal.Name = "lbCal"
        Me.lbCal.Size = New System.Drawing.Size(100, 20)
        Me.lbCal.TabIndex = 8
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.PersonBSEDataSet
        '
        'PersonBSEDataSet
        '
        Me.PersonBSEDataSet.DataSetName = "PersonBSEDataSet"
        Me.PersonBSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOSBindingSource1
        '
        Me.EMPLEADOSBindingSource1.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource1.DataSource = Me.PersonBSEDataSet
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(3, 3)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGrabar.TabIndex = 1
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdMes
        '
        Me.cmdMes.Location = New System.Drawing.Point(805, 63)
        Me.cmdMes.Name = "cmdMes"
        Me.cmdMes.Size = New System.Drawing.Size(91, 23)
        Me.cmdMes.TabIndex = 2
        Me.cmdMes.Text = "Actualizar Mes"
        Me.cmdMes.UseVisualStyleBackColor = True
        '
        'cmdAbrirMes
        '
        Me.cmdAbrirMes.Location = New System.Drawing.Point(12, 63)
        Me.cmdAbrirMes.Name = "cmdAbrirMes"
        Me.cmdAbrirMes.Size = New System.Drawing.Size(75, 23)
        Me.cmdAbrirMes.TabIndex = 3
        Me.cmdAbrirMes.Text = "Abrir Mes"
        Me.cmdAbrirMes.UseVisualStyleBackColor = True
        '
        'cmdCerrarMes
        '
        Me.cmdCerrarMes.Location = New System.Drawing.Point(616, 3)
        Me.cmdCerrarMes.Name = "cmdCerrarMes"
        Me.cmdCerrarMes.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrarMes.TabIndex = 4
        Me.cmdCerrarMes.Text = "Cerrar Mes"
        Me.cmdCerrarMes.UseVisualStyleBackColor = True
        '
        'cmdSemAnt
        '
        Me.cmdSemAnt.Location = New System.Drawing.Point(697, 3)
        Me.cmdSemAnt.Name = "cmdSemAnt"
        Me.cmdSemAnt.Size = New System.Drawing.Size(59, 23)
        Me.cmdSemAnt.TabIndex = 6
        Me.cmdSemAnt.Text = "Sem Ant"
        Me.cmdSemAnt.UseVisualStyleBackColor = True
        '
        'cmdSemSig
        '
        Me.cmdSemSig.Location = New System.Drawing.Point(762, 3)
        Me.cmdSemSig.Name = "cmdSemSig"
        Me.cmdSemSig.Size = New System.Drawing.Size(73, 23)
        Me.cmdSemSig.TabIndex = 7
        Me.cmdSemSig.Text = "Sem Sigu"
        Me.cmdSemSig.UseVisualStyleBackColor = True
        '
        'cmdListaHoras
        '
        Me.cmdListaHoras.Location = New System.Drawing.Point(489, 3)
        Me.cmdListaHoras.Name = "cmdListaHoras"
        Me.cmdListaHoras.Size = New System.Drawing.Size(75, 23)
        Me.cmdListaHoras.TabIndex = 8
        Me.cmdListaHoras.Text = "ListHora"
        Me.cmdListaHoras.UseVisualStyleBackColor = True
        '
        'cmdPonerCero
        '
        Me.cmdPonerCero.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmdPonerCero.Location = New System.Drawing.Point(408, 3)
        Me.cmdPonerCero.Name = "cmdPonerCero"
        Me.cmdPonerCero.Size = New System.Drawing.Size(75, 23)
        Me.cmdPonerCero.TabIndex = 9
        Me.cmdPonerCero.Text = "Pone0"
        Me.cmdPonerCero.UseVisualStyleBackColor = False
        '
        'cmdDesb
        '
        Me.cmdDesb.Location = New System.Drawing.Point(327, 3)
        Me.cmdDesb.Name = "cmdDesb"
        Me.cmdDesb.Size = New System.Drawing.Size(75, 23)
        Me.cmdDesb.TabIndex = 10
        Me.cmdDesb.Text = "Desbl"
        Me.cmdDesb.UseVisualStyleBackColor = True
        '
        'cmdBloquear
        '
        Me.cmdBloquear.Location = New System.Drawing.Point(246, 3)
        Me.cmdBloquear.Name = "cmdBloquear"
        Me.cmdBloquear.Size = New System.Drawing.Size(75, 23)
        Me.cmdBloquear.TabIndex = 11
        Me.cmdBloquear.Text = "Bloq"
        Me.cmdBloquear.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(165, 3)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 12
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdComprobar
        '
        Me.cmdComprobar.Location = New System.Drawing.Point(84, 3)
        Me.cmdComprobar.Name = "cmdComprobar"
        Me.cmdComprobar.Size = New System.Drawing.Size(75, 23)
        Me.cmdComprobar.TabIndex = 13
        Me.cmdComprobar.Text = "Comprobar"
        Me.cmdComprobar.UseVisualStyleBackColor = True
        '
        'picBoton
        '
        Me.picBoton.Controls.Add(Me.cmdGrabar)
        Me.picBoton.Controls.Add(Me.cmdComprobar)
        Me.picBoton.Controls.Add(Me.cmdLimpiar)
        Me.picBoton.Controls.Add(Me.cmdBloquear)
        Me.picBoton.Controls.Add(Me.cmdDesb)
        Me.picBoton.Controls.Add(Me.cmdPonerCero)
        Me.picBoton.Controls.Add(Me.cmdListaHoras)
        Me.picBoton.Controls.Add(Me.lbMsg)
        Me.picBoton.Controls.Add(Me.cmdCerrarMes)
        Me.picBoton.Controls.Add(Me.cmdSemAnt)
        Me.picBoton.Controls.Add(Me.cmdSemSig)
        Me.picBoton.Location = New System.Drawing.Point(2, 451)
        Me.picBoton.Name = "picBoton"
        Me.picBoton.Size = New System.Drawing.Size(894, 31)
        Me.picBoton.TabIndex = 14
        '
        'lbMsg
        '
        Me.lbMsg.AutoSize = True
        Me.lbMsg.Location = New System.Drawing.Point(570, 0)
        Me.lbMsg.Name = "lbMsg"
        Me.lbMsg.Size = New System.Drawing.Size(40, 13)
        Me.lbMsg.TabIndex = 14
        Me.lbMsg.Text = "Blanco"
        '
        'cbProyVal
        '
        Me.cbProyVal.FormattingEnabled = True
        Me.cbProyVal.Location = New System.Drawing.Point(22, 411)
        Me.cbProyVal.Name = "cbProyVal"
        Me.cbProyVal.Size = New System.Drawing.Size(121, 21)
        Me.cbProyVal.TabIndex = 15
        '
        'txtTTH
        '
        Me.txtTTH.Location = New System.Drawing.Point(753, 394)
        Me.txtTTH.Name = "txtTTH"
        Me.txtTTH.Size = New System.Drawing.Size(100, 20)
        Me.txtTTH.TabIndex = 16
        '
        'txtTTE
        '
        Me.txtTTE.Location = New System.Drawing.Point(753, 368)
        Me.txtTTE.Name = "txtTTE"
        Me.txtTTE.Size = New System.Drawing.Size(100, 20)
        Me.txtTTE.TabIndex = 17
        '
        'bChgBD
        '
        Me.bChgBD.Location = New System.Drawing.Point(12, 92)
        Me.bChgBD.Name = "bChgBD"
        Me.bChgBD.Size = New System.Drawing.Size(75, 23)
        Me.bChgBD.TabIndex = 18
        Me.bChgBD.Text = "bChgBD"
        Me.bChgBD.UseVisualStyleBackColor = True
        '
        'txBD
        '
        Me.txBD.Location = New System.Drawing.Point(289, 94)
        Me.txBD.Name = "txBD"
        Me.txBD.Size = New System.Drawing.Size(277, 20)
        Me.txBD.TabIndex = 19
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'EMPLEADOS_WEBTableAdapter
        '
        Me.EMPLEADOS_WEBTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 16
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 130)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        'Me.TableLayoutPanel1.Size = New System.Drawing.Size(320, 160)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'EMPHORAS
        '
        Me.ClientSize = New System.Drawing.Size(906, 483)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txBD)
        Me.Controls.Add(Me.bChgBD)
        Me.Controls.Add(Me.txtTTE)
        Me.Controls.Add(Me.txtTTH)
        Me.Controls.Add(Me.cbProyVal)
        Me.Controls.Add(Me.picBoton)
        Me.Controls.Add(Me.cmdAbrirMes)
        Me.Controls.Add(Me.cmdMes)
        Me.Controls.Add(Me.Picture2)
        Me.Name = "EMPHORAS"
        Me.Picture2.ResumeLayout(False)
        Me.Picture2.PerformLayout()
        CType(Me.EMPLEADOSWEBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBSEDataSetWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBoton.ResumeLayout(False)
        Me.picBoton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picture2 As FlowLayoutPanel
    Friend WithEvents lbAño As Label
    Friend WithEvents cbAño As ComboBox
    Friend WithEvents lbMes As Label
    Friend WithEvents cbMes As ComboBox
    Friend WithEvents lbEmp As Label
    Friend WithEvents cbEmp As ComboBox
    Friend WithEvents cbId As TextBox
    Friend WithEvents lbUbi As TextBox
    Friend WithEvents lbCal As TextBox
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdMes As Button
    Friend WithEvents cmdAbrirMes As Button
    Friend WithEvents cmdCerrarMes As Button
    Friend WithEvents cmdSemAnt As Button
    Friend WithEvents cmdSemSig As Button
    Friend WithEvents cmdListaHoras As Button
    Friend WithEvents cmdPonerCero As Button
    Friend WithEvents cmdDesb As Button
    Friend WithEvents cmdBloquear As Button
    Friend WithEvents cmdLimpiar As Button
    Friend WithEvents cmdComprobar As Button
    Friend WithEvents picBoton As FlowLayoutPanel
    Friend WithEvents lbMsg As Label
    Friend WithEvents cbProyVal As ComboBox
    Friend WithEvents txtTTH As TextBox
    Friend WithEvents txtTTE As TextBox
    Friend WithEvents bChgBD As Button
    Friend WithEvents txBD As TextBox
    Friend WithEvents PersonBSEDataSet As PersonBSEDataSet
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As PersonBSEDataSetTableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents EMPLEADOSBindingSource1 As BindingSource
    Friend WithEvents PersonBSEDataSetWeb As PersonBSEDataSetWeb
    Friend WithEvents EMPLEADOSWEBBindingSource As BindingSource
    Friend WithEvents EMPLEADOS_WEBTableAdapter As PersonBSEDataSetWebTableAdapters.EMPLEADOS_WEBTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    'Friend WithEvents txtDia As TextBox
End Class
