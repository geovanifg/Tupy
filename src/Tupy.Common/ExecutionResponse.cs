namespace Tupy.Common
{
    public class ExecutionResponse : IExecutionResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public int? ErrorNumber { get; set; }
        public Exception? Exception { get; set; }
        public List<string> ErrorMessages { get; set; } = [];
        public bool HasMultipleErrors => ErrorMessages?.Count > 0;

        public ExecutionResponse()
        {
            Success = true;
            Message = null;
        }

        public ExecutionResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static ExecutionResponse FromResponseException(ResponseException ex)
        {
            return new ExecutionResponse
            {
                Success = false,
                Message = ex.Message,
                Exception = ex.InnerException
            };
        }

        public static ExecutionResponse FromException(Exception ex)
        {
            ExecutionResponse result = new()
            {
                Success = false,
                Exception = ex,
                Message = ex.Message
            };

            return result;
        }

        public static ExecutionResponse FromException(Exception ex, string message)
        {
            ExecutionResponse result = new()
            {
                Success = false,
                Exception = ex,
                Message = message
            };

            return result;
        }
    }
}