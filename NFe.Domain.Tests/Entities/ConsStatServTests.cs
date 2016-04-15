using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Domain.Entities;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Tests.Entities
{
    [TestClass]
    public class ConsStatServTests
    {
        [TestMethod]
        public void ConsStatServ_TestDocument()
        {
          var cns = new ConsStatServ();
          
          
          cns.tpAmb = Amb.PRODUCAO;
          cns.versao = "3.10";
          cns.xServ = "STATUS";

          Assert.AreEqual(Amb.PRODUCAO, cns.tpAmb);

        }
    }
}
