<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmitPatient
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
        Me.HmDataSet = New WindowsApplication1.hmDataSet()
        Me.AdmitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmitTableAdapter = New WindowsApplication1.hmDataSetTableAdapters.AdmitTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager()
        Me.AdmitDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegnoTextBox = New System.Windows.Forms.TextBox()
        Me.BedcategoryTextBox = New System.Windows.Forms.TextBox()
        Me.BednoTextBox = New System.Windows.Forms.TextBox()
        Me.ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AdmitdatetimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DiseaseTextBox = New System.Windows.Forms.TextBox()
        Me.BloodgroupTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
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
        CType(Me.HmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegnoLabel
        '
        RegnoLabel.AutoSize = True
        RegnoLabel.BackColor = System.Drawing.Color.Coral
        RegnoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        RegnoLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RegnoLabel.Location = New System.Drawing.Point(0, 4)
        RegnoLabel.Name = "RegnoLabel"
        RegnoLabel.Size = New System.Drawing.Size(45, 19)
        RegnoLabel.TabIndex = 1
        RegnoLabel.Text = "Regno:"
        '
        'BedcategoryLabel
        '
        BedcategoryLabel.AutoSize = True
        BedcategoryLabel.BackColor = System.Drawing.Color.Coral
        BedcategoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        BedcategoryLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BedcategoryLabel.Location = New System.Drawing.Point(0, 30)
        BedcategoryLabel.Name = "BedcategoryLabel"
        BedcategoryLabel.Size = New System.Drawing.Size(80, 19)
        BedcategoryLabel.TabIndex = 3
        BedcategoryLabel.Text = "Bedcategory:"
        '
        'BednoLabel
        '
        BednoLabel.AutoSize = True
        BednoLabel.BackColor = System.Drawing.Color.Coral
        BednoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        BednoLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BednoLabel.Location = New System.Drawing.Point(0, 56)
        BednoLabel.Name = "BednoLabel"
        BednoLabel.Size = New System.Drawing.Size(46, 19)
        BednoLabel.TabIndex = 5
        BednoLabel.Text = "Bedno:"
        '
        'ChargeLabel
        '
        ChargeLabel.AutoSize = True
        ChargeLabel.BackColor = System.Drawing.Color.Coral
        ChargeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        ChargeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChargeLabel.Location = New System.Drawing.Point(0, 82)
        ChargeLabel.Name = "ChargeLabel"
        ChargeLabel.Size = New System.Drawing.Size(51, 19)
        ChargeLabel.TabIndex = 7
        ChargeLabel.Text = "Charge:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Coral
        NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        NameLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(0, 108)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(44, 19)
        NameLabel.TabIndex = 9
        NameLabel.Text = "Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.Coral
        AgeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        AgeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(0, 134)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(33, 19)
        AgeLabel.TabIndex = 11
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Coral
        AddressLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        AddressLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(0, 160)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(57, 19)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.Coral
        PhoneLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        PhoneLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(0, 186)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(46, 19)
        PhoneLabel.TabIndex = 15
        PhoneLabel.Text = "Phone:"
        '
        'AdmitdatetimeLabel
        '
        AdmitdatetimeLabel.AutoSize = True
        AdmitdatetimeLabel.BackColor = System.Drawing.Color.Coral
        AdmitdatetimeLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdmitdatetimeLabel.Location = New System.Drawing.Point(295, 1)
        AdmitdatetimeLabel.Name = "AdmitdatetimeLabel"
        AdmitdatetimeLabel.Size = New System.Drawing.Size(96, 19)
        AdmitdatetimeLabel.TabIndex = 17
        AdmitdatetimeLabel.Text = "Admitdatetime:"
        '
        'DiseaseLabel
        '
        DiseaseLabel.AutoSize = True
        DiseaseLabel.BackColor = System.Drawing.Color.Coral
        DiseaseLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiseaseLabel.Location = New System.Drawing.Point(295, 26)
        DiseaseLabel.Name = "DiseaseLabel"
        DiseaseLabel.Size = New System.Drawing.Size(52, 19)
        DiseaseLabel.TabIndex = 19
        DiseaseLabel.Text = "Disease:"
        '
        'BloodgroupLabel
        '
        BloodgroupLabel.AutoSize = True
        BloodgroupLabel.BackColor = System.Drawing.Color.Coral
        BloodgroupLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BloodgroupLabel.Location = New System.Drawing.Point(295, 52)
        BloodgroupLabel.Name = "BloodgroupLabel"
        BloodgroupLabel.Size = New System.Drawing.Size(74, 19)
        BloodgroupLabel.TabIndex = 21
        BloodgroupLabel.Text = "Bloodgroup:"
        '
        'DoctorLabel
        '
        DoctorLabel.AutoSize = True
        DoctorLabel.BackColor = System.Drawing.Color.Coral
        DoctorLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DoctorLabel.Location = New System.Drawing.Point(295, 78)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New System.Drawing.Size(50, 19)
        DoctorLabel.TabIndex = 23
        DoctorLabel.Text = "Doctor:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.BackColor = System.Drawing.Color.Coral
        RemarksLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarksLabel.Location = New System.Drawing.Point(295, 104)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(60, 19)
        RemarksLabel.TabIndex = 25
        RemarksLabel.Text = "Remarks:"
        '
        'HmDataSet
        '
        Me.HmDataSet.DataSetName = "hmDataSet"
        Me.HmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdmitBindingSource
        '
        Me.AdmitBindingSource.DataMember = "Admit"
        Me.AdmitBindingSource.DataSource = Me.HmDataSet
        '
        'AdmitTableAdapter
        '
        Me.AdmitTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdmitTableAdapter = Me.AdmitTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.dischargeTableAdapter = Nothing
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdmitDataGridView
        '
        Me.AdmitDataGridView.AutoGenerateColumns = False
        Me.AdmitDataGridView.BackgroundColor = System.Drawing.Color.Aquamarine
        Me.AdmitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdmitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.AdmitDataGridView.DataSource = Me.AdmitBindingSource
        Me.AdmitDataGridView.Location = New System.Drawing.Point(3, 254)
        Me.AdmitDataGridView.Name = "AdmitDataGridView"
        Me.AdmitDataGridView.Size = New System.Drawing.Size(1368, 220)
        Me.AdmitDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Regno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Regno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bedcategory"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bedcategory"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bedno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bedno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Charge"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Charge"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Admitdatetime"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Admitdatetime"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Disease"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Disease"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Bloodgroup"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Bloodgroup"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Doctor"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Doctor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'RegnoTextBox
        '
        Me.RegnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Regno", True))
        Me.RegnoTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegnoTextBox.Location = New System.Drawing.Point(82, 1)
        Me.RegnoTextBox.Name = "RegnoTextBox"
        Me.RegnoTextBox.Size = New System.Drawing.Size(200, 27)
        Me.RegnoTextBox.TabIndex = 2
        '
        'BedcategoryTextBox
        '
        Me.BedcategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Bedcategory", True))
        Me.BedcategoryTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BedcategoryTextBox.Location = New System.Drawing.Point(82, 27)
        Me.BedcategoryTextBox.Name = "BedcategoryTextBox"
        Me.BedcategoryTextBox.Size = New System.Drawing.Size(200, 27)
        Me.BedcategoryTextBox.TabIndex = 4
        '
        'BednoTextBox
        '
        Me.BednoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Bedno", True))
        Me.BednoTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BednoTextBox.Location = New System.Drawing.Point(82, 53)
        Me.BednoTextBox.Name = "BednoTextBox"
        Me.BednoTextBox.Size = New System.Drawing.Size(200, 27)
        Me.BednoTextBox.TabIndex = 6
        '
        'ChargeTextBox
        '
        Me.ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Charge", True))
        Me.ChargeTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargeTextBox.Location = New System.Drawing.Point(82, 79)
        Me.ChargeTextBox.Name = "ChargeTextBox"
        Me.ChargeTextBox.Size = New System.Drawing.Size(200, 27)
        Me.ChargeTextBox.TabIndex = 8
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(82, 105)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 27)
        Me.NameTextBox.TabIndex = 10
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(82, 131)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 27)
        Me.AgeTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(82, 157)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 27)
        Me.AddressTextBox.TabIndex = 14
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(82, 183)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 27)
        Me.PhoneTextBox.TabIndex = 16
        '
        'AdmitdatetimeDateTimePicker
        '
        Me.AdmitdatetimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdmitBindingSource, "Admitdatetime", True))
        Me.AdmitdatetimeDateTimePicker.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmitdatetimeDateTimePicker.Location = New System.Drawing.Point(398, 1)
        Me.AdmitdatetimeDateTimePicker.Name = "AdmitdatetimeDateTimePicker"
        Me.AdmitdatetimeDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.AdmitdatetimeDateTimePicker.TabIndex = 18
        '
        'DiseaseTextBox
        '
        Me.DiseaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Disease", True))
        Me.DiseaseTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiseaseTextBox.Location = New System.Drawing.Point(398, 27)
        Me.DiseaseTextBox.Name = "DiseaseTextBox"
        Me.DiseaseTextBox.Size = New System.Drawing.Size(200, 27)
        Me.DiseaseTextBox.TabIndex = 20
        '
        'BloodgroupTextBox
        '
        Me.BloodgroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Bloodgroup", True))
        Me.BloodgroupTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodgroupTextBox.Location = New System.Drawing.Point(398, 53)
        Me.BloodgroupTextBox.Name = "BloodgroupTextBox"
        Me.BloodgroupTextBox.Size = New System.Drawing.Size(200, 27)
        Me.BloodgroupTextBox.TabIndex = 22
        '
        'DoctorTextBox
        '
        Me.DoctorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Doctor", True))
        Me.DoctorTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorTextBox.Location = New System.Drawing.Point(398, 79)
        Me.DoctorTextBox.Name = "DoctorTextBox"
        Me.DoctorTextBox.Size = New System.Drawing.Size(200, 27)
        Me.DoctorTextBox.TabIndex = 24
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmitBindingSource, "Remarks", True))
        Me.RemarksTextBox.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksTextBox.Location = New System.Drawing.Point(398, 105)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(200, 27)
        Me.RemarksTextBox.TabIndex = 26
        '
        'BtnBACK
        '
        Me.BtnBACK.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnBACK.Location = New System.Drawing.Point(398, 187)
        Me.BtnBACK.Name = "BtnBACK"
        Me.BtnBACK.Size = New System.Drawing.Size(75, 23)
        Me.BtnBACK.TabIndex = 27
        Me.BtnBACK.Text = "BACK"
        Me.BtnBACK.UseVisualStyleBackColor = False
        '
        'frmAdmitPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(1351, 486)
        Me.Controls.Add(Me.BtnBACK)
        Me.Controls.Add(RegnoLabel)
        Me.Controls.Add(Me.RegnoTextBox)
        Me.Controls.Add(BedcategoryLabel)
        Me.Controls.Add(Me.BedcategoryTextBox)
        Me.Controls.Add(BednoLabel)
        Me.Controls.Add(Me.BednoTextBox)
        Me.Controls.Add(ChargeLabel)
        Me.Controls.Add(Me.ChargeTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(AdmitdatetimeLabel)
        Me.Controls.Add(Me.AdmitdatetimeDateTimePicker)
        Me.Controls.Add(DiseaseLabel)
        Me.Controls.Add(Me.DiseaseTextBox)
        Me.Controls.Add(BloodgroupLabel)
        Me.Controls.Add(Me.BloodgroupTextBox)
        Me.Controls.Add(DoctorLabel)
        Me.Controls.Add(Me.DoctorTextBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.AdmitDataGridView)
        Me.Name = "frmAdmitPatient"
        Me.Text = "ADMIT PATIENT"
        CType(Me.HmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HmDataSet As WindowsApplication1.hmDataSet
    Friend WithEvents AdmitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdmitTableAdapter As WindowsApplication1.hmDataSetTableAdapters.AdmitTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdmitDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents BtnBACK As Button
End Class
