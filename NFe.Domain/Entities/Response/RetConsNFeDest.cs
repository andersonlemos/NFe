
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.Response
{
   
    [XmlType(Namespace = NamespaceBase.Domain)]
    [XmlRoot("retConsNFeDest", Namespace = NamespaceBase.Domain,IsNullable = false)]
    public class RetConsNFeDest
    {

        [XmlAttribute("versao")]
        public string versao { get; set; }

        [XmlElement("tpAmb")]
        public Amb tpAmb { get; set; }

        public string VerAplic { get;set }


        private string cStatField;

        private string xMotivoField;

        private System.DateTime dhRespField;

        private TRetConsNFeDestIndCont indContField;

        private bool indContFieldSpecified;

        private string ultNSUField;

        private TRetConsNFeDestRet[] retField;

        private TVeConsNFeDest versaoField;

       
        /// <remarks/>
        public string cStat
        {
            get { return this.cStatField; }
            set { this.cStatField = value; }
        }

        /// <remarks/>
        public string xMotivo
        {
            get { return this.xMotivoField; }
            set { this.xMotivoField = value; }
        }

        /// <remarks/>
        public System.DateTime dhResp
        {
            get { return this.dhRespField; }
            set { this.dhRespField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestIndCont indCont
        {
            get { return this.indContField; }
            set { this.indContField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool indContSpecified
        {
            get { return this.indContFieldSpecified; }
            set { this.indContFieldSpecified = value; }
        }

        /// <remarks/>
        public string ultNSU
        {
            get { return this.ultNSUField; }
            set { this.ultNSUField = value; }
        }

        /// <remarks/>
        [XmlElement("ret")]
        public TRetConsNFeDestRet[] ret
        {
            get { return this.retField; }
            set { this.retField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public TVeConsNFeDest versao
        {
            get { return this.versaoField; }
            set { this.versaoField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {

        /// <remarks/>
        [XmlEnum("1")] Item1,

        /// <remarks/>
        [XmlEnum("2")] Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestIndCont
    {

        /// <remarks/>
        [XmlEnum("0")] Item0,

        /// <remarks/>
        [XmlEnum("1")] Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetConsNFeDestRet
    {

        private object itemField;

        /// <remarks/>
        [XmlElement("resCCe", typeof (TRetConsNFeDestRetResCCe))]
        [XmlElement("resCanc", typeof (TRetConsNFeDestRetResCanc))]
        [XmlElement("resNFe", typeof (TRetConsNFeDestRetResNFe))]
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetConsNFeDestRetResCCe
    {

        private string chNFeField;

        private string dhEventoField;

        private TRetConsNFeDestRetResCCeTpEvento tpEventoField;

        private string nSeqEventoField;

        private TRetConsNFeDestRetResCCeDescEvento descEventoField;

        private string xCorrecaoField;

        private TRetConsNFeDestRetResCCeTpNF tpNFField;

        private System.DateTime dhRecbtoField;

        private string nSUField;

        /// <remarks/>
        public string chNFe
        {
            get { return this.chNFeField; }
            set { this.chNFeField = value; }
        }

        /// <remarks/>
        public string dhEvento
        {
            get { return this.dhEventoField; }
            set { this.dhEventoField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResCCeTpEvento tpEvento
        {
            get { return this.tpEventoField; }
            set { this.tpEventoField = value; }
        }

        /// <remarks/>
        public string nSeqEvento
        {
            get { return this.nSeqEventoField; }
            set { this.nSeqEventoField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResCCeDescEvento descEvento
        {
            get { return this.descEventoField; }
            set { this.descEventoField = value; }
        }

        /// <remarks/>
        public string xCorrecao
        {
            get { return this.xCorrecaoField; }
            set { this.xCorrecaoField = value; }
        }

        /// <remarks/>
        public TRetConsNFeDestRetResCCeTpNF tpNF
        {
            get { return this.tpNFField; }
            set { this.tpNFField = value; }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get { return this.dhRecbtoField; }
            set { this.dhRecbtoField = value; }
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
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResCCeTpEvento
    {

        /// <remarks/>
        [XmlEnum("110110")] Item110110,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResCCeDescEvento
    {

        /// <remarks/>
        [XmlEnum("Carta de Correção")] CartadeCorreção,

        /// <remarks/>
        [XmlEnum("Carta de Correcao")] CartadeCorrecao,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TRetConsNFeDestRetResCCeTpNF
    {

        /// <remarks/>
        [XmlEnum("0")] Item0,

        /// <remarks/>
        [XmlEnum("1")] Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetConsNFeDestRetResCanc
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVeConsNFeDest
    {

        /// <remarks/>
        [XmlEnum("1.01")] Item101,
    }
}