using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
   
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace =NamespaceBase.Domain)]
    public class EventoInfEvento
    {

        private COrgaoIBGE cOrgaoField;

        private Amb tpAmbField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string chNFeField;

        private string dhEventoField;

        private string tpEventoField;

        private string nSeqEventoField;

        private string verEventoField;

        private EventoInfEventoDetEvento detEventoField;

        private string idField;


      public COrgaoIBGE cOrgao { get; set; }


      public Amb tpAmb { get; set; }

      /// <remarks/>
      [XmlElementAttribute("CNPJ", typeof (string))]
      [XmlElementAttribute("CPF", typeof (string))]
      [XmlChoiceIdentifierAttribute("ItemElementName")]

      public string Item { get; set; }

      /// <remarks/>
      [XmlIgnoreAttribute()]
      public ItemChoiceType ItemElementName { get; set; }

      public string chNFe { get; set; }

      public string dhEvento { get; set; }


        public string tpEvento { get; set; }

      public string nSeqEvento { get; set; }

      public string verEvento { get; set; }

        public EventoInfEventoDetEvento detevento { get; set; }

        /// <remarks/>
        public TEventoInfEventoDetEvento detEvento
        {
            get
            {
                return this.detEventoField;
            }
            set
            {
                this.detEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}
