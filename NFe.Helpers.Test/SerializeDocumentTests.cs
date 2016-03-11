using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Helpers.Services;
using NFe.Domain.Entities;
namespace NFe.Helpers.Test
{
   [TestClass]
   public class SerializeDocumentTests
    {

     [TestMethod]
     public void SerializeDocument_IsSerialized()
     {
       var _nfe = new StatusDoServico(); 
       var _doc = new SerializeDocument<StatusDoServico>(_nfe);
       Assert.IsTrue(_doc.IsSerialized());
     }
     [TestMethod]
     public void SerializeDocument_Serialize()
     {
       var _nfe = new StatusDoServico("3.10","1","22","2");
       var _doc = new SerializeDocument<StatusDoServico>(_nfe);
       Assert.AreNotEqual(string.Empty, _doc.Serialize());
     }

    }
}
