Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class Form1
    Private Boleto As New BoletosAgogeBB()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Boleto.Valor = 1000
        Boleto.Vencimento = DateAdd(DateInterval.Day, 1, Today)
        Boleto.NossoNumero = String.Format("{0:ddMMyyHHmm}", Now)
        Me.DBoletoBindingSource.DataSource = Me.Boleto
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        AgogeComponents.AbrirArquivoProgramaPadrao(Boleto.ToPDF)
    End Sub

    Private Sub btnMHT_Click(sender As Object, e As EventArgs) Handles btnMHT.Click
        AgogeComponents.AbrirArquivoProgramaPadrao(Boleto.ToMHT)
    End Sub

End Class





Class BoletosAgogeBB
    Inherits BoletoBancoBrasil1819

    Sub New()
        'MyBase.New(2366721)
        MyBase.New(Razao:="Agoge Sistemas", CNPJ:="14867123000139", Convenio:=2366721, ContaSemDigito:=32128, DigitoConta:=1, AgenciaSemDigito:=2818, DigitoAgencia:=5)
    End Sub
End Class





MustInherit Class BoletoBancoBrasil1819

    Property Vencimento As Date
    Property Valor As Decimal
    Property NossoNumero As String

    Property Documento As String = String.Empty

    Property SacadoRazao As String = String.Empty
    Property SacadoCNPJ As String = String.Empty
    Property SacadoEndereco As String = String.Empty
    Property SacadoBairro As String = String.Empty
    Property SacadoCep As String = String.Empty
    Property SacadoCidade As String = String.Empty
    Property SacadoUF As String = String.Empty



    Private CedenteRazao As String
    Private CedenteCNPJ As String = "              "

    Private Convenio As Integer

    Private ContaSemDigito As Integer
    Private DigitoConta As Integer
    Private AgenciaSemDigito As Integer

    Private DigitoAgencia As Integer





    Sub New(Convenio As Integer)
        Me.Convenio = Convenio
    End Sub

    Sub New(Razao As String, CNPJ As String, Convenio As Integer)
        Me.CedenteRazao = Razao
        Me.CedenteCNPJ = CNPJ
        Me.Convenio = Convenio
    End Sub

    Sub New(Razao As String, CNPJ As String, Convenio As Integer, ContaSemDigito As Integer, DigitoConta As Integer, AgenciaSemDigito As Integer, DigitoAgencia As Integer)
        Me.CedenteRazao = Razao
        Me.CedenteCNPJ = CNPJ
        Me.Convenio = Convenio
        Me.ContaSemDigito = ContaSemDigito
        Me.DigitoConta = DigitoConta
        Me.AgenciaSemDigito = AgenciaSemDigito
        Me.DigitoAgencia = DigitoAgencia
    End Sub

    Private Function getHtml() As String
        Dim c As New BoletoNet.Cedente
        c.Nome = Me.CedenteRazao
        c.CPFCNPJ = Me.CedenteCNPJ
        c.Convenio = Me.Convenio
        c.ContaBancaria = New BoletoNet.ContaBancaria()
        If Not String.IsNullOrEmpty(Me.AgenciaSemDigito) Then c.ContaBancaria.Agencia = AgenciaSemDigito
        If Not String.IsNullOrEmpty(Me.DigitoAgencia) Then c.ContaBancaria.DigitoAgencia = DigitoAgencia
        If Not String.IsNullOrEmpty(Me.ContaSemDigito) Then c.ContaBancaria.Conta = ContaSemDigito
        If Not String.IsNullOrEmpty(Me.DigitoConta) Then c.ContaBancaria.DigitoConta = DigitoConta

        Dim s As New BoletoNet.Sacado With {.Nome = Me.SacadoRazao, .Endereco = New BoletoNet.Endereco}
        If Not String.IsNullOrEmpty(Me.SacadoCNPJ) Then s.CPFCNPJ = Me.SacadoCNPJ
        With s.Endereco
            .End = Me.SacadoEndereco
            .Bairro = Me.SacadoBairro
            .CEP = Me.SacadoCep
            .Cidade = Me.SacadoCidade
            .UF = Me.SacadoUF
        End With

        Dim b As New BoletoNet.Boleto With {.Carteira = "18-019", .Cedente = c, .Sacado = s}
        b.DataVencimento = Me.Vencimento
        b.ValorBoleto = Me.Valor
        b.NossoNumero = Me.NossoNumero
        b.NumeroDocumento = Me.Documento

        For i As Integer = 1 To 7 '7 linhas é o espaço que +ou- o boleto real tem
            b.Instrucoes.Add(New BoletoNet.Instrucao_BancoBrasil() With {.Descricao = String.Empty})
        Next

        Dim bb As New BoletoNet.BoletoBancario() With {.CodigoBanco = 1, .Boleto = b, .MostrarComprovanteEntrega = False}
        bb.Boleto.Valida()

        Return bb.MontaHtml
    End Function





    Private Function getDefaultFileName(ExtensionWithoutDot As String)
        Dim DesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Return String.Format("{0}\Boleto_{1}_{2}_{3:yyyy-MM-dd}_{4:c2}.{5}", DesktopPath, SacadoRazao, NossoNumero, Vencimento, Valor, ExtensionWithoutDot).Replace(" ", "")
    End Function





    Sub ToPDF(PDFPath As String)
        Dim PathCentraHtml As String = String.Format("{0}.centra.html", PDFPath)
        Dim PathBoletoHtml As String = String.Format("{0}.boleto.html", PDFPath)

        Dim TempHtmlCentra As String = String.Format("<html><body><div style=""margin-left: 55px; margin-top: 100px""><iframe src=""{0}"" style=""width: 670px; height: 950px; border: 0"" frameBorder=""0"" scrolling=""no""></div></body></html>", PathBoletoHtml)
        Dim TempHtmlBoleto = Me.getHtml()

        My.Computer.FileSystem.WriteAllText(PathCentraHtml, TempHtmlCentra, False)
        My.Computer.FileSystem.WriteAllText(PathBoletoHtml, TempHtmlBoleto, False)

        Dim BoletoBitmap As Drawing.Bitmap = AgogeComponents.Web.Render.ToBitmap(String.Format("file:///{0}", PathCentraHtml), 794, 1050)

        AgogeComponents.Web.ToPDF(BoletoBitmap, PDFPath)

        My.Computer.FileSystem.DeleteFile(PathCentraHtml)
        My.Computer.FileSystem.DeleteFile(PathBoletoHtml)
    End Sub

    Function ToPDF() As String
        Dim PDFPath As String = getDefaultFileName("pdf")

        ToPDF(PDFPath)

        Return PDFPath
    End Function



    Sub ToMHT(MHTPath As String)

        Dim PathHTML As String = String.Format("{0}.html", MHTPath)

        My.Computer.FileSystem.WriteAllText(PathHTML, getHtml, False)

        Dim URL As String = String.Format("file:///{0}", PathHTML)

        Url2MHT(URL, MHTPath)

        My.Computer.FileSystem.DeleteFile(PathHTML)
    End Sub

    Function ToMHT() As String
        Dim MHTPath As String = getDefaultFileName("mht")

        ToMHT(MHTPath)

        Return MHTPath
    End Function

    Private Sub Url2MHT(ByVal Url As String, ByVal FilePath As String)
        'http://social.msdn.microsoft.com/Forums/vstudio/en-US/0ceadca6-dc14-45cb-9cd2-218b5364fff4/faq-how-do-i-save-a-web-page-in-vbnet?forum=vbgeneral
        Dim iMessage As CDO.Message = New CDO.Message
        iMessage.CreateMHTMLBody(Url, _
        CDO.CdoMHTMLFlags.cdoSuppressNone, "", "")
        Dim adodbstream As ADODB.Stream = New ADODB.Stream
        adodbstream.Type = ADODB.StreamTypeEnum.adTypeText
        adodbstream.Charset = "US-ASCII"
        adodbstream.Open()
        iMessage.DataSource.SaveToObject(adodbstream, "_Stream")
        adodbstream.SaveToFile(FilePath, _
                  ADODB.SaveOptionsEnum.adSaveCreateOverWrite)
    End Sub






End Class

