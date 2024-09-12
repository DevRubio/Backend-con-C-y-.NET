
public class LoggerService : ILoggerService
{
    private readonly ILogger<LoggerService> _logger;

    public LoggerService(ILogger<LoggerService> logger)
    {
        _logger = logger;
    }

    public void SaveException(LogException logException)
    {
        _logger.LogError($"Componen: {logException.Component}, Error {logException.ErrorMessage}, Details: {logException.ErrorDetails}, {logException.Exception}");
    }

    public void SaveTrace(LogTrace logTrace)
    {
        _logger.LogInformation($"Component: {logTrace.Component}, Method: {logTrace.Method}; Trace: {logTrace.TraceDetails}");
    }
}