using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Domain.Entities.Response;

namespace NFe.Domain.Tests.Entities
{

    [TestClass]
    public class RetConsStatServTests
    {
        [TestMethod]
        public void RetConsStatServ_TestDocument()
        {

          var ret = new RetConsStatServ("3,10",Domain.Entities.Base.TAmb.PRODUCAO,"1.00","1.00","2","Teste","33","33","2");

          Assert.IsNotNull(ret);

        }
    }
}


