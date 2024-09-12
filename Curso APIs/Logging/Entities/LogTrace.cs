public class LogTrace: Log
{
    public string Method {get; set;}
    public string TraceDetails {get; set;}

    public LogTrace(Component component, string method, string traceDetails)
    {
        Component = component;
        Method = method;
        TraceDetails = traceDetails;
    }
}