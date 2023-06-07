<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Dim RegnoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AdmitdateLabel As System.Windows.Forms.Label
        Dim DischargedateLabel As System.Windows.Forms.Label
        Dim BedtypeLabel As System.Windows.Forms.Label
        Dim ChargeperdayLabel As System.Windows.Forms.Label
        Dim BedchargeLabel As System.Windows.Forms.Label
        Dim OperationotherLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.HmDataSet1 = New WindowsApplication1.hmDataSet()
        Me.BillBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter1 = New WindowsApplication1.hmDataSetTableAdapters.BillTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager()
        Me.BillDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegnoTextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AdmitdateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DischargedateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BedtypeTextBox1 = New System.Windows.Forms.TextBox()
        Me.ChargeperdayTextBox1 = New System.Windows.Forms.TextBox()
        Me.BedchargeTextBox1 = New System.Windows.Forms.TextBox()
        Me.OperationotherTextBox1 = New System.Windows.Forms.TextBox()
        Me.TotalTextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnBACK = New System.Windows.Forms.Button()
        RegnoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AdmitdateLabel = New System.Windows.Forms.Label()
        DischargedateLabel = New System.Windows.Forms.Label()
        BedtypeLabel = New System.Windows.Forms.Label()
        ChargeperdayLabel = New System.Windows.Forms.Label()
        BedchargeLabel = New System.Windows.Forms.Label()
        OperationotherLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.HmDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegnoLabel
        '
        RegnoLabel.AutoSize = True
        RegnoLabel.BackColor = System.Drawing.Color.DarkOrange
        RegnoLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RegnoLabel.Location = New System.Drawing.Point(8, 10)
        RegnoLabel.Name = "RegnoLabel"
        RegnoLabel.Size = New System.Drawing.Size(45, 19)
        RegnoLabel.TabIndex = 1
        RegnoLabel.Text = "Regno:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.DarkOrange
        NameLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(8, 36)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(44, 19)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AdmitdateLabel
        '
        AdmitdateLabel.AutoSize = True
        AdmitdateLabel.BackColor = System.Drawing.Color.DarkOrange
        AdmitdateLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdmitdateLabel.Location = New System.Drawing.Point(8, 63)
        AdmitdateLabel.Name = "AdmitdateLabel"
        AdmitdateLabel.Size = New System.Drawing.Size(71, 19)
        AdmitdateLabel.TabIndex = 5
        AdmitdateLabel.Text = "Admitdate:"
        '
        'DischargedateLabel
        '
        DischargedateLabel.AutoSize = True
        DischargedateLabel.BackColor = System.Drawing.Color.DarkOrange
        DischargedateLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DischargedateLabel.Location = New System.Drawing.Point(8, 89)
        DischargedateLabel.Name = "DischargedateLabel"
        DischargedateLabel.Size = New System.Drawing.Size(90, 19)
        DischargedateLabel.TabIndex = 7
        DischargedateLabel.Text = "Dischargedate:"
        '
        'BedtypeLabel
        '
        BedtypeLabel.AutoSize = True
        BedtypeLabel.BackColor = System.Drawing.Color.DarkOrange
        BedtypeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BedtypeLabel.Location = New System.Drawing.Point(8, 114)
        BedtypeLabel.Name = "BedtypeLabel"
        BedtypeLabel.Size = New System.Drawing.Size(57, 19)
        BedtypeLabel.TabIndex = 9
        BedtypeLabel.Text = "Bedtype:"
        '
        'ChargeperdayLabel
        '
        ChargeperdayLabel.AutoSize = True
        ChargeperdayLabel.BackColor = System.Drawing.Color.DarkOrange
        ChargeperdayLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChargeperdayLabel.Location = New System.Drawing.Point(8, 140)
        ChargeperdayLabel.Name = "ChargeperdayLabel"
        ChargeperdayLabel.Size = New System.Drawing.Size(89, 19)
        ChargeperdayLabel.TabIndex = 11
        ChargeperdayLabel.Text = "Chargeperday:"
        '
        'BedchargeLabel
        '
        BedchargeLabel.AutoSize = True
        BedchargeLabel.BackColor = System.Drawing.Color.DarkOrange
        BedchargeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BedchargeLabel.Location = New System.Drawing.Point(8, 166)
        BedchargeLabel.Name = "BedchargeLabel"
        BedchargeLabel.Size = New System.Drawing.Size(70, 19)
        BedchargeLabel.TabIndex = 13
        BedchargeLabel.Text = "Bedcharge:"
        '
        'OperationotherLabel
        '
        OperationotherLabel.AutoSize = True
        OperationotherLabel.BackColor = System.Drawing.Color.DarkOrange
        OperationotherLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OperationotherLabel.Location = New System.Drawing.Point(8, 192)
        OperationotherLabel.Name = "OperationotherLabel"
        OperationotherLabel.Size = New System.Drawing.Size(97, 19)
        OperationotherLabel.TabIndex = 15
        OperationotherLabel.Text = "Operationother:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.BackColor = System.Drawing.Color.DarkOrange
        TotalLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(8, 218)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(39, 19)
        TotalLabel.TabIndex = 17
        TotalLabel.Text = "Total:"
        '
        'HmDataSet1
        '
        Me.HmDataSet1.DataSetName = "hmDataSet"
        Me.HmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillBindingSource1
        '
        Me.BillBindingSource1.DataMember = "Bill"
        Me.BillBindingSource1.DataSource = Me.HmDataSet1
        '
        'BillTableAdapter1
        '
        Me.BillTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdmitTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BillTableAdapter = Me.BillTableAdapter1
        Me.TableAdapterManager1.dischargeTableAdapter = Nothing
        Me.TableAdapterManager1.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BillDataGridView1
        '
        Me.BillDataGridView1.AutoGenerateColumns = False
        Me.BillDataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.BillDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.BillDataGridView1.DataSource = Me.BillBindingSource1
        Me.BillDataGridView1.Location = New System.Drawing.Point(11, 339)
        Me.BillDataGridView1.Name = "BillDataGridView1"
        Me.BillDataGridView1.Size = New System.Drawing.Size(300, 220)
        Me.BillDataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Regno"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Regno"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Admitdate"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Admitdate"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Dischargedate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Dischargedate"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Bedtype"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Bedtype"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Chargeperday"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Chargeperday"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Bedcharge"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Bedcharge"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Operationother"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Operationother"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'RegnoTextBox1
        '
        Me.RegnoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Regno", True))
        Me.RegnoTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegnoTextBox1.Location = New System.Drawing.Point(111, 9)
        Me.RegnoTextBox1.Name = "RegnoTextBox1"
        Me.RegnoTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.RegnoTextBox1.TabIndex = 2
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Name", True))
        Me.NameTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox1.Location = New System.Drawing.Point(111, 35)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.NameTextBox1.TabIndex = 4
        '
        'AdmitdateDateTimePicker1
        '
        Me.AdmitdateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BillBindingSource1, "Admitdate", True))
        Me.AdmitdateDateTimePicker1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmitdateDateTimePicker1.Location = New System.Drawing.Point(111, 61)
        Me.AdmitdateDateTimePicker1.Name = "AdmitdateDateTimePicker1"
        Me.AdmitdateDateTimePicker1.Size = New System.Drawing.Size(200, 25)
        Me.AdmitdateDateTimePicker1.TabIndex = 6
        '
        'DischargedateDateTimePicker1
        '
        Me.DischargedateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BillBindingSource1, "Dischargedate", True))
        Me.DischargedateDateTimePicker1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DischargedateDateTimePicker1.Location = New System.Drawing.Point(111, 87)
        Me.DischargedateDateTimePicker1.Name = "DischargedateDateTimePicker1"
        Me.DischargedateDateTimePicker1.Size = New System.Drawing.Size(200, 25)
        Me.DischargedateDateTimePicker1.TabIndex = 8
        '
        'BedtypeTextBox1
        '
        Me.BedtypeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Bedtype", True))
        Me.BedtypeTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BedtypeTextBox1.Location = New System.Drawing.Point(111, 113)
        Me.BedtypeTextBox1.Name = "BedtypeTextBox1"
        Me.BedtypeTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.BedtypeTextBox1.TabIndex = 10
        '
        'ChargeperdayTextBox1
        '
        Me.ChargeperdayTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Chargeperday", True))
        Me.ChargeperdayTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeperdayTextBox1.Location = New System.Drawing.Point(111, 139)
        Me.ChargeperdayTextBox1.Name = "ChargeperdayTextBox1"
        Me.ChargeperdayTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.ChargeperdayTextBox1.TabIndex = 12
        '
        'BedchargeTextBox1
        '
        Me.BedchargeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Bedcharge", True))
        Me.BedchargeTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BedchargeTextBox1.Location = New System.Drawing.Point(111, 165)
        Me.BedchargeTextBox1.Name = "BedchargeTextBox1"
        Me.BedchargeTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.BedchargeTextBox1.TabIndex = 14
        '
        'OperationotherTextBox1
        '
        Me.OperationotherTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Operationother", True))
        Me.OperationotherTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperationotherTextBox1.Location = New System.Drawing.Point(111, 191)
        Me.OperationotherTextBox1.Name = "OperationotherTextBox1"
        Me.OperationotherTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.OperationotherTextBox1.TabIndex = 16
        '
        'TotalTextBox1
        '
        Me.TotalTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource1, "Total", True))
        Me.TotalTextBox1.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox1.Location = New System.Drawing.Point(111, 217)
        Me.TotalTextBox1.Name = "TotalTextBox1"
        Me.TotalTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.TotalTextBox1.TabIndex = 18
        '
        'BtnBACK
        '
        Me.BtnBACK.BackColor = System.Drawing.Color.Orange
        Me.BtnBACK.Location = New System.Drawing.Point(454, 219)
        Me.BtnBACK.Name = "BtnBACK"
        Me.BtnBACK.Size = New System.Drawing.Size(75, 23)
        Me.BtnBACK.TabIndex = 19
        Me.BtnBACK.Text = "BACK"
        Me.BtnBACK.UseVisualStyleBackColor = False
        '
        'frmBill
        '
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(860, 571)
        Me.Controls.Add(Me.BtnBACK)
        Me.Controls.Add(RegnoLabel)
        Me.Controls.Add(Me.RegnoTextBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(AdmitdateLabel)
        Me.Controls.Add(Me.AdmitdateDateTimePicker1)
        Me.Controls.Add(DischargedateLabel)
        Me.Controls.Add(Me.DischargedateDateTimePicker1)
        Me.Controls.Add(BedtypeLabel)
        Me.Controls.Add(Me.BedtypeTextBox1)
        Me.Controls.Add(ChargeperdayLabel)
        Me.Controls.Add(Me.ChargeperdayTextBox1)
        Me.Controls.Add(BedchargeLabel)
        Me.Controls.Add(Me.BedchargeTextBox1)
        Me.Controls.Add(OperationotherLabel)
        Me.Controls.Add(Me.OperationotherTextBox1)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox1)
        Me.Controls.Add(Me.BillDataGridView1)
        Me.Name = "frmBill"
        CType(Me.HmDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HmDataSet As WindowsApplication1.hmDataSet
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter As WindowsApplication1.hmDataSetTableAdapters.BillTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BillDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmitdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DischargedateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BedtypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChargeperdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BedchargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OperationotherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HmDataSet1 As WindowsApplication1.hmDataSet
    Friend WithEvents BillBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter1 As WindowsApplication1.hmDataSetTableAdapters.BillTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BillDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegnoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AdmitdateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DischargedateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BedtypeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ChargeperdayTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BedchargeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OperationotherTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnBACK As Button
End Class
