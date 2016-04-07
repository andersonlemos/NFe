using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class EventoInfEvento
    {
        
        public COrgaoIBGE cOrgao { get; set; }
        
        public Amb tpAmb { get; set; }
        
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item { get; set; }
        
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName { get; set; }

        public string chNFe { get; set; }

        public string dhEvento { get; set; }

        public string tpEvento { get; set; }

        public string nSeqEvento { get; set; }

        public string verEvento { get; set; }

        public EventoInfEventoDetEvento detevento { get; set; }
        
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }

    }
}
