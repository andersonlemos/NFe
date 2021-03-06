﻿using System;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

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
      public XServOptions xServ { get; set; }
        
      public ConsStatServ()
      {
      }

      public ConsStatServ(VersaoNFe versao, Amb tpAmb, CodUfIBGE cUF, XServOptions xServ)
      {
        this.versao = versao;
        this.tpAmb = tpAmb;
        this.cUF = cUF;
        this.xServ = xServ;
        
      }
        

    }
}
