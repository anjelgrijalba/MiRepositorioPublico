'
' name:     Contraseña
' author:   mregila (hasta jul/2013)
' modif:    pantxo
' se modifica aspecto general
' version:  2.0 (2014/05/15)
'

Public Class Form_contraseña
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCont1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCont1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(441, 85)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 32)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtCont
        '
        Me.txtCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCont.Location = New System.Drawing.Point(202, 45)
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
        Me.Label2.Location = New System.Drawing.Point(202, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NUEVA CONTRASEÑA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCont1
        '
        Me.txtCont1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCont1.Location = New System.Drawing.Point(202, 97)
        Me.txtCont1.MaxLength = 25
        Me.txtCont1.Name = "txtCont1"
        Me.txtCont1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCont1.Size = New System.Drawing.Size(220, 20)
        Me.txtCont1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(202, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CONFIRMAR CONTRASEÑA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_contraseña
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(548, 130)
        Me.Controls.Add(Me.txtCont1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_contraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIAR CONTRASEÑA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim kselect, passI As String
        Dim da2 As SqlClient.SqlDataAdapter
        Dim ds2 As Data.DataSet

        If Trim(txtCont.Text) <> "" Then
            If txtCont.Text = txtCont1.Text Then
                kselect = "select nombre,contraseña from USUARIOS where nombre='" & gUsuario & "'"
                ds2 = New Data.DataSet
                da2 = New SqlClient.SqlDataAdapter(kselect, dbConexion)
                da2.Fill(ds2, "Usuarios")
                'passI = Encripta(txtCont.Text)
                'ds2.Tables(0).Rows(0).Item("contraseña") = passI

                Dim bdr As New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = bdr.GetUpdateCommand
                da2.InsertCommand = bdr.GetInsertCommand
                da2.DeleteCommand = bdr.GetDeleteCommand
                da2.Update(ds2, "Usuarios")
                ds2.AcceptChanges()
                Me.Close()
            Else
                MsgBox("La contraseña y la confirmacion de contraseña deben ser iguales")
                txtCont.Text = ""
                txtCont1.Text = ""
            End If
        Else
            MsgBox("La contraseña no puede estar en blanco")
        End If
    End Sub

    Private Sub Form_contraseña_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        gUsuario = ""
        Me.Close()
    End Sub

End Class
