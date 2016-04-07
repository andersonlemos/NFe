using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public partial class ProcEvento
    {

        public Evento evento { get; set; }
        public RetEvento retEvento { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao { get; set; }


    }
}
