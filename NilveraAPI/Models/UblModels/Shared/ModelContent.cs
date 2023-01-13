
namespace NilveraAPI.Models.UblModels.Shared
{
    public class ModelContent<T>
    {
        public string XmlContent { get; set; }

        public T Model { get; set; }
    }
}
