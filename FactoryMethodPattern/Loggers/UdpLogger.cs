namespace FactoryMethodPattern.Loggers;

public class UdpLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"UdpLogger: {message}");
    }
}