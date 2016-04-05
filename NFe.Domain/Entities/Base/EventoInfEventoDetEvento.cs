using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Base
{

    [XmlTypeAttribute(AnonymousType = true, Namespace = NamespaceBase.Domain)]
    public class EventoInfEventoDetEvento
    {

        public XmlElement[] Any { get; set; }

        public XmlElement[] AnyAttr { get; set; }

    }
}
