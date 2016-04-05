using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <remarks/>
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        /// <remarks/>
        public Amb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public string dhEvento
        {
            get
            {
                return this.dhEventoField;
            }
            set
            {
                this.dhEventoField = value;
            }
        }

        /// <remarks/>
        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        /// <remarks/>
        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        /// <remarks/>
        public string verEvento
        {
            get
            {
                return this.verEventoField;
            }
            set
            {
                this.verEventoField = value;
            }
        }

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
