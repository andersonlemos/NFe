Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports NFe

Public Class Form1

    Private cert As X509Certificate2 = New X509Certificate2(Sefaz.BuscaCertificados())
    Private servico As New NFeStatusServico.NfeStatusServico2SoapClient
    Private resposta As New NFeStatusServico.nfeStatusServicoNF2Response
    Private arquivoRequisicao As New XmlDocument
    Private documentoRequisicao As New TConsStatServ

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        documentoRequisicao.versao = "3.10"
        documentoRequisicao.tpAmb = NFe.TAmb.Item2
        documentoRequisicao.cUF = NFe.TCodUfIBGE.Item33
        documentoRequisicao.xServ = NFe.TConsStatServXServ.STATUS
        
        arquivoRequisicao.LoadXml(documentoRequisicao.Serialize(UTF8Encoding.UTF8))

        TextBox2.Text = arquivoRequisicao.OuterXml
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        resposta.nfeStatusServicoNF2Result = servico.nfeStatusServicoNF2(New NFeStatusServico.nfeCabecMsg() With {.cUF = "33", .versaoDados = "3.10"}, arquivoRequisicao)


        Dim d As New XmlDocument

        d.LoadXml(resposta.nfeStatusServicoNF2Result.OuterXml)

        d.Save("d:\teste.xml")


        TextBox1.Text = resposta.nfeStatusServicoNF2Result.OuterXml
    
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim status As NFe.TRetConsStatServ
        Dim d As New XmlDocument

        d.Load("d:\teste.xml")
        
        status = TRetConsStatServ.Deserialize(d.OuterXml)
        
        TextBox3.Text = status.xMotivo.ToString()

    End Sub
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        servico.ClientCredentials.ClientCertificate.Certificate = cert
     
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New Form2
        x.Show()
    End Sub
End Class
