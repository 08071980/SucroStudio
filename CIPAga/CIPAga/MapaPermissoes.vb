Public Class MapaPermissoes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New DireitoDeRecusa
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form = New PreparoDeCanaLocal
        form.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form = New SOS
        form.ShowDialog()
    End Sub
    Private inConta As Integer = 0
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If inConta > 2 Then
            inConta = 0
        End If
        If Button3.Visible = True Then
            Button3.Visible = False
        Else
            Button3.Visible = True
            If inConta = 0 Then
                Button3.ForeColor = Color.Black
            ElseIf inConta = 1 Then
                Button3.ForeColor = Color.Yellow
            ElseIf inConta = 2 Then
                Button3.ForeColor = Color.Blue
            End If
        End If
        inConta += 1
    End Sub
End Class