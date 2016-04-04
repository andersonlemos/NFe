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
          
          cns.cUF = TCodUfIBGE.RIO_DE_JANEIRO;
          cns.tpAmb = TAmb.PRODUCAO;
          cns.versao = "3.10";
          cns.xServ = "STATUS";

          Assert.AreEqual(TAmb.PRODUCAO, cns.tpAmb);

        }
    }
}
