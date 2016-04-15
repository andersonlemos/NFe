using NFe.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Request
{
    [Serializable(),XmlRoot("downloadNFe",Namespace=NamespaceBase.Domain)]
    public class DownloadNFe:ModelBase
    {
        public Amb tpAmb { get; set; }
        
        [XmlElement("xServ")]
        public string xServ { get; set; }

        [XmlElement("CNPJ")]
        public string CNPJ{get;set;}

        [XmlElement("chNFe")]
        public string chNFe { get; set; }

    }
}
