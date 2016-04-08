using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public partial class TRetEventoInfEvento
    {
        public Amb tpAmb { get; set; }

        [XmlElementAttribute("verAplic")]
        public string verAplic { get; set; }

        public COrgaoIBGE cOrgao { get; set; }

        [XmlElementAttribute("cStat")]
        public string cStat { get; set; }

        [XmlElementAttribute("xMotivo")]
        public string xMotivo { get; set; }

        [XmlElementAttribute("chNFe")]
        public string chNFe { get; set; }

        [XmlElementAttribute("tpEvento")]
        public string tpEvento { get; set; }

        [XmlElementAttribute("xEvento")]
        public string xEvento { get; set; }

        [XmlElementAttribute("nSeqEvento")]
        public string nSeqEvento { get; set; }

        [XmlElementAttribute("CNPJDest", typeof(string))]
        [XmlElementAttribute("CPFDest", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName { get; set; }

        [XmlElementAttribute("emailDest")]
        public string emailDest { get; set; }

        [XmlElementAttribute("dhRegEvento")]
        public string dhRegEvento { get; set; }

        [XmlElementAttribute("nProt")]
        public string nProt { get; set; }
        
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }

    }

}
