Public Class Aceiros
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form = New Limpar
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New Limpar
        form.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form = New Pare
        form.ShowDialog()
    End Sub
End Class