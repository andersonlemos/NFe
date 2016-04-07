using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(AnonymousType = true, Namespace =NamespaceBase.Domain)]
    public class RetCancNFeInfCanc
    {

        public Amb tpAmb { get; set; }

        public string verAplic { get; set; }

        public string cStat { get; set; }

        public string xMotivo { get; set; }

        public CodUfIBGE cUF { get; set; }

        public string chNFe { get; set; }

        public DateTime dhRecbto { get; set; }

        [XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified { get; set; }

        public string nProt { get; set; }
        
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }
        
    }
}
