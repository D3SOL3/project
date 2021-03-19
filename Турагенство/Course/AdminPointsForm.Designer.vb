<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPointsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.СтраныBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ТурагнетсвоDataSet = New Course.ТурагнетсвоDataSet()
        Me.DeleteSubmit = New System.Windows.Forms.LinkLabel()
        Me.AddAbout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddAddres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddCountry = New System.Windows.Forms.ComboBox()
        Me.СтраныBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager()
        Me.СтраныTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddSubmit = New System.Windows.Forms.Button()
        Me.AddName = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1121 = New System.Windows.Forms.TabControl()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.ТранспортныеПунктыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ТранспортныеПунктыTableAdapter = New Course.ТурагнетсвоDataSetTableAdapters.ТранспортныеПунктыTableAdapter()
        Me.SendPoint = New System.Windows.Forms.CheckBox()
        Me.EditSendingPoint = New System.Windows.Forms.CheckBox()
        Me.EditAbout = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditAddres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EditCountry = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SaveSubmit = New System.Windows.Forms.Button()
        Me.EditName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СтранаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АдресDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОписаниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПунктОтбытияDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage4.SuspendLayout()
        CType(Me.СтраныBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1121.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТранспортныеПунктыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.EditSendingPoint)
        Me.TabPage4.Controls.Add(Me.EditAbout)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.EditAddres)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.EditCountry)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.SaveSubmit)
        Me.TabPage4.Controls.Add(Me.EditName)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.DeleteSubmit)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(409, 394)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Изменение"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'СтраныBindingSource1
        '
        Me.СтраныBindingSource1.DataMember = "Страны"
        Me.СтраныBindingSource1.DataSource = Me.ТурагнетсвоDataSet
        '
        'ТурагнетсвоDataSet
        '
        Me.ТурагнетсвоDataSet.DataSetName = "ТурагнетсвоDataSet"
        Me.ТурагнетсвоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeleteSubmit
        '
        Me.DeleteSubmit.AutoSize = True
        Me.DeleteSubmit.Location = New System.Drawing.Point(353, 370)
        Me.DeleteSubmit.Name = "DeleteSubmit"
        Me.DeleteSubmit.Size = New System.Drawing.Size(50, 13)
        Me.DeleteSubmit.TabIndex = 11
        Me.DeleteSubmit.TabStop = True
        Me.DeleteSubmit.Text = "Удалить"
        '
        'AddAbout
        '
        Me.AddAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddAbout.Location = New System.Drawing.Point(6, 137)
        Me.AddAbout.Multiline = True
        Me.AddAbout.Name = "AddAbout"
        Me.AddAbout.Size = New System.Drawing.Size(397, 199)
        Me.AddAbout.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Об отеле"
        '
        'AddAddres
        '
        Me.AddAddres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddAddres.Location = New System.Drawing.Point(6, 98)
        Me.AddAddres.Name = "AddAddres"
        Me.AddAddres.Size = New System.Drawing.Size(397, 20)
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
        Me.AddCountry.Size = New System.Drawing.Size(397, 21)
        Me.AddCountry.TabIndex = 9
        Me.AddCountry.ValueMember = "ID"
        '
        'СтраныBindingSource
        '
        Me.СтраныBindingSource.DataMember = "Страны"
        Me.СтраныBindingSource.DataSource = Me.ТурагнетсвоDataSet
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ВидыТранспортаTableAdapter = Nothing
        Me.TableAdapterManager1.ОтелиTableAdapter = Nothing
        Me.TableAdapterManager1.СтраныTableAdapter = Me.СтраныTableAdapter
        Me.TableAdapterManager1.ТранспортныеПунктыTableAdapter = Nothing
        '
        'СтраныTableAdapter
        '
        Me.СтраныTableAdapter.ClearBeforeFill = True
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
        'AddSubmit
        '
        Me.AddSubmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSubmit.Location = New System.Drawing.Point(6, 365)
        Me.AddSubmit.Name = "AddSubmit"
        Me.AddSubmit.Size = New System.Drawing.Size(397, 23)
        Me.AddSubmit.TabIndex = 7
        Me.AddSubmit.Text = "Добавить"
        Me.AddSubmit.UseVisualStyleBackColor = True
        '
        'AddName
        '
        Me.AddName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddName.Location = New System.Drawing.Point(6, 19)
        Me.AddName.Name = "AddName"
        Me.AddName.Size = New System.Drawing.Size(397, 20)
        Me.AddName.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SendPoint)
        Me.TabPage3.Controls.Add(Me.AddAbout)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.AddAddres)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.AddCountry)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.AddSubmit)
        Me.TabPage3.Controls.Add(Me.AddName)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 394)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Добавление"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Название пункта"
        '
        'GroupBox1121
        '
        Me.GroupBox1121.Controls.Add(Me.TabPage3)
        Me.GroupBox1121.Controls.Add(Me.TabPage4)
        Me.GroupBox1121.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1121.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1121.Name = "GroupBox1121"
        Me.GroupBox1121.SelectedIndex = 0
        Me.GroupBox1121.Size = New System.Drawing.Size(417, 420)
        Me.GroupBox1121.TabIndex = 0
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AutoGenerateColumns = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.СтранаDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.НазваниеDataGridViewTextBoxColumn, Me.ОписаниеDataGridViewTextBoxColumn, Me.ПунктОтбытияDataGridViewCheckBoxColumn})
        Me.Grid.DataSource = Me.ТранспортныеПунктыBindingSource
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.GridColor = System.Drawing.SystemColors.Control
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(415, 420)
        Me.Grid.TabIndex = 8
        '
        'ТранспортныеПунктыBindingSource
        '
        Me.ТранспортныеПунктыBindingSource.DataMember = "ТранспортныеПункты"
        Me.ТранспортныеПунктыBindingSource.DataSource = Me.ТурагнетсвоDataSet
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Grid)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox1121)
        Me.SplitContainer4.Size = New System.Drawing.Size(836, 420)
        Me.SplitContainer4.SplitterDistance = 415
        Me.SplitContainer4.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SplitContainer4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(842, 439)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Управление транспортными пунктами"
        '
        'ТранспортныеПунктыTableAdapter
        '
        Me.ТранспортныеПунктыTableAdapter.ClearBeforeFill = True
        '
        'SendPoint
        '
        Me.SendPoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SendPoint.AutoSize = True
        Me.SendPoint.Location = New System.Drawing.Point(6, 342)
        Me.SendPoint.Name = "SendPoint"
        Me.SendPoint.Size = New System.Drawing.Size(120, 17)
        Me.SendPoint.TabIndex = 16
        Me.SendPoint.Text = "Это пункт отбытия"
        Me.SendPoint.UseVisualStyleBackColor = True
        '
        'EditSendingPoint
        '
        Me.EditSendingPoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditSendingPoint.AutoSize = True
        Me.EditSendingPoint.Location = New System.Drawing.Point(6, 342)
        Me.EditSendingPoint.Name = "EditSendingPoint"
        Me.EditSendingPoint.Size = New System.Drawing.Size(120, 17)
        Me.EditSendingPoint.TabIndex = 26
        Me.EditSendingPoint.Text = "Это пункт отбытия"
        Me.EditSendingPoint.UseVisualStyleBackColor = True
        '
        'EditAbout
        '
        Me.EditAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditAbout.Location = New System.Drawing.Point(6, 137)
        Me.EditAbout.Multiline = True
        Me.EditAbout.Name = "EditAbout"
        Me.EditAbout.Size = New System.Drawing.Size(397, 199)
        Me.EditAbout.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Об отеле"
        '
        'EditAddres
        '
        Me.EditAddres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditAddres.Location = New System.Drawing.Point(6, 98)
        Me.EditAddres.Name = "EditAddres"
        Me.EditAddres.Size = New System.Drawing.Size(397, 20)
        Me.EditAddres.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Адрес"
        '
        'EditCountry
        '
        Me.EditCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditCountry.DataSource = Me.СтраныBindingSource
        Me.EditCountry.DisplayMember = "Название"
        Me.EditCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EditCountry.FormattingEnabled = True
        Me.EditCountry.Location = New System.Drawing.Point(6, 58)
        Me.EditCountry.Name = "EditCountry"
        Me.EditCountry.Size = New System.Drawing.Size(397, 21)
        Me.EditCountry.TabIndex = 21
        Me.EditCountry.ValueMember = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Страна"
        '
        'SaveSubmit
        '
        Me.SaveSubmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveSubmit.Location = New System.Drawing.Point(6, 365)
        Me.SaveSubmit.Name = "SaveSubmit"
        Me.SaveSubmit.Size = New System.Drawing.Size(341, 23)
        Me.SaveSubmit.TabIndex = 19
        Me.SaveSubmit.Text = "Сохранить"
        Me.SaveSubmit.UseVisualStyleBackColor = True
        '
        'EditName
        '
        Me.EditName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditName.Location = New System.Drawing.Point(6, 19)
        Me.EditName.Name = "EditName"
        Me.EditName.Size = New System.Drawing.Size(397, 20)
        Me.EditName.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Название пункта"
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
        'СтранаDataGridViewTextBoxColumn
        '
        Me.СтранаDataGridViewTextBoxColumn.DataPropertyName = "Страна"
        Me.СтранаDataGridViewTextBoxColumn.HeaderText = "Страна"
        Me.СтранаDataGridViewTextBoxColumn.Name = "СтранаDataGridViewTextBoxColumn"
        Me.СтранаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        Me.АдресDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НазваниеDataGridViewTextBoxColumn
        '
        Me.НазваниеDataGridViewTextBoxColumn.DataPropertyName = "Название"
        Me.НазваниеDataGridViewTextBoxColumn.HeaderText = "Название"
        Me.НазваниеDataGridViewTextBoxColumn.Name = "НазваниеDataGridViewTextBoxColumn"
        Me.НазваниеDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ОписаниеDataGridViewTextBoxColumn
        '
        Me.ОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.HeaderText = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.Name = "ОписаниеDataGridViewTextBoxColumn"
        Me.ОписаниеDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ПунктОтбытияDataGridViewCheckBoxColumn
        '
        Me.ПунктОтбытияDataGridViewCheckBoxColumn.DataPropertyName = "ПунктОтбытия"
        Me.ПунктОтбытияDataGridViewCheckBoxColumn.HeaderText = "Это пункт отбытия"
        Me.ПунктОтбытияDataGridViewCheckBoxColumn.Name = "ПунктОтбытияDataGridViewCheckBoxColumn"
        Me.ПунктОтбытияDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'AdminPointsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 439)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "AdminPointsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Управление транспортными пунтками"
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.СтраныBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТурагнетсвоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтраныBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1121.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТранспортныеПунктыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ТурагнетсвоDataSet As Course.ТурагнетсвоDataSet
    Friend WithEvents СтраныBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DeleteSubmit As System.Windows.Forms.LinkLabel
    Friend WithEvents AddAbout As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddAddres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddCountry As System.Windows.Forms.ComboBox
    Friend WithEvents СтраныBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager1 As Course.ТурагнетсвоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СтраныTableAdapter As Course.ТурагнетсвоDataSetTableAdapters.СтраныTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddSubmit As System.Windows.Forms.Button
    Friend WithEvents AddName As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1121 As System.Windows.Forms.TabControl
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ТранспортныеПунктыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ТранспортныеПунктыTableAdapter As Course.ТурагнетсвоDataSetTableAdapters.ТранспортныеПунктыTableAdapter
    Friend WithEvents SendPoint As System.Windows.Forms.CheckBox
    Friend WithEvents EditSendingPoint As System.Windows.Forms.CheckBox
    Friend WithEvents EditAbout As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EditAddres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EditCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SaveSubmit As System.Windows.Forms.Button
    Friend WithEvents EditName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СтранаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АдресDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОписаниеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПунктОтбытияDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
