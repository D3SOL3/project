<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHotelsForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ТурагнетсвоDataSet = New Course.ТурагнетсвоDataSet()
        Me.ОтелиTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.ОтелиTableAdapter()
        Me.ОтелиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.HotelsGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddSubmit = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AddAbout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddRating = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddAddres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddCountry = New System.Windows.Forms.ComboBox()
        Me.СтраныBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AddName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditAbout = New System.Windows.Forms.TextBox()
        Me.EditRating = New System.Windows.Forms.NumericUpDown()
        Me.EditAddres = New System.Windows.Forms.TextBox()
        Me.EditCountry = New System.Windows.Forms.ComboBox()
        Me.СтраныBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EditSubmit = New System.Windows.Forms.Button()
        Me.EditName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeleteSubmit = New System.Windows.Forms.LinkLabel()
        Me.СтраныTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter()
        Me.TableAdapterManager1 = New Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОтелиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.HotelsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddSubmit.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.AddRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.EditRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтраныBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ТурагнетсвоDataSet
        '
        Me.ТурагнетсвоDataSet.DataSetName = "ТурагнетсвоDataSet"
        Me.ТурагнетсвоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ОтелиTableAdapter
        '
        Me.ОтелиTableAdapter.ClearBeforeFill = True
        '
        'ОтелиBindingSource
        '
        Me.ОтелиBindingSource.DataMember = "Отели"
        Me.ОтелиBindingSource.DataSource = Me.ТурагнетсвоDataSet
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SplitContainer4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(829, 548)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Управление отелями"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.HotelsGrid)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.AddSubmit)
        Me.SplitContainer4.Size = New System.Drawing.Size(823, 529)
        Me.SplitContainer4.SplitterDistance = 409
        Me.SplitContainer4.TabIndex = 2
        '
        'HotelsGrid
        '
        Me.HotelsGrid.AllowUserToAddRows = False
        Me.HotelsGrid.AllowUserToDeleteRows = False
        Me.HotelsGrid.AutoGenerateColumns = False
        Me.HotelsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HotelsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HotelsGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.HotelsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HotelsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.HotelsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.HotelsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HotelsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.HotelsGrid.DataSource = Me.ОтелиBindingSource
        Me.HotelsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HotelsGrid.GridColor = System.Drawing.SystemColors.Control
        Me.HotelsGrid.Location = New System.Drawing.Point(0, 0)
        Me.HotelsGrid.MultiSelect = False
        Me.HotelsGrid.Name = "HotelsGrid"
        Me.HotelsGrid.ReadOnly = True
        Me.HotelsGrid.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.HotelsGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.HotelsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HotelsGrid.Size = New System.Drawing.Size(409, 529)
        Me.HotelsGrid.TabIndex = 8
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "№"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 43
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Название"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'AddSubmit
        '
        Me.AddSubmit.Controls.Add(Me.TabPage3)
        Me.AddSubmit.Controls.Add(Me.TabPage4)
        Me.AddSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddSubmit.Location = New System.Drawing.Point(0, 0)
        Me.AddSubmit.Name = "AddSubmit"
        Me.AddSubmit.SelectedIndex = 0
        Me.AddSubmit.Size = New System.Drawing.Size(410, 529)
        Me.AddSubmit.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AddAbout)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.AddRating)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.AddAddres)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.AddCountry)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.AddName)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(402, 503)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Добавление"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AddAbout
        '
        Me.AddAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddAbout.Location = New System.Drawing.Point(6, 176)
        Me.AddAbout.Multiline = True
        Me.AddAbout.Name = "AddAbout"
        Me.AddAbout.Size = New System.Drawing.Size(390, 292)
        Me.AddAbout.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Об отеле"
        '
        'AddRating
        '
        Me.AddRating.Location = New System.Drawing.Point(6, 137)
        Me.AddRating.Name = "AddRating"
        Me.AddRating.Size = New System.Drawing.Size(390, 20)
        Me.AddRating.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Рейтинг"
        '
        'AddAddres
        '
        Me.AddAddres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddAddres.Location = New System.Drawing.Point(6, 98)
        Me.AddAddres.Name = "AddAddres"
        Me.AddAddres.Size = New System.Drawing.Size(390, 20)
        Me.AddAddres.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Адрес"
        '
        'AddCountry
        '
        Me.AddCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddCountry.DataSource = Me.СтраныBindingSource
        Me.AddCountry.DisplayMember = "Название"
        Me.AddCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AddCountry.FormattingEnabled = True
        Me.AddCountry.Location = New System.Drawing.Point(6, 58)
        Me.AddCountry.Name = "AddCountry"
        Me.AddCountry.Size = New System.Drawing.Size(390, 21)
        Me.AddCountry.TabIndex = 9
        Me.AddCountry.ValueMember = "ID"
        '
        'СтраныBindingSource
        '
        Me.СтраныBindingSource.DataMember = "Страны"
        Me.СтраныBindingSource.DataSource = Me.ТурагнетсвоDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Страна"
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(6, 474)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(390, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AddName
        '
        Me.AddName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddName.Location = New System.Drawing.Point(6, 19)
        Me.AddName.Name = "AddName"
        Me.AddName.Size = New System.Drawing.Size(390, 20)
        Me.AddName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Название отеля"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.EditAbout)
        Me.TabPage4.Controls.Add(Me.EditRating)
        Me.TabPage4.Controls.Add(Me.EditAddres)
        Me.TabPage4.Controls.Add(Me.EditCountry)
        Me.TabPage4.Controls.Add(Me.EditSubmit)
        Me.TabPage4.Controls.Add(Me.EditName)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.DeleteSubmit)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(402, 503)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Изменение"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Об отеле"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Рейтинг"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Адрес"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Страна"
        '
        'EditAbout
        '
        Me.EditAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditAbout.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтелиBindingSource, "Адрес", True))
        Me.EditAbout.Location = New System.Drawing.Point(6, 176)
        Me.EditAbout.Multiline = True
        Me.EditAbout.Name = "EditAbout"
        Me.EditAbout.Size = New System.Drawing.Size(390, 292)
        Me.EditAbout.TabIndex = 22
        '
        'EditRating
        '
        Me.EditRating.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОтелиBindingSource, "Рейтинг", True))
        Me.EditRating.Location = New System.Drawing.Point(6, 137)
        Me.EditRating.Name = "EditRating"
        Me.EditRating.Size = New System.Drawing.Size(390, 20)
        Me.EditRating.TabIndex = 21
        '
        'EditAddres
        '
        Me.EditAddres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditAddres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтелиBindingSource, "Адрес", True))
        Me.EditAddres.Location = New System.Drawing.Point(6, 98)
        Me.EditAddres.Name = "EditAddres"
        Me.EditAddres.Size = New System.Drawing.Size(390, 20)
        Me.EditAddres.TabIndex = 20
        '
        'EditCountry
        '
        Me.EditCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditCountry.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ОтелиBindingSource, "Страна", True))
        Me.EditCountry.DataSource = Me.СтраныBindingSource1
        Me.EditCountry.DisplayMember = "Название"
        Me.EditCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EditCountry.FormattingEnabled = True
        Me.EditCountry.Location = New System.Drawing.Point(6, 58)
        Me.EditCountry.Name = "EditCountry"
        Me.EditCountry.Size = New System.Drawing.Size(390, 21)
        Me.EditCountry.TabIndex = 19
        Me.EditCountry.ValueMember = "ID"
        '
        'СтраныBindingSource1
        '
        Me.СтраныBindingSource1.DataMember = "Страны"
        Me.СтраныBindingSource1.DataSource = Me.ТурагнетсвоDataSet
        '
        'EditSubmit
        '
        Me.EditSubmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditSubmit.Location = New System.Drawing.Point(6, 474)
        Me.EditSubmit.Name = "EditSubmit"
        Me.EditSubmit.Size = New System.Drawing.Size(335, 23)
        Me.EditSubmit.TabIndex = 18
        Me.EditSubmit.Text = "Изменить"
        Me.EditSubmit.UseVisualStyleBackColor = True
        '
        'EditName
        '
        Me.EditName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОтелиBindingSource, "Страна", True))
        Me.EditName.Location = New System.Drawing.Point(6, 19)
        Me.EditName.Name = "EditName"
        Me.EditName.Size = New System.Drawing.Size(390, 20)
        Me.EditName.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Название отеля"
        '
        'DeleteSubmit
        '
        Me.DeleteSubmit.AutoSize = True
        Me.DeleteSubmit.Location = New System.Drawing.Point(347, 479)
        Me.DeleteSubmit.Name = "DeleteSubmit"
        Me.DeleteSubmit.Size = New System.Drawing.Size(50, 13)
        Me.DeleteSubmit.TabIndex = 11
        Me.DeleteSubmit.TabStop = True
        Me.DeleteSubmit.Text = "Удалить"
        '
        'СтраныTableAdapter
        '
        Me.СтраныTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ВидыТранспортаTableAdapter = Nothing
        Me.TableAdapterManager1.ОтелиTableAdapter = Me.ОтелиTableAdapter
        Me.TableAdapterManager1.СтраныTableAdapter = Me.СтраныTableAdapter
        Me.TableAdapterManager1.ТранспортныеПунктыTableAdapter = Nothing
        '
        'AdminHotelsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 548)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "AdminHotelsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Управление отелями"
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОтелиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.HotelsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddSubmit.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.AddRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.EditRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтраныBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ТурагнетсвоDataSet As Course.ТурагнетсвоDataSet
    Friend WithEvents ОтелиTableAdapter As Course.ТурагнетсвоDataSetTableAdapters.ОтелиTableAdapter
    Friend WithEvents ОтелиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents HotelsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddSubmit As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AddName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DeleteSubmit As System.Windows.Forms.LinkLabel
    Friend WithEvents AddCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents СтраныBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтраныTableAdapter As Course.ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter
    Friend WithEvents AddAbout As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddRating As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddAddres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EditAbout As System.Windows.Forms.TextBox
    Friend WithEvents EditRating As System.Windows.Forms.NumericUpDown
    Friend WithEvents EditAddres As System.Windows.Forms.TextBox
    Friend WithEvents EditCountry As System.Windows.Forms.ComboBox
    Friend WithEvents СтраныBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EditSubmit As System.Windows.Forms.Button
    Friend WithEvents EditName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager1 As Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager
End Class
