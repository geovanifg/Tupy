namespace Tupy.Common
{
    public class SingleResponse<TModel> : ExecutionResponse
    {
        public TModel? Model { get; set; }

        public SingleResponse() : base()
        {

        }

        public SingleResponse(bool success, string message) : base(success, message)
        {
        }

        public SingleResponse(bool success, string message, TModel model) : base(success, message)
        {
            Model = model;
        }
    }
}