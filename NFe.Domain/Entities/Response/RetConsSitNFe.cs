using NFe.Domain.Entities.Base;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Response
{

    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    [XmlRoot("retConsSitNFe", Namespace = NamespaceBase.Domain, IsNullable = false)]
    public class RetConsSitNFe
    {
        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElement("verAplic")]
        public string verAplic { get; set; }

        [XmlElement("cStat")]
        public string cStat { get; set; }

        [XmlElement("xMotivo")]
        public string xMotivo { get; set; }

        [XmlElement("cUF")]
        public CodUfIBGE cUF { get; set; }

        [XmlElement("dhRecbto")]
        public string dhRecbto { get; set; }
        
        [XmlElement("chNFe")]
        public string chNFe { get; set; }

        public ProtNFe protNFe { get; set; }

        public RetCancNFe retCancNFe { get; set; }

        [XmlElementAttribute("procEventoNFe")]
        public ProcEvento[] procEventoNFe { get; set; }

        [XmlAttributeAttribute()]
        public VerConsSitNFe versao { get; set; }
        
    }


}
