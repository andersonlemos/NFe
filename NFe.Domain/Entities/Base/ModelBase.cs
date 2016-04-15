using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
    
    public abstract class ModelBase
    {
        [XmlAttribute(AttributeName = "versao")]
        public string versao { get; set; }
             

       
    }
}
