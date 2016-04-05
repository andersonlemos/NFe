using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
  
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public class RetCancNFe
    {

        private TRetCancNFeInfCanc infCancField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TRetCancNFeInfCanc infCanc
        {
            get
            {
                return this.infCancField;
            }
            set
            {
                this.infCancField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
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
