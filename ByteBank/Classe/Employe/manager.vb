Namespace Classe.employe
    Public Class manager
#Region "Propertys"
        Public Property Nome As String
        Public Property cpf As String
        Public Property salario As Double
#End Region

#Region "CONSTRUTORES"
#End Region

#Region "METHODS/FUNCTIONS"
        Public Function obterBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region
    End Class
End Namespace