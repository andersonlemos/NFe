using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFe.Helpers.Services;
using System.Security.Cryptography.X509Certificates;
using NFe.Repositories.StatusServico;
using System.Xml;
using NFe.Domain.Entities;
using NFe.Helpers.Services;
using NFe.Helpers.Interfaces;
using System.ServiceModel;

namespace NFe.Console
{
    class Program
    {
     
        static void Main(string[] args)
        {
           
         StatusDoServico statsuDoServico = new StatusDoServico("3.10","2","33","STATUS");
         ISerializeOperation nfe = new SerializeDocument<StatusDoServico>(statsuDoServico);

         XmlDocument nfeDadosMsg = new XmlDocument();
         
         nfeDadosMsg.LoadXml(nfe.Serialize());
          nfeDadosMsg.Save(@"d:\xml.xml");
         System.Console.WriteLine(nfeDadosMsg.OuterXml);
         System.Console.WriteLine("================================================================");
         System.Console.ReadKey();


          nfeCabecMsg nfeCabMsg = new nfeCabecMsg();

          nfeCabMsg.cUF = "33";
          nfeCabMsg.versaoDados = "3.10";

          Certificate cert = new Certificate();
          NfeStatusServico2SoapClient servico = new NfeStatusServico2SoapClient();
          nfeStatusServicoNF2Response resp = new nfeStatusServicoNF2Response();

          servico.ClientCredentials.ClientCertificate.Certificate = cert.GetCollection()[1];

          resp.nfeStatusServicoNF2Result = servico.nfeStatusServicoNF2(nfeCabMsg,nfeDadosMsg);

          System.Console.WriteLine(resp.nfeStatusServicoNF2Result.OuterXml);

          System.Console.ReadKey();
            
       
        }

    }
}
