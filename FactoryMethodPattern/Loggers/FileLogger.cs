namespace FactoryMethodPattern.Loggers;

public class FileLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"FileLogger: {message}");
    }
}