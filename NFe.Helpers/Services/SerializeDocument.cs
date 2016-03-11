using System.IO;
using System.Xml.Serialization;
using NFe.Helpers.Interfaces;

namespace NFe.Helpers.Services
{
  public class SerializeDocument<T> : ISerializeOperation 
  {
    private object _document;
    private static XmlSerializer _serializer;
    private static MemoryStream _memoryStream;
    private static StreamReader _streamReader;


    private static MemoryStream MemoryStream
      {
          get
          {
              if ((_memoryStream == null)) _memoryStream = new MemoryStream();
              return _memoryStream;
          }
      }

    private static XmlSerializer Serializer
      {
          get
          {
              if ((_serializer == null)) _serializer = new XmlSerializer(typeof(T));
              return _serializer;
          }
      }

    public SerializeDocument(object document)
    {
      this._document = document;
    }
    
    public SerializeDocument()
      {

      }

    public bool IsSerialized()
    {
        string obj;
        try
        {
            obj = this.Serialize();
            return true;
        }
        catch
        {
            return false;
        }

    }
    public string Serialize()
      {
         
          try
          {

              Serializer.Serialize(MemoryStream, this._document);

              MemoryStream.Seek(0, System.IO.SeekOrigin.Begin);

              _streamReader = new System.IO.StreamReader(MemoryStream);

              return _streamReader.ReadToEnd();
          }
          finally
          {
              if ((((_streamReader) != null)))
              {
                  _streamReader.Dispose();
              }
              if ((((MemoryStream) != null)))
              {
                  MemoryStream.Dispose();
              }
          }
      }

  }
}
