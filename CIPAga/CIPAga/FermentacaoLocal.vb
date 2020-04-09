Public Class FermentacaoLocal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New PTR5340Fermentacao
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form = New PTR_5342Fermentacao
        form.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form = New PTR9001Fermentacao
        form.ShowDialog()
    End Sub
End Class