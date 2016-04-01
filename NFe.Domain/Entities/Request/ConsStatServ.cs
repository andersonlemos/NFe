using NFe.Domain.Entities.Base;
using NFe.Domain.Entities.Request;
using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities
{
    [Serializable(), XmlRoot(ElementName = "consStatServ", Namespace = NamespaceBase.Domain)]
    public class ConsStatServ:ModelBase
    {

    
      [XmlElement("cUF")]
      public TCodUfIBGE cUF { get; set; }
        
      [XmlElement("xServ")]
      public string xServ { get; set; }
        
      public ConsStatServ()
      {
      }

      public ConsStatServ(string versao, TAmb ambiente, TCodUfIBGE uf, string serv)
      {
        this.versao = versao;
        this.tpAmb = ambiente;
        this.cUF = uf;
        this.xServ = serv;
        
      }
        

    }
}
