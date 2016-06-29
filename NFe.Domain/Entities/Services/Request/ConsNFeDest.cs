using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.Services.Request
{
    [Serializable(), XmlRoot(ElementName = "consNFeDest", Namespace = NamespaceBase.Domain)]
    public class ConsNFeDest : ModelBase
    {

        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElement("xServ")]
        public string xServ { get; set; }

        [XmlElement("CNPJ")]
        public string cnpj { get; set; }

        [XmlElement("indNFe")]
        public string indNFe { get; set; }

        [XmlElement("indEmi")]
        public string indEmi { get; set; }

        [XmlElement("ultNSU")]
        public string ultNsu { get; set; }

        public ConsNFeDest(){}

        public ConsNFeDest(VersaoNFe versao, Amb tpAmb, string xServ, string cnpj, string indNFe, string indEmi, string ultNsu)
        {
            this.versao = versao;
            this.tpAmb = tpAmb;
            this.xServ = xServ;
            this.cnpj = cnpj;
            this.indNFe = indNFe;
            this.indEmi = indEmi;
            this.ultNsu = ultNsu;
        }
    

    }
}
