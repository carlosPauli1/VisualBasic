Imports ByteBank.Classe.employe

Public Class FrmMain
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Main"
        lblMain.Text = "Main"
        btnBonificacao.Text = "Obter Bonificação"
    End Sub

    Private Sub btnBonificacao_Click(sender As Object, e As EventArgs) Handles btnBonificacao.Click

        Dim Funcionario As New manager()
        Funcionario.Nome = "Carlos Roberto Pauli"
        Funcionario.cpf = "487.478.454-98"
        Funcionario.salario = 28000

        Dim Funcionario2 As New Diretor()

        Funcionario2.Nome = "Priscila Kistenmacher Pauli"
        Funcionario2.cpf = "437.278.353-94"
        Funcionario2.salario = 48000

        MsgBox("O Salário do " + Funcionario.Nome + " é " + Funcionario.salario.ToString)
        MsgBox("A Bonificação do " + Funcionario.Nome + " será de " + Funcionario.obterBonificacao().ToString)

        MsgBox("O Salário do " + Funcionario2.Nome + " é " + Funcionario2.salario.ToString)
        MsgBox("A Bonificação do " + Funcionario2.Nome + " será de " + Funcionario2.obterBonificacao().ToString)

    End Sub
End Class
