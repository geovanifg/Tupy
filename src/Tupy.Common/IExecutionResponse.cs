namespace Tupy.Common
{
    public interface IExecutionResponse
    {
        bool Success { get; set; }
        string? Message { get; set; }
        int? ErrorNumber { get; set; }
        Exception? Exception { get; set; }
        bool HasMultipleErrors { get; }
        List<string> ErrorMessages { get; set; }
    }
}