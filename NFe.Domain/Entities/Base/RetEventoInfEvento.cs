using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public partial class TRetEventoInfEvento
    {
        public Amb tpAmb { get; set; }

        public string verAplic { get; set; }

        public COrgaoIBGE cOrgao { get; set; }

        public string cStat { get; set; }

        public string xMotivo { get; set; }

        public string chNFe { get; set; }

        public string tpEvento { get; set; }

        public string xEvento { get; set; }

        public string nSeqEvento { get; set; }

        [XmlElementAttribute("CNPJDest", typeof(string))]
        [XmlElementAttribute("CPFDest", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName { get; set; }
        
        public string emailDest { get; set; }

        public string dhRegEvento { get; set; }

        public string nProt { get; set; }
        
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }

    }

}
