using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(AnonymousType = true, Namespace =NamespaceBase.Domain)]
    public class RetCancNFeInfCanc
    {

        public Amb tpAmb { get; set; }

        [XmlElementAttribute("verAplic")]
        public string verAplic { get; set; }

        [XmlElementAttribute("cStat")]
        public string cStat { get; set; }

        [XmlElementAttribute("xMotivo")]
        public string xMotivo { get; set; }

        public CodUfIBGE cUF { get; set; }

        [XmlElementAttribute("chNFe")]
        public string chNFe { get; set; }

        [XmlElementAttribute("dhRecbto")]
        public DateTime dhRecbto { get; set; }

        [XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified { get; set; }

        [XmlElementAttribute("nProt")]
        public string nProt { get; set; }
        
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }
        
    }
}
