<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDischarge
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
        Dim BedcategoryLabel As System.Windows.Forms.Label
        Dim BednoLabel As System.Windows.Forms.Label
        Dim ChargeLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AdmitdatetimeLabel As System.Windows.Forms.Label
        Dim DiseaseLabel As System.Windows.Forms.Label
        Dim BloodgroupLabel As System.Windows.Forms.Label
        Dim DoctorLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim DischargedateLabel As System.Windows.Forms.Label
        Me.HmDataSet1 = New WindowsApplication1.hmDataSet()
        Me.DischargeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DischargeTableAdapter1 = New WindowsApplication1.hmDataSetTableAdapters.dischargeTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager()
        Me.DischargeDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegnoTextBox1 = New System.Windows.Forms.TextBox()
        Me.BedcategoryTextBox1 = New System.Windows.Forms.TextBox()
        Me.BednoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ChargeTextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AgeTextBox1 = New System.Windows.Forms.TextBox()
        Me.AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.AdmitdatetimeDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DiseaseTextBox1 = New System.Windows.Forms.TextBox()
        Me.BloodgroupTextBox1 = New System.Windows.Forms.TextBox()
        Me.DoctorTextBox1 = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox1 = New System.Windows.Forms.TextBox()
        Me.DischargedateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnBACK = New System.Windows.Forms.Button()
        RegnoLabel = New System.Windows.Forms.Label()
        BedcategoryLabel = New System.Windows.Forms.Label()
        BednoLabel = New System.Windows.Forms.Label()
        ChargeLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AdmitdatetimeLabel = New System.Windows.Forms.Label()
        DiseaseLabel = New System.Windows.Forms.Label()
        BloodgroupLabel = New System.Windows.Forms.Label()
        DoctorLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        DischargedateLabel = New System.Windows.Forms.Label()
        CType(Me.HmDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DischargeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DischargeDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegnoLabel
        '
        RegnoLabel.AutoSize = True
        RegnoLabel.BackColor = System.Drawing.Color.Cyan
        RegnoLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RegnoLabel.Location = New System.Drawing.Point(8, 6)
        RegnoLabel.Name = "RegnoLabel"
        RegnoLabel.Size = New System.Drawing.Size(45, 19)
        RegnoLabel.TabIndex = 1
        RegnoLabel.Text = "Regno:"
        '
        'BedcategoryLabel
        '
        BedcategoryLabel.AutoSize = True
        BedcategoryLabel.BackColor = System.Drawing.Color.Cyan
        BedcategoryLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BedcategoryLabel.Location = New System.Drawing.Point(8, 32)
        BedcategoryLabel.Name = "BedcategoryLabel"
        BedcategoryLabel.Size = New System.Drawing.Size(80, 19)
        BedcategoryLabel.TabIndex = 3
        BedcategoryLabel.Text = "Bedcategory:"
        '
        'BednoLabel
        '
        BednoLabel.AutoSize = True
        BednoLabel.BackColor = System.Drawing.Color.Cyan
        BednoLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BednoLabel.Location = New System.Drawing.Point(8, 58)
        BednoLabel.Name = "BednoLabel"
        BednoLabel.Size = New System.Drawing.Size(46, 19)
        BednoLabel.TabIndex = 5
        BednoLabel.Text = "Bedno:"
        '
        'ChargeLabel
        '
        ChargeLabel.AutoSize = True
        ChargeLabel.BackColor = System.Drawing.Color.Cyan
        ChargeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChargeLabel.Location = New System.Drawing.Point(8, 84)
        ChargeLabel.Name = "ChargeLabel"
        ChargeLabel.Size = New System.Drawing.Size(51, 19)
        ChargeLabel.TabIndex = 7
        ChargeLabel.Text = "Charge:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Cyan
        NameLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(8, 110)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(44, 19)
        NameLabel.TabIndex = 9
        NameLabel.Text = "Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.Cyan
        AgeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(8, 136)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(33, 19)
        AgeLabel.TabIndex = 11
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Cyan
        AddressLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(8, 162)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(57, 19)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.Cyan
        PhoneLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(8, 188)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(46, 19)
        PhoneLabel.TabIndex = 15
        PhoneLabel.Text = "Phone:"
        '
        'AdmitdatetimeLabel
        '
        AdmitdatetimeLabel.AutoSize = True
        AdmitdatetimeLabel.BackColor = System.Drawing.Color.Cyan
        AdmitdatetimeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdmitdatetimeLabel.Location = New System.Drawing.Point(326, 6)
        AdmitdatetimeLabel.Name = "AdmitdatetimeLabel"
        AdmitdatetimeLabel.Size = New System.Drawing.Size(96, 19)
        AdmitdatetimeLabel.TabIndex = 17
        AdmitdatetimeLabel.Text = "Admitdatetime:"
        AddHandler AdmitdatetimeLabel.Click, AddressOf Me.AdmitdatetimeLabel_Click
        '
        'DiseaseLabel
        '
        DiseaseLabel.AutoSize = True
        DiseaseLabel.BackColor = System.Drawing.Color.Cyan
        DiseaseLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiseaseLabel.Location = New System.Drawing.Point(325, 32)
        DiseaseLabel.Name = "DiseaseLabel"
        DiseaseLabel.Size = New System.Drawing.Size(52, 19)
        DiseaseLabel.TabIndex = 19
        DiseaseLabel.Text = "Disease:"
        AddHandler DiseaseLabel.Click, AddressOf Me.DiseaseLabel_Click
        '
        'BloodgroupLabel
        '
        BloodgroupLabel.AutoSize = True
        BloodgroupLabel.BackColor = System.Drawing.Color.Cyan
        BloodgroupLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BloodgroupLabel.Location = New System.Drawing.Point(325, 58)
        BloodgroupLabel.Name = "BloodgroupLabel"
        BloodgroupLabel.Size = New System.Drawing.Size(74, 19)
        BloodgroupLabel.TabIndex = 21
        BloodgroupLabel.Text = "Bloodgroup:"
        AddHandler BloodgroupLabel.Click, AddressOf Me.BloodgroupLabel_Click
        '
        'DoctorLabel
        '
        DoctorLabel.AutoSize = True
        DoctorLabel.BackColor = System.Drawing.Color.Cyan
        DoctorLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DoctorLabel.Location = New System.Drawing.Point(325, 84)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New System.Drawing.Size(50, 19)
        DoctorLabel.TabIndex = 23
        DoctorLabel.Text = "Doctor:"
        AddHandler DoctorLabel.Click, AddressOf Me.DoctorLabel_Click
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.BackColor = System.Drawing.Color.Cyan
        RemarksLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarksLabel.Location = New System.Drawing.Point(325, 110)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(60, 19)
        RemarksLabel.TabIndex = 25
        RemarksLabel.Text = "Remarks:"
        AddHandler RemarksLabel.Click, AddressOf Me.RemarksLabel_Click
        '
        'DischargedateLabel
        '
        DischargedateLabel.AutoSize = True
        DischargedateLabel.BackColor = System.Drawing.Color.Cyan
        DischargedateLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DischargedateLabel.Location = New System.Drawing.Point(325, 136)
        DischargedateLabel.Name = "DischargedateLabel"
        DischargedateLabel.Size = New System.Drawing.Size(90, 19)
        DischargedateLabel.TabIndex = 27
        DischargedateLabel.Text = "Dischargedate:"
        AddHandler DischargedateLabel.Click, AddressOf Me.DischargedateLabel_Click
        '
        'HmDataSet1
        '
        Me.HmDataSet1.DataSetName = "hmDataSet"
        Me.HmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DischargeBindingSource1
        '
        Me.DischargeBindingSource1.DataMember = "discharge"
        Me.DischargeBindingSource1.DataSource = Me.HmDataSet1
        '
        'DischargeTableAdapter1
        '
        Me.DischargeTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdmitTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BillTableAdapter = Nothing
        Me.TableAdapterManager1.dischargeTableAdapter = Me.DischargeTableAdapter1
        Me.TableAdapterManager1.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DischargeDataGridView1
        '
        Me.DischargeDataGridView1.AutoGenerateColumns = False
        Me.DischargeDataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine
        Me.DischargeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DischargeDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.DischargeDataGridView1.DataSource = Me.DischargeBindingSource1
        Me.DischargeDataGridView1.Location = New System.Drawing.Point(11, 312)
        Me.DischargeDataGridView1.Name = "DischargeDataGridView1"
        Me.DischargeDataGridView1.Size = New System.Drawing.Size(1356, 220)
        Me.DischargeDataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Regno"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Regno"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Bedcategory"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Bedcategory"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Bedno"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Bedno"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Charge"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Charge"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Admitdatetime"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Admitdatetime"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Disease"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Disease"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Bloodgroup"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Bloodgroup"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Doctor"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Doctor"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Dischargedate"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Dischargedate"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'RegnoTextBox1
        '
        Me.RegnoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Regno", True))
        Me.RegnoTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegnoTextBox1.Location = New System.Drawing.Point(93, 3)
        Me.RegnoTextBox1.Name = "RegnoTextBox1"
        Me.RegnoTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.RegnoTextBox1.TabIndex = 2
        '
        'BedcategoryTextBox1
        '
        Me.BedcategoryTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Bedcategory", True))
        Me.BedcategoryTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BedcategoryTextBox1.Location = New System.Drawing.Point(93, 29)
        Me.BedcategoryTextBox1.Name = "BedcategoryTextBox1"
        Me.BedcategoryTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.BedcategoryTextBox1.TabIndex = 4
        '
        'BednoTextBox1
        '
        Me.BednoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Bedno", True))
        Me.BednoTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BednoTextBox1.Location = New System.Drawing.Point(93, 55)
        Me.BednoTextBox1.Name = "BednoTextBox1"
        Me.BednoTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.BednoTextBox1.TabIndex = 6
        '
        'ChargeTextBox1
        '
        Me.ChargeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Charge", True))
        Me.ChargeTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeTextBox1.Location = New System.Drawing.Point(93, 81)
        Me.ChargeTextBox1.Name = "ChargeTextBox1"
        Me.ChargeTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.ChargeTextBox1.TabIndex = 8
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Name", True))
        Me.NameTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox1.Location = New System.Drawing.Point(93, 107)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.NameTextBox1.TabIndex = 10
        '
        'AgeTextBox1
        '
        Me.AgeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Age", True))
        Me.AgeTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox1.Location = New System.Drawing.Point(93, 133)
        Me.AgeTextBox1.Name = "AgeTextBox1"
        Me.AgeTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.AgeTextBox1.TabIndex = 12
        '
        'AddressTextBox1
        '
        Me.AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Address", True))
        Me.AddressTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox1.Location = New System.Drawing.Point(93, 159)
        Me.AddressTextBox1.Name = "AddressTextBox1"
        Me.AddressTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.AddressTextBox1.TabIndex = 14
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Phone", True))
        Me.PhoneTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(93, 185)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.PhoneTextBox1.TabIndex = 16
        '
        'AdmitdatetimeDateTimePicker1
        '
        Me.AdmitdatetimeDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DischargeBindingSource1, "Admitdatetime", True))
        Me.AdmitdatetimeDateTimePicker1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmitdatetimeDateTimePicker1.Location = New System.Drawing.Point(428, 3)
        Me.AdmitdatetimeDateTimePicker1.Name = "AdmitdatetimeDateTimePicker1"
        Me.AdmitdatetimeDateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.AdmitdatetimeDateTimePicker1.TabIndex = 18
        '
        'DiseaseTextBox1
        '
        Me.DiseaseTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Disease", True))
        Me.DiseaseTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiseaseTextBox1.Location = New System.Drawing.Point(428, 29)
        Me.DiseaseTextBox1.Name = "DiseaseTextBox1"
        Me.DiseaseTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.DiseaseTextBox1.TabIndex = 20
        '
        'BloodgroupTextBox1
        '
        Me.BloodgroupTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Bloodgroup", True))
        Me.BloodgroupTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodgroupTextBox1.Location = New System.Drawing.Point(428, 55)
        Me.BloodgroupTextBox1.Name = "BloodgroupTextBox1"
        Me.BloodgroupTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.BloodgroupTextBox1.TabIndex = 22
        '
        'DoctorTextBox1
        '
        Me.DoctorTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Doctor", True))
        Me.DoctorTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorTextBox1.Location = New System.Drawing.Point(428, 81)
        Me.DoctorTextBox1.Name = "DoctorTextBox1"
        Me.DoctorTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.DoctorTextBox1.TabIndex = 24
        '
        'RemarksTextBox1
        '
        Me.RemarksTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DischargeBindingSource1, "Remarks", True))
        Me.RemarksTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksTextBox1.Location = New System.Drawing.Point(428, 107)
        Me.RemarksTextBox1.Name = "RemarksTextBox1"
        Me.RemarksTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.RemarksTextBox1.TabIndex = 26
        '
        'DischargedateDateTimePicker1
        '
        Me.DischargedateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DischargeBindingSource1, "Dischargedate", True))
        Me.DischargedateDateTimePicker1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DischargedateDateTimePicker1.Location = New System.Drawing.Point(428, 133)
        Me.DischargedateDateTimePicker1.Name = "DischargedateDateTimePicker1"
        Me.DischargedateDateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.DischargedateDateTimePicker1.TabIndex = 28
        '
        'BtnBACK
        '
        Me.BtnBACK.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnBACK.Location = New System.Drawing.Point(428, 204)
        Me.BtnBACK.Name = "BtnBACK"
        Me.BtnBACK.Size = New System.Drawing.Size(75, 23)
        Me.BtnBACK.TabIndex = 29
        Me.BtnBACK.Text = "BACK"
        Me.BtnBACK.UseVisualStyleBackColor = False
        '
        'frmDischarge
        '
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1370, 531)
        Me.Controls.Add(Me.BtnBACK)
        Me.Controls.Add(RegnoLabel)
        Me.Controls.Add(Me.RegnoTextBox1)
        Me.Controls.Add(BedcategoryLabel)
        Me.Controls.Add(Me.BedcategoryTextBox1)
        Me.Controls.Add(BednoLabel)
        Me.Controls.Add(Me.BednoTextBox1)
        Me.Controls.Add(ChargeLabel)
        Me.Controls.Add(Me.ChargeTextBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox1)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox1)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox1)
        Me.Controls.Add(AdmitdatetimeLabel)
        Me.Controls.Add(Me.AdmitdatetimeDateTimePicker1)
        Me.Controls.Add(DiseaseLabel)
        Me.Controls.Add(Me.DiseaseTextBox1)
        Me.Controls.Add(BloodgroupLabel)
        Me.Controls.Add(Me.BloodgroupTextBox1)
        Me.Controls.Add(DoctorLabel)
        Me.Controls.Add(Me.DoctorTextBox1)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox1)
        Me.Controls.Add(DischargedateLabel)
        Me.Controls.Add(Me.DischargedateDateTimePicker1)
        Me.Controls.Add(Me.DischargeDataGridView1)
        Me.Name = "frmDischarge"
        CType(Me.HmDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DischargeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DischargeDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HmDataSet As WindowsApplication1.hmDataSet
    Friend WithEvents DischargeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DischargeTableAdapter As WindowsApplication1.hmDataSetTableAdapters.dischargeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DischargeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BedcategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BednoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmitdatetimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiseaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodgroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoctorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DischargedateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HmDataSet1 As WindowsApplication1.hmDataSet
    Friend WithEvents DischargeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DischargeTableAdapter1 As WindowsApplication1.hmDataSetTableAdapters.dischargeTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DischargeDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegnoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BedcategoryTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BednoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ChargeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AdmitdatetimeDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiseaseTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BloodgroupTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DoctorTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DischargedateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBACK As Button
End Class
