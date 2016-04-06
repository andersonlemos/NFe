using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFe.Domain.Entities.Base;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Response
{

    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    [XmlRootAttribute("retConsSitNFe", Namespace = NamespaceBase.Domain, IsNullable = false)]
    public class RetConsSitNFe
    {
        public Amb tpAmb { get; set; }

        public string verAplic { get; set; }

        public string cStat { get; set; }

        public string xMotivo { get; set; }

        public CodUfIBGE cUF { get; set; }

        public string dhRecbto { get; set; }

        public string chNFe { get; set; }

        public ProtNFe protNFe { get; set; }

        public RetCancNFe retCancNFe { get; set; }

        [XmlElementAttribute("procEventoNFe")]
        public ProcEvento[] procEventoNFe { get; set; }

        [XmlAttributeAttribute()]
        public VerConsSitNFe versao { get; set; }
        
    }


}
