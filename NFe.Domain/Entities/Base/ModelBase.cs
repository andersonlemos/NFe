using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    
    public abstract class ModelBase
    {
        [XmlAttribute(AttributeName = "versao")]
        public VersaoNFe versao { get; set; }
             

       
    }
}
