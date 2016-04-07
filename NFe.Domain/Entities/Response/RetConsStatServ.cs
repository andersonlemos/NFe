using NFe.Domain.Entities.Base;
using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Response
{
   [Serializable(), XmlRoot(ElementName = "retConsStatServ", Namespace = NamespaceBase.Domain)]
   public class RetConsStatServ:ModelBase
   {
    
     [XmlElement("verAplic")]
     public string verAplic { get; set; }

     [XmlElement("cStat")]
     public string cStat { get; set; }

     [XmlElement("xMotivo")]
     public string xMotivo { get; set; }

     [XmlElement("cUF")]
     public string cUF { get; set; }

     [XmlElement("dhRecbto")]
     public string dhRecbto { get; set; }

     [XmlElement("tMed")]
     public string tMed { get; set; }

     public RetConsStatServ()
      {
      }

     public RetConsStatServ(string versao, Amb amb, string ver, string verAplic, string codStatus, string motivo, string uf, string dhRecebimento, string tMed)
      {
           this.versao = versao;
           this.tpAmb = amb;
           this.versao = ver;
           this.verAplic = verAplic;
           this.cStat = codStatus;
           this.xMotivo = motivo;
           this.cUF = uf;
           this.dhRecbto = dhRecebimento;
           this.tMed = tMed;

      }


   }
}
