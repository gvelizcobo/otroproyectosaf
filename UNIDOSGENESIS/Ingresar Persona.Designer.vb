<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Persona
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
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbdpto = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ced = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.txtcarrera = New System.Windows.Forms.TextBox()
        Me.txtuniversidad = New System.Windows.Forms.TextBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
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
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(447, 120)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(200, 20)
        Me.txtdireccion.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Dirección"
        '
        'clbdpto
        '
        Me.clbdpto.FormattingEnabled = True
        Me.clbdpto.Items.AddRange(New Object() {"Spoude", "DAR", "Artes", "Coord. General y TTHH", "Finanzas"})
        Me.clbdpto.Location = New System.Drawing.Point(424, 222)
        Me.clbdpto.Name = "clbdpto"
        Me.clbdpto.Size = New System.Drawing.Size(153, 94)
        Me.clbdpto.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "INFORMACIÓN ADICIONAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.Location = New System.Drawing.Point(15, 75)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(40, 13)
        Me.ced.TabIndex = 159
        Me.ced.Text = "Cédula"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(119, 75)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(200, 20)
        Me.txtcedula.TabIndex = 158
        '
        'cmbestado
        '
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.cmbestado.Location = New System.Drawing.Point(122, 274)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(197, 21)
        Me.cmbestado.TabIndex = 157
        '
        'txtcarrera
        '
        Me.txtcarrera.Location = New System.Drawing.Point(122, 251)
        Me.txtcarrera.Name = "txtcarrera"
        Me.txtcarrera.Size = New System.Drawing.Size(197, 20)
        Me.txtcarrera.TabIndex = 156
        '
        'txtuniversidad
        '
        Me.txtuniversidad.Location = New System.Drawing.Point(122, 225)
        Me.txtuniversidad.Name = "txtuniversidad"
        Me.txtuniversidad.Size = New System.Drawing.Size(197, 20)
        Me.txtuniversidad.TabIndex = 155
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbtipo.Location = New System.Drawing.Point(122, 300)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(197, 21)
        Me.cmbtipo.TabIndex = 154
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(447, 147)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 20)
        Me.fecha.TabIndex = 153
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(447, 96)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(200, 20)
        Me.txtemail.TabIndex = 152
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(447, 72)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(200, 20)
        Me.txttelefono.TabIndex = 151
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(119, 127)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(200, 20)
        Me.txtapellidos.TabIndex = 150
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(119, 101)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(200, 20)
        Me.txtnombre.TabIndex = 149
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.Location = New System.Drawing.Point(16, 277)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(40, 13)
        Me.est1.TabIndex = 148
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.Location = New System.Drawing.Point(15, 251)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(41, 13)
        Me.car1.TabIndex = 147
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.Location = New System.Drawing.Point(12, 228)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(63, 13)
        Me.uni1.TabIndex = 146
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.Location = New System.Drawing.Point(344, 221)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(74, 13)
        Me.dpto1.TabIndex = 145
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.Location = New System.Drawing.Point(340, 153)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(106, 13)
        Me.fec1.TabIndex = 144
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.Location = New System.Drawing.Point(340, 99)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(35, 13)
        Me.mail1.TabIndex = 143
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.Location = New System.Drawing.Point(340, 75)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(49, 13)
        Me.tel1.TabIndex = 142
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.Location = New System.Drawing.Point(15, 303)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(28, 13)
        Me.ti1.TabIndex = 141
        Me.ti1.Text = "Tipo"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.Location = New System.Drawing.Point(12, 127)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(49, 13)
        Me.ap1.TabIndex = 140
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.Location = New System.Drawing.Point(12, 101)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(49, 13)
        Me.nom1.TabIndex = 139
        Me.nom1.Text = "Nombres"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(283, 346)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 138
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(388, 346)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 137
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Ingresar_Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 408)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clbdpto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.txtcarrera)
        Me.Controls.Add(Me.txtuniversidad)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtnombre)
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
        Me.Name = "Ingresar_Persona"
        Me.Text = "Ingresar_Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbdpto As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ced As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents txtcarrera As TextBox
    Friend WithEvents txtuniversidad As TextBox
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombre As TextBox
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
