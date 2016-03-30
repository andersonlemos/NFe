using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities
{
    [Serializable(), XmlRoot(ElementName = "consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class StatusDoServico
    {

      [XmlAttribute(AttributeName = "versao")]
      public string versao { get; set; }

      [XmlElement("tpAmb",Order=1)]
      public string tpAmb { get; set; }

      [XmlElement("cUF",Order=2)]
      public string cUF { get; set; }
        
      [XmlElement("xServ",Order=3)]
      public string xServ { get; set; }
        
      public StatusDoServico()
      {
      }
        
       public StatusDoServico(string versao, string ambiente, string uf, string serv)
      {
        this.versao = versao;
        this.tpAmb = ambiente;
        this.cUF = uf;
        this.xServ = serv;
        
      }
        

    }
}
