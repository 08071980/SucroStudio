Public Class SOS
    Private inConta As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If inConta > 2 Then
            inConta = 0
        End If
        If Label1.Visible = True Then
            Label1.Visible = False
        Else
            Label1.Visible = True
            If inConta = 0 Then
                Label1.ForeColor = Color.Black
            ElseIf inConta = 1 Then
                Label1.ForeColor = Color.Yellow
            ElseIf inConta = 2 Then
                Label1.ForeColor = Color.Blue
            End If
        End If
        inConta += 1
    End Sub
End Class