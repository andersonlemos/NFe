using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Helpers.Services;
namespace NFe.Helpers.Test
{
    [TestClass]
    public class CertificateTests
    {
       
        [TestMethod]
        public void Certificates_NumberOfCertificates()
        {
          
          var c = new Certificate();

          Assert.AreEqual(2, c.GetCollection().Count);

        }
    }
}
