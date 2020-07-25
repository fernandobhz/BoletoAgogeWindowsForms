<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ValorLabel1 As System.Windows.Forms.Label
        Dim VencimentoLabel As System.Windows.Forms.Label
        Dim NossoNumeroLabel As System.Windows.Forms.Label
        Dim SacadoRazaoLabel As System.Windows.Forms.Label
        Dim SacadoCNPJLabel As System.Windows.Forms.Label
        Dim SacadoEnderecoLabel As System.Windows.Forms.Label
        Dim SacadoBairroLabel As System.Windows.Forms.Label
        Dim SacadoCepLabel As System.Windows.Forms.Label
        Dim SacadoCidadeLabel As System.Windows.Forms.Label
        Dim SacadoUFLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Me.VencimentoDateTimePicker = New AgogeComponents.DateTimePicker()
        Me.DBoletoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.NossoNumeroTextEdit = New System.Windows.Forms.TextBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.SacadoRazaoTextEdit = New System.Windows.Forms.TextBox()
        Me.SacadoCNPJTextEdit = New System.Windows.Forms.TextBox()
        Me.SacadoEnderecoTextEdit = New System.Windows.Forms.TextBox()
        Me.SacadoBairroTextEdit = New System.Windows.Forms.TextBox()
        Me.SacadoCepTextEdit = New System.Windows.Forms.TextBox()
        Me.SacadoCidadeTextEdit = New System.Windows.Forms.TextBox()
        Me.SacadoUFTextEdit = New System.Windows.Forms.TextBox()
        Me.DocumentoTextEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMHT = New System.Windows.Forms.Button()
        ValorLabel1 = New System.Windows.Forms.Label()
        VencimentoLabel = New System.Windows.Forms.Label()
        NossoNumeroLabel = New System.Windows.Forms.Label()
        SacadoRazaoLabel = New System.Windows.Forms.Label()
        SacadoCNPJLabel = New System.Windows.Forms.Label()
        SacadoEnderecoLabel = New System.Windows.Forms.Label()
        SacadoBairroLabel = New System.Windows.Forms.Label()
        SacadoCepLabel = New System.Windows.Forms.Label()
        SacadoCidadeLabel = New System.Windows.Forms.Label()
        SacadoUFLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        CType(Me.DBoletoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValorLabel1
        '
        ValorLabel1.AutoSize = True
        ValorLabel1.Location = New System.Drawing.Point(46, 31)
        ValorLabel1.Name = "ValorLabel1"
        ValorLabel1.Size = New System.Drawing.Size(34, 13)
        ValorLabel1.TabIndex = 1
        ValorLabel1.Text = "Valor:"
        '
        'VencimentoLabel
        '
        VencimentoLabel.AutoSize = True
        VencimentoLabel.Location = New System.Drawing.Point(233, 31)
        VencimentoLabel.Name = "VencimentoLabel"
        VencimentoLabel.Size = New System.Drawing.Size(66, 13)
        VencimentoLabel.TabIndex = 3
        VencimentoLabel.Text = "Vencimento:"
        '
        'NossoNumeroLabel
        '
        NossoNumeroLabel.AutoSize = True
        NossoNumeroLabel.Location = New System.Drawing.Point(451, 31)
        NossoNumeroLabel.Name = "NossoNumeroLabel"
        NossoNumeroLabel.Size = New System.Drawing.Size(80, 13)
        NossoNumeroLabel.TabIndex = 5
        NossoNumeroLabel.Text = "Nosso Numero:"
        '
        'SacadoRazaoLabel
        '
        SacadoRazaoLabel.AutoSize = True
        SacadoRazaoLabel.Location = New System.Drawing.Point(37, 130)
        SacadoRazaoLabel.Name = "SacadoRazaoLabel"
        SacadoRazaoLabel.Size = New System.Drawing.Size(41, 13)
        SacadoRazaoLabel.TabIndex = 12
        SacadoRazaoLabel.Text = "Razao:"
        '
        'SacadoCNPJLabel
        '
        SacadoCNPJLabel.AutoSize = True
        SacadoCNPJLabel.Location = New System.Drawing.Point(41, 104)
        SacadoCNPJLabel.Name = "SacadoCNPJLabel"
        SacadoCNPJLabel.Size = New System.Drawing.Size(37, 13)
        SacadoCNPJLabel.TabIndex = 10
        SacadoCNPJLabel.Text = "CNPJ:"
        '
        'SacadoEnderecoLabel
        '
        SacadoEnderecoLabel.AutoSize = True
        SacadoEnderecoLabel.Location = New System.Drawing.Point(22, 156)
        SacadoEnderecoLabel.Name = "SacadoEnderecoLabel"
        SacadoEnderecoLabel.Size = New System.Drawing.Size(56, 13)
        SacadoEnderecoLabel.TabIndex = 14
        SacadoEnderecoLabel.Text = "Endereco:"
        '
        'SacadoBairroLabel
        '
        SacadoBairroLabel.AutoSize = True
        SacadoBairroLabel.Location = New System.Drawing.Point(37, 182)
        SacadoBairroLabel.Name = "SacadoBairroLabel"
        SacadoBairroLabel.Size = New System.Drawing.Size(37, 13)
        SacadoBairroLabel.TabIndex = 16
        SacadoBairroLabel.Text = "Bairro:"
        '
        'SacadoCepLabel
        '
        SacadoCepLabel.AutoSize = True
        SacadoCepLabel.Location = New System.Drawing.Point(308, 182)
        SacadoCepLabel.Name = "SacadoCepLabel"
        SacadoCepLabel.Size = New System.Drawing.Size(29, 13)
        SacadoCepLabel.TabIndex = 18
        SacadoCepLabel.Text = "Cep:"
        '
        'SacadoCidadeLabel
        '
        SacadoCidadeLabel.AutoSize = True
        SacadoCidadeLabel.Location = New System.Drawing.Point(439, 182)
        SacadoCidadeLabel.Name = "SacadoCidadeLabel"
        SacadoCidadeLabel.Size = New System.Drawing.Size(43, 13)
        SacadoCidadeLabel.TabIndex = 20
        SacadoCidadeLabel.Text = "Cidade:"
        '
        'SacadoUFLabel
        '
        SacadoUFLabel.AutoSize = True
        SacadoUFLabel.Location = New System.Drawing.Point(741, 182)
        SacadoUFLabel.Name = "SacadoUFLabel"
        SacadoUFLabel.Size = New System.Drawing.Size(24, 13)
        SacadoUFLabel.TabIndex = 22
        SacadoUFLabel.Text = "UF:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(656, 31)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(65, 13)
        DocumentoLabel.TabIndex = 7
        DocumentoLabel.Text = "Documento:"
        '
        'VencimentoDateTimePicker
        '
        Me.VencimentoDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.VencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DBoletoBindingSource, "Vencimento", True))
        Me.VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.VencimentoDateTimePicker.Location = New System.Drawing.Point(305, 28)
        Me.VencimentoDateTimePicker.Name = "VencimentoDateTimePicker"
        Me.VencimentoDateTimePicker.Size = New System.Drawing.Size(122, 20)
        Me.VencimentoDateTimePicker.TabIndex = 4
        Me.VencimentoDateTimePicker.Value = Nothing
        '
        'DBoletoBindingSource
        '
        Me.DBoletoBindingSource.DataSource = GetType(BoletoAgogeWindowsForms.BoletosAgogeBB)
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorTextBox.Location = New System.Drawing.Point(86, 28)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(135, 20)
        Me.ValorTextBox.TabIndex = 2
        '
        'NossoNumeroTextEdit
        '
        Me.NossoNumeroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "NossoNumero", True))
        Me.NossoNumeroTextEdit.Location = New System.Drawing.Point(537, 28)
        Me.NossoNumeroTextEdit.Name = "NossoNumeroTextEdit"
        Me.NossoNumeroTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NossoNumeroTextEdit.TabIndex = 6
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(727, 54)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(82, 27)
        Me.btnPDF.TabIndex = 24
        Me.btnPDF.Text = "Gerar PDF"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'SacadoRazaoTextEdit
        '
        Me.SacadoRazaoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoRazao", True))
        Me.SacadoRazaoTextEdit.Location = New System.Drawing.Point(86, 127)
        Me.SacadoRazaoTextEdit.Name = "SacadoRazaoTextEdit"
        Me.SacadoRazaoTextEdit.Size = New System.Drawing.Size(723, 20)
        Me.SacadoRazaoTextEdit.TabIndex = 13
        '
        'SacadoCNPJTextEdit
        '
        Me.SacadoCNPJTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoCNPJ", True))
        Me.SacadoCNPJTextEdit.Location = New System.Drawing.Point(86, 101)
        Me.SacadoCNPJTextEdit.Name = "SacadoCNPJTextEdit"
        Me.SacadoCNPJTextEdit.Size = New System.Drawing.Size(135, 20)
        Me.SacadoCNPJTextEdit.TabIndex = 11
        '
        'SacadoEnderecoTextEdit
        '
        Me.SacadoEnderecoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoEndereco", True))
        Me.SacadoEnderecoTextEdit.Location = New System.Drawing.Point(86, 153)
        Me.SacadoEnderecoTextEdit.Name = "SacadoEnderecoTextEdit"
        Me.SacadoEnderecoTextEdit.Size = New System.Drawing.Size(723, 20)
        Me.SacadoEnderecoTextEdit.TabIndex = 15
        '
        'SacadoBairroTextEdit
        '
        Me.SacadoBairroTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoBairro", True))
        Me.SacadoBairroTextEdit.Location = New System.Drawing.Point(86, 179)
        Me.SacadoBairroTextEdit.Name = "SacadoBairroTextEdit"
        Me.SacadoBairroTextEdit.Size = New System.Drawing.Size(213, 20)
        Me.SacadoBairroTextEdit.TabIndex = 17
        '
        'SacadoCepTextEdit
        '
        Me.SacadoCepTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoCep", True))
        Me.SacadoCepTextEdit.Location = New System.Drawing.Point(343, 179)
        Me.SacadoCepTextEdit.Name = "SacadoCepTextEdit"
        Me.SacadoCepTextEdit.Size = New System.Drawing.Size(84, 20)
        Me.SacadoCepTextEdit.TabIndex = 19
        '
        'SacadoCidadeTextEdit
        '
        Me.SacadoCidadeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoCidade", True))
        Me.SacadoCidadeTextEdit.Location = New System.Drawing.Point(488, 179)
        Me.SacadoCidadeTextEdit.Name = "SacadoCidadeTextEdit"
        Me.SacadoCidadeTextEdit.Size = New System.Drawing.Size(247, 20)
        Me.SacadoCidadeTextEdit.TabIndex = 21
        '
        'SacadoUFTextEdit
        '
        Me.SacadoUFTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "SacadoUF", True))
        Me.SacadoUFTextEdit.Location = New System.Drawing.Point(771, 179)
        Me.SacadoUFTextEdit.Name = "SacadoUFTextEdit"
        Me.SacadoUFTextEdit.Size = New System.Drawing.Size(38, 20)
        Me.SacadoUFTextEdit.TabIndex = 23
        '
        'DocumentoTextEdit
        '
        Me.DocumentoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DBoletoBindingSource, "Documento", True))
        Me.DocumentoTextEdit.Location = New System.Drawing.Point(727, 28)
        Me.DocumentoTextEdit.Name = "DocumentoTextEdit"
        Me.DocumentoTextEdit.Size = New System.Drawing.Size(82, 20)
        Me.DocumentoTextEdit.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dados Obrigatórios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Dados do Sacado"
        '
        'btnMHT
        '
        Me.btnMHT.Location = New System.Drawing.Point(727, 94)
        Me.btnMHT.Name = "btnMHT"
        Me.btnMHT.Size = New System.Drawing.Size(82, 27)
        Me.btnMHT.TabIndex = 25
        Me.btnMHT.Text = "Gerar MHT"
        Me.btnMHT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnMHT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 211)
        Me.Controls.Add(Me.btnMHT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextEdit)
        Me.Controls.Add(SacadoUFLabel)
        Me.Controls.Add(Me.SacadoUFTextEdit)
        Me.Controls.Add(SacadoCidadeLabel)
        Me.Controls.Add(Me.SacadoCidadeTextEdit)
        Me.Controls.Add(SacadoCepLabel)
        Me.Controls.Add(Me.SacadoCepTextEdit)
        Me.Controls.Add(SacadoBairroLabel)
        Me.Controls.Add(Me.SacadoBairroTextEdit)
        Me.Controls.Add(SacadoEnderecoLabel)
        Me.Controls.Add(Me.SacadoEnderecoTextEdit)
        Me.Controls.Add(SacadoCNPJLabel)
        Me.Controls.Add(Me.SacadoCNPJTextEdit)
        Me.Controls.Add(SacadoRazaoLabel)
        Me.Controls.Add(Me.SacadoRazaoTextEdit)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(NossoNumeroLabel)
        Me.Controls.Add(Me.NossoNumeroTextEdit)
        Me.Controls.Add(VencimentoLabel)
        Me.Controls.Add(ValorLabel1)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(Me.VencimentoDateTimePicker)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissão Boletos Agoge Sistemas"
        CType(Me.DBoletoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VencimentoDateTimePicker As AgogeComponents.DateTimePicker
    Friend WithEvents DBoletoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NossoNumeroTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents SacadoRazaoTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents SacadoCNPJTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents SacadoEnderecoTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents SacadoBairroTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents SacadoCepTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents SacadoCidadeTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents SacadoUFTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents DocumentoTextEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMHT As System.Windows.Forms.Button

End Class
