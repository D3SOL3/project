<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.АдминистрированиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HotelsGrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.РейтингDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKОтелиСтраныBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СтраныBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ТурагнетсвоDataSet = New Course.ТурагнетсвоDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ОтелиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HowToGet = New System.Windows.Forms.LinkLabel()
        Me.RoadsGrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяОтбытияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяПрибытияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяВозвращенияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеВидаТранспорта = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеПунктаОтбытия = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеСтраныПунктаОтбытия = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресПунктаОтбытия = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеПунктаПрибытия = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеСтраныПунктаПрибытия = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресПунктаПрибытия = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Стоимость = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKМаршрутыОтелиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ОтелиTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.ОтелиTableAdapter()
        Me.МаршрутыTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.МаршрутыTableAdapter()
        Me.СтраныTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.HotelsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKОтелиСтраныBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ОтелиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKМаршрутыОтелиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ErrorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.АдминистрированиеToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'АдминистрированиеToolStripMenuItem
        '
        Me.АдминистрированиеToolStripMenuItem.Name = "АдминистрированиеToolStripMenuItem"
        Me.АдминистрированиеToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.АдминистрированиеToolStripMenuItem.Text = "Администрирование"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.HotelsGrid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CountryComboBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ErrorPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1240, 690)
        Me.SplitContainer1.SplitterDistance = 425
        Me.SplitContainer1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Список отелей этой страны"
        '
        'HotelsGrid
        '
        Me.HotelsGrid.AllowUserToAddRows = False
        Me.HotelsGrid.AllowUserToDeleteRows = False
        Me.HotelsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HotelsGrid.AutoGenerateColumns = False
        Me.HotelsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HotelsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HotelsGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.HotelsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HotelsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.HotelsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.HotelsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HotelsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.НазваниеDataGridViewTextBoxColumn, Me.РейтингDataGridViewTextBoxColumn})
        Me.HotelsGrid.DataSource = Me.FKОтелиСтраныBindingSource
        Me.HotelsGrid.GridColor = System.Drawing.SystemColors.Control
        Me.HotelsGrid.Location = New System.Drawing.Point(3, 56)
        Me.HotelsGrid.MultiSelect = False
        Me.HotelsGrid.Name = "HotelsGrid"
        Me.HotelsGrid.ReadOnly = True
        Me.HotelsGrid.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.HotelsGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HotelsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HotelsGrid.Size = New System.Drawing.Size(419, 631)
        Me.HotelsGrid.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "№"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'НазваниеDataGridViewTextBoxColumn
        '
        Me.НазваниеDataGridViewTextBoxColumn.DataPropertyName = "Название"
        Me.НазваниеDataGridViewTextBoxColumn.HeaderText = "Название"
        Me.НазваниеDataGridViewTextBoxColumn.Name = "НазваниеDataGridViewTextBoxColumn"
        Me.НазваниеDataGridViewTextBoxColumn.ReadOnly = True
        '
        'РейтингDataGridViewTextBoxColumn
        '
        Me.РейтингDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.РейтингDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг"
        Me.РейтингDataGridViewTextBoxColumn.HeaderText = "Рейтинг"
        Me.РейтингDataGridViewTextBoxColumn.Name = "РейтингDataGridViewTextBoxColumn"
        Me.РейтингDataGridViewTextBoxColumn.ReadOnly = True
        Me.РейтингDataGridViewTextBoxColumn.Width = 73
        '
        'FKОтелиСтраныBindingSource
        '
        Me.FKОтелиСтраныBindingSource.DataMember = "FK_Отели_Страны"
        Me.FKОтелиСтраныBindingSource.DataSource = Me.СтраныBindingSource
        '
        'СтраныBindingSource
        '
        Me.СтраныBindingSource.DataMember = "Страны"
        Me.СтраныBindingSource.DataSource = Me.ТурагнетсвоDataSet
        '
        'ТурагнетсвоDataSet
        '
        Me.ТурагнетсвоDataSet.DataSetName = "ТурагнетсвоDataSet"
        Me.ТурагнетсвоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Выберите страну"
        '
        'CountryComboBox
        '
        Me.CountryComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryComboBox.DataSource = Me.СтраныBindingSource
        Me.CountryComboBox.DisplayMember = "Название"
        Me.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryComboBox.Location = New System.Drawing.Point(3, 16)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(419, 21)
        Me.CountryComboBox.TabIndex = 0
        Me.CountryComboBox.ValueMember = "ID"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.HowToGet)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RoadsGrid)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Size = New System.Drawing.Size(811, 690)
        Me.SplitContainer2.SplitterDistance = 207
        Me.SplitContainer2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтелиBindingSource, "Рейтинг", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Label6.Location = New System.Drawing.Point(60, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        '
        'ОтелиBindingSource
        '
        Me.ОтелиBindingSource.DataMember = "Отели"
        Me.ОтелиBindingSource.DataSource = Me.ТурагнетсвоDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Рейтинг:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтелиBindingSource, "Описание", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.TextBox1.Location = New System.Drawing.Point(6, 39)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(802, 165)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтелиBindingSource, "Название", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(805, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Отель ""Плазасадомаза"""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HowToGet
        '
        Me.HowToGet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HowToGet.AutoSize = True
        Me.HowToGet.Location = New System.Drawing.Point(714, 463)
        Me.HowToGet.Name = "HowToGet"
        Me.HowToGet.Size = New System.Drawing.Size(94, 13)
        Me.HowToGet.TabIndex = 9
        Me.HowToGet.TabStop = True
        Me.HowToGet.Text = "Как приобрести?"
        '
        'RoadsGrid
        '
        Me.RoadsGrid.AllowUserToAddRows = False
        Me.RoadsGrid.AllowUserToDeleteRows = False
        Me.RoadsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoadsGrid.AutoGenerateColumns = False
        Me.RoadsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RoadsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RoadsGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RoadsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RoadsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.RoadsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RoadsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoadsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.ВремяОтбытияDataGridViewTextBoxColumn, Me.ВремяПрибытияDataGridViewTextBoxColumn, Me.ВремяВозвращенияDataGridViewTextBoxColumn, Me.НазваниеВидаТранспорта, Me.НазваниеПунктаОтбытия, Me.НазваниеСтраныПунктаОтбытия, Me.АдресПунктаОтбытия, Me.НазваниеПунктаПрибытия, Me.НазваниеСтраныПунктаПрибытия, Me.АдресПунктаПрибытия, Me.Стоимость})
        Me.RoadsGrid.DataSource = Me.FKМаршрутыОтелиBindingSource
        Me.RoadsGrid.GridColor = System.Drawing.SystemColors.Control
        Me.RoadsGrid.Location = New System.Drawing.Point(3, 16)
        Me.RoadsGrid.MultiSelect = False
        Me.RoadsGrid.Name = "RoadsGrid"
        Me.RoadsGrid.ReadOnly = True
        Me.RoadsGrid.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.RoadsGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.RoadsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RoadsGrid.Size = New System.Drawing.Size(805, 444)
        Me.RoadsGrid.TabIndex = 8
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "№"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Width = 43
        '
        'ВремяОтбытияDataGridViewTextBoxColumn
        '
        Me.ВремяОтбытияDataGridViewTextBoxColumn.DataPropertyName = "ВремяОтбытия"
        Me.ВремяОтбытияDataGridViewTextBoxColumn.HeaderText = "Время отбытия"
        Me.ВремяОтбытияDataGridViewTextBoxColumn.Name = "ВремяОтбытияDataGridViewTextBoxColumn"
        Me.ВремяОтбытияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ВремяПрибытияDataGridViewTextBoxColumn
        '
        Me.ВремяПрибытияDataGridViewTextBoxColumn.DataPropertyName = "ВремяПрибытия"
        Me.ВремяПрибытияDataGridViewTextBoxColumn.HeaderText = "Время прибытия"
        Me.ВремяПрибытияDataGridViewTextBoxColumn.Name = "ВремяПрибытияDataGridViewTextBoxColumn"
        Me.ВремяПрибытияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ВремяВозвращенияDataGridViewTextBoxColumn
        '
        Me.ВремяВозвращенияDataGridViewTextBoxColumn.DataPropertyName = "ВремяВозвращения"
        Me.ВремяВозвращенияDataGridViewTextBoxColumn.HeaderText = "Время возвращения"
        Me.ВремяВозвращенияDataGridViewTextBoxColumn.Name = "ВремяВозвращенияDataGridViewTextBoxColumn"
        Me.ВремяВозвращенияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НазваниеВидаТранспорта
        '
        Me.НазваниеВидаТранспорта.DataPropertyName = "НазваниеВидаТранспорта"
        Me.НазваниеВидаТранспорта.HeaderText = "Транспорт"
        Me.НазваниеВидаТранспорта.Name = "НазваниеВидаТранспорта"
        Me.НазваниеВидаТранспорта.ReadOnly = True
        '
        'НазваниеПунктаОтбытия
        '
        Me.НазваниеПунктаОтбытия.DataPropertyName = "НазваниеПунктаОтбытия"
        Me.НазваниеПунктаОтбытия.HeaderText = "Пункт отбытия"
        Me.НазваниеПунктаОтбытия.Name = "НазваниеПунктаОтбытия"
        Me.НазваниеПунктаОтбытия.ReadOnly = True
        '
        'НазваниеСтраныПунктаОтбытия
        '
        Me.НазваниеСтраныПунктаОтбытия.DataPropertyName = "НазваниеСтраныПунктаОтбытия"
        Me.НазваниеСтраныПунктаОтбытия.HeaderText = "Страна отбытия"
        Me.НазваниеСтраныПунктаОтбытия.Name = "НазваниеСтраныПунктаОтбытия"
        Me.НазваниеСтраныПунктаОтбытия.ReadOnly = True
        '
        'АдресПунктаОтбытия
        '
        Me.АдресПунктаОтбытия.DataPropertyName = "АдресПунктаОтбытия"
        Me.АдресПунктаОтбытия.HeaderText = "Адрес пункта отбытия"
        Me.АдресПунктаОтбытия.Name = "АдресПунктаОтбытия"
        Me.АдресПунктаОтбытия.ReadOnly = True
        '
        'НазваниеПунктаПрибытия
        '
        Me.НазваниеПунктаПрибытия.DataPropertyName = "НазваниеПунктаПрибытия"
        Me.НазваниеПунктаПрибытия.HeaderText = "Пункт прибытия"
        Me.НазваниеПунктаПрибытия.Name = "НазваниеПунктаПрибытия"
        Me.НазваниеПунктаПрибытия.ReadOnly = True
        '
        'НазваниеСтраныПунктаПрибытия
        '
        Me.НазваниеСтраныПунктаПрибытия.DataPropertyName = "НазваниеСтраныПунктаПрибытия"
        Me.НазваниеСтраныПунктаПрибытия.HeaderText = "Страна прибытия"
        Me.НазваниеСтраныПунктаПрибытия.Name = "НазваниеСтраныПунктаПрибытия"
        Me.НазваниеСтраныПунктаПрибытия.ReadOnly = True
        '
        'АдресПунктаПрибытия
        '
        Me.АдресПунктаПрибытия.DataPropertyName = "АдресПунктаПрибытия"
        Me.АдресПунктаПрибытия.HeaderText = "Адрес пункта прибытия"
        Me.АдресПунктаПрибытия.Name = "АдресПунктаПрибытия"
        Me.АдресПунктаПрибытия.ReadOnly = True
        '
        'Стоимость
        '
        Me.Стоимость.DataPropertyName = "Стоимость"
        Me.Стоимость.HeaderText = "Стоимость"
        Me.Стоимость.Name = "Стоимость"
        Me.Стоимость.ReadOnly = True
        '
        'FKМаршрутыОтелиBindingSource
        '
        Me.FKМаршрутыОтелиBindingSource.DataMember = "FK_Маршруты_Отели"
        Me.FKМаршрутыОтелиBindingSource.DataSource = Me.ОтелиBindingSource
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Список рейсов в этот отель"
        '
        'ErrorPanel
        '
        Me.ErrorPanel.Controls.Add(Me.Label8)
        Me.ErrorPanel.Controls.Add(Me.Label7)
        Me.ErrorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorPanel.Location = New System.Drawing.Point(0, 0)
        Me.ErrorPanel.Name = "ErrorPanel"
        Me.ErrorPanel.Size = New System.Drawing.Size(811, 690)
        Me.ErrorPanel.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(487, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "← Если у этой страны есть отели, вы увидите их здесь, а если нет, то увидите это " &
    "сообщение"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "← Для начала выберите страну"
        '
        'ОтелиTableAdapter
        '
        Me.ОтелиTableAdapter.ClearBeforeFill = True
        '
        'МаршрутыTableAdapter
        '
        Me.МаршрутыTableAdapter.ClearBeforeFill = True
        '
        'СтраныTableAdapter
        '
        Me.СтраныTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Туристическое агенство «Дельфин»"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.HotelsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKОтелиСтраныBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ОтелиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKМаршрутыОтелиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ErrorPanel.ResumeLayout(False)
        Me.ErrorPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents АдминистрированиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents HotelsGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoadsGrid As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents ТурагнетсвоDataSet As ТурагнетсвоDataSet
    Friend WithEvents ОтелиBindingSource As BindingSource
    Friend WithEvents ОтелиTableAdapter As ТурагнетсвоDataSetTableAdapters.ОтелиTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents РейтингDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FKМаршрутыОтелиBindingSource As BindingSource
    Friend WithEvents МаршрутыTableAdapter As ТурагнетсвоDataSetTableAdapters.МаршрутыTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ВремяОтбытияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяПрибытияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяВозвращенияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеВидаТранспорта As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеПунктаОтбытия As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеСтраныПунктаОтбытия As DataGridViewTextBoxColumn
    Friend WithEvents АдресПунктаОтбытия As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеПунктаПрибытия As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеСтраныПунктаПрибытия As DataGridViewTextBoxColumn
    Friend WithEvents АдресПунктаПрибытия As DataGridViewTextBoxColumn
    Friend WithEvents СтраныBindingSource As BindingSource
    Friend WithEvents СтраныTableAdapter As ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter
    Friend WithEvents FKОтелиСтраныBindingSource As BindingSource
    Friend WithEvents ErrorPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Стоимость As DataGridViewTextBoxColumn
    Friend WithEvents HowToGet As LinkLabel
End Class
