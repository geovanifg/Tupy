namespace Tupy.Common
{
    public class ListResponse<TModel> : ExecutionResponse
    {
        public IEnumerable<TModel>? Model { get; set; }

        public ListResponse() : base()
        {

        }

        public ListResponse(bool success, string message) : base(success, message)
        {
        }

        public ListResponse(bool success, string message, IEnumerable<TModel> model) : base(success, message)
        {
            Model = model;
        }

        public static ListResponse<TModel> CreateSuccess(IEnumerable<TModel> model)
        {
            ListResponse<TModel> result = new()
            {
                Model = model
            };
            return result;
        }

        public static new ListResponse<TModel> FromException(Exception ex)
        {
            ListResponse<TModel> result = new()
            {
                Success = false,
                Exception = ex,
                Message = ex.Message
            };

            return result;
        }
    }
}