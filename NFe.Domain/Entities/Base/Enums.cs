using System;
using System.CodeDom;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain)]
    public enum Amb
    {

        [XmlEnumAttribute("1")]
        PRODUCAO,

        [XmlEnumAttribute("2")]
        HOMOLOGACAO,
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain)]
    public enum CodUfIBGE
    {

        /// <remarks/>
        [XmlEnumAttribute("11")]
        RONDONIA,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        ACRE,

        /// <remarks/>
        [XmlEnumAttribute("13")]
        AMAZONAS,

        /// <remarks/>
        [XmlEnumAttribute("14")]
        RORAIMA,

        /// <remarks/>
        [XmlEnumAttribute("15")]
        PARA,

        /// <remarks/>
        [XmlEnumAttribute("16")]
        AMAPA,

        /// <remarks/>
        [XmlEnumAttribute("17")]
        TOCANTINS,

        /// <remarks/>
        [XmlEnumAttribute("21")]
        MARANHAO,

        /// <remarks/>
        [XmlEnumAttribute("22")]
        PIAUI,

        /// <remarks/>
        [XmlEnumAttribute("23")]
        CEARA,

        /// <remarks/>
        [XmlEnumAttribute("24")]
        RIO_GRANDE_DO_NORTE,

        /// <remarks/>
        [XmlEnumAttribute("25")]
        PARAIBA,

        /// <remarks/>
        [XmlEnumAttribute("26")]
        PERNAMBUCO,

        /// <remarks/>
        [XmlEnumAttribute("27")]
        ALAGOAS,

        /// <remarks/>
        [XmlEnumAttribute("28")]
        SERGIPE,

        /// <remarks/>
        [XmlEnumAttribute("29")]
        BAHIA,

        /// <remarks/>
        [XmlEnumAttribute("31")]
        MINAS_GERAIS,

        /// <remarks/>
        [XmlEnumAttribute("32")]
        ESPIRITO_SANTO,

        /// <remarks/>
        [XmlEnumAttribute("33")]
        RIO_DE_JANEIRO,

        /// <remarks/>
        [XmlEnumAttribute("35")]
        SAO_PAULO,

        /// <remarks/>
        [XmlEnumAttribute("41")]
        PARANA,

        /// <remarks/>
        [XmlEnumAttribute("42")]
        SANTA_CATARINA,

        /// <remarks/>
        [XmlEnumAttribute("43")]
        RIO_GRANDE_DO_SUL,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        MATO_GROSSO_DO_SUL,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        MATO_GROSSO,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        GOIAS,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        DISTRITO_FEDERAL,
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain, IncludeInSchema = false)]
    public enum TipoDeDocumento
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        IE
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain, IncludeInSchema = false)]
    public enum CnpjOuCpfDestinatario
    {

        /// <remarks/>
        CNPJDest,

        /// <remarks/>
        CPFDest,
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain)]
    public enum VersaoNFe
    {

        [XmlEnumAttribute("3.10")]
        Versao_3_10,

        [XmlEnumAttribute("2.00")]
        Versao_2_00,

        [XmlEnumAttribute("1.01")]
        Versao_1_01,

        [XmlEnumAttribute("1.00")]
        Versao_1_00
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain)]
    public enum COrgaoIBGE
    {

        /// <remarks/>
        [XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [XmlEnumAttribute("90")]
        Item90,

        /// <remarks/>
        [XmlEnumAttribute("91")]
        Item91,

        /// <remarks/>
        [XmlEnumAttribute("92")]
        Item92,
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true,Namespace = NamespaceBase.Domain)]
    public enum XServOptions
    {

        [XmlEnumAttribute("CONSULTAR NFE DEST")]
        CONSULTAR_NFE_DESTINATARIO,

        [XmlEnumAttribute("STATUS")]
        CONSULTAR_STATUS_SERVICO,

        [XmlEnumAttribute("CONSULTAR")]
        CONSULTAR


    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum RetConsNFeDestIndCont
    {

        [XmlEnum("0")]
        NAO_POSSUI_MAIS_DOCUMENTOS_PARA_CNPJ,

        [XmlEnum("1")]
        POSSUI_MAIS_DOCUMENTOS_PARA_CNPJ,
    }
    
    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum RetConsNFeDestRetResCCeTpEvento
    {

        [XmlEnum("110110")]
        CODIGO_EVENTO_110110,
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum RetConsNFeDestRetResCCeDescEvento
    {

        [XmlEnum("Carta de Correção")]
        CartadeCorreção,

        [XmlEnum("Carta de Correcao")]
        CartadeCorrecao,
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum TipoDeOperacaoNotaFiscal
    {

        [XmlEnum("0")]
        ENTRADA,

        [XmlEnum("1")]
        SAIDA,
    }
    
    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum SituacaoDaNFe
    {
        [XmlEnum("1")]
        USO_AUTORIZADO_NO_MOMENTO_DA_CONSULTA,
        [XmlEnum("2")]
        USO_DENEGADO,
        /// <remarks/>
        [XmlEnum("3")]
        NFe_CANCELADA,
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum SituacaoManifestacaoDestinatario
    {
        
        [XmlEnum("0")]
        SEM_MANIFESTACAO_DESTINATARIO,
        
        [XmlEnum("1")]
        CONFIRMADA_OPERACAO,

        [XmlEnum("2")]
        DESCONEHCIDA,

        [XmlEnum("3")]
        OPERACAO_NAO_REALIZADA,

        [XmlEnum("4")]
        CIENCIA,
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum IndicadorDeNFeConsultada
    {
        [XmlEnum("0")]
        TODAS,

        [XmlEnum("1")]
        SEM_MANIFESTACAO,

        [XmlEnum("2")]
        SEM_MANIFESTACAO_E_CIENCIA_DA_EMISSAO
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public enum IndicadorDoEmissorNFe
    {
        [XmlEnum("0")]
        TODOS_EMITENTES_REMETENTES,

        [XmlEnum("1")]
        EMISSORES_REMETENTES_SEM_MESMO_NPJ_BASE

    }
    public abstract class Enums
    {
    }
}
