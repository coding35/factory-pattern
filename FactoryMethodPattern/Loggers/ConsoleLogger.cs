namespace FactoryMethodPattern.Loggers;

public class ConsoleLogger : Logger
{
    private readonly Configuration _configurationFactory;
    
    public ConsoleLogger(ConfigurationFactory configurationFactory)
    {
        _configurationFactory = configurationFactory.GetConfiguration(LoggerType.Console);
    }

    public override void Log(string message)
    {
        Console.ForegroundColor = ((ConsoleConfiguration)_configurationFactory).ForeGroundColor;
        Console.BackgroundColor = ((ConsoleConfiguration)_configurationFactory).BackGroundColor;
        Console.WriteLine($"ConsoleLogger: {message}");
    }
}