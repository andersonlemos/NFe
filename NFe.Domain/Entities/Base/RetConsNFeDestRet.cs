using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class RetConsNFeDestRet
    {

        [XmlElementAttribute("resCCe", typeof(RetConsNFeDestRetResCCe))]
        [XmlElementAttribute("resCanc", typeof(RetConsNFeDestRetResCanc))]
        [XmlElementAttribute("resNFe", typeof(RetConsNFeDestRetResNFe))]
        public object Item { get; set; }
        
    }
}
