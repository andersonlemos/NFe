using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NFe.Domain.Entities.Response;

namespace NFe.Domain.Entities.Base
{
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public  class RetConsNFeDestRetResCanc
    {




        private string chNFeField;

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        private string xNomeField;

        private string ieField;

        private string dEmiField;

        private TRetConsNFeDestRetResCancTpNF tpNFField;

        private string vNFField;

        private string digValField;

        private System.DateTime dhRecbtoField;

        private TRetConsNFeDestRetResCancCSitNFe cSitNFeField;

        private TRetConsNFeDestRetResCancCSitConf cSitConfField;

        private string nSUField;

        /// <remarks/>
        public string chNFe
        {
            get { return this.chNFeField; }
            set { this.chNFeField = value; }
        }

        /// <remarks/>
        [XmlElement("CNPJ", typeof (string))]
        [XmlElement("CPF", typeof (string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName
        {
            get { return this.itemElementNameField; }
            set { this.itemElementNameField = value; }
        }

        /// <remarks/>
        public string xNome
        {
            get { return this.xNomeField; }
            set { this.xNomeField = value; }
        }

        /// <remarks/>
        public string IE
        {
            get { return this.ieField; }
            set { this.ieField = value; }
        }

        /// <remarks/>
        public string dEmi
        {
            get { return this.dEmiField; }
            set { this.dEmiField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResCancTpNF tpNF
        {
            get { return this.tpNFField; }
            set { this.tpNFField = value; }
        }

        /// <remarks/>
        public string vNF
        {
            get { return this.vNFField; }
            set { this.vNFField = value; }
        }

        /// <remarks/>
        public string digVal
        {
            get { return this.digValField; }
            set { this.digValField = value; }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get { return this.dhRecbtoField; }
            set { this.dhRecbtoField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResCancCSitNFe cSitNFe
        {
            get { return this.cSitNFeField; }
            set { this.cSitNFeField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResCancCSitConf cSitConf
        {
            get { return this.cSitConfField; }
            set { this.cSitConfField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string NSU
        {
            get { return this.nSUField; }
            set { this.nSUField = value; }
        }
    }
    }

