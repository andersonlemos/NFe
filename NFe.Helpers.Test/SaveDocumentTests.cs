using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFe.Domain;
using NFe.Helpers.Services;

namespace NFe.Helpers.Test
{
    [TestClass]
    public class SaveDocumentTests
    {
        [TestMethod]
        public void SaveDocument_WasSaved()
        {
          var _file = new SaveDocument("", @"D:\teste.txt");
          Assert.IsTrue(_file.WasSaved());
        }
        [TestMethod]
        public void SaveDocument_Save()
        {
            var _file = new SaveDocument("", @"D:\save.txt");
            _file.SaveToFile();
            var _io = new System.IO.FileInfo(@"D:\save.txt");
            
            Assert.IsTrue(_io.Exists);
        }
    }
}
