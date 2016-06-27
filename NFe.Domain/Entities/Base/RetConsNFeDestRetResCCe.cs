using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class RetConsNFeDestRetResCCe
    {

        [XmlAttribute("NSU")]
        public string NSU { get; set; }

        [XmlElement("chNFe")]
        public string chNFe { get; set; }

        [XmlElement("dhEvento")]
        public DateTime dhEvento { get; set; }

        [XmlElement("tpEvento")]
        public RetConsNFeDestRetResCCeTpEvento tpEvento { get; set; }
        
        [XmlElement("nSeqEvento")]
        public string nSeqEvento { get; set; }

        [XmlElement("descEvento")]
        public RetConsNFeDestRetResCCeDescEvento descEvento { get; set; }

        [XmlElement("xCorrecao")]
        public string xCorrecao { get; set; }

        [XmlElement("tpNF")]
        public TipoDeOperacaoNotaFiscal tpNF { get; set; }

        [XmlElement("dhRecbto")]
        public DateTime dhRecbto { get; set; }
        
       
    }
}
