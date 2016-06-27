using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using NFe.Domain.Entities;
using NFe.Domain.Entities.Base;
using NFe.Domain.Entities.Request;
using NFe.Domain.Entities.Response;
using NFe.Helpers.Interfaces;
using NFe.Helpers.Services;
using NFe.Repositories.Entities;
using System.Xml;
using System.Xml.Schema;
using NFe.Repositories.Repositories;
using NFe.Repositories.Request;
using NFe.Repositories.Response;


namespace NFe.Console
{
    class Program
    {
     
        static void Main(string[] args)
        {

            //var cabecalho = new Domain.Entities.ConsStatServ();
           // cabecalho.cUF = CodUfIBGE.RIO_DE_JANEIRO;
            //cabecalho.tpAmb = Amb.HOMOLOGACAO;
            //cabecalho.versao = VersaoNFe.Versao_3_10;
            //cabecalho.xServ = XServOptions.CONSULTAR_STATUS_SERVICO;


            //var document = new SerializeDocument<ConsStatServ>(cabecalho);
            //var xmlDoc = new XmlDocument();

            //xmlDoc.LoadXml(document.Serialize());

            //var service = new Repositories.Clients.NFeStatusServico2SoapClient();
            //var req = new NFeStatusServicoNF2Request(new NFeCabecMsg() { CUf = CodUfIBGE.RIO_DE_JANEIRO, VersaoDados = VersaoNFe.Versao_3_10 }, xmlDoc);
            //var res = new NFeStatusServicoNF2Response();

            //service.ClientCredentials.ClientCertificate.Certificate = new Certificate().GetCollection()[1];

            //res.nfeStatusServicoNF2Result = service.NFeStatusServicoNF2(req.nfeCabecMsg, (XmlDocument)req.nfeDadosMsg);

            //var des = new DeserializeDocument<RetConsStatServ>(res.nfeStatusServicoNF2Result.OuterXml);

            //var saveDoc = new XmlDocument();
            //saveDoc.LoadXml(res.nfeStatusServicoNF2Result.OuterXml);
            //saveDoc.Save("d:/teste.xml");

            //RetConsStatServ StatServ = des.Deserialize();


            //System.Console.WriteLine(res.nfeStatusServicoNF2Result.OuterXml);
            //System.Console.WriteLine(StatServ.xMotivo);
            //System.Console.ReadKey();


            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var cabecalho = new Domain.Entities.Request.ConsNFeDest();
        
            cabecalho.versao =VersaoNFe.Versao_1_01;
            


            var document = new SerializeDocument<ConsNFeDest>(cabecalho);
            var xml = new XmlDocument();

            xml.LoadXml(document.Serialize());

            System.Console.WriteLine(xml.OuterXml);
            System.Console.WriteLine("=============================================================================");

            var service = new Repositories.Repositories.NFeConsultaDestSoapClient();
            var req = new Repositories.Repositories.nfeConsultaNFDestRequest(new nfeCabecMsg() { cUF = "33", versaoDados = "1.01" }, xml);
            var res = new Repositories.Repositories.nfeConsultaNFDestResponse();

            
            service.ClientCredentials.ClientCertificate.Certificate = new Certificate().GetCollection()[1];
            res.nfeConsultaNFDestResult = service.nfeConsultaNFDest(req.nfeCabecMsg, (XmlDocument)req.nfeDadosMsg);

            var des = new DeserializeDocument<RetConsNFeDest>(res.nfeConsultaNFDestResult.OuterXml);

            RetConsNFeDest dest = des.Deserialize();
            
            
      
            System.Console.WriteLine(res.nfeConsultaNFDestResult.OuterXml);
            stopwatch.Stop();
            System.Console.WriteLine("Tempo passado em Milisegundos: " + stopwatch.ElapsedMilliseconds );
            
            System.Console.WriteLine();

            System.Console.ReadKey();

        }

    }
}
