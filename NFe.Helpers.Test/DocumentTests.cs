using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Domain.Entities;
using System.Xml;
namespace NFe.Helpers.Test
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void Document_Get_Type()
        {
          StatusDoServico nfe = new StatusDoServico("3.10","1","2","2");
        
          DocumentNFe<StatusDoServico> servico = new DocumentNFe<StatusDoServico>(nfe);
          Assert.AreEqual(typeof(string), servico.Serialize().GetType());

       }
      [TestMethod]
      public void Document_IsSerialized()
      {
        StatusDoServico nfe = new StatusDoServico("3.10", "1", "22", "1");
        DocumentNFe <StatusDoServico> servico= new DocumentNFe<StatusDoServico>(nfe);

        Assert.IsFalse(servico.IsSerialized());


      }
        
      [TestMethod]
        public void Document_Save_To_FIle()
        {
            StatusDoServico nfe = new StatusDoServico("3.10", "1", "22", "1");
            DocumentNFe<StatusDoServico> servico = new DocumentNFe<StatusDoServico>(nfe);
     
            servico.SaveAS(servico.Serialize(),"D:/Teste.xml");
            Assert.Inconclusive("Inconclusive",null);


        }

        [TestMethod]
        public void Document_Deserialize()
        {
        
            XmlDocument oXML = new XmlDocument();
         
            string ArquivoXML = "D:/Teste.xml";
            
            oXML.Load(ArquivoXML);

            DocumentNFe<StatusDoServico> servico = new DocumentNFe<StatusDoServico>(oXML.OuterXml);
            StatusDoServico nfe = servico.Deserialize();

            Assert.AreEqual("3.10", nfe.versao);


        }
    }
}
