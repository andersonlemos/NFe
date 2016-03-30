using NFe.Domain.Entities;
using NFe.Helpers.Interfaces;
using NFe.Helpers.Services;
using NFe.Repositories.Entities;
using System.Xml;


namespace NFe.Console
{
    class Program
    {
     
        static void Main(string[] args)
        {
          const string xsd = @"D:\Repositories\NFe\Documentos\Esquemas\PL_008h2\consStatServ_v3.10.xsd";
            
         StatusDoServico statsuDoServico = new StatusDoServico("3.10","1","33","STATUS");
         ISerializeOperation nfe = new SerializeDocument<StatusDoServico>(statsuDoServico);

         XmlDocument nfeDadosMsg = new XmlDocument();
           
         nfeDadosMsg.PreserveWhitespace = false;
         nfeDadosMsg.LoadXml(nfe.Serialize());
         
         nfeDadosMsg.Save(@"d:\xml.xml");
            

         System.Console.WriteLine(nfeDadosMsg.OuterXml);
         System.Console.WriteLine("================================================================");
         System.Console.ReadKey();

         System.Console.WriteLine(new ValidateDocument( xsd,@"d:\xml.xml"));
         System.Console.WriteLine("================================================================");
         System.Console.ReadKey();

         NFeCabecMsg nfeCabMsg = new NFeCabecMsg();

          nfeCabMsg.cUF = "33";
          nfeCabMsg.versaoDados = "3.10";

          Certificate cert = new Certificate();
          NFe.Repositories.Clients.NFeStatusServico2SoapClient service = new Repositories.Clients.NFeStatusServico2SoapClient();
          NFe.Repositories.Response.NFeStatusServicoNF2Response response = new Repositories.Response.NFeStatusServicoNF2Response();
          NFe.Repositories.Request.NFeStatusServicoNF2Request request = new Repositories.Request.NFeStatusServicoNF2Request(nfeCabMsg,nfeDadosMsg);

          service.ClientCredentials.ClientCertificate.Certificate = cert.GetCollection()[1];
          response.nfeStatusServicoNF2Result = service.NFeStatusServicoNF2(request).nfeStatusServicoNF2Result;
            System.Console.WriteLine(response.nfeStatusServicoNF2Result.OuterXml);

           System.Console.ReadKey();
      


        }

    }
}
