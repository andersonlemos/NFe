
using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.Response
{
   
    [XmlType(Namespace = NamespaceBase.Domain)]
    [XmlRoot("retConsNFeDest", Namespace = NamespaceBase.Domain,IsNullable = false)]
    public class RetConsNFeDest:ModelBase
    {

        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElement("verAplic")]
        public string verAplic { get; set; }

        [XmlElement("cStat")]
        public string cStat { get; set; }

        [XmlElement("xMotivo")]
        public string xMotivo { get; set; }

        [XmlElement("dhResp")]
        public DateTime dhResp { get; set; }

        [XmlElement("indCont")]
        public RetConsNFeDestIndCont indCont { get; set; }

        [XmlIgnore()]
        public bool indContSpecified { get; set; }

        [XmlElement("ultNSU")]
        public string ultNSU { get; set; }

        [XmlElementAttribute("ret")]
        public RetConsNFeDestRet[] ret { get; set; }
        
    }
    
}