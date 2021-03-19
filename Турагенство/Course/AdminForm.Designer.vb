<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.УправлениеОтелямиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Phones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassSave = New System.Windows.Forms.Button()
        Me.PassNewConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PassNew = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PassOld = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CountriesGrid = New System.Windows.Forms.DataGridView()
        Me.СтраныBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryPages = New System.Windows.Forms.TabControl()
        Me.CountryAdd = New System.Windows.Forms.TabPage()
        Me.AddCountry = New System.Windows.Forms.Button()
        Me.CountryAddName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CountryEdit = New System.Windows.Forms.TabPage()
        Me.CountryEditDelete = New System.Windows.Forms.LinkLabel()
        Me.CountryEditApply = New System.Windows.Forms.Button()
        Me.CountryEditName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TransportGrid = New System.Windows.Forms.DataGridView()
        Me.ВидыТранспортаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransportAddName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.СтраныTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter()
        Me.TableAdapterManager1 = New Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager()
        Me.ВидыТранспортаTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.ВидыТранспортаTableAdapter()
        Me.ТурагнетсвоDataSet = New Course.ТурагнетсвоDataSet()
        Me.УправлениеТранспортнымиПунктамиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.CountriesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CountryPages.SuspendLayout()
        Me.CountryAdd.SuspendLayout()
        Me.CountryEdit.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.TransportGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВидыТранспортаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УправлениеТранспортнымиПунктамиToolStripMenuItem, Me.УправлениеОтелямиToolStripMenuItem, Me.ОтчётыToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(889, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'УправлениеОтелямиToolStripMenuItem
        '
        Me.УправлениеОтелямиToolStripMenuItem.Name = "УправлениеОтелямиToolStripMenuItem"
        Me.УправлениеОтелямиToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.УправлениеОтелямиToolStripMenuItem.Text = "Управление отелями"
        '
        'ОтчётыToolStripMenuItem
        '
        Me.ОтчётыToolStripMenuItem.Enabled = False
        Me.ОтчётыToolStripMenuItem.Name = "ОтчётыToolStripMenuItem"
        Me.ОтчётыToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ОтчётыToolStripMenuItem.Text = "Отчёты"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(889, 526)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Служебная информация"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Phones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PassSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PassNewConfirm)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PassNew)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PassOld)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(877, 238)
        Me.SplitContainer1.SplitterDistance = 435
        Me.SplitContainer1.TabIndex = 0
        '
        'Phones
        '
        Me.Phones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Phones.Location = New System.Drawing.Point(3, 16)
        Me.Phones.Multiline = True
        Me.Phones.Name = "Phones"
        Me.Phones.Size = New System.Drawing.Size(429, 219)
        Me.Phones.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Номера телефонов"
        '
        'PassSave
        '
        Me.PassSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassSave.Location = New System.Drawing.Point(6, 120)
        Me.PassSave.Name = "PassSave"
        Me.PassSave.Size = New System.Drawing.Size(426, 23)
        Me.PassSave.TabIndex = 6
        Me.PassSave.Text = "Сохранить"
        Me.PassSave.UseVisualStyleBackColor = True
        '
        'PassNewConfirm
        '
        Me.PassNewConfirm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassNewConfirm.Location = New System.Drawing.Point(6, 94)
        Me.PassNewConfirm.Name = "PassNewConfirm"
        Me.PassNewConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassNewConfirm.Size = New System.Drawing.Size(426, 20)
        Me.PassNewConfirm.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Новый пароль (ещё раз)"
        '
        'PassNew
        '
        Me.PassNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassNew.Location = New System.Drawing.Point(6, 55)
        Me.PassNew.Name = "PassNew"
        Me.PassNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassNew.Size = New System.Drawing.Size(426, 20)
        Me.PassNew.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Новый пароль"
        '
        'PassOld
        '
        Me.PassOld.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassOld.Location = New System.Drawing.Point(6, 16)
        Me.PassOld.Name = "PassOld"
        Me.PassOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassOld.Size = New System.Drawing.Size(426, 20)
        Me.PassOld.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Пароль администратора"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 257)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Управление странами"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.CountriesGrid)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CountryPages)
        Me.SplitContainer2.Size = New System.Drawing.Size(432, 238)
        Me.SplitContainer2.SplitterDistance = 226
        Me.SplitContainer2.TabIndex = 2
        '
        'CountriesGrid
        '
        Me.CountriesGrid.AllowUserToAddRows = False
        Me.CountriesGrid.AllowUserToDeleteRows = False
        Me.CountriesGrid.AutoGenerateColumns = False
        Me.CountriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CountriesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CountriesGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.CountriesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CountriesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CountriesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CountriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CountriesGrid.DataSource = Me.СтраныBindingSource
        Me.CountriesGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CountriesGrid.GridColor = System.Drawing.SystemColors.Control
        Me.CountriesGrid.Location = New System.Drawing.Point(0, 0)
        Me.CountriesGrid.MultiSelect = False
        Me.CountriesGrid.Name = "CountriesGrid"
        Me.CountriesGrid.ReadOnly = True
        Me.CountriesGrid.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.CountriesGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CountriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CountriesGrid.Size = New System.Drawing.Size(226, 238)
        Me.CountriesGrid.TabIndex = 8
        '
        'CountryPages
        '
        Me.CountryPages.Controls.Add(Me.CountryAdd)
        Me.CountryPages.Controls.Add(Me.CountryEdit)
        Me.CountryPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CountryPages.Location = New System.Drawing.Point(0, 0)
        Me.CountryPages.Name = "CountryPages"
        Me.CountryPages.SelectedIndex = 0
        Me.CountryPages.Size = New System.Drawing.Size(202, 238)
        Me.CountryPages.TabIndex = 0
        '
        'CountryAdd
        '
        Me.CountryAdd.Controls.Add(Me.AddCountry)
        Me.CountryAdd.Controls.Add(Me.CountryAddName)
        Me.CountryAdd.Controls.Add(Me.Label5)
        Me.CountryAdd.Location = New System.Drawing.Point(4, 22)
        Me.CountryAdd.Name = "CountryAdd"
        Me.CountryAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.CountryAdd.Size = New System.Drawing.Size(194, 212)
        Me.CountryAdd.TabIndex = 0
        Me.CountryAdd.Text = "Добавление"
        Me.CountryAdd.UseVisualStyleBackColor = True
        '
        'AddCountry
        '
        Me.AddCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddCountry.Location = New System.Drawing.Point(3, 45)
        Me.AddCountry.Name = "AddCountry"
        Me.AddCountry.Size = New System.Drawing.Size(188, 23)
        Me.AddCountry.TabIndex = 7
        Me.AddCountry.Text = "Добавить"
        Me.AddCountry.UseVisualStyleBackColor = True
        '
        'CountryAddName
        '
        Me.CountryAddName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryAddName.Location = New System.Drawing.Point(3, 19)
        Me.CountryAddName.Name = "CountryAddName"
        Me.CountryAddName.Size = New System.Drawing.Size(188, 20)
        Me.CountryAddName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Название страны"
        '
        'CountryEdit
        '
        Me.CountryEdit.Controls.Add(Me.CountryEditDelete)
        Me.CountryEdit.Controls.Add(Me.CountryEditApply)
        Me.CountryEdit.Controls.Add(Me.CountryEditName)
        Me.CountryEdit.Controls.Add(Me.Label6)
        Me.CountryEdit.Location = New System.Drawing.Point(4, 22)
        Me.CountryEdit.Name = "CountryEdit"
        Me.CountryEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.CountryEdit.Size = New System.Drawing.Size(194, 212)
        Me.CountryEdit.TabIndex = 1
        Me.CountryEdit.Text = "Изменение"
        Me.CountryEdit.UseVisualStyleBackColor = True
        '
        'CountryEditDelete
        '
        Me.CountryEditDelete.AutoSize = True
        Me.CountryEditDelete.Location = New System.Drawing.Point(138, 50)
        Me.CountryEditDelete.Name = "CountryEditDelete"
        Me.CountryEditDelete.Size = New System.Drawing.Size(50, 13)
        Me.CountryEditDelete.TabIndex = 11
        Me.CountryEditDelete.TabStop = True
        Me.CountryEditDelete.Text = "Удалить"
        '
        'CountryEditApply
        '
        Me.CountryEditApply.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryEditApply.Location = New System.Drawing.Point(3, 45)
        Me.CountryEditApply.Name = "CountryEditApply"
        Me.CountryEditApply.Size = New System.Drawing.Size(129, 23)
        Me.CountryEditApply.TabIndex = 10
        Me.CountryEditApply.Text = "Изменить"
        Me.CountryEditApply.UseVisualStyleBackColor = True
        '
        'CountryEditName
        '
        Me.CountryEditName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryEditName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтраныBindingSource, "Название", True))
        Me.CountryEditName.Location = New System.Drawing.Point(3, 19)
        Me.CountryEditName.Name = "CountryEditName"
        Me.CountryEditName.Size = New System.Drawing.Size(188, 20)
        Me.CountryEditName.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Название страны"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SplitContainer3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(447, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 257)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Управление видами транспортов"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TransportGrid)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(433, 238)
        Me.SplitContainer3.SplitterDistance = 217
        Me.SplitContainer3.TabIndex = 2
        '
        'TransportGrid
        '
        Me.TransportGrid.AllowUserToAddRows = False
        Me.TransportGrid.AllowUserToDeleteRows = False
        Me.TransportGrid.AutoGenerateColumns = False
        Me.TransportGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TransportGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TransportGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TransportGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransportGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TransportGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TransportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransportGrid.DataSource = Me.ВидыТранспортаBindingSource
        Me.TransportGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransportGrid.GridColor = System.Drawing.SystemColors.Control
        Me.TransportGrid.Location = New System.Drawing.Point(0, 0)
        Me.TransportGrid.MultiSelect = False
        Me.TransportGrid.Name = "TransportGrid"
        Me.TransportGrid.ReadOnly = True
        Me.TransportGrid.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.TransportGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.TransportGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TransportGrid.Size = New System.Drawing.Size(217, 238)
        Me.TransportGrid.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(212, 238)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TransportAddName)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(204, 212)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Добавление"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(3, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransportAddName
        '
        Me.TransportAddName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransportAddName.Location = New System.Drawing.Point(3, 19)
        Me.TransportAddName.Name = "TransportAddName"
        Me.TransportAddName.Size = New System.Drawing.Size(198, 20)
        Me.TransportAddName.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Название транспорта"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(204, 212)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Изменение"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(144, 50)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Удалить"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(3, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Изменить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВидыТранспортаBindingSource, "Название", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(3, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(194, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Название транспорта"
        '
        'СтраныTableAdapter
        '
        Me.СтраныTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ВидыТранспортаTableAdapter = Me.ВидыТранспортаTableAdapter
        Me.TableAdapterManager1.ОтелиTableAdapter = Nothing
        Me.TableAdapterManager1.СтраныTableAdapter = Me.СтраныTableAdapter
        Me.TableAdapterManager1.ТранспортныеПунктыTableAdapter = Nothing
        '
        'ВидыТранспортаTableAdapter
        '
        Me.ВидыТранспортаTableAdapter.ClearBeforeFill = True
        '
        'ТурагнетсвоDataSet
        '
        Me.ТурагнетсвоDataSet.DataSetName = "ТурагнетсвоDataSet"
        Me.ТурагнетсвоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'УправлениеТранспортнымиПунктамиToolStripMenuItem
        '
        Me.УправлениеТранспортнымиПунктамиToolStripMenuItem.Name = "УправлениеТранспортнымиПунктамиToolStripMenuItem"
        Me.УправлениеТранспортнымиПунктамиToolStripMenuItem.Size = New System.Drawing.Size(233, 20)
        Me.УправлениеТранспортнымиПунктамиToolStripMenuItem.Text = "Управление транспортными пунктами"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 550)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Форма администратора"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.CountriesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CountryPages.ResumeLayout(False)
        Me.CountryAdd.ResumeLayout(False)
        Me.CountryAdd.PerformLayout()
        Me.CountryEdit.ResumeLayout(False)
        Me.CountryEdit.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.TransportGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВидыТранспортаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ОтчётыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Phones As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PassSave As Button
    Friend WithEvents PassNewConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PassNew As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PassOld As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents СтраныBindingSource As BindingSource
    Friend WithEvents СтраныTableAdapter As ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents CountriesGrid As DataGridView
    Friend WithEvents CountryPages As TabControl
    Friend WithEvents CountryAdd As TabPage
    Friend WithEvents AddCountry As Button
    Friend WithEvents CountryAddName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CountryEdit As TabPage
    Friend WithEvents CountryEditDelete As LinkLabel
    Friend WithEvents CountryEditApply As Button
    Friend WithEvents CountryEditName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TableAdapterManager1 As ТурагнетсвоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents TransportGrid As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TransportAddName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ВидыТранспортаTableAdapter As ТурагнетсвоDataSetTableAdapters.ВидыТранспортаTableAdapter
    Friend WithEvents ВидыТранспортаBindingSource As BindingSource
    Friend WithEvents УправлениеОтелямиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТурагнетсвоDataSet As Course.ТурагнетсвоDataSet
    Friend WithEvents УправлениеТранспортнымиПунктамиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
