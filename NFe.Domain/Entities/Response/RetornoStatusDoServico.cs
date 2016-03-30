using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Domain.Entities.Response
{
   [Serializable(), XmlRoot(ElementName = "retConsStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
   public class RetornoStatusDoServico
   {
     [XmlAttribute("versao")]
     public string versao { get; set; }

     [XmlElement("tpAmb")]
     public string tpAmb { get; set; }
     
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

     public RetornoStatusDoServico()
      {
      }

     public RetornoStatusDoServico(string versao,string amb,string ver,string verAplic,string codStatus,string motivo,string uf,string dhRecebimento,string tMed)
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
