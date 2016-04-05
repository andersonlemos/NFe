using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Domain.Entities.Base
{
   
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public partial class ProtNFeInfProt
    {
        [System.Xml.Serialization.XmlElementAttribute("tpAmb")]
        public Amb tpAmb { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("verAplic")]
        public string verAplic { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("chNFe")]
        public string chNFe { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("dhRecbto")]
        public DateTime dhRecbto { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("nProt")]
        public string nProt { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("digVal", DataType = "base64Binary")]
        public byte[] digval { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("cStat")]
        public string cStat { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("xMotivo")]
        public string xMotivo { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }

    }
}
