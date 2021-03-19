Public Class AdminHotelsForm


    Private pForm As Form

    Public Sub New(pForm As Form)
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        Me.pForm = pForm
    End Sub

    Private Sub AdminHotelsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.Show()
    End Sub

    Private Sub AdminHotelsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ТурагнетсвоDataSet.Отели' table. You can move, or remove it, as needed.
        Me.ОтелиTableAdapter.Fill(Me.ТурагнетсвоDataSet.Отели)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТурагнетсвоDataSet.Страны". При необходимости она может быть перемещена или удалена.
        Me.СтраныTableAdapter.Fill(Me.ТурагнетсвоDataSet.Страны)

    End Sub

    Private Sub save()
        Try
            ОтелиBindingSource.EndEdit()
            TableAdapterManager1.UpdateAll(ТурагнетсвоDataSet)
            ТурагнетсвоDataSet.AcceptChanges()
            ОтелиTableAdapter.Fill(ТурагнетсвоDataSet.Отели)
        Catch
            MessageBox.Show("Ой, ошибка. Этот отель где-то используется.")
        End Try
    End Sub

    Private Sub EditSubmit_Click(sender As Object, e As EventArgs) Handles EditSubmit.Click
        Me.Validate()
        save()
    End Sub


    Private Sub DeleteSubmit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteSubmit.LinkClicked
        If MessageBox.Show("Вы действительно хотите удалить выбранный элемент?" & vbLf & "Это действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each item As DataGridViewRow In HotelsGrid.SelectedRows
                ОтелиBindingSource.RemoveAt(item.Index)
            Next
            save()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fk1 As ТурагнетсвоDataSet.СтраныRow = ТурагнетсвоDataSet.Страны.NewСтраныRow()
        fk1.ID = Convert.ToInt32(AddCountry.SelectedValue.ToString())
        ТурагнетсвоDataSet.Отели.AddОтелиRow(AddName.Text, AddAbout.Text, AddRating.Value, fk1, AddAddres.Text)
        save()
    End Sub
End Class