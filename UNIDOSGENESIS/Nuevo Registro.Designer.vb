<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo_Registro
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
        Me.fecharegistro = New System.Windows.Forms.DateTimePicker()
        Me.cmbsubtipo = New System.Windows.Forms.ComboBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Subtipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'fecharegistro
        '
        Me.fecharegistro.Location = New System.Drawing.Point(65, 91)
        Me.fecharegistro.Name = "fecharegistro"
        Me.fecharegistro.Size = New System.Drawing.Size(200, 20)
        Me.fecharegistro.TabIndex = 24
        '
        'cmbsubtipo
        '
        Me.cmbsubtipo.FormattingEnabled = True
        Me.cmbsubtipo.Location = New System.Drawing.Point(66, 63)
        Me.cmbsubtipo.Name = "cmbsubtipo"
        Me.cmbsubtipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbsubtipo.TabIndex = 23
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Location = New System.Drawing.Point(66, 35)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipo.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(65, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 21
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(65, 117)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(122, 20)
        Me.txtmonto.TabIndex = 20
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(162, 203)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 19
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(42, 203)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 18
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Detalle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Monto"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(20, 91)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Fecha.TabIndex = 15
        Me.Fecha.Text = "Fecha"
        '
        'Subtipo
        '
        Me.Subtipo.AutoSize = True
        Me.Subtipo.Location = New System.Drawing.Point(20, 66)
        Me.Subtipo.Name = "Subtipo"
        Me.Subtipo.Size = New System.Drawing.Size(43, 13)
        Me.Subtipo.TabIndex = 14
        Me.Subtipo.Text = "Subtipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tipo"
        '
        'Nuevo_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.fecharegistro)
        Me.Controls.Add(Me.cmbsubtipo)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Subtipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Nuevo_Registro"
        Me.Text = "Nuevo_Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fecharegistro As DateTimePicker
    Friend WithEvents cmbsubtipo As ComboBox
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Subtipo As Label
    Friend WithEvents Label1 As Label
End Class
