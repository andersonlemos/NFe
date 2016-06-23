using NFe.Domain.Entities.Base;
using System;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Response
{
   [Serializable(), XmlRoot(ElementName = "retConsStatServ", Namespace = NamespaceBase.Domain)]
   public class RetConsStatServ:ModelBase
   {
     [XmlElement("tpAmb")]
      public Amb tpAmb { get; set; }
    
     [XmlElement("verAplic")]
     public string verAplic { get; set; }

     [XmlElement("cStat")]
     public string cStat { get; set; }

     [XmlElement("xMotivo")]
     public string xMotivo { get; set; }

     [XmlElement("cUF")]
     public CodUfIBGE cUF { get; set; }

     [XmlElement("dhRecbto")]
     public string dhRecbto { get; set; }

     [XmlElement("tMed")]
     public string tMed { get; set; }

     public RetConsStatServ()
      {
      }

     public RetConsStatServ(VersaoNFe versao, Amb amb, string verAplic, string codStatus, string motivo, CodUfIBGE uf, string dhRecebimento, string tMed)
      {
           this.versao = versao;
           this.tpAmb = amb;
           this.verAplic = verAplic;
           this.cStat = codStatus;
           this.xMotivo = motivo;
           this.cUF = uf;
           this.dhRecbto = dhRecebimento;
           this.tMed = tMed;

      }


   }
}
