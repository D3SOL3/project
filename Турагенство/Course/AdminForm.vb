Public Class AdminForm

    Public Sub New(pForm As Form)

        ' This call is required by the designer.
        InitializeComponent()

        Me.pForm = pForm

    End Sub

    Private pForm As Form

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ТурагнетсвоDataSet.ВидыТранспорта' table. You can move, or remove it, as needed.
        Me.ВидыТранспортаTableAdapter.Fill(Me.ТурагнетсвоDataSet.ВидыТранспорта)
        'TODO: This line of code loads data into the 'ТурагнетсвоDataSet.Страны' table. You can move, or remove it, as needed.
        Me.СтраныTableAdapter.Fill(Me.ТурагнетсвоDataSet.Страны)
        Phones.Text = My.Settings.Properties("Phones").DefaultValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdminForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.Close()
    End Sub

    Private Sub Phones_TextChanged(sender As Object, e As EventArgs) Handles Phones.TextChanged
        My.Settings.Properties("Phones").DefaultValue = Phones.Text
    End Sub

    Private Sub PassSave_Click(sender As Object, e As EventArgs) Handles PassSave.Click
        If (My.Settings.Properties("AdminPassword").DefaultValue <> PassOld.Text) Then
            MessageBox.Show("Старый пароль введён неверно.")
            Return
        End If
        If (PassNew.Text <> PassNewConfirm.Text) Then
            MessageBox.Show("2 новых пароля не совпадают, а должны.")
            Return
        End If
        MessageBox.Show("Новый пароль успшено установлен!")
        My.Settings.Properties("AdminPassword").DefaultValue = Phones.Text
    End Sub

    Private Sub saveContries()
        Try
            СтраныBindingSource.EndEdit()
            TableAdapterManager1.UpdateAll(ТурагнетсвоDataSet)
            ТурагнетсвоDataSet.AcceptChanges()
            СтраныTableAdapter.Fill(ТурагнетсвоDataSet.Страны)
        Catch
            MessageBox.Show("Ой, эта страна уже где-то используется и её удалить нельзя.")
        End Try
    End Sub

    Private Sub CountryEditApply_Click(sender As Object, e As EventArgs) Handles CountryEditApply.Click
        Me.Validate()
        saveContries()
    End Sub

    Private Sub AddCountry_Click(sender As Object, e As EventArgs) Handles AddCountry.Click
        ТурагнетсвоDataSet.Страны.AddСтраныRow(CountryAddName.Text)
        saveContries()
    End Sub

    Private Sub CountryEditDelete_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CountryEditDelete.LinkClicked
        If MessageBox.Show("Вы действительно хотите удалить выбранный элемент?" & vbLf & "Это действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each item As DataGridViewRow In CountriesGrid.SelectedRows
                СтраныBindingSource.RemoveAt(item.Index)
            Next
            saveContries()
        End If

    End Sub

    Private Sub saveTransport()
        Try
            ВидыТранспортаBindingSource.EndEdit()
            TableAdapterManager1.UpdateAll(ТурагнетсвоDataSet)
            ТурагнетсвоDataSet.AcceptChanges()
            ВидыТранспортаTableAdapter.Fill(ТурагнетсвоDataSet.ВидыТранспорта)
        Catch
            MessageBox.Show("Ой, ошибка. Этот транспорт где-то используется и в текущий момент эту запись удалить нельзя.")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ТурагнетсвоDataSet.ВидыТранспорта.AddВидыТранспортаRow(TransportAddName.Text)
        saveTransport()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MessageBox.Show("Вы действительно хотите удалить выбранный элемент?" & vbLf & "Это действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each item As DataGridViewRow In TransportGrid.SelectedRows
                ВидыТранспортаBindingSource.RemoveAt(item.Index)
            Next
            saveTransport()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        saveTransport()
    End Sub

    Private Sub УправлениеОтелямиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УправлениеОтелямиToolStripMenuItem.Click
        Dim oForm As Form = New AdminHotelsForm(Me)
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub УправлениеТранспортнымиПунктамиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УправлениеТранспортнымиПунктамиToolStripMenuItem.Click
        Dim oForm As Form = New AdminPointsForm(Me)
        Me.Hide()
        oForm.Show()
    End Sub
End Class