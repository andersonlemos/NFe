using System.Xml.Serialization;
using NFe.Domain.Entities.Response;

namespace NFe.Domain.Entities.Base
{
    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class RetConsNFeDestRet
    {

        [XmlElementAttribute("resCCe", typeof(RetConsNFeDestRetResCCe))]
        [XmlElementAttribute("resCanc", typeof(RetConsNFeDestRetResCanc))]
        [XmlElementAttribute("resNFe", typeof(TRetConsNFeDestRetResNFe))]
        public object Item { get; set; }
        
    }
}
