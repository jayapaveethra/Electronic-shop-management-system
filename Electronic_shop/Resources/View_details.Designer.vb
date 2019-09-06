<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddstockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectronicshopDataSet2 = New Electronic_shop.electronicshopDataSet2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Add_stockTableAdapter = New Electronic_shop.electronicshopDataSet2TableAdapters.add_stockTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddstockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectronicshopDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(18, 115)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 328)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IidDataGridViewTextBoxColumn, Me.InameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AddstockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(76, 54)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 231)
        Me.DataGridView1.TabIndex = 0
        '
        'IidDataGridViewTextBoxColumn
        '
        Me.IidDataGridViewTextBoxColumn.DataPropertyName = "i_id"
        Me.IidDataGridViewTextBoxColumn.HeaderText = "i_id"
        Me.IidDataGridViewTextBoxColumn.Name = "IidDataGridViewTextBoxColumn"
        '
        'InameDataGridViewTextBoxColumn
        '
        Me.InameDataGridViewTextBoxColumn.DataPropertyName = "i_name"
        Me.InameDataGridViewTextBoxColumn.HeaderText = "i_name"
        Me.InameDataGridViewTextBoxColumn.Name = "InameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'AddstockBindingSource
        '
        Me.AddstockBindingSource.DataMember = "add_stock"
        Me.AddstockBindingSource.DataSource = Me.ElectronicshopDataSet2
        '
        'ElectronicshopDataSet2
        '
        Me.ElectronicshopDataSet2.DataSetName = "electronicshopDataSet2"
        Me.ElectronicshopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(323, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VIEW ALL AVAILABLE DETAILS"
        '
        'Add_stockTableAdapter
        '
        Me.Add_stockTableAdapter.ClearBeforeFill = True
        '
        'View_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1117, 483)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "View_details"
        Me.Text = "View_details"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddstockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectronicshopDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ElectronicshopDataSet2 As Electronic_shop.electronicshopDataSet2
    Friend WithEvents AddstockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_stockTableAdapter As Electronic_shop.electronicshopDataSet2TableAdapters.add_stockTableAdapter
    Friend WithEvents IidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
