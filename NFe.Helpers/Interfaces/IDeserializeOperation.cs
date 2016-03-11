using System;
namespace NFe.Helpers.Interfaces
{
    public interface IDeserializeOperation<T> where T:class
    {
      bool IsDeserialized();
      T Deserialize();
    }
}
