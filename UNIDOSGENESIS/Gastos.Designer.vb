<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos
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
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.btnvertodo = New System.Windows.Forms.Button()
        Me.btnlimpiarg = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dtphasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsalirg = New System.Windows.Forms.Button()
        Me.btneliminarg = New System.Windows.Forms.Button()
        Me.btnmodificarg = New System.Windows.Forms.Button()
        Me.btnagregarg = New System.Windows.Forms.Button()
        Me.dgvingresos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvingresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbtipo
        '
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Items.AddRange(New Object() {"Gasto General", "Gasto Operativo", "Otro Gasto"})
        Me.cbtipo.Location = New System.Drawing.Point(122, 231)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(200, 21)
        Me.cbtipo.TabIndex = 33
        '
        'btnvertodo
        '
        Me.btnvertodo.Location = New System.Drawing.Point(364, 219)
        Me.btnvertodo.Name = "btnvertodo"
        Me.btnvertodo.Size = New System.Drawing.Size(75, 23)
        Me.btnvertodo.TabIndex = 32
        Me.btnvertodo.Text = "Ver todo"
        Me.btnvertodo.UseVisualStyleBackColor = True
        '
        'btnlimpiarg
        '
        Me.btnlimpiarg.Location = New System.Drawing.Point(234, 300)
        Me.btnlimpiarg.Name = "btnlimpiarg"
        Me.btnlimpiarg.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiarg.TabIndex = 31
        Me.btnlimpiarg.Text = "Limpiar"
        Me.btnlimpiarg.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(122, 300)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 30
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'dtphasta
        '
        Me.dtphasta.Location = New System.Drawing.Point(122, 205)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(200, 20)
        Me.dtphasta.TabIndex = 29
        '
        'dtpdesde
        '
        Me.dtpdesde.Location = New System.Drawing.Point(122, 179)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpdesde.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "BUSCAR"
        '
        'btnsalirg
        '
        Me.btnsalirg.Location = New System.Drawing.Point(376, 107)
        Me.btnsalirg.Name = "btnsalirg"
        Me.btnsalirg.Size = New System.Drawing.Size(75, 23)
        Me.btnsalirg.TabIndex = 26
        Me.btnsalirg.Text = "Salir"
        Me.btnsalirg.UseVisualStyleBackColor = True
        '
        'btneliminarg
        '
        Me.btneliminarg.Location = New System.Drawing.Point(376, 78)
        Me.btneliminarg.Name = "btneliminarg"
        Me.btneliminarg.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarg.TabIndex = 25
        Me.btneliminarg.Text = "Eliminar"
        Me.btneliminarg.UseVisualStyleBackColor = True
        '
        'btnmodificarg
        '
        Me.btnmodificarg.Location = New System.Drawing.Point(376, 49)
        Me.btnmodificarg.Name = "btnmodificarg"
        Me.btnmodificarg.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarg.TabIndex = 24
        Me.btnmodificarg.Text = "Modificar"
        Me.btnmodificarg.UseVisualStyleBackColor = True
        '
        'btnagregarg
        '
        Me.btnagregarg.Location = New System.Drawing.Point(376, 20)
        Me.btnagregarg.Name = "btnagregarg"
        Me.btnagregarg.Size = New System.Drawing.Size(75, 23)
        Me.btnagregarg.TabIndex = 23
        Me.btnagregarg.Text = "Agregar"
        Me.btnagregarg.UseVisualStyleBackColor = True
        '
        'dgvingresos
        '
        Me.dgvingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvingresos.Location = New System.Drawing.Point(26, 40)
        Me.dgvingresos.Name = "dgvingresos"
        Me.dgvingresos.Size = New System.Drawing.Size(287, 80)
        Me.dgvingresos.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "GASTOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Desde:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Hasta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Concepto:"
        '
        'Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 328)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbtipo)
        Me.Controls.Add(Me.btnvertodo)
        Me.Controls.Add(Me.btnlimpiarg)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.dtphasta)
        Me.Controls.Add(Me.dtpdesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsalirg)
        Me.Controls.Add(Me.btneliminarg)
        Me.Controls.Add(Me.btnmodificarg)
        Me.Controls.Add(Me.btnagregarg)
        Me.Controls.Add(Me.dgvingresos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gastos"
        Me.Text = "Gastos"
        CType(Me.dgvingresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbtipo As ComboBox
    Friend WithEvents btnvertodo As Button
    Friend WithEvents btnlimpiarg As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents dtphasta As DateTimePicker
    Friend WithEvents dtpdesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalirg As Button
    Friend WithEvents btneliminarg As Button
    Friend WithEvents btnmodificarg As Button
    Friend WithEvents btnagregarg As Button
    Friend WithEvents dgvingresos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
