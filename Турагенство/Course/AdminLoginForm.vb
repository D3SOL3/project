Public Class AdminLoginForm

    Public Sub New(pForm As Form)

        ' This call is required by the designer.
        InitializeComponent()

        Me.pForm = pForm

    End Sub

    Private pForm As Form

    Private Sub AdminLoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (My.Settings.Properties("AdminPassword").DefaultValue <> TextBox1.Text) Then
            Me.Close()
            Return
        End If
        Dim oForm As Form = New AdminForm(Me)
        Me.Hide()
        oForm.Show()
    End Sub
End Class