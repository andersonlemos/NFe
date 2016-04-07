using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public class RetEvento
    {

        public TRetEventoInfEvento infEvento { get; set; }

        [XmlAttributeAttribute()]
        public string versao { get; set; }

    }
}
