using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
   
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class RetConsNFeDestRetResNFe
    {
        [XmlElement("chNFe")]
        public string chNFe { get; set; }

        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("TipoDocumento")]
        public string Documento { get; set; }

        [XmlIgnore()]
        public TipoDeDocumento TipoDocumento { get; set; }

        [XmlElement("xNome")]
        public string xNome { get; set; }

        [XmlElement("IE")]
        public string IE { get; set; }

        [XmlElement("dEmi")]
        public DateTime dEmi { get; set; }

        [XmlElement("tpNF")]
        public TipoDeOperacaoNotaFiscal tpNF { get; set; }

        [XmlElement("vNF")]
        public string vNF { get; set; }

        [XmlElement("digVal")]
        public string digVal { get; set; }

        [XmlElement("dhRecbto")]
        public DateTime dhRecbto { get; set; }

        [XmlElement("cSitNFe")]
        public SituacaoDaNFe cSitNFe { get; set; }

        [XmlElement("cSitConf")]
        public SituacaoManifestacaoDestinatario csitConf { get; set; }

        [XmlAttribute("NSU")]
        public string NSU { get; set; }

    }
}
