using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Request
{
    [Serializable(), XmlRoot(ElementName = "consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class ConsSitNFe:RequestBase
    {

        //[XmlAttribute(AttributeName = "versao")]
        //public string versao { get; set; }

        [XmlElement("tpAmb", Order = 1)]
        public string tpAmb { get; set; }

        [XmlElement("xServ", Order = 2)]
        public string xServ { get; set; }

        [XmlElement("chNFe", Order = 3)]
        public string chNFe { get; set; }

        public ConsSitNFe()
        {
        }

        public ConsSitNFe(string versao, string ambiente, string serv, string chNFe)
        {
            this.versao = versao;
            this.tpAmb = ambiente;
            this.xServ = serv;
            this.chNFe = chNFe;
        }


    }
}
