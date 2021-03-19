Public Class AdminPointsForm

    Public Sub New(pForm As Form)

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        Me.pForm = pForm

    End Sub

    Private pForm As Form

    Private Sub AdminRoutesForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.Show()
    End Sub

    Private Sub AdminRoutesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТурагнетсвоDataSet.ТранспортныеПункты". При необходимости она может быть перемещена или удалена.
        Me.ТранспортныеПунктыTableAdapter.Fill(Me.ТурагнетсвоDataSet.ТранспортныеПункты)

    End Sub

    Private Sub save()
        Try
            ТранспортныеПунктыBindingSource.EndEdit()
            TableAdapterManager1.UpdateAll(ТурагнетсвоDataSet)
            ТурагнетсвоDataSet.AcceptChanges()
            ТранспортныеПунктыTableAdapter.Fill(ТурагнетсвоDataSet.ТранспортныеПункты)
        Catch
            MessageBox.Show("Ой, ошибка. Этот транспрортный пункт используется в каком-то маршруте.")
        End Try
    End Sub

    Private Sub AddSubmit_Click(sender As Object, e As EventArgs) Handles AddSubmit.Click
        Dim fk1 As ТурагнетсвоDataSet.СтраныRow = ТурагнетсвоDataSet.Страны.NewСтраныRow()
        fk1.ID = Convert.ToInt32(AddCountry.SelectedValue.ToString())
        ТурагнетсвоDataSet.ТранспортныеПункты.AddТранспортныеПунктыRow(fk1, AddAddres.Text, AddName.Text, AddAbout.Text, SendPoint.Checked)
        save()
    End Sub

    Private Sub SaveSubmit_Click(sender As Object, e As EventArgs) Handles SaveSubmit.Click

        Me.Validate()
        save()
    End Sub

    Private Sub DeleteSubmit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteSubmit.LinkClicked
        If MessageBox.Show("Вы действительно хотите удалить выбранный элемент?" & vbLf & "Это действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each item As DataGridViewRow In Grid.SelectedRows
                ТранспортныеПунктыBindingSource.RemoveAt(item.Index)
            Next
            save()
        End If
    End Sub
End Class