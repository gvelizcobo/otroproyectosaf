<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_datosde_persona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtmdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.clbmdpto = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ced = New System.Windows.Forms.Label()
        Me.txtmcedula = New System.Windows.Forms.TextBox()
        Me.cmbmestado = New System.Windows.Forms.ComboBox()
        Me.txtmcarrera = New System.Windows.Forms.TextBox()
        Me.txtmuniversidad = New System.Windows.Forms.TextBox()
        Me.cmbmtipo = New System.Windows.Forms.ComboBox()
        Me.mfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtmemail = New System.Windows.Forms.TextBox()
        Me.txtmtelefono = New System.Windows.Forms.TextBox()
        Me.txtmapellidos = New System.Windows.Forms.TextBox()
        Me.txtmnombre = New System.Windows.Forms.TextBox()
        Me.est1 = New System.Windows.Forms.Label()
        Me.car1 = New System.Windows.Forms.Label()
        Me.uni1 = New System.Windows.Forms.Label()
        Me.dpto1 = New System.Windows.Forms.Label()
        Me.fec1 = New System.Windows.Forms.Label()
        Me.mail1 = New System.Windows.Forms.Label()
        Me.tel1 = New System.Windows.Forms.Label()
        Me.ti1 = New System.Windows.Forms.Label()
        Me.ap1 = New System.Windows.Forms.Label()
        Me.nom1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtmdireccion
        '
        Me.txtmdireccion.Location = New System.Drawing.Point(492, 170)
        Me.txtmdireccion.Name = "txtmdireccion"
        Me.txtmdireccion.Size = New System.Drawing.Size(200, 20)
        Me.txtmdireccion.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Dirección"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(196, 21)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscar.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Ingrese número de cédula"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(388, 18)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 164
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'clbmdpto
        '
        Me.clbmdpto.FormattingEnabled = True
        Me.clbmdpto.Items.AddRange(New Object() {"Spoude", "DAR", "Artes", "Coord. General y TTHH", "Finanzas"})
        Me.clbmdpto.Location = New System.Drawing.Point(469, 269)
        Me.clbmdpto.Name = "clbmdpto"
        Me.clbmdpto.Size = New System.Drawing.Size(153, 94)
        Me.clbmdpto.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "INFORMACIÓN ADICIONAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.Location = New System.Drawing.Point(60, 122)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(40, 13)
        Me.ced.TabIndex = 160
        Me.ced.Text = "Cédula"
        '
        'txtmcedula
        '
        Me.txtmcedula.Location = New System.Drawing.Point(164, 122)
        Me.txtmcedula.Name = "txtmcedula"
        Me.txtmcedula.Size = New System.Drawing.Size(200, 20)
        Me.txtmcedula.TabIndex = 159
        '
        'cmbmestado
        '
        Me.cmbmestado.FormattingEnabled = True
        Me.cmbmestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.cmbmestado.Location = New System.Drawing.Point(167, 321)
        Me.cmbmestado.Name = "cmbmestado"
        Me.cmbmestado.Size = New System.Drawing.Size(197, 21)
        Me.cmbmestado.TabIndex = 158
        '
        'txtmcarrera
        '
        Me.txtmcarrera.Location = New System.Drawing.Point(167, 298)
        Me.txtmcarrera.Name = "txtmcarrera"
        Me.txtmcarrera.Size = New System.Drawing.Size(197, 20)
        Me.txtmcarrera.TabIndex = 157
        '
        'txtmuniversidad
        '
        Me.txtmuniversidad.Location = New System.Drawing.Point(167, 272)
        Me.txtmuniversidad.Name = "txtmuniversidad"
        Me.txtmuniversidad.Size = New System.Drawing.Size(197, 20)
        Me.txtmuniversidad.TabIndex = 156
        '
        'cmbmtipo
        '
        Me.cmbmtipo.FormattingEnabled = True
        Me.cmbmtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbmtipo.Location = New System.Drawing.Point(167, 347)
        Me.cmbmtipo.Name = "cmbmtipo"
        Me.cmbmtipo.Size = New System.Drawing.Size(197, 21)
        Me.cmbmtipo.TabIndex = 155
        '
        'mfecha
        '
        Me.mfecha.Location = New System.Drawing.Point(492, 196)
        Me.mfecha.Name = "mfecha"
        Me.mfecha.Size = New System.Drawing.Size(200, 20)
        Me.mfecha.TabIndex = 154
        '
        'txtmemail
        '
        Me.txtmemail.Location = New System.Drawing.Point(492, 143)
        Me.txtmemail.Name = "txtmemail"
        Me.txtmemail.Size = New System.Drawing.Size(200, 20)
        Me.txtmemail.TabIndex = 153
        '
        'txtmtelefono
        '
        Me.txtmtelefono.Location = New System.Drawing.Point(492, 119)
        Me.txtmtelefono.Name = "txtmtelefono"
        Me.txtmtelefono.Size = New System.Drawing.Size(200, 20)
        Me.txtmtelefono.TabIndex = 152
        '
        'txtmapellidos
        '
        Me.txtmapellidos.Location = New System.Drawing.Point(164, 174)
        Me.txtmapellidos.Name = "txtmapellidos"
        Me.txtmapellidos.Size = New System.Drawing.Size(200, 20)
        Me.txtmapellidos.TabIndex = 151
        '
        'txtmnombre
        '
        Me.txtmnombre.Location = New System.Drawing.Point(164, 148)
        Me.txtmnombre.Name = "txtmnombre"
        Me.txtmnombre.Size = New System.Drawing.Size(200, 20)
        Me.txtmnombre.TabIndex = 150
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.Location = New System.Drawing.Point(61, 324)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(40, 13)
        Me.est1.TabIndex = 149
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.Location = New System.Drawing.Point(60, 298)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(41, 13)
        Me.car1.TabIndex = 148
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.Location = New System.Drawing.Point(57, 275)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(63, 13)
        Me.uni1.TabIndex = 147
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.Location = New System.Drawing.Point(389, 268)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(74, 13)
        Me.dpto1.TabIndex = 146
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.Location = New System.Drawing.Point(385, 202)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(106, 13)
        Me.fec1.TabIndex = 145
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.Location = New System.Drawing.Point(385, 146)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(35, 13)
        Me.mail1.TabIndex = 144
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.Location = New System.Drawing.Point(385, 122)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(49, 13)
        Me.tel1.TabIndex = 143
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.Location = New System.Drawing.Point(60, 350)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(28, 13)
        Me.ti1.TabIndex = 142
        Me.ti1.Text = "Tipo"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.Location = New System.Drawing.Point(57, 174)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(49, 13)
        Me.ap1.TabIndex = 141
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.Location = New System.Drawing.Point(57, 148)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(49, 13)
        Me.nom1.TabIndex = 140
        Me.nom1.Text = "Nombres"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(328, 393)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 139
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(433, 393)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 138
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Modificar_datosde_persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 434)
        Me.Controls.Add(Me.txtmdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.clbmdpto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.txtmcedula)
        Me.Controls.Add(Me.cmbmestado)
        Me.Controls.Add(Me.txtmcarrera)
        Me.Controls.Add(Me.txtmuniversidad)
        Me.Controls.Add(Me.cmbmtipo)
        Me.Controls.Add(Me.mfecha)
        Me.Controls.Add(Me.txtmemail)
        Me.Controls.Add(Me.txtmtelefono)
        Me.Controls.Add(Me.txtmapellidos)
        Me.Controls.Add(Me.txtmnombre)
        Me.Controls.Add(Me.est1)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.uni1)
        Me.Controls.Add(Me.dpto1)
        Me.Controls.Add(Me.fec1)
        Me.Controls.Add(Me.mail1)
        Me.Controls.Add(Me.tel1)
        Me.Controls.Add(Me.ti1)
        Me.Controls.Add(Me.ap1)
        Me.Controls.Add(Me.nom1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "Modificar_datosde_persona"
        Me.Text = "Modificar_datosde_persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmdireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents clbmdpto As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ced As Label
    Friend WithEvents txtmcedula As TextBox
    Friend WithEvents cmbmestado As ComboBox
    Friend WithEvents txtmcarrera As TextBox
    Friend WithEvents txtmuniversidad As TextBox
    Friend WithEvents cmbmtipo As ComboBox
    Friend WithEvents mfecha As DateTimePicker
    Friend WithEvents txtmemail As TextBox
    Friend WithEvents txtmtelefono As TextBox
    Friend WithEvents txtmapellidos As TextBox
    Friend WithEvents txtmnombre As TextBox
    Friend WithEvents est1 As Label
    Friend WithEvents car1 As Label
    Friend WithEvents uni1 As Label
    Friend WithEvents dpto1 As Label
    Friend WithEvents fec1 As Label
    Friend WithEvents mail1 As Label
    Friend WithEvents tel1 As Label
    Friend WithEvents ti1 As Label
    Friend WithEvents ap1 As Label
    Friend WithEvents nom1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
End Class
