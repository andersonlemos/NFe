using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{
 
    [XmlTypeAttribute(Namespace = NamespaceBase.Domain)]
    public class Evento
    {
        public EventoInfEvento infEvento { get; set; }
        
        [XmlAttributeAttribute()]
        public string versao { get; set; }
       
    }
}
