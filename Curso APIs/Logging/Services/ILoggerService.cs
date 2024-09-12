public interface ILoggerService
{
    void SaveException(LogException logException);
    void SaveTrace(LogTrace logTrace);
}