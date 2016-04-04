using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public enum TAmb
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        PRODUCAO,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        HOMOLOGACAO,
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public enum TCodUfIBGE
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
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain, IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    public abstract class Enums
    {
    }
}
