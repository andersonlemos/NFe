using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Threading.Tasks;
using NFe.Domain.Entities;
using NFe.Domain.Entities.Base;
using NFe.Domain.Entities.Response;
using NFe.Helpers.Interfaces;
using NFe.Helpers.Services;
using NFe.Repositories.Entities;
using System.Xml;
using System.Xml.Schema;
using NFe.Domain.Entities.NFeDoc;
using NFe.Repositories.ConsultaProtocolo;
using NFe.Repositories.Repositories;
using NFe.Repositories.Request;
using NFe.Repositories.Response;
using NFe.Domain.Entities.NFeDoc;
using NFe.Domain.Entities.NFeDoc;

namespace NFe.Console
{
    class Program
    {
     
        static void Main(string[] args)
        {

            var xml = new XmlDocument();

            xml.Load("d:/nota01.xml");

           

            var arquivo = new DeserializeDocument<NFeProc>(xml.OuterXml);
            NFeProc nfe = arquivo.Deserialize();

            byte[] dBytes = nfe.Nfe.signature.SignedInfo.Reference.DigestValue;
            string s3 = Convert.ToBase64String(nfe.Nfe.signature.SignedInfo.Reference.DigestValue);  // gsjqFw==
            
            
            //System.Console.WriteLine(nfe.Nfe);
            System.Console.WriteLine(nfe.Nfe.signature.SignedInfo.Reference.URI);
            System.Console.WriteLine(s3);
            System.Console.ReadKey();

        }

    }
}
