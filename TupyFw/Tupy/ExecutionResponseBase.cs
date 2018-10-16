namespace Tupy
{
    public abstract class ExecutionResponseBase
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }        
        public int StatusCode { get; set; }
        public string Source { get; set; }

        public ExecutionResponseBase() : this(true)
        {

        }

        public ExecutionResponseBase(bool success) : this(success, null)
        {

        }

        public ExecutionResponseBase(bool success, string message)
        {
            IsSuccess = success;
            Message = message;
        }
    }
}
