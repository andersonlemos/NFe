using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public partial class ProcEvento
    {

        private TEvento eventoField;

        private TRetEvento retEventoField;

        private string versaoField;

        /// <remarks/>
        public TEvento evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        /// <remarks/>
        public TRetEvento retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }
}
