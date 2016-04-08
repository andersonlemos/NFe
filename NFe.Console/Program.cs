using NFe.Domain.Entities;
using NFe.Domain.Entities.Base;
using NFe.Domain.Entities.Request;
using NFe.Domain.Entities.Response;
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
          ConsSitNFe consultaNFe = new ConsSitNFe("3.10",Amb.PRODUCAO, "CONSULTAR", "33160268643105000100550010000167591000000000");
          //ConsStatServ statsuDoServico = new ConsStatServ("3.10", TAmb.HOMOLOGACAO, TCodUfIBGE.RIO_DE_JANEIRO, "STATUS");
          //ISerializeOperation nfe = new SerializeDocument<ConsStatServ>(statsuDoServico);
          ISerializeOperation nfe = new SerializeDocument<ConsSitNFe>(consultaNFe);
         XmlDocument nfeDadosMsg = new XmlDocument();
           
         nfeDadosMsg.PreserveWhitespace = false;
         nfeDadosMsg.LoadXml(nfe.Serialize());
         
         nfeDadosMsg.Save(@"d:\xml.xml");
            

         System.Console.WriteLine(nfeDadosMsg.OuterXml);
         System.Console.WriteLine("================================================================");
         System.Console.ReadKey();

         System.Console.WriteLine(new ValidateDocument(xsd,@"d:\xml.xml").Validate());
         System.Console.WriteLine("================================================================");
         System.Console.ReadKey();

         NFeCabecMsg nfeCabMsg = new NFeCabecMsg();

          nfeCabMsg.cUF = "33";
          nfeCabMsg.versaoDados = "3.10";

          Certificate cert = new Certificate();
          XmlNode node = nfeDadosMsg;

          NFe.Repositories.ConsultaNFeService.NfeConsulta2SoapClient service =
            new Repositories.ConsultaNFeService.NfeConsulta2SoapClient();
          NFe.Repositories.ConsultaNFeService.nfeConsultaNF2Response response =
            new Repositories.ConsultaNFeService.nfeConsultaNF2Response();
          NFe.Repositories.ConsultaNFeService.nfeConsultaNF2Request request = new Repositories.ConsultaNFeService.nfeConsultaNF2Request(new Repositories.ConsultaNFeService.nfeCabecMsg { cUF = nfeCabMsg.cUF, versaoDados = nfeCabMsg.versaoDados }, node);
          service.ClientCredentials.ClientCertificate.Certificate = cert.GetCollection()[1];

          response.nfeConsultaNF2Result = service.nfeConsultaNF2(request).nfeConsultaNF2Result;
          var x = new XmlDocument();
          x.LoadXml(response.nfeConsultaNF2Result.OuterXml);
          x.Save(@"d:\resp.xml");

          var doc = new DeserializeDocument<RetConsSitNFe>(response.nfeConsultaNF2Result.OuterXml);
          
            RetConsSitNFe ret = doc.Deserialize();

          System.Console.WriteLine(response.nfeConsultaNF2Result.OuterXml);

          System.Console.WriteLine(ret.protNFe.infProt.verAplic);

          System.Console.ReadKey();

          //NFe.Repositories.Clients.NFeStatusServico2SoapClient service = new Repositories.Clients.NFeStatusServico2SoapClient();
          //NFe.Repositories.Response.NFeStatusServicoNF2Response response = new Repositories.Response.NFeStatusServicoNF2Response();
          //NFe.Repositories.Request.NFeStatusServicoNF2Request request = new Repositories.Request.NFeStatusServicoNF2Request(nfeCabMsg, nfeDadosMsg);

          //service.ClientCredentials.ClientCertificate.Certificate = cert.GetCollection()[1];

          //response.nfeStatusServicoNF2Result = service.NFeStatusServicoNF2(request).nfeStatusServicoNF2Result;

          //System.Console.WriteLine(response.nfeStatusServicoNF2Result.OuterXml);

          //System.Console.ReadKey();

          //var _doc = new DeserializeDocument<RetConsStatServ>(response.nfeStatusServicoNF2Result.OuterXml);

          //RetConsStatServ _nfe = _doc.Deserialize();

          //System.Console.WriteLine(_nfe.xMotivo + " Hora:" + _nfe.dhRecbto);

          //System.Console.ReadKey();

        }

    }
}
