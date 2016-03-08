using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities
{
    [Serializable(), XmlRoot(ElementName = "ConstStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class StatusDoServico
    {
      
      [XmlAttribute(AttributeName="versao")]
      public string versao { get; set; }

      [XmlElementAttribute("tpAmb")]
      public string tpAmb { get; set; }

      [XmlElementAttribute("cUF")]
      public string cUF { get; set; }

      [XmlElementAttribute("xServ")]
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
