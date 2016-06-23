using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.Request
{
    [Serializable(), XmlRoot(ElementName = "consNFeDest", Namespace = NamespaceBase.Domain)]
    public class ConsNFeDest : ModelBase
    {

        [XmlElement("tpAmb")]
        public Amb TpAmb { get; set; }

        [XmlElement("xServ")]
        public string XServ { get; set; }

        [XmlElement("CNPJ")]
        public string Cnpj { get; set; }

        [XmlElement("indNFe")]
        public string IndNFe { get; set; }

        [XmlElement("indEmi")]
        public string IndEmi { get; set; }

        [XmlElement("ultNSU")]
        public string UltNsu { get; set; }

        public ConsNFeDest(){}

        public ConsNFeDest(Amb oTpAmb, string oXServ, string oCnpj, string oIndNFe, string oIndEmi, string oUltNsu)
        {
            TpAmb = oTpAmb;
            XServ = oXServ;
            Cnpj = oCnpj;
            IndNFe = oIndNFe;
            IndEmi = oIndEmi;
            UltNsu = oUltNsu;
        }
    

    }
}
