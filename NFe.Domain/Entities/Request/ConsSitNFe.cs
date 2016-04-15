using NFe.Domain.Entities.Base;
using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Request
{
   
    [Serializable(), XmlRoot(ElementName = "consSitNFe", Namespace =NamespaceBase.Domain)]
    public class ConsSitNFe:ModelBase
    {

        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElement("xServ")]
        public string xServ { get; set; }

        [XmlElement("chNFe")]
        public string chNFe { get; set; }

        public ConsSitNFe()
        {
        }

        public ConsSitNFe(string versao, Amb ambiente, string serv, string chNFe)
        {
            this.versao = versao;
            this.tpAmb = ambiente;
            this.xServ = serv;
            this.chNFe = chNFe;
        }


    }
}
