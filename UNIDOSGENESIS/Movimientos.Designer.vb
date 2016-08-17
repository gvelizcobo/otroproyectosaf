<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimientos
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MovimientoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOVIMIENTOBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSDataSet3 = New UNIDOSGENESIS.UNIDOSDataSet3()
        Me.btnmagregar = New System.Windows.Forms.Button()
        Me.btnmmodificar = New System.Windows.Forms.Button()
        Me.btnmeliminar = New System.Windows.Forms.Button()
        Me.btnmsalir = New System.Windows.Forms.Button()
        Me.btnmvertodo = New System.Windows.Forms.Button()
        Me.btnmsaldo = New System.Windows.Forms.Button()
        Me.btnmbuscar = New System.Windows.Forms.Button()
        Me.btnmlimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSDataSet = New UNIDOSGENESIS.UNIDOSDataSet()
        Me.MOVIMIENTOTableAdapter = New UNIDOSGENESIS.UNIDOSDataSetTableAdapters.MOVIMIENTOTableAdapter()
        Me.MOVIMIENTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKDPTOMOVIMIENTOMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DPTO_MOVIMIENTOTableAdapter = New UNIDOSGENESIS.UNIDOSDataSetTableAdapters.DPTO_MOVIMIENTOTableAdapter()
        Me.MOVIMIENTOBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVIMIENTOBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVIMIENTOTableAdapter1 = New UNIDOSGENESIS.UNIDOSDataSet3TableAdapters.MOVIMIENTOTableAdapter()
        Me.txtmovimiento = New System.Windows.Forms.TextBox()
        Me.cbmtipo = New System.Windows.Forms.ComboBox()
        Me.cbmsubtipo = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKDPTOMOVIMIENTOMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientoIDDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.SubtipoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MOVIMIENTOBindingSource4
        Me.DataGridView1.Location = New System.Drawing.Point(50, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(651, 91)
        Me.DataGridView1.TabIndex = 0
        '
        'MovimientoIDDataGridViewTextBoxColumn
        '
        Me.MovimientoIDDataGridViewTextBoxColumn.DataPropertyName = "MovimientoID"
        Me.MovimientoIDDataGridViewTextBoxColumn.HeaderText = "MovimientoID"
        Me.MovimientoIDDataGridViewTextBoxColumn.Name = "MovimientoIDDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'SubtipoDataGridViewTextBoxColumn
        '
        Me.SubtipoDataGridViewTextBoxColumn.DataPropertyName = "Subtipo"
        Me.SubtipoDataGridViewTextBoxColumn.HeaderText = "Subtipo"
        Me.SubtipoDataGridViewTextBoxColumn.Name = "SubtipoDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        '
        'MOVIMIENTOBindingSource4
        '
        Me.MOVIMIENTOBindingSource4.DataMember = "MOVIMIENTO"
        Me.MOVIMIENTOBindingSource4.DataSource = Me.UNIDOSDataSet3
        '
        'UNIDOSDataSet3
        '
        Me.UNIDOSDataSet3.DataSetName = "UNIDOSDataSet3"
        Me.UNIDOSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnmagregar
        '
        Me.btnmagregar.Location = New System.Drawing.Point(505, 105)
        Me.btnmagregar.Name = "btnmagregar"
        Me.btnmagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnmagregar.TabIndex = 1
        Me.btnmagregar.Text = "Guardar"
        Me.btnmagregar.UseVisualStyleBackColor = True
        '
        'btnmmodificar
        '
        Me.btnmmodificar.Location = New System.Drawing.Point(701, 412)
        Me.btnmmodificar.Name = "btnmmodificar"
        Me.btnmmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmmodificar.TabIndex = 2
        Me.btnmmodificar.Text = "Modificar"
        Me.btnmmodificar.UseVisualStyleBackColor = True
        '
        'btnmeliminar
        '
        Me.btnmeliminar.Location = New System.Drawing.Point(701, 441)
        Me.btnmeliminar.Name = "btnmeliminar"
        Me.btnmeliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnmeliminar.TabIndex = 3
        Me.btnmeliminar.Text = "Eliminar"
        Me.btnmeliminar.UseVisualStyleBackColor = True
        '
        'btnmsalir
        '
        Me.btnmsalir.Location = New System.Drawing.Point(701, 470)
        Me.btnmsalir.Name = "btnmsalir"
        Me.btnmsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnmsalir.TabIndex = 4
        Me.btnmsalir.Text = "Salir"
        Me.btnmsalir.UseVisualStyleBackColor = True
        '
        'btnmvertodo
        '
        Me.btnmvertodo.Location = New System.Drawing.Point(424, 369)
        Me.btnmvertodo.Name = "btnmvertodo"
        Me.btnmvertodo.Size = New System.Drawing.Size(75, 23)
        Me.btnmvertodo.TabIndex = 5
        Me.btnmvertodo.Text = "Ver Todo"
        Me.btnmvertodo.UseVisualStyleBackColor = True
        '
        'btnmsaldo
        '
        Me.btnmsaldo.Location = New System.Drawing.Point(424, 413)
        Me.btnmsaldo.Name = "btnmsaldo"
        Me.btnmsaldo.Size = New System.Drawing.Size(75, 23)
        Me.btnmsaldo.TabIndex = 6
        Me.btnmsaldo.Text = "Saldo"
        Me.btnmsaldo.UseVisualStyleBackColor = True
        '
        'btnmbuscar
        '
        Me.btnmbuscar.Location = New System.Drawing.Point(181, 473)
        Me.btnmbuscar.Name = "btnmbuscar"
        Me.btnmbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnmbuscar.TabIndex = 7
        Me.btnmbuscar.Text = "Buscar"
        Me.btnmbuscar.UseVisualStyleBackColor = True
        '
        'btnmlimpiar
        '
        Me.btnmlimpiar.Location = New System.Drawing.Point(290, 473)
        Me.btnmlimpiar.Name = "btnmlimpiar"
        Me.btnmlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnmlimpiar.TabIndex = 8
        Me.btnmlimpiar.Text = "Limpiar"
        Me.btnmlimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MOVIMIENTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "BUSCAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Desde:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hasta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Concepto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 347)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(191, 369)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(191, 396)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Movimientoid:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(188, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tipo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Subtipo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Detalle:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(176, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Monto:"
        '
        'MOVIMIENTOBindingSource
        '
        Me.MOVIMIENTOBindingSource.DataMember = "MOVIMIENTO"
        Me.MOVIMIENTOBindingSource.DataSource = Me.UNIDOSDataSet
        '
        'UNIDOSDataSet
        '
        Me.UNIDOSDataSet.DataSetName = "UNIDOSDataSet"
        Me.UNIDOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MOVIMIENTOTableAdapter
        '
        Me.MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'MOVIMIENTOBindingSource1
        '
        Me.MOVIMIENTOBindingSource1.DataMember = "MOVIMIENTO"
        Me.MOVIMIENTOBindingSource1.DataSource = Me.UNIDOSDataSet
        '
        'FKDPTOMOVIMIENTOMOVIMIENTOBindingSource
        '
        Me.FKDPTOMOVIMIENTOMOVIMIENTOBindingSource.DataMember = "FK_DPTO_MOVIMIENTO_MOVIMIENTO"
        Me.FKDPTOMOVIMIENTOMOVIMIENTOBindingSource.DataSource = Me.MOVIMIENTOBindingSource
        '
        'DPTO_MOVIMIENTOTableAdapter
        '
        Me.DPTO_MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'MOVIMIENTOBindingSource2
        '
        Me.MOVIMIENTOBindingSource2.DataMember = "MOVIMIENTO"
        Me.MOVIMIENTOBindingSource2.DataSource = Me.UNIDOSDataSet
        '
        'MOVIMIENTOBindingSource3
        '
        Me.MOVIMIENTOBindingSource3.DataMember = "MOVIMIENTO"
        Me.MOVIMIENTOBindingSource3.DataSource = Me.UNIDOSDataSet
        '
        'MOVIMIENTOTableAdapter1
        '
        Me.MOVIMIENTOTableAdapter1.ClearBeforeFill = True
        '
        'txtmovimiento
        '
        Me.txtmovimiento.Location = New System.Drawing.Point(245, 49)
        Me.txtmovimiento.Name = "txtmovimiento"
        Me.txtmovimiento.Size = New System.Drawing.Size(200, 20)
        Me.txtmovimiento.TabIndex = 24
        '
        'cbmtipo
        '
        Me.cbmtipo.FormattingEnabled = True
        Me.cbmtipo.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cbmtipo.Location = New System.Drawing.Point(245, 72)
        Me.cbmtipo.Name = "cbmtipo"
        Me.cbmtipo.Size = New System.Drawing.Size(200, 21)
        Me.cbmtipo.TabIndex = 25
        '
        'cbmsubtipo
        '
        Me.cbmsubtipo.FormattingEnabled = True
        Me.cbmsubtipo.Items.AddRange(New Object() {"Donaciones", "Patrocinios", "Venta", "Gastos Operativos", "Gastos Administrativos", "Otros Gastos"})
        Me.cbmsubtipo.Location = New System.Drawing.Point(245, 97)
        Me.cbmsubtipo.Name = "cbmsubtipo"
        Me.cbmsubtipo.Size = New System.Drawing.Size(200, 21)
        Me.cbmsubtipo.TabIndex = 26
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(245, 124)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha.TabIndex = 27
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(245, 148)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(200, 20)
        Me.txtdetalle.TabIndex = 28
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(245, 171)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(200, 20)
        Me.txtmonto.TabIndex = 29
        '
        'Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 517)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.cbmsubtipo)
        Me.Controls.Add(Me.cbmtipo)
        Me.Controls.Add(Me.txtmovimiento)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmlimpiar)
        Me.Controls.Add(Me.btnmbuscar)
        Me.Controls.Add(Me.btnmsaldo)
        Me.Controls.Add(Me.btnmvertodo)
        Me.Controls.Add(Me.btnmsalir)
        Me.Controls.Add(Me.btnmeliminar)
        Me.Controls.Add(Me.btnmmodificar)
        Me.Controls.Add(Me.btnmagregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Movimientos"
        Me.Text = "Movimientos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKDPTOMOVIMIENTOMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnmagregar As Button
    Friend WithEvents btnmmodificar As Button
    Friend WithEvents btnmeliminar As Button
    Friend WithEvents btnmsalir As Button
    Friend WithEvents btnmvertodo As Button
    Friend WithEvents btnmsaldo As Button
    Friend WithEvents btnmbuscar As Button
    Friend WithEvents btnmlimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UNIDOSDataSet As UNIDOSDataSet
    Friend WithEvents MOVIMIENTOBindingSource As BindingSource
    Friend WithEvents MOVIMIENTOTableAdapter As UNIDOSDataSetTableAdapters.MOVIMIENTOTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MOVIMIENTOBindingSource1 As BindingSource
    Friend WithEvents FKDPTOMOVIMIENTOMOVIMIENTOBindingSource As BindingSource
    Friend WithEvents DPTO_MOVIMIENTOTableAdapter As UNIDOSDataSetTableAdapters.DPTO_MOVIMIENTOTableAdapter
    Friend WithEvents MovimientoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOVIMIENTOBindingSource3 As BindingSource
    Friend WithEvents MOVIMIENTOBindingSource2 As BindingSource
    Friend WithEvents UNIDOSDataSet3 As UNIDOSDataSet3
    Friend WithEvents MOVIMIENTOBindingSource4 As BindingSource
    Friend WithEvents MOVIMIENTOTableAdapter1 As UNIDOSDataSet3TableAdapters.MOVIMIENTOTableAdapter
    Friend WithEvents txtmovimiento As TextBox
    Friend WithEvents cbmtipo As ComboBox
    Friend WithEvents cbmsubtipo As ComboBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents txtmonto As TextBox
End Class
