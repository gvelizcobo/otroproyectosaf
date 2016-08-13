<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvingresos = New System.Windows.Forms.DataGridView()
        Me.btnagregari = New System.Windows.Forms.Button()
        Me.btnmodificari = New System.Windows.Forms.Button()
        Me.btneliminari = New System.Windows.Forms.Button()
        Me.btnsaliri = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
        Me.dtphasta = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnlimpiari = New System.Windows.Forms.Button()
        Me.btnvertodo = New System.Windows.Forms.Button()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.cbforma = New System.Windows.Forms.ComboBox()
        Me.UNIDOSDataSet1 = New UNIDOSGENESIS.UNIDOSDataSet1()
        Me.MOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVIMIENTOTableAdapter = New UNIDOSGENESIS.UNIDOSDataSet1TableAdapters.MOVIMIENTOTableAdapter()
        Me.MovimientoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormadepagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvingresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESOS"
        '
        'dgvingresos
        '
        Me.dgvingresos.AutoGenerateColumns = False
        Me.dgvingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvingresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientoIDDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.SubtipoDataGridViewTextBoxColumn, Me.FormadepagoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn})
        Me.dgvingresos.DataSource = Me.MOVIMIENTOBindingSource
        Me.dgvingresos.Location = New System.Drawing.Point(4, 56)
        Me.dgvingresos.Name = "dgvingresos"
        Me.dgvingresos.Size = New System.Drawing.Size(740, 80)
        Me.dgvingresos.TabIndex = 1
        '
        'btnagregari
        '
        Me.btnagregari.Location = New System.Drawing.Point(613, 159)
        Me.btnagregari.Name = "btnagregari"
        Me.btnagregari.Size = New System.Drawing.Size(75, 23)
        Me.btnagregari.TabIndex = 2
        Me.btnagregari.Text = "Agregar"
        Me.btnagregari.UseVisualStyleBackColor = True
        '
        'btnmodificari
        '
        Me.btnmodificari.Location = New System.Drawing.Point(613, 188)
        Me.btnmodificari.Name = "btnmodificari"
        Me.btnmodificari.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificari.TabIndex = 3
        Me.btnmodificari.Text = "Modificar"
        Me.btnmodificari.UseVisualStyleBackColor = True
        '
        'btneliminari
        '
        Me.btneliminari.Location = New System.Drawing.Point(613, 217)
        Me.btneliminari.Name = "btneliminari"
        Me.btneliminari.Size = New System.Drawing.Size(75, 23)
        Me.btneliminari.TabIndex = 4
        Me.btneliminari.Text = "Eliminar"
        Me.btneliminari.UseVisualStyleBackColor = True
        '
        'btnsaliri
        '
        Me.btnsaliri.Location = New System.Drawing.Point(613, 246)
        Me.btnsaliri.Name = "btnsaliri"
        Me.btnsaliri.Size = New System.Drawing.Size(75, 23)
        Me.btnsaliri.TabIndex = 5
        Me.btnsaliri.Text = "Salir"
        Me.btnsaliri.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BUSCAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Forma de pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Concepto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hasta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Desde:"
        '
        'dtpdesde
        '
        Me.dtpdesde.Location = New System.Drawing.Point(146, 195)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpdesde.TabIndex = 12
        '
        'dtphasta
        '
        Me.dtphasta.Location = New System.Drawing.Point(146, 221)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(200, 20)
        Me.dtphasta.TabIndex = 13
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(146, 316)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 16
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnlimpiari
        '
        Me.btnlimpiari.Location = New System.Drawing.Point(258, 316)
        Me.btnlimpiari.Name = "btnlimpiari"
        Me.btnlimpiari.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiari.TabIndex = 17
        Me.btnlimpiari.Text = "Limpiar"
        Me.btnlimpiari.UseVisualStyleBackColor = True
        '
        'btnvertodo
        '
        Me.btnvertodo.Location = New System.Drawing.Point(388, 235)
        Me.btnvertodo.Name = "btnvertodo"
        Me.btnvertodo.Size = New System.Drawing.Size(75, 23)
        Me.btnvertodo.TabIndex = 18
        Me.btnvertodo.Text = "Ver todo"
        Me.btnvertodo.UseVisualStyleBackColor = True
        '
        'cbtipo
        '
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Items.AddRange(New Object() {"Donaciones", "Ventas", "Patrocinios"})
        Me.cbtipo.Location = New System.Drawing.Point(146, 247)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(200, 21)
        Me.cbtipo.TabIndex = 19
        '
        'cbforma
        '
        Me.cbforma.FormattingEnabled = True
        Me.cbforma.Items.AddRange(New Object() {"Efectivo", "Transferencia", "Cheque"})
        Me.cbforma.Location = New System.Drawing.Point(146, 274)
        Me.cbforma.Name = "cbforma"
        Me.cbforma.Size = New System.Drawing.Size(200, 21)
        Me.cbforma.TabIndex = 20
        '
        'UNIDOSDataSet1
        '
        Me.UNIDOSDataSet1.DataSetName = "UNIDOSDataSet1"
        Me.UNIDOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MOVIMIENTOBindingSource
        '
        Me.MOVIMIENTOBindingSource.DataMember = "MOVIMIENTO"
        Me.MOVIMIENTOBindingSource.DataSource = Me.UNIDOSDataSet1
        '
        'MOVIMIENTOTableAdapter
        '
        Me.MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'MovimientoIDDataGridViewTextBoxColumn
        '
        Me.MovimientoIDDataGridViewTextBoxColumn.DataPropertyName = "MovimientoID"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.MovimientoIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MovimientoIDDataGridViewTextBoxColumn.HeaderText = "MovimientoID"
        Me.MovimientoIDDataGridViewTextBoxColumn.Name = "MovimientoIDDataGridViewTextBoxColumn"
        Me.MovimientoIDDataGridViewTextBoxColumn.Visible = False
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
        'FormadepagoDataGridViewTextBoxColumn
        '
        Me.FormadepagoDataGridViewTextBoxColumn.DataPropertyName = "Forma_de_pago"
        Me.FormadepagoDataGridViewTextBoxColumn.HeaderText = "Forma_de_pago"
        Me.FormadepagoDataGridViewTextBoxColumn.Name = "FormadepagoDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "$"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        '
        'Ingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 372)
        Me.Controls.Add(Me.cbforma)
        Me.Controls.Add(Me.cbtipo)
        Me.Controls.Add(Me.btnvertodo)
        Me.Controls.Add(Me.btnlimpiari)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.dtphasta)
        Me.Controls.Add(Me.dtpdesde)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsaliri)
        Me.Controls.Add(Me.btneliminari)
        Me.Controls.Add(Me.btnmodificari)
        Me.Controls.Add(Me.btnagregari)
        Me.Controls.Add(Me.dgvingresos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ingresos"
        Me.Text = "Ingresos"
        CType(Me.dgvingresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvingresos As DataGridView
    Friend WithEvents btnagregari As Button
    Friend WithEvents btnmodificari As Button
    Friend WithEvents btneliminari As Button
    Friend WithEvents btnsaliri As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpdesde As DateTimePicker
    Friend WithEvents dtphasta As DateTimePicker
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnlimpiari As Button
    Friend WithEvents btnvertodo As Button
    Friend WithEvents cbtipo As ComboBox
    Friend WithEvents cbforma As ComboBox
    Friend WithEvents UNIDOSDataSet1 As UNIDOSDataSet1
    Friend WithEvents MOVIMIENTOBindingSource As BindingSource
    Friend WithEvents MOVIMIENTOTableAdapter As UNIDOSDataSet1TableAdapters.MOVIMIENTOTableAdapter
    Friend WithEvents MovimientoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormadepagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
