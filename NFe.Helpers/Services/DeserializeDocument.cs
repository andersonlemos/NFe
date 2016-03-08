using System;
using NFe.Helpers.Interfaces;
using System.Xml.Serialization;

namespace NFe.Helpers.Services
{
    public class DeserializeDocument<T>:IDeserializeOperation<T>
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

      private bool Deserialize(string xml, T obj)
        {
            System.Exception exception = null;

            return Deserialize(xml, obj, exception);
        }

        private bool Deserialize(string xml, T obj, Exception exception)
        {
            exception = null;
          
            try
            {
                obj = Deserialize();
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;

                return false;
            }
        }

        public virtual T Deserialize()
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader((string)this._document);
                return (T)Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader));
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
