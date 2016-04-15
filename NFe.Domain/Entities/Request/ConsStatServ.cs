﻿using NFe.Domain.Entities.Base;
using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities
{
    [Serializable(), XmlRoot(ElementName = "consStatServ", Namespace = NamespaceBase.Domain)]
    public class ConsStatServ:ModelBase
    {


      [XmlElement("tpAmb")]
      public Amb tpAmb { get; set; }  

      [XmlElement("cUF")]
      public CodUfIBGE cUF { get; set; }
        
      [XmlElement("xServ")]
      public string xServ { get; set; }
        
      public ConsStatServ()
      {
      }

      public ConsStatServ(string versao, Amb ambiente, CodUfIBGE uf, string serv)
      {
        this.versao = versao;
        this.tpAmb = ambiente;
        this.cUF = uf;
        this.xServ = serv;
        
      }
        

    }
}
