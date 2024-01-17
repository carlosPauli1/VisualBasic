<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnBonificacao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(53, 13)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "ByteBank"
        '
        'btnBonificacao
        '
        Me.btnBonificacao.Location = New System.Drawing.Point(15, 37)
        Me.btnBonificacao.Name = "btnBonificacao"
        Me.btnBonificacao.Size = New System.Drawing.Size(135, 23)
        Me.btnBonificacao.TabIndex = 1
        Me.btnBonificacao.Text = "Obter Bonificação"
        Me.btnBonificacao.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBonificacao)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents btnBonificacao As Button
End Class
