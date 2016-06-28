using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public class RetEvento
    {

        public RetEventoInfEvento infEvento { get; set; }

        [XmlAttributeAttribute("versao")]
        public string versao { get; set; }

    }
}
