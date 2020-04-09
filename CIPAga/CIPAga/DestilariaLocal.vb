Public Class DestilariaLocal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New PTR5341Destilaria
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form = New PTR3388Destilaria
        form.ShowDialog()
    End Sub
End Class