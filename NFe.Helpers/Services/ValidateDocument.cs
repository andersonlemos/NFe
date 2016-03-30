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

      private const string _namespace = "http://www.portalfiscal.inf.br/nfe";
      
      private XmlReaderSettings _xmlSettings;
      private XmlReader _file;

      private string _warnings;
  
      public ValidateDocument(string schema,string xmlFile)
      {
          _xmlSettings = new XmlReaderSettings();

          _xmlSettings.Schemas.Add(_namespace, schema);
          _xmlSettings.ValidationType = ValidationType.Schema;
          _xmlSettings.ValidationEventHandler += new ValidationEventHandler(fileValidationEventHandler);

          _file = XmlReader.Create(xmlFile, _xmlSettings);
         
           while (_file.Read()) { }

      }
      
      void fileValidationEventHandler(object sender, ValidationEventArgs e)
      {
          if (e.Severity == XmlSeverityType.Warning || e.Severity == XmlSeverityType.Error)
          {
            _warnings = _warnings + (e.Message + "-" + e.Severity);
          }
         
      }

      public string Validate()
      {
        return _warnings;
      }

      public bool IsValid()
      {
        if (_warnings == string.Empty)
        {
          return true;
        }
        return false;

      }
    }
}
