using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Domain.Entities.Base
{

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public partial class ProtNFe
    {

        public ProtNFeInfProt infProt { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao { get; set; }


    }
}
