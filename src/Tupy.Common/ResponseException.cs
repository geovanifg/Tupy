namespace Tupy.Common
{
    public class ResponseException : Exception
    {
        public IExecutionResponse Response { get; private set; }

        //private static string FormatarMessage(string message, IExecutionResponse response)
        //{
        //    string result = "";

        //    if (string.IsNullOrEmpty(message) == false)
        //        result = message;

        //    if (response?.Message != result)
        //        result += " " + response?.Message;

        //    if (result == "")
        //        result = "N/D";

        //    return result;
        //}

        public ResponseException(string message) : base(message)
        {
            Response = new ExecutionResponse(false, message);
        }

        //public ResponseException(IExecutionResponse response) : base(response?.Message ?? "N/D", response?.Exception)
        //{
        //    Response = response;
        //}

        //public ResponseException(IExecutionResponse response, string message) : base(FormatarMessage(message, response), response?.Exception)
        //{
        //    Response = response;
        //}
    }
}
