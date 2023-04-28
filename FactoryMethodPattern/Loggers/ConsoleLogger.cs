namespace FactoryMethodPattern.Loggers;

public class ConsoleLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"ConsoleLogger: {message}");
    }
}