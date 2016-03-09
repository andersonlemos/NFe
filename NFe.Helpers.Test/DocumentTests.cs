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
        public void DocumentocomConteudoEmBranco()
        {
          StatusDoServico nfe = new StatusDoServico("3.10","1","2","2");
          //DocumentNFe<StatusDoServico> servico = new DocumentNFe<StatusDoServico>(nfe);
          DocumentNFe<StatusDoServico> servico = new DocumentNFe<StatusDoServico>(nfe);
          Assert.AreEqual(typeof(string), servico.Serialize().GetType());

        }

        [TestMethod]
        public void DocumentocomConteudoSaveToFile()
        {
            StatusDoServico nfe = new StatusDoServico("3.10", "1", "22", "1");
            DocumentNFe<StatusDoServico> servico = new DocumentNFe<StatusDoServico>(nfe);
            //servico.SaveToFile("d:/teste.xml");
            servico.SaveAS(servico.Serialize(),"D:/Teste.xml");
            Assert.Inconclusive("Inconclusive",null);


        }
    }
}
