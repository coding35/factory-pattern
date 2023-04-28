namespace FactoryMethodPattern.Loggers;

public class DatabaseLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"DatabaseLogger: {message}");
    }
}