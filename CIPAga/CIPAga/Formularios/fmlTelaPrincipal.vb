Public Class fmlTelaPrincipal
    Private Sub LocalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalToolStripMenuItem.Click

    End Sub

    Private Sub DataEHoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataEHoraToolStripMenuItem.Click
        Dim form = New Graficos
        form.ShowDialog()
    End Sub

    Private Sub ExtraçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExtraçãoToolStripMenuItem1.Click
        Dim form = New Extracao
        form.ShowDialog()
    End Sub

    Private Sub UtilidadesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UtilidadesToolStripMenuItem1.Click
        Dim form = New Caldeira
        form.ShowDialog()
    End Sub

    Private Sub TratamentoDeCaldoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TratamentoDeCaldoToolStripMenuItem1.Click
        Dim form = New TratamentoDeCaldo
        form.ShowDialog()
    End Sub

    Private Sub FermentaçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FermentaçãoToolStripMenuItem1.Click
        Dim form = New FabricaDeEtanol
        form.ShowDialog()
    End Sub

    Private Sub DestilariaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DestilariaToolStripMenuItem1.Click
        Dim form = New FabricaDeEtanol
        form.ShowDialog()
    End Sub

    Private Sub CarregamentoDeEtanolToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CarregamentoDeEtanolToolStripMenuItem1.Click
        Dim form = New FabricaDeEtanol
        form.ShowDialog()
    End Sub

    Private Sub CaldeirariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaldeirariaToolStripMenuItem.Click
        Dim form = New Caldeiraria
        form.ShowDialog()
    End Sub

    Private Sub PreparoDeCanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreparoDeCanaToolStripMenuItem.Click
        Dim form = New PreparoDeCanaLocal
        form.ShowDialog()
    End Sub

    Private Sub fmlTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TelasDeProcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TelasDeProcessoToolStripMenuItem.Click

    End Sub

    Private Sub PreparoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreparoToolStripMenuItem.Click
        Dim form = New PreparoTela
        form.ShowDialog()
    End Sub

    Private Sub ExtraçãoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExtraçãoToolStripMenuItem2.Click
        Dim form = New ExtracaoTela
        form.ShowDialog()
    End Sub

    Private Sub Terno1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Terno1ToolStripMenuItem.Click
        Dim form = New Terno1Tela
        form.ShowDialog()
    End Sub

    Private Sub MecânicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MecânicaToolStripMenuItem.Click
        Dim form = New Mecanica
        form.ShowDialog()
    End Sub

    Private Sub ElétricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElétricaToolStripMenuItem.Click
        Dim form = New Eletrica
        form.ShowDialog()
    End Sub

    Private Sub NúmeroDaPTRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmeroDaPTRToolStripMenuItem.Click
        Dim form = New PTRdigital
        form.ShowDialog()
    End Sub

    Private Sub InstrumentaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentaçãoToolStripMenuItem.Click
        Dim form = New Instrumentacao
        form.ShowDialog()
    End Sub

    Private Sub ConstruçãoCivilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstruçãoCivilToolStripMenuItem.Click
        Dim form = New ConstrucaoCivil
        form.ShowDialog()
    End Sub

    Private Sub UsinagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsinagemToolStripMenuItem.Click
        Dim form = New Usinagem
        form.ShowDialog()
    End Sub

    Private Sub MapaDePermissõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapaDePermissõesToolStripMenuItem.Click
        Dim form = New MapaPermissoes
        form.ShowDialog()
    End Sub

    Private Sub MapaDePermissõesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MapaDePermissõesToolStripMenuItem1.Click
        Dim form = New MapaPermissoes
        form.ShowDialog()
    End Sub

    Private Sub ParqueQuímicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParqueQuímicoToolStripMenuItem.Click
        Dim form = New ParqueQuimicoLocal
        form.ShowDialog()
    End Sub

    Private Sub TratamentoDeCaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamentoDeCaldoToolStripMenuItem.Click
        Dim form = New TratamentoDeCaldoLocal
        form.ShowDialog()
    End Sub

    Private Sub FermentaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermentaçãoToolStripMenuItem.Click
        Dim form = New FermentacaoLocal
        form.ShowDialog()
    End Sub

    Private Sub DestilariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestilariaToolStripMenuItem.Click
        Dim form = New DestilariaLocal
        form.ShowDialog()
    End Sub
End Class