namespace Tupy
{
    public abstract class ExecutionStatusBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public ExecutionStatusBase()
        {

        }

        public ExecutionStatusBase(bool success) : this()
        {
            Success = success;
        }

        public ExecutionStatusBase(bool success, string message) : this(success)
        {
            Message = message;
        }
    }
}
