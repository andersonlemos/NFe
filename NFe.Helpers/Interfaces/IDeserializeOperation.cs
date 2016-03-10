
namespace NFe.Helpers.Interfaces
{
    public interface IDeserializeOperation<T> 
    {
      bool IsDeserialized();
      T Deserialize();
    }
}
