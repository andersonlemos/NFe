using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.NFeDoc
{
    [Serializable()]
    [XmlRoot("infNFe", Namespace = NamespaceBase.Domain)]
    public class InfNFe:ModelBase
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }


        //
        //private TNFeInfNFeIde ideField;

        //private TNFeInfNFeEmit emitField;

        //private TNFeInfNFeAvulsa avulsaField;

        //private TNFeInfNFeDest destField;

        //private TLocal retiradaField;

        //private TLocal entregaField;

        //private TNFeInfNFeAutXML[] autXMLField;

        //private TNFeInfNFeDet[] detField;

        //private TNFeInfNFeTotal totalField;

        //private TNFeInfNFeTransp transpField;

        //private TNFeInfNFeCobr cobrField;

        //private TNFeInfNFePag[] pagField;

        //private TNFeInfNFeInfAdic infAdicField;

        //private TNFeInfNFeExporta exportaField;

        //private TNFeInfNFeCompra compraField;

        //private TNFeInfNFeCana canaField;

        //private string versaoField;

        //private string idField;

        ///// <remarks/>
        //public TNFeInfNFeIde ide
        //{
        //    get
        //    {
        //        return this.ideField;
        //    }
        //    set
        //    {
        //        this.ideField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeEmit emit
        //{
        //    get
        //    {
        //        return this.emitField;
        //    }
        //    set
        //    {
        //        this.emitField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeAvulsa avulsa
        //{
        //    get
        //    {
        //        return this.avulsaField;
        //    }
        //    set
        //    {
        //        this.avulsaField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeDest dest
        //{
        //    get
        //    {
        //        return this.destField;
        //    }
        //    set
        //    {
        //        this.destField = value;
        //    }
        //}

        ///// <remarks/>
        //public TLocal retirada
        //{
        //    get
        //    {
        //        return this.retiradaField;
        //    }
        //    set
        //    {
        //        this.retiradaField = value;
        //    }
        //}

        ///// <remarks/>
        //public TLocal entrega
        //{
        //    get
        //    {
        //        return this.entregaField;
        //    }
        //    set
        //    {
        //        this.entregaField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("autXML")]
        //public TNFeInfNFeAutXML[] autXML
        //{
        //    get
        //    {
        //        return this.autXMLField;
        //    }
        //    set
        //    {
        //        this.autXMLField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("det")]
        //public TNFeInfNFeDet[] det
        //{
        //    get
        //    {
        //        return this.detField;
        //    }
        //    set
        //    {
        //        this.detField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeTotal total
        //{
        //    get
        //    {
        //        return this.totalField;
        //    }
        //    set
        //    {
        //        this.totalField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeTransp transp
        //{
        //    get
        //    {
        //        return this.transpField;
        //    }
        //    set
        //    {
        //        this.transpField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeCobr cobr
        //{
        //    get
        //    {
        //        return this.cobrField;
        //    }
        //    set
        //    {
        //        this.cobrField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("pag")]
        //public TNFeInfNFePag[] pag
        //{
        //    get
        //    {
        //        return this.pagField;
        //    }
        //    set
        //    {
        //        this.pagField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeInfAdic infAdic
        //{
        //    get
        //    {
        //        return this.infAdicField;
        //    }
        //    set
        //    {
        //        this.infAdicField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeExporta exporta
        //{
        //    get
        //    {
        //        return this.exportaField;
        //    }
        //    set
        //    {
        //        this.exportaField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeCompra compra
        //{
        //    get
        //    {
        //        return this.compraField;
        //    }
        //    set
        //    {
        //        this.compraField = value;
        //    }
        //}

        ///// <remarks/>
        //public TNFeInfNFeCana cana
        //{
        //    get
        //    {
        //        return this.canaField;
        //    }
        //    set
        //    {
        //        this.canaField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public string versao
        //{
        //    get
        //    {
        //        return this.versaoField;
        //    }
        //    set
        //    {
        //        this.versaoField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        //public string Id
        //{
        //    get
        //    {
        //        return this.idField;
        //    }
        //    set
        //    {
        //        this.idField = value;
        //    }
        //}
    }
}
