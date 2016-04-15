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
            var download = new DownloadNFe();

            download.chNFe = "33160268643105000100550010000167591000000000";
            download.CNPJ = "68643105000100";
            download.tpAmb = Amb.PRODUCAO;
            download.versao = "1.00";
            download.xServ = "DOWNLOAD NFE";

            var xmlDownload = new XmlDocument();

            var xmlSerialized = new SerializeDocument<DownloadNFe>(download);
            
            xmlDownload.LoadXml(xmlSerialized.Serialize());

            System.Console.WriteLine(xmlDownload.InnerXml);

            //Repositories.DownloadNFe.NfeDownloadNFSoapClient service = new Repositories.DownloadNFe.NfeDownloadNFSoapClient();

            Repositories.Clients.NFeStatusServico2SoapClient service = new Repositories.Clients.NFeStatusServico2SoapClient();
            Repositories.Context.NFeStatusServicoContext.

            //Repositories.DownloadNFe.nfeCabecMsg cabecalho = new Repositories.DownloadNFe.nfeCabecMsg { cUF = "33", versaoDados = "1.00" };

            //Repositories.DownloadNFe.nfeDownloadNFRequest request = new Repositories.DownloadNFe.nfeDownloadNFRequest(cabecalho, (XmlNode)xmlDownload);

            //Repositories.DownloadNFe.nfeDownloadNFResponse response = new Repositories.DownloadNFe.nfeDownloadNFResponse();

            var certificate = new Certificate();
            
            service.ClientCredentials.ClientCertificate.Certificate= certificate.GetCollection()[1];

            response.nfeDownloadNFResult = service.nfeDownloadNF(request.nfeCabecMsg, request.nfeDadosMsg);


            System.Console.WriteLine(response.nfeDownloadNFResult.InnerXml);
            System.Console.ReadKey();





        }

    }
}
