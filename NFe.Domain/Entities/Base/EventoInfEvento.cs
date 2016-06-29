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
        public TipoDeDocumento ItemElementName { get; set; }

        [XmlElementAttribute("chNFe")]
        public string chNFe { get; set; }

        [XmlElementAttribute("dhEvento")]
        public string dhEvento { get; set; }

        [XmlElementAttribute("tpEvento")]
        public string tpEvento { get; set; }

        [XmlElementAttribute("nSeqEvento")]
        public string nSeqEvento { get; set; }

        [XmlElementAttribute("verEvento")]
        public string verEvento { get; set; }

        [XmlElementAttribute("detevento")]
        public EventoInfEventoDetEvento detevento { get; set; }

        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }

    }
}
