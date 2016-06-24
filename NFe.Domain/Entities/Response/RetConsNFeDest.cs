
using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.Response
{
   
    [XmlType(Namespace = NamespaceBase.Domain)]
    [XmlRoot("retConsNFeDest", Namespace = NamespaceBase.Domain,IsNullable = false)]
    public class RetConsNFeDest:ModelBase
    {

        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        [XmlElement("verAplic")]
        public string verAplic { get; set; }

        [XmlElement("cStat")]
        public string cStat { get; set; }

        [XmlElement("xMotivo")]
        public string xMotivo { get; set; }

        [XmlElement("dhResp")]
        public DateTime dhResp { get; set; }

        [XmlElement("indCont")]
        public RetConsNFeDestIndCont indCont { get; set; }

        [XmlIgnore()]
        public bool indContSpecified { get; set; }

        [XmlElement("ultNSU")]
        public string ultNSU { get; set; }

        [XmlElementAttribute("ret")]
        public RetConsNFeDestRet[] ret { get; set; }
        

    }



   

   

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false
        )]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResCancTpNF
    {

        /// <remarks/>
        [XmlEnum("0")] Item0,

        /// <remarks/>
        [XmlEnum("1")] Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResCancCSitNFe
    {

        /// <remarks/>
        [XmlEnum("3")] Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResCancCSitConf
    {

        /// <remarks/>
        [XmlEnum("0")] Item0,

        /// <remarks/>
        [XmlEnum("1")] Item1,

        /// <remarks/>
        [XmlEnum("2")] Item2,

        /// <remarks/>
        [XmlEnum("3")] Item3,

        /// <remarks/>
        [XmlEnum("4")] Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetConsNFeDestRetResNFe
    {

        private string chNFeField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string xNomeField;

        private string ieField;

        private string dEmiField;

        private TRetConsNFeDestRetResNFeTpNF tpNFField;

        private string vNFField;

        private string digValField;

        private System.DateTime dhRecbtoField;

        private TRetConsNFeDestRetResNFeCSitNFe cSitNFeField;

        private TRetConsNFeDestRetResNFeCSitConf cSitConfField;

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
        public ItemChoiceType ItemElementName
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
        public TRetConsNFeDestRetResNFeTpNF tpNF
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
        public TRetConsNFeDestRetResNFeCSitNFe cSitNFe
        {
            get { return this.cSitNFeField; }
            set { this.cSitNFeField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResNFeCSitConf cSitConf
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false
        )]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResNFeTpNF
    {

        /// <remarks/>
        [XmlEnum("0")] Item0,

        /// <remarks/>
        [XmlEnum("1")] Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResNFeCSitNFe
    {

        /// <remarks/>
        [XmlEnum("1")] Item1,

        /// <remarks/>
        [XmlEnum("2")] Item2,

        /// <remarks/>
        [XmlEnum("3")] Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResNFeCSitConf
    {

        /// <remarks/>
        [XmlEnum("0")] Item0,

        /// <remarks/>
        [XmlEnum("1")] Item1,

        /// <remarks/>
        [XmlEnum("2")] Item2,

        /// <remarks/>
        [XmlEnum("3")] Item3,

        /// <remarks/>
        [XmlEnum("4")] Item4,
    }

 
}