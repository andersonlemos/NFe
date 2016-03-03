
Imports System.Xml.Serialization

<Serializable(), _
 XmlRoot(ElementName:="retConsStatServ", Namespace:="http://www.portalfiscal.inf.br/nfe")> _
Public Class RetornoConsultaStatusDoServico

    <XmlAttribute(attributeName:="versao")> _
    Public Property versao As String

    <XmlElementAttribute("tpAmb")> _
    Public Property tpAmb As String

    <XmlElementAttribute("cStat")> _
    Public Property cStat As String

    <XmlElement("xServ")> _
    Public Property xServ As String

    <XmlElement("xMotivo")> _
    Public Property xMotivo As String

    <XmlElement("dhResp")> _
    Public Property dhResp As String

    <XmlElement("indCont")> _
    Public Property indCont As String

    <XmlElement("ultNsu")> _
    Public Property ultNsu As String

End Class
