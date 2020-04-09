Public Class Pare
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New FatorDeRisco
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form = New PareDireitoDeRecusa
        form.ShowDialog()
    End Sub
End Class