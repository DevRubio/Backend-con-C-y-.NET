public class LogException : Log
{
    public string ErrorMessage {get; set;}
    public string ErrorDetails {get; set;}
    public Exception Exception{get; set;}

    public LogException(Component component, string errorMessage, string errorDetails, Exception exception)
    {
        Component = component;
        ErrorMessage = errorMessage;
        ErrorDetails = errorDetails;
        Exception = exception;
    }
}