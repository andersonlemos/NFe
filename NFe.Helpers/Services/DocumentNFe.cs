using NFe.Helpers.Services;
using NFe.Helpers.Interfaces;

namespace NFe.Helpers
{
    public class DocumentNFe<T>where T:class , IDocumentOperation<T>
    {
      private object _document;
      
      public DocumentNFe()
      {
      }

      public DocumentNFe(object document)
      {
          this._document = document;
      }


      public virtual string Serialize()
      {
          return new SerializeDocument<T>(this._document).Serialize();
      }

      public virtual T Deserialize()
      {
        return new DeserializeDocument<T>(this._document).Deserialize();
      }


      public virtual bool SaveToFile(string fileName, ref System.Exception exception)
      {
          exception = null;
          try
          {
              SaveToFile(fileName);
              return true;
          }
          catch (System.Exception e)
          {
              exception = e;
              return false;
          }
      }

      public virtual void SaveToFile(string fileName)
      {
          System.IO.StreamWriter streamWriter = null;
          try
          {
              string xmlString = Serialize();
              System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
              streamWriter = xmlFile.CreateText();
              streamWriter.WriteLine(xmlString);
              streamWriter.Close();
          }
          finally
          {
              if ((((streamWriter) != null)))
              {
                  streamWriter.Dispose();
              }
          }
      }

      //public static bool LoadFromFile(string fileName, T obj, System.Exception exception)
      //{
      //    exception = null;
      //    obj = (T)null;
      //    try
      //    {
      //        obj = LoadFromFile(fileName);
      //        return true;
      //    }
      //    catch (System.Exception ex)
      //    {
      //        exception = ex;
      //        return false;
      //    }
      //}

      //public static bool LoadFromFile(string fileName, ref T obj)
      //{
      //    System.Exception exception = null;
      //    return LoadFromFile(fileName, obj, exception);
      //}

      //public static T LoadFromFile(string fileName)
      //{
      //    System.IO.FileStream file = null;
      //    System.IO.StreamReader sr = null;
      //    try
      //    {
      //        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
      //        sr = new System.IO.StreamReader(file);

      //        string xmlString = sr.ReadToEnd();

      //        sr.Close();
      //        file.Close();

      //        return Deserialize(xmlString);
      //    }
      //    finally
      //    {
      //        if ((((file) != null)))
      //        {
      //            file.Dispose();
      //        }
      //        if ((((sr) != null)))
      //        {
      //            sr.Dispose();
      //        }
      //    }
      //}
      
    }

}

