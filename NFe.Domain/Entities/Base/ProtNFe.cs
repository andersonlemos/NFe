
using System.Xml.Serialization;
namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public class ProtNFe
    {

        public ProtNFeInfProt infProt { get; set; }

        [XmlAttributeAttribute()]
        public string versao { get; set; }


    }
}

