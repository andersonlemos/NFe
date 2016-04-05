using NFe.Domain.Entities.Base;
using NFe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Request
{
   
    [Serializable(), XmlRoot(ElementName = "consSitNFe", Namespace =NamespaceBase.Domain)]
    public class ConsSitNFe:ModelBase
    {

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
