using NFe.Helpers.Services;
using NFe.Helpers.Interfaces;

namespace NFe.Helpers
{
    public class DocumentNFe<T> where T:class, IDocumentOperation<T>
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
      public bool IsDeserialized()
      {
        return new DeserializeDocument<T>(this._document).IsDeserialized();
      }

      public bool IsSerialized()
      {
        return new SerializeDocument<T>(this._document).IsSerialized();
      }
      public virtual T Deserialize()
      {
         return  new DeserializeDocument<T>(this._document).Deserialize();
      }

      public virtual void SaveAS(object obj,string fileName)
      {
         var file = new SaveDocument(obj, fileName);

         file.SaveToFile(new System.Exception("Erro no Salvamento"));
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

