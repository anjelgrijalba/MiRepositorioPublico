'
' name:     Login
' author:   mregila (hasta jul/2013)
' descr:    control de acceso a la aplicación
' modif:    pantxo
' se añade versión en la cabecera
' se controla la salida del formato al finalizarlo
' al pulsar la X del from de login se accedía directamente a la aplicación
' para evitarlo se añade la variable gLogin
' version:  2.0 (2014/04/30)
'

Public Class Form_Login
    Inherits System.Windows.Forms.Form
    Dim dVeces As Int16 = 3
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(200, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USUARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Location = New System.Drawing.Point(200, 28)
        Me.txtUsuario.MaxLength = 25
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'txtCont
        '
        Me.txtCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCont.Location = New System.Drawing.Point(200, 72)
        Me.txtCont.MaxLength = 25
        Me.txtCont.Name = "txtCont"
        Me.txtCont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCont.Size = New System.Drawing.Size(220, 20)
        Me.txtCont.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(200, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CONTRASEÑA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(439, 28)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(105, 60)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(327, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCELAR"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCambiar
        '
        Me.btnCambiar.BackColor = System.Drawing.Color.White
        Me.btnCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar.ForeColor = System.Drawing.Color.Black
        Me.btnCambiar.Location = New System.Drawing.Point(439, 109)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(107, 35)
        Me.btnCambiar.TabIndex = 5
        Me.btnCambiar.Text = "CAMBIAR CONTRASEÑA"
        Me.btnCambiar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form_Login
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(558, 156)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonaBSE>"
        'Me.Icon = BOS.ico
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = gAplNam & gAplVers & "  >>> Inicio"
        txtUsuario.Text = gUsuario
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Dim passI As String
        Dim da2 As SqlClient.SqlDataAdapter

        Using ds2 As Data.DataSet = New Data.DataSet()
            Using form1 As New Form_contraseña()
                gUsuario = txtUsuario.Text
                gContraseña = txtCont.Text
                If dVeces <= 1 Then
                    usuario = ""
                    Me.Close()
                    Exit Sub
                End If
                'gusuario = ""
                Dim kselect As String = String.Format("Select nombre,contraseña from USUARIOS where nombre='{0}'", usuario)
                da2 = New SqlClient.SqlDataAdapter(kselect, dbConexion)
                ds2.Clear()
                da2.Fill(ds2, "Usuarios")
                If ds2.Tables(0).Rows.Count = 1 Then
                    If IsDBNull(ds2.Tables(0).Rows(0).Item("contraseña")) Or IsNothing(ds2.Tables(0).Rows(0).Item("contraseña")) Or Trim(ds2.Tables(0).Rows(0).Item("contraseña")) = "" Then
                        form1.ShowDialog()
                        Me.Close()
                        'Else
                        '    passI = Encripta(txtCont.Text)
                        '    If ds2.Tables(0).Rows(0).Item("contraseña") = passI Then
                        '        'gusuario = ds2.Tables(0).Rows(0).Item("id_usuario")
                        '        form1.ShowDialog()
                        '        Me.Close()
                        '    Else
                        '        dVeces = dVeces - 1
                        '        MsgBox("REVISE USUARIO Y CONTRASEÑA")
                        '        txtCont.Text = ""
                        '    End If
                    End If
                ElseIf ds2.Tables(0).Rows.Count = 2 Then
                Else
                    MsgBox("REVISE USUARIO Y CONTRASEÑA")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim gContraseña, passI As String
        Dim da2 As SqlClient.SqlDataAdapter

        Using ds2 As Data.DataSet = New Data.DataSet()
            Using form1 As New Form_contraseña()
                gUsuario = txtUsuario.Text
                gContraseña = txtCont.Text

                If dVeces <= 1 Then
                    gUsuario = ""
                    Me.Close()
                    Exit Sub
                End If
                Dim kselect As String = String.Format("select nombre,contraseña from USUARIOS where nombre='{0}'", gUsuario)
                da2 = New SqlClient.SqlDataAdapter(kselect, dbConexion)
                ds2.Clear()
                da2.Fill(ds2, "Usuarios")
                If ds2.Tables(0).Rows.Count = 1 Then
                    If IsDBNull(ds2.Tables(0).Rows(0).Item("contraseña")) Then
                        form1.ShowDialog()
                        Me.Close()
                    ElseIf IsNothing(ds2.Tables(0).Rows(0).Item("contraseña")) Or Trim(ds2.Tables(0).Rows(0).Item("contraseña")) = "" Then
                        form1.ShowDialog()
                        Me.Close()
                    Else
                        'passI = Encripta(txtCont.Text)
                        If ds2.Tables(0).Rows(0).Item("contraseña") <> gContraseña Then
                            dVeces = dVeces - 1
                            MessageBox.Show("REVISE USUARIO Y CONTRASEÑA")
                            txtCont.Text = ""
                            gUsuario = ""
                        Else
                            gLogin = gUsuario
                            Me.Close()
                        End If
                    End If
                Else
                    dVeces = dVeces - 1
                    MessageBox.Show("REVISE USUARIO Y CONTRASEÑA")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gUsuario = ""
        Me.Close()
        End
    End Sub

End Class







'Option Explicit On
'Public Class Form_Login

'    Dim usuario As String

'    Private Sub Form_Load()
'        '
'        'name:      APLLOG
'        'descr:     login en la aplicación
'        'author:    pantxo
'        'date:      may/14
'        '
'        gModulo = "APLLOG>"
'        Menu.pronam = gModulo
'        '    MENU.newver = "v1.0 (2014/05/02)"
'        ' se pone versión aplicación
'        Menu.newver = "v1.1 (2015/01/21)"

'        gReloj = 0
'        Me.Caption = Menu.aplnam + ">> " + Menu.aplver + " " + Menu.apldate
'        usuario = gUser
'        txtUserName.text = gUser
'    End Sub

'    Private Sub bSalir_Click()
'        usuario = ""
'        gPriv = -1
'        End
'    End Sub

'    Private Sub bOK_Click()
'        Dim kk As String, cc As String

'        usuario = txtUserName.text
'        Unload Me

'End Sub

'    Private Function Contraseña(sUsu As String) As String
'        Dim rsA As New ADODB.Recordset
'        Dim sSql As String, nivel As Integer

'        sSql = "select CONTRASEÑA, NIVEL from USUARIOS where NOMBRE='" & sUsu & "'"
'        rsA.CursorLocation = adUseClient
'        rsA.Open sSql, Menu.dbHoras, adOpenStatic, adLockReadOnly
'    If rsA.RecordCount <> 0 Then
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
