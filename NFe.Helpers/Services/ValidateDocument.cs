using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace NFe.Helpers.Services
{
    public class ValidateDocument
    {

      public ValidateDocument(string schema,string xmlFile)
      {

          XmlReaderSettings booksSettings = new XmlReaderSettings();
          booksSettings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", schema);
          booksSettings.ValidationType = ValidationType.Schema;
          booksSettings.ValidationEventHandler += new ValidationEventHandler(booksSettingsValidationEventHandler);

          XmlReader books = XmlReader.Create(xmlFile, booksSettings);

          while (books.Read()) { }

      }




      static void booksSettingsValidationEventHandler(object sender, ValidationEventArgs e)
      {
          if (e.Severity == XmlSeverityType.Warning)
          {
              Console.Write("WARNING: ");
              Console.WriteLine(e.Message);
          }
          else if (e.Severity == XmlSeverityType.Error)
          {
              Console.Write("ERROR: ");
              Console.WriteLine(e.Message);
          }
      }




    }
}
