using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
   
    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class ProtNFeInfProt
    {
        [XmlElementAttribute("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElementAttribute("verAplic")]
        public string verAplic { get; set; }

        [XmlElementAttribute("chNFe")]
        public string chNFe { get; set; }

        [XmlElementAttribute("dhRecbto")]
        public DateTime dhRecbto { get; set; }

        [XmlElementAttribute("nProt")]
        public string nProt { get; set; }

        [XmlElementAttribute("digVal", DataType = "base64Binary")]
        public byte[] digval { get; set; }

        [XmlElementAttribute("cStat")]
        public string cStat { get; set; }

        [XmlElementAttribute("xMotivo")]
        public string xMotivo { get; set; }

        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }

    }
}
