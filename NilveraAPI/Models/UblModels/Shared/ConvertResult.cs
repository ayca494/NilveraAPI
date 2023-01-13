namespace NilveraAPI.Models.UblModels.Shared
{
    public class ConvertResult<TUbl, TModel>
    {
        public TUbl UblModel { get; set; }
        public TModel Model { get; set; }
        public string ErrorDescription { get; set; }
        public bool IsSuccess { get; set; }
        public string XMLContent { get; set; }
    }
}
