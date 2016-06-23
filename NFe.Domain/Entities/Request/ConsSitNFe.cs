using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.Request
{
   
    [Serializable(), XmlRoot(ElementName = "consSitNFe", Namespace =NamespaceBase.Domain)]
    public class ConsSitNFe:ModelBase
    {

        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElement("xServ")]
        public XServOptions xServ { get; set; }

        [XmlElement("chNFe")]
        public string chNFe { get; set; }

        public ConsSitNFe()
        {
        }

        public ConsSitNFe(VersaoNFe versao, Amb ambiente, XServOptions serv, string chNFe)
        {
            this.versao = versao;
            this.tpAmb = ambiente;
            this.xServ = serv;
            this.chNFe = chNFe;
        }


    }
}
