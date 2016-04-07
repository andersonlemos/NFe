using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Domain.Entities;
using NFe.Helpers.Services;
using System.Xml;
namespace NFe.Helpers.Test
{
    [TestClass]
    public class DeserializeDocumentTests
    {
      private const string _path=@"D:\Teste.xml";
      private XmlDocument _fileXML;
  
      [TestInitialize]
      public void DeserializeDocument_DeveInstanciarDocumentoXML()
      {
        _fileXML = new XmlDocument();
        _fileXML.Load(_path);

      }

        [TestMethod]
        public void DeserializeDocument_IsDeserialized()
        {

            var _doc = new DeserializeDocument<ConsStatServ>(_fileXML.OuterXml);

             Assert.IsTrue(_doc.IsDeserialized());


        }
        [TestMethod]
        public void DeserializeDocument_Deserialized()
        {

            var _doc = new DeserializeDocument<ConsStatServ>(_fileXML.OuterXml);
            ConsStatServ _nfe = _doc.Deserialize();

          Assert.AreEqual("3.10", _nfe.versao);


        }
    }
}
