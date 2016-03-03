Imports System.Text
Imports System.IO
Imports System.Xml.Serialization
Imports System.Xml

Imports System.Security.Cryptography.X509Certificates

Public Class Sefaz

    Public Shared ReadOnly Property DeclaracaoXml As String

        Get
            Return "<?xml version=""" & "1.0" & """ encoding=""" & "UTF-8""" & "?>"
        End Get

    End Property

    Public Shared Function Gerar(Of T)(ByVal objeto As T)

        Dim elementoXMl As XElement

        Try

            Dim serializador As XmlSerializer = New XmlSerializer(GetType(T))

            Dim fluxoDeMemoria = New MemoryStream()


            Dim leitorDeTexto As TextReader = New StreamReader(fluxoDeMemoria, Encoding.UTF8)

            serializador.Serialize(fluxoDeMemoria, objeto)

            fluxoDeMemoria.Position = 0

            elementoXMl = XElement.Load(leitorDeTexto)

            elementoXMl.Attributes().Where(Function(x) x.Name.LocalName.Equals("xsd") OrElse x.Name.LocalName.Equals("xsi")).Remove()

        Catch be As Exception
            Throw New Exception("Gerar xml")
        End Try

        Return String.Concat(DeclaracaoXml, LimpaXML(elementoXMl.ToString))

    End Function

  Public Shared Function BuscaCertificados() As X509Certificate2

        Dim certificado As New X509Certificate2

        Try
            
            Dim repositorioDeCertificados As New X509Store("MY", StoreLocation.CurrentUser)

            repositorioDeCertificados.Open(OpenFlags.ReadOnly OrElse OpenFlags.OpenExistingOnly)

            Dim certificados As X509Certificate2Collection = repositorioDeCertificados.Certificates

            Dim colecaoDeCertificados As X509Certificate2Collection = certificados _
                                                                       .Find(X509FindType.FindByTimeValid, DateTime.Now, False) _
                                                                       .Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, False)
            
            Dim selecaoDeCertificados As X509Certificate2Collection

            selecaoDeCertificados = X509Certificate2UI.SelectFromCollection(colecaoDeCertificados, _
                                                                      "Certificado(s) Digital(is) disponível(is)", _
                                                                      "Selecione o Certificado Digital para uso no aplicativo", _
                                                                       X509SelectionFlag.SingleSelection)

            If selecaoDeCertificados.Count = 0 Then
                certificado.Reset()
                MessageBox.Show("Nenhum certificado escolhido")
            Else
                certificado = selecaoDeCertificados(0)
            End If

            repositorioDeCertificados.Close()

            Return certificado

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            Return certificado

        End Try

    End Function
   

    Private Shared Function LimpaXML(ByVal xml As String) As String

        Dim dicionarioDeCaracteres As New Dictionary(Of Object, String)

        With dicionarioDeCaracteres
            .Add(vbLf, "><")
            .Add(vbTab, "><")
            .Add(vbCr, "><")
            .Add("> <", "><")
            .Add(">  <", "><")
            .Add(">   <", "><")
            .Add(">    <", "><")
            .Add(">     <", "><")
        End With

        Dim retorno As String = Xml.Trim

        For Each ch In retorno
            While dicionarioDeCaracteres.ContainsKey(ch)
                retorno = retorno.Replace(ch, dicionarioDeCaracteres(ch))
            End While
        Next

        Return retorno

    End Function

    Public Shared Function DerserializarXml(xml As String, tipo As Type) As Object

     
        Dim xmldoc As New XmlDocument

        xmldoc.LoadXml(xml)

        Dim xmln As XmlNamespaceManager = New XmlNamespaceManager(xmldoc.NameTable)

        xmln.RemoveNamespace("xmlns", "http://www.portalfiscal.inf.br/nfe")

        Dim serializer As XmlSerializer = New XmlSerializer(tipo)

        Dim stream As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(xmlDoc.OuterXml))

        Return serializer.Deserialize(stream)

    End Function



End Class
