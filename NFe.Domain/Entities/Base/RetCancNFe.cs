using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
  
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public class RetCancNFe
    {

        public RetCancNFeInfCanc infCanc { get; set; }

        [XmlAttributeAttribute("versao")]
        public string versao { get; set; }
    }

}
