public class HelloworldService : IHelloWordService
{
    public string GetHelloWorld()
    {
        return "Hello word";
    }
}

public interface IHelloWordService
{
    string GetHelloWorld();
}