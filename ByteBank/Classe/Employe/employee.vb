Namespace Classe.employe

    Public Class employee
#Region "Propertys"
        Public Property Nome As String
        Public Property cpf As String
        Public Property salario As Double
        Public Property cargo As String '1 - Diretor, 2 - Gerente, 3 - Caixa
#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cargo As String)
            cargo = _cargo
        End Sub

#End Region

#Region "METHODS/FUNCTIONS"
        Public Function obterBonificacao() As Double
            If cargo = "1" Then
                Return salario * 1
            ElseIf cargo = "2" Then
                Return salario * 0.1
            Else
                Return "Usuário não tem bonificação"
            End If
        End Function
#End Region

    End Class

End Namespace