Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ТурагнетсвоDataSet.Страны' table. You can move, or remove it, as needed.
        Me.СтраныTableAdapter.Fill(Me.ТурагнетсвоDataSet.Страны)
        'TODO: This line of code loads data into the 'ТурагнетсвоDataSet.Маршруты' table. You can move, or remove it, as needed.
        Me.МаршрутыTableAdapter.Fill(Me.ТурагнетсвоDataSet.Маршруты)
        'TODO: This line of code loads data into the 'ТурагнетсвоDataSet.Отели' table. You can move, or remove it, as needed.
        Me.ОтелиTableAdapter.Fill(Me.ТурагнетсвоDataSet.Отели)

    End Sub

    Private Sub HotelsGrid_SelectionChanged(sender As Object, e As EventArgs) Handles HotelsGrid.SelectionChanged

        If (HotelsGrid.RowCount = 0) Then
            ErrorPanel.BringToFront()
        Else
            ErrorPanel.SendToBack()
        End If
    End Sub

    Private Sub HowToGet_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HowToGet.LinkClicked
        MessageBox.Show("Для того, чтобы связаться с нами и обсудить подробности поездки позвоните нам: " + vbNewLine + My.Settings.Properties.Item("Phones").DefaultValue)
    End Sub

    Private Sub АдминистрированиеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles АдминистрированиеToolStripMenuItem.Click
        Dim oForm As Form = New AdminLoginForm(Me)
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub RoadsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RoadsGrid.CellContentClick

    End Sub
End Class
