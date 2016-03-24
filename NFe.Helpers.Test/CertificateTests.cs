using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Helpers.Services;
namespace NFe.Helpers.Test
{
    [TestClass]
    public class CertificateTests
    {

      private Certificate _certificate;

   
      [TestMethod]
        public void Certificates_NumberOfCertificates()
        {
            _certificate = new Certificate();
          Assert.AreEqual(2, _certificate.GetCollection().Count);

        }

        [TestMethod]
        public void Certificates_NameOfCertificate()
        {
            _certificate = new Certificate();
          Assert.IsTrue(_certificate.GetCollection()[1].FriendlyName.Contains("DMO"));

        }
    }
}
