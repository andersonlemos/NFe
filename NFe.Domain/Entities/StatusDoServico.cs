using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities
{
    [Serializable(), XmlRoot(ElementName = "ConstStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class StatusDoServico
    {
      
      [XmlAttribute(AttributeName="versao")]
      public string versao { get; private set; }

      [XmlElementAttribute("tpAmb")]
      public string tpAmb { get; private set; }

      [XmlElementAttribute("cUF")]
      public string cUF { get; private set; }

      [XmlElementAttribute("xServ")]
      public string xServ { get; private set; }

      public StatusDoServico(string versao, string ambiente, string uf, string serv)
      {
        this.versao = versao;
        this.tpAmb = ambiente;
        this.cUF = uf;
        this.xServ = serv;
      }
        

    }
}
