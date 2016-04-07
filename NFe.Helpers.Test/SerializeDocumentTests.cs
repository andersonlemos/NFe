using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Helpers.Services;
using NFe.Domain.Entities;
using NFe.Domain.Entities.Response;
using System;
using System.Globalization;
using System.Xml;
namespace NFe.Helpers.Test
{
   [TestClass]
   public class SerializeDocumentTests
    {

    
     [TestMethod]
     public void SerializeDocument_Serialize()
     {
         var _nfe = new ConsStatServ("3.10",Domain.Entities.Base.Amb.PRODUCAO,Domain.Entities.Base.CodUfIBGE.RIO_DE_JANEIRO,"STATUS");
         var _doc = new SerializeDocument<ConsStatServ>(_nfe);
       Assert.AreNotEqual(string.Empty, _doc.Serialize());
     }

     [TestMethod]
     public void SerializeDocument_ConsSitNFe()
     {

       var _nf = new RetConsSitNFe();
       _nf.tpAmb = Domain.Entities.Base.Amb.HOMOLOGACAO;
       _nf.verAplic = "3.10";
       _nf.cStat = "1";
       _nf.cUF = Domain.Entities.Base.CodUfIBGE.RIO_DE_JANEIRO;
       _nf.dhRecbto = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture);
        
       var _doc = new SerializeDocument<RetConsSitNFe>(_nf);

       Assert.AreNotEqual(null, _doc.Serialize());

     }
     [TestMethod]
     public void SerializeDocument_IsSerialized()
     {
         var _nfe = new ConsStatServ();
         var _doc = new SerializeDocument<ConsStatServ>(_nfe);
         Assert.IsTrue(_doc.IsSerialized());
     }
    }
}
