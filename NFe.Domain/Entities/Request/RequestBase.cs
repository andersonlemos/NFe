using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Request
{
    public  abstract class RequestBase
    {
        [XmlAttribute(AttributeName = "versao")]
        public string versao { get; set; }

    }
}
