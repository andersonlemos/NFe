using System;

namespace NFe.Helpers.Interfaces
{
    public interface IDeserializeOperation<T> where T :class
    {
      bool Deserialize(string xml, T obj);
      bool Deserialize(string xml, T obj, Exception exception);
      T Deserialize(string xml);
    }
}
