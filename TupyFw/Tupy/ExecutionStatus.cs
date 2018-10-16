namespace Tupy
{
    public class ExecutionStatus : ExecutionStatusBase
    {
        public ExecutionStatus(bool success) : base(success)
        {
        }

        public string Data { get; set; }
    }
}
