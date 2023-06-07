<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctor
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim JoiningDateLabel As System.Windows.Forms.Label
        Me.HmDataSet1 = New WindowsApplication1.hmDataSet()
        Me.DoctorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorsTableAdapter1 = New WindowsApplication1.hmDataSetTableAdapters.DoctorsTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager()
        Me.DoctorsDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.JoiningDateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnBACK = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        JoiningDateLabel = New System.Windows.Forms.Label()
        CType(Me.HmDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.DarkKhaki
        IDLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(7, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 19)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.DarkKhaki
        NameLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(7, 35)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(44, 19)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.DarkKhaki
        AddressLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(7, 61)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(57, 19)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.DarkKhaki
        PhoneLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(7, 87)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(46, 19)
        PhoneLabel.TabIndex = 7
        PhoneLabel.Text = "Phone:"
        '
        'JoiningDateLabel
        '
        JoiningDateLabel.AutoSize = True
        JoiningDateLabel.BackColor = System.Drawing.Color.DarkKhaki
        JoiningDateLabel.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JoiningDateLabel.Location = New System.Drawing.Point(7, 114)
        JoiningDateLabel.Name = "JoiningDateLabel"
        JoiningDateLabel.Size = New System.Drawing.Size(81, 19)
        JoiningDateLabel.TabIndex = 9
        JoiningDateLabel.Text = "Joining Date:"
        '
        'HmDataSet1
        '
        Me.HmDataSet1.DataSetName = "hmDataSet"
        Me.HmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorsBindingSource1
        '
        Me.DoctorsBindingSource1.DataMember = "Doctors"
        Me.DoctorsBindingSource1.DataSource = Me.HmDataSet1
        '
        'DoctorsTableAdapter1
        '
        Me.DoctorsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdmitTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BillTableAdapter = Nothing
        Me.TableAdapterManager1.dischargeTableAdapter = Nothing
        Me.TableAdapterManager1.DoctorsTableAdapter = Me.DoctorsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DoctorsDataGridView1
        '
        Me.DoctorsDataGridView1.AutoGenerateColumns = False
        Me.DoctorsDataGridView1.BackgroundColor = System.Drawing.Color.Aqua
        Me.DoctorsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorsDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DoctorsDataGridView1.DataSource = Me.DoctorsBindingSource1
        Me.DoctorsDataGridView1.Location = New System.Drawing.Point(10, 198)
        Me.DoctorsDataGridView1.Name = "DoctorsDataGridView1"
        Me.DoctorsDataGridView1.Size = New System.Drawing.Size(300, 220)
        Me.DoctorsDataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "JoiningDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "JoiningDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource1, "ID", True))
        Me.IDTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox1.Location = New System.Drawing.Point(100, 6)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.IDTextBox1.TabIndex = 2
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource1, "Name", True))
        Me.NameTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox1.Location = New System.Drawing.Point(100, 32)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.NameTextBox1.TabIndex = 4
        '
        'AddressTextBox1
        '
        Me.AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource1, "Address", True))
        Me.AddressTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox1.Location = New System.Drawing.Point(100, 58)
        Me.AddressTextBox1.Name = "AddressTextBox1"
        Me.AddressTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.AddressTextBox1.TabIndex = 6
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource1, "Phone", True))
        Me.PhoneTextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(100, 84)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.PhoneTextBox1.TabIndex = 8
        '
        'JoiningDateDateTimePicker1
        '
        Me.JoiningDateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DoctorsBindingSource1, "JoiningDate", True))
        Me.JoiningDateDateTimePicker1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JoiningDateDateTimePicker1.Location = New System.Drawing.Point(100, 110)
        Me.JoiningDateDateTimePicker1.Name = "JoiningDateDateTimePicker1"
        Me.JoiningDateDateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.JoiningDateDateTimePicker1.TabIndex = 10
        '
        'BtnBACK
        '
        Me.BtnBACK.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnBACK.Location = New System.Drawing.Point(359, 114)
        Me.BtnBACK.Name = "BtnBACK"
        Me.BtnBACK.Size = New System.Drawing.Size(75, 23)
        Me.BtnBACK.TabIndex = 11
        Me.BtnBACK.Text = "BACK"
        Me.BtnBACK.UseVisualStyleBackColor = False
        '
        'frmDoctor
        '
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(608, 582)
        Me.Controls.Add(Me.BtnBACK)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox1)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox1)
        Me.Controls.Add(JoiningDateLabel)
        Me.Controls.Add(Me.JoiningDateDateTimePicker1)
        Me.Controls.Add(Me.DoctorsDataGridView1)
        Me.Name = "frmDoctor"
        CType(Me.HmDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HmDataSet As WindowsApplication1.hmDataSet
    Friend WithEvents DoctorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorsTableAdapter As WindowsApplication1.hmDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JoiningDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HmDataSet1 As WindowsApplication1.hmDataSet
    Friend WithEvents DoctorsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorsTableAdapter1 As WindowsApplication1.hmDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.hmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorsDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents JoiningDateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBACK As Button
End Class
