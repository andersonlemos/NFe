using System;
using NFe.Helpers.Interfaces;
using System.Xml.Serialization;

namespace NFe.Helpers.Services
{
    public class DeserializeDocument<T>:IDeserializeOperation<T> where T:class
    {
        private object _document;
        private static XmlSerializer _serializer;
      
        private static XmlSerializer Serializer
        {
            get
            {
                if ((_serializer == null)) _serializer = new XmlSerializer(typeof(T));
                return _serializer;
            }
        }


      public DeserializeDocument()
      {

      }

      public DeserializeDocument(object document)
      {
        this._document = document;
      }

      public bool IsDeserialized()
      {
        
          object obj ;

          try
          {
            obj = this.Deserialize();

              return true;
          }
          catch 
          {
           return false;
          }
      }

      public virtual T Deserialize()
      {
          System.IO.StringReader stringReader = null;

          try
          {
              stringReader = new System.IO.StringReader((string)this._document);
             
              return (T) Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
          }
          finally
          {
              if ((((stringReader) != null)))
              {
                  stringReader.Dispose();
              }
          }
      }

    
    }
}
