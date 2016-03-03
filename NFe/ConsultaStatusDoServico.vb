
Imports System.Xml.Serialization

<Serializable(), _
 XmlRoot(ElementName:="consStatServ", Namespace:="http://www.portalfiscal.inf.br/nfe")> _
Public Class ConsultaStatusDoServico

    <XmlAttribute(attributeName:="versao")> _
    Public Property versao As String = "3.10"

    <XmlElementAttribute("tpAmb")> _
    Public Property tpAmb As String = "2"

    <XmlElementAttribute("cUF")> _
    Public Property cUf As String = "33"

    <XmlElementAttribute("xServ")> _
    Public Property xServ As String = "STATUS"
    
End Class
